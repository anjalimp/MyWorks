using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBL
{
    public class NumberToWord
    {      
        public String ChangeNumberToWords(String number)
        {
            String val = String.Empty;
            String wholeNumber = number;
            String points = String.Empty;
            String andStr = "";
            String pointStr =  String.Empty;
            try
            {
                int decimalPlace = number.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNumber = number.Substring(0, decimalPlace);
                    points = number.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        pointStr = TranslateDecimal(points);
                        andStr = " point";
                    }
                }
                String wholeStr = TranslateWholeNumber(wholeNumber);
                if (wholeStr.EndsWith("and"))
                {
                    wholeStr = wholeStr.Remove(wholeStr.LastIndexOf("and"), 3);
                }
                val = String.Format("{0}{1}{2}", wholeStr, andStr, pointStr);              
            }
            catch(Exception ex) 
            {
                val = ex.Message;               
            }
            return val;
        }
        public String Tens(String digitStr)
        {
            String name = String.Empty; ;
            try
            {
                int digit = Convert.ToInt32(digitStr);
                switch (digit)
                {
                    case 10:
                        name = "Ten";
                        break;
                    case 11:
                        name = "Eleven";
                        break;
                    case 12:
                        name = "Twelve";
                        break;
                    case 13:
                        name = "Thirteen";
                        break;
                    case 14:
                        name = "Fourteen";
                        break;
                    case 15:
                        name = "Fifteen";
                        break;
                    case 16:
                        name = "Sixteen";
                        break;
                    case 17:
                        name = "Seventeen";
                        break;
                    case 18:
                        name = "Eighteen";
                        break;
                    case 19:
                        name = "Nineteen";
                        break;
                    case 20:
                        name = "Twenty";
                        break;
                    case 30:
                        name = "Thirty";
                        break;
                    case 40:
                        name = "Fourty";
                        break;
                    case 50:
                        name = "Fifty";
                        break;
                    case 60:
                        name = "Sixty";
                        break;
                    case 70:
                        name = "Seventy";
                        break;
                    case 80:
                        name = "Eighty";
                        break;
                    case 90:
                        name = "Ninety";
                        break;
                    default:
                        if (digit > 0)
                        {
                            name = Tens(digitStr.Substring(0, 1) + "0") + " " + Ones(digitStr.Substring(1));
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
            return name;
        }
        public String Ones(String digitStr)
        {
            String name = String.Empty;
            try
            {
                int digit = Convert.ToInt32(digitStr);              
                switch (digit)
                {
                    case 1:
                        name = "One";
                        break;
                    case 2:
                        name = "Two";
                        break;
                    case 3:
                        name = "Three";
                        break;
                    case 4:
                        name = "Four";
                        break;
                    case 5:
                        name = "Five";
                        break;
                    case 6:
                        name = "Six";
                        break;
                    case 7:
                        name = "Seven";
                        break;
                    case 8:
                        name = "Eight";
                        break;
                    case 9:
                        name = "Nine";
                        break;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
          
            return name;
        }
        public String TranslateDecimal(String decStr)
        {
            String dec = String.Empty;
            String digit = String.Empty;
            String engOne = String.Empty;
            try
            {
                for (int i = 0; i < decStr.Length; i++)
                {
                    digit = decStr[i].ToString();
                    if (digit.Equals("0"))
                    {
                        engOne = "Zero";
                    }
                    else
                    {
                        engOne = Ones(digit);
                    }
                    dec += " " + engOne;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
            return dec;
        }
        public String TranslateWholeNumber(String number)
        {
            String word = String.Empty;
            try
            {               
                bool isDone = false;
                bool isHundred = false;              
                
               number =  (number.StartsWith("0")) ? number.Remove(0,1).ToString() : number;

               int numDigits = number.Length;
               int pos = 0;
               String place = "";
                    switch (numDigits)
                    {
                        case 1:
                            word = Ones(number);
                            isDone = true;
                            break;
                        case 2:
                            word = Tens(number);
                            isDone = true;
                            break;
                        case 3:
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            isHundred = true;
                            break;
                        case 4:
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 7:
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million ";
                            break;
                        case 10:
                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {
                        word = TranslateWholeNumber(number.Substring(0, pos)) + place;
                        word = (isHundred) ? word + "and " : word + " ";
                        word = word + TranslateWholeNumber(number.Substring(pos));                                                                     
                    }
                    
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            catch(Exception ex)
            {
                throw;
            }
            return word.Trim();
        }
    }
}
