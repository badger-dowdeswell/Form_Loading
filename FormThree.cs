//
// FORM THREE
// ==========
// FormThree is the child of FormTwo
// 
using System;
using System.Windows.Forms;

namespace Form_Loading {
    public partial class FormThree : Form {

        // The parent of this form is FormMain. A reference
        // to it was passed in via this Constructor. Save it
        // so we know where to go back to.
        Form FormParent;

        //
        // Constructor FormThree
        // =====================
        public FormThree(Form FormParent) {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void FormThree_Load(object sender, EventArgs e) {
        }

        //
        // buttonGoBack_Click()
        // ====================
        private void buttonGoBack_Click(object sender, EventArgs e) {
            // Hide FormThree now we have finished with it.
            this.Visible = false;

            // Go back to the parent of this form. It is FormMain.
            FormParent.Show();
        }
    }
}
