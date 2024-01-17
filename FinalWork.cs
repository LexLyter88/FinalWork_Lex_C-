using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final
{
    public class FinalWork
    {
        private const int ELEMENT_MAX_LENGTH = 3;
        public static void Main(string[] args) 
        {
            string[] arr = {"Hello", "2", "world", ":-)"};

            Console.WriteLine("[\"{0}\"]", string.Join("\", \"", GetArrayWithRestrictElementLength(arr, ELEMENT_MAX_LENGTH)));
        }

        public static string[] GetArrayWithRestrictElementLength(string[] array, int maxLengthElement) {
            string[] newArray = new string[GetLengthForArray(array, maxLengthElement)];
            int index = 0;
            for(int i = 0; i < array.Length; i++) 
            {        
                if(array[i].Length <= maxLengthElement) 
                {
                    newArray[index++] = array[i];
                }
            }
            return newArray;
        }

        private static int GetLengthForArray(string[] array, int maxLengthElement) {
            int newLength = 0;
            foreach(string el in array) 
            {
                if(el.Length <= maxLengthElement) 
                {
                    newLength++;
                }
            }
            return newLength;
        }
    }
}