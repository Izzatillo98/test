using test.model;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student;
            ShowStudentInfo(out student);
            Console.WriteLine(student.Surname);
        }
        //params
        static void Add(params int[]b) 
        {
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            { 
                sum += b[i];
            }
            Console.WriteLine(sum);
        }
        static void ShowStudentInfo(out Student student)
        {
            student = new Student("Tillo");  
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            student.Surname = "Abdusamatov";
            
        }
    }

}
