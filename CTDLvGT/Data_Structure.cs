


using System.Collections.Generic;
using System.Collections;
using System;
using System.Text;
namespace Data_Structure
{
    #region  //Stack and Queue
    public class MyStack
    {
        /// <summary>
        /// Chuyen so nguyen ve Bit
        /// </summary>
        public class bitConverter
        {
            public static void Start(int n)
            {
                Stack<int> stack = new Stack<int>();
                do
                {
                    stack.Push(n % 2);
                    n = n / 2;

                } while (n != 0);
                while (stack.Count != 0)
                {
                    Console.Write(stack.Pop());
                }

            }

        }
        /// <summary>
        /// Chuyen so dang aaabbc thanh a3b2c1
        /// </summary>
        public class Encoder
        {
            public static void Start(string s)
            {
                Stack<char> stack = new Stack<char>();
                StringBuilder rs = new StringBuilder(s[0] + "1");
                stack.Push(s[0]);
                for (int i = 1; i < s.Length; i++)
                {
                    char check = stack.Peek();
                    stack.Push(s[i]);
                    if (check == stack.Peek())
                    {
                        rs[rs.Length - 1] += (char)1;
                    }
                    else
                        rs.Append(s[i] + "1");
                }
                Console.WriteLine(rs);
            }
        }
    }

    public class MyQueue
    {
        /// <summary>
        /// Chuyen phan tu dau Queue ve cuoi Queue
        /// </summary>
        public class Cycle

        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="arr"> Mang dau vao</param>
            /// <param name="k">So lan chuyen tu dau xuong cuoi</param>
            public static void Start(int[] arr, int k)
            {
                Queue<int> queue = new Queue<int>(arr);
                for (int i = 1; i <= k; i++)
                {

                    queue.Enqueue(queue.Peek());
                    queue.Dequeue();

                }
                foreach (var item in queue)
                {
                    Console.Write(item + " ");
                }

            }
        }
        /// <summary>
        /// Dua ra cac so la so sieu nguyen to nho hon hoac bang n
        /// So sieu nguyen to la 
        ///   Ban than no la so nguyen to
        ///   Khi xoa lan luot cac chu so sau cung cua no thi so moi van la so nguyen to
        /// </summary>
        public class superPrimeNumber
        {
            private static bool isPrime(int k)
            {
                if (k < 2) return false;
                if (k == 2 || k == 3) return true;
                for (int i = 2; i <= Math.Sqrt(k); i++)
                {
                    if (k % i == 0) return false;
                }
                return true;
            }

