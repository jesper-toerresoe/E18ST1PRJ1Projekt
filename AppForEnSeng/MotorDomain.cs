using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEnSeng
{
    class MotorDomain
    {
        public int Hastighed { get; set; }
        public int Position { get; set; }
        private int Portnummer { get; set; }
        private MotorIF Motor {get;set;}
        public MotorDomain(int motorport)
        {
            Portnummer = motorport;
            Position = 0;
            Hastighed = 0;
            Motor = new MotorIF(Portnummer);
        }
        public void StartHoejre() {
            //Kør mortor på "portnummer" højre om med "hastighed" til "position hvis "position ikke er nul
            //ellers kør til stop
            if (Position == 0)
                Motor.Start(Hastighed, 1);
            else
                Motor.StilPosition(Hastighed, Position);


         }
        public void StartVenstre()
        {
            //Kør mortor på "portnummer" venstre om med "hastighed" til "position hvis "position ikke er nul
            //ellers kør til stop
            if (Position == 0)
                Motor.Start(Hastighed, 2);
            else
                Motor.StilPosition(Hastighed, Position);
        }

        public void Stop() {
            //Stop motor på "portnummer"
            Motor.Stop();
        }

        public int PositionNu() {
            return Motor.HentPosition();
        }




    }
}
