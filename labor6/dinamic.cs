namespace dinamic
{
    class Massive
    {
        public Massive() { a = new int[1]; Size = 0; capacity = 1; }
        public Massive(int c)
        {
            a = new int[c];
            Size = 0;
            capacity = c;
        }
        public Massive(Massive b)
        {
            capacity = b.capacity;
            Size = b.Size;
            a = new int[b.capacity];
            for (int i = 0; i < b.a.Length; i++)
            {
                a[i] = b.a[i];
            }
        }
        public void New()
        {
            int cap = capacity * 2;
            int[] A = new int[cap];
            for (int i = 0; i < Size; i++)
            {
                A[i] = a[i];
            }
            a = A;
            capacity = cap;
        }
        public override string ToString()
        {
            string name = " ";
            for (int i = 0; i < a.Length; i++)
            {
                name = name + a[i] + " ";
            }
            return name;
        }
        public void Input()
        {
            Console.WriteLine("Какой длины будет массив? ");
            capacity = Convert.ToInt32(Console.ReadLine());
            a = new int[capacity];
            Console.WriteLine("Сколько элмеентов хотите добавить? ");
            Size = Convert.ToInt32(Console.ReadLine());
            if (Size > capacity)
                throw new IndexOutOfRangeException();
            else
            {
                if (Size == capacity)
                {
                    New();
                }
                for (int i = 0; i < Size; i++)
                {
                    int d = Convert.ToInt32(Console.ReadLine());
                    set(i, d);
                }
            }
        }
        public void last(int LE)
        {
            if (capacity == Size)
            {
                New();
            }
            a[Size] = LE;
            Size++;
        }
        public void Remove()
        {
            if (Size == 0) { return; }
            Size--;
        }
        public void Output()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public int[] Max()
        {
            int max = a[0];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i]) { max = a[i]; k = i; }
            }
            return new int[] { max, k };
        }

        public int Kol() { return Size; }
        public int sum() { int k = 0; for (int i = 0; i < Size; i++) { k += a[i]; } return k; }

        public void Ran()
        {
            Console.WriteLine("Какой длины будет массив? ");
            capacity = Convert.ToInt32(Console.ReadLine());
            a = new int[capacity];
            Console.WriteLine("Сколько элмеентов хотите добавить? ");
            Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диапозон(два значения) в котором будет заполнен массив: ");
            int c = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < Size; i++)
            {
                if (b >= c)
                {
                    a[i] = c + random.Next();
                }
                else { a[i] = b + random.Next(); }

            }
        }


        private int capacity;
        private int Size;
        public void set(int j, int value) { a[j] = value; }
        public int get(int j) { return a[j]; }
        private int[] a;
    }
}
