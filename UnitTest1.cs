using StackStuff;
namespace StackApp
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushNumberToTopOfStack()
        {
            StackList stackList = new StackList();
            stackList.PushNumber(10);
            Assert.Equal(10, Convert.ToInt32(stackList.myStack.Peek()));
        }
        [Theory]
        [InlineData(10,5)]
        [InlineData(25,4)]
        public void CanPushManyNumbers(int in1, int in2)
           
        {          
            StackList stackList = new StackList();
            stackList.PushXNumbers(in1, in2);
            Assert.Equal(in2, Convert.ToInt32(stackList.myStack.Pop()));
            Assert.Equal(in1, Convert.ToInt32(stackList.myStack.Pop()));         
        }

        [Fact]
        public void CanClearTheStack()
        {
        StackList stackList = new StackList();
        stackList.PushXNumbers(3,4,5,4,3,4);   
        stackList.ClearTheStack(); 
        Assert.Empty(stackList.myStack);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(103)]
        public void CanSearchForNumbers(int in1)
        {
            StackList stackList = new StackList();
            stackList.PushXNumbers(1,2,3,4,5,6,7);
            Assert.Equal("Does not contain number", stackList.ContainsCertainNumber(in1));
        }
    }
}