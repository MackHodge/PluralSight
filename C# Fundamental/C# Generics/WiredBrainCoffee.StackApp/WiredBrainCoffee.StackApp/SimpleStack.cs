using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private readonly object[] _items;
        private int currentIndex = -1;

        public SimpleStack() =>  _items = new object[10];

        public int Count => currentIndex + 1;

        public void Push(object item) => _items[++currentIndex] = item;

        public object Pop() => _items[currentIndex--];
        
    }
}