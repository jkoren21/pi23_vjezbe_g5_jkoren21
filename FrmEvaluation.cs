using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaluation : Form {
        public FrmEvaluation() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void txtEvaluationDate_TextChanged(object sender, EventArgs e) {

        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {

        }

        private void btnEvaluiraj_Click(object sender, EventArgs e) {

        }

        private void txtActivityDescription_TextChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.Min
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
