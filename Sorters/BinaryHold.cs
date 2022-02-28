using System;
using System.Collections.Generic;
using System.Text;

namespace Sorters
{
    class BinaryHold
    {
        static int BitLength = 12;
        public int[] bin = new int[BitLength];

        public BinaryHold()
        {
            for (int i = 0; i < BitLength; i++) { bin[i] = 2; }
        }
        public BinaryHold(int[] bin)
        {
            this.bin = bin;
        }
    }
}
