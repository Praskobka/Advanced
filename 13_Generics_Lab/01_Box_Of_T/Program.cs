﻿namespace BoxOfT
{
    public class StartUp
    {
        public static void Main()
        {
            BoxOfT<int> box = new BoxOfT<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
        }
    }
}