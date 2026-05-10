using System;

namespace TAFEEnrollmentSystem.DataStructures
{
    public class BinarySearchTree<T>
        where T : IComparable<T>
    {
        public BinarySearchTreeNode<T> Root 
        { 
            get; 
            set; 
        }

        public bool Add(T value)
        {
            BinarySearchTreeNode<T> before = null;

            BinarySearchTreeNode<T> after = this.Root;

            while (after != null)
            {
                before = after;

                if (value.CompareTo(after.Data) < 0)
                {
                    after = after.LeftNode;
                }
                else if (value.CompareTo(after.Data) > 0)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }

            BinarySearchTreeNode<T> newNode = new BinarySearchTreeNode<T>(value);

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value.CompareTo(before.Data) < 0)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }

            return true;
        }

        public BinarySearchTreeNode<T> Find(T value)
        {
            return this.Find(value, this.Root);
        }

        private BinarySearchTreeNode<T> Find(T value, BinarySearchTreeNode<T> parent)
        {
            if (parent != null)
            {
                if (value.CompareTo(parent.Data) == 0)
                {
                    return parent;
                }

                if (value.CompareTo(parent.Data) < 0)
                {
                    return Find(value, parent.LeftNode);
                }
                else
                {
                    return Find(value, parent.RightNode);
                }
            }

            return null;
        }

        public void Remove(T value)
        {
            this.Root = Remove(this.Root, value);
        }

        private BinarySearchTreeNode<T> Remove(BinarySearchTreeNode<T> parent, T key)
        {
            if (parent == null)
            {
                return parent;
            }

            if (key.CompareTo(parent.Data) < 0)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key.CompareTo(parent.Data) > 0)
            {
                parent.RightNode = Remove(parent.RightNode, key);
            }
            else
            {
                if (parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null)
                {
                    return parent.LeftNode;
                }

                parent.Data = MinValue(parent.RightNode);

                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private T MinValue(BinarySearchTreeNode<T> node)
        {
            T minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;

                node = node.LeftNode;
            }

            return minv;
        }

        public int GetTreeDepth()
        {
            return GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(BinarySearchTreeNode<T> current)
        {
            return current == null ? 0
                : Math.Max(
                    GetTreeDepth(current.LeftNode),
                    GetTreeDepth(current.RightNode)
                ) + 1;
        }

        public void TraversePreOrder(BinarySearchTreeNode<T> parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(BinarySearchTreeNode<T> parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(BinarySearchTreeNode<T> parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }

        public string GetPreOrder()
        {
            string result = "";

            GetPreOrder(Root, ref result);

            return result.Trim();
        }

        private void GetPreOrder(
            BinarySearchTreeNode<T> parent,
            ref string result)
        {
            if (parent != null)
            {
                result += parent.Data + " ";

                GetPreOrder(parent.LeftNode, ref result);

                GetPreOrder(parent.RightNode, ref result);
            }
        }

        public string GetInOrder()
        {
            string result = "";

            GetInOrder(Root, ref result);

            return result.Trim();
        }

        private void GetInOrder(
            BinarySearchTreeNode<T> parent,
            ref string result)
        {
            if (parent != null)
            {
                GetInOrder(parent.LeftNode, ref result);

                result += parent.Data + " ";

                GetInOrder(parent.RightNode, ref result);
            }
        }

        public string GetPostOrder()
        {
            string result = "";

            GetPostOrder(Root, ref result);

            return result.Trim();
        }

        private void GetPostOrder(
            BinarySearchTreeNode<T> parent,
            ref string result)
        {
            if (parent != null)
            {
                GetPostOrder(parent.LeftNode, ref result);

                GetPostOrder(parent.RightNode, ref result);

                result += parent.Data + " ";
            }
        }

    }
}