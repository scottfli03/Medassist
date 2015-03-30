using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedAssist.Controller;
using MedAssist.DAL;
using MedAssist.Model;

namespace MedAssist.View
{
    //TODO: Create Static Class that keeps track of Employee logged in.
    //TODO: Display which employee is logged in.
    //TODO: Create method that can be used to check if a nurse is logged in.   ----   I can help with some of this stuff.  Let me know.
    public partial class FormLogin : Form
    {
        private ControllerNurse controllerNurse;
        private Nurse nurse;
        private MainForm mainForm;
        public FormLogin()
        {
            InitializeComponent();
            this.controllerNurse = new ControllerNurse();
            //TODO: Add Tags, so that Validation displays a title for the different fields.
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The method manages a nurse login, so that he/she can get access to other 
        /// applications after login button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            if(Validator.IsPresent(textBoxUserName) &&
                Validator.IsPresent(textBoxPassword))
            {
                try
                {
                    this.nurse = this.controllerNurse.GetNurse(userName, password);

                    if (this.nurse != null)
                    {
                        this.mainForm = new MainForm();
                        this.mainForm.Text = "Logged in as " + userName;
                        this.mainForm.Show(); 
                        //TODO: Close login once main form opens.
                        
                    }

                    else
                    {
                        MessageBox.Show("Invalid user name or passoword.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Closes login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: Display message asking them if they are sure they want to exit.  If yes, exit, if no, do nothing.
            this.Close();
        }
    }
}
