

public class Address
{
    string _street;
    string _city;
    string _stateOrProvince;
    string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;

    }

    public bool Is_USA()
    {
        return _country.Trim().ToUpper() == "USA";
    }
    public string Get_FullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}"; 
    }
    
}