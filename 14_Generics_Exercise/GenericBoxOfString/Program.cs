﻿namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string forBox=Console.ReadLine();
                Box<string> box=new Box<string>(forBox);
                Console.WriteLine(box.ToString());
            }
        }
    }
}