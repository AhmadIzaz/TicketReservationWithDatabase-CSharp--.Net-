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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonforresever_MouseHover(object sender, EventArgs e)
        {

            buttonforresever.BackColor = Color.LightCyan;
            

        }

        private void buttonforresever_MouseLeave(object sender, EventArgs e)
        {
            buttonforresever.BackColor = Color.LightGray;
        }

        private void buttonforresever_Click(object sender, EventArgs e)
        {

            ReservationSeatForm s = new ReservationSeatForm();
            s.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonforexitonfrontpage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonofcancelreservation_Click(object sender, EventArgs e)
        {
            CancelSeatForm c = new CancelSeatForm();
            c.Show();
            this.Hide();
        }

        private void buttonforCheckStatus_Click(object sender, EventArgs e)
        {
            CheckStatusForm check = new CheckStatusForm();
            check.Show();
            this.Hide();
        }

      
    }
}
