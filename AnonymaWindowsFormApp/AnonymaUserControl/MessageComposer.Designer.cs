namespace AnonymaWindowsFormApp.AnonymaUserControl
{
    partial class MessageComposer
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
            this.messageRTextbox = new System.Windows.Forms.RichTextBox();
            this.trashButton = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trashButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadButton)).BeginInit();
            this.SuspendLayout();
            // 
            // messageRTextbox
            // 
            this.messageRTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.messageRTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageRTextbox.Font = new System.Drawing.Font("Ebrima", 12F);
            this.messageRTextbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.messageRTextbox.Location = new System.Drawing.Point(15, 34);
            this.messageRTextbox.Name = "messageRTextbox";
            this.messageRTextbox.Size = new System.Drawing.Size(568, 466);
            this.messageRTextbox.TabIndex = 3;
            this.messageRTextbox.Text = " Write Here. . .";
            // 
            // trashButton
            // 
            this.trashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trashButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.trash_button;
            this.trashButton.Location = new System.Drawing.Point(301, 522);
            this.trashButton.Name = "trashButton";
            this.trashButton.Size = new System.Drawing.Size(119, 45);
            this.trashButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trashButton.TabIndex = 5;
            this.trashButton.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.upload_button;
            this.uploadButton.Location = new System.Drawing.Point(451, 522);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(135, 45);
            this.uploadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.uploadButton.TabIndex = 4;
            this.uploadButton.TabStop = false;
            // 
            // MessageComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trashButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.messageRTextbox);
            this.Font = new System.Drawing.Font("Ebrima", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MessageComposer";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.trashButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trashButton;
        private System.Windows.Forms.PictureBox uploadButton;
        private System.Windows.Forms.RichTextBox messageRTextbox;
    }
}
