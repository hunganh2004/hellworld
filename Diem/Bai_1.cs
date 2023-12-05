class Diem
{
    // Tọa độ x, y
    private double x;
    private double y;
    // Phương thức khởi tạo:
    public Diem() => x = y = 0;
    public Diem(double x, double y) { this.x = x; this.y = y; }
    // Phương thức hoạt động:
    public void Nhap(double x, double y) { this.x = x; this.y = y; }
    public void Hienthi() => Console.WriteLine($"({x},{y})");
    public void Khoang_cach(Diem x) => Math.Sqrt(Math.Pow(this.x - x.x, 2) + Math.Pow(this.y - x.y, 2));
     // I am thinking about you !
}
