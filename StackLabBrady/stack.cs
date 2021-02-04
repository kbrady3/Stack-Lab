using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************************************
* Name        : StackLabBrady
* Author      : Kabrina Brady
* Created     : 2/3/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

namespace StackLabCode
{
    public class stack
    {
        // Members
        private int top;  // Will hold the index of the last value present in the stack
        private int maxSize; // Will hold a number that represents the maximum size of the stack
        private string[] stackItems;

        public stack()
        {
            this.maxSize = 5;
            this.top = -1;
            this.stackItems = new string[maxSize];
        }

        public stack(int maxSize)
        {
            this.maxSize = maxSize;
            this.top = -1;
            this.stackItems = new string[maxSize];
        }

        public bool isFull()
        {
            return top == maxSize - 1; // Returns a bool representing whether top is equal to maxSize - 1
        }

        public bool isEmpty()
        {
            //Checks if the first element in the array is empty
            if (stackItems[0] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int size()
        {
            int nullCounter = 0;
            int hasValueCounter = 0;

            for (int i = 0; i < stackItems.Length; i++)
            {
                if (string.IsNullOrEmpty(stackItems[i]))
                {
                    nullCounter++;
                }
                else
                {
                    hasValueCounter++;
                }
            }

            //Returns the number of values the array holds
            return hasValueCounter;
        }

        public string peek()
        {
            if (!this.isEmpty()) // Necessary to check whether the array contains something, otherwise there's nothing to show
                return stackItems[top];
            throw new StackEmptyException(); 
        }

        public string pop()
        {
            if (isEmpty())
            {
                throw new StackEmptyException();
            }
            else
            {
                //Set top
                for (int i = 0; i < stackItems.Length; i++)
                {
                    if (string.IsNullOrEmpty(stackItems[i]))
                    {
                        //Gets the index of the last not null value
                        top = i - 1;
                        break;
                    }
                }

                string item = null;
                string poppedValue = stackItems[top];
                stackItems[top] = item;

                //Sets new top
                if(!(top == 0))
                {
                    top -= 1;
                }

                return poppedValue;
            }
        }


        public void push(string item)
        {
            //Set top
            for(int i = 0; i < stackItems.Length; i++)
            {
                if (string.IsNullOrEmpty(stackItems[i]))
                {
                    //Gets the index of the last not null value
                    top = i - 1;
                    break;
                }
            }

            try
            {
                stackItems[top + 1] = item;
                //Sets new top
                top += 1;
            }
            catch
            {
                throw new StackFullException();
            }
        }

        public string printStackUp()
        {
            string stackString = "";

            if (isEmpty())
            {
                throw new StackEmptyException();
            }
            else
            {
                for (int i = 0; i < stackItems.Length; i++)
                {
                    //Prints each item on a new line
                    stackString += stackItems[i] + "\n";
                }
            }
            return stackString;
        }
    }
}
