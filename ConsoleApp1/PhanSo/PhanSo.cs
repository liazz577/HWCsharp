using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session2
{
    internal class PhanSo
    {
        public int tuso { get; set; }
        public int mauso { get; set; }

        public PhanSo()
        {

        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void NhapPhanSo()
        {
            Console.WriteLine("Nhập tử số ");
            this.tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số");
            do
                this.mauso = int.Parse(Console.ReadLine());
            while (this.mauso == 0);
        }
        public void InPhanSo()
        {
            Console.WriteLine("Phân số :" + this.tuso + "/" + this.mauso);
        }
        public PhanSo NgichDao()
        {
            this.tuso = mauso;
            this.mauso = tuso;
            return this;

        }
        public int ucln(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public PhanSo RutGon(PhanSo a)
        {
            int uc = ucln(a.tuso, a.mauso);
            a.tuso = a.tuso / uc;
            a.mauso = a.mauso / uc;
            return a;
        }
        public PhanSo CongPhanSo(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tuso = a.tuso * b.mauso + b.tuso * a.mauso;
            c.mauso = a.mauso * b.mauso;

            return c.RutGon(c);
        }
        public PhanSo TruPhanSo(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tuso = a.tuso * b.mauso - b.tuso * a.mauso;
            c.mauso = a.mauso * b.mauso;

            return c.RutGon(c);
        }
        public PhanSo NhanPhanSo(PhanSo a, PhanSo b)

        {
            PhanSo c = new PhanSo();
            c.tuso = a.tuso * b.tuso;
            c.mauso = a.mauso * b.mauso;

            return c.RutGon(c);
        }
        public PhanSo ChiaPhanSo(PhanSo a, PhanSo b)

        {
            PhanSo c = new PhanSo();
            c.tuso = a.tuso * b.mauso;
            c.mauso = a.mauso * b.tuso;
            return c.RutGon(c);
        }
    }
}