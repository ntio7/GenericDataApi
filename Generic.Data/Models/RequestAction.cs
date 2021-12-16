using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.ComponentModel.DataAnnotations;

namespace Generic.Data.Models
{
    public class RequestAction
    {
        public int Id { get; set; }
        public int ActionTypeId { get; set; }
        public int AdapterId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;  
        public string MethodName { get; set; } = string.Empty;
        public string MethodJson { get; set; } = string.Empty;
        public int MethodOrder { get; set; }


    }

    public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<RequestAction>
    {
        public void Configure(EntityTypeBuilder<RequestAction> builder)
        {
                  builder.HasKey(A => A.Id);
            //    builder.Property(A => A.Action);
        }
    }
}