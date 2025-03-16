using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class Director:Lid
    {
        public override string GetRole()
        {
            return "Director";
        }
    }
}
