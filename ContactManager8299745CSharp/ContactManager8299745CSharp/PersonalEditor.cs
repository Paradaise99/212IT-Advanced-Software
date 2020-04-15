using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager8299745CSharp
{
    public partial class PersonalEditor : Form //this is the form from the perosnal that is the same from business just running diferent methods from the personnal check the comments from business;
    {
        DbCon dbCon = new DbCon(); 
        public PersonalEditor()
        {
            InitializeComponent();
        }

        private void PersonalEditor_Load(object sender, EventArgs e)
        {
            dgv_PersonalRecords.DataSource = dbCon.GetAllPersonal();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_PersonalRecords.DataSource = dbCon.GetAllPersonal();
        }

        private void dgv_PersonalRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Int32.Parse(dgv_PersonalRecords.SelectedCells[0].Value.ToString());
            tbx_FName.Text = dgv_PersonalRecords.SelectedCells[1].Value.ToString();
            tbx_LName.Text = dgv_PersonalRecords.SelectedCells[2].Value.ToString();
            tbx_Email.Text = dgv_PersonalRecords.SelectedCells[3].Value.ToString();
            tbx_Tel.Text = dgv_PersonalRecords.SelectedCells[4].Value.ToString();
            tbx_Addr1.Text = dgv_PersonalRecords.SelectedCells[5].Value.ToString();
            tbx_Addr2.Text = dgv_PersonalRecords.SelectedCells[6].Value.ToString();
            tbx_City.Text = dgv_PersonalRecords.SelectedCells[7].Value.ToString();
            tbx_PostCode.Text = dgv_PersonalRecords.SelectedCells[8].Value.ToString();
            tbx_HomeTel.Text = dgv_PersonalRecords.SelectedCells[9].Value.ToString();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            tbx_FName.Enabled = true;
            tbx_LName.Enabled = true;
            tbx_Email.Enabled = true;
            tbx_Tel.Enabled = true;
            tbx_Addr1.Enabled = true;
            tbx_Addr2.Enabled = true;
            tbx_City.Enabled = true;
            tbx_PostCode.Enabled = true;
            tbx_HomeTel.Enabled = true;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = false;
            btn_SaveNew.Enabled = true;
            tbx_FName.Text = String.Empty;
            tbx_LName.Text = String.Empty;
            tbx_Email.Text = String.Empty;
            tbx_Tel.Text = String.Empty;
            tbx_Addr1.Text = String.Empty;
            tbx_Addr2.Text = String.Empty;
            tbx_City.Text = String.Empty;
            tbx_PostCode.Text = String.Empty;
            tbx_HomeTel.Text = String.Empty;

        }

        private void btn_SaveNew_Click(object sender, EventArgs e)
        {
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactFName = tbx_FName.Text;
            personalContact.ContactLName = tbx_LName.Text;
            personalContact.ContactEmail = tbx_Email.Text;
            personalContact.ContactTel = tbx_Tel.Text;
            personalContact.ContactAddr1 = tbx_Addr1.Text;
            personalContact.ContactAddr2 = tbx_Addr2.Text;
            personalContact.ContactCity = tbx_City.Text;
            personalContact.ContactPostcode = tbx_PostCode.Text;
            personalContact.ContactHomeTel = tbx_HomeTel.Text;
            dbCon.InsertPersonal(personalContact);
            tbx_FName.Enabled = false;
            tbx_LName.Enabled = false;
            tbx_Email.Enabled = false;
            tbx_Tel.Enabled = false;
            tbx_Addr1.Enabled = false;
            tbx_Addr2.Enabled = false;
            tbx_City.Enabled = false;
            tbx_PostCode.Enabled = false;
            tbx_HomeTel.Enabled = false;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            btn_SaveNew.Enabled = false;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            tbx_FName.Enabled = true;
            tbx_LName.Enabled = true;
            tbx_Email.Enabled = true;
            tbx_Tel.Enabled = true;
            tbx_Addr1.Enabled = true;
            tbx_Addr2.Enabled = true;
            tbx_City.Enabled = true;
            tbx_PostCode.Enabled = true;
            tbx_HomeTel.Enabled = true;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = false;
            btn_AddNew.Enabled = false;
            btn_SaveSelected.Enabled = true;
            
        }

        private void btn_SaveSelected_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dgv_PersonalRecords.SelectedCells[0].Value.ToString());
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactID = index;
            personalContact.ContactFName = tbx_FName.Text;
            personalContact.ContactLName = tbx_LName.Text;
            personalContact.ContactEmail = tbx_Email.Text;
            personalContact.ContactTel = tbx_Tel.Text;
            personalContact.ContactAddr1 = tbx_Addr1.Text;
            personalContact.ContactAddr2 = tbx_Addr2.Text;
            personalContact.ContactCity = tbx_City.Text;
            personalContact.ContactPostcode = tbx_PostCode.Text;
            personalContact.ContactHomeTel = tbx_HomeTel.Text;
            dbCon.UpdatePersonal(personalContact);
            dgv_PersonalRecords.DataSource = dbCon.GetAllPersonal();
            tbx_FName.Enabled = false;
            tbx_LName.Enabled = false;
            tbx_Email.Enabled = false;
            tbx_Tel.Enabled = false;
            tbx_Addr1.Enabled = false;
            tbx_Addr2.Enabled = false;
            tbx_City.Enabled = false;
            tbx_PostCode.Enabled = false;
            tbx_HomeTel.Enabled = false;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = true;
            btn_AddNew.Enabled = true; 
            btn_SaveSelected.Enabled = false;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string message = "Do you really want to delete?";
            string caption = "Do you want to Delete  the contact with the record ID=" + Int32.Parse(dgv_PersonalRecords.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                dbCon.DeletePersonal(Int32.Parse(dgv_PersonalRecords.SelectedCells[0].Value.ToString()));
                dgv_PersonalRecords.DataSource = dbCon.GetAllPersonal();
            }
        }
    }
}
