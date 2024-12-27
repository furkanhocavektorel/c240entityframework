namespace Collectionss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            HashSet<int> set = new HashSet<int>();

            LinkedList<int> linkedList = new LinkedList<int>();

            // First in First out -> FIFO
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(350);
            queue.Enqueue(100);

            queue.Dequeue();

            // Last in First out -> LIFO
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(350);
            stack.Push(100);

            stack.Pop();

            

            Dictionary<string, List<string> > testDictionary = new Dictionary<int, string>();

            List<string> a= new List<string>();
            a.Add("ali");
            a.Add("veli");
            a.Add("deli");

            testDictionary.Add("adlar", a);
          

            SortedList<int, string> sortedList = new SortedList<int, string>();

        }

    }
}
