using OMPS.DomainKatmani.CompanyEnties;
using OMPS.DomainKatmani.Repository.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.DomainKatmani.Repository.UCAFRepos
{
    public interface IUCAFQueryRepo:ICompanyDbQueryRepo<UCAF>
    {
    }
}
