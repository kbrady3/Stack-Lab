using System;
using System.Collections.Generic;
using System.Text;

namespace StackLabCode
{
    public class StackFullException : Exception
    {
        public override string Message
        {
            get
            {
                return "Stack is Full";
            }
        }
    }
}
