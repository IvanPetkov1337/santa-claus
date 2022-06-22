namespace SantaClaus;

internal interface IMagicBoard
{
    void AddElf(Elf elf);
    void GiveCommand(ICommand command);
    void RemoveElf(Elf elf);
}