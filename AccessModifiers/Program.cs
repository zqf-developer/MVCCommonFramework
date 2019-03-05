using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {

        class Modifiers
        {
            /// <summary>
            /// 默认private
            /// </summary>
            static void AAA()
            {
                Console.WriteLine("Modifiers AAA");
            }
            public static void BBB()
            {
                Console.WriteLine("Modifiers BBB");
                AAA();
                CCC();
                
            }
            
            /// <summary>
            /// 如果没有添加static关键字，不能被任何
            /// </summary>
            protected static void CCC()
            {
                Console.WriteLine("Modifiers CCC");
            }

        }

        static void Main(string[] args)
        {
            //测试public和private的访问控制符控制范围
            Modifiers.BBB();
            //AAA不可访问，因为有一定的访问权限
            //Modifiers.AAA();
            //CCC不可访问，因为有一定的访问权限
            //Modifiers.CCC();
            Console.ReadKey();
        }
    }
}
