using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class Contribution
    {
        private int contributionid; 
        private double rate;
        private DateTime paymentDate;
        private Lid lid;
        private string status;


        public int ContributionId
        {
            get { return contributionid; }
           private set { contributionid = value; }
        }
        public double Rate
        {
            get { return rate; }
            set {
                if (value <= 0)
                    throw new ArgumentException("The amount must be greater then 0");

                rate = value; }
        } 
        public string Status
        {
            get { return status; }
            private set { status = value; }
        }
        public DateTime PaymentDate
        {
            get { return paymentDate; } 
            
            set {
                if(value>DateTime.Now)
                    throw new ArgumentException("The date cannot be in the future");
                paymentDate = value; }
        }
        public Lid Lid
        {
            get { return lid; }
            private set
            {
                if (value == null)

                    throw new ArgumentNullException("Lid cannot be null!");
               lid = value;

            } 
        }

        public Contribution(double rate, DateTime paymentDate, Lid lid)
        {
            Rate = rate;
            PaymentDate = paymentDate;
            this.lid = lid;
        }

    }
}
