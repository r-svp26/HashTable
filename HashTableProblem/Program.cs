using System;

namespace HashTableProblem
{
    class Program
    {
        static readonly MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        /// <summary>
        /// print the HashTable operations.
        /// </summary>
        public static void HashOperation()
        {
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into ");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");
            string hash0 = hash.Get("0");
            Console.WriteLine("Oth index value:" + hash0);
            string hash3 = hash.Get("3");
            Console.WriteLine("3rd index value:" + hash3);
            hash.Remove(hash3);
            string hash10 = hash.Get("10");
            Console.WriteLine("10th index value:" + hash10);
        }
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.HashOperation();
        }
    }
}
