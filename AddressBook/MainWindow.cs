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
        private List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            contacts.Add(new Contact("ExampleFirst", "ExampleLast", new PhoneNumber(913, 555, 1024), "exampleEmail@yahoo.com"));
        }

        public void AddContact(Contact newContact)
        {
            contacts.Add(newContact);
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            PutAllContactsIntoForm();
        }

        private void PutAllContactsIntoForm()
        {
            foreach (Contact contact in contacts)
            {
                contactListBox.Items.Add(contact.FirstName + " " + contact.LastName);
            } 
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            newContactForm form = new newContactForm(this);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //comment
    }
}
