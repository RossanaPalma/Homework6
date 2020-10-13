using System;

namespace Project1
{
    public class Counter
    {
        private int count;

        public Counter(int count)
        {
            this.count = count;
        }

        public void setCount(int count)
        {
            this.count = 0;
        }
        public void incCount(int count)
        {
            this.count += 1;
        }
        public void decCount(int count)
        {
            if (count > 0)
            {
                this.count -= 1;
            }
        }
        public int getCount(int count)
        {
            return count;
        }
        public void displayCount(int count)
        {
            Console.WriteLine("Count value: " + count);
        }
        public int toString()
        {
            return ("Count values are " + setCount + incCount + decCount);
        }
        public bool equals(Counter other)
        {
            return (this.int.Equals(other, int));
        }
        class Program
        {
            static void Main(string[] args)
            {
                Counter balance = new Counter();

                Console.WriteLine(balance.ToString());
                Console.WriteLine(" Total Value is:" + balance.equals);
            }
        }
    }
}