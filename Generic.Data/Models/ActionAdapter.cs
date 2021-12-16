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
    public class ActionAdapter
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSource { get; set; }
        public bool? IsTargate { get; set; }
        public string TimeOut { get; set; } = String.Empty;
        public string Value { get; set; } = String.Empty;
        public string Query { get; set; } = String.Empty;
        public string DateTimeFormat { get; set; } = String.Empty;
        public string RootPathOrUrl { get; set; } = String.Empty;
        public string AuthenticationType { get; set; } = String.Empty;
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string Domain { get; set; } = String.Empty;
        public string cartificate { get; set; } = String.Empty;

        public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<ActionAdapter>
        {
            public void Configure(EntityTypeBuilder<ActionAdapter> builder)
            {
                builder.HasKey(A => A.Id);
                //    builder.Property(A => A.Action);
            }
        }

    }
}
