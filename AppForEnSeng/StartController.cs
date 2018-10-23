using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEnSeng
{

    class StartController
    {
        private MotorDomain MotorEt { get; set; }
        private MotorDomain MotorTo { get; set; }
        public StartController()
        {
            MotorEt = new MotorDomain(1);
            MotorTo = new MotorDomain(2);
        }

        public void StartBevægelseOp() {
            MotorEt.Hastighed = 5;
            MotorEt.Position = 0;
            MotorTo.Hastighed = 5;
            MotorTo.Position = 0;
            MotorEt.StartHoejre();
            MotorTo.StartHoejre();
        }
        public void StartBevægelseNed() {
            MotorEt.Hastighed = 3;
            MotorEt.Position = 0;
            MotorTo.Hastighed = 3;
            MotorTo.Position = 0;
            MotorEt.StartVenstre();
            MotorTo.StartVenstre();
        }
        public void StartBevægelseFlad() {
            MotorEt.Hastighed = 4;
            MotorEt.Position = 100;
            MotorTo.Hastighed = 4;
            MotorTo.Position = 100;
            MotorEt.StartHoejre();
            MotorTo.StartVenstre();
        }
    }
}
