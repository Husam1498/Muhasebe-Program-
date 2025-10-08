using OMPS.DomainKatmani.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.DomainKatmani.AppEntities
{
    public sealed class Company:Entity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxDepartment { get; set; } // Vergi Numarası
        public string Tel { get; set; }
        public string Email { get; set; }

    }
}
