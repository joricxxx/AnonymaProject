using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymaWindowsFormApp.AnonymaUserControl
{
    public partial class ReadRequirement : UserControl
    {
        public ReadRequirement()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new RoleSelection());
            Parent.Controls.RemoveAt(0);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new MessageDisplayer());
            Parent.Controls.RemoveAt(0);
        }
    }
}
