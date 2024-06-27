using EntityFramewor.Testing.Configurations;
using EntityFramewor.Testing.Models;

namespace EntityFramewor.Testing.Tests
{
    public class DatabaseTests
    {
        private User savedUser = new();

        [SetUp]
        public void Setup()
        {
            using (var dbContext = new UsersDatabaseContext())
            {
                var user = dbContext.Users.Add(Configuration.TestUser);
                dbContext.SaveChanges();
                savedUser = user.Entity;
            }
        }

        [Test]
        public void ReadEntity()
        {
            var userToOutput = new User();
            using (var dbContext = new UsersDatabaseContext())
            {
                userToOutput = dbContext.Users.ToList().First(user => user.Id == savedUser.Id);
            }
            Console.WriteLine(userToOutput);
        }

        [TearDown]
        public void TearDown()
        {
            using (var dbContext = new UsersDatabaseContext())
            {
                dbContext.Users.Remove(savedUser);
                dbContext.SaveChanges();
            }
        }
    }
}
