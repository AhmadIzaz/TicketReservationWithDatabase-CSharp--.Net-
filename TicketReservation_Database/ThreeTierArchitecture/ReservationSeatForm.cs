using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace ThreeTierArchitecture
{   
    public partial class ReservationSeatForm : Form
    {
        FacadeController f = FacadeController.getfacadecontroller();
        public ReservationSeatForm()
        {
            InitializeComponent();
        }

        private void ReservationSeatForm_Load(object sender, EventArgs e)
        {
            comboBoxofavailableseats.Sorted = true;
            pictureBoxofbackinresevrseat.Parent = pictureBoxofreserveseat;
            pictureBoxofbackinresevrseat.BackColor = Color.Transparent;
            pictureBoxofreservebuttoninreserveseatform.Parent = pictureBoxofreserveseat;
            pictureBoxofreservebuttoninreserveseatform.BackColor = Color.Transparent;
            labelofcntactnoonreservseat.Parent = pictureBoxofreserveseat;
            labelofcntactnoonreservseat.BackColor = Color.Transparent;
            labelofcNIConreserveseat.Parent = pictureBoxofreserveseat;
            labelofcNIConreserveseat.BackColor = Color.Transparent;
            labelpfseatnoonreserveseat.Parent = pictureBoxofreserveseat;
            labelpfseatnoonreserveseat.BackColor = Color.Transparent;
            labelofenternameonreservseat.Parent = pictureBoxofreserveseat;
            labelofenternameonreservseat.BackColor = Color.Transparent;
            labelpersonalinfoonreserveform.Parent = pictureBoxofreserveseat;
            labelpersonalinfoonreserveform.BackColor = Color.Transparent;
        }

        private void pictureBoxofbackinresevrseat_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f = new MainForm();
            f.Show();
        }

        private void pictureBoxofreservebuttoninreserveseatform_Click(object sender, EventArgs e)
        {
            string name = textBoxforenternameonreserverseat.Text;
            string contactno = textBoxforcontactnoonrerserveseat.Text;
            string cnic = textBoxforcniconreserveseat.Text;
            string seatno = null;
            if (comboBoxofavailableseats.SelectedIndex != -1)
            {
                
                seatno = comboBoxofavailableseats.SelectedItem.ToString();
            }
            else
            {
                errorProviderforseatnoinreserveseatform.SetError(comboBoxofavailableseats, "Select Seat");
                //  MessageBox.Show("Can not Leave Empty Seat NO" , "Error !" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                comboBoxofavailableseats.Focus();
            }
            string t = f.checkandgive(name, contactno, cnic, seatno);
            if (t == "true")
            {
                MessageBox.Show("Seat is Reserved for you", "Seat Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxforenternameonreserverseat.Clear();
                textBoxforcontactnoonrerserveseat.Clear();
                textBoxforcniconreserveseat.Clear();
            
            }
            if(t == name)
            {

                
               // MessageBox.Show("Wrong Input", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxforenternameonreserverseat.Clear();
                textBoxforenternameonreserverseat.Focus();
                errorProviderforenternameinreserveseatform.SetError(textBoxforenternameonreserverseat, "Wrong Input");
            }
            if (t == contactno)
            {
                         // MessageBox.Show("Wrong Input", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxforcontactnoonrerserveseat.Clear();
                textBoxforcontactnoonrerserveseat.Focus();
                errorProviderforcntactnoinreserveseatform.SetError(textBoxforcontactnoonrerserveseat, "Wrong Input");

            }
            if(t == cnic)
            {
            //    MessageBox.Show("Wrong Input", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxforcniconreserveseat.Clear();
                textBoxforcniconreserveseat.Focus();
                errorProviderforcnicinreserveseatform.SetError(textBoxforcniconreserveseat, "Wrong Input");

            }
            if (t == seatno)
            {
                MessageBox.Show("Seat is Already Reserved", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxofavailableseats.Focus();
 
            }
            
        }

        private void comboBoxofavailableseats_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderforseatnoinreserveseatform.Clear();
        }

        private void textBoxforenternameonreserverseat_TextChanged(object sender, EventArgs e)
        {
            errorProviderforenternameinreserveseatform.Clear();
        }

        private void textBoxforcontactnoonrerserveseat_TextChanged(object sender, EventArgs e)
        {
            errorProviderforcntactnoinreserveseatform.Clear();
        }

        private void textBoxforcniconreserveseat_TextChanged(object sender, EventArgs e)
        {
            errorProviderforcnicinreserveseatform.Clear();
        }
        }
    }
