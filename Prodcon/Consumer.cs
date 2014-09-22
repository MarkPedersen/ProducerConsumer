using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodcon
{
    class Consumer
    {
        private Boundedbuffer _buffer;
       
        public Consumer(Boundedbuffer buffer, int expectedAmount)
        {
            this._buffer = buffer;
        }

        public Consumer()
        {
            
        }

        public void Run()
        {
          if()
            {


                int temp = this._buffer.Take();
            }
        }
    }
}
