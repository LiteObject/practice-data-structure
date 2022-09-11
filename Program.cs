namespace PracticeDataStructure
{
    public class Program
    {
        public static void Main()
        {
            MyLinkedList<int> myList = new();
            /*myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            myList.PrintAllNodeValues();
            Console.WriteLine("Count: " + myList.Count); */
            

            myList.Remove(2);           
            myList.PrintAllNodeValues(); 
            Console.WriteLine("Count: " + myList.Count);
        }
    }
}