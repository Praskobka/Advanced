using System.Threading.Tasks.Dataflow;

namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main()
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] ints = ArrayCreator.Create(10, 33);
        }
    }
}