            public static void Start(int n)
            {
                Queue queue = new Queue();
                for (int i = 2; (i <= n && i < 10); i++)
                {
                    if (isPrime(i)) queue.Enqueue(i);
                }
                while (queue.Count != 0)
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        int k = (int)queue.Peek() * 10 + i;
                        if (isPrime(k) && k <= n) queue.Enqueue((int)queue.Peek() * 10 + i);

                    }
                    Console.Write(queue.Dequeue() + " ");
                }


            }
        }
        /// <summary>
        /// Huyền có một cái điện thoại, màn hình điện thoại của Huyền chỉ hiển thị được tối đa k tin nhắn. Màn hình của Huyền hiện thị như sau:
        /// Không hiện thị 2 tin nhắn của cùng một số điện thoại (SĐT) trên cùng một khung hình, nếu SĐT a gửi tin nhắn đến mà trên màn hình đã có tin nhắn của SĐT a thì màn hình không thay đổi gì.
        /// Khi SĐT a gửi tin nhắn đến mà trên màn hình chưa có tin nhắn của SĐT a thì:
        /// Nếu màn hình chưa đủ k tin nhắn thì tin nhắn của SĐT a sẽ được chèn vào cuối màn hình. 
        /// Nếu màn hình đã có đủ k tin nhắn thì thì màn hình sẽ đẩy tin nhắn trên cùng ra và sau đó chèn tin nhắn của SĐT a vào cuối màn hình.
        /// </summary>
        public class messagesPhone
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a">Cac so dien thoai se gui tin nhan cho Huyen</param>
            /// <param name="k">So tin nhan toi da</param>
            public static void Start(int[] a, int k)
            {
                Queue queue = new Queue(k);
                for (int i = 0; i < a.Length; i++)
                {
                    if (queue.Contains(a[i])) continue;
                    else queue.Enqueue(a[i]);
                    if (queue.Count > k) queue.Dequeue();
                }

                foreach (var item in queue)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
    #endregion
    #region //LinkedList
    /// <summary>
    /// Su dung LinkedList
    /// </summary>
    public class MyLinkedList
    {
        public class linkedListExample
        {
            public static void Start(int[] arr)
            {
                LinkedList<int> linkedlist = new LinkedList<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    linkedlist.AddLast(arr[i]);
                }
                foreach (var item in linkedlist)
                {
                    Console.Write(item + " ");
                }
            }
        }
        /// <summary>
        /// Nhập vào một số nguyên dương n, tiếp theo là n số nguyên của một dãy số, hãy cài đặt nó vào một danh sách liên kết đơn. Tiếp theo nhập hai số nguyên k và x, (0 ≤ k ≤ n), hãy chèn giá trị x vào danh sách liên kết tại chỉ số k và in ra màn hình danh sách đó, sau một phần tử có một khoảng trắng.
        /// </summary>
        public class insertLinkedList
        {
            public static void Start(LinkedList<int> arr, int k, int x)
            {
                if (k == 0) arr.AddFirst(x);
                else
                {
                    LinkedListNode<int> arri = arr.First;
                    for (int i = 1; i < arr.Count; i++)
                    {
                        arri = arri.Next;
                        if (i == k - 1) { arr.AddAfter(arri, x); break; }
                    }
                }

                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
            }
        }
        /// <summary>
        /// Nhập vào một số nguyên dương n, tiếp theo là n số nguyên của một dãy số, hãy cài đặt nó vào một danh sách liên kết đơn. Tiếp theo nhập một số nguyên k (0 ≤ k < n).Hãy xóa những phần tử có giá trị lớn hơn giá trị của phần tử ở chỉ số k. In ra màn hình danh sách đó, sau một phần tử có đúng một khoảng trắng.
        /// </summary>
        public class deleteMultiValue
        {
            public static void Start(LinkedList<int> arr, int k)
            {


                LinkedListNode<int> arri = arr.First;
                LinkedListNode<int> arrk = arr.First;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (i == k)
                    { arrk = arri; break; }
                    arri = arri.Next;


                }
                arri = arr.Last;
                while (true)
                {
                    if (arri.Value > arrk.Value) { arr.Remove(arri); arri = arr.Last; }
                    else
                        arri = arri.Previous;
                    if (arri == arr.First)
                    {
                        if (arri.Value > arrk.Value) arr.RemoveFirst();
                        break;
                    }


                }
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }

            }
        }
    }
    #endregion
    #region //Tree
    public class MyBinaryTree
    {
        public enum Order
        {
            preOrder, inOrder, postOrder
        }
        public enum Place
        {
            Left, Right,
        }
        public class TreeNode
        {
            object data = new object();
            TreeNode childl;
            TreeNode childr;

            public TreeNode()
            {
            }
            public TreeNode(object Data)
            {
                data = Data;

            }
            public TreeNode(object Data, TreeNode ChildL, TreeNode ChildR)
            {
                data = Data;
                childl = ChildL;
                childr = ChildR;
            }
            public TreeNode(object Data, TreeNode Child, Place place)
            {
                data = Data;
                if (place == Place.Left) childl = Child;
                else
                    childr = Child;
            }
            public object Data
            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }
            public TreeNode ChildL
            {
                set
                {
                    childl = value;
                }
                get
                {
                    return childl;
                }
            }
            public TreeNode ChildR
            {
                set
                {
                    childr = value;
                }
                get
                {
                    return childr;
                }
            }

            // public bool isParent(TreeNode Child)
            // {
            //   if (this == Child.Parent) return true;
            //   else return false;
            // }
            public bool isChild(TreeNode Parent)
            {
                if (this == Parent.ChildL || this == Parent.ChildR) return true;
                else return false;
            }
            public bool isChildL(TreeNode Parent)
            {
                if (this == Parent.ChildL) return true;
                else return false;
            }
            public bool isChildR(TreeNode Parent)
            {
                if (this == Parent.ChildR) return true;
                else return false;
            }
            public static int depthNode(TreeNode node)
            {
                if (node == null) return 0;
                else return Math.Max(depthNode(node.ChildL), depthNode(node.ChildR)) + 1;
            }
            public int Count
            {
                get
                {
                    if (this == null) return 0;
                    else
                        return 1 + this.ChildR.Count + this.ChildL.Count;
                }

            }
            /// <summary>
            /// Remove subtree from node
            /// </summary>
            /// <param name="node"></param>
            public static void Empty(TreeNode node)
            {
                if (node == null) return;
                Empty(node.ChildL);
                Empty(node.ChildR);
                node.Data = null;
                node = null;

            }
            /// <summary>
            /// Add node with parent
            /// </summary>
            /// <param name="node">Add this</param>
            /// <param name="Parent">Parent of node</param>
            /// <param name="Place">Left or Right</param>
            public static void AddTreeNode(TreeNode node, TreeNode Parent, Place place)
            {
                if (place == Place.Left)
                {
                    Parent.ChildL = node;
                }
                else
                {
                    Parent.ChildR = node;
                }
            }
            /// <summary>
            /// Add node with Children
            /// </summary>
            /// <param name="node">Add this</param>
            /// <param name="ChildL">Left child</param>
            /// <param name="ChildR">Right child</param>
            public static void AddTreeNode(TreeNode node, TreeNode ChildL, TreeNode ChildR)
            {
                node.ChildL = ChildL;
                node.ChildR = ChildR;
            }
            public static void Traversal(TreeNode RootNode, Order order)
            {
                switch (order)
                {
                    case Order.preOrder:
                        preOrder(RootNode);
                        break;
                    case Order.inOrder:
                        inOrder(RootNode);
                        break;
                    case Order.postOrder:
                        postOrder(RootNode);
                        break;
                }
            }
            private static void inOrder(TreeNode Node)
            {
                if (Node.ChildL != null)
                {
                    inOrder(Node.ChildL);
                }
                if (Node != null)
                    Console.Write(Node.Data + " ");
                if (Node.ChildR != null)
                {
                    inOrder(Node.ChildR);
                }
            }
            private static void preOrder(TreeNode Node)
            {
                if (Node != null)
                    Console.Write(Node.Data + " ");
                if (Node.ChildL != null)
                {
                    preOrder(Node.ChildL);
                }
                if (Node.ChildR != null)
                {
                    preOrder(Node.ChildR);
                }
            }
            private static void postOrder(TreeNode Node)
            {
                if (Node.ChildL != null)
                {
                    postOrder(Node.ChildL);
                }
                if (Node.ChildR != null)
                {
                    postOrder(Node.ChildR);
                }
                if (Node != null)
                    Console.Write(Node.Data + " ");
            }

            /// <summary>
            /// Convert arr to Complete Tree
            /// </summary>
            /// <param name="arr"></param>
            /// <param name="root"></param>
            /// <param name="i"></param>
            /// <returns>RootNode </returns>
            public static TreeNode toCompleTree(int[] arr, TreeNode root, int i)
            {
                if (i < arr.Length)
                {
                    TreeNode temp = new TreeNode(arr[i]);
                    root = temp;
                    root.ChildL = toCompleTree(arr, root.ChildL, 2 * i + 1);
                    root.ChildR = toCompleTree(arr, root.ChildR, 2 * i + 2);

                }
                return root;

            }



            #endregion
        }
        public class BSTNode
        {
            public int Key { get; }
            public BSTNode ChildL { set; get; }
            public BSTNode ChildR { set; get; }
            public Object Data;
            public BSTNode(int key)
            {
                this.Key = key;
                this.ChildL = null;
                this.ChildR = null;
            }
            public BSTNode(int key, Object data)
            {
                this.Key = key;
                this.ChildL = null;
                this.ChildR = null;
                this.Data = data;
            }
            public void setData(Object data)
            {
                this.Data = data;
            }
            public BSTNode searchNode(int key)
            {
                if (this != null)
                {
                    if (key == this.Key) return this;
                    if (key < this.Key)
                    {
                        return this.ChildL.searchNode(key);
                    }
                    else
                    {
                        return this.ChildR.searchNode(key);
                    }
                }
                return null;
            }
            public void insertNode(int key)
            {
                BSTNode newNode = new BSTNode(key);
                if (key == this.Key) throw new Exception("Key existed");
                if (key < this.Key)
                {
                    if (this.ChildL == null)
                    {
                        this.ChildL = newNode;
                    }
                    else
                        this.ChildL.insertNode(key);
                }
                else
                {
                    if (this.ChildR == null)
                    {
                        this.ChildR = newNode;
                    }
                    else
                        this.ChildR.insertNode(key);
                }
            }
            public void inOrder()
            {
                if (this.ChildL != null)
                {
                    this.ChildL.inOrder();
                }
                if (this != null)
                    Console.Write(this.Key + " ");
                if (this.ChildR != null)
                {
                    this.ChildR.inOrder();
                }
            }

        }
    }
}