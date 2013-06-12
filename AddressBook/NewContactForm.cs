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
    public partial class NewContactForm : Form
    {
        private MainWindow home;

        public NewContactForm(MainWindow homeFormParamter)
        {
            InitializeComponent();//Basically illustrates the form
            home = homeFormParamter;
        }

        private void closeButton_Click(object sender, EventArgs e)//Closes the addbutton window when close button is clicked
        {
            Close();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            if (HasAnyEmpty())//Checks for missing info (HasAnyEmpty is a bool method below)
            {
                MessageBox.Show("Missing information.");//Tells user about missing info
                return;//Leaves the method to check again
            }

            WriteNewContact();//Refers to the WriteNewContact method below
            Close();//Proceeds to close the window after ^{all of the above to addContactButton_Click} is done
        }

        private bool HasAnyEmpty()
        {
            return firstNameTextbox.Text == string.Empty || lastNameTextbox.Text == string.Empty || firstPartTextbox.Text == string.Empty || secondPartTextbox.Text == string.Empty || emailTextbox.Text == string.Empty;
        }////////////////////////////This^ (double =) only checks for whether or not it is the case -- it does not set it equal to (mini if then statement)

        public void WriteNewContact()
        {
            int areaCode = int.Parse(areaCodeTextbox.Text); //All these look for the data input in the textboxes and the parse does not crash if there is nothing
            int firstPart = int.Parse(firstPartTextbox.Text);
            int secondPart = int.Parse(secondPartTextbox.Text);

            Contact contact = new Contact(firstNameTextbox.Text, lastNameTextbox.Text, new PhoneNumber(areaCode, firstPart, secondPart), emailTextbox.Text);
            //^^^Adds new contact to the virtualContactList that is later used in the contactListBox
            home.AddContact(contact);
        }
    }
}
