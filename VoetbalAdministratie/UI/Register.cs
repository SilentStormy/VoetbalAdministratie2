using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoetbalAdministratie
{
    public partial class Register : Form
    {
        
        private MembershipManager _membershipManager;
        public Register(MembershipManager membershipManager)
        {
            InitializeComponent();
            _membershipManager = membershipManager;
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string selectedRole = "";
            if (CBDirector.Checked) 
            
            {
                selectedRole = "Director";
            }
             if (CBCoach.Checked) 
            
            {
                selectedRole = "Coach";
            }
             if (CBPlayer.Checked) 
            
            {
                selectedRole = "Player";
            }



            Lid lid=new Lid(txtboxfirstname.Text,txtboxlastname.Text, DateTime.Parse(txtboxdateofbirth.Text),txtboxemail.Text, txtboxpassword.Text,selectedRole);
            
            _membershipManager.Register(lid);

            MessageBox.Show("Welcome! You are now registerd!");
            this.Close();
            Login loginform = new Login(_membershipManager);
            loginform.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginform = new Login(_membershipManager);
            loginform.ShowDialog();
            this.Close();
        }
    }
}
