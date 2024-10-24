public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"How long, in seconds, would you like your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        Console.WriteLine("Get ready...");
        ShowCountDown(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> { "|", "/", "—", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected int GetDuration()
    {
        return _duration;
    }
}
