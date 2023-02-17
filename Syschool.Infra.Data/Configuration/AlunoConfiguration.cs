﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Syschool.Domain.Entities;

namespace Syschool.Infra.Data.Configuration
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.Sobrenome).IsRequired().HasColumnType("varchar(80)");
            builder.Property(x => x.Cpf).IsRequired().HasColumnType("varchar(11)");
            builder.Property(x => x.Logradouro).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Numero).IsRequired().HasColumnType("varchar(20)");
            builder.Property(x => x.Complemento).HasColumnType("varchar(30)");
            builder.Property(x => x.Cidade).IsRequired().HasColumnType("varchar(30)");
            builder.Property(x => x.Uf).IsRequired().HasColumnType("varchar(2)");
            builder.Property(x => x.Cep).IsRequired().HasColumnType("varchar(8)");
            builder.Property(x => x.DataMatricula).IsRequired().HasColumnType("date");
            builder.Property(x => x.DataNascimento).IsRequired().HasColumnType("date");
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Matricula).IsRequired().HasColumnType("varchar(50)");
        }
    }
}
