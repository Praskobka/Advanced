namespace Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] data1 = Console.ReadLine().Split();
            string name1=data1[0]+" "+data1[1];
            string address = data1[2];
            Tuple<string,string> tuplePerson=new Tuple<string,string>(name1,address);
            Console.WriteLine(tuplePerson.ToString());
            string[] data2 = Console.ReadLine().Split();
            string name2 = data2[0];
            int possibleBeer=int.Parse(data2[1]);
            Tuple<string,int> tupleBeer=new Tuple<string,int>(name2,possibleBeer);
            Console.WriteLine(tupleBeer.ToString());
            string[] data3 = Console.ReadLine().Split();
            int integer=int.Parse(data3[0]);
            double doubles=double.Parse(data3[1]);
            Tuple<int,double> tupleNumbers=new Tuple<int,double>(integer,doubles);
            Console.WriteLine(tupleNumbers.ToString());
        }
    }
}