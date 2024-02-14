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
            Console.WriteLine(TinhTrungBinhCacSoLeViTriChan(arrays));
        }

        public static double TinhTrungBinhCacSoLeViTriChan(List<int> arrays)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arrays.Count; i++)
            {
                if (arrays[i] % 2 != 0 && i % 2 == 0)
                {
                    sum += arrays[i];
                    count += 1;
                }
            }
            return ((double)sum / count);
        }
    }
}