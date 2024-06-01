public class Address{

    public Address(int type){
        if (type == 1){
            _street = "Yellow Brick Road";
            _city = "Brooklyn";
            _state = "NY";
            _country = "US";
        }
        else if (type == 2){
            _street = "123 Imaginary Lane";
            _city = "Nowhereville";
            _state = "Fictionland";
            _country = "US";
        }
        else {
            _street = "456 Unicorn Street";
            _city = "Rainbow City";
            _state = "Fantasy World 12345";
            _country = "Not the US"; 
        }

    }
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public string GetAddressString(){
        return $"{_street}, {_city}, {_state}, {_country}";
    }

    public bool IsInTheUS(){
        if (_country == "US"){
            return true;
        }
        else{
            return false;
        }
    }
}