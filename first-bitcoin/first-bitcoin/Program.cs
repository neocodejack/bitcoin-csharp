﻿using System;
using NBitcoin;

namespace first_bitcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" + new Key().GetWif(Network.Main));
        }
    }
}
