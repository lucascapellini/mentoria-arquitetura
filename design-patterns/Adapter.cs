class ApiProduct {
    public string id;
    public string name;
    public float price;
}

class FrontProduct {
    public string name;
    public int price;

    public FrontProduct(string name, int price) {
        this.name = name;
        this.price = price;
    }
}

class Api {
    public ApiProduct getProduct() {
        Console.WriteLine("PRODUCT");
        return new ApiProduct();
    }
}

interface IClientGetProduct {
    FrontProduct getProduct();
}

class ProductAdapter : IClientGetProduct {
    private Api api;

    public ProductAdapter(Api api) {
        this.api = api;
    }

    public FrontProduct getProduct() {
        ApiProduct apiProduct = this.api.getProduct();
        return this.convertApiProductToFront(apiProduct);
    }

    private FrontProduct convertApiProductToFront(ApiProduct product){
        return new FrontProduct(product.name, (int) product.price);
    }
}

class front {
    FrontProduct product;

    public void someMethod() {
        Api api = new Api();
        ProductAdapter adapter = new ProductAdapter(api);

        this.product = adapter.getProduct();
    }
}


