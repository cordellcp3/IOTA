using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOTA
{
    public static class IOTAHelper
    {
        //properties
        private String _seed = String.Empty;
        public String Seed 
        {
            get { return _seed; }
            set { _seed = value; }
        }
        
        //constants
        private static readonly String TRYTE_ALPHABET = "9ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly Int32 SEED_LENGTH = 81;
        
        //methods
        public static String GenerateSeed()
        {
            var r = new Random();
            var builder = new StringBuilder();
            
            for(int i = 0; i < SEED_LENGTH; i++)
            {
                builder.Append(TRYTE_ALPHABET[r.Next(0, TRYTE_ALPHABET.Length)]);
            }
            
            return builder.ToString();
        }
    }
}