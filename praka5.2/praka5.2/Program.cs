List<IHello> Hi = new List<IHello>();
Hi.Add(new Rus());
Hi.Add(new Eng());
Hi.Add(new Azer());
Hi.Add(new Serb());
Hi.Add(new Frenc());
foreach (IHello lang in Hi)
{
    lang.SayHello();
}
Console.ReadKey(true);
interface IHello
{
    void SayHello();
}

class Rus : IHello { public void SayHello() { Console.WriteLine("Привет!"); } }
class Eng : IHello { public void SayHello() { Console.WriteLine("Hello!"); } }
class Azer : IHello { public void SayHello() { Console.WriteLine("Salam!"); } }
class Serb : IHello { public void SayHello() { Console.WriteLine("Zdravo!"); } }
class Frenc : IHello { public void SayHello() { Console.WriteLine("Bonjour!"); } }