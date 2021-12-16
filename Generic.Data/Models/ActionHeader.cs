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
    public class ActionHeader
    {
      
        public int Id { get; set; }
        public int ActionId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Value { get; set; } = String.Empty;

        public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<ActionHeader>
        {
            public void Configure(EntityTypeBuilder<ActionHeader> builder)
            {
                builder.HasKey(A => A.Id);
                //    builder.Property(A => A.Action);
            }
        }
    }
}
