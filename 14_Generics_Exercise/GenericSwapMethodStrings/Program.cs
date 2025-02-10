namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        public static void Main()
        {
            List<Box<string>> list = new List<Box<string>>();
            int n=int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string values=Console.ReadLine();
                Box<string> box=new Box<string>(values);
                list.Add(box);
            }
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(list, indices[0],indices[1]);
            foreach(Box<string> box in list)
            {
                Console.WriteLine(box.ToString());
            }
        }
        public static void Swap<T>(List<T> list,int index1,int index2)
        {
            T temp=list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}