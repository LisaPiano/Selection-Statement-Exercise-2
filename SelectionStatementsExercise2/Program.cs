namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your favorite subject in school? Please type here:");
            string favSubject = Console.ReadLine();
            
            switch (favSubject.ToLower())
            {
                case ("math"):
                case ("calculus"):
                    Console.WriteLine($"Wonderful! I also really like math.");
                    break;
                case ("english"):
                    Console.WriteLine($"Great! I also like English. Reading great literature can be so fun!");
                    break;
                case ("science"):
                case ("biology"):
                case ("chemistry"):
                    Console.WriteLine($"That is fantastic! My dad is a scientist.");
                    break;
                case ("geography"):
                    Console.WriteLine($"Very interesting! I was always terrible with geography.");
                    break;
                case ("computer programming"):
                    Console.WriteLine($"Aha! That is my favorite as well!");
                    break;
                default:
                    Console.WriteLine("Wow! I don't think that I have ever taken that class!");
                    break;
            }
        }
    }
}