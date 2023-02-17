using System;

class Order
{
    public List<Product> _product = new List<Product>();

    public string  _customer;

    public float _totalCost;

    public int _shippingCost;

    public Order(string customer)
    {
        _customer = customer;

    }

    public float CalculateTotalCost()
    {
       float TotalCost = _totalCost + _shippingCost;
       return TotalCost;
    }

    public string MakeListOfProducts()
    {
        fullList = new List<Product>();
        return fullList;
    }

    public string GetPackagingLabel()
     {
        string Label = $"{_customer}";
        return Label;
     }

    public string GetShippingLabel()
     {
        string Label = $"{_customer} {_streetAddress} {_city} {_stateOrProvince} {_country}";
        return Label;
     }

    public float GetTotalCost()
    {
       float TotalCost = _totalCost + _shippingCost;
       return TotalCost;
    }

}