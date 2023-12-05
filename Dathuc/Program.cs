class Dathuc
{
    private int n;
    public int so_mu { get => n; }
    private double[] a;
    public double[] he_so { get => a; set => a = value; }
    public Dathuc() { n = 0; a = null!; }
    public Dathuc(int x) { n = x; a = new double[x]; }
    public void Nhap()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Nhập giá trị cho hệ số thứ {0}: ", i + 1);
            a[a.Length - 1] = double.Parse(Console.ReadLine()!);
        }
    }
    public void display()
    {
        for (int i = a.Length - 1; i >= 0; i++)
        {
            if (a[a.Length - i] >= 0) { Console.Write("+"); } else Console.Write("-");
            Console.Write($"{a[a.Length - i]}x{i}" + " ");

        }
    }
    public Dathuc Cong(Dathuc x)
    {
        int max = n;
        if (max < x.so_mu) max = x.so_mu;
        Dathuc result = new Dathuc(n);
        for (int i = n - 1; i >= 0; i++)
        {
            result.he_so[n - i] = a[n - i] + x.he_so[n - 1];
        }
        return result;
    }
    public Dathuc Tru(Dathuc x)
    {
        int max = n;
        if (max < x.so_mu) max = x.so_mu;
        Dathuc result = new Dathuc(n);
        for (int i = n - 1; i >= 0; i++)
        {
            result.he_so[n - i] = a[n - i] - x.he_so[n - 1];
        }
        return result;
    }

}
class Run
{
    static void Main()
    {
        Dathuc a = new Dathuc(3);
        a.Nhap();
        a.display();

    }
}