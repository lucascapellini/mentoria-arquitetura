namespace Proxy
{

    interface IHeavyService
    {
        void expensiveOperation();
    }
    class HeavyService : IHeavyService
    {
        public void expensiveOperation()
        {
            Console.WriteLine("heavy process");
        }
    }

    class CachedServiceProxy : IHeavyService
    {
        private IHeavyService service;
        private List<string> cachedResult;

        public CachedServiceProxy(IHeavyService s)
        {
            this.service = s;
        }

        public void expensiveOperation()
        {
            if (this.cachedResult.Count > 0)
            {
                Console.WriteLine("cached result {0}", this.cachedResult);
            }
            else
            {
                this.service.expensiveOperation();
                this.cachedResult = ["heavy", "data", "returned", "from", "service"];
            }
        }
    }
}