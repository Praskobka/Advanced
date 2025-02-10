namespace GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int numsBox=int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(numsBox);
                Console.WriteLine(box.ToString());
            }
        }
    }
}