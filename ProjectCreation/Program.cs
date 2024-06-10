class ProjectCreation
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());
        int neededHours = number * 3;

        Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {number} project/s.");
    }
}