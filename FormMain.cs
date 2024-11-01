//
// FORM LOADING AND SWITCHING EXAMPLE
// ==================================
// This project demonstrates how to switch between
// different forms connected together in the same
// application.
//
// FormMain is the main form. It has two children
// and one grandchild:
//
//          FormMain--> FormOne    
//                 '--> FormTwo --> FormThree
//
// Look at the code to understand why Form Main 
// can show FormOne and FormTwo by looking at
// the button handling event code. 
//
// Look at the code to understand why FormOne is
// modal and displays over the top of FormMain.
// Then look at how FormTwo hides FormMain, how
// it can then load FormThree, and how it can
// can go back to FormTwo and FormMain without
// forgetting where it came from.
//
// Revision History
// ================
// 21.05.2023 BRD Original version.
// 30.10.2024 BRD Revised to make the code simpler.
// 01.11.2024 BRD Updated documentation.
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

        // FormTwo can be accessed from FormMain. Remember that
        // Forms are objects and you need to created them just
        // like you create Classes.
        //
        Form FormTwo;        

        //
        // Constructor FormMain
        // ====================
        public FormMain() {
            InitializeComponent();

            // This creates FormOne and FormTwo. Note how the
            // Constructor tells each form who its parent is by
            // passing a reference of type Form to the child
            // that it can remember for later when it needs to
            // go back to where it came from. FormOne also accepts
            // an integer parameter you can pass to it from the
            // parent form and use inside FormOne.
            //
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
            // the this keyword.
            //
            // If you want to make FormMain invisible
            // remove the comment from the next line:
            // this.Visible = false;

            // Tell FormOne to show itself.
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
