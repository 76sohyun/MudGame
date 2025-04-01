namespace MudGame;

public class RadioScene : Scene
{
    private Player player;
    public override void Render()
    {
        Console.WriteLine("\"가만히 생각하다 이제 밖의 상황이 어떤지 궁금해졌습니다.\"");
        Console.WriteLine("궁금해진 나머지 참을 수가 없게 되었습니다.");
        Console.WriteLine("안이 너무 답답한 당신은 어떻게 하시겠습니까?");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 가만히 기다린다.");
        Console.WriteLine("2. 라디오를 켜서 지금 상황이 어떤지 들어본다.");
        Console.WriteLine("3. 밖에 나가서 상황을 살펴본다.");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("가만히 기다린 당신은 미쳐 날뛰다가 넘어져 다쳤습니다.");
                Console.WriteLine("쿳소..........");
                Console.WriteLine("당신의 HP가 1 깎였습니다.");
                player.hp--;
                break;
            case ConsoleKey.D2:
                    Console.WriteLine("\"ㅊㅊ치칯칙..치치치ㅣㅊ치치ㅣㄱ칙\"");
                    Console.WriteLine("\"안내 방송드립니다. 밖에는 방사능 노출의 위험이 있어 절대 나가지 말아주십시오\"");
                    Console.WriteLine("\"최대한 빠른 시일내에 구조작업을 할 예정이오니 조금만 기다려주시기 바랍니다.\"");
                    Console.WriteLine("\"다ㅏ시 한 번 말ㄹㄹ씀ㅁㅁㅁㅁㅁ\"");
                    Console.WriteLine("갑자기 음성이 끊기더니 라디오가 고장났습니다.");
                    Game.player.inventory.Remove("Radio");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("당신은 문을 열고 나갑니다...");
                Console.WriteLine("바보같은 당신은 방사능에 오염되어 쓰러집니다.");
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
            case ConsoleKey.D2:
                

            case ConsoleKey.D3:
                Console.WriteLine("당신은 방사능에 오염되어 사망하였습니다....");
                Game.GameOver("당신은 방사능에 오염되어 사망하였습니다....");
                break;
        }
    }
}