using Lecture_10.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_10.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //ID - Primary Key
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            //FirstName
            builder.Property(x => x.FirstName).IsRequired(); //isrequired
            builder.Property(x => x.FirstName).HasMaxLength(60);

            //LastName
            builder.Property(x => x.LastName).IsRequired(); 
            builder.Property(x => x.LastName).HasMaxLength(150);

            //Country
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(150);

            //City
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.City).HasMaxLength(150);

            //Company
            builder.Property(x => x.Company).IsRequired();
            builder.Property(x => x.Company).HasMaxLength(250);

            //Age
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Age).HasColumnType("smallint");
            //int16 yapinca hasconvertion kaldirildi.
            
            
            //RegistrationFee decimal? oldugu icin false ata.
            builder.Property(x => x.RegistrationFee).IsRequired(false);
            builder.Property(x => x.RegistrationFee).HasColumnType("decimal(19,2)"); 
            //19 hane, 17 hane virgulden sonra 2 hane
            //hascolumntype ile decimal'e uzunluk verebiliyoruz.

            // Gender
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Gender).HasConversion<int>(); //enum'u db'ye int yaz.

            // IsGraduated
            builder.Property(x => x.IsGraduated).IsRequired();
            builder.Property(x => x.IsGraduated).HasDefaultValueSql("false");

            // Common Fields
            // Common Fields

            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            // ModifiedByUserId
            builder.Property(x => x.ModifiedByUserId).IsRequired(false);
            builder.Property(x => x.ModifiedByUserId).HasMaxLength(75);

            // LastModifiedOn
            builder.Property(x => x.LastModifiedOn).IsRequired(false);

            // DeletedByUserId
            builder.Property(x => x.DeletedByUserId).IsRequired(false);
            builder.Property(x => x.DeletedByUserId).HasMaxLength(75);

            // DeletedOn
            builder.Property(x => x.DeletedOn).IsRequired(false);

            // IsDeleted
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.ToTable("Students"); //EntityFrameworkCore.Relational ekledim.
        }
    }
}
