namespace AnonymaWindowsFormApp.AnonymaUserControl
{
    partial class KeyResult
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
            this.keyPlaceholder = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.copyButton)).BeginInit();
            this.SuspendLayout();
            // 
            // keyPlaceholder
            // 
            this.keyPlaceholder.AutoSize = true;
            this.keyPlaceholder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.keyPlaceholder.Font = new System.Drawing.Font("Ebrima", 12F);
            this.keyPlaceholder.Location = new System.Drawing.Point(179, 160);
            this.keyPlaceholder.Name = "keyPlaceholder";
            this.keyPlaceholder.Size = new System.Drawing.Size(242, 21);
            this.keyPlaceholder.TabIndex = 4;
            this.keyPlaceholder.Text = "kghiDkcJaAowrIfkChWi2rIf8cCjsq";
            // 
            // copyButton
            // 
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.copy_button;
            this.copyButton.Location = new System.Drawing.Point(243, 195);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(115, 45);
            this.copyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.copyButton.TabIndex = 5;
            this.copyButton.TabStop = false;
            // 
            // KeyResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.keyPlaceholder);
            this.Font = new System.Drawing.Font("Ebrima", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KeyResult";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.copyButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox copyButton;
        private System.Windows.Forms.Label keyPlaceholder;
    }
}
