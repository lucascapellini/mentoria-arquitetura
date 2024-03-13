// implementar execução adiada de operações? operações matemáticas? como ficaria essa estrutura?

namespace Command
{
    abstract class Operation
    {
        protected float a;
        protected float b;
        protected float result;

        public Operation(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public abstract void execute();
    }

    class AdditionOperation : Operation
    {
        public AdditionOperation(float a, float b) : base(a, b) { }
        public override void execute()
        {
            this.result = this.a + this.b;
        }
    }

    class SubtractionOperation : Operation
    {
        public SubtractionOperation(float a, float b) : base(a, b) { }
        public override void execute()
        {
            this.result = this.a = this.b;
        }
    }

    class MultiplicationOperation : Operation
    {
        public MultiplicationOperation(float a, float b) : base(a, b) { }
        public override void execute()
        {
            this.result = this.a * this.b;
        }
    }

    class DivisionOperation : Operation
    {
        public DivisionOperation(float a, float b) : base(a, b) { }
        public override void execute()
        {
            this.result = this.a / this.b;
        }
    }

    class PowOperation : Operation {
        private Receiver receiver;

        public PowOperation(Receiver r, float a, float b) : base(a, b) {
            this.receiver = r;
        }

        public override void execute() {
            this.receiver.Pow(this.a, this.b);
        }
    }

    class Receiver
    {
        public float Pow(float baseNumber, float exponent) {
            float result = 0;
            for (int i=0; i<exponent; i++) {
                result *= baseNumber;
            }
            return result;
        }
    }

    class Invoker {
        private List<Operation> operations;

        public void AddOperation(Operation op) {
            this.operations.Add(op);
        }

        public void runNextCommand() {
            if(this.operations[0] is Operation) {
                this.operations[0].execute();
                this.operations.RemoveAt(0);
            }
        }
    }
}