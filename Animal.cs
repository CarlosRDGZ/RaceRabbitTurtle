using System;

namespace Race
{
    public abstract class Animal
    {
        protected int _steps = 0;
        public int Steps => _steps;

        protected static Random random = new Random(DateTime.Now.Millisecond);

        public abstract void MakeStep();
    }
}