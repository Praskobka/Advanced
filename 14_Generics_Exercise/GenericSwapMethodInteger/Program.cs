namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        public static void Main()
        {
            List<Box<int>> list = new List<Box<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int values = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(values);
                list.Add(box);
            }
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(list, indices[0], indices[1]);
            foreach (Box<int> box in list)
            {
                Console.WriteLine(box.ToString());
            }
        }
        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}