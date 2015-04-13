﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssist.Model
{
    class OrderDetails
    {
        private int orderID;
        private DateTime orderDate;
        private DateTime? datePerformed;
        private Boolean? result;
        private int testID;
        private int visitID;
        private string patientName;
        private string TestName;

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

        public Boolean? Result
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
