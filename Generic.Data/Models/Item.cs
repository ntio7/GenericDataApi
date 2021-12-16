using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Parent { get; set; } = string.Empty;
        public int Level { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;

        public JArray? ValueArray { get; set; }

        public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<Item>
        {
            public void Configure(EntityTypeBuilder<Item> builder)
            {
                //builder.HasKey(A => A.Id);
                builder.HasNoKey();
                //    builder.Property(A => A.Action);
            }
        }
    }

    public class ItemKey
    {

        public int Id { get; set; }
        public int ActionId { get; set; }
        public string SourceKey { get; set; } = string.Empty;
        public string NewKey { get; set; } = string.Empty;
        public int KeyLevel { get; set; }

        public class MethodActionEntityTypeConfiguration : IEntityTypeConfiguration<ItemKey>
        {
            public void Configure(EntityTypeBuilder<ItemKey> builder)
            {
                builder.HasKey(A => A.Id);
                //    builder.Property(A => A.Action);
            }
        }

    }
}
