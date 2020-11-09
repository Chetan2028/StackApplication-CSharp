using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackApplication;
namespace StackMSTest
{
    [TestClass]
    public class StackUnitTest
    {
        /// <summary>
        /// Checks the element if added to stack happy case.
        /// </summary>
        [TestMethod]
        public void CheckElementIfAddedToStack_HappyCase()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(60);
            linkedListStack.Push(40);

            int expectedResult1 = 40;
            int expectedResult2 = 60;

            Assert.AreEqual(expectedResult1,linkedListStack.top.data);
            Assert.AreEqual(expectedResult2, linkedListStack.top.next.data);
        }
        /// <summary>
        /// Checks the element added to stack sad case.
        /// </summary>
        [TestMethod]
        public void CheckElementAddedToStack_SadCase()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(60);
            linkedListStack.Push(40);
            int expectedResult1 = 60;
            int expectedResult2 = 40;

            Assert.AreNotEqual(expectedResult1, linkedListStack.top.data);
            Assert.AreNotEqual(expectedResult2, linkedListStack.top.next.data);
        }

        /// <summary>
        /// Checks the element peeked from stack happy case.
        /// </summary>
        [TestMethod]
        public void CheckElementPeekedFromStack_HappyCase()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(10);
            linkedListStack.Push(20);
            linkedListStack.Push(30);
            linkedListStack.Push(40);
            linkedListStack.Peek();

            int expected = 40;

            Assert.AreEqual(expected, linkedListStack.top.data);
        }

        /// <summary>
        /// Checks the element peeked from stack sad case.
        /// </summary>
        [TestMethod]
        public void CheckElementPeekedFromStack_SadCase()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(10);
            linkedListStack.Push(20);
            linkedListStack.Push(30);
            linkedListStack.Push(40);
            linkedListStack.Peek();

            int expected = 30;

            Assert.AreNotEqual(expected, linkedListStack.top.data);
        }
    }
}
