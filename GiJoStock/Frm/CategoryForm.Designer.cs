namespace GiJoStock
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEnable = new MetroFramework.Controls.MetroCheckBox();
            this.SpAdding = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveImg = new MetroFramework.Controls.MetroButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.linkOpenImage = new MetroFramework.Controls.MetroLink();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 10);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // cbxEnable
            // 
            this.cbxEnable.AutoSize = true;
            this.cbxEnable.Location = new System.Drawing.Point(218, 264);
            this.cbxEnable.Name = "cbxEnable";
            this.cbxEnable.Size = new System.Drawing.Size(56, 15);
            this.cbxEnable.TabIndex = 52;
            this.cbxEnable.Text = "Activa";
            this.cbxEnable.UseSelectable = true;
            // 
            // SpAdding
            // 
            this.SpAdding.Location = new System.Drawing.Point(195, 264);
            this.SpAdding.Maximum = 100;
            this.SpAdding.Name = "SpAdding";
            this.SpAdding.Size = new System.Drawing.Size(16, 16);
            this.SpAdding.TabIndex = 46;
            this.SpAdding.UseSelectable = true;
            this.SpAdding.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Guardar";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtName.CustomButton.Location = new System.Drawing.Point(304, 1);
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
            this.txtName.Location = new System.Drawing.Point(219, 108);
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
            this.txtName.Size = new System.Drawing.Size(326, 23);
            this.txtName.TabIndex = 42;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Nombre del producto";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(219, 86);
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
            this.panel2.Location = new System.Drawing.Point(38, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 145);
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
            this.picImage.Location = new System.Drawing.Point(13, 8);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(128, 128);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.DoubleClick += new System.EventHandler(this.PicImage_DoubleClick);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(256, 1);
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
            this.txtDescription.Location = new System.Drawing.Point(219, 164);
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
            this.txtDescription.Size = new System.Drawing.Size(326, 71);
            this.txtDescription.TabIndex = 54;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Nombre del producto";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(219, 141);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "Descripción";
            // 
            // linkOpenImage
            // 
            this.linkOpenImage.Location = new System.Drawing.Point(38, 236);
            this.linkOpenImage.Name = "linkOpenImage";
            this.linkOpenImage.Size = new System.Drawing.Size(116, 19);
            this.linkOpenImage.TabIndex = 57;
            this.linkOpenImage.Text = "Cargar Imagen...";
            this.linkOpenImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkOpenImage.UseSelectable = true;
            this.linkOpenImage.Click += new System.EventHandler(this.LinkOpenImage_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 302);
            this.Controls.Add(this.linkOpenImage);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbxEnable);
            this.Controls.Add(this.SpAdding);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CategoryForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Nueva Categoría";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox cbxEnable;
        private MetroFramework.Controls.MetroProgressSpinner SpAdding;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImage;
        private MetroFramework.Controls.MetroButton btnRemoveImg;
        private MetroFramework.Controls.MetroLink linkOpenImage;
    }
}