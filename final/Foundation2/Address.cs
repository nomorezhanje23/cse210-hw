using System;

class Address
{
    public string _streetAddress;

    public string _city;

    public string _stateOrProvince;

    public string _country;

    public Address(string streetAddress, string city , string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool GetLiveInUSA()
     {
     }

    public string GetFullAddress()
     {
        string FullAddress = $"{_streetAddress} {_city} {_stateOrProvince} {_country}";
        return FullAddress;
     }


}