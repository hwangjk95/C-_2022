using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_01_HwangJaeGyu
{
    class UserInt//사용자 정의 자료형
    {
        public int Number;
    }
    
    
    
    internal class Program
    {
        static void Main(string[] args) //프로그램 진입점. entry point
        {
            int[] arrInt = new int[4]; //value type
            UserInt[] arrUserInt = new UserInt[4]; //reftype

            /*for(int i=0; i<arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }*/

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrUserInt[i].Number);
            }

        }
    }
}

