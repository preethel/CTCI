namespace UniqueString{
    public class Node{
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public int Value{ get; set; }

        Node getNode(Node head, int data)
        {
            if(head.Left == null && head.Right == null)
            {
                return head;
            }
            if(head.Value > data)
            {
                if (head.Left != null) return getNode(head.Left, data);
                else return head;
            }
            if(head.Value < data)
            {
                if (head.Right != null) return getNode(head.Right, data);
                else return head;
            }
            return head;
        }
        public Node Push(Node head, int data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            newNode.Left = null;
            newNode.Right = null;

            if(head == null)
            {
                return newNode;
            }
            Node tempNode = getNode(head, data);
            if (tempNode.Value > data)
            {
                tempNode.Left = newNode;
            }
            else
            {
                tempNode.Right = newNode;
            }
            return head;
        }

    }
}