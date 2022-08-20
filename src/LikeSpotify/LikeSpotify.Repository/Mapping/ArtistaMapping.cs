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
    public class ArtistaMapping : IEntityTypeConfiguration<Artista>
    {
        public void Configure(EntityTypeBuilder<Artista> builder)
        {
            builder.ToTable("Artista");
            builder.HasKey(x => x.Id);            
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(200);
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("varchar").HasMaxLength(1024);
            builder.Property(x => x.E_Banda).HasColumnType("bit").IsRequired();            
            builder.Property(x => x.Foto).IsRequired().HasColumnType("varchar").HasMaxLength(500);

            builder.HasMany(x => x.Albuns).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
