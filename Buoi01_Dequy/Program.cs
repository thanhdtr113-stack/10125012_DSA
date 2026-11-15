class Program
{
    static void B1C1()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random rand = new Random();

        int[] RandomNum = new int[1000];

        for (int i = 0; i < RandomNum.Length; i++)
        {
            RandomNum[i] = rand.Next(1, 101);
        }

        int MaxNum = RandomNum[0];
        int MinNum = RandomNum[0];

        for (int i = 0; i < RandomNum.Length; i++)
        {
            if (MaxNum < RandomNum[i])
            {
                MaxNum = RandomNum[i];
            }
            if (MinNum > RandomNum[i])
            {
                MinNum = RandomNum[i];
            }
        }

        Console.WriteLine("Các phần tử trong mảng: " + string.Join(", ", RandomNum) + "\n");
        Console.WriteLine("Số lớn nhất: " + MaxNum);
        Console.WriteLine("Số nhỏ nhất: " + MinNum);
    }
    static void B2C1()
    {
        int[] Number = new int[101];
        for (int i = 1; i < Number.Length; i++)
        {
            Number[i] = i;
        }

        for (int i = 1; i < Number.Length; i++)
        {
            if (Number[i] % 3 == 0) { Console.Write("Fizz" + ","); }
            if (Number[i] % 5 == 0) { Console.Write("Buzz" + ","); }
            if ((Number[i] % 3 == 0) && (Number[i] % 5 == 0)) { Console.Write("FizzBuzz" + ","); }
            else { Console.Write(Number[i] + ","); }
        }
    }
    static void B3C1()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập vào một chuỗi : ");
        string input = Console.ReadLine();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            char c = input[i];
            Console.Write(c);

        }
    }
    static void B4C1()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random rand = new Random();
        int[] RandomNum = new int[1000];

        for (int i = 0; i < RandomNum.Length; i++) { RandomNum[i] = rand.Next(1, 101); }

        Console.Write("Mảng ban đầu: ");
        for (int i = 0; i < RandomNum.Length; i++) { Console.Write(RandomNum[i] + " "); }
        Console.WriteLine("\n");

        Console.WriteLine("Mảng sau khi sắp xếp tăng dần: ");
        Array.Sort(RandomNum);
        for (int i = 0; i < RandomNum.Length; i++) { Console.Write(RandomNum[i] + " "); }
        Console.WriteLine();
    }
    static void B5C1()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n : ");
        int n = int.Parse(Console.ReadLine());
        int Fibonaci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonaci(n - 1) + Fibonaci(n - 2);
            }
        }
        Console.WriteLine($"Số Fibonaci thứ {n} là: {Fibonaci(n)}");
    }
    static void B1C2()
    {
        static void ThapHaNoi(int n, char cotA, char cotB, char cotC)
        {
            if (n == 1)
            {
                Console.WriteLine($"Di chuyển đĩa 1 từ {cotA} sang {cotC}");
                return;
            }
            ThapHaNoi(n - 1, cotA, cotC, cotB);

            Console.WriteLine($"Di chuyển đĩa {n} từ {cotA} sang {cotC}");

            ThapHaNoi(n - 1, cotB, cotA, cotC);
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng đĩa n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Các bước thực hiện:");
        ThapHaNoi(n, 'A', 'B', 'C');
    }
    static void B2C2()
    {
        static int BinarySearch(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return BinarySearch(arr, left, mid - 1, x);

                return BinarySearch(arr, mid + 1, right, x);
            }

            return -1;
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        Console.WriteLine("Mảng hiện tại: " + string.Join(", ", arr));
        Console.Write("Nhập số cần tìm: ");
        int x = int.Parse(Console.ReadLine());

        int result = BinarySearch(arr, 0, arr.Length - 1, x);

        if (result == -1)
            Console.WriteLine("Không tìm thấy phần tử trong mảng.");
        else
            Console.WriteLine($"Tìm thấy phần tử {x} tại vị trí chỉ số (index): {result}");
    }
    static void B3C2()
    {
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n cần kiểm tra: ");
        int n = int.Parse(Console.ReadLine());

        if (KiemTraNguyenTo(n))
        {
            Console.WriteLine($"{n} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số nguyên tố.");
        }
    }
    static void B4C2()
    {
        static bool LaSoHoanHao(int num)
        {
            if (num <= 1) return false;

            int tongUoc = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    tongUoc += i;
                }
            }

            return tongUoc == num;
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Các số hoàn hảo nhỏ hơn {n} là:");
        bool coSoHoanHao = false;

        for (int i = 1; i < n; i++)
        {
            if (LaSoHoanHao(i))
            {
                Console.Write(i + " ");
                coSoHoanHao = true;
            }
        }

        if (!coSoHoanHao)
        {
            Console.WriteLine("Không có số hoàn hảo nào nhỏ hơn " + n);
        }
    }
    static void B5C2()
    {
        static long FibonacciDeQuy(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciDeQuy(n - 1) + FibonacciDeQuy(n - 2);
        }

        static long FibonacciVongLap(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            long a = 0;
            long b = 1;
            long c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        long kq = FibonacciVongLap(n);
        Console.WriteLine($"Số Fibonacci thứ {n} là: {kq}");
    }
    static void B6C2()
    {
        static void BubbleSort(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                double temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double[] arr = { 4.5, 1.2, 8.9, 3.3, 2.1, 7.6 };

        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

        BubbleSort(arr);

        Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", arr));
    }
    static void B1C3()
    {
        static int TinhS(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return TinhS(n - 1) + n;
        }
        Console.Write("Nhap so nguyen duong n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int i = TinhS(n);
            Console.WriteLine($"Ket qua: S({n}) = {i}");
        }
    }
    static void B2C3()
    {
        static int TinhS(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return TinhS(n - 1) + (n * n);
        }
        Console.Write("Nhap so nguyen duong n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int i = TinhS(n);
            Console.WriteLine($"Ket qua: S({n}) = {i}");
        }
    }
    static void B3C3()
    {
        static double TinhS(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return TinhS(n - 1) + (1.0 / n);
        }
        Console.Write("Nhap so nguyen duong n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            double i = TinhS(n);
            Console.WriteLine($"Ket qua: S({n}) = {i}");
        }
    }
    static void B4C3()
    {
        static double LuyThua(double x, int n)
        {
            if (n < 0)
            {
                return 1.0 / LuyThua(x, -n);
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return x * LuyThua(x, n - 1);
            }
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập cơ số x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Nhập số mũ n: ");
        int n = int.Parse(Console.ReadLine());

        double kq = LuyThua(x, n);

        Console.WriteLine($"Kết quả của {x}^{n} là: {kq}");
    }
    static void B5C3()
    {
        static int UocLeMax(int n)
        {
            if (n % 2 != 0)
            {
                return n;
            }
            else
            {
                return UocLeMax(n / 2);
            }
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        int kq = UocLeMax(n);
        Console.WriteLine($"Ước lẻ lớn nhất của {n} là: {kq}");
    }
    static void B6C3()
    {
        static int UCLN(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return UCLN(b, a % b);
            }
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số b: ");
        int b = int.Parse(Console.ReadLine());

        int kq = UCLN(a, b);
        Console.WriteLine($"Ước chung lớn nhất của {a} và {b} là: {kq}");
    }
    static void B7C3()
    {
        static int SoChuSo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return SoChuSo(n / 10) + 1;
            }
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        int kq;
        if (n == 0)
        {
            kq = 1;
        }
        else
        {
            kq = SoChuSo(n);
        }
        Console.WriteLine($"Số lượng chữ số của {n} là: {kq}");
    }
    static void B8C3()
    {
        static float Can(int i, int n)
        {
            if (i == n)
            {
                return (float)Math.Sqrt(n);
            }
            else
            {
                return (float)Math.Sqrt(i + Can(i + 1, n));
            }
        }

        static float S(int n)
        {
            return Can(1, n);
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        float kq = S(n);
        Console.WriteLine($"Kết quả S({n}) là: {kq}");
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Bài 1 Chương 1 ===");
        B1C1();
        Console.WriteLine("\n=== Bài 2 Chương 1 ===");
        B2C1();
        Console.WriteLine("\n=== Bài 3 Chương 1 ===");
        B3C1();
        Console.WriteLine("\n=== Bài 4 Chương 1 ===");
        B4C1();
        Console.WriteLine("\n=== Bài 5 Chương 1 ===");
        B5C1();
        Console.WriteLine("\n=== Bài 1 Chương 2 ===");
        B1C2();
        Console.WriteLine("\n=== Bài 2 Chương 2 ===");
        B2C2();
        Console.WriteLine("\n=== Bài 3 Chương 2 ===");
        B3C2();
        Console.WriteLine("\n=== Bài 4 Chương 2 ===");
        B4C2();
        Console.WriteLine("\n=== Bài 5 Chương 2 ===");
        B5C2();
        Console.WriteLine("\n=== Bài 6 Chương 2 ===");
        B6C2();
        Console.WriteLine("\n=== Bài 1 Chương 3 ===");
        B1C3();
        Console.WriteLine("\n=== Bài 2 Chương 3 ===");
        B2C3();
        Console.WriteLine("\n=== Bài 3 Chương 3 ===");
        B3C3();
        Console.WriteLine("\n=== Bài 4 Chương 3 ===");
        B4C3();
        Console.WriteLine("\n=== Bài 5 Chương 3 ===");
        B5C3();
        Console.WriteLine("\n=== Bài 6 Chương 3 ===");
        B6C3();
        Console.WriteLine("\n=== Bài 7 Chương 3 ===");
        B7C3();
        Console.WriteLine("\n=== Bài 8 Chương 3 ===");
        B8C3();
        Console.WriteLine("\n=== Kết thúc chương trình ===");
        Console.ReadKey();
    }
}