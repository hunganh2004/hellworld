class Diem
{
    private double x;
    private double y;
    public Diem() => x = y = 0;
    public Diem(double x, double y) { this.x = x; this.y = y; }
    public void Nhap(double x, double y) { this.x = x; this.y = y; }
    public void Hienthi() => Console.WriteLine($"({x},{y})");
    public void Khoang_cach(Diem x) => Math.Sqrt(Math.Pow(this.x - x.x, 2) + Math.Pow(this.y - x.y, 2));
}
