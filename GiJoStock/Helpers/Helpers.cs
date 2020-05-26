using GiJoStock.Repositories;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static MetroFramework.Controls.MetroTextBox;

namespace GiJoStock
{
    public static class Helpers
    {
        public static DialogResult ShowDialog(this Exception exception, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            return ShowDialog(exception.Message, icon: icon);
        }
        public static DialogResult ShowDialog(string msg, MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            var title = icon == MessageBoxIcon.Error ? " Error" : string.Empty;
            return MessageBox.Show(msg, $"GiJoStock{title}", button, icon);
        }
        public static void Start(this MetroProgressSpinner spinner)
        {
            spinner.Visible = true;
            spinner.Value = 50;
        }
        public static void Stop(this MetroProgressSpinner spinner)
        {
            spinner.Visible = false;
            spinner.Value = 100;
        }
        public static void HasEnterKey(this MetroTextBox textBox, ButClick TxtInStock_ButtonClick)
        {
            textBox.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxtInStock_ButtonClick(sender, e);
                }
            };
        }
        public static void OnlyNumber(this Control control)
        {
            control.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }
        public static Image GetImage(byte[] data)
        {
            // Asignar la imagen del producto.
            return Image.FromStream(new MemoryStream(data));
        }
        public static byte[] GetByteImage(Image image)
        {
            // Asignar la imagen del producto.
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        #region Mantenimiento
        public static void CellContentClick<TSource, TForm>(this DataGridView gridView)
            where TForm : Form, IForm<TSource>, IFormEvents, new()
            where TSource : BaseEntity, IDisable
        {
            gridView.CellContentClick += delegate (object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                var controller = GetController<TSource>();
                string column = gridView.Columns[e.ColumnIndex]?.Name;

                if (column == $"col_{controller}_detail")
                {
                    if (typeof(TSource) == typeof(User) && !UserRepository.LoggedUser.HasPrivilege(Privilege.EditUser))
                    {
                        ShowDialog("Este usuario no tiene privilegio para realizar esta operación", icon: MessageBoxIcon.Warning);
                        return;
                    }

                    try
                    {
                        var view = gridView.Rows[e.RowIndex].DataBoundItem as DataRowView;
                        var source = view["Source"] as TSource;

                        var form = new TForm();
                        form.OnUpdate += delegate (object updated, EventArgs args)
                        {
                            UpdateRow(gridView, (TSource)updated);
                        };

                        form.SetEntity(source);
                        form.ShowDialog();
                    }
                    catch (Exception)
                    {
                    }
                }

                if (column == $"col_{controller}_disable")
                {
                    if (!UserRepository.LoggedUser.HasPrivilege(Privilege.DisableEntity))
                    {
                        return;
                    }

                    try
                    {
                        var view = gridView.Rows[e.RowIndex].DataBoundItem as DataRowView;
                        var source = view["Source"] as TSource;

                        if (!source.Enable)
                        {
                            return;
                        }

                        var dialogResult = ShowDialog("Seguro que desea Inactivar esta entidad?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            var repository = new Repository<TSource>();
                            repository.Disable(source.ID);
                            ShowDialog("Operación completada con exito.");
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            };
        }
        public static void LoadEntitiesClick<TSource>(this Button button, DataGridView gridView) where TSource : BaseEntity, IDisable
        {
            button.Click += delegate (object sender, EventArgs e)
            {
                try
                {
                    var repository = new Repository<TSource>();
                    var sources = repository.GetAll();
                    SetDataTable(gridView, sources);
                }
                catch (Exception ex)
                {
                    ex.ShowDialog();
                }
            };
        }
        public static void AddEntityClick<TSource, TForm>(this Button button, DataGridView gridView)
            where TSource : BaseEntity, IDisable
             where TForm : Form, IFormEvents, new()
        {
            button.Click += delegate (object sender, EventArgs e)
            {
                try
                {
                    var form = new TForm();

                    form.OnAdded += delegate (object added, EventArgs args)
                    {
                        AddRowSource(gridView, added);
                    };

                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    ex.ShowDialog();
                }
            };
        }
        #endregion

        public static void SetDataTable<TSource>(DataGridView gridView, List<TSource> sources)
        {
            // Tipo del source.
            var sourceType = typeof(TSource);

            // Tabla para el DataSource.
            var table = new DataTable(sourceType.Name);

            // Obtener las columnas del DataGridView.
            var columns = gridView.Columns.Cast<DataGridViewColumn>().Where(x => !string.IsNullOrWhiteSpace(x.DataPropertyName)).ToArray();

            // Agregar las columnas al DataTable.
            foreach (var dgvColumn in columns)
            {
                // Obtener el tipo de la propiedad.
                var property = sourceType.GetProperty(dgvColumn.DataPropertyName);
                if (property != null)
                {
                    table.Columns.Add(dgvColumn.DataPropertyName, property.PropertyType);
                }
            }

            table.Columns.Add("Source", sourceType);

            // Llenar los datos.
            foreach (var source in sources)
            {
                var row = table.NewRow();
                row["Source"] = source;

                SetDataRow(row);

                table.Rows.Add(row);
            }

            gridView.DataSource = table;
        }
        private static void SetDataRow(DataRow row)
        {
            var source = row["Source"];
            foreach (DataColumn column in row.Table.Columns)
            {
                if (column.ColumnName == "Source")
                    continue;

                // Obtener el valor de la propiedad.
                var property = source.GetType().GetProperty(column.ColumnName);
                var value = property.GetValue(source);

                // Establecer el valor al row.
                row[column] = value;
            }
        }
        public static void AddRowSource<TSource>(DataGridView gridView, TSource source)
        {
            // Obtener el DataTable.
            var table = (DataTable)gridView.DataSource;
            if (table == null)
            {
                return;
            }

            // Agregar el Row.
            var row = table.NewRow();
            row["Source"] = source;

            SetDataRow(row);
            table.Rows.Add(row);
        }
        public static void UpdateRow<TSource>(DataGridView gridView, TSource source) where TSource : IDisable
        {
            // Obtener el DataTable.
            var table = (DataTable)gridView.DataSource;

            foreach (DataRow row in table.Rows)
            {
                var sourceRow = (TSource)row["Source"];
                if (sourceRow.ID == source.ID)
                {
                    row["Source"] = source;
                    SetDataRow(row);
                }
            }
        }
        public static string GetDescriptionEnum(object item)
        {
            var member = GetAttributeEnum((Enum)item);
            if (member != null)
            {
                var attribute = GetAttribute<System.ComponentModel.DescriptionAttribute>(member);
                if (attribute != null)
                {
                    return attribute.Description;
                }
            }

            return item.ToString();
        }
        public static MemberInfo GetAttributeEnum(Enum item)
        {
            var enumType = item.GetType();
            var enumValue = item.ToString();
            return enumType.GetMember(enumValue).FirstOrDefault();
        }
        public static TAttribute GetAttribute<TAttribute>(MemberInfo member) where TAttribute : Attribute
        {
            if (member != null)
                return System.Attribute.GetCustomAttribute(member, typeof(TAttribute)) as TAttribute;
            else return null;
        }
        public static string GetController<TSource>()
        {
            var type = typeof(TSource);

            if (type == typeof(Category))
            {
                return "category";
            }

            if (type == typeof(User))
            {
                return "user";
            }

            if (type == typeof(Supplier))
            {
                return "supplier";
            }

            if (type == typeof(Warehouse))
            {
                return "warehouse";
            }

            if (type == typeof(Product) || type == typeof(ProductUp))
            {
                return "product";
            }

            if (type == typeof(Entry))
            {
                return "entry";
            }

            if (type == typeof(Invoice))
            {
                return "invoice";
            }

            throw new Exception("Type Not Found.");
        }
    }
}