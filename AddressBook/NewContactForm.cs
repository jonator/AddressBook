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
            InitializeComponent();
            home = homeFormParamter;
        }

        private void closeButton_Click(object sender, EventArgs e)//Closes the addbutton window when close button is clicked
        {
            Close();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            if (HasAnyEmpty())
            {
                MessageBox.Show("Missing information.");
                return;
            }

            WriteNewContact();
            Close();
        }

        private bool HasAnyEmpty()
        {
            return firstNameTextbox.Text == string.Empty || lastNameTextbox.Text == string.Empty || firstPartTextbox.Text == string.Empty || secondPartTextbox.Text == string.Empty || emailTextbox.Text == string.Empty;
        }

        public void WriteNewContact()
        {
            int areaCode = int.Parse(areaCodeTextbox.Text);
            int firstPart = int.Parse(firstPartTextbox.Text);
            int secondPart = int.Parse(secondPartTextbox.Text);

            Contact contact = new Contact(firstNameTextbox.Text, lastNameTextbox.Text, new PhoneNumber(areaCode, firstPart, secondPart), emailTextbox.Text);

            home.AddContact(contact);
        }
    }
}
