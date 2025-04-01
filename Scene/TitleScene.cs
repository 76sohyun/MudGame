namespace MudGame;

public class TitleScene :Scene
{
    public override void Render()
    {
        Console.WriteLine("***********************");
        Console.WriteLine("*****     1분     *****");
        Console.WriteLine("***********************");
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