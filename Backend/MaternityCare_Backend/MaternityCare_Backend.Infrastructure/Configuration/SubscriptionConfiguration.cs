﻿using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
	{
		public void Configure(EntityTypeBuilder<Subscription> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.UserId).IsRequired();
			builder.Property(x => x.PackageId).IsRequired();
			builder.Property(x => x.StartDate);
			builder.Property(x => x.EndDate);
			builder.HasOne(x => x.User).WithMany(x => x.Subscriptions).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Package).WithMany(x => x.Subscriptions).HasForeignKey(x => x.PackageId).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Transaction).WithOne(x => x.Subscription).HasForeignKey<Transaction>(x => x.SubscriptionId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
