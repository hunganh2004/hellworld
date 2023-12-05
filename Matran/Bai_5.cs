using System.Data;
using System.Xml.Serialization;

class Matran
{
    private double[,] matrix;
    public double[,] ma_tran { get => matrix; set => matrix = value; }
    public Matran(int row, int column) => matrix = new double[row, column];
    public void Nhap()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Nhập vị trí [{i}][{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine()!);
            }
        }
    }
    public Matran Cong(Matran x)
    {
        if (Tuong_thich(x))
        {
            Matran result = new Matran(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result.ma_tran[i, j] = matrix[i, j] + x.ma_tran[i, j];
                }
            }
            return result;
        }
        else throw new Exception("Không thể cộng 2 ma trận không tương thích !");
    }
    public Matran Hieu(Matran x)
    {
        if (Tuong_thich(x))
        {
            Matran result = new Matran(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result.ma_tran[i, j] = matrix[i, j] - x.ma_tran[i, j];
                }
            }
            return result;
        }
        else throw new Exception("Không thể trừ 2 ma trận không tương thích !");
    }
    public void Doi_dau()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                matrix[i, j] = -matrix[i, j];
            }
        }
    }
    public void Chuyen_Vi()
    {
        Matran temp = new Matran(matrix.GetLength(1), matrix.GetLength(0));
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {

                temp.ma_tran[i, j] = ma_tran[j, i];
            }
        }
        matrix = temp.ma_tran;
    }
    public Matran Tich(Matran x)
    {
        Matran result = new Matran(matrix.GetLength(0), x.ma_tran.GetLength(1));
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < x.ma_tran.GetLength(1); j++)
            {
                for (int k = 0;k < matrix.GetLength(1); k++) {
                    result.ma_tran[i,j] += matrix[i,k] * x.ma_tran[k,j];
                }
            }
        }
        return result;
    }
    public bool Tuong_thich(Matran x) => (matrix.GetLength(0), matrix.GetLength(1)) == (x.ma_tran.GetLength(0), x.ma_tran.GetLength(1));
    public bool maTranVuong() => matrix.GetLength(0) == matrix.GetLength(1);
    public void display()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
class Run
{
    static void Main() {
        Console.WriteLine("Ma trận 1:");
        Matran a = new Matran(2,3);
        a.Nhap();
        Console.WriteLine("Ma trận 2:");
        Matran b = new Matran(3,2);
        b.Nhap();
        a.Tich(b).display();
        
    }
}