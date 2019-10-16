using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhanSo
{
    public class PhanSo
    {
        private int tu;
        private int mau;

        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }

        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }

        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }

        public PhanSo(int t , int m)
        {
            this.tu = t;
            this.mau = m;
        }

        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau + mau * p.tu;
            kq.mau = mau * p.mau;
            return kq;
        }

        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau + mau * p.tu;
            kq.mau = mau * p.mau;
            return kq;
        }

        public PhanSo Chia(PhanSo p)
        {
            if (p.tu == 0)
                throw new DivideByZeroException();
            
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau;
            kq.mau = mau * p.tu;
            return kq;
        }


        public override string ToString()
        {
            return tu + "/" + mau;
        }
    }
}
