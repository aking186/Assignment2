using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        //Global variables for the form
        private Redditch[] redditch = new Redditch[20]; //Array of 20 items
        private int redditchArrayIndex; //used to iterate through array
        private DateTime updated; //Date record updated

        private Bromsgrove[] bromsgrove = new Bromsgrove[20]; //Array of 20 items
        private int bromsgroveArrayIndex; //used to iterate through array

        private Worcester[] worcester = new Worcester[20]; //Array of 20 items
        private int worcesterArrayIndex; //used to iterate through array

        private Malvern[] malvern = new Malvern[20]; //Array of 20 items
        private int malvernArrayIndex; //used to iterate through array

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redditchArrayIndex = -1;
            bromsgroveArrayIndex = -1;
            worcesterArrayIndex = -1;
            malvernArrayIndex = -1;
            updated = DateTime.Now;
            txtDate.Text = updated.ToString("dd/MM/yyyy HH:mm");
        }

        private void populateList()
        {
            
            if (rdoRedditch.Checked == true)
            {
                lstRedditch.Items.Clear();

                for (int i = 0; i <= redditchArrayIndex; i++)
                {
                    if (redditch[i].getAvailable() == true)
                    {
                        lstRedditch.Items.Add(redditch[i].getName() + " - Available");
                    }
                    else
                    {
                        lstRedditch.Items.Add(redditch[i].getName() + " - Not Available - "
                            + redditch[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            else if (rdoBromsgrove.Checked == true)
            {
                lstBromsgrove.Items.Clear();

                for (int i = 0; i <= bromsgroveArrayIndex; i++)
                {
                    if (bromsgrove[i].getAvailable() == true)
                    {
                        lstBromsgrove.Items.Add(bromsgrove[i].getName() + " - Available");
                    }
                    else
                    {
                        lstBromsgrove.Items.Add(bromsgrove[i].getName() + " - Not Available - "
                            + bromsgrove[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            else if (rdoWorcester.Checked == true)
            {
                lstWorcester.Items.Clear();

                for (int i = 0; i <= worcesterArrayIndex; i++)
                {
                    if (worcester[i].getAvailable() == true)
                    {
                        lstWorcester.Items.Add(worcester[i].getName() + " - Available");
                    }
                    else
                    {
                        lstWorcester.Items.Add(worcester[i].getName() + " - Not Available - "
                            + worcester[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            else if (rdoMalvern.Checked == true)
            {
                lstMalvern.Items.Clear();

                for (int i = 0; i <= malvernArrayIndex; i++)
                {
                    if (malvern[i].getAvailable() == true)
                    {
                        lstMalvern.Items.Add(malvern[i].getName() + " - Available");
                    }
                    else
                    {
                        lstMalvern.Items.Add(malvern[i].getName() + " - Not Available - "
                            + malvern[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            arrayIndex++; //increment array counter

            if(arrayIndex == equipment.Length) //Resize if needed
            {
                Array.Resize(ref equipment, arrayIndex + 10);
            }

            Equipment newEquipment = new Equipment(); //Create new temporary equipment instance

            newEquipment.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
            equipment[arrayIndex] = newEquipment; //Assign to permanent array "Equipment"

            if (chkAvailable.Checked == true)
            {
                newEquipment.setAvailable(true);
            }
            else
            {
                newEquipment.setAvailable(false);
            }

            txtEquipment.Text = ""; //Clear fields
            txtFeatures.Text = "";

            populateList(); //Refresh list
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = lstRedditch.SelectedIndex; //Get no of selected line in listbox

            if(i != -1) //-1 indicates no selection, only proceed if selected
            {
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                equipment[i].setAvailable(chkAvailable.Checked);

                populateList();
            }
            else
            {
                MessageBox.Show("Please select equipment", "Error");
            }
        }
    }
}
