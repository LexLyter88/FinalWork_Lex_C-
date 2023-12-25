using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final
{
    public class FinalWork
    {
        public static void Main(string[] args) {
            string[] arr = {"Hello", "2", "world", ":-)"};

            Console.WriteLine("[\"{0}\"]", string.Join("\", \"", GetArrayWithRestrictElementLength(arr, 3)));
        }

        public static string[] GetArrayWithRestrictElementLength(string[] array, int maxLength) {
            int newLength = 0;
            foreach(string el in array) {
                if(el.Length <= maxLength) {
                    newLength++;
                }
            }

            string[] newArray = new string[newLength];
            int index = 0;
            for(int i = 0; i < array.Length; i++) {        
                if(array[i].Length <= maxLength) {
                    newArray[index++] = array[i];
                }
            }
            return newArray;
        }
    }
}