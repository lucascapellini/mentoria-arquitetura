// application -> credit analysis (abstraction) -> bank loan (implementation) / credit card

class CreditAnalysis
{
    protected CreditProvider creditProvider;

    public CreditAnalysis(CreditProvider provider)
    {
        this.creditProvider = provider;
    }

    bool hasCreditAvailable()
    {
        return !this.creditProvider.hasDebits() && this.creditProvider.hasGoodSalary();
    }
    void analiseClient()
    {
        if (creditProvider.hasDebits() && creditProvider.hasGoodSalary())
        {
            this.creditProvider.setAmount(20000);
            Console.WriteLine("CreditAvailable");
        }
    }
}

interface CreditProvider
{
    bool hasDebits();
    bool hasGoodSalary();
    void setAmount(int amount);

}

class BankLoan : CreditProvider
{
    private int loanAmount;
    private Person client;

    public BankLoan(Person client)
    {
        this.client = client;
    }

    public bool hasDebits()
    {
        return this.client.hasDebits;
    }

    public bool hasGoodSalary()
    {
        if (this.client.salary > 15000) return true;
        return false;
    }

    public void setAmount(int amount)
    {
        this.loanAmount = amount;
    }
}

class CreditCard : CreditProvider
{
    private int creditAmount;
    private Person client;

    public CreditCard(Person client)
    {
        this.client = client;
    }

    public bool hasDebits()
    {
        return this.client.hasDebits;
    }

    public bool hasGoodSalary()
    {
        if (this.client.salary > 5000) return true;
        return false;
    }

    public void setAmount(int amount)
    {
        this.creditAmount = amount;
    }
}

class Person
{
    public int salary;
    public bool hasDebits;

    public Person(int salary, bool hasDebits)
    {
        this.salary = salary;
        this.hasDebits = hasDebits;
    }
}