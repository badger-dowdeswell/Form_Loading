//
// FORM TWO
// ========
// FormTwo has a child of its own called
// FormThree. FormThree is a grandchild of
// FormMain.

using System;
using System.Windows.Forms;

namespace Form_Loading {
    public partial class FormTwo : Form {
        Form FormParent;
        Form FormThree;

        //
        // Constructor FormTwo
        // ===================
        public FormTwo(Form FormParent) {
            InitializeComponent();

            // The parent of this form is FormMain. A reference
            // to it was passed in via this Constructor. Save it
            // so we know where to go back to.
            this.FormParent = FormParent;

            // Form Two can also display Form Three ...
            FormThree = new FormThree(this);
        }

        //
        // FormTwo_Load()
        // ===============
        private void FormTwo_Load(object sender, EventArgs e) {
        }

        //
        // buttonGoBack_Click()
        // ====================
        private void buttonGoBack_Click(object sender, EventArgs e) {
            // Hide FormTwo now we have finished with it.
            this.Visible = false;

            // Go back to the parent of this form. It is FormMain.
            FormParent.Show();
        }

        //
        // buttonLoadFormThree_Click()
        // ===========================
        private void buttonLoadFormThree_Click(object sender, EventArgs e) {
            // Hide FormTwo now we have finished with it.
            this.Visible = false;

            // Load Form Three.
            FormThree.Show();
        }

        private void FormTwo_Load_1(object sender, EventArgs e) {

        }
               
    }
}
