public class Student :Class
{
    int Value = 0;
    public int Price = 5;


    public Student(string name, int price, int value) : base(name, price, value)
    {
        Price = price;
        Value = value;
        Name = name;

    }
    public void Totalincome()
    {
        Console.WriteLine(Price - 4);
    }

    public void GetFullInfo()
    {
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Value: {this.Value}");
        Console.WriteLine($"Price: {this.Price}");
    }

}