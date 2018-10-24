using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEnSeng
{
    class MotorDomain
    {
        //Den hastighed motor skal køre rund med
        public int Hastighed { get; set; }
        //Postion motor skal stilles i
        public int Position { get; set; }
        //Den position motor har når den stoppes
        public int GemtPosition { get; set; }
        //Eksempel på hvilken forbindelse der bruges til den rigtige motor
        private int Portnummer { get; set; }
        //Den klasse som håndterer den fysiske kommunikation til motoren
        private MotorIF Motor {get;set;}

        public MotorDomain(int motorport)
        {
            Portnummer = motorport;
            Position = 0;
            Hastighed = 0;
            GemtPosition = 0;
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
            GemtPosition = Motor.HentPosition();
        }

        //public int PositionNu() {
        //    return Motor.HentPosition();
        //}




    }
}
