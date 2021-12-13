using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Generic.Data.Models
{
    public class RequestAction
    {
        public int Id { get; set; }       
        public int ActionTypeId { get; set; }
        public string ActionType { get; set; } = string.Empty;
        //ConnectionString, dll location 
        public string Location { get; set; } = string.Empty;
        public string MethodName { get; set; } = string.Empty;
        public string MethodJson { get; set; } = string.Empty;
        public int MethodOrder { get; set; }    
    }

    public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<RequestAction>
    {
        public void Configure(EntityTypeBuilder<RequestAction> builder)
        {
            //    builder.HasKey(A => A.Id);
            //    builder.Property(A => A.Action);
        }
    }
}