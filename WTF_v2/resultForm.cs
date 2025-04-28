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

            result_ST_richTextBox.Text = recordForSt;
            resultTCH_richTextBox.Text = recordForTch;

            MessageBox.Show("Тесты успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.FormClosed += ResultForm_FormClosed;
        }
        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Очищаем RichTextBox
            result_ST_richTextBox.Clear();
            resultTCH_richTextBox.Clear();

            // Освобождаем ресурсы
            result_ST_richTextBox.Dispose();
            resultTCH_richTextBox.Dispose();

            // Отписываемся от событий
            this.FormClosed -= ResultForm_FormClosed;
        }        
    }
}
