namespace AnonymaWindowsFormApp.AnonymaUserControl
{
    partial class ReadRequirement
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
            this.label2 = new System.Windows.Forms.Label();
            this.keyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.PictureBox();
            this.enterButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 20F);
            this.label2.Location = new System.Drawing.Point(237, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Key";
            // 
            // keyTextbox
            // 
            this.keyTextbox.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTextbox.Location = new System.Drawing.Point(76, 145);
            this.keyTextbox.Name = "keyTextbox";
            this.keyTextbox.Size = new System.Drawing.Size(449, 36);
            this.keyTextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F);
            this.label1.Location = new System.Drawing.Point(87, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "After opening the message, a message will always be deleted. However, you \ncan ta" +
    "ke a picture or copy the message if you want to. This is to ensure that it \ncann" +
    "ot be access by others.";
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.cancel_button;
            this.cancelButton.Location = new System.Drawing.Point(170, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 45);
            this.cancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cancelButton.TabIndex = 14;
            this.cancelButton.TabStop = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.enter_button;
            this.enterButton.Location = new System.Drawing.Point(317, 206);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(115, 45);
            this.enterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enterButton.TabIndex = 13;
            this.enterButton.TabStop = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // ReadRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ebrima", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReadRequirement";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cancelButton;
        private System.Windows.Forms.PictureBox enterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyTextbox;
        private System.Windows.Forms.Label label1;
    }
}
