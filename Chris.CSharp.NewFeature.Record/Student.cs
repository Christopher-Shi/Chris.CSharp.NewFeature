namespace Chris.CSharp.NewFeature.Record
{
    public sealed record Student : Person
    {
        public int Level { get; init; }

        public Student()
        {

        }

        public Student(string first, string last, int level) : base(first, last) => Level = level;
    }
}