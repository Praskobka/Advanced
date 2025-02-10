namespace GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
            Console.WriteLine(box.CountLarger(list));
        }

    }
}