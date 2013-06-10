namespace AddressBook
{
    partial class ContactViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.introLabel = new System.Windows.Forms.Label();
            this.firstNameDescLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Location = new System.Drawing.Point(12, 9);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(91, 13);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Selected contact:";
            // 
            // firstNameDescLabel
            // 
            this.firstNameDescLabel.AutoSize = true;
            this.firstNameDescLabel.Location = new System.Drawing.Point(45, 43);
            this.firstNameDescLabel.Name = "firstNameDescLabel";
            this.firstNameDescLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameDescLabel.TabIndex = 1;
            this.firstNameDescLabel.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // ContactViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameDescLabel);
            this.Controls.Add(this.introLabel);
            this.Name = "ContactViewer";
            this.Text = "ContactViewer";
            this.Load += new System.EventHandler(this.ContactViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label firstNameDescLabel;
        private System.Windows.Forms.Label label2;
    }
}