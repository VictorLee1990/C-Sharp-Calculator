using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clculate
{
    class clc 
    {

                         
        public static double math(string Op,double value,double sum)
        {
            
           
            switch (Op)
            {
                        case "+":
                            sum += value;
                            break;
                        case "-":
                            sum -= value;
                            break;
                        case "*":
                            sum *= value;
                            break;
                        case "/":
                            sum /= value;
                            break;
                        case "sqrt":
                            //sum = sum;
                            break;   
             }                                                  
                 return sum;            
        }

        public static string negate(string text)
        {
            
            if (text == "")
            {
                text = "";
            }
            else if (text != "")
            {
                double sin = Convert.ToDouble(text);
                Math.Sign(sin);
                if (Math.Sign(sin) > 0)
                
                    sin = 0 - sin;                                 
                else               
                    sin = 0 - sin;   
                    text = sin.ToString();                                 
            } 
            return text;
        }
    }
}
