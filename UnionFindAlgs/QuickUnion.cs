using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFindAlgs
{
    public class QuickUnion
    {
        private int[] ids;
        private int[] sz;

        public QuickUnion(int n)
        {

            ids = new int[n];
            sz = new int[n];

            for (int i = 0; i < n; i++)
            {
                ids[i] = i;
                sz[i] = 1;
            }
        
        }

        private int Root(int i)
        {
            while (i != ids[i])
            {
                ids[i] = ids[ids[i]];

                i = ids[i];
            }
            return i;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);

            if (i == j) return;

            if (sz[i] < sz[j])
            {
                ids[i] = j;

                sz[j] += sz[i];
            }
            else
            {
                ids[j] = i;

                sz[i] += sz[j];
            }
        }
    }
    
}
