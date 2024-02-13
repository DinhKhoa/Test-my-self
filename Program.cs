using System.Diagnostics.CodeAnalysis;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> arrays = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu {0}: ", i);
                arrays.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(TongSoNguyenTo(arrays));
        }
        public static int TongSoNguyenTo(List<int> arrays)
        {
            int sum = 0;
            for (int i = 0; i < arrays.Count; i++)
            {
                if (KiemTraNghiemDu(arrays[i]) && arrays[i] > 1) sum += arrays[i];
            }
            return sum;
        }
        private static bool KiemTraNghiemDu(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % 2 == 0) return false;
            }
            return true;
        }
    }
}