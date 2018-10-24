using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEnSeng
{
    class StopController
    {
        private MotorDomain MotorEt { get; set; }
        private MotorDomain MotorTo { get; set; }
        //De to properties er nu tilføjet MotorDomain klassen mere naturligt at have dem der
        //private int MotorEtPosition { get; set; }
        //private int MotorToPosition { get; set; }
        public StopController()
        {
            MotorEt = new MotorDomain(1);
            MotorTo = new MotorDomain(2);
            //MotorEtPosition = 0;
            //MotorToPosition = 0;
        }

        public void StopBevægelseOp()
        {
            MotorEt.Stop();//Gemmer selv stopposition
            MotorTo.Stop();//Gemmer selv stopposition
            //MotorEtPosition = MotorEt.PositionNu();
            //MotorToPosition = MotorTo.PositionNu();
            MotorEt.Hastighed = 0;
            MotorEt.Position = 0;
            MotorTo.Hastighed = 0;
            MotorTo.Position = 0;
            
        }
        public void StopBevægelseNed()
        {
            MotorEt.Stop();
            MotorTo.Stop();
            //MotorEtPosition = MotorEt.PositionNu();
            //MotorToPosition = MotorTo.PositionNu();
            MotorEt.Hastighed = 0;
            MotorEt.Position = 0;
            MotorTo.Hastighed = 0;
            MotorTo.Position = 0;
        }
        public void StopBevægelseFlad()
        {
            MotorEt.Stop();
            MotorTo.Stop();
            //MotorEtPosition = MotorEt.PositionNu();
            //MotorToPosition = MotorTo.PositionNu();
            MotorEt.Hastighed = 0;
            MotorEt.Position = 0;
            MotorTo.Hastighed = 0;
            MotorTo.Position = 0;
        }              
       
    }
}
