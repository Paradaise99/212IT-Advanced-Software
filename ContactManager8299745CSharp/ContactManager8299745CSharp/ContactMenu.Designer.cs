namespace ContactManager8299745CSharp
{
    partial class ContactMenu
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
            this.btn_Personal = new System.Windows.Forms.Button();
            this.btn_Business = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Personal
            // 
            this.btn_Personal.Location = new System.Drawing.Point(141, 104);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(118, 54);
            this.btn_Personal.TabIndex = 0;
            this.btn_Personal.Text = "Personal Contacts";
            this.btn_Personal.UseVisualStyleBackColor = true;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click);
            // 
            // btn_Business
            // 
            this.btn_Business.Location = new System.Drawing.Point(349, 104);
            this.btn_Business.Name = "btn_Business";
            this.btn_Business.Size = new System.Drawing.Size(118, 54);
            this.btn_Business.TabIndex = 1;
            this.btn_Business.Text = "Business Contacts";
            this.btn_Business.UseVisualStyleBackColor = true;
            this.btn_Business.Click += new System.EventHandler(this.btn_Business_Click);
            // 
            // ContactMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 244);
            this.Controls.Add(this.btn_Business);
            this.Controls.Add(this.btn_Personal);
            this.Name = "ContactMenu";
            this.Text = "Pedro Contact Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Button btn_Business;
    }
}

