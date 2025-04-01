namespace MudGame;

public class TitleScene :Scene
{
    public override void Render()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆");
        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("＼　　ヽ　　　　i　　|　　　　 /　　　/　                    ");
        Console.WriteLine("　　　＼　                                                           ");
        Console.WriteLine("!                                                                        ");
        Console.WriteLine("　　　　　　　　　　　　　　;' ':;,,　　　　 ,;'':;,             ");
        Console.WriteLine("　　　　　　　　　　　　　;'　　 ':;,.,.,.,.,.,,,;'　　';,           ");
        Console.WriteLine("　　ー　　　　　　　　 ,:'　　　　　　　　 　 ::::::::､         ");
        Console.WriteLine("　_＿　　　　　　　　,:' ／ 　 　　　　＼ 　　 ::::::::',        ");
        Console.WriteLine("　　　　　二　　　　:'　 ●　　　　　 ●　 　　   ::::::::i    .");
        Console.WriteLine("　　￣　　　　　　　i　 '''　(__人_)　　'''' 　　 ::::::::::i      ");
        Console.WriteLine("　　　　-‐　　　　　 :　 　　　　　　　　　 　 ::::::::i      ");
        Console.WriteLine("　　　　　　　　　　`:,､ 　　　　　 　 　  :::::::::: /           ");
        Console.WriteLine("　　　　／　　　　　　 ,:'　　　　　　　  : ::::::::::::｀:､      ");
        Console.WriteLine("　　　　　　　　　　　 ,:'　　　　　　　　  : : ::::::::::｀:､   ");

        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆");
        Console.WriteLine("☆                     O   N   E   M  I  N  U  T  E                        ☆");
        Console.WriteLine("☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆");
        Console.ResetColor();
    }

    public override void Choice()
    {           
        Console.WriteLine("1. 게임 시작");
        Console.WriteLine("2. 게임 종료");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("게임을 시작합니다.");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("게임을 종료합니다.");
                break;
            default:
                break;
        }
    }
    

    public override void Next()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Game.CurSceneChange("Choose");
                break;
            case ConsoleKey.D2:
                Game.gameOver = true;
                break;
            default:
                break;
        }
    }
}