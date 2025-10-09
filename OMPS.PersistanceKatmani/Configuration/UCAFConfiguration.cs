using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OMPS.DomainKatmani.CompanyEnties;
using OMPS.PersistanceKatmani.Constans;

namespace OMPS.PersistanceKatmani.Configuration
{
    public sealed class UCAFConfiguration : IEntityTypeConfiguration<UCAF>
    {
        public void Configure(EntityTypeBuilder<UCAF> builder)
        {
            builder.ToTable(TableName.UCAF);
            builder.HasKey(e => e.Id);
        }
    }
}
