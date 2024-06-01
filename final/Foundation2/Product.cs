public class Product{
    private string _name;
    private int _productID;
    private float _price;

    public Product(string name, int productID, float price){
        _name = name;
        _productID = productID;
        _price = price;
    }

    public string GetProductName(){return _name;}

    public int GetProductID(){return _productID;}

    public float GetProductPrice(){return _price;}

    public string GetProductDetails(){return $"{_name}, {_productID} ${_price}";}
}