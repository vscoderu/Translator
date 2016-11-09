using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        YandexTranslator yt;

        public Form1()
        {
            InitializeComponent();

            yt = new YandexTranslator();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string lang;

            if (ruEnRadioButton.Checked == true)
            {
                lang = "ru-en";
            }
            else
            {
                lang = "en-ru";
            }

            outputTextBox.Text = yt.Translate(inputTextBox.Text, lang);
        }
    }
}