using AnonymaClassLibrary.StaticClass;
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
    public partial class MessageDisplayer : UserControl
    {
        public MessageDisplayer()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new RoleSelection());
            Parent.Controls.RemoveAt(0);
        }
        public void setupMessageContent(string content)
        {
            messageContent.Text = content;
        }
    }
}
