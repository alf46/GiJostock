namespace GiJoStock
{
    partial class ProductNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductNewForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveImg = new MetroFramework.Controls.MetroButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.linkOpenImage = new MetroFramework.Controls.MetroLink();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPriceIn = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lkSupplier = new MetroFramework.Controls.MetroLink();
            this.lkCategory = new MetroFramework.Controls.MetroLink();
            this.txtPriceOut = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantityPerUnit = new MetroFramework.Controls.MetroTextBox();
            this.errorValidator1 = new Ofimatic.Framework.Controls.ErrorValidator();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 10);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Guardar";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 43;
            this.metroLabel4.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRemoveImg);
            this.panel2.Controls.Add(this.picImage);
            this.panel2.Controls.Add(this.linkOpenImage);
            this.panel2.Location = new System.Drawing.Point(567, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 240);
            this.panel2.TabIndex = 53;
            // 
            // btnRemoveImg
            // 
            this.btnRemoveImg.Location = new System.Drawing.Point(125, 119);
            this.btnRemoveImg.Name = "btnRemoveImg";
            this.btnRemoveImg.Size = new System.Drawing.Size(15, 16);
            this.btnRemoveImg.TabIndex = 56;
            this.btnRemoveImg.Text = "x";
            this.btnRemoveImg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveImg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveImg.UseSelectable = true;
            this.btnRemoveImg.Click += new System.EventHandler(this.BtnRemoveImg_Click);
            // 
            // picImage
            // 
            this.picImage.Image = global::GiJoStock.Properties.Resources._default;
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(128, 128);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.DoubleClick += new System.EventHandler(this.PicImage_DoubleClick);
            // 
            // linkOpenImage
            // 
            this.linkOpenImage.Location = new System.Drawing.Point(12, 145);
            this.linkOpenImage.Name = "linkOpenImage";
            this.linkOpenImage.Size = new System.Drawing.Size(116, 19);
            this.linkOpenImage.TabIndex = 57;
            this.linkOpenImage.Text = "Cargar Imagen...";
            this.linkOpenImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkOpenImage.UseSelectable = true;
            this.linkOpenImage.Click += new System.EventHandler(this.LinkOpenImage_Click);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.DisplayIcon = true;
            this.txtDescription.Icon = global::GiJoStock.Properties.Resources.deparment;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(14, 151);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Nombre del producto";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.ShowClearButton = true;
            this.txtDescription.Size = new System.Drawing.Size(251, 74);
            this.txtDescription.TabIndex = 54;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Nombre del producto";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "Descripción";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtName.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.Icon = global::GiJoStock.Properties.Resources.deparment;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(15, 31);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Nombre del producto";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 42;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Nombre del producto";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(133, 19);
            this.metroLabel5.TabIndex = 61;
            this.metroLabel5.Text = "Cantidad por Unidad";
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.DisplayIcon = true;
            this.txtBarcode.Icon = global::GiJoStock.Properties.Resources.deparment;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(281, 31);
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.PromptText = "Código de barras";
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.ShowClearButton = true;
            this.txtBarcode.Size = new System.Drawing.Size(223, 23);
            this.txtBarcode.TabIndex = 62;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMark = "Código de barras";
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(281, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(113, 19);
            this.metroLabel6.TabIndex = 63;
            this.metroLabel6.Text = "Código de barras";
            // 
            // txtPriceIn
            // 
            // 
            // 
            // 
            this.txtPriceIn.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtPriceIn.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtPriceIn.CustomButton.Name = "";
            this.txtPriceIn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPriceIn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceIn.CustomButton.TabIndex = 1;
            this.txtPriceIn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceIn.CustomButton.UseSelectable = true;
            this.txtPriceIn.CustomButton.Visible = false;
            this.txtPriceIn.DisplayIcon = true;
            this.txtPriceIn.Icon = global::GiJoStock.Properties.Resources.deparment;
            this.txtPriceIn.Lines = new string[0];
            this.txtPriceIn.Location = new System.Drawing.Point(281, 92);
            this.txtPriceIn.MaxLength = 32767;
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.PasswordChar = '\0';
            this.txtPriceIn.PromptText = "compra";
            this.txtPriceIn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceIn.SelectedText = "";
            this.txtPriceIn.SelectionLength = 0;
            this.txtPriceIn.SelectionStart = 0;
            this.txtPriceIn.ShortcutsEnabled = true;
            this.txtPriceIn.ShowClearButton = true;
            this.txtPriceIn.Size = new System.Drawing.Size(96, 23);
            this.txtPriceIn.TabIndex = 64;
            this.txtPriceIn.UseSelectable = true;
            this.txtPriceIn.WaterMark = "compra";
            this.txtPriceIn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceIn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(281, 70);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 19);
            this.metroLabel7.TabIndex = 65;
            this.metroLabel7.Text = "Precio compra";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(277, 151);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 71;
            this.metroLabel8.Text = "Categoría:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(423, 70);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(81, 19);
            this.metroLabel9.TabIndex = 66;
            this.metroLabel9.Text = "Precio venta";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(285, 184);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 73;
            this.metroLabel10.Text = "Suplidor:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.lkSupplier);
            this.metroPanel2.Controls.Add(this.lkCategory);
            this.metroPanel2.Controls.Add(this.txtPriceOut);
            this.metroPanel2.Controls.Add(this.txtQuantityPerUnit);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.txtPriceIn);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.txtName);
            this.metroPanel2.Controls.Add(this.txtBarcode);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.txtDescription);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 73);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(538, 240);
            this.metroPanel2.TabIndex = 70;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lkSupplier
            // 
            this.lkSupplier.Location = new System.Drawing.Point(349, 180);
            this.lkSupplier.Name = "lkSupplier";
            this.lkSupplier.Size = new System.Drawing.Size(184, 23);
            this.lkSupplier.TabIndex = 77;
            this.lkSupplier.Text = "---";
            this.lkSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lkSupplier.UseSelectable = true;
            this.lkSupplier.Click += new System.EventHandler(this.LkSupplier_Click);
            // 
            // lkCategory
            // 
            this.lkCategory.Location = new System.Drawing.Point(349, 148);
            this.lkCategory.Name = "lkCategory";
            this.lkCategory.Size = new System.Drawing.Size(184, 23);
            this.lkCategory.TabIndex = 76;
            this.lkCategory.Text = "---";
            this.lkCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lkCategory.UseSelectable = true;
            this.lkCategory.Click += new System.EventHandler(this.LkCategory_Click);
            // 
            // txtPriceOut
            // 
            // 
            // 
            // 
            this.txtPriceOut.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtPriceOut.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtPriceOut.CustomButton.Name = "";
            this.txtPriceOut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPriceOut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceOut.CustomButton.TabIndex = 1;
            this.txtPriceOut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceOut.CustomButton.UseSelectable = true;
            this.txtPriceOut.CustomButton.Visible = false;
            this.txtPriceOut.DisplayIcon = true;
            this.txtPriceOut.Icon = global::GiJoStock.Properties.Resources.deparment;
            this.txtPriceOut.Lines = new string[0];
            this.txtPriceOut.Location = new System.Drawing.Point(408, 92);
            this.txtPriceOut.MaxLength = 32767;
            this.txtPriceOut.Name = "txtPriceOut";
            this.txtPriceOut.PasswordChar = '\0';
            this.txtPriceOut.PromptText = "compra";
            this.txtPriceOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceOut.SelectedText = "";
            this.txtPriceOut.SelectionLength = 0;
            this.txtPriceOut.SelectionStart = 0;
            this.txtPriceOut.ShortcutsEnabled = true;
            this.txtPriceOut.ShowClearButton = true;
            this.txtPriceOut.Size = new System.Drawing.Size(96, 23);
            this.txtPriceOut.TabIndex = 75;
            this.txtPriceOut.UseSelectable = true;
            this.txtPriceOut.WaterMark = "compra";
            this.txtPriceOut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceOut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantityPerUnit
            // 
            // 
            // 
            // 
            this.txtQuantityPerUnit.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtQuantityPerUnit.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtQuantityPerUnit.CustomButton.Name = "";
            this.txtQuantityPerUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantityPerUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantityPerUnit.CustomButton.TabIndex = 1;
            this.txtQuantityPerUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantityPerUnit.CustomButton.UseSelectable = true;
            this.txtQuantityPerUnit.CustomButton.Visible = false;
            this.txtQuantityPerUnit.DisplayIcon = true;
            this.txtQuantityPerUnit.Icon = global::GiJoStock.Properties.Resources.deparment;
            this.txtQuantityPerUnit.Lines = new string[0];
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(16, 92);
            this.txtQuantityPerUnit.MaxLength = 32767;
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.PasswordChar = '\0';
            this.txtQuantityPerUnit.PromptText = "Nombre del producto";
            this.txtQuantityPerUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantityPerUnit.SelectedText = "";
            this.txtQuantityPerUnit.SelectionLength = 0;
            this.txtQuantityPerUnit.SelectionStart = 0;
            this.txtQuantityPerUnit.ShortcutsEnabled = true;
            this.txtQuantityPerUnit.ShowClearButton = true;
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(250, 23);
            this.txtQuantityPerUnit.TabIndex = 74;
            this.txtQuantityPerUnit.UseSelectable = true;
            this.txtQuantityPerUnit.WaterMark = "Nombre del producto";
            this.txtQuantityPerUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantityPerUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errorValidator1
            // 
            this.errorValidator1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorValidator1.ContainerControl = this;
            this.errorValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorValidator1.Icon")));
            this.errorValidator1.TimerError = 5000;
            // 
            // ProductNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 360);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductNewForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Agregar Nuevo Producto";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImage;
        private MetroFramework.Controls.MetroButton btnRemoveImg;
        private MetroFramework.Controls.MetroLink linkOpenImage;
        private MetroFramework.Controls.MetroTextBox txtPriceIn;
        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtPriceOut;
        private MetroFramework.Controls.MetroTextBox txtQuantityPerUnit;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLink lkSupplier;
        private MetroFramework.Controls.MetroLink lkCategory;
        private Ofimatic.Framework.Controls.ErrorValidator errorValidator1;
    }
}