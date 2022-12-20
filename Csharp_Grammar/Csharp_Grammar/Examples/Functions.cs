using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Grammar.Examples
{
    class car001
    {
        #region 형태
        private string size;
        private string color;

        public void setSize(string size)
        {
            this.size=size;
        }

        public string getSize()
        {
            return size;
        }
    
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }

        #endregion

    }

    class Bread
    {
        public string shape { get; set; }
        public string source { get; set; }   

    }


    public class Functions
    {
        #region >> basic idea of variables
        public void hello()
        {
            Console.WriteLine("Hello");
        }

        public void WriteCh()
        {
            char ch = 'A';
            string strMessage = "hello";

            Console.WriteLine(ch);
            Console.WriteLine(strMessage);
        }

        ///
        ///Object can save any type of data but doesn't know what type it is
        ///var & dynamic both can save any type of data and distinguish what type it is
        ///difference between var & dynamic >> var can not change type once it is used
        ///                                 >> dynamic can change type whenever it wants
        ///
        public void OVdCompare()
        {

            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;

            Console.WriteLine("object = {0}", objValue);
            Console.WriteLine("var = {0}", vValue);
            Console.WriteLine("dynamic = {0}", dValue);

            objValue = "hello";
            vValue = "hello";
            dValue = "hello";

            bool isContain1 = objValue.ToString().Contains("hello");
            bool isContain2 = vValue.ToString().Contains("hello");
            bool isContain3 = dValue.ToString().Contains("hello");

            Console.WriteLine("object has hello? {0}", isContain1);
            Console.WriteLine("var has hello? {0}", isContain2);
            Console.WriteLine("dynamic has hello? {0}", isContain3);



        }
        #endregion

        #region >> type change of variable
    
        public void TypeChangeVariable()
        {
            int korean = 100;
            int english = 90;
            int math = 70;

            int total = korean + english + math;

            Console.WriteLine("total point {0}",total);
            Console.WriteLine("average point {0}",(double)total / 4);
        }

        public void StringToInt()
        {
            string strNum = "10";

            int convertNum= Convert.ToInt32(strNum);
            int parseNum= Int32.Parse(strNum); ;

            Console.WriteLine("{0} + {1} = {2}", convertNum, parseNum, convertNum + parseNum);

        }
     
        #endregion

        #region >> class using 
        
        public void CarClassRun()
        {
            car001 car = new car001();
            car.setSize("suv");
            car.setColor("black");
            Console.WriteLine("your car is " + car.getSize()+ " " + car.getColor());
        }

        public void BreadClassRun()
        {
            Bread cake = new Bread();

            cake.shape = "circle";
            cake.source = "cream";

            Console.WriteLine("Your bread shape is "+cake.shape+" and made of "+cake.source);
        }
      
        #endregion



    }
}
