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
        private List<Contact> virtualContactList;//makes a new list that and makes memory for <contact>; name of the list is virtualContactList

        public MainWindow()
        {
            InitializeComponent();
            virtualContactList = new List<Contact>(20);//initial size of list (20 before it multiplies)
        }

        private void UpdateContactNumberLabel()//Method that updates the contactNumberLabel
        {
            int count = virtualContactList.Count;//Looks for the number of contacts in virtualContactList

            if (count == 1)
            {
                contactNumberLabel.Text = count + " contact";
            }
            else
            {
                contactNumberLabel.Text = count + " contacts";
            }
        }

        public void AddContact(Contact newContact)//adds new contact to the virtual list
        {
            virtualContactList.Add(newContact);

            contactListBox.Items.Add(newContact.FirstName + " " + newContact.LastName);//Adds to the listbox

            UpdateContactNumberLabel();//Takes another look at how many contacts there are
        }


        private void MainWindow_Load(object sender, EventArgs e)//calls this method after the MainWindow(); loads/is drawn
        {
            UpdateContactNumberLabel();//Takes another look at how many contacts there are
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

        protected void deleteButton_Click(object sender, EventArgs e)//deletes the highlighted contact
        {
            if (contactListBox.SelectedIndex == -1)//check if nothing is selected
            {
                MessageBox.Show("No contacts selected.");//show message to tell user nothing is selected
                return;//returning early so that it does not try to delete nothing
            }

            int selectedIndex = contactListBox.SelectedIndex;//getting the selected variable as an int
            contactListBox.Items.RemoveAt(selectedIndex);//deleting the item that is selected

            virtualContactList.RemoveAt(selectedIndex);//deleting the item in the virtual list

            UpdateContactNumberLabel(); //Takes another look at how many contacts there are
        }

        private void listBoxDoubleClick_DoubleClick(object sender, EventArgs e)
        {
            int index = contactListBox.SelectedIndex;

            Contact toView = virtualContactList[index];//Contact toView = the item in the virtual list at index; virtualContactList[index] pulls out the contact info that is tied to the contactListBox because of the [ ]
            ContactViewer form = new ContactViewer(toView);
            form.Show();
        }
    }
}
