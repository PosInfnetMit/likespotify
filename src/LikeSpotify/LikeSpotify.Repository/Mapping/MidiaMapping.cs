using LikeSpotify.Domain.Album;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeSpotify.Repository.Mapping
{
    public class MidiaMapping : IEntityTypeConfiguration<Midia>
    {
        public void Configure(EntityTypeBuilder<Midia> builder)
        {
            builder.ToTable("Midia");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);

            //atributo para ser utilizado com os ValueObjects
            builder.OwnsOne(x => x.Tempo_Midia, p =>
            {
                p.Property(f => f.Valor).HasColumnName("Tempo_Midia").IsRequired();
            });
        }
    }
}
