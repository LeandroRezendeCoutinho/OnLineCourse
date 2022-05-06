namespace OnLineCourse.Domain
{
    public class Course
    {
        public string Name { get; set; }
        public int WorkLoad { get; set; }
        public string TargetAudience { get; set; }
        public decimal Price { get; set; }

        public Course(string name, int workLoad, string targetAudience, decimal price)
        {
            Name = name;
            WorkLoad = workLoad;
            TargetAudience = targetAudience;
            Price = price;
        }
    }
}