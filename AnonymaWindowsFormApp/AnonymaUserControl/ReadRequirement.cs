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
            if (IntenetConnectionChecker.IsConnectedToInternet())
            {
                if (DbConnector.KeyIsValid(keyTextbox.Text) == true)
                {
                    string content = DbConnector.retrieveContent(keyTextbox.Text);
                    MessageDisplayer messageDisplay = new MessageDisplayer();
                    messageDisplay.setupMessageContent(content);
                    DbConnector.deleteContent(keyTextbox.Text);

                    Parent.Controls.Add(messageDisplay);
                    Parent.Controls.RemoveAt(0);
                }
                else
                    MessageBox.Show("Invalid Key or might be the Message was already seen by others before you");
            }
            else
            {
                MessageBox.Show("You have no internet connection! Connect to internet to proceed");
            }
        }
    }
}
