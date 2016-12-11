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
    public partial class CancelSeatForm : Form
    {
        public CancelSeatForm()
        {
            InitializeComponent();
        }

        private void CancelSeatForm_Load(object sender, EventArgs e)
        {
            labelofentercniconcanlform.Parent = pictureBoxofbgimgincancelform;
            labelofentercniconcanlform.BackColor = Color.Transparent;
            labelofseatnooncanelform.Parent = pictureBoxofbgimgincancelform;
            labelofseatnooncanelform.BackColor = Color.Transparent;
            pictureBoxofcanceloncancelseatform.Parent = pictureBoxofbgimgincancelform;
            pictureBoxofcanceloncancelseatform.BackColor = Color.Transparent;
            pictureBoxofdeletefilelogoincanceform.Parent = pictureBoxofbgimgincancelform;
            pictureBoxofdeletefilelogoincanceform.BackColor = Color.Transparent;
            pictureBoxofgobackincancelreservseat.Parent = pictureBoxofbgimgincancelform;
            pictureBoxofgobackincancelreservseat.BackColor = Color.Transparent;
           

        }

        private void pictureBoxofgobackincancelreservseat_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f = new MainForm();
            f.Show();
        }

        private void pictureBoxofcanceloncancelseatform_Click(object sender, EventArgs e)
        {
            if (textBoxofentercniconcancelform.Text == string.Empty)
                errorProviderforcnicinchecck.SetError(textBoxofentercniconcancelform, "Cant Leave Empty");
            else if (textBoxofentercniconcancelform.Text == string.Empty)
                errorProviderforseatno.SetError(textBoxofseatnooncancelform,"Can not Leave Empty");
            else
            {
                FacadeController f = FacadeController.getfacadecontroller();
                bool flag = f.remove(this.textBoxofentercniconcancelform.Text, this.textBoxofseatnooncancelform.Text.ToUpper());
                if (flag == true)
                {
                    MessageBox.Show("Your Seat is Cancelled !", "Seat  Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxofentercniconcancelform.Clear();
                    textBoxofseatnooncancelform.Clear();
                    textBoxofentercniconcancelform.Focus();
                }
                else
                {
                    MessageBox.Show(" Cannot cancel non-reserved seat! Or Cnic Format is wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxofentercniconcancelform.Clear();
                    textBoxofseatnooncancelform.Clear();
                    textBoxofseatnooncancelform.Focus();
                }
            }
        }
    } 
}
