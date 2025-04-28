using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTF_v2
{
    public partial class resultForm: Form
    {
        public resultForm(string recordForSt, string recordForTch)
        {
            InitializeComponent();
            MessageBox.Show("Тесты успешно сохранены");

            result_ST_richTextBox.Text = recordForSt;
            resultTCH_richTextBox.Text = recordForTch;
        }

    }
}
