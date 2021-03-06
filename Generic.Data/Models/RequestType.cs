using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Models
{
    public class RequestType
    {
        public int Id { get; set; }  
        public Guid Token { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;

        public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<RequestType>
        {
            public void Configure(EntityTypeBuilder<RequestType> builder)
            {
                      builder.HasKey(A => A.Id);
                //    builder.Property(A => A.Action);
            }
        }
    }
}
