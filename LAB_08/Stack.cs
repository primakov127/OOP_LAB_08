using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB_08
{
    [Serializable]
    class Stack<T> : IManage<T> where T : Person
    {

        private T[] items;  // элементы стека
        private int count;  // количество элементов
        private int length;
        const int n = 10;   // количество элементов в массиве по умолчанию
        public Stack() : this(n)
        {

        }
        public Stack(int length)
        {
            this.length = length;
            items = new T[length];
        }
        
        // пуст ли стек
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        // размер стека
        public int Count
        {
            get { return count; }
        }
        public int Length
        {
            get { return length; }
        }
        // добвление элемента
        public void Push(T item)
        {
            // если стек заполнен, выбрасываем исключение
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count++] = item;
        }
        // извлечение элемента
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку
            return item;
        }
        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Невозможно обратиться к элементу(.Peek). Стэк пуст!");
            return items[count - 1];
        }

        public Stack<T> Clone()
        {
            Stack<T> st = new Stack<T>(this.length);

            for (int i = 0; i < this.count; i++)
                st.Push(this.items[i]);

            return st;
        }

        public void Add(T item)
        {
            this.Push(item);
        }

        public T Remove()
        {
            return this.Pop();
        }

        public void Look()
        {
            Console.WriteLine(this.Peek());
        }

        public void Save(string CurrentFile)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(CurrentFile, FileMode.OpenOrCreate))
            {

                bf.Serialize(fs, items);

            }

        }

        public void Upload(string CurrentFile)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(CurrentFile, FileMode.OpenOrCreate))
            {
                T[] deser = (T[])bf.Deserialize(fs);
                foreach (T p in deser)
                {
                    if (p == null)
                        continue;
                    this.Push(p);
                }

            }
        }

    }
}
