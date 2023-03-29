namespace dinamic2
{
    class Massive2
    {
        public Massive2() { a = new double[1]; Size = 0; capacity = 1; }
        public Massive2(int c)
        {
            a = new double[c];
            Size = 0;
            capacity = c;
        }
        public Massive2(Massive2 b)
        {
            capacity = b.capacity;
            Size = b.Size;
            a = new double[b.capacity];
            for (int i = 0; i < b.a.Length; i++)
            {
                a[i] = b.a[i];
            }
        }
        public void New()
        {
            int cap = capacity * 2;
            double[] A = new double[cap];
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
            a = new double[capacity];
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
                    double d = Convert.ToDouble(Console.ReadLine());
                    set(i, d);
                }
            }
        }
        public void last(double LE)
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

        public double[] Max()
        {
            double max = a[0];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i]) { max = a[i]; k = i; }
            }
            return new double[] { max, Convert.ToDouble(k) };
        }

        public int Kol() { return Size; }


        public void Ran()
        {
            Console.WriteLine("Какой длины будет массив? ");
            capacity = Convert.ToInt32(Console.ReadLine());
            a = new double[capacity];
            Console.WriteLine("Сколько элмеентов хотите добавить? ");
            Size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диапозон(два значения) в котором будет заполнен массив: ");
            double c = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < Size; i++)
            {
                if (b >= c)
                {
                    a[i] = c + random.NextDouble();
                }
                else { a[i] = b + random.NextDouble(); }

            }
        }


        private int capacity;
        private int Size;
        public void set(int j, double value) { a[j] = value; }
        public double get(int j) { return a[j]; }
        private double[] a;
    }
}
