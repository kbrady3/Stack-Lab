using System;
using Xunit;
using StackLabBrady;

namespace TestStackLab
{
    public class UnitTestStackClass
    {
        [Fact]
        public void testCreateStack()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            bool actual;
            // ACT
            actual = myStack.isEmpty();
            // ASSERT
            Assert.True(actual);
        }

        [Fact]
        public void testIsEmptyTrue()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            bool actual, expected;
            // ACT
            actual = myStack.isEmpty();
            expected = true;
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIsEmptyFalse()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            string item = "Java is Fun!";
            bool actual, expected;
            // ACT
            myStack.push(item);
            actual = myStack.isEmpty();
            expected = false;
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIsFullTrue()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            string item = "Java is Fun!";
            bool actual, expected;
            // ACT
            myStack.push(item);
            actual = myStack.isFull();
            expected = true;
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIsFullFalse()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            bool actual, expected;
            // ACT
            actual = myStack.isFull();
            expected = false;
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testPushStack()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(2);
            string item = "StackItem";
            string expected, actual;
            expected = "StackItem2";
            // ACT
            myStack.push(item + "1");
            myStack.push(item + "2");
            actual = myStack.peek(); 
            // ASSERT
            Assert.False(myStack.isEmpty());
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void testPushFullStack()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            string item = "StackItem";
            myStack.push(item);
            // ACT
            // ASSERT
            Assert.Throws<StackLabCode.StackFullException>(() => myStack.push(item));
        }

        [Fact]
        public void testPopStack()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(2);
            string item = "StackItem";
            string actual1, actual2, expected1, expected2;
            expected1 = "StackItem2";
            expected2 = "StackItem1";
            myStack.push(item + "1");
            myStack.push(item + "2");
            // ACT
            actual1 = myStack.pop();
            actual2 = myStack.pop();
            // ASSERT
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.True(myStack.isEmpty());
        }

        [Fact]
        public void testStackSizeZero()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(2);
            int actual, expected;
            expected = 0;
            // ACT
            actual = myStack.size();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testStackSizeNonZero()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(2);
            string item = "StackItem";
            int actual, expected;
            expected = 2;
            // ACT
            myStack.push(item + "1");
            myStack.push(item + "2");
            actual = myStack.size();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testPopEmptyStack()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            // ACT
            // ASSERT
            Assert.Throws<StackLabCode.StackEmptyException>(() => myStack.pop());
        }

        [Fact]
        public void testPeekStack() {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            string item = "StackItem";
            string actual, expected;
            // ACT
            myStack.push(item);
            expected = item;
            actual = myStack.peek();
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testPeekEmptyStack()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            // ACT
            // ASSERT
            Assert.Throws<StackLabCode.StackEmptyException>(() => myStack.peek());
        }

        [Fact]
        public void testPrintStackUp()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(2);
            string item = "StackItem";
            string actual, expected;
            expected = "StackItem1\nStackItem2\n";
            // ACT
            myStack.push(item + "1");
            myStack.push(item + "2");
            actual = myStack.printStackUp();
            // ASSERT
            Assert.Equal(expected, actual);
            Assert.False(myStack.isEmpty());
        }

        [Fact]
        public void testPrintStackUpEmptyStack()
        {
            // ARRANGE
            StackLabCode.stack myStack = new StackLabCode.stack(1);
            // ACT
            // ASSERT
            Assert.Throws<StackLabCode.StackEmptyException>(() => myStack.printStackUp());
        }
    }
}