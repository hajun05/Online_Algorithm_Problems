using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsWorkspace
{
    class CroatiaAlphabet
    {
        static public short CountCroatia(string str)
        {
            short count = 0;
            short length = (short)str.Length;

            for (short index = 0; index < length; index++)
            {
                char alphabet = str[index];

                switch (alphabet)
                {
                    case 'c':
                        if (index < length - 1)
                            if (str[index + 1] == '=' || str[index + 1] == '-')
                                index++;
                        break;
                    case 'd':
                        if (index < length - 1)
                            if (str[index + 1] == '-')
                                index++;
                            //if (index < length - 2)
                            //    if ((str[index + 1] == 'z' && str[index + 2] == '='))
                            //        index += 2;
                            else if (str[index + 1] == 'z' && index < length - 2)
                                if (str[index + 2] == '=')
                                    index += 2;
                        break;
                    case 'l': case 'n':
                        if (index < length - 1)
                            if (str[index + 1] == 'j')
                                index++;
                        break;
                    case 's':
                        if (index < length - 1)
                            if (str[index + 1] == '=')
                                index++;
                        break;
                    case 'z':
                        if (index < length - 1)
                            if (str[index + 1] == '=')
                                index++;
                        break;
                }
                count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

                string str = ReadLine().ToLower();
                WriteLine($"{CroatiaAlphabet.CountCroatia(str)}");

        }
    }
}