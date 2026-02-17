List<Action> actions = new List<Action>();

for (int i = 1; i <= 5; i++)
{
    int number = i;
    actions.Add(() => { Console.WriteLine(number);});
}

foreach (var action in actions)
{
    action();
}