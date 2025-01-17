using MaternityCare_Backend.Domain.Entities;
using MaternityCare_Backend.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MaternityCare_Backend.Infrastructure.Persistence
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
			modelBuilder.ApplyConfiguration(new BlogConfiguration());
			modelBuilder.ApplyConfiguration(new CommentConfiguration());
			modelBuilder.ApplyConfiguration(new DoctorConfiguration());
			modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
			modelBuilder.ApplyConfiguration(new FetusConfiguration());
			modelBuilder.ApplyConfiguration(new FetusHealthConfiguration());
			modelBuilder.ApplyConfiguration(new LikeConfiguration());
			modelBuilder.ApplyConfiguration(new PackageConfiguration());
			modelBuilder.ApplyConfiguration(new ReminderConfiguration());
			modelBuilder.ApplyConfiguration(new SlotConfiguration());
			modelBuilder.ApplyConfiguration(new RoleConfiguration());
			modelBuilder.ApplyConfiguration(new StandardFetusHealthConfiguration());
			modelBuilder.ApplyConfiguration(new SubscriptionConfiguration());
			modelBuilder.ApplyConfiguration(new TagConfiguration());
			modelBuilder.ApplyConfiguration(new TransactionConfiguration());
			modelBuilder.ApplyConfiguration(new UserConfiguration());
		}

		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }
		public DbSet<Fetus> Fetuses { get; set; }
		public DbSet<FetusHealth> FetusHealths { get; set; }
		public DbSet<Like> Likes { get; set; }
		public DbSet<Package> Packages { get; set; }
		public DbSet<Reminder> Reminders { get; set; }
		public DbSet<Slot> Slots { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<StandardFetusHealth> StandardFetusHealths { get; set; }
		public DbSet<Subscription> Subscriptions { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
