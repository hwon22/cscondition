﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("숫자입력: ");
            var input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            else { 
                Console.WriteLine("홀수입니다!");
            }

            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //오전과 오후 구분
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else{
                Console.WriteLine("오후입니다.");
            }


        }
    }
}
