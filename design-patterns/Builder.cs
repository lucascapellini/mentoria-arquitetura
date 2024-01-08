class Wizard {
    public bool magicPowers;
    public int speed;
    public int strengh;
}

class Warrior {
    public bool hasWeapons;
    public int speed;
    public int strengh;
}

interface Builder {
    void reset();
    void setSpeed(int speed);
    void setStrengh(int strengh);
    // public setHasWeapons();
    // public setMagicPowers();
}

class WizardBuilder : Builder {
    private Wizard wizard;

    public WizardBuilder() {
        this.reset();
    }

    public void reset() {
        this.wizard = new Wizard();
    }

    public void setSpeed(int speed) {
        this.wizard.speed = speed;
    }

    public void setStrengh(int strengh) {
        this.wizard.strengh = strengh;
    }

    public void setMagicPowers() {
        this.wizard.magicPowers = true;
    }

    public Wizard getCharacter() {
        return this.wizard;
    }
}

class WarriorBuilder : Builder {
    private Warrior warrior;

    public WarriorBuilder() {
        this.reset();
    }

    public void reset() {
        this.warrior = new Warrior();
    }

    public void setSpeed(int speed) {
        this.warrior.speed = speed;
    }

    public void setStrengh(int strengh) {
        this.warrior.strengh = strengh;
    }

    public void setHasWeapons() {
        this.warrior.hasWeapons = true;
    }

    public Warrior getCharacter() {
        return this.warrior;
    }
}

class Director {
    public void createStrongWarrior(WarriorBuilder builder) {
        builder.reset();
        builder.setHasWeapons();
        builder.setSpeed(5);
        builder.setStrengh(9);
    }

    public void createFastWarrior(WarriorBuilder builder) {
        builder.reset();
        builder.setHasWeapons();
        builder.setSpeed(10);
        builder.setStrengh(6);
    }

    public void createWizard(WizardBuilder builder) {
        builder.reset();
        builder.setSpeed(6);
        builder.setStrengh(4);
        builder.setMagicPowers();
    }
}