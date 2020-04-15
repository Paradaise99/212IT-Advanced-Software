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
    public partial class ContactMenu : Form //this is the from page of the system that runs in a form format;
    {
        public ContactMenu()
        {
            InitializeComponent(); //it uses the initialize componets that runst the form 
        }

        private void btn_Personal_Click(object sender, EventArgs e) //this is the action that when clicking the button personal it goes to the form personal contacts;
        {
            PersonalEditor personal = new PersonalEditor();
            personal.Show();
        }

        private void btn_Business_Click(object sender, EventArgs e) //this is the same but for business contacts;
        {
            BusinessEditor business = new BusinessEditor();
            business.Show();
        }
    }
}
