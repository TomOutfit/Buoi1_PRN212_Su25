namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new("Nguyen Thi Me", 123);

            // Java : std.setAge(567);
            std.Age = 567;


            // Java : std.getAge();
            Console.WriteLine(std.Age);
        }
    }
}
