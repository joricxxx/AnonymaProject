namespace AnonymaWindowsFormApp.AnonymaUserControl
{
    partial class RoleSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleSelection));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.PictureBox();
            this.readButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.writeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reader";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Writer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "A reader will be given a key by the writer so that he can read the message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // writeButton
            // 
            this.writeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.write_button;
            this.writeButton.Location = new System.Drawing.Point(227, 228);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(115, 45);
            this.writeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.writeButton.TabIndex = 15;
            this.writeButton.TabStop = false;
            // 
            // readButton
            // 
            this.readButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readButton.Image = global::AnonymaWindowsFormApp.Properties.Resources.read_button;
            this.readButton.Location = new System.Drawing.Point(227, 160);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(115, 45);
            this.readButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.readButton.TabIndex = 14;
            this.readButton.TabStop = false;
            // 
            // RoleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.readButton);
            this.Font = new System.Drawing.Font("Ebrima", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RoleSelection";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.writeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox writeButton;
        private System.Windows.Forms.PictureBox readButton;
    }
}
