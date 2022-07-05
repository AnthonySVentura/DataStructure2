Console.WriteLine("What word would you like to reverse?");
string word = Console.ReadLine();
   

static string Reverse(string word)
{
    Stack<string> stack = new Stack<string>();

    stack.Push(word);

    return stack.Pop();

}