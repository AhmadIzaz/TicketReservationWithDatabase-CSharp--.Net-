using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessLayer;
using System.Text.RegularExpressions;

namespace BusinessLogicLayer
{
    class Seat
    {
         public string checkandgive(string name, string contact, string cnic, string seat)
         {
             DBHandler f = new DBHandler();
             string s = "false";
             if (string.IsNullOrEmpty(name))
             {
                 return name;
             }
             else if (string.IsNullOrEmpty(contact))
             {
                 return contact;
             }
             else if (string.IsNullOrEmpty(cnic))
             {
                 return cnic;
             }
             else if (string.IsNullOrEmpty(seat))
             {
                 return seat;
             }
             else
             {
                 if (!(checktextboxforchar(name)))
                     return name;
                 else if (!(checktextboxfornum(contact)))
                     return contact;
                 else if (!(checktextboxforcnic(cnic)))
                     return cnic;
                 else if (f.exist(seat) == true)
                     return seat;
                 else
                 {
                     bool b = f.writeonfile(name, contact, cnic, seat);
                     if (b == true)
                     {
                         s = "true";
                     }
                 }
             }
             return s;

         }
        private bool checktextboxforchar(string s)
         {
             char []arr = s.ToCharArray();
             try
             {
                 for (int i = 0; i < arr.Length; i++)
                 {
                     if (!(char.IsLetter(arr[i])) && arr[i] != ' ')
                     {
                         return false;
                     }
                 }
            
             }
             catch (IndexOutOfRangeException obj)
             { }
             catch (NullReferenceException obj)
             { }
             return true;
          }
         private bool checktextboxfornum(string s)
         {
             try
             {
                 char[] arr = s.ToCharArray();
                 if (s.Length == 11)
                 {
                     for (int i = 0; i < s.Length; i++)
                     {
                         if (!(char.IsNumber(arr[i])))
                         {
                             return false;
                         }
                     }
                 }
                 else
                 {
                     return false;
                 }
             }
             catch (IndexOutOfRangeException obj)
             { }
             catch (NullReferenceException obj)
             { }
             catch (ArgumentException obj)
             { }
             return true;
         }
         private bool checktextboxforcnic(string s)
         {
             Regex regular;
             string format = @"^[0-9]{5}-[0-9]{7}-[0-9]{1}$";
             regular = new Regex(format);
             if (regular.IsMatch(s))
             {
                 return true;
             }
            return false;   
         }
         
         public string[] checkstatus()
         {
             DBHandler f = new DBHandler();
             string []arr = f.checkstatus();
             return arr;            
         }
         public bool remove( string cni, string seat)
         {
             DBHandler f = new DBHandler();
             if ((checktextboxforcnic(cni)) == false  || seat.Length > 3 || seat[0] !='7' || !(seat[1] > '0' && seat[1] < '9') || !(seat[2] >= 'A' && seat[2]<= 'Z'))
             {
                 return false;
             }
             return f.remove(cni, seat);
        }
         

    }
}
