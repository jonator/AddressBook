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
    public partial class EditExistingContactWindow : Form
    {
        private Contact toEdit;

        public EditExistingContactWindow(Contact contactToView)//contactToView is set equal to toView which is set equal to the selected contact in contactListBox
        {
            InitializeComponent();
            firstNameEditTextBox.Text = contactToView.FirstName;
            lastNameEditTextbox.Text = contactToView.LastName;
            areaCodeEditTextBox.Text = contactToView.PhoneNumber.AreaCode.ToString();
            firstPartEditTextBox.Text = contactToView.PhoneNumber.FirstPart.ToString();
            secondPartEditTextBox.Text = contactToView.PhoneNumber.SecondPart.ToString();
            emailEditTextbox.Text = contactToView.Email;

            toEdit = contactToView;
        }

        private void EditExistingContactWindow_Load(object sender, EventArgs e)
        {

        }

        private void editExistingContactButton_Click(object sender, EventArgs e)
        {
            toEdit.FirstName = firstNameEditTextBox.Text;
            toEdit.LastName  = lastNameEditTextbox.Text;

            int areaCode = int.Parse(areaCodeEditTextBox.Text);
            int firstPart = int.Parse(firstPartEditTextBox.Text);
            int secondPart = int.Parse(secondPartEditTextBox.Text);

            PhoneNumber newPhoneNumber = new PhoneNumber(areaCode, firstPart, secondPart);

            toEdit.PhoneNumber = newPhoneNumber;
            toEdit.Email = emailEditTextbox.Text;

            Close();
        }

        private void closeEditContactForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
