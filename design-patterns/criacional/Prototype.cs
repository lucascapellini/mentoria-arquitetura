abstract class Airplane {
    public int maxSpeed;
    public int maxHeight;
    private string engineType;

    public Airplane(){
        
    }

    public Airplane(Airplane obj) {
        this.maxSpeed = obj.maxSpeed;
        this.maxHeight = obj.maxHeight;
        this.engineType = obj.engineType;
    }

    public abstract Airplane clone();
}

class F35 : Airplane {
    public string weapons;

    public F35() : base() {
    }

    public F35(F35 obj) : base(obj) {
        this.weapons = obj.weapons;
    }

    public override Airplane clone() {
        return new F35(this);
    }
}