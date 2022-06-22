namespace SantaClaus;

internal class CreateBicycleCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Creating Bycicle");
    }
}
