﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class Order
    {
        private int orderID;
        private DateTime orderDate;
        private DateTime? datePerformed;
        private char? result;
        private int testID;
        private int visitID;

        public Order() { }

        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        public DateTime? DatePerformed
        {
            get
            {
                return datePerformed;
            }
            set
            {
                datePerformed = value;
            }
        }

        public char? Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        public int TestID
        {
            get
            {
                return testID;
            }
            set
            {
                testID = value;
            }
        }

        public int VisitID
        {
            get
            {
                return visitID;
            }
            set
            {
                visitID = value;
            }
        }
    }
}
