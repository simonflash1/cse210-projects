using System;
// I added the ability to see how many times each goal type has been recoreded along with how many times each eternal goal has been completed
// ASCII fireworks for when you comeplete a goal
// A sumary of the completed goals
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}