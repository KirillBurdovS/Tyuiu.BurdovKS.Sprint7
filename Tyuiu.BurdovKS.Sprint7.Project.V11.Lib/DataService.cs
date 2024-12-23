





namespace Tyuiu.BurdovKS.Sprint7.Project.V11.Lib
{
    public class DataService
    {

        public class Person
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public DateTime BirthDate { get; set; }
            public string Profession { get; set; }
            public DateTime StartDate { get; set; }
            public int SizeOfShoe { get; set; }
            public int Height { get; set; }
            public string University { get; set; }
            public int Age { get; set; }
            public string EyeColor { get; set; }
        }

        public static class Sorter
        {
            public static List<Person> SortByHeight(List<Person> people)
            {
                return people.OrderBy(p => p.Height).ToList();
            }

            public static List<Person> SortByShoeSize(List<Person> people)
            {
                return people.OrderBy(p => p.SizeOfShoe).ToList();
            }
        }
    }



}
