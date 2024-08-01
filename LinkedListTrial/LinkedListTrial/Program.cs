namespace LinkedListTrial
{
    internal class Program
    {
        static Node head; // head of list  

        public class Node
        {
            public int data;
            public Node next;

            public Node(int value)
            {
                data = value;
                next = null;
            }
        }

        static int sizeOfList() 
        {
            Node pointer = head;
            int size = 0;
            while (pointer != null)
            {
                size++;
                pointer = pointer.next;
            }

            return size;
        }

        static void insertAt(int value, int index)
        {
            if (head == null)
            {
                head = new Node(value);
            }
            else if (index == 0) //insert at head
            {
                Node newNode = new Node(value);
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node newNode = new Node(value);

                int size = sizeOfList();
                if (index > size)
                {
                    Console.WriteLine("Index out of range hehe");
                    return;
                }

                Node pointer = head;
                for (int i = 0; i < index - 1; i++) //get to the index in list
                { 
                    pointer = pointer.next;
                }
                newNode.next = pointer.next;
                pointer.next = newNode;
            }
        }

        static void deleteAt(int index)
        {
            if (head == null)
            {
                Console.WriteLine("Empty list");
            }
            else if (index == 0) //delete head if only 1 node
            {
                head = null;
            }
            else
            {
                int size = sizeOfList();
                if (index > size)
                {
                    Console.WriteLine("Index out of range hehe");
                    return;
                }

                Node pointer = head;
                for (int i = 0; i < index - 1; i++) //get to the index in list
                {
                    pointer = pointer.next;
                }
                pointer.next = pointer.next.next;
            }
        }

        static void printList()
        {
            Node pointer = head;
            while (pointer != null)
            {
                Console.Write(pointer.data + " ");
                pointer = pointer.next;
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(4);
            head.next.next.next = new Node(5);
            Console.WriteLine("Linked list init: ");
            printList();

            int val = 3;
            int index = 2;
            //Insert
            insertAt(val, index);
            Console.WriteLine($"Linked list appended value {val} at index {index}: ");
            printList();

            //Delete
            index = 4;
            deleteAt(index);
            Console.WriteLine($"Linked list delete value at index {index}: ");
            printList();
        }
    }
}
