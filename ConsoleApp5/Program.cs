
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
string name = "Sütlaç";
int price = 5;
int count = 100;

Console.WriteLine("if you want our special sütlaç you can press 1 and order");


Student student = new Student(name, price, count);
student.GetFullInfo();
student.Sell();
