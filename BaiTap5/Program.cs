using System;

namespace LinkedList
{
    class Program
    {
        public class Node
        {
            internal int Data;
            internal Node Next;

            public Node(int d)
            {
                Data = d;
                Next = null;
            }
        }

        public class LinkedList
        {
            private Node _first;
            private Node _last;
            private int _size;

            public int Count
            {
                get { return _size; }
            }

            public Node FirstNode
            {
                get { return _first; }
            }

            public Node LastNode
            {
                get { return _last; }
            }

            public LinkedList()
            {
                _first = null;
                _last = null;
                _size = 0;
            }

            public void AddFirst(int newData)
            {
                Node newNode = new Node(newData);
                if (_first == null)
                {
                    _first = newNode;
                    _last = newNode;
                }
                else
                {
                    newNode.Next = _first;
                    _first = newNode;
                }
                _size++;
            }

            public void AddLast(int newData)
            {
                Node newNode = new Node(newData);
                if (_first == null)
                {
                    _first = newNode;
                    _last = newNode;
                }
                else
                {
                    _last.Next = newNode;
                    _last = newNode;
                }
            }

            public void AddAfter(Node pre, int newData)
            {
                if (pre != null)
                {
                    Node newNode = new Node(newData);
                    newNode.Next = pre.Next;
                    pre.Next = newNode;
                    if (pre == _last)
                        _last = newNode;
                    _size++;
                }
            }

            public void RemoveFirst()
            {
                Node p = _first;
                if (p != null)
                {
                    _first = p.Next;
                    if (_first == null)
                        _last = null;
                    _size--;
                }
            }

            public void RemoveLast()
            {
                if (_first == _last)
                {
                    _first = null;
                    _last = null;
                    _size = 0;
                }
                else
                {
                    Node pre = _first;
                    while (pre.Next != _last)
                    {
                        pre = pre.Next;
                    }

                    pre.Next = null;
                    _last = pre;
                    _size--;
                }
            }

            public void RemoveAfter(Node pre)
            {
                Node del;
                if (pre != null)
                {
                    del = pre.Next;
                    if (del != null)
                    {
                        pre.Next = del.Next;
                        if (pre.Next == null)
                            _last = pre;
                        _size--;
                    }
                }
            }
        }

        static void RanDomValue(LinkedList l, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Random rd = new Random();
                int val = rd.Next(1, 10);
                l.AddFirst(val);
            }
        }

        static void PrintNode(LinkedList l)
        {
            Node temp = l.FirstNode;
            while (temp != null)
            {
                Console.Write("{0} ", temp.Data);
                temp = temp.Next;
            }
        }

