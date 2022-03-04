using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Avancerad_.NET_Labb_1_Generics
{
    public class LådaSameVol : EqualityComparer<Låda>
    {
        public override bool Equals(Låda x, Låda y)
        {
            if ((x.höjd * x.bredd * x.längd )==(y.höjd * y.bredd * y.längd))
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
