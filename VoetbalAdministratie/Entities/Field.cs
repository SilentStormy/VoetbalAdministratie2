using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class Field
    {
        private int fieldid;
        private string fieldname;
        public Match Match { get; private set; }

        public int FieldID
        {
            get { return fieldid; }
            set { fieldid = value; }
        }
        public string Fieldname
        {
            get { return fieldname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(fieldname))
                    fieldname = value;
                else throw new ArgumentException("Fieldname cannot be empty");
            }


        }
        public string GetName(string fieldname)
        {
            return Fieldname;
        }
    }
}