 //a.	Tạo danh sách L3 bằng cách nối L2 vào sau L1.
        static LinkedList ConcatTwoList(LinkedList l1, LinkedList l2)
        {
            LinkedList result = new LinkedList();
            Node nodeL1 = l1.FirstNode;
            Node nodeL2 = l2.FirstNode;
            while (nodeL1 != null)
            {
                result.AddLast(nodeL1.Data);
                nodeL1 = nodeL1.Next;
            }

            while (nodeL2 != null)
            {
                result.AddLast(nodeL2.Data);
                nodeL2 = nodeL2.Next;
            }

            return result;
        }

//b.	Tạo danh sách L3 bao gồm các phần tử chỉ có trong L1 mà không có trong L2 (L3 là hiệu của L1 và L2).
        static LinkedList InL1(LinkedList l1, LinkedList l2)
        {
            LinkedList result = new LinkedList();
            Node nodeL1 = l1.FirstNode;
            Node nodeL2 = l2.FirstNode;
            bool flag = false;
            while (nodeL1 != null)
            {
                while (nodeL2 != null)
                {
                    if (nodeL1.Data == nodeL2.Data)
                    {
                        break;
                    }
                    else
                    {
                        flag = true;
                        break;
                    }
                    nodeL2 = nodeL2.Next;
                }

                if (flag)
                {
                    result.AddFirst(nodeL1.Data);
                }
                nodeL1 = nodeL1.Next;
            }
            return result;
        }

//c.	Tạo danh sách L3 bao gồm các phần tử vừa có trong L1 vừa có trong L2 (L3 là giao của L1 và L2).
        static LinkedList InL1AndL2(LinkedList l1, LinkedList l2)
        {
            LinkedList result = new LinkedList();
            Node nodeL1 = l1.FirstNode;
            Node nodeL2 = l2.FirstNode;
            while (nodeL1 != null)
            {
                while (nodeL2 != null)
                {
                    if (nodeL1.Data == nodeL2.Data)
                    {
                        result.AddFirst(nodeL1.Data);
                    }
                    nodeL2 = nodeL2.Next;
                }
                nodeL1 = nodeL1.Next;
            }
            return result;
        } 
        
//d.	Tạo danh sách L3 bao gồm các phần tử hoặc có trong L1 hoặc có trong L2 (L3 là hợp của L1 và L2).
        static LinkedList InL1OrL2(LinkedList l1, LinkedList l2)
        {
            LinkedList result = new LinkedList();
            Node nodeL1 = l1.FirstNode;
            Node nodeL2 = l2.FirstNode;
            while (nodeL1 != null)
            {
                result.AddFirst(nodeL1.Data);
                nodeL1 = nodeL1.Next;
            }

            while (nodeL2 != null)
            {
                result.AddFirst(nodeL2.Data);
                nodeL2 = nodeL2.Next;
            }

            return result;
        }
        
// e.	Tạo danh sách tổng L3 sao cho:
// -	Có độ dài là độ dài lớn nhất của L1 và L2.
// -	Có giá trị phần tử là tổng giá trị các phần tử tương ứng của L1 và L2 (các phần tử bị thiếu trong danh sách ngắn hơn xem như có giá trị 0).
        static LinkedList TotalL3(LinkedList l1, LinkedList l2)
        {
            LinkedList result = new LinkedList();
            int sizeL3 = 0;
            sizeL3 = l1.Count > l2.Count ? l1.Count : l2.Count;
            Node nodeL1 = l1.FirstNode;
            Node nodel2 = l2.FirstNode;
            while (sizeL3 > 0)
            {
                int nodeL1Data = nodeL1 != null ? nodeL1.Data : 0;
                int nodeL2Data = nodel2 != null ? nodel2.Data : 0;
                int totalData = nodeL1Data + nodeL2Data;

                result.AddFirst(totalData);

                nodeL1 = nodeL1 != null ? nodeL1.Next : null;
                nodel2 = nodel2 != null ? nodel2.Next : null;
                sizeL3--;
            }

            return result;
        }

// f.	Kiểm tra 2 danh sách L1 và L2 có trùng giá trị hay không ?
        static void CheckExistData(LinkedList l1, LinkedList l2)
        {
            LinkedList result = new LinkedList();
            Node nodeL1 = l1.FirstNode;
            Node nodeL2 = l2.FirstNode;
            bool flag = false;
            while (nodeL1 != null)
            {
                while (nodeL2 != null)
                {
                    if (nodeL1.Data == nodeL2.Data)
                    {
                        flag = true;
                        return;
                    }
                    nodeL2 = nodeL2.Next;
                }
                nodeL1 = nodeL1.Next;
            }

            if (flag)
            {
                Console.WriteLine("Co gia tri trung trong L1 và L2");
            }
            else
            {
                Console.WriteLine("Khong co gia tro trung L1 và L2");
            }
        }
        
//g.	Xóa một phần tử đầu tiên được tìm thấy trong L1 thõa mãn điều kiện: Giá trị của nó lớn hơn tổng giá trị phần tử của L2.
        static void RemoveFirstOneFind(LinkedList l1, LinkedList l2)
        {
            Node nodeL1 = l1.FirstNode;
            Node prev;
            Node nodeL2 = l2.FirstNode;
            int totalL2 = 0;

            while (nodeL2 != null)
            {
                totalL2 += nodeL2.Data;
                nodeL2 = nodeL2.Next;
            }
            while (nodeL1 != null)
            {
                if (l1.FirstNode.Data > totalL2)
                {
                    l1.RemoveFirst();
                    return;
                }
                if (l1.LastNode.Data > totalL2)
                {
                    l1.RemoveLast();
                    return;
                }
                prev = nodeL1;
                if (prev.Next != null)
                {
                    if (nodeL1.Next.Data > totalL2)
                    {
                        l1.RemoveAfter(prev);
                        return;
                    }
                }
                nodeL1 = nodeL1.Next;
            }
        }
        
//h.	Xóa tất cả các phần tử trong L1 có giá trị bằng giá trị lớn nhất trong L2.
        static void RemoveAllFind(LinkedList l1, LinkedList l2)
        {
            Node nodeL1 = l1.FirstNode;
            Node prev;
            Node nodeL2 = l2.FirstNode;
            int maxL2 = l1.FirstNode.Next.Data;

            while (nodeL2 != null)
            {
                if (maxL2 < nodeL2.Data)
                {
                    maxL2 = nodeL2.Data;
                }
                nodeL2 = nodeL2.Next;
            }
            
            Console.Write(":{0} ", maxL2);
            Console.WriteLine("\n");
            while (nodeL1 != null)
            {
                if (l1.FirstNode.Data == maxL2)
                {
                    l1.RemoveFirst();
                }
                if (l1.LastNode.Data == maxL2)
                {
                    l1.RemoveLast();
                }
                prev = nodeL1;
                if (prev.Next != null)
                {
                    if (nodeL1.Next.Data == maxL2)
                    {
                        l1.RemoveAfter(prev);
                    }
                }
                nodeL1 = nodeL1.Next;
            }
        }

        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            LinkedList l2 = new LinkedList();
            RanDomValue(l1, 10);
            RanDomValue(l2, 10);
            Console.Write("L1:");
            PrintNode(l1);
            Console.WriteLine("\n");
            Console.Write("L2:");
            PrintNode(l2);
            Console.WriteLine("\n");
            
