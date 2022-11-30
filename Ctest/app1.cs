using System;
using System.Threading;
using 应用1;


namespace Ctest//命名空间为Ctest，可以为中文？
{
    class Program1//声明一个类，在括号里都是这个类的成员
    {

        static uint st1;
        

        static void Main()//编译器把他作为程序的起始点，相当于主函数
        {

            /*   ushort val1 = 1000;
               uint val2 = 230;
               //字符：WriteLine代表打印换行，Write直接打印
               Console.Write("hello world! {0}", val1);//{num}代表第几个变量
               Console.WriteLine("hello world! {1}, {0}, {1}", val1, val2, 3);//{num}代表第几个变量
               Console.WriteLine("hello world! {0:C}", val1);//表示货币
               Console.WriteLine("hello world! {0,10}", val1);//变量在第10个字符位置对齐
               Console.WriteLine("|{0,20}|", val1);//右对齐
               Console.WriteLine("|{0,-20}|", val1);//左对齐
               //C，c:货币   D，d：十进制字符  F,f：小数定点  G，g：例{0:G4} 12.34567→12.34
               //X，x：十六进制字符  N，n：带逗号小数  P，p小数转百分比位数
               //R,r:字符串转成数字  E,e：科学计数法
               */
            /***  多行注释  ***/
            /*
            Console.WriteLine("{0:F4}", 123.4345466);//4位小数字符
            Console.WriteLine("{0:N4}", 123456123.4345466);//4位小数字符

            //从类的外部访问成员
            DaysTemp temp = new DaysTemp();
            Console.WriteLine("high: {0}", temp.high);
            Console.WriteLine("low: {0}", temp.low);

            temp.Test1(8);//引用运行其它类里的函数
            Console.WriteLine("low: {0}", temp.Test2(2));//引用运行其它类里的函数

            temp.high = 85;
            temp.low = 60;
            Console.WriteLine("high: {0}", temp.high);
            Console.WriteLine("low: {0}", temp.low);

            //引用其它文件的类，函数，变量，函数名称可以一样，类名不可以，每个空间可以包括多个类，且空间名称唯一
            DaysTemp2 temp2 = new DaysTemp2();
            Console.WriteLine("high: {0}", temp2.high2);
            Console.WriteLine("low: {0}", temp2.low2);
            temp2.Test1(8);//引用运行其它类里的函数
            Console.WriteLine("low: {0}", temp2.Test2(2));//引用运行其它类里的函数
            */



            ////Parse 方法用于将字符串类型转换成任意类型，具体的语法形式如下。
            ////数据类型 变量 = 数据类型.Parse(字符串类型的值),要求值不能超
            ////字符转有符号数字1
            //string va1 = "12";
            //Console.WriteLine("字符转有符号数字: {0}", (float.Parse(va1)-23));

            ////字符转双精度浮点(DBL)2
            //string va2 = "123.4";
            //Console.WriteLine("字符转双精度浮点: {0}", (float.Parse(va2) - 23));

            ////字符转无符号数字3
            //string va3 = "13";
            //Console.WriteLine("字符转无符号数字3: {0}", (byte.Parse(va3)));

            ////字符转有符号数字4
            //string va4 = "-123";
            //Console.WriteLine("字符转无符号数字3: {0}", (sbyte.Parse(va4) - 23));

            ////双精度浮点(DBL)转字符5
            //double va5 = 12.455;
            //Console.WriteLine("双精度浮点(DBL)转字符: {0}", (Convert.ToString(va5)));

            ////无符号数字转字符6
            //uint va6 = 33;
            //Console.WriteLine("无符号数字转字符5: {0}", (Convert.ToString(va6)));

            ////有符号数字转字符7
            //int va7 = -33;
            //Console.WriteLine("有符号数字转字符: {0}", (Convert.ToString(va7)));

            ////数字转双精度浮点(DBL)8
            //int va8 = -12;
            //Console.WriteLine("数字转双精度浮点(DBL): {0}", (double)va8);

            ////数字转单精度浮点(SGL)9
            //int va9 = -88;//单精度数值后面需要加F
            //Console.WriteLine("数字转双精度浮点(DBL): {0}", (float)va9);

            Thread pritf1 = new Thread(run1);//此方法创建的线程无法调用外部变量，数据独立
            pritf1.Start();
            pritf1.IsBackground = true;

            Thread pritf2 = new Thread(run2);
            pritf2.Start();

            uint st2;
            for (int i = 0; i < 1000; i++)
            {
                
                st2 = st1;
                Console.WriteLine("for循环打印{0}", st2);
                Thread.Sleep(800);


            }



            //Thread.Sleep(50000);

        }
        static void run1()
        {
            //  1、静态方法是不属于特定对象的方法；

　　          //2、静态方法可以访问静态成员；

　　          //3、静态方法不可以直接访问实例成员，可以在实例函数调用的情况下，实例成员做为参数传给静态方法；

　　          //4、静态方法也不能直接调用实例方法，可以间接调用，首先要创建一个类的实例，然后通过这一特定对象来调用静态方法。
            
            while (true)
            {
                Console.WriteLine("线程run1打印");
                Thread.Sleep(500);
                st1++;
                
            }


        }

        static void run2()
        {

            while (true)
            {
                Console.WriteLine("线程run2打印{0}", st1);
                
                Thread.Sleep(800);

            }
        }


    }
    class Apptest1
    {
        int intval = 3;
        void Somemethod()
        { 
            if(intval == 3)
            {
               Console.WriteLine("low: {0}", intval);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("low: {0}", i);
            }
        }
        
    }











    class DaysTemp
    {
        public int high = 30;
        public int low = 20;
        private int higttter = 2;
        public void Test1(int t1)
        {
            Console.WriteLine("low: {0}", higttter + t1);
        }
        public int Test2(int t2)
        {
            return higttter - t2;
        }

    }

}
