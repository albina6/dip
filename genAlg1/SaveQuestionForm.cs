using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genAlg1
{
    public partial class SaveQuestionForm : Form
    {
        public SaveQuestionForm()
        {
            InitializeComponent();
        }

        public SaveBoolEvent SaveBE;
        private void SaveQuestion_Load(object sender, EventArgs e)
        {

        }
        //public EventLogic S;
        private void yesB_Click(object sender, EventArgs e)
        {
            SaveBE = SaveBoolEvent.Yes;
            this.Close();
        }

        private void noB_Click(object sender, EventArgs e)
        {
            SaveBE = SaveBoolEvent.No;
            this.Close();
        }
    }
}
