using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_dien_2
{
    class TuVung
    {
        private string tu;
        private string nghia;
        private string tuloai;
        private string vidu;

        public void setTu(string tu)
        {
            this.tu = tu;
        }

        public void setNghia(string nghia)
        {
            this.nghia = nghia;
        }

        public void setViDu(string vidu)
        {
            this.vidu = vidu;
        }

        public void setTuLoai(string tuloai)
        {
            this.tuloai = tuloai;
        }

        public string getTu() { return this.tu; }
        public string getNghia() { return this.nghia; }
        public string getViDu() { return this.vidu; }

        public string getTuLoai() { return this.tuloai; }

        public TuVung(string tu, string nghia, string vidu, string tuloai)
        {
            this.tu = tu;
            this.nghia = nghia;
            this.vidu = vidu;
            this.tuloai = tuloai;
        }
    }

    class Node
    {
        private TuVung TuMoi;
        private Node next;

        public void setNode(Node n)
        {
            next = n;
        }
        public Node GetNode() { return next; }

        public TuVung GetTuMoi()
        {
            return TuMoi;
        }

        public void SetTuMoi(TuVung tu)
        {
            TuMoi = tu;
        }

        public Node(TuVung m, Node n)
        {
            TuMoi = m;
            next = n;
        }
    }

    class TuDien
    {
        private Node head;
        private Node tail;
        private int size;

        public TuDien()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void SetSize(int size) { this.size = size; }
        public int getSize() { return size; }

        public void setHead(Node head) { this.head = head; }
        public void setTail(Node tail) { this.tail = tail; }
        public Node GetHead() { return head; }
        public Node GetTail() { return tail; }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
        public void ThemTu(TuVung TuMoi)
        {
            Node newest = new Node(TuMoi, null);
            if (IsEmpty())
            {
                head = newest;
            }
            else
            {
                tail.setNode(newest);
            }
            tail = newest;
            size = size + 1;

        }
        public void Remove_First()
        {
            head = head.GetNode();
            size -= 1;
        }
    }
}
