namespace PracticeDataStructure
{
    public class MyLinkedList<T>
    {
        private Node<T>? firstNode;
        public int Count { get; private set; }

        public void Add(T value)
        {
            Node<T> newNode = new();
            newNode.Value = value;

            if (firstNode == null)
            {
                firstNode = newNode;
            }
            else
            {
                var currentNode = firstNode;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }

            Count += 1;
        }

        public void Remove(T value)
        {
            var currentNode = firstNode;
            Node<T>? previousNode = null;

            while (currentNode != null)
            {
                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    Console.WriteLine($"Removing  \"{value}\" now...");

                    if (previousNode != null)
                    {
                        previousNode.Next = currentNode.Next;
                    }

                    currentNode = null;
                    Count -= 1;
                    break;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void PrintAllNodeValues()
        {
            if (firstNode != null)
            {
                Node<T>? currentNode = firstNode;

                while (currentNode != null)
                {
                    Console.WriteLine($"Value is {currentNode.Value}");
                    currentNode = currentNode.Next;
                };
            }
            else
            {
                Console.WriteLine("The linked-list is empty.");
            }
        }
    }
}