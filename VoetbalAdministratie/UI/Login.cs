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
    public partial class Login : Form
    {
        private MembershipManager _membershipManager;
        
        public Login(MembershipManager membershipManager)
        {
            InitializeComponent();
            _membershipManager = membershipManager;
          
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Lid user=new Lid(textBoxEmail.Text,textBoxPassword.Text);

            bool isAuthenticated= _membershipManager.Login(user);

            if (isAuthenticated)
            {
                MessageBox.Show("You are logged in! ");
                
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Invalid Email or Password");
            }
        }
    }
}
