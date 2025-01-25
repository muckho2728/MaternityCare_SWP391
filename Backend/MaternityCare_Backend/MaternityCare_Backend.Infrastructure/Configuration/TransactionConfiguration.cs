using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
	{
		public void Configure(EntityTypeBuilder<Transaction> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Amount).IsRequired();
			builder.Property(x => x.Description).IsRequired();
			builder.Property(x => x.CreatedAt);
			builder.Property(x => x.Status).HasConversion<string>().IsRequired();
			builder.Property(x => x.SubscriptionId).IsRequired();
			builder.HasOne(x => x.Subscription).WithOne(x => x.Transaction).HasForeignKey<Transaction>(x => x.SubscriptionId).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
