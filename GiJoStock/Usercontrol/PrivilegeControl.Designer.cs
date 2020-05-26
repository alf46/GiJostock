namespace GiJoStock.Usercontrol
{
    partial class PrivilegeControl
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
            this.privilegePanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // privilegePanel
            // 
            this.privilegePanel.AutoScroll = true;
            this.privilegePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.privilegePanel.HorizontalScrollbar = true;
            this.privilegePanel.HorizontalScrollbarBarColor = true;
            this.privilegePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.privilegePanel.HorizontalScrollbarSize = 10;
            this.privilegePanel.Location = new System.Drawing.Point(0, 0);
            this.privilegePanel.Name = "privilegePanel";
            this.privilegePanel.Size = new System.Drawing.Size(431, 150);
            this.privilegePanel.TabIndex = 52;
            this.privilegePanel.VerticalScrollbar = true;
            this.privilegePanel.VerticalScrollbarBarColor = true;
            this.privilegePanel.VerticalScrollbarHighlightOnWheel = false;
            this.privilegePanel.VerticalScrollbarSize = 10;
            // 
            // PrivilegeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.privilegePanel);
            this.Name = "PrivilegeControl";
            this.Size = new System.Drawing.Size(431, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel privilegePanel;
    }
}
