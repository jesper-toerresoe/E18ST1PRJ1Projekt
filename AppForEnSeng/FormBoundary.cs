using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForEnSeng
{
    public partial class FormBoundary : Form
    {
        /// <summary>
        /// Her initialiserer du APPforEnSeng afhængigheder som typisk er oprettelse
        /// af forskellige COntroller Class som skal udføre den funktion.
        /// Referencen til den eller de nødvendige Controller Class kan som udgangspunkt
        /// oprettes som Properties eller Attributes på FormBoundary klassen
        /// </summary>
        private StartController StartController { get; set; }
        private StopController StopController { get; set; }

        public FormBoundary()
        {
            InitializeComponent();
            //Her initialiserer du APPforEnSeng afhængigheder
            StartController = new StartController();
            StopController = new StopController();

        }

        private void koerop_Click(object sender, EventArgs e)
        {
            StartController.StartBevægelseOp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartController.StartBevægelseOp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopController.StopBevægelseFlad();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartController.StartBevægelseFlad();
        }
    }
}
