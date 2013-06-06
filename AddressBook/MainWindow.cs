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
    public partial class MainWindow : Form
    {
        private List<Contact> virtualContactList;//makes a new list that and makes memory for <contact>

        public MainWindow()
        {
            InitializeComponent();
            virtualContactList = new List<Contact>(20);//initial size of list size (20 before it multiplies)
        }

        public void AddContact(Contact newContact)//adds new contact to the virtual list
        {
            virtualContactList.Add(newContact);

            contactListBox.Items.Add(newContact.FirstName + " " + newContact.LastName);
        }


        private void MainWindow_Load(object sender, EventArgs e)//calls this method after the MainWindow(); loads/is drawn
        {
        }

        private void addButton_Click(object sender, EventArgs e)//happens when add_button is clicked
        {
            NewContactForm form = new NewContactForm(this);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)//closes the form when the close button is clicked
        {
            Close();
        }
    }
}
