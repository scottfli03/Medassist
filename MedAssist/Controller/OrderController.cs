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

        public static BindingList<OrderDetails> GetPatientsOrders(int patientID)
        {
            return OrderDAL.GetPatientsOrdersWithDetails(patientID);
        }

        public static Order GetOrderByID(int orderID)
        {
            return OrderDAL.GetOrderByID(orderID);
        }

        public static bool UpdateResults(Order newOrder, Order oldOrder)
        {
            return OrderDAL.UpdateResults(newOrder, oldOrder);
        }
    }
}
