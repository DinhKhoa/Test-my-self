namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(TinhTong(a, b));
        }
        /// <summary>
        /// Tinh tong a va b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int TinhTong(int a, int b)
        {
            return (a + b);
        }
    }
}