namespace GiJoStock.Usercontrol
{
    partial class ProductFilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.dtProductTo = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtProductID = new MetroFramework.Controls.MetroTextBox();
            this.dtProductFrom = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.dtProductTo);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtProductID);
            this.metroPanel1.Controls.Add(this.dtProductFrom);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(682, 31);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(367, 7);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Hasta :";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(560, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 23);
            this.btnLoad.TabIndex = 82;
            this.btnLoad.Text = "Buscar";
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // dtProductTo
            // 
            this.dtProductTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProductTo.Location = new System.Drawing.Point(418, 1);
            this.dtProductTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtProductTo.Name = "dtProductTo";
            this.dtProductTo.ShowCheckBox = true;
            this.dtProductTo.Size = new System.Drawing.Size(122, 29);
            this.dtProductTo.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(184, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Desde :";
            // 
            // txtProductID
            // 
            // 
            // 
            // 
            this.txtProductID.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtProductID.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtProductID.CustomButton.Name = "";
            this.txtProductID.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtProductID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductID.CustomButton.TabIndex = 1;
            this.txtProductID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductID.CustomButton.UseSelectable = true;
            this.txtProductID.CustomButton.Visible = false;
            this.txtProductID.DisplayIcon = true;
            this.txtProductID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProductID.Lines = new string[0];
            this.txtProductID.Location = new System.Drawing.Point(1, 1);
            this.txtProductID.MaxLength = 32767;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.PromptText = "Código del producto";
            this.txtProductID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductID.SelectedText = "";
            this.txtProductID.SelectionLength = 0;
            this.txtProductID.SelectionStart = 0;
            this.txtProductID.ShortcutsEnabled = true;
            this.txtProductID.ShowClearButton = true;
            this.txtProductID.Size = new System.Drawing.Size(170, 29);
            this.txtProductID.TabIndex = 4;
            this.txtProductID.UseSelectable = true;
            this.txtProductID.WaterMark = "Código del producto";
            this.txtProductID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtProductFrom
            // 
            this.dtProductFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProductFrom.Location = new System.Drawing.Point(239, 1);
            this.dtProductFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtProductFrom.Name = "dtProductFrom";
            this.dtProductFrom.ShowCheckBox = true;
            this.dtProductFrom.Size = new System.Drawing.Size(122, 29);
            this.dtProductFrom.TabIndex = 3;
            // 
            // ProductFilterControl
            // 
            this.Controls.Add(this.metroPanel1);
            this.Name = "ProductFilterControl";
            this.Size = new System.Drawing.Size(682, 31);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dtProductTo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtProductID;
        private MetroFramework.Controls.MetroDateTime dtProductFrom;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
