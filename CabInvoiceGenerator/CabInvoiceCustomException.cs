﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceCustomException:Exception
    {
        public enum ExceptionType
        {
            INVALID_DISTANCE, 
            INVALID_TIME,
            INVALID_USER_ID,
            NULL_RIDES
        }
        public ExceptionType type;
        public CabInvoiceCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
