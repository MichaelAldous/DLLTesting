/* DLLIST Unit Test */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace UnittestDLLList
{
    [TestClass]
    public class UnitTest1
    {
        /*
         *      Testing addToHead function
         */

        /* Testing addToHead, 3 nodes */
        [TestMethod]
        public void TestMethodAddToHead1()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            //Head should be 3, Tail should be 1, and tail.next and head.previous should be null
            Assert.AreEqual(true, (dll.head.str == "3" && dll.tail.str == "1"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodAddToHead1

        /* Testing addToHead, testing link(head -> tail) */
        [TestMethod]
        public void TestMethodAddToHead2()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            //Should be: Head = 3, head.next.str = 2, head.next.next.str = 1
            Assert.AreEqual(true, (dll.head.str == "3" && dll.head.next.str == "2" && dll.head.next.next.str == "1"));
        }//End of TestMethodAddToHead2

        /* Testing addToHead, testing link(tail -> head) */
        [TestMethod]
        public void TestMethodAddToHead3()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            //Should be: Tail = 1, tail.previous.str = 2, tail.previous.previous.str = 3
            Assert.AreEqual(true, (dll.tail.str == "1" && dll.tail.previous.str == "2" && dll.tail.previous.previous.str == "3"));
        }//End of TestMethodAddToHead3

        /* Testing addToHead, 1 Node */
        [TestMethod]
        public void TestMethodAddToHead4()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            //Should be: Head and Tail = 1, and both .next.str and .previous.str are null;
            Assert.AreEqual(true, (dll.head.str == "1" && dll.tail.str == "1"));
            Assert.AreEqual(true, (dll.head.next == null && dll.head.previous == null));
            Assert.AreEqual(true, (dll.tail.next == null && dll.tail.previous == null));
        }//End of TestMethodAddToHead4

        /*
         *      Testing addToTail Function
         */

        /* Testing addToTail, 3 nodes */
        [TestMethod]
        public void TestMethodAddToTail1()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToTail(p);
            p = new DLLNode("2");
            dll.addToTail(p);
            p = new DLLNode("3");
            dll.addToTail(p);
            //Head should be 1, Tail should be 3, and tail.next and head.previous should be null
            Assert.AreEqual(true, (dll.head.str == "1" && dll.tail.str == "3"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodAddToTail1

        /* Testing addToTail, testing link (head -> tail) */
        [TestMethod]
        public void TestMethodAddToTail2()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToTail(p);
            p = new DLLNode("2");
            dll.addToTail(p);
            p = new DLLNode("3");
            dll.addToTail(p);
            //Should be: Head = 1, head.next.str = 2, head.next.next.str = 3
            Assert.AreEqual(true, (dll.head.str == "1" && dll.head.next.str == "2" && dll.head.next.next.str == "3"));
        }//End of TestMethodAddToTail2

        /* Testing addToTail, testing link (Tail -> Head) */
        [TestMethod]
        public void TestMethodAddToTail3()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToTail(p);
            p = new DLLNode("2");
            dll.addToTail(p);
            p = new DLLNode("3");
            dll.addToTail(p);
            //Should be: Tail = 3, tail.previous.str = 2, tail.previous.previous.str = 1
            Assert.AreEqual(true, (dll.tail.str == "3" && dll.tail.previous.str == "2" && dll.tail.previous.previous.str == "1"));
        }//End of TestMethodAddToTail3

        /* Testing addToTail, 1 Node */
        [TestMethod]
        public void TestMethodAddToTail4()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToTail(p);
            //Should be: Head and Tail = 1, and both .next.str and .previous.str are null;
            Assert.AreEqual(true, (dll.head.str == "1" && dll.tail.str == "1"));
            Assert.AreEqual(true, (dll.head.next == null && dll.head.previous == null));
            Assert.AreEqual(true, (dll.tail.next == null && dll.tail.previous == null));
        }//End of TestMethodAddToTail4

        /*
         *      Testing removHead Function
         */

        /* Testing removHead, 3 nodes */
        [TestMethod]
        public void TestMethodRemovHead1()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            dll.removHead();
            //Before removal, order should be 3,2,1
            //After, should be 2,1, with head.previous null, and tail.next null
            Assert.AreEqual(true, (dll.head.str == "2" && dll.tail.str == "1"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodRemovHead1

        /* Testing removHead, testing link (Head -> Tail) */
        [TestMethod]
        public void TestMethodRemovHead2()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            dll.removHead();
            //Before removal, order should be 3,2,1
            //After, should be null -> 2 -> 1 -> null
            Assert.AreEqual(true, (dll.head.previous == null && dll.head.str == "2" && dll.head.next.str == "1" && dll.head.next.next == null));
        }//End of TestMethodRemovHead2

        /* Testing removHead, testing link (Tail -> Head) */
        [TestMethod]
        public void TestMethodRemovHead3()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            dll.removHead();
            //Before removal, order should be 3,2,1
            //After, should be null <- 2 <- 1 <- null
            Assert.AreEqual(true, (dll.tail.str == "1" && dll.tail.previous.str == "2"));
        }//End of TestMethodRemovHead3

        /* Testing removHead, 1 node */
        [TestMethod]
        public void TestMethodRemovHead4()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            dll.removHead();
            //Before removal, list should be 1
            //After, head and tail should point to null
            Assert.AreEqual(true, (dll.head == null && dll.tail == null));
        }//End of TestMethodRemovHead4

        /*
         *      Testing removeTail function
         */

        /* Testing removeTail, 3 nodes */
        [TestMethod]
        public void TestMethodRemovTail1()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            dll.removeTail();
            //Before removal, order should be 3,2,1
            //After, should be 3,2, with head.previous null, and tail.next null
            Assert.AreEqual(true, (dll.head.str == "3" && dll.tail.str == "2"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodRemovTail1

        /* Testing removeTail, testing link (Head -> Tail) */
        [TestMethod]
        public void TestMethodRemovTail2()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            dll.removeTail();
            //Before removal, order should be 3,2,1
            //After, should be null -> 3 -> 2 -> null
            Assert.AreEqual(true, (dll.head.previous == null && dll.head.str == "2" && dll.head.next.str == "1" && dll.head.next.next == null));
        }//End of TestMethodRemoveTail2

        /* Testing removeTail, testing link (Tail -> Head) */
        [TestMethod]
        public void TestMethodRemoveTail3()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("3");
            dll.addToHead(p);
            dll.removeTail();
            //Before removal, order should be 3,2,1
            //After, should be null <- 3 <- 2 <- null
            Assert.AreEqual(true, (dll.tail.next == null && dll.tail.str == "1" && dll.tail.previous.str == "2" && dll.tail.previous.previous == null));
        }//End of TestMethodRemoveTail3

        /* Testing removeTail, 1 node */
        [TestMethod]
        public void TestMethodRemoveTail4()
        {
            DLLNode p = new DLLNode("1");
            DLList dll = new DLList();
            dll.addToHead(p);
            dll.removeTail();
            //Before removal, list should be 1
            //After, head and tail should point to null
            Assert.AreEqual(true, (dll.head == null && dll.tail == null));
        }//End of TestMethodRemoveTail4

        /*
         *      Testing Search function
         */

        /* Testing search, 3 nodes, First position */
        [TestMethod]
        public void TestMethodSearch1()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            Assert.AreEqual(true, (dll.search("1") == dll.head));
        }//End of TestMethodSearch1

        /* Testing search, 3 nodes, Second position */
        [TestMethod]
        public void TestMethodSearch2()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            Assert.AreEqual(true, (dll.search("2") == dll.head.next));
        }//End of TestMethodSearch2

        /* Testing search, 3 nodes, Third position */
        [TestMethod]
        public void TestMethodSearch3()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            Assert.AreEqual(true, (dll.search("3") == dll.tail));
        }//End of TestMethodSearch3

        /* Testing search, 3 nodes, Does exist */
        [TestMethod]
        public void TestMethodSearch4()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            //"4" should not be found, and should return null
            Assert.AreEqual(true, (dll.search("4") == null));
        }//End of TestMethodSearch4

        /*
         *      Testing removeNode
         */

        /* Testing removeNode, 3 nodes, head */
        [TestMethod]
        public void TestMethodRemoveNode1()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            dll.removeNode(dll.head);
            //"4" should not be found, and should return null
            Assert.AreEqual(true, (dll.head.str == "2" && dll.tail.str == "3"));
            Assert.AreEqual(true, (dll.head.next.str == "3" && dll.tail.previous.str == "2"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodRemoveNode1

        /* Testing removeNode, 3 nodes, head.next */
        [TestMethod]
        public void TestMethodRemoveNode2()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            dll.removeNode(dll.head.next);
            //"4" should not be found, and should return null
            Assert.AreEqual(true, (dll.head.str == "1" && dll.tail.str == "3"));
            Assert.AreEqual(true, (dll.head.next.str == "3" && dll.tail.previous.str == "1"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodRemoveNode2

        /* Testing removeNode, 3 nodes, head.next.next */
        [TestMethod]
        public void TestMethodRemoveNode3()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            dll.removeNode(dll.head.next.next);
            //"4" should not be found, and should return null
            Assert.AreEqual(true, (dll.head.str == "1" && dll.tail.str == "2"));
            Assert.AreEqual(true, (dll.head.next.str == "2" && dll.tail.previous.str == "1"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodRemoveNode3

        /* Testing removeNode, 3 nodes, head.prev */
        [TestMethod]
        public void TestMethodRemoveNode4()
        {
            DLLNode p = new DLLNode("3");
            DLList dll = new DLList();
            dll.addToHead(p);
            p = new DLLNode("2");
            dll.addToHead(p);
            p = new DLLNode("1");
            dll.addToHead(p);
            //DLL order == 1,2,3
            dll.removeNode(dll.head.next.next);
            //"4" should not be found, and should return null
            Assert.AreEqual(true, (dll.head.str == "1" && dll.tail.str == "3"));
            Assert.AreEqual(true, (dll.head.next.str == "2" && dll.head.next.next.str == "3" && dll.tail.previous.str == "2" && dll.tail.previous.previous.str =="1"));
            Assert.AreEqual(true, (dll.head.previous == null && dll.tail.next == null));
        }//End of TestMethodRemoveNode4

    }//End of class UnitTest1
}
