﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MifGen
{
    static class SquareWave
    {
    
    
        public static void Tri_gen()
        {
           
            double i;
            long t = (long)Math.Pow(2, 15) ;
            ArrayList list = new ArrayList();
            long counter = 0;
            string c_or_s;
            // 向ArrayList中添加一些内容
            int add = list.Add("MEMORY_INITIALIZATION_RADIX=16;");
            list.Add("MEMORY_INITIALIZATION_VECTOR=");
            for (i = 0; i < t + 1; i ++)
            {
                var y = ((Math.Pow(2,14)-1)>i)? 1:0;
                
                // Console.WriteLine(r);

                c_or_s = counter == (long)(Math.Pow(2, 15)) ? ";" : ",";
               
                var temp = Convert.ToString((long) y, 16) + c_or_s;
                add = list.Add(temp);

                counter = counter + 1;

            }
            // Console.WriteLine(counter);
            // Console.ReadKey();
            // 创建文件。如果文件存在则覆盖
            var fs = File.Open(@"d:\Triangle.coe", FileMode.Create);
            // 创建写入流
            var wr = new StreamWriter(fs);
            // 将ArrayList中的每个项逐一写入文件
            foreach (var t1 in list)
            {
                wr.WriteLine(t1);
            }
            // 关闭写入流wr.Flush();
            wr.Close();
            // 关闭文件
            fs.Close();
        }
    }
}
