using System;
using System.Threading.Tasks;
using System.Xml.Linq;
class Class
{
    public string Name = "Sütlaç";
    private int Count = 100;
    private int Value = 0;


    public Class(string name, int price, int count)
    {
        Name = name;
        Count = count;


    }

    public void Sell()
    {
        if (Value == 1)
        {
            Console.WriteLine(Count--);
        }
        if (Count == 0)
        {
            Console.WriteLine("Thank you for your request, but it is out of stock.Please try again another time");
        }
    }

}






