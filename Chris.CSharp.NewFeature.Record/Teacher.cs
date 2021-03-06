﻿namespace Chris.CSharp.NewFeature.Record
{
    public record Teacher : Person
    {
        public string Subject { get; init; }

        public Teacher()
        {

        }

        public Teacher(string first, string last, string sub)
            : base(first, last) => Subject = sub;
    }
}