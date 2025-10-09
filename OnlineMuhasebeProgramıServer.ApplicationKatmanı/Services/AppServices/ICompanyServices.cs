using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.ApplicationKatmanı.Services.AppServices
{
    public  interface ICompanyServices
    {
        Task CreateCompanyAsync(CreateCompayRequest request);
    }
}
