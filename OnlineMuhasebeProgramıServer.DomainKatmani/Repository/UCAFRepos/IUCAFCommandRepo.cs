using OMPS.DomainKatmani.CompanyEnties;
using OMPS.DomainKatmani.Repository.GenericRepository.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.DomainKatmani.Repository.UCAFRepos
{
    public interface IUCAFCommandRepo:ICompanyDbCommandRepo<UCAF>
    {
    }
}
