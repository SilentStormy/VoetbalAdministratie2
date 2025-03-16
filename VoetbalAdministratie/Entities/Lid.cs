using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class Lid
    {
        private int lidid;
        private string firstname;
        private string lastname;
        private DateTime dateofbirth;
        private string email;
        private string password;
        private string role;
        public static Lid loggedinUser { get; private set; }
        public Lid() { }

        public int LidID
        {
            get { return lidid; }
            set
            {
                lidid = value;
            }
        }
        public string Firstname {
            get { return firstname; } 
            
            set {

                if (!string.IsNullOrWhiteSpace(value))

                    firstname = value;
                else throw new ArgumentException("Firstname cannot be empty");
                    
            } 
        }
        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    lastname = value;
                else throw new ArgumentException("Lastname cannnot be empty");
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Date of birth cannot be in the future");
                dateofbirth = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Contains("@"))
                    email = value;
                else throw new ArgumentException("InvalidFormat");
            }
        } 
        public string Password
        {
            get { return password; }
           private set
            {
                if(!string.IsNullOrWhiteSpace(value) && value.Length>6)
                password = value;
                else throw new ArgumentException("Password must have at least 6 charachters");
            }
        }
        public string Role
        {
            get { return role; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                    role = value;
                else throw new ArgumentException("a role must be chosen");
            
            }
        }
        public Lid(string firstname, string lastname, DateTime dateofbirth, string email, string password,string role)
        {
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth= dateofbirth;
            Email = email;
            Password = password;
            Role = role;
            
        }

        public Lid(string email, string password)
        {
            Email = email;
            Password = password;
        }
      

        public virtual string GetRole()
        {
            return "Lid";
        }
        public string GetName()
        {
            return Firstname;
        }

        public static void AddLoggedInUser(Lid user)
        {
            if (user != null)
            {
                loggedinUser = user;
            }
            else throw new ArgumentException("User cannot be null");
        }

     
    }
}
