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
    public partial class KeyResult : UserControl
    {
        public KeyResult()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This will get the key into your clipboard. The key will be the identifier of the 
        /// message. Share this to  your receiver to be able to read your message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(keyPlaceholder.Text);
            Parent.Controls.Add(new RoleSelection());
            Parent.Controls.RemoveAt(0);
        }
        public void editKeyPlaceholder(string key)
        {
            keyPlaceholder.Text = key;
        }
    }
}
