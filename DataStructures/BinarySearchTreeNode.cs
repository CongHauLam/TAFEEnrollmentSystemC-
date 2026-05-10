namespace TAFEEnrollmentSystem.DataStructures
{
     public class BinarySearchTreeNode<T>
    {
        public BinarySearchTreeNode<T> LeftNode { get; set; }
        public BinarySearchTreeNode<T> RightNode { get; set; }
        public T Data { get; set; }
        public BinarySearchTreeNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}