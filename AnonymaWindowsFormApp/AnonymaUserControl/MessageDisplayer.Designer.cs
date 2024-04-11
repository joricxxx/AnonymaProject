namespace AnonymaWindowsFormApp.AnonymaUserControl
{
    partial class MessageDisplayer
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
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.messageContent = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.exit_button;
            this.exitButton.Location = new System.Drawing.Point(469, 539);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 45);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitButton.TabIndex = 3;
            this.exitButton.TabStop = false;
            // 
            // messageContent
            // 
            this.messageContent.BackColor = System.Drawing.Color.Gainsboro;
            this.messageContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageContent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.messageContent.Location = new System.Drawing.Point(16, 67);
            this.messageContent.Name = "messageContent";
            this.messageContent.ReadOnly = true;
            this.messageContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.messageContent.Size = new System.Drawing.Size(568, 466);
            this.messageContent.TabIndex = 4;
            this.messageContent.Text = " Display Here";
            // 
            // MessageDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageContent);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Ebrima", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MessageDisplayer";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.RichTextBox messageContent;
    }
}
