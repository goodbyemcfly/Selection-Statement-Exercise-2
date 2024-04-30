namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Today I will be telling you what your favorite subject in school says about you. Please input the name of your favorite subject below:");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "math":
                    Console.WriteLine($"If you chose {userInput} you're probably a dilligent and hard worker and you recognize how important math is in our daily lives.");
                    break;

                case "science":
                    Console.WriteLine($"If you chose {userInput} you probably watched Breaking Bad once and thought that Walter White was the good guy. No shame though, he's a great character.");
                    break;

                case "english":
                    Console.WriteLine($"If you chose {userInput} you probably used to use an excuses to sneak out of class so you could go bother your English teacher during their lunch break.");
                    break;

                case "history":
                    Console.WriteLine($"If you chose {userInput} one of your parents probably has a hyper fixation on WWII and showed you a lot of war documentaries as a kid, which isn't a bad thing.");
                    break;

                case "physical education":
                    Console.WriteLine($"If you chose {userInput} you probably didn't like school that much and you're porbably in better shape than I am.");
                    break;

                default:
                    Console.WriteLine($"Looks like you chose {userInput}, which was not one of the first 5 subjects that came to mind when I was doing this assignment. And that's not a bad thing, it just means you'll get this default message. Which is probably a good thing, because tbh the individual answers I wrote for the other subjects weren't even that funny.");
                    break;
            }
        }
    }
}