namespace SantaClaus;

internal class MagicBoard : IMagicBoard
{
    private List<Elf> _elves;

    public MagicBoard()
    {
        _elves = new List<Elf>();
    }

    public void GiveCommand(ICommand command)
    {
        _elves.ForEach(e => e.Work(command));
    }

    public void AddElf(Elf elf)
    {
        _elves.Add(elf);
    }

    public void RemoveElf(Elf elf)
    {
        if (_elves.Contains(elf)) _elves.Remove(elf);
    }
}
