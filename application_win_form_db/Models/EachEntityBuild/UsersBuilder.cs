﻿
namespace application_win_form_db.Models.EachEntityBuild
{
	internal static class UsersBuilder
	{
		public static void UsersBuild(this ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<User>(entity =>
			{
				entity.Property(e => e.UserId)
					.ValueGeneratedNever()
					.HasColumnName("user_id");

				entity.Property(e => e.Login)
					.HasMaxLength(100)
					.IsUnicode(false)
					.HasColumnName("login");

				entity.Property(e => e.Password)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("password");

				entity.Property(e => e.Role)
					.HasMaxLength(50)
					.HasColumnName("role");

				entity.Property(e => e.Notes)
					.HasMaxLength(1000)
					.HasColumnName("notes");
			});

			modelBuilder.Entity<User>().HasData(
				new User { UserId = 1, Login = "admin", Password = "123", Role = "Admin", Notes="Edit yout Notes" },
				new User { UserId = 2, Login = "analyst", Password = "456", Role = "Analyst", Notes = "Edit yout Notes" },
				new User { UserId = 3, Login = "application_operator", Password = "789", Role = "Application Operator", Notes = "Edit yout Notes" },
				new User { UserId = 4, Login = "survey_operator", Password = "910", Role = "Survey Operator", Notes = "Edit yout Notes" }
			);
		}
	}
}
