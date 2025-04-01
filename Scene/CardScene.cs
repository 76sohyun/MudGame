namespace MudGame;

public class CardScene : Scene
{
    public override void Render()
    {
        Console.WriteLine("\"코카카칵 팍\"");
        Console.WriteLine("밖에서 누가 문을 부시며 들어옵니다.");
        Console.WriteLine("어떤 깡패무리들이 들어옵니다.");
        Console.WriteLine("당신이 말합니다.");
        Console.WriteLine("\"뭐하시는거예요!!!!!!!\"");
        Console.WriteLine("깡패 중 대장이 말합니다.");
        Console.WriteLine("\"하... 내가 너무 심심해서 그런데 물건 다 걸고 카드게임할래?\"");
        Console.WriteLine("당신은 어떻게 할 것입니까?");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 저... 카드게임 못합니다... 나가주시면 안될까요?");
        Console.WriteLine("2. 네 한 번 뜨시죠!!!");
        Console.WriteLine("3. 맞짱뜬다.");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("깡패 대장이 당황합니다.");
                Console.WriteLine("\"너 왜이렇게 쫄보니? 하.... 그런 xx들이 젤 싫어 퉤\"");
                Console.WriteLine("당신의 얼굴에 침을 뱉었습니다.");
                Console.WriteLine("당신이 말합니다.");
                Console.WriteLine("제발 살려주세요");
                Console.WriteLine("대장은 당신의 얼굴에 죽빵을 날리고 부하들과 떠납니다.");
                Console.WriteLine("당신의 HP가 1 깎였습니다.");
                Game.player.hp--;
                Console.WriteLine("아프당.............");
                break;

            case ConsoleKey.D2:
                Console.WriteLine("카드게임을 시작합니다...");
                Console.WriteLine("2시간 게임 끝에 당신이 이겼습니다.");
                Game.player.inventory.Remove("Card");
                Console.WriteLine("\"야 너 잘한다?\"");
                Console.WriteLine("하하......");
                Console.WriteLine("\"내가 졌으니 총 한 자루 주마.\"");
                Console.WriteLine("대장이 총을 준 후 깡패 부하들이 문을 고치고 떠납니다...(착하네요)");
                break;

            case ConsoleKey.D3:
                Console.WriteLine("\"당신은 갑자기 분노조절장애가 생기며 대장에게 주먹을 날립니다.\"");
                Console.WriteLine("대장의 부하들이 당신을 엄청나게 팹니다.... 퍽퍼퍼퍽");
                break;
        }
    }

    public override void Next()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Game.livPer += 10;
                Game.RandomScene();
                Game.Escape();
                break;
            case ConsoleKey.D2:
                Game.livPer += 10;
                Game.RandomScene();
                Game.Escape();
                break;
            case ConsoleKey.D3:
                Game.livPer += 10;
                Game.GameOver("당신은 엄청나게 맞아서 결국 과다출혈로 사망했습니다..... 나대지말라는거에요 -석숭이-");
                break;
        }
    }
}