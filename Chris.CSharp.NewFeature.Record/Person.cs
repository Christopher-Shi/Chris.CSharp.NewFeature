namespace Chris.CSharp.NewFeature.Record
{
    public record Person
    {
        public string LastName { get; init; }
        public string FirstName { get; init; }

        public Person()
        {
            
        }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
    }
}
