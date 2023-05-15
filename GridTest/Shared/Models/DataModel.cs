
namespace GridTest.Shared.Models
{
    public static class DataModel
    {
        private static List<Person> people = new()
        {
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Andy",
                BirthDate = DateTime.Parse("1994-05-12")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Jane",
                BirthDate = DateTime.Parse("1992-02-08")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Kim",
                BirthDate = DateTime.Parse("1984-09-13")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Paul",
                BirthDate = DateTime.Parse("1977-09-15")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Kevin",
                BirthDate = DateTime.Parse("1970-11-27")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Robert",
                BirthDate = DateTime.Parse("1993-05-12")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Conan",
                BirthDate = DateTime.Parse("1999-11-09")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Justin",
                BirthDate = DateTime.Parse("1984-04-26")
            },
            new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Diana",
                BirthDate = DateTime.Parse("1998-02-16")
            }
        };

        public static List<Person> GetPeople()
        {
            return people;
        }
    }
}
