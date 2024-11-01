//
// FORM ONE
// ========
// FormOne is a child of FormMain
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
    public partial class FormOne : Form {
        
        Form FormParent;

        private int totalDistance;

        //
        // Constructor FormOne
        // ===================
        public FormOne(Form FormParent, int TotalDistance) {
            InitializeComponent();

            // Save the value passed into this form.
            this.totalDistance = TotalDistance;          

            // The parent of this form is FormMain. A reference
            // to it was passed in via this Constructor. Save it
            // so we know where to go back to when we close
            // this form.
            this.FormParent = FormParent;
        }

        //
        // FormOne_Load
        // ============
        private void FormOne_Load(object sender, EventArgs e) {
        }


        //
        // buttonGoBack_Click
        // ==================
        private void buttonGoBack_Click(object sender, EventArgs e) {
            // Hide FormOne now we have finished with it. Note that
            // this does not destroy FormOne or its lose its data. If
            // we come back, it will remember what we did last time.
            this.Visible = false;

            // Go back to the parent of this form which is FormMain.
            FormParent.Show();
        }
    }
}
