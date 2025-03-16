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
    public partial class ContributionPayment : Form
    {
        public ContributionPayment()
        {
            InitializeComponent();
            LbName.Text=Lid.loggedinUser.GetName();
        }
        
        
        private void btnMakePayment_Click(object sender, EventArgs e)
        {

                if(Lid.loggedinUser == null)
            {
                MessageBox.Show("You are not logged in!");

            }
          FinancialManager financialManager = new FinancialManager();

            if (financialManager.HasPaid(Lid.loggedinUser))
            {
                MessageBox.Show("You already paid");
            }
            double contributionamount = 50.00;
            bool paymentsucceed=financialManager.ProcessPayment(Lid.loggedinUser,contributionamount);
            if (paymentsucceed) 
            {
                MessageBox.Show("Your contribution is now paid!");
            
            }
            else
            {
                MessageBox.Show("Please Try Again!");
            }

                
        }

      
    }
}
