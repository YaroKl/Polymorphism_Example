using System.ComponentModel;

namespace Polymorphism_Example
{
    internal class Program
    {
        public class News
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Created { get; set; } = DateTime.Now;
            public string GetHappyNews()
            {
                string happyNews = "Happy! " + Description;
                return happyNews;
            }
        }
        
        public class SuperNews : News
        {
            public string SuperMethod()
            {
                string SuperNews = "Super! " + Description;
                return SuperNews;
            }
        }

        static void Main(string[] args)
        {
            News newsObject = new News();
            newsObject.Description = "First News";

            Console.WriteLine("Hello, World!");

            Console.WriteLine(newsObject.Description);

            Console.WriteLine(newsObject.GetHappyNews());

            SuperNews superNewsObject = new SuperNews();
            superNewsObject.Description = "First Super News";

            Console.WriteLine(superNewsObject.Description);

            Console.WriteLine(superNewsObject.GetHappyNews());

            Console.WriteLine(superNewsObject.SuperMethod());
        }
    }
}
