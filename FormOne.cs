//
// FORM ONE
// ========
// FormOne is a child of FormMain
//
using System;
using System.Windows.Forms;

namespace Form_Loading {
    public partial class FormOne : Form {
        
        Form FormParent;
        private int totalDistance;
        public int TotalDistance {
            get { return totalDistance; }
        }

        //
        // Constructor FormOne
        // ===================
        public FormOne(Form FormParent, int TotalDistance) {
            InitializeComponent();
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
            // Hide FormOne now we have finished with it.
            //FormParent.TotalDistance = totalDistance;
            totalDistance = 1000;
            this.Visible = false;

            // Go back to the parent of this form. It is FormMain.
            FormParent.Show();
        }
    }
}
