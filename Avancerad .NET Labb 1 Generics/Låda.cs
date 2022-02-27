using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Avancerad_.NET_Labb_1_Generics
{
    public class Låda : IEquatable<Låda>
    {
        public Låda(int h, int l, int b)
        {
            this.höjd = h;
            this.längd = l;
            this.bredd = b;
        }
        public int höjd { get; set; }
        public int längd { get; set; }
        public int bredd { get; set; }
        public override string ToString()
        {
            return "Höjd: " + höjd + " " + "Bredd: " + bredd + " " + "Längd: " + längd;
        }

        public bool Equals(Låda other)
        {
            if (new LådaSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class LådaSameDimensions : EqualityComparer<Låda>
    {    
        public override bool Equals([AllowNull] Låda x, [AllowNull] Låda y)
        {
            if (x.höjd == y.höjd && x.längd == y.längd && x.bredd == y.bredd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode([DisallowNull] Låda obj)
        {
            int HashCode = obj.höjd ^ obj.längd ^ obj.bredd;
            return HashCode.GetHashCode();
        }
        
    }
    
}
