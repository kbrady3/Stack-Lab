using System;
using System.Collections.Generic;
using System.Text;

namespace StackLabCode
{
    public class StackEmptyException: Exception
    {
        public override string Message
        {
            get
            {
                return "Stack is Empty";
            }
        }
    }
}
