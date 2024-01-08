
class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();

        WizardBuilder wiBuilder = new WizardBuilder();
        director.createWizard(wiBuilder);
        Wizard wizard = wiBuilder.getCharacter();
        Console.WriteLine("speed {0}, strengh {1}, hability {2}", wizard.speed, wizard.strengh, wizard.magicPowers);

        WarriorBuilder waBuilder = new WarriorBuilder();
        director.createStrongWarrior(waBuilder);
        Warrior strongWarrior = waBuilder.getCharacter(); 
        Console.WriteLine("speed {0}, strengh {1}, hability {2}", strongWarrior.speed, strongWarrior.strengh, strongWarrior.hasWeapons);

        director.createFastWarrior(waBuilder);
        Warrior fastWarrior = waBuilder.getCharacter();
        Console.WriteLine("speed {0}, strengh {1}, hability {2}",fastWarrior.speed, fastWarrior.strengh, fastWarrior.hasWeapons);
    }
}
