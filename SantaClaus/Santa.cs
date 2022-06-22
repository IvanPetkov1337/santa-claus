namespace SantaClaus;

internal class Santa
{
    private static Santa s_instance;
    private static IMagicBoard s_magicBoard;

    private Santa()
    {

    }

    public static Santa GetSanta()
    {
        if (s_instance == null) s_instance = new Santa();

        return s_instance;
    }

    public void SetBoard(IMagicBoard magicBoard)
    {
        s_magicBoard = magicBoard;
    }

    public void GiveCommand(ICommand command)
    {
        if (s_magicBoard is null) Console.WriteLine("You do not have a board!");
        else s_magicBoard.GiveCommand(command);
    }
}
