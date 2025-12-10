using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITI_Interview.Data
{
    public class EmpolyeeConfiguration : IEntityTypeConfiguration<Empolyee>
    {
        public void Configure(EntityTypeBuilder<Empolyee> builder)
        {
            builder.ToTable("Employees").HasKey(e => e.Id);

        }
    }
}
