using GiJoStock;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AFPrinting.Report
{
    public static class ReportManager
    {
        public static bool Print(LocalReport report, PrintDocument printDocument)
        {
            string deviceInfo =
                $@"<DeviceInfo>
                    <OutputFormat>EMF</OutputFormat>
                    <PageWidth>{printDocument.DefaultPageSettings.PaperSize.Width * 100}in</PageWidth>
                    <PageHeight>{printDocument.DefaultPageSettings.PaperSize.Height * 100}in</PageHeight>
                    <MarginTop>{printDocument.DefaultPageSettings.Margins.Top * 100}in</MarginTop>
                    <MarginLeft>{printDocument.DefaultPageSettings.Margins.Left * 100}in</MarginLeft>
                    <MarginRight>{printDocument.DefaultPageSettings.Margins.Right * 100}in</MarginRight>
                    <MarginBottom>{printDocument.DefaultPageSettings.Margins.Bottom * 100}in</MarginBottom>
                </DeviceInfo>";

            List<Stream> _streams = new List<Stream>();
            int _currentPageIndex = 0;

            report.Render("Image", deviceInfo, (name, fileNameExtension, encoding, mimeType, willSeek) =>
            {
                MemoryStream stream = new MemoryStream();
                _streams.Add(stream);
                return stream;
            }, out Warning[] warnings);

            if (_streams == null || _streams.Count == 0)
            {
                throw new Exception("Error: no stream to print.");
            }

            foreach (Stream stream in _streams)
            {
                stream.Position = 0;
            }

            printDocument.PrintPage += (sender, e) =>
            {
                Metafile pageImage = new Metafile(_streams[_currentPageIndex]);

                int x = e.PageBounds.Left - (int)e.PageSettings.HardMarginX;
                int y = e.PageBounds.Top - (int)e.PageSettings.HardMarginY;

                x += 0;
                y += 10;

                int w = e.PageBounds.Width;
                int h = e.PageBounds.Height;

                Rectangle adjustedRect = new Rectangle(x, y, w, h);

                e.Graphics.DrawImage(pageImage, adjustedRect);
                _currentPageIndex++;
                e.HasMorePages = (_currentPageIndex < _streams.Count - 1);
            };

            bool printResult = false;

            printDocument.EndPrint += (Sender, e) =>
            {
                if (_streams != null)
                {
                    foreach (Stream stream in _streams)
                    {
                        stream.Close();
                    }

                    _streams = null;
                }

                printResult = !e.Cancel;
            };

            printDocument.Print();

            return printResult;
        }

        public static ReportParameter[] GetReportParameters(Entry entry)
        {
            ReportParameter[] parameters = new ReportParameter[4];

            parameters[0] = new ReportParameter("Fecha", entry.Date.ToString("dd-MM-yyyy hh:mm: tt", CultureInfo.InvariantCulture));
            parameters[1] = new ReportParameter("AcuseNo", entry.ToString());
            parameters[2] = new ReportParameter("TotalCarnet", entry.Items.ToString());
            parameters[3] = new ReportParameter("User", entry.User?.ToString());

            return parameters;
        }

        public static ReportParameter[] GetReportInvoiceParameters(Invoice invoice)
        {
            var paramMap = new Dictionary<string, string>();

            paramMap["Date"] = invoice.Date.ToString("dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture);
            paramMap["InvoiceID"] = invoice.ToString();
            paramMap["TotalItems"] = invoice.Items.ToString();

            paramMap["CustomerText"] = invoice.Supplier.Phone + "\n" + invoice.Supplier.Address + "\n" + invoice.Supplier.Email; ;
            paramMap["CustomerRNC"] = invoice.Supplier.Document;
            paramMap["CustomerName"] = invoice.Supplier.Name;

            var itebis = ((invoice.Amount * 18.00M) / 100.00M);
            paramMap["TotalRD"] = string.Format("RD$ {0:#,0.00}", invoice.Amount + itebis);
            paramMap["SubTotal"] = string.Format("RD$ {0:#,0.00}", invoice.Amount);
            paramMap["ITEBIS"] = string.Format("RD$ {0:#,0.00}", itebis);

            paramMap["Method"] = invoice.PaymentMethod;
            paramMap["Reference"] = invoice.Reference;
            paramMap["Observations"] = invoice.Observations;

            return paramMap.Select(x => new ReportParameter(x.Key, x.Value)).ToArray();
        }

        public static ReportParameter[] GetReportReportParameters(List<Product> products, Warehouse warehouse)
        {
            var paramMap = new Dictionary<string, string>();

            paramMap["Date"] = DateTime.Now.ToString("dd-MM-yyyy hh:mm tt", CultureInfo.InvariantCulture);
            paramMap["WarehouseName"] = warehouse.ToString();
            paramMap["WarehouseAddress"] = warehouse.Address;
            paramMap["WarehousePhone"] = warehouse.Phone;
            paramMap["TotalItems"] = products.Count.ToString();
            paramMap["User"] = "admin";

            return paramMap.Select(x => new ReportParameter(x.Key, x.Value)).ToArray();
        }

        /// <summary>
        /// Método que imprime un acuse y luego guarda un Log con los datos de este acuse.
        /// </summary>
        /// <param name="acuse">acuse a imprimir.</param>
        /// <returns>retorno <see cref="bool.TrueString"/> en caso de que la imprisión finalize correctamente, en caso contrario retorna <see cref="bool.FalseString"/>.</returns>
        public static void RunEntry(Entry entry, PrintDocument document = null)
        {
            if (document == null)
            {
                document = new PrintDocument();
                document.PrintController = new StandardPrintController();
                document.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            }

            document.DefaultPageSettings.Margins = new Margins { Bottom = 0, Left = 0, Right = 0, Top = 0 };

            var report = new LocalReport();
            report.ReportEmbeddedResource = "GiJoStock.Report.Acuse.rdlc";

            ReportParameter[] parameters = GetReportParameters(entry);
            report.SetParameters(parameters);

            foreach (var item in entry.EntryItems)
            {
                item.PriceIN = item.Product.PriceOUT;
                item.Name = item.Product.Name;
            }

            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("DataSet1", entry.EntryItems));

            Print(report, document);
        }

        public static void RunInvoice(Invoice invoice, PrintDocument document = null)
        {
            if (document == null)
            {
                document = new PrintDocument();
                document.PrintController = new StandardPrintController();
                document.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            }
            document.DefaultPageSettings.Margins = new Margins { Bottom = 0, Left = 0, Right = 0, Top = 0 };

            var report = new LocalReport();
            report.ReportEmbeddedResource = "GiJoStock.Report.Factura.rdlc";

            ReportParameter[] parameters = GetReportInvoiceParameters(invoice);
            report.SetParameters(parameters);

            foreach (var item in invoice.InvoiceItems)
            {
                item.PriceOUT = item.Product.PriceOUT;
                item.Name = item.Product.Name;
            }

            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("DataSet1", invoice.InvoiceItems));

            Print(report, document);
        }

        public static void RunPhysicalInventory(List<Product> products, Warehouse warehouse, PrintDocument document = null)
        {
            if (document == null)
            {
                document = new PrintDocument();
                document.PrintController = new StandardPrintController();
                document.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            }
            document.DefaultPageSettings.Margins = new Margins { Bottom = 0, Left = 0, Right = 0, Top = 0 };

            var report = new LocalReport();
            report.ReportEmbeddedResource = "GiJoStock.Report.Rpt.rdlc";

            ReportParameter[] parameters = GetReportReportParameters(products, warehouse);
            report.SetParameters(parameters);

            //foreach (var item in invoice.InvoiceItems)
            //{
            //    item.PriceOUT = item.Product.PriceOUT;
            //    item.Name = item.Product.Name;
            //}

            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("DataSet1", products));

            Print(report, document);
        }
    }
}