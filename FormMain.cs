//
// FORM SWITCHING EXAMPLE
// ======================
// Demonstrates how to switch between different
// forms connected in the same application.
//
// FormMain is the main form. It has two children
// and one grandchild:
//
//          FormMain--> FormOne    
//                 '--> FormTwo --> FormThree
//
// Look at the code to understand why Form One
// cannot show Form Two but it can go back to
// FormMain.
//
// Look at the code to understand why FormTwo
// can go back to FormMain or show FormThree.
//
// Revision History
// ================
// 21.05.2023 BRD Original version.
// 30.10.2024 BRD Revised to make the code simpler
//
using System;
using System.Windows.Forms;

namespace Form_Loading {
    public partial class FormMain : Form {
        // FormOne is another form we have already created.
        // This is an object of type Form that will allows us
        // to control FormOne when we want to after we create
        // it in this forms constructor.
        private int totalDistance;

        Form formOne;

        // FormTwo can be accessed from FormMain
        Form FormTwo;        

        //
        // Constructor FormMain
        // ====================
        public FormMain() {
            InitializeComponent();

            // This creates FormOne and FormTwo. The this command
            // tells each form who its parent is.
            totalDistance = 1024;
            formOne = new FormOne(this, totalDistance);

            FormTwo = new FormTwo(this);
            
        }

        //
        // FormMain_Load()
        // ===============
        private void FormMain_Load(object sender, EventArgs e) {
        }

        //
        // buttonLoadFormOne_Click()
        // =========================
        private void buttonLoadFormOne_Click(object sender, EventArgs e) {
            // FormMain is the current visible form. It can be referenced with
            // the this keyword. Make FormMain invisible
            //this.Visible = false;

            // Now tell FormOne to show itself.
            formOne.ShowDialog();
        }

        //
        // buttonLoadFormTwo_Click()
        // =========================
        private void buttoLoadFormTwo_Click(object sender, EventArgs e) {
            // Make FormMain invisible
            this.Visible = false;

            // Now tell FormTwo to show itself.
            FormTwo.Show();
        }                
    }
}
