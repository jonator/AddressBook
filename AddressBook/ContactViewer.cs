using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class ContactViewer : Form
    {
        Contact contactToView;

        public ContactViewer(Contact toView)//to view is the contact that is selected in the contactListBox
        {
            InitializeComponent();
            this.Text = toView.FirstName + " " + toView.LastName;//Sets the title of the form to the first and last name
            phoneNumberLabel.Text = toView.PhoneNumber.ToString();//In phone number label's text, we added the class called phonenumbers imformation based on the (contact toView)
            emailLabel.Text = toView.Email;//We called the email based on the toView contact from the Contact class
            contactToView = toView;
        }
        private void ContactViewer_Load(object sender, EventArgs e)//Gets called after it loads
        {

        }

        private void button2_Click(object sender, EventArgs e)//Closes the contact view window
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)//(EDIT THIS CONTACT BUTTON) opens the contact editor (make later)
        {
            EditExistingContactWindow form = new EditExistingContactWindow(contactToView);
            form.ShowDialog();
            Close();
        }
    }
}
