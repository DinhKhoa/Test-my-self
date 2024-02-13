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
            Console.WriteLine(TongCacSoHoanHao(arrays));
        }
        
        public static int TongCacSoHoanHao(List<int> arrays)
        {
            int sum = 0;
            for (int i = 0; i < arrays.Count; i++)
            {
                if (KiemTraSoHoanHao(arrays[i])) sum += arrays[i];
            }
            return sum;
        }
        private static bool KiemTraSoHoanHao(int n)
        {
            int tongUoc = 0; 
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) tongUoc += i;
            }
            if (tongUoc == n) return true;
            return false;
        }
    }
}