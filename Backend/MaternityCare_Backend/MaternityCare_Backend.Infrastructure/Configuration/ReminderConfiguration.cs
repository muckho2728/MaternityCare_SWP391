using MaternityCare_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaternityCare_Backend.Infrastructure.Configuration
{
	public class ReminderConfiguration : IEntityTypeConfiguration<Reminder>
	{
		public void Configure(EntityTypeBuilder<Reminder> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();
			builder.Property(x => x.Week).IsRequired();
			builder.Property(x => x.Description).IsRequired().HasColumnType("NVARCHAR(MAX)");

			builder.HasData(
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 5,
					Description = "Bạn nên đi khám thai lần đầu và siêu âm hoặc xét nghiệm máu để xác nhận tình trạng mang thai."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 9,
					Description = "Bạn nên sàng lọc trong tam cá nguyệt đầu tiên để kiểm tra tình trạng nhiễm sắc thể."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 13,
					Description = "Đây là thời điểm bắt đầu của tam cá nguyệt thứ hai. Kiểm tra sức khỏe định kỳ là điều cần thiết để kiểm tra xem thai kỳ có tiến triển bình thường không"
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 18,
					Description = "Bạn nên siêu âm dị tật để kiểm tra giải phẫu thai nhi."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 20,
					Description = "Bạn nên siêu âm vào giữa thai kỳ để kiểm tra sự phát triển của thai nhi."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 25,
					Description = "Đây là thời điểm bắt đầu của tam cá nguyệt thứ ba. Bạn nên có lịch trình xét nghiệm hoặc sàng lọc bổ sung (như thiếu máu hoặc tiểu đường thai kỳ)"
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 31,
					Description = "Từ bây giờ, bạn phải lên lịch hẹn khám với bác sĩ một lần mỗi tuần để đảm bảo em bé phát triển khỏe mạnh."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 37,
					Description = "Bây giờ bạn được coi là thai kỳ sớm. Bạn nên được theo dõi thường xuyên."
				},
				new Reminder
				{
					Id = Guid.NewGuid(),
					Week = 39,
					Description = "Bây giờ bạn được coi là đủ tháng. Bạn nên tham dự tất cả các cuộc hẹn khám thai theo lịch trình và liên hệ với bác sĩ nếu bạn gặp bất kỳ thay đổi hoặc khó chịu nào."
				}
			);
		}
	}
}
