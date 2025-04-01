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
        Console.WriteLine("3. 지도가 없다고 말한다.(거짓말친다.)");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("받은 사람이 말합니다.");
                Console.WriteLine("\"고마워요 정말 고맙습니다. 별 거 아니긴 한데 닭다리 구이 하나 드릴게요!!\"");
                Game.player.inventory.Remove("Map");
                Console.WriteLine("그 사람은 닭다리를 주고 떠났습니다...");
                Console.WriteLine("당신은 배고파서 5초안에 다 먹었습니다...(돼지놈..)");
                Console.WriteLine("당신은 너무 빨리 먹은 나머지 배탈이 나 일주일을 앓았습니다...");
                Console.WriteLine("당신의 HP가 1 닳았습니다...");
                player.hp--;
                Console.WriteLine("\"오늘의 교훈 음식은 천천히 먹자\"");
                break;

            case ConsoleKey.D2:
                Console.WriteLine("\"꺼져!!!!! 이 XX아!!!!!\"");
                Console.WriteLine("부탁한 사람이 말합니다.");
                Console.WriteLine("\"뭐라고????? 이 XX아!!!!!!!!!!! 넌 죽었다!!!!!\"");
                Console.WriteLine("갑자기 그 사람이 문 앞에 폭탄을 설치합니다....");
                Console.WriteLine("\"삐....삐삐삐삐삐삐ㄱ삐ㄱㄱㄱㄱㄱ삐삑 퍼엉\"");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("\"(우는 연기를 하며) 지도가 없어요.. 정말 죄송해요... 대신 빵이라도 드릴게요..\"");
                Console.WriteLine("그러자 밖에 있던 사람이 괜찮다며 조심히 지내라고 한다.");
                break;
            default:
                break;
        }
    }

    public override void Next()
    {
        
    }
}