namespace ContactManager8299745CSharp
{
    partial class PersonalEditor
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
            this.dgv_PersonalRecords = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.btn_SaveNew = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_SaveSelected = new System.Windows.Forms.Button();
            this.tbx_FName = new System.Windows.Forms.TextBox();
            this.tbx_LName = new System.Windows.Forms.TextBox();
            this.tbx_Addr1 = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_Tel = new System.Windows.Forms.TextBox();
            this.tbx_Addr2 = new System.Windows.Forms.TextBox();
            this.tbx_City = new System.Windows.Forms.TextBox();
            this.tbx_PostCode = new System.Windows.Forms.TextBox();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_Addr1 = new System.Windows.Forms.Label();
            this.lbl_Addr2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_PostCode = new System.Windows.Forms.Label();
            this.lbl_HomeTel = new System.Windows.Forms.Label();
            this.tbx_HomeTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PersonalRecords
            // 
            this.dgv_PersonalRecords.AllowUserToResizeColumns = false;
            this.dgv_PersonalRecords.AllowUserToResizeRows = false;
            this.dgv_PersonalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PersonalRecords.Location = new System.Drawing.Point(24, 203);
            this.dgv_PersonalRecords.Name = "dgv_PersonalRecords";
            this.dgv_PersonalRecords.ReadOnly = true;
            this.dgv_PersonalRecords.RowHeadersWidth = 62;
            this.dgv_PersonalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PersonalRecords.Size = new System.Drawing.Size(1500, 645);
            this.dgv_PersonalRecords.TabIndex = 0;
            this.dgv_PersonalRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PersonalRecords_CellClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1449, 174);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(1449, 13);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNew.TabIndex = 2;
            this.btn_AddNew.Text = "Add New";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_SaveNew
            // 
            this.btn_SaveNew.Enabled = false;
            this.btn_SaveNew.Location = new System.Drawing.Point(1449, 52);
            this.btn_SaveNew.Name = "btn_SaveNew";
            this.btn_SaveNew.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveNew.TabIndex = 3;
            this.btn_SaveNew.Text = "Save New";
            this.btn_SaveNew.UseVisualStyleBackColor = true;
            this.btn_SaveNew.Click += new System.EventHandler(this.btn_SaveNew_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(1305, 13);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update Selected";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1305, 52);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(115, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delect Selected";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_SaveSelected
            // 
            this.btn_SaveSelected.Enabled = false;
            this.btn_SaveSelected.Location = new System.Drawing.Point(1305, 95);
            this.btn_SaveSelected.Name = "btn_SaveSelected";
            this.btn_SaveSelected.Size = new System.Drawing.Size(115, 23);
            this.btn_SaveSelected.TabIndex = 6;
            this.btn_SaveSelected.Text = "Save Selected";
            this.btn_SaveSelected.UseVisualStyleBackColor = true;
            this.btn_SaveSelected.Click += new System.EventHandler(this.btn_SaveSelected_Click);
            // 
            // tbx_FName
            // 
            this.tbx_FName.Enabled = false;
            this.tbx_FName.Location = new System.Drawing.Point(85, 10);
            this.tbx_FName.Name = "tbx_FName";
            this.tbx_FName.Size = new System.Drawing.Size(100, 20);
            this.tbx_FName.TabIndex = 7;
            // 
            // tbx_LName
            // 
            this.tbx_LName.Enabled = false;
            this.tbx_LName.Location = new System.Drawing.Point(85, 38);
            this.tbx_LName.Name = "tbx_LName";
            this.tbx_LName.Size = new System.Drawing.Size(100, 20);
            this.tbx_LName.TabIndex = 8;
            // 
            // tbx_Addr1
            // 
            this.tbx_Addr1.Enabled = false;
            this.tbx_Addr1.Location = new System.Drawing.Point(419, 6);
            this.tbx_Addr1.Name = "tbx_Addr1";
            this.tbx_Addr1.Size = new System.Drawing.Size(100, 20);
            this.tbx_Addr1.TabIndex = 9;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Enabled = false;
            this.tbx_Email.Location = new System.Drawing.Point(85, 66);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(100, 20);
            this.tbx_Email.TabIndex = 10;
            // 
            // tbx_Tel
            // 
            this.tbx_Tel.Enabled = false;
            this.tbx_Tel.Location = new System.Drawing.Point(85, 97);
            this.tbx_Tel.Name = "tbx_Tel";
            this.tbx_Tel.Size = new System.Drawing.Size(100, 20);
            this.tbx_Tel.TabIndex = 11;
            // 
            // tbx_Addr2
            // 
            this.tbx_Addr2.Enabled = false;
            this.tbx_Addr2.Location = new System.Drawing.Point(419, 34);
            this.tbx_Addr2.Name = "tbx_Addr2";
            this.tbx_Addr2.Size = new System.Drawing.Size(100, 20);
            this.tbx_Addr2.TabIndex = 12;
            // 
            // tbx_City
            // 
            this.tbx_City.Enabled = false;
            this.tbx_City.Location = new System.Drawing.Point(419, 60);
            this.tbx_City.Name = "tbx_City";
            this.tbx_City.Size = new System.Drawing.Size(100, 20);
            this.tbx_City.TabIndex = 13;
            // 
            // tbx_PostCode
            // 
            this.tbx_PostCode.Enabled = false;
            this.tbx_PostCode.Location = new System.Drawing.Point(419, 89);
            this.tbx_PostCode.Name = "tbx_PostCode";
            this.tbx_PostCode.Size = new System.Drawing.Size(100, 20);
            this.tbx_PostCode.TabIndex = 14;
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Location = new System.Drawing.Point(21, 13);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FName.TabIndex = 15;
            this.lbl_FName.Text = "First Name";
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Location = new System.Drawing.Point(21, 41);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LName.TabIndex = 16;
            this.lbl_LName.Text = "Last Name";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(21, 69);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 17;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Location = new System.Drawing.Point(21, 100);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(58, 13);
            this.lbl_Tel.TabIndex = 18;
            this.lbl_Tel.Text = "Telephone";
            // 
            // lbl_Addr1
            // 
            this.lbl_Addr1.AutoSize = true;
            this.lbl_Addr1.Location = new System.Drawing.Point(351, 10);
            this.lbl_Addr1.Name = "lbl_Addr1";
            this.lbl_Addr1.Size = new System.Drawing.Size(54, 13);
            this.lbl_Addr1.TabIndex = 19;
            this.lbl_Addr1.Text = "Address 1";
            // 
            // lbl_Addr2
            // 
            this.lbl_Addr2.AutoSize = true;
            this.lbl_Addr2.Location = new System.Drawing.Point(351, 38);
            this.lbl_Addr2.Name = "lbl_Addr2";
            this.lbl_Addr2.Size = new System.Drawing.Size(57, 13);
            this.lbl_Addr2.TabIndex = 20;
            this.lbl_Addr2.Text = "Address 2 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 21;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(351, 66);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(24, 13);
            this.lbl_City.TabIndex = 22;
            this.lbl_City.Text = "City";
            // 
            // lbl_PostCode
            // 
            this.lbl_PostCode.AutoSize = true;
            this.lbl_PostCode.Location = new System.Drawing.Point(351, 94);
            this.lbl_PostCode.Name = "lbl_PostCode";
            this.lbl_PostCode.Size = new System.Drawing.Size(56, 13);
            this.lbl_PostCode.TabIndex = 23;
            this.lbl_PostCode.Text = "Post Code";
            // 
            // lbl_HomeTel
            // 
            this.lbl_HomeTel.AutoSize = true;
            this.lbl_HomeTel.Location = new System.Drawing.Point(694, 6);
            this.lbl_HomeTel.Name = "lbl_HomeTel";
            this.lbl_HomeTel.Size = new System.Drawing.Size(89, 13);
            this.lbl_HomeTel.TabIndex = 24;
            this.lbl_HomeTel.Text = "Home Telephone";
            // 
            // tbx_HomeTel
            // 
            this.tbx_HomeTel.Enabled = false;
            this.tbx_HomeTel.Location = new System.Drawing.Point(809, 3);
            this.tbx_HomeTel.Name = "tbx_HomeTel";
            this.tbx_HomeTel.Size = new System.Drawing.Size(100, 20);
            this.tbx_HomeTel.TabIndex = 25;
            // 
            // PersonalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 868);
            this.Controls.Add(this.tbx_HomeTel);
            this.Controls.Add(this.lbl_HomeTel);
            this.Controls.Add(this.lbl_PostCode);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Addr2);
            this.Controls.Add(this.lbl_Addr1);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.tbx_PostCode);
            this.Controls.Add(this.tbx_City);
            this.Controls.Add(this.tbx_Addr2);
            this.Controls.Add(this.tbx_Tel);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.tbx_Addr1);
            this.Controls.Add(this.tbx_LName);
            this.Controls.Add(this.tbx_FName);
            this.Controls.Add(this.btn_SaveSelected);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_SaveNew);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_PersonalRecords);
            this.Name = "PersonalEditor";
            this.Text = "Personal Editor";
            this.Load += new System.EventHandler(this.PersonalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PersonalRecords;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_SaveNew;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_SaveSelected;
        private System.Windows.Forms.TextBox tbx_FName;
        private System.Windows.Forms.TextBox tbx_LName;
        private System.Windows.Forms.TextBox tbx_Addr1;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_Tel;
        private System.Windows.Forms.TextBox tbx_Addr2;
        private System.Windows.Forms.TextBox tbx_City;
        private System.Windows.Forms.TextBox tbx_PostCode;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_Addr1;
        private System.Windows.Forms.Label lbl_Addr2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_PostCode;
        private System.Windows.Forms.Label lbl_HomeTel;
        private System.Windows.Forms.TextBox tbx_HomeTel;
    }
}