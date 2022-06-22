namespace SantaClaus;

internal class CreateDollCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Creating Doll");
    }
}
