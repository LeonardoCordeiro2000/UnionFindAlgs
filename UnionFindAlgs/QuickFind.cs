using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFindAlgs
{
    public class QuickFind
    {
        private int[] ids;

        public QuickFind(int n)
        {
            ids = new int[n];

            for (int i = 0; i < n; i++)
            {
                ids[i] = i;
            }
        }

        public bool Connected(int p, int q)
        {
             return ids[p] == ids[q];
        }

        public void Union(int p, int q)
        {
            int pid = ids[p];
            int qid = ids[q];

            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] == pid) ids[i] = qid;
            }
        }
    }
}
