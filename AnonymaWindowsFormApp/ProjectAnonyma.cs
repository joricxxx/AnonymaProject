using AnonymaWindowsFormApp.AnonymaUserControl;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymaWindowsFormApp
{
    public partial class ProjectAnonyma : Form
    {
        public ProjectAnonyma()
        {
            InitializeComponent();
            mainPanel.Controls.Add(new RoleSelection());
        }

        /// <summary>
        /// This will update the app if there are changes
        /// </summary>
        /// <returns></returns>
        private async Task CheckForUpdate()
        {
            //The Path is not yet fix because after cloning, everyone has different path of the release folder
            using (var manager = new UpdateManager(@"C:\Github\Cloned Repository\AnonymaProject\AnonymaWindowsFormApp\bin\Release"))
            {
                await manager.UpdateApp();
            }
        }
    }
}
