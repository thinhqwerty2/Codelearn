using System.Collections.Generic;
using System.Collections;
using System;
using System.Text;
namespace Data_Structure
{
  #region  //Stack and Queue
  public class myStack
  {
    /// <summary>
    /// Chuyen so nguyen ve Bit
    /// </summary>
    public class BitConverter
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

  public class myQueue
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
  public class myLinkedList
  {
    public class LinkedListExample
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
    public class InsertLinkedList
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
    public class DeleteMultiValue
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
  public class myBinaryTree
  {
    public class TreeNode
    {
      object data = new object();
      TreeNode parent = new TreeNode();
      TreeNode[] children = new TreeNode[2];
      public TreeNode()
      {
      }
      public TreeNode(object Data)
      {
        data = Data;
      }
      public TreeNode(object Data, TreeNode NodeL, TreeNode NodeR)
      {
        data = Data;
        children[0] = NodeL;
        children[1] = NodeR;
      }
      public TreeNode(object Data, TreeNode Node)
      {
        data = Data;
        children[0] = Node;
        children[1] = null;
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
      public TreeNode TreeNodeL
      {
        set
        {
          children[0] = value;
        }
        get
        {
          return children[0];
        }
      }
      public TreeNode TreeNodeR
      {
        set
        {
          children[1] = value;
        }
        get
        {
          return children[1];
        }
      }





    }
    public class Tree
    {
      List<TreeNode> TreeNodes = new List<TreeNode>();
      public void AddTreeNode(TreeNode treeNode)
      {
        TreeNodes.Add(treeNode);
      }
      public void inOrderTraversal()
      {

      }
    }


    #endregion
  }
}