namespace Generic.Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MethodAction
{
    public int Id { get; set; }
    public string Action1 { get; set; } = string.Empty;
    public string ActionName { get; set; } = string.Empty;
}

public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<MethodAction>
{
    public void Configure(EntityTypeBuilder<MethodAction> builder)
    {
    //    builder.HasKey(A => A.Id);
    //    builder.Property(A => A.Action);
    }
}