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
    public partial class RoleSelection : UserControl
    {
        public RoleSelection()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new ReadRequirement());
            Parent.Controls.RemoveAt(0);
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new MessageComposer());
            Parent.Controls.RemoveAt(0);
        }
    }
}
