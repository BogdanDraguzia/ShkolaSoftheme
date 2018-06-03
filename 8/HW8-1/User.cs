using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
    class User
    {
        private int a;
        private string b;
        private bool c;

        public User(int a, string b, bool c)
        {
            this.a = a;
            this.B = b;
            this.C = c;
        }

        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public bool C { get => c; set => c = value; }

        public void ShallowClone(out User destination)
        {
            destination = this;
            return;
        }

        public void DeepClone(out User destination)
        {
            destination = new User(A,B,C);
        }
    }
    
}
