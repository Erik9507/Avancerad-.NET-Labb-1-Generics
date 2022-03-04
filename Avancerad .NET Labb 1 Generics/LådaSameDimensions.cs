using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Avancerad_.NET_Labb_1_Generics
{
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
        public override int GetHashCode( Låda obj)
        {
            int HashCode = obj.höjd ^ obj.längd ^ obj.bredd;
            return HashCode.GetHashCode();
        }

    }
}
