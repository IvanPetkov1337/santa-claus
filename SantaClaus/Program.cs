using SantaClaus;

ICommand createDoll = new CreateDollCommand();
ICommand createBycicle = new CreateBicycleCommand();
ICommand createRubic = new CreateRubicCommand();
IMagicBoard magicBoard = new MagicBoard();

Elf doby = new();
Elf dobyTheSecond = new();

Santa santa = Santa.GetSanta();

magicBoard.AddElf(doby);
magicBoard.AddElf(dobyTheSecond);

santa.GiveCommand(createRubic);
santa.SetBoard(magicBoard);
santa.GiveCommand(createRubic);

magicBoard.RemoveElf(doby);

santa.GiveCommand(createBycicle);
santa.GiveCommand(createDoll);