using System;
using TAFEEnrollmentSystem.Model;
using TAFEEnrollmentSystem.Utility;
using TAFEEnrollmentSystem.DataStructures;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TESTING ADDRESS CLASS");
        // Test no-arg constructor
        Address addr1 = new Address();
        Console.WriteLine("\nAddress no-arg constructor:");
        Console.WriteLine(addr1.ToString());
        // Test all-arg constructor
        Address addr2 = new Address("160", "Rundle Mall", "Adelaide", "5000", "SA");
        Console.WriteLine("\nAddress all-arg constructor:");
        Console.WriteLine(addr2.ToString());


        Console.WriteLine("\nTESTING PERSON CLASS");
        // Test no-arg constructor
        Person p1 = new Person();
        Console.WriteLine("\nPerson no-arg constructor:");
        Console.WriteLine(p1.ToString());
        // Test all-arg constructor
        Person p2 = new Person("Cong Hau Lam", "conghau@email.com", "0406026464", addr2);
        Console.WriteLine("\nPerson all-arg constructor:");
        Console.WriteLine(p2.ToString());



        Console.WriteLine("\nTESTING SUBJECT CLASS");
        // Test no-arg constructor
        Subject sub1 = new Subject();
        Console.WriteLine("\nSubject no-arg constructor:");
        Console.WriteLine(sub1.ToString());
        // Test all-arg constructor
        Subject sub2 = new Subject("ICTPRG547", "Apply advanced programming skills in another language", 400);
        Console.WriteLine("\nSubject all-arg constructor:");
        Console.WriteLine(sub2.ToString());



        Console.WriteLine("\nTESTING ENROLLMENT CLASS");
        // Test no-arg constructor
        Enrollment e1 = new Enrollment();
        Console.WriteLine("\nEnrollment no-arg constructor:");
        Console.WriteLine(e1.ToString());
        // Test all-arg constructor
        Enrollment e2 = new Enrollment(DateTime.Now, "Pass", "Semester 1", sub2);
        Console.WriteLine("\nEnrollment all-arg constructor:");
        Console.WriteLine(e2.ToString());


        Console.WriteLine("\nTESTING STUDENT CLASS");
        // Test no-arg constructor
        Student s1 = new Student();
        Console.WriteLine("\nStudent no-arg constructor:");
        Console.WriteLine(s1.ToString());
        // Test studentID-only constructor
        Student s2 = new Student("S0111");
        Console.WriteLine("\nStudent constructor with studentID only:");
        Console.WriteLine("\nStudent ID: " + s2.StudentID);
        // Test all-arg constructor
        Student s3 = new Student("S0222","IT",DateTime.Now,"Cong Hau Lam", "conghau@email.com", "0406026464", addr2, e2);
        Console.WriteLine("\nStudent all-arg constructor:");
        Console.WriteLine(s3.ToString());



        // Testing equality and operators
        Console.WriteLine("\nTesting Student equality:");

        Student sA = new Student("S0111");
        Student sB = new Student("S0222");
        Student sC = new Student("S0222");

        Console.WriteLine("\nStudent 1: " + sA.StudentID);

        Console.WriteLine("\nStudent 2: " + sB.StudentID);

        Console.WriteLine("\nStudent 3: " + sC.StudentID);

        Console.WriteLine("\nEquals test:");
        Console.WriteLine(sA.Equals(sB));

        Console.WriteLine("\nOperator == test:");
        Console.WriteLine(sA == sB);

        Console.WriteLine("\nOperator != test:");
        Console.WriteLine(sA != sC);

        // Testing hashing
        Console.WriteLine("\nHashCode:");
        Console.WriteLine("Student 1 hash: " + sA.GetHashCode());
        Console.WriteLine("Student 2 hash: " + sB.GetHashCode());
        Console.WriteLine("Student 3 hash: " + sC.GetHashCode());

        //  SORTING TEST

        Student[] unsorted = new Student[]
        {
            new Student("S0333"),
            new Student("S0111"),
            new Student("S1000"),
            new Student("S0777"),
            new Student("S0555"),
            new Student("S0222"),
            new Student("S0999"),
            new Student("S0444"),
            new Student("S0666"),
            new Student("S0888")
        };
        //  LINEAR SEARCH TEST

        Console.WriteLine("\n\nLINEAR SEARCH TEST ");

        Console.WriteLine("Search S0555, expected index 4, found at index: " +

            SearchUtility.LinearSearchArray(unsorted, new Student("S0555")));

        Console.WriteLine("Search S1111, not found: " +
            SearchUtility.LinearSearchArray(unsorted, new Student("S1111")));


        Console.WriteLine("\nSORTING TEST ");

        Console.WriteLine("\nUnsorted array:");
        foreach (var s in unsorted)
        {
            Console.Write(s.StudentID + " ");
        }

        // SORT ASCENDING
        SearchUtility.BubbleSortAscending(unsorted);

        Console.WriteLine("\n\nSorted array (Ascending):");
        foreach (var s in unsorted)
        {
            Console.Write(s.StudentID + " ");
        }

        //  BINARY SEARCH TEST
           
        Console.WriteLine("\n\nBINARY SEARCH TEST ");

        Console.WriteLine("Search S0444, found at index: " +
            SearchUtility.BinarySearchArray(unsorted, new Student("S0444")));

        Console.WriteLine("Search S1111, not found: " +
            SearchUtility.BinarySearchArray(unsorted, new Student("S1111")));


        //  DESCENDING SORT TEST

        SearchUtility.BubbleSortDescending(unsorted);

        Console.WriteLine("\nSorted array (Descending):");
        foreach (var s in unsorted)
        {
            Console.Write(s.StudentID + " ");
        }

        //SINGLE LINKED LIST TESTING
        Console.WriteLine("\nSINGLE LINKED LIST TESTING");
       
        SinglyLinkedList<Student> singleList = new SinglyLinkedList<Student>
        {
            new Student("S003"),
            new Student("S002"),
            new Student("S001"),
        };
        Console.WriteLine("\nInitial List:");
        foreach (Student student in singleList)
        {
            Console.WriteLine(student.StudentID);
        }
        

        // Test AddFirst
        singleList.AddFirst(new Student("S000"));
        Console.WriteLine("\nAfter AddFirst(S000):");
        foreach (Student student in singleList)
        {
            Console.WriteLine(student.StudentID);
        }
        


        // Test AddLast
        singleList.AddLast(new Student("S004"));
        Console.WriteLine("\nAfter AddLast(S004):");
        foreach (Student student in singleList)
        {
            Console.WriteLine(student.StudentID);
        }
        


        // Test Contains
        Student foundSingle = new Student("S002");
        Console.WriteLine("\nContains S002:" + singleList.Contains(foundSingle));
    


        // Test RemoveFirst
        singleList.RemoveFirst();
        Console.WriteLine("\nAfter RemoveFirst:");
        foreach (Student student in singleList)
        {
            Console.WriteLine(student.StudentID);
        }
       


        // Test RemoveLast
        singleList.RemoveLast();
        Console.WriteLine("\nAfter RemoveLast:");
        foreach (Student student in singleList)
        {
            Console.WriteLine(student.StudentID);
        }
        


        // Remove(item)
        singleList.Remove(new Student("S001"));

        Console.WriteLine("\nAfter Remove(S001):");

        foreach (Student student in singleList)
        {
            Console.WriteLine(student.StudentID);
        }


        // Test Count
        Console.WriteLine("\nCount:");
        Console.WriteLine(singleList.Count);


        // DOUBLY LINKED LIST TESTING
        Console.WriteLine("\nDOUBLY LINKED LIST TESTING");

        DoublyLinkedList<Student> doublyList = new DoublyLinkedList<Student>
        {
            new Student("S001"),
            new Student("S002"),
            new Student("S003"),
        };
        Console.WriteLine("\nInitial Doubly List:");
        foreach (Student student in doublyList)
        {
            Console.WriteLine(student.StudentID);
        }



        // Test AddFirst
        doublyList.AddFirst(new Student("S000"));
        Console.WriteLine("\nAfter AddFirst(S000):");
        foreach (Student student in doublyList)
        {
            Console.WriteLine(student.StudentID);
        }
        


        // AddLast
        doublyList.AddLast(new Student("S004"));
        Console.WriteLine("\nAfter AddLast(S004):");
        foreach (Student student in doublyList)
        {
            Console.WriteLine(student.StudentID);
        }



        // Test Contains
        Student foundDouble = new Student("S003");
        Console.WriteLine("\nContains S003:" + doublyList.Contains(foundDouble));


        // Test RemoveFirst
        doublyList.RemoveFirst();
        Console.WriteLine("\nAfter RemoveFirst:");
        foreach (Student student in doublyList)
        {
            Console.WriteLine(student.StudentID);
        }



        // Test RemoveLast
        doublyList.RemoveLast();
        Console.WriteLine("\nAfter RemoveLast:");
        foreach (Student student in doublyList)
        {
            Console.WriteLine(student.StudentID);
        }



        // Test Remove(item)
        doublyList.Remove(new Student("S001"));
        Console.WriteLine("\nAfter Remove(S001):");
        foreach (Student student in doublyList)
        {
            Console.WriteLine(student.StudentID);
        }



        // Test Count
        Console.WriteLine("\nCount:");
        Console.WriteLine(doublyList.Count);

    
        // BINARY SEARCH TREE TESTING
        Console.WriteLine("BINARY SEARCH TREE TESTING");

        BinarySearchTree<string> binaryTree = new BinarySearchTree<string>();

        binaryTree.Add("S004");
        binaryTree.Add("S002");
        binaryTree.Add("S006");
        binaryTree.Add("S001");
        binaryTree.Add("S003");
        binaryTree.Add("S005");
        binaryTree.Add("S007");

        // Test Find
        BinarySearchTreeNode<string> foundNode = binaryTree.Find("S005");
        Console.WriteLine("\nFind S005:");

        if (foundNode != null)
        {
            Console.WriteLine(foundNode.Data);
        }
        else
        {
            Console.WriteLine("Not found");
        }


        // Test PreOrder
        Console.WriteLine("\nPreOrder Traversal:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine();


        // Test InOrder
        Console.WriteLine("\nInOrder Traversal:");
        binaryTree.TraverseInOrder(binaryTree.Root);
        Console.WriteLine();


        // Test PostOrder
        Console.WriteLine("\nPostOrder Traversal:");
        binaryTree.TraversePostOrder(binaryTree.Root);
        Console.WriteLine();


        // Test Tree Depth
        Console.WriteLine("\nTree Depth:");
        Console.WriteLine(binaryTree.GetTreeDepth());


        // Remove
        binaryTree.Remove("S007");
        binaryTree.Remove("S005");
        Console.WriteLine("\nPreOrder After Removing S007 and S005:");
        binaryTree.TraversePreOrder(binaryTree.Root);

        
        
        Console.ReadKey();
    }
}