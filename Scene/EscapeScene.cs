namespace MudGame;

public class EscapeScene : Scene
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
                Console.WriteLine("\"여기 생존자가 있다!\"");
                Console.WriteLine("당신의 선택은 훌륭했습니다.");
                Console.WriteLine("당신이 방공호에 대피하고 있던 시간 동안 밖은 안전해졌습니다.");
                Game.GameClear();
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
        //todo : 남은 이벤트 중에 랜덤?
    }
}