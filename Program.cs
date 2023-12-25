namespace JCD_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your middle name?");
            string middleName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What's your gender?");
            string gender = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your year of birth?");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your current job?");
            string job = Console.ReadLine();

            Console.WriteLine("Qual é a sua altura?");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("What color are your eyes?");
            string eyes = Console.ReadLine();

            DateTime dataAtual = DateTime.Now;
            int age1 = DateTime.Now.Year - year;


            Console.WriteLine($"My full name is {firstName} {middleName} {lastName}");

            Console.WriteLine($"My gender is {gender}");

            Console.WriteLine($"My age is {age}");

            Console.WriteLine($"My year of birth is {year}");

            Console.WriteLine($"My job curret is {job}");

            Console.WriteLine($"My eyes are the color {eyes}");

            Console.WriteLine($"Your age is {age1}");

            Console.WriteLine($"My height is {altura}");

        }
    }
}