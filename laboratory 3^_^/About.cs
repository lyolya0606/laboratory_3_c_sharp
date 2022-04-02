using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratory_3 {
    public partial class About : Form {
        public bool IsAgain { get; set; }

        public About(bool isAgain) {
            IsAgain = isAgain;
            //SavingChoice();
            InitializeComponent();
        }

        public void SavingChoice() {
            SavingCheckBox savingCheckBox = new SavingCheckBox();
            if (savingCheckBox.ReadCheckBox()) {
                checkBox.Checked = false;
            } else {
                checkBox.Checked = true;
            }
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e) {
            IsAgain = !checkBox.Checked;

        }

        private void ClosingAbout(object sender, FormClosingEventArgs e) {
            SavingCheckBox savingCheckBox = new SavingCheckBox();
            savingCheckBox.ChangeMessageBox(IsAgain);

        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
