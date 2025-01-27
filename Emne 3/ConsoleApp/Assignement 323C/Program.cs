using Assignement_323C;

var board = new Board();
var gameConsole = new GameConsole(board);
while (true)
{
    gameConsole.Show(board);
    
    Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
    var position = Console.ReadLine(); 
    if (position != null) board.Mark(position);
}