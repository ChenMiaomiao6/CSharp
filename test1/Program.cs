using System;
namespace RectangleApplication
{
    class Rectangle
    {
        // 成员变量
        double length;
        double width;
        string unit;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
            unit = "cm";
        }
        /// <summary>
        /// 接受外部参数输入
        /// </summary>
        /// <param name="len"></param>
        /// <param name="w"></param>
        /// <param name="un"></param>
        public void Acceptdetails(double len,double w,string un)
        {
            this.length = len;
            this.width = w;
            this.unit = un;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}{1}", length,unit);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();//新增房间1，r1是房间1的钥匙
            Rectangle r2 = new Rectangle();//新增房间2，r2是房间2的钥匙
            //Rectangle r3 = r1;//r3是房间1的钥匙 

            r1.Acceptdetails(1,2,"cm");
            r2.Acceptdetails(10, 20,"mm");
            

            r1.Display();
            r2.Display();
            Console.ReadLine();
        }
    }
}
