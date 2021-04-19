using System;

namespace HomeWork4_2_054
{
    class Program
    {
        static string halfDNASequence = Console.ReadLine();
        static char Confirm;
        static void Main()
        {
            do
            {
                IsValidSequence(halfDNASequence);
                if (IsValidSequence(halfDNASequence) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", halfDNASequence);
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    Confirm = Char.Parse(Console.ReadLine());
                    while (Confirm != 'Y' && Confirm != 'N')
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                    }
                    if (Confirm == 'Y') // replicate
                    {
                        ReplicateSeqeunce(halfDNASequence);
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(halfDNASequence));
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                        while (Confirm != 'Y' && Confirm != 'N') // another
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            Confirm = Char.Parse(Console.ReadLine());
                        }
                        if (Confirm == 'Y')
                        {
                            do
                            {
                                newSequence();
                            }
                            while (Confirm == 'Y');
                        }
                    }
                    else // not replicate
                    {
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                        while (Confirm != 'Y' && Confirm != 'N') // another
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            Confirm = Char.Parse(Console.ReadLine());
                        }
                        if (Confirm == 'Y')
                        {
                            do
                            {
                                newSequence();
                            }
                            while (Confirm == 'Y');
                        }
                    }
                }
                else // invalid
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                    Console.Write("Do you want to process another sequence ? (Y/N) : ");
                    Confirm = Char.Parse(Console.ReadLine());
                    while (Confirm != 'Y' && Confirm != 'N') // another
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                    }
                    if (Confirm == 'Y')
                    {
                        do
                        {
                            newSequence();
                        }
                        while (Confirm == 'Y');
                    }
                }
            }
            while (Confirm == 'Y');
        }
        static void newSequence()
        {
            do
            {
                IsValidSequence(halfDNASequence = Console.ReadLine());
                if (IsValidSequence(halfDNASequence) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", halfDNASequence);
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    Confirm = Char.Parse(Console.ReadLine());
                    while (Confirm != 'Y' && Confirm != 'N') // replicate
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                    }
                    if (Confirm == 'Y')
                    {
                        ReplicateSeqeunce(halfDNASequence);
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(halfDNASequence));
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                        while (Confirm != 'Y' && Confirm != 'N') // another
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            Confirm = Char.Parse(Console.ReadLine());
                        }
                        if (Confirm == 'Y')
                        {
                            do
                            {
                                newSequence();
                            }
                            while (Confirm == 'Y');
                        }
                    }
                    else // not replicate
                    {
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                        while (Confirm != 'Y' && Confirm != 'N') // another
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            Confirm = Char.Parse(Console.ReadLine());
                        }
                        if (Confirm == 'Y')
                        {
                            do
                            {
                                newSequence();
                            }
                            while (Confirm == 'Y');
                        }
                    }
                }
                else // invalid
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                    Console.Write("Do you want to process another sequence ? (Y/N) : ");
                    Confirm = Char.Parse(Console.ReadLine());
                    while (Confirm != 'Y' && Confirm != 'N') // another
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");
                        Confirm = Char.Parse(Console.ReadLine());
                    }
                    if (Confirm == 'Y')
                    {
                        do
                        {
                            newSequence();
                        }
                        while (Confirm == 'Y');
                    }
                }
            }
            while (Confirm == 'Y');
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
    }
}
