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
            Console.WriteLine(TongCacSoTrongMang(arrays));
        } 

        public static int TongCacSoTrongMang(List<int> arrays)
        {
            int t = 0;
            for (int i = 0; i < arrays.Count; i++)
            {
                t += arrays[i];
            }
            return t;
        }
    }
}