using System;

class Product
{
    public string _name;

    private string _productID;

    private float _price;

    public int _quantity;

    private float _totalPrice;

    public Product(string name, string productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public float CalculateTotalPrice()
    {
        _price * _quantity;
    }
    public float GetIndividualPrice()
     {
        float price = $"{_price}";
        return price;
     }

    public float GetTotalPrice()
     {
        float price = $"{_price}* {_quantity}";
        return Totalprice;
     }

    public string GetProductID()
     {
        return productID;
     }

}