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
    public partial class MessageComposer : UserControl
    {
        public MessageComposer()
        {
            InitializeComponent();
        }

        private void trashButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(new RoleSelection());
            Parent.Controls.RemoveAt(0);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (IntenetConnectionChecker.IsConnectedToInternet())
            {
                string Key = KeyGenerator.GenerateKey();
                AnonymaClassLibrary.Model.Message message = new AnonymaClassLibrary.Model.Message(messageRTextbox.Text);
                DbConnector.uploadMessage(Key, message);

                KeyResult form = new KeyResult();
                form.editKeyPlaceholder(Key);

                Parent.Controls.Add(form);
                Parent.Controls.RemoveAt(0);
            }
            else
                MessageBox.Show("You have no internet connection! Connect to internet to proceed");
        }

        private void messageRTextbox_Click(object sender, EventArgs e)
        {
            messageRTextbox.Text = "";
        }
    }
}
