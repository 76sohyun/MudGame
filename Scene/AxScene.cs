namespace MudGame;

public class AxScene : Scene
{
    public override void Render()
    {
        Console.WriteLine("\"찍찍!\"");
        Console.WriteLine("방공호에 쥐가 나타났습니다.");
        Console.WriteLine("쥐를 잡지 않으면 전염병에 걸릴지도 모릅니다.");
        Console.WriteLine("당신은 어떻게 하겠습니까?");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 도끼를 양손으로 움켜쥐어 쥐를 향해 내려칩니다.");
        Console.WriteLine("2. 쥐약을 방공호 구석구석에 배치합니다. ");
        Console.WriteLine("3. 현재로써는 아무것도 할 수 없습니다. 제발 어디론가 사라지기를 기도합니다.");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("당신은 다행히 도끼를 휘두룰 힘이 남아있었습니다.");
                Console.WriteLine("쥐를 잡는데 성공했지만, 너무 세게 휘둘렀는지 도끼가 부러졌습니다.");
                Game.player.inventory.Remove("Ax");
                break;
            case ConsoleKey.D2:
                Console.WriteLine("총을 쏘는건 굉장히 쉬운 일입니다.");
                Console.WriteLine("쥐를 잡는데는 성공했지만, 너무 흥분한 나머지 모든 총알을 다 써버리고 말았습니다.");
                Game.player.inventory.Remove("Gun");
                break;
            case ConsoleKey.D3:
                break;
            default:
                break;
        }
    }

    public override void Next()
    {
        throw new NotImplementedException();
    }
}