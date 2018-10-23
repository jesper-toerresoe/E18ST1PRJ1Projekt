using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEnSeng
{
    class MotorIF
    {
        private int Nummer { get; set; }
        public MotorIF(int nummer)
        {
            Nummer = nummer;
        }

        public void Stop() { }

        public void Start(int hastighed,int retning) { }

        public void StilPosition(int hastighed, int position) { }
       
        public int HentPosition()
        {
            return 23;
        }

    }
}
