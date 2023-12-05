using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;

class Employee{
    private static int id  = 0 ;
    public int ID {get => id;}
    private string name = string.Empty;
    public string Name { set => name = value; get => name;}
    private int yearOfBirth;
    public int year {get => yearOfBirth;}
    private double salaryLevel;
    public double salaryLV {set => salaryLevel = value; get => salaryLevel;}
    private double basicSalary = 3500000;
    public double basic {set => basicSalary = value; get => basicSalary;}
    public Employee() => ++id;
    public Employee(string name, int yearOfBirth, double salaryLevel) {
        id++;
        this.name = name;
        this.yearOfBirth = yearOfBirth;
        this.salaryLevel = salaryLevel;
    }
    public int getID() => ID;
    public string getName() => Name;
    public int getYearOfBirth() => year;
    public double getIncome() => salaryLevel*basicSalary;
    public void display() 
    {
        Console.WriteLine("Định danh    : {0}",getID());
        Console.WriteLine("Tên          : {0}",getName());
        Console.WriteLine("Năm sinh     : {0}",getYearOfBirth());
        Console.WriteLine("Lương cơ bản : {0}",basic);
        Console.WriteLine("Thu nhập     : {0}",getIncome());

    }
}
class Run {
    static void Main() {
        new Employee("Nguyễn Hùng Anh",2004,1.5).display();
        new Employee("Nguyễn Thế Anh",2004,1.3).display();
        new Employee("Nguyễn Hoàng Anh",2004,1.6).display();
    }
}