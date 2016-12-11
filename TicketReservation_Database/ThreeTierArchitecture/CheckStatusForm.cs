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
    public partial class CheckStatusForm : Form
    {

        
        public CheckStatusForm()
        {
            InitializeComponent();
        }

        private void CheckStatusForm_Load(object sender, EventArgs e)
        {
            pictureBoxofbackincheckstatusform.Parent = panelofcheckstatus;
            pictureBoxofbackincheckstatusform.BackColor = Color.Transparent;
            checkstatus();
        }
        private void checkstatus()
        {
          FacadeController f = FacadeController.getfacadecontroller();
          string []array =   f.checkstatus();
          if (array != null)
          {
              for (int i = 0; i < array.Length; i++)
              {
                  if (array[i] == "71K")
                  {
                      label71k.ForeColor = Color.Red;
                  }
                  else if (array[i] == "71J")
                  {
                      label71j.ForeColor = Color.Red;
                  }
                  else if (array[i] == "72K")
                  {
                      label72k.ForeColor = Color.Red;
                  }
                  else if (array[i] == "72J")
                  {
                      label72j.ForeColor = Color.Red;
                  }
                  else if (array[i] == "72A")
                  {
                      label72a.ForeColor = Color.Red;
                  }
                  else if (array[i] == "72B")
                  {
                      label72b.ForeColor = Color.Red;
                  }
                  else if (array[i] == "73J")
                  {
                      label73j.ForeColor = Color.Red;
                  }
                  else if (array[i] == "73K")
                  {
                      llabel73k.ForeColor = Color.Red;
                  }
                  else if (array[i] == "73A")
                  {
                      llabel73a.ForeColor = Color.Red;
                  }
                  else if (array[i] == "73B")
                  {
                      llabel73b.ForeColor = Color.Red;
                  }
                  else if (array[i] == "77J")
                  {
                      llabel77j.ForeColor = Color.Red;
                  }
                  else if (array[i] == "77K")
                  {
                      llabel77k.ForeColor = Color.Red;
                  }
                  else if (array[i] == "77A")
                  {
                      llabel77a.ForeColor = Color.Red;
                  }
                  else if (array[i] == "77B")
                  {
                      llabel77b.ForeColor = Color.Red;
                  }
                  else if (array[i] == "78J")
                  {
                      llabel78j.ForeColor = Color.Red;
                  }
                  else if (array[i] == "78K")
                  {
                      llabel78k.ForeColor = Color.Red;
                  }
                  else if (array[i] == "78A")
                  {
                      llabel78a.ForeColor = Color.Red;
                  }
                  else if (array[i] == "78B")
                  {
                      llabel78b.ForeColor = Color.Red;
                  }
                  else if (array[i] == "79K")
                  {
                      llabel79k.ForeColor = Color.Red;
                  }
                  else if (array[i] == "79J")
                  {
                      llabel79j.ForeColor = Color.Red;
                  }
              }
              }
          else
          {
                      label71k.ForeColor = Color.Black;
                  
                      label71j.ForeColor = Color.Black;
                  
                  
                      label72k.ForeColor = Color.Black;
                  
                      label72j.ForeColor = Color.Black;
                  
                      label72a.ForeColor = Color.Black;
                  
                      label72b.ForeColor = Color.Black;
                  
                      label73j.ForeColor = Color.Black;
                  
                      llabel73k.ForeColor = Color.Black;
                  
                      llabel73a.ForeColor = Color.Black;
                  
                      llabel73b.ForeColor = Color.Black;
                  
                      llabel77j.ForeColor = Color.Black;
                  
                      llabel77k.ForeColor = Color.Black;
                 
                      llabel77a.ForeColor = Color.Black;
                  
                  
                      llabel77b.ForeColor = Color.Black;
                  
                  
                      llabel78j.ForeColor = Color.Black;
                  
                  
                      llabel78k.ForeColor = Color.Black;
                  
                  
                      llabel78a.ForeColor = Color.Black;
                  
                  
                      llabel78b.ForeColor = Color.Black;
                  
                  
                      llabel79k.ForeColor = Color.Black;
                  
                  
                      llabel79j.ForeColor = Color.Black;
                  
 
          }
         
         
        }

      

   

        private void pictureBoxofbackincheckstatusform_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm F = new MainForm();
            F.Show();

        }

        private void pictureBoxofexitinchecktatusform_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
