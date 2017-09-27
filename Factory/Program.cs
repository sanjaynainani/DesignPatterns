using System;

class Program
{
    abstract class Position
    {
        public abstract string Title { get; }
    }

    class QualityAnalyst : Position
    {
        public override string Title
        {
            get
            {
                return "Quality Analyst";
            }
        }
    }

    class BusinessAnalyst : Position
    {
        public override string Title
        {
            get
            {
                return "Business Analyst";
            }
        }
    }

    class Developer : Position
    {
        public override string Title
        {
            get
            {
                return "Developer";
            }
        }
    }

    static class Factory
    {
        /// <summary>
        /// Decides which class to instantiate.
        /// </summary>
        public static Position Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Developer();
                case 1:
                case 2:
                    return new QualityAnalyst();
                case 3:
                default:
                    return new BusinessAnalyst();
            }
        }
    }

    static void Main()
    {
        for (int i = 0; i <= 3; i++)
        {
            var position = Factory.Get(i);
            Console.WriteLine("Where id = {0}, position = {1} ", i, position.Title);
        }
    }
}
