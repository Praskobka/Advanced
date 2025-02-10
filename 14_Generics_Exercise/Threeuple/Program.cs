namespace Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] data1 = Console.ReadLine().Split();
            string name1 = data1[0] + " " + data1[1];
            string address = data1[2];
            string town;
            if (data1.Length > 4)
            {
                town = data1[3] + " " + data1[4];
            }
            else
            {
                town = data1[3];
            }
            Threeuple<string, string, string> threeuplePerson = new Threeuple<string, string, string>(name1, address, town);
            Console.WriteLine(threeuplePerson.ToString());
            string[] data2 = Console.ReadLine().Split();
            string name2 = data2[0];
            int possibleBeer = int.Parse(data2[1]);
            string drunk = data2[2];
            bool isDrunk = false;
            if (drunk == "drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }
            Threeuple<string, int, bool> threeupleBeer = new Threeuple<string, int, bool>(name2, possibleBeer, isDrunk);
            Console.WriteLine(threeupleBeer.ToString());
            string[] data3 = Console.ReadLine().Split();
            string name = data3[0];
            double balance = double.Parse(data3[1]);
            string bankName = data3[2];
            Threeuple<string, double, string> threeupleBank = new Threeuple<string, double, string>(name, balance, bankName);
            Console.WriteLine(threeupleBank.ToString());
        }
    }
}