using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepeateLessons.Database.Entities
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.UserId)
                .ValueGeneratedOnAdd();
            builder.Property(user => user.LastName)
                .HasMaxLength(50);
            builder.Property(user => user.FirstName)
                .HasMaxLength(50);
            builder.Property(user => user.FullName)
                .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");
            builder.Property(user => user.Age)
                .HasDefaultValue(18);

            builder.HasData(GetDefaultData());
        }

        private static User[] GetDefaultData()
        {
            User[] users = new User[]
            {
                new User { UserId = 1, FirstName = "Никита", LastName = "Палин", Age = 23 },
                new User { UserId = 2, FirstName = "Олег", LastName = "Петров", Age = 26 },
                new User { UserId = 3, FirstName = "Иван", LastName = "Сергеев", Age = 18 },
                new User { UserId = 4, FirstName = "Петр", LastName = "Полеев", Age = 19 },
                new User { UserId = 5, FirstName = "Георгий", LastName = "Андреев", Age = 24 },
                new User { UserId = 6, FirstName = "Роман", LastName = "Микушин", Age = 21 },
                new User { UserId = 7, FirstName = "Андрей", LastName = "Петроханов", Age = 20 },
                new User { UserId = 8, FirstName = "Никита", LastName = "Ольхов", Age = 28 },
                new User { UserId = 9, FirstName = "Вячеслав", LastName = "Сергеев", Age = 23 },
                new User { UserId = 10, FirstName = "Евгений", LastName = "Андропов", Age = 31 },
            };

            return users;
        }
    }
}
