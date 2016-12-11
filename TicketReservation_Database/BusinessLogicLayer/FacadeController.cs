using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class FacadeController
    {
        private FacadeController() { }
        public static FacadeController facadeobject = null;
        public static FacadeController getfacadecontroller()
        {
            if (facadeobject == null)
            {
                facadeobject = new FacadeController();
            }
            return facadeobject;
        }
        public string checkandgive(string name, string contct, string cnic, string seat)
        {
            Seat s = new Seat();
            return s.checkandgive(name, contct, cnic, seat);
        }
        public string[] checkstatus()
        {
            Seat s = new Seat();
            return s.checkstatus();
        }

        public bool remove(string cnic , string seat)
        {
                Seat s = new Seat();
                return s.remove(cnic, seat);
            
        }
    }
}
