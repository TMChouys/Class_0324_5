namespace Class_0324_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.Count);


            Student joe;
            joe = new Student(1234, "AAA", 92, 88);
            Console.WriteLine(joe.GetStudent());
            Console.WriteLine(Student.Count);

            Student mary = new Student(1234, "AAA", 92, 88);
            Console.WriteLine(Student.Count);

            Student tom = new Student(1234, "AAA", 92, 88);
            Console.WriteLine(Student.Count);

        }
    }
}
