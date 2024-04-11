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
        //TODO : If this form is displayed and a user will click the close button, it must also delete the content.
        private string Key;
        public MessageDisplayer()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            DbConnector.deleteContent(Key);
            Parent.Controls.Add(new RoleSelection());
            Parent.Controls.RemoveAt(0);
        }
        public void setupMessageContent(string key, string content)
        {
            messageContent.Text = content;
            Key = key;
        }
    }
}
