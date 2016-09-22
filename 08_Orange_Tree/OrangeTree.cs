using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        
        public int Age;
        public int Height;
        public bool TreeAlive;
        public int NumOranges;
        public int OrangesEaten;

        public OrangeTree(int v1, int v2)
        {
            this.Age = v1;
            this.Height = v2;
        }
        public OrangeTree()
        {

        }

        internal void OneYearPasses()
        {
            this.Age += 1;
            this.Height += 2;
            if(this.Age > 79)
            {
                this.TreeAlive = false;
            }
            if(this.Age >= 2)
            {
                NumOranges += 5;
            }
        }

        internal void EatOrange(int v)
        {
            this.OrangesEaten += v;
            if(this.NumOranges < 1)
            {
                throw new IndexOutOfRangeException ("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
            
        }
    }
}