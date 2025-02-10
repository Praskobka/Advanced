namespace GenericCountMethodString
{
    public class StartUp
    {
        public static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for(int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            Box<string> box=new Box<string>(Console.ReadLine());
            Console.WriteLine(box.CountLarger(list));
        }
       
    }
}