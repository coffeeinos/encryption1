using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLaba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("How would you like to encrypt the sentence ?");
            Console.WriteLine("1 - \"Single key permutation\"");
            Console.WriteLine("2 - \"Double permutation by key\"");
            Console.WriteLine("3 - \"Simple method\"");
            int choice = int.Parse(Console.ReadLine());
            char[,] cipher = new char [6,8];
            char[,] cipher_two = new char[6, 8];
            char[,] arr = new char[6, 8];
            char[,] arr_two = new char[6, 8];
            int counter = 0;
            for (int i = 0; i < cipher.GetLength(0); i++)
            {
                for (int j = 0; j < cipher.GetLength(1); j++)
                {
                    if (counter >= sentence.Length)
                    {
                        cipher[i, j] = '*';
                    }
                    else
                    {
                        if (sentence[counter] == ' ')
                        {
                            cipher[i, j] = '*';
                        }
                        else
                        {
                            cipher[i, j] = sentence[counter];
                        }
                    }
                    counter++;
                }
            }
            for (int i = 0; i < cipher_two.GetLength(0); i++)
            {
                for (int j = 0; j < cipher_two.GetLength(1); j++)
                {
                    if (counter >= sentence.Length)
                    {
                        cipher_two[i, j] = '*';
                    }
                    else
                    {
                        if (sentence[counter] == ' ')
                        {
                            cipher_two[i, j] = '*';
                        }
                        else
                        {
                            cipher_two[i, j] = sentence[counter];
                        }
                    }
                    counter++;
                }
            }

            for (int i = 0; i < cipher.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < cipher.GetLength(1); j++)
                {
                    Console.Write(" " + cipher[i, j] + " ");
                }
            }

            Console.WriteLine("");

            for (int i = 0; i < cipher_two.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < cipher_two.GetLength(1); j++)
                {
                    Console.Write(" " + cipher_two[i, j] + " ");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            if (choice == 1)
            {
                Console.WriteLine("Enter the key (random sequence of all digits from 1 to 8)");
                string order = Console.ReadLine();
                // шифрование

                Console.WriteLine("Encrypted message");

                for (int i = 0; i < cipher.GetLength(1); i++)
                {
                    
                    for (int j = 0; j < cipher.GetLength(0); j++)
                    {
                        int order_of_array = int.Parse(order[i].ToString());
                        order_of_array--;
                        arr[j, i] = cipher[j, order_of_array];
                    }

                }
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(" " + arr[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < cipher_two.GetLength(1); i++)
                {

                    for (int j = 0; j < cipher_two.GetLength(0); j++)
                    {
                        int order_of_array = int.Parse(order[i].ToString());
                        order_of_array--;
                        arr_two[j, i] = cipher_two[j, order_of_array];
                    }

                }
                for (int i = 0; i < arr_two.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < arr_two.GetLength(1); j++)
                    {
                        Console.Write(" " + arr_two[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                // разшифрование

                Console.WriteLine("Decrypted message");

                for (int i = 0; i < cipher.GetLength(1); i++)
                {

                    for (int j = 0; j < cipher.GetLength(0); j++)
                    {
                        int order_of_array = int.Parse(order[i].ToString());
                        order_of_array--;
                        cipher[j, order_of_array] = arr[j, i];
                    }

                }
                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < cipher.GetLength(1); i++)
                {

                    for (int j = 0; j < cipher.GetLength(0); j++)
                    {
                        int order_of_array = int.Parse(order[i].ToString());
                        order_of_array--;
                        cipher[j, order_of_array] = arr_two[j, i];
                    }

                }
                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the key (random sequence of all digits from 1 to 8)");
                string order_col = Console.ReadLine();
                Console.WriteLine("Enter the key (random sequence of all digits from 1 to 6)");
                string order_row = Console.ReadLine();
                // шифрование

                Console.WriteLine("Encrypted message");

                for (int i = 0; i < cipher.GetLength(1); i++)
                {

                    for (int j = 0; j < cipher.GetLength(0); j++)
                    {
                        int order_of_array_col = int.Parse(order_col[i].ToString());
                        order_of_array_col--;
                        arr[j, i] = cipher[j, order_of_array_col];
                    }

                }
                for (int i = 0; i < cipher.GetLength(0); i++)
                {

                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        int order_of_array_row = int.Parse(order_row[i].ToString());
                        order_of_array_row--;
                        cipher[i, j] = arr[order_of_array_row, j];
                    }

                }
                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < cipher_two.GetLength(1); i++)
                {

                    for (int j = 0; j < cipher_two.GetLength(0); j++)
                    {
                        int order_of_array_col = int.Parse(order_col[i].ToString());
                        order_of_array_col--;
                        arr_two[j, i] = cipher_two[j, order_of_array_col];
                    }

                }
                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {

                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        int order_of_array_row = int.Parse(order_row[i].ToString());
                        order_of_array_row--;
                        cipher_two[i, j] = arr_two[order_of_array_row, j];
                    }

                }
                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher_two[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                // разшифрование

                Console.WriteLine("Decrypted message");

                for (int i = 0; i < cipher.GetLength(0); i++)
                {

                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        int order_of_array_row = int.Parse(order_row[i].ToString());
                        order_of_array_row--;
                        arr[order_of_array_row, j] = cipher[i, j];
                    }

                }

                for (int i = 0; i < cipher.GetLength(1); i++)
                {

                    for (int j = 0; j < cipher.GetLength(0); j++)
                    {
                        int order_of_array_col = int.Parse(order_col[i].ToString());
                        order_of_array_col--;
                        cipher[j, order_of_array_col] = arr[j, i];
                    }

                }
                
                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {

                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        int order_of_array_row = int.Parse(order_row[i].ToString());
                        order_of_array_row--;
                        arr_two[order_of_array_row, j] = cipher_two[i, j];
                    }

                }

                for (int i = 0; i < cipher_two.GetLength(1); i++)
                {

                    for (int j = 0; j < cipher_two.GetLength(0); j++)
                    {
                        int order_of_array_col = int.Parse(order_col[i].ToString());
                        order_of_array_col--;
                        cipher_two[j, order_of_array_col] = arr_two[j, i];
                    }

                }

                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher_two[i, j] + " ");
                    }
                }

            }
            else if (choice == 3)
            {
                //шифрование

                Console.WriteLine("Encrypted message");

                string code = null;

                for (int i = 0; i < cipher.GetLength(1); i++)
                {
                    for (int j = 0; j < cipher.GetLength(0); j++)
                    {
                        code += cipher[j, i];
                    }
                }

                counter = 0;

                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        cipher[i, j] = code[counter];
                        counter++;
                    }
                }

                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher[i, j] + " ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                code = null;

                for (int i = 0; i < cipher_two.GetLength(1); i++)
                {
                    for (int j = 0; j < cipher_two.GetLength(0); j++)
                    {
                        code += cipher_two[j, i];
                    }
                }

                counter = 0;

                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {
                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        cipher_two[i, j] = code[counter];
                        counter++;
                    }
                }

                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher_two[i, j] + " ");
                    }
                }


                Console.WriteLine("");
                Console.WriteLine("");

                //разшифровка

                Console.WriteLine("Decrypted message");

                code = null;

                counter = 0;

                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        code += cipher[i, j];
                        counter++;
                    }
                }

                counter = 0;

                for (int i = 0; i < cipher.GetLength(1); i++)
                {
                    for (int j = 0; j < cipher.GetLength(0); j++)
                    {
                        cipher[j, i] = code[counter];
                        counter++;
                    }
                }

                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher[i, j] + " ");
                    }
                }

                Console.WriteLine("");

                code = null;

                counter = 0;

                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {
                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        code += cipher_two[i, j];
                        counter++;
                    }
                }

                counter = 0;

                for (int i = 0; i < cipher_two.GetLength(1); i++)
                {
                    for (int j = 0; j < cipher_two.GetLength(0); j++)
                    {
                        cipher_two[j, i] = code[counter];
                        counter++;
                    }
                }

                for (int i = 0; i < cipher_two.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < cipher_two.GetLength(1); j++)
                    {
                        Console.Write(" " + cipher_two[i, j] + " ");
                    }
                }

                Console.WriteLine("");


            }

        }
    }
}
