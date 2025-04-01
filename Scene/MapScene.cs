namespace MudGame;

public class MapScene : Scene
{
    private Player player;
    public override void Render()
    {
        Console.WriteLine("\"쾅ㅋ코캉왘왘ㅇ쾅\"");
        Console.WriteLine("밖에서 누가 문을 두드립니다.");
        Console.WriteLine("당신은 말합니다.");
        Console.WriteLine("\"누구세요....?\"");
        Console.WriteLine("누군가가 대답합니다.");
        Console.WriteLine("\"저기... 제가 길을 잃어서 그런데 지도 한 번만 빌려주시면 안될까요..?\"");
        Console.WriteLine("당신은 지도를 주겠습니까?");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 벽에 붙인 귀한 지도를 문 틈 사이로 준다.");
        Console.WriteLine("2. 꺼져라");
        Console.WriteLine("3. 지도가 없다고 말한다.");
    }

    public override void Result()
    {
        throw new NotImplementedException();
    }

    public override void Next()
    {
        throw new NotImplementedException();
    }
}