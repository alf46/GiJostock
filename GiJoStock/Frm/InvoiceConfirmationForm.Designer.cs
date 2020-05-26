namespace GiJoStock
{
    partial class InvoiceConfirmationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceConfirmationForm));
            this.btnSaveEntry = new MetroFramework.Controls.MetroButton();
            this.lbMessage = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.linkSave = new MetroFramework.Controls.MetroLink();
            this.lbTotal = new MetroFramework.Controls.MetroLabel();
            this.lbItems = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.Location = new System.Drawing.Point(23, 155);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(95, 23);
            this.btnSaveEntry.TabIndex = 46;
            this.btnSaveEntry.Text = "Dar Salida";
            this.btnSaveEntry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSaveEntry.UseSelectable = true;
            this.btnSaveEntry.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbMessage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbMessage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbMessage.ForeColor = System.Drawing.Color.Tomato;
            this.lbMessage.Location = new System.Drawing.Point(23, 60);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(442, 54);
            this.lbMessage.TabIndex = 47;
            this.lbMessage.Text = "¿Seguro que desea dar Salida a estos Productos?";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMessage.UseCustomBackColor = true;
            this.lbMessage.UseCustomForeColor = true;
            this.lbMessage.WrapToLine = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.metroLabel2.Location = new System.Drawing.Point(23, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 26);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "Total de Items";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.WrapToLine = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.metroLabel3.Location = new System.Drawing.Point(202, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 26);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "Total en $RD";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.WrapToLine = true;
            // 
            // linkSave
            // 
            this.linkSave.Location = new System.Drawing.Point(350, 155);
            this.linkSave.Name = "linkSave";
            this.linkSave.Size = new System.Drawing.Size(115, 23);
            this.linkSave.TabIndex = 50;
            this.linkSave.Text = "Imprimir Factura";
            this.linkSave.UseSelectable = true;
            this.linkSave.Visible = false;
            this.linkSave.Click += new System.EventHandler(this.LinkSave_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbTotal.Location = new System.Drawing.Point(310, 117);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(155, 26);
            this.lbTotal.TabIndex = 51;
            this.lbTotal.Text = "---";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTotal.UseCustomForeColor = true;
            this.lbTotal.WrapToLine = true;
            // 
            // lbItems
            // 
            this.lbItems.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbItems.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbItems.Location = new System.Drawing.Point(124, 117);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(72, 26);
            this.lbItems.TabIndex = 52;
            this.lbItems.Text = "---";
            this.lbItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbItems.UseCustomForeColor = true;
            this.lbItems.WrapToLine = true;
            // 
            // InvoiceConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 192);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.linkSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnSaveEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InvoiceConfirmationForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Confirmación de Salida";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSaveEntry;
        private MetroFramework.Controls.MetroLabel lbMessage;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink linkSave;
        private MetroFramework.Controls.MetroLabel lbTotal;
        private MetroFramework.Controls.MetroLabel lbItems;
    }
}