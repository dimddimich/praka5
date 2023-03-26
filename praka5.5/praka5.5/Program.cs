List<IWizard> Wizardry = new List<IWizard>();
Wizardry.Add(new Magician(100, "Гарри Поттер"));
Wizardry.Add(new Magician(150, "Волан-де-Морт"));
Wizardry.Add(new Magician(20, "Пивз"));
foreach (IWizard cast in Wizardry)
{
    cast.spell();
}

Console.ReadKey(true);

interface IWizard
{
    void spell();
}
class Magician : IWizard
{
    public int Mana { get; set; }
    public string Name { get; set; }
    public Magician(int mana, string name)
    {
        Mana = mana;
        Name = name;
    }
    public void spell()
    {
        int mana = 100;
        if (Mana >= mana)
        {
            Console.WriteLine(Name + " Колдует!");
            Mana -= mana;
        }
        else
        {
            Console.WriteLine("Для заклинания недостаточно " + (Math.Abs(mana - Mana)) + " единиц маны. " + Name + " хлебните зелья!");
        }
    }
}
