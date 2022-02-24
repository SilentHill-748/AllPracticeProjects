var cars = new List<Car>()
{
    new Car{ Name = "Ford", Number = "АВ74С"},
    new Car{ Name = "Lada", Number = "АВ05Б"}
};

var parking = new Parking();
foreach (Car car in cars)
{
    parking.Add(car);
}

Car? lada = parking["АВ05Б"];
Console.WriteLine($"Name = {lada?.Name}, number = {lada?.Number}");



class Car
{
    public string Name { get; set; }

    public string Number { get; set; }



    public Car()
    {
        Name = string.Empty;
        Number = string.Empty;
    }
}

class Parking
{
    private List<Car> _cars;
    private const int MAX_CARS = 100;


    public Parking()
    {
        _cars = new List<Car>();
        Name = "";
    }


    public Car? this[string number]
    {
        get => _cars.FirstOrDefault(c => c.Number.Equals(number));
    }

    public int Count => _cars.Count;

    public string Name { get; set; }

    public int Add(Car car)
    {
        if (car is null)
        {
            throw new ArgumentNullException(nameof(car));
        }

        if (_cars.Count < MAX_CARS)
        {
            _cars.Add(car);
            return _cars.IndexOf(car);
        }
        return -1;
    }
    
    public void GoOut(string number)
    {
        if (string.IsNullOrWhiteSpace(number))
        {
            throw new ArgumentNullException(nameof(number), "Number is null or empty.");
        }

        var car = _cars.FirstOrDefault(c => c.Name == number);
        if (car is not null)
        {
            _cars.Remove(car);
        }
    }
}