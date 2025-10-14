using OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMPS.ApplicationKatmanı.Services.CompanyServices
{
    public interface IUCAFServis
    {
        Task CreateUCAFAsync(CreateUCAFCommand request);
    }
}
