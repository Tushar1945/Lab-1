namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<Students> listStudent = new List<Students>
           {
               new Students { StudentID = 1, Name = "Tejas Sonawane", Marks = 80},
               new Students { StudentID = 2, Name = "Tushar Chaudhari", Marks = 90},
               new Students { StudentID = 3, Name = "Yogesh Rajpure", Marks = 75},
               new Students { StudentID = 4, Name = "John", Marks = 70}
           };

            IEnumerable<Students> studentResult = from student in listStudent where student.Marks == 90 select student;

            foreach (Students sdt in studentResult)
            {
                Console.WriteLine(sdt.StudentID + " " + sdt.Name + " " + sdt.Marks);

            }
        }

    }
    public class Students
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}