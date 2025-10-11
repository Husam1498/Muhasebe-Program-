
using OMPS.DomainKatmani.Abstractions;
using OMPS.DomainKatmani.AppEntities;
// hesap planı tablosu için
namespace OMPS.DomainKatmani.CompanyEnties
{
    //Uniform Chart of Accounts
    public sealed class UCAF:Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }// Ana grup, alt grup, muavin
        /// <summary>
        /// 100 Ana grup
        ///     100.01 kasalarım /Alt grup
        ///         100.01.001 Merkez kasa / Muavin
        ///         100.01.002 Finans kasa / Muavin
        /// bu dosyalamyı kurmak için type değişkeni kurulacak
        /// </summary>
        /// 

    }
}
