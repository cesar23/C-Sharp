using System;
using System.Collections.Generic;
using System.Text;

namespace Notificacion_v1.Utility
{
    public class Date_class
    {
        public static String hourFull()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public static String hour()
        {
            return DateTime.Now.ToString("HH");
        }

        public static String dateFull_US()
        {
            return DateTime.Now.ToString("dd/MM/yyyy"); ;
        }

        public static String dateFull_ES()
        {
            return DateTime.Now.ToString("yyyy/MM/dd"); 
        }


        

    }
}
