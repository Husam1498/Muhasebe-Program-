using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.DomainKatmani.Repository
{
    public interface  IRepository
    {
        void CreateDbContextInstance(DbContext context);// iki tane context olduğu için crud işlemlerinde hangi veirtabanına göndereceğini belirlemek içn
    }
}
