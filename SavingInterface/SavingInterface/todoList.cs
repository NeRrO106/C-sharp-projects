using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            if (nextOpenIndex < 5)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
            else
            {
                Console.WriteLine("You have more than 5 task`s");
            }

        }
        void HeaderSymbol()
        {
            Console.WriteLine("Task`s");
            Console.WriteLine("--------");
        }
        public void Display()
        {
            HeaderSymbol();
            foreach (string todo in Todos)
            {
                if (!String.IsNullOrEmpty(todo)) Console.WriteLine(todo);
                else Console.WriteLine("[]");
            }
        }
        public void Reset()
        {
            nextOpenIndex = 0;
            Todos = new string[5];
        }
    }
}