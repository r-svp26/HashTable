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
            hash.Add("0", "to");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash0 = hash.Get("0");
            Console.WriteLine("Oth index value:" + hash0);
            string hash3 = hash.Get("3");
            Console.WriteLine("3rd index value:" + hash3);
            hash.Remove(hash3);
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
