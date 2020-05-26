using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GiJoStock.Usercontrol
{
    public partial class PrivilegeControl : UserControl
    {
        private int _index = 7;
        private readonly int _margin = 20;

        public PrivilegeControl()
        {
            this.InitializeComponent();

            var str = "";
            foreach (var item in Enum.GetValues(typeof(Privilege)))
            {
                var description = Helpers.GetDescriptionEnum(item);
                str += description + "\n";

                this.AddControls((int)item, item.ToString(), description);
            }
        }

        #region Properties
        public string Selecteds
        {
            get
            {
                var selectedModules = this.GetCheckBoxes().Where(x => x.Checked == true).Select(x => x.Tag.ToString());
                return string.Join(",", selectedModules).ToLower();
            }
        }
        #endregion

        #region Public Methods
        public void SelectPrivileges(string privileges)
        {
            var priv = privileges.Split(',');
            foreach (var item in priv)
            {
                this.Select(int.Parse(item));
            }
        }
        public void DisableEdit()
        {
            this.privilegePanel.Enabled = false;
        }
        #endregion

        #region Private Methods
        private void Select(int privilege)
        {
            var privilegeControl = this.GetCheckBoxes().Where(x => (int)x.Tag == privilege).FirstOrDefault();
            if (privilegeControl != null)
            {
                privilegeControl.Checked = true;
            }
        }
        private void AddControls(int code, string name, string description)
        {
            var checkBox = new MetroCheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = new Point(16, this._index);
            checkBox.Name = "cbx_" + this._index;
            checkBox.Size = new Size(79, 15);
            checkBox.Text = name;
            checkBox.Tag = code;
            checkBox.UseCustomForeColor = true;
            checkBox.ForeColor = Color.Crimson;
            checkBox.FontWeight = MetroCheckBoxWeight.Bold;
            this.privilegePanel.Controls.Add(checkBox);

            var label = new MetroLabel();
            label.AutoSize = true;
            label.ForeColor = Color.DimGray;
            label.FontSize = MetroLabelSize.Small;
            label.FontWeight = MetroLabelWeight.Bold;
            label.Location = new Point(161, this._index);
            label.Name = "clb_" + this._index;
            label.Size = new Size(81, 19);
            label.Text = description;
            label.UseCustomForeColor = true;
            this.privilegePanel.Controls.Add(label);

            this._index += this._margin;
        }
        private IEnumerable<MetroCheckBox> GetCheckBoxes()
        {
            return this.privilegePanel.Controls.Cast<Control>().Where(x => x is MetroCheckBox).Select(x => x as MetroCheckBox);
        }
        #endregion
    }
}