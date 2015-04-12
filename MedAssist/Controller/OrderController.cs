using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MedAssist.Model;
using MedAssist.DAL;

namespace MedAssist.Controller
{
    class OrderController
    {
        public OrderController() { }

        public static bool OrderTests(BindingList<Test> tests, int visitID)
        {
            return OrderDAL.OrderTests(tests, visitID);
        } 
    }
}
