namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = "Ashton";
            int userAge = 31;
            char firstLetterFirstName = 'A';
            bool isMale = true;
            double fakeAge = -1000.0;
            decimal dewey = 0.12345m;

            Console.WriteLine($"My name is {userName}.\n" +
                $"The first letter of my name is {firstLetterFirstName}.\n" +
                $"I am {userAge} years old.\n" +
                $"I tell people I am {fakeAge} years old.\n" +
                $"{dewey} is just a random number.");

            if (isMale)
                Console.WriteLine("I am a male.\n");
            else
                Console.WriteLine("I am a female.\n");
        }
    }
}