            Console.Write("1. (a) Nối danh sách L1 & L2:");
            PrintNode(ConcatTwoList(l1, l2));
            Console.WriteLine("\n");
            
            Console.Write("2. (b) Danh sách các phần tử chỉ có trong L1 mà không có trong L2: ");
            PrintNode(InL1(l1, l2));
            Console.WriteLine("\n");
            
            Console.Write("3. (c) Danh sách các phần tử vừa có trong L1 vừa có trong L2: ");
            PrintNode(InL1AndL2(l1, l2));
            Console.WriteLine("\n");
            
            Console.Write("4. (d) Danh sách các phần tử hoặc có trong L1 hoặc có trong L2:");
            PrintNode(InL1OrL2(l1, l2));
            Console.WriteLine("\n");
            
            Console.Write("5. (e) Danh sách tổng các phần tử của 2 mảng: ");
            PrintNode(TotalL3(l1, l2));
            Console.WriteLine("\n");
            
            Console.Write("6. (f) Kiểm tra 2 danh sách L1 và L2 có trùng giá trị hay không?: ");
            CheckExistData(l1, l2);
            Console.WriteLine("\n");
            
            Console.Write("7. (g) Xóa một phần tử đầu tiên được tìm thấy trong L1 thõa mãn điều kiện: Giá trị của nó lớn hơn tổng giá trị phần tử của L2: ");
            RemoveFirstOneFind(l1, l2);
            PrintNode(l1);
            Console.WriteLine("\n");
            
            Console.Write("8. (h). Xóa tất cả các phần tử trong L1 có giá trị bằng giá trị lớn nhất trong L2: ");
            RemoveAllFind(l1, l2);
            //PrintNode(l1);
            //Console.WriteLine("\n");
            //Console.ReadLine();
        }
    }
}