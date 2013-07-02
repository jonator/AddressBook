using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            string open = File.ReadAllText("saved.xml");

            XElement parsed = XElement.Parse(open);

            foreach (XElement child in parsed.Elements("contact"))
            {
                string savedFirstName = child.Element("firstName").Value;
                string savedLastName = child.Element("lastName").Value;
                string savedAreaCode = child.Element("PhoneNumber").Element("areaCode").Value;
                string savedFirstPart = child.Element("PhoneNumber").Element("firstPart").Value;
                string savedSecondPart = child.Element("PhoneNumber").Element("secondPart").Value;
                PhoneNumber savedPhoneNumber = new PhoneNumber(int.Parse(savedAreaCode), int.Parse(savedFirstPart), int.Parse(savedSecondPart));
                string savedEmail = child.Element("email").Value;

                virtualContactList.Add(new Contact(savedFirstName, savedLastName, savedPhoneNumber, savedEmail));


            }
            
            DisplayVirtualListInBox();

            UpdateContactNumberLabel();//Takes another look at how many contacts there are
        }
        private void DisplayVirtualListInBox()
        {
            foreach (Contact c in virtualContactList)
            {
                contactListBox.Items.Add(c.FirstName + " " + c.LastName);
            }
        }

        private void addButton_Click(object sender, EventArgs e)//happens when add_button is clicked
        {
            NewContactForm form = new NewContactForm(this);//
            form.ShowDialog();//Pauses the code unlike show
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

            UpdateContactNumberLabel();//Takes another look at how many contacts there are to add to the counter
        }

        private void refreshListBox()
        {
            contactListBox.Items.Clear();

            foreach (Contact c in virtualContactList)//makes sure the virtualContactList is the same as what first and last name appears in the contactListBox
            {
                contactListBox.Items.Add(c.FirstName + " " + c.LastName);
            }
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            int mainIndex = contactListBox.SelectedIndex;

            if (mainIndex == -1)
            {
                MessageBox.Show("No contacts selected.");//show message to tell user nothing is selected
                return;//returning early so that it does not try to delete nothing
            }

            Contact toEdit = virtualContactList[mainIndex];
            EditExistingContactWindow form = new EditExistingContactWindow(toEdit);

            form.ShowDialog();

            refreshListBox();
        }

        private void contactListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = contactListBox.SelectedIndex;

            if (virtualContactList.Count == 0 || index == -1)
            {
                return;
            }

            Contact toView = virtualContactList[index];//Contact toView = the item in the virtual list at index; virtualContactList[index] pulls out the contact info that is tied to the contactListBox because of the [ ]
            ContactViewer form = new ContactViewer(toView);

            form.ShowDialog();

            refreshListBox();//calls the refrestListBox method below upon a double click
        }

        private void contactSaver(object sender, EventArgs e)
        {

            XElement xml = new XElement("contacts");//saves the contact information as an xml file in saved.xml

            foreach (Contact c in virtualContactList)
            {
                XElement contactElement = new XElement(//XElement is the way to write xml in C#
                    "contact",
                    new XElement("firstName", c.FirstName),
                    new XElement("lastName", c.LastName),
                    new XElement("PhoneNumber",
                        new XElement("areaCode", c.PhoneNumber.AreaCode),
                        new XElement("firstPart", c.PhoneNumber.FirstPart),
                        new XElement("secondPart", c.PhoneNumber.SecondPart)),
                    new XElement("email", c.Email)
                );

                xml.Add(contactElement);
            }

            File.WriteAllText("saved.xml", xml.ToString());       
        }
    }
}