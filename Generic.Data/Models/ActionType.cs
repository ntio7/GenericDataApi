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
    /// <summary>
    /// ActionTyps = Api, Porcidure, from file - dll,send mail, sms...
    /// </summary>
    public class ActionType
    {
       
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;

        public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<ActionType>
        {
            public void Configure(EntityTypeBuilder<ActionType> builder)
            {
                builder.HasKey(A => A.Id);
                //    builder.Property(A => A.Action);
            }
        }

    }
}
