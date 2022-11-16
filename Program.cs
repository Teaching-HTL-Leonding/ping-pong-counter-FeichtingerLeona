Console.WriteLine("Which type of match will be played ? (short, regular,double,custom)");
string MATCH_TYPE = Console.ReadLine()!;
int NUMBER_OF_GAMES = 0;
int POINTS_PLAYER_1 = 0;
int POINTS_PLAYER_2 = 0;
int GAME_POINTS_PLAYER_1 = 0;
int GAME_POINTS_PLAYER_2 = 0;
string PLAYER1 = "player 1";
string PLAYER2 = "player 2";
string PLAYER;


do
{
    if (MATCH_TYPE == "short")
    {
        NUMBER_OF_GAMES = NUMBER_OF_GAMES + 1;
    }
    else if (MATCH_TYPE == "regular")
    {
        NUMBER_OF_GAMES = NUMBER_OF_GAMES + 4;
    }
    else if (MATCH_TYPE == "regular")
    {
        NUMBER_OF_GAMES = NUMBER_OF_GAMES + 3;
    }
    else if (MATCH_TYPE == "custom")
    {
        do
        {
            Console.Write("Plese enter how many games they have to play (1-10)");
            NUMBER_OF_GAMES = int.Parse(Console.ReadLine()!);
        }
        while (NUMBER_OF_GAMES <= 0 || NUMBER_OF_GAMES > 9 || NUMBER_OF_GAMES % 2 == 0);
    }

}
while (MATCH_TYPE != "short" || MATCH_TYPE != "regular" || MATCH_TYPE != "double" || MATCH_TYPE != "custom");
while (GAME_POINTS_PLAYER_1 != NUMBER_OF_GAMES || GAME_POINTS_PLAYER_2 != NUMBER_OF_GAMES)
{
    do
    {
        Console.WriteLine("Who scored the point ");
        PLAYER = Console.ReadLine()!;
        if (PLAYER == PLAYER1) { POINTS_PLAYER_1 = POINTS_PLAYER_1 + 1; }
        else if (PLAYER == PLAYER2) { POINTS_PLAYER_2 = POINTS_PLAYER_2 + 1; }
        Console.WriteLine($"{POINTS_PLAYER_1}:{POINTS_PLAYER_2}");
    }
    while (11 != POINTS_PLAYER_1 || 11 != POINTS_PLAYER_2);
    if (POINTS_PLAYER_1 >= 11)
    {
        GAME_POINTS_PLAYER_1 = GAME_POINTS_PLAYER_1 + 1;
         Console.WriteLine("Player 1 winns the game");
    }
    else if (POINTS_PLAYER_2 >= 11)
    {
        GAME_POINTS_PLAYER_2 = GAME_POINTS_PLAYER_2 + 1;
         Console.WriteLine("Player 2 winns the  game ");
    }
    Console.WriteLine($"{GAME_POINTS_PLAYER_1}:{GAME_POINTS_PLAYER_2}");
    POINTS_PLAYER_1 = 0;
    POINTS_PLAYER_2 = 0;

}
if (GAME_POINTS_PLAYER_1 >= NUMBER_OF_GAMES)
{
    Console.WriteLine("Player 1 winns the match");
}
else if (POINTS_PLAYER_2 >= NUMBER_OF_GAMES)
{
    Console.WriteLine("Player 2 winns the match ");
}




