namespace GridTest.Shared.Models
{
    public class Person
    {
        public PersonId Id { get; set; } = new();

        public PersonName Name { get; set; } = new();

        public string Gender { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Cell { get; set; } = string.Empty;

        public string Nat { get; set; } = string.Empty;
    }

    public class PersonName
    {
        public string Title { get; set; } = string.Empty;

        public string First { get; set; } = string.Empty;

        public string Last { get; set; } = string.Empty;
    }

    public class PersonId
    {
        public string Name { get; set; } = string.Empty;

        public string Value { get; set; } = Guid.NewGuid().ToString().Split("-")[0];
    }
}
