using System.Collections;
namespace StackStuff
{
    public class StackList
    {
        public Stack myStack = new Stack();        
        public void PushNumber(int number)
        {           
            myStack.Push(number);              
        }
        public void PushXNumbers(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)           
                myStack.Push(list[i]);           
        }
        public void ClearTheStack()
        {
            myStack.Clear();
        }
        public string ContainsCertainNumber(int no1)
        {
            if (!myStack.Contains(no1))
                return "Does not contain number";
            else           
                return no1.ToString();           
        }
        
    }
}