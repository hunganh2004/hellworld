class ComplexNumber {
    private double real;
    public double phan_thuc {get => real; set=> real = value;}
    private double not_real ;
    public double phan_ao { get => not_real; set => not_real = value;}
    public ComplexNumber(double thuc, double ao) { real = thuc; not_real = ao;}
    public void display() => Console.WriteLine($"{real} + {not_real}i");
    public ComplexNumber Tong( ComplexNumber x) => new ComplexNumber(phan_thuc + x.phan_thuc, phan_ao + x.phan_ao);
    public ComplexNumber Hieu( ComplexNumber x) => new ComplexNumber(phan_thuc - x.phan_thuc, phan_ao - x.phan_ao);

}
class Run {
    static void Main() => new ComplexNumber(1,1).Hieu( new ComplexNumber(1,2)).display();
}