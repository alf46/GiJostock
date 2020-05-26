namespace GiJoStock.Usercontrol
{
    partial class WarehouseControl
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
            this.warehousePanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // warehousePanel
            // 
            this.warehousePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warehousePanel.AutoScroll = true;
            this.warehousePanel.HorizontalScrollbar = true;
            this.warehousePanel.HorizontalScrollbarBarColor = true;
            this.warehousePanel.HorizontalScrollbarHighlightOnWheel = true;
            this.warehousePanel.HorizontalScrollbarSize = 10;
            this.warehousePanel.Location = new System.Drawing.Point(0, 0);
            this.warehousePanel.Name = "warehousePanel";
            this.warehousePanel.Size = new System.Drawing.Size(380, 69);
            this.warehousePanel.TabIndex = 2;
            this.warehousePanel.VerticalScrollbar = true;
            this.warehousePanel.VerticalScrollbarBarColor = true;
            this.warehousePanel.VerticalScrollbarHighlightOnWheel = true;
            this.warehousePanel.VerticalScrollbarSize = 10;
            // 
            // WarehouseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warehousePanel);
            this.Name = "WarehouseControl";
            this.Size = new System.Drawing.Size(380, 69);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WarehouseControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel warehousePanel;
    }
}