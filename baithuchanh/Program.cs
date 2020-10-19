using System;

namespace baithuchanh1
{
    class Diem
    {
        private double x, y;
        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y:");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Toa do (x,y)=({0},{1})");
        }
        public double TinhDT(Diem B)
        {
            return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
        }
    }
}
//BÀI 2:
class Employe
{
    private int id, year;
    private string name;
    private double salary, basic;
    public double setsalary
    {
        get
        {
            return salary;
        }
        set
        {
            salary = value;
        }
    }
    public double setbasic
    {
        get
        {
            return basic;
        }
        set
        {
            basic = value;
        }
    }
    public int getid()
    {
        return id;
    }
    public string getname()
    {
        return name;
    }
    public int getyear()
    {
        return year;
    }
    public double getincome()
    {
        return salary * basic;
    }
    public void display()
    {
        Console.WriteLine("dinh danh\t ten\tnam sinh \tluong co ban\t thu nhap");
        Console.WriteLine(id + "\t" + name + "\t" + year + "\t\t" + basic + "\t" + getincome());
    }
    class stack //bai3
    {
        private int top;
        private int[] s;
        public stack()
        {
            top = -1;
            s = new int[20];
        }
        public stack(int n)
        {
            top = -1;
            s = new int[n];
        }
        public bool empty()
        {
            if (top == -1)
                return true;
            else return false;
        }
        public bool full()
        {
            if (top == s.Length - 1)
                return true;
            else return false;
        }
        public void push(int x)
        {
            if (full()) Console.WriteLine("Stack day");
            else s[++top] = x;
        }
        public int pop()
        {
            if (empty()) throw new Exception("Stack rong");
            else
            {
                int x = s[top--];
                return x;
            }
        }
    }
    class App
    {
        public void Main()
        {
            int n;
            stack s = new stack();
            Console.Write("Nhap n="); n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                s.push(n % 2);
                n = n / 2;
            }
            while (!s.empty())
                Console.Write(s.pop());
            Console.ReadKey();
        }
    }