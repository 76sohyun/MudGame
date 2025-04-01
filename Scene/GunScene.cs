namespace MudGame;

public class GunScene : Scene
{
    public override void Render()
    {
        Console.WriteLine("\"똑똑!\"");
        Console.WriteLine();
        Console.WriteLine("누군가 방공호를 두드리는 소리가 들립니다.");
        Console.WriteLine("많은 시간이 흐르긴 했지만, 당신은 밖의 상황을 모릅니다.");
        Console.WriteLine("문을 여시겠습니까?");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 날 구해주러온 것이 분명하다. (문을 연다)");
        Console.WriteLine("2. 저것들은 나에게 호의적인 존재가 아닐 것이다. (문을 열지 않는다)");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                if (Game.player.IsOwned("Gun"))
                {
                    Console.WriteLine("\"탕 탕!\"");
                    Console.WriteLine("문 밖에는 당신의 대피소를 습격하기 위한 괴한들이 있었습니다.");
                    Console.WriteLine("하지만 당신은 총을 가지고 있었고, 괴한들의 습격으로부터 살아남을 수 있었습니다.");

                }
                else
                {
                    Console.WriteLine("\"푹\"");
                    Console.WriteLine("대피소 문을 열자마자 보이는건 칼을 든 괴한들이었습니다.");
                    Console.WriteLine("당신은 급하게 문을 닫으려했지만, 결국 괴한들의 칼에 찔렸습니다.");
                }

                break;
            case ConsoleKey.D2:
                Console.WriteLine("아무 일도 일어나지 않았습니다.");
                Console.WriteLine("누가 왔는지는 평생 알 수 없겠지만, 여전히 당신은 안전합니다.");
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
                if (Game.player.IsOwned("Gun"))
                {
                    Game.Escape();
                    Game.RandomScene();
                }
                else
                {
                    Game.GameOver("당신은 과다출혈로 죽었습니다.");
                }

                break;
            case ConsoleKey.D2:
                Game.Escape();
                Game.RandomScene();
                break;
        }
    }
}