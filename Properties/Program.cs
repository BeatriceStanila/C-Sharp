namespace Properties
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person (new DateTime(1989, 12, 13));
            
            Console.WriteLine(person.Age);
        }
    }
}