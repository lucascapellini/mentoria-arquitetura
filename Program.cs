
class Program
{
    static void Main(string[] args)
    {
        // Director director = new Director();

        // WizardBuilder wiBuilder = new WizardBuilder();
        // director.createWizard(wiBuilder);
        // Wizard wizard = wiBuilder.getCharacter();
        // Console.WriteLine("speed {0}, strengh {1}, hability {2}", wizard.speed, wizard.strengh, wizard.magicPowers);

        // WarriorBuilder waBuilder = new WarriorBuilder();
        // director.createStrongWarrior(waBuilder);
        // Warrior strongWarrior = waBuilder.getCharacter(); 
        // Console.WriteLine("speed {0}, strengh {1}, hability {2}", strongWarrior.speed, strongWarrior.strengh, strongWarrior.hasWeapons);

        // director.createFastWarrior(waBuilder);
        // Warrior fastWarrior = waBuilder.getCharacter();
        // Console.WriteLine("speed {0}, strengh {1}, hability {2}",fastWarrior.speed, fastWarrior.strengh, fastWarrior.hasWeapons);
    
        F35 airplane = new F35();
        airplane.maxHeight = 20000;
        airplane.maxSpeed = 2700;
        airplane.weapons = "missile and machinegun";

        F35 clone = (F35) airplane.clone();

        Console.WriteLine("Original and clone: maxSpeed {0} e {1}, maxHeigth {2} e {3}, weapons {4} e {5}", airplane.maxSpeed, clone.maxSpeed, airplane.maxHeight, clone.maxHeight, airplane.weapons, clone.weapons);
    }
}
