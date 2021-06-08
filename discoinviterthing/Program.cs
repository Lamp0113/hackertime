//This project is libre, and licenced under the terms of the
//DO WHAT THE FUCK YOU WANT TO PUBLIC LICENCE, version 3.1,
//as published by dtf on July 2019. See the COPYING file or
//https://ph.dtf.wtf/w/wtfpl/#version-3-1 for more details.
using System;

namespace discoinviterthing
{
    class Program
    {
        static void Main(string[] args)
        {
            string invite = ("dbQxrq");
            string strone;
            string[] raymond = new string[26];

            raymond[0] = "a";
            raymond[1] = "b";
            raymond[2] = "c";
            raymond[3] = "d";
            raymond[4] = "e";
            raymond[5] = "f";
            raymond[6] = "g";
            raymond[7] = "h";
            raymond[8] = "i";
            raymond[9] = "j";
            raymond[10] = "k";
            raymond[11] = "l";
            raymond[12] = "m";
            raymond[13] = "n";
            raymond[14] = "o";
            raymond[15] = "p";
            raymond[16] = "q";
            raymond[17] = "r";
            raymond[18] = "s";
            raymond[19] = "t";
            raymond[20] = "u";
            raymond[21] = "v";
            raymond[22] = "w";
            raymond[23] = "x";
            raymond[24] = "y";
            raymond[25] = "z";

            for (int i=0; i<26; i++)
            {
                strone = raymond[i];
                for (int a=0; a<10; a++)
                {
                    Console.WriteLine("discord.gg/" + raymond[i] + invite + a);
                }
            }
        }
    }
}