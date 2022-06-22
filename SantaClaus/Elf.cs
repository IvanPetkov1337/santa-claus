namespace SantaClaus;

internal class Elf
{
    internal void Work(ICommand command)
    {
        command.Execute();
    }
}

