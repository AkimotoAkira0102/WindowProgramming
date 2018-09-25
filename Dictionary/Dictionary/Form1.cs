using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class dictionary : Form
    {
        Dictionary<String, String> dict = new Dictionary<string, string>();

        public dictionary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String eword = comboBox1.Text;
                String cword = dict[eword];
                richTextBox1.Text = cword;
            }
            catch
            {
                MessageBox.Show("輸入錯誤，查不到！");
            }
        }

        private void dictionary_Load(object sender, EventArgs e)
        {
            String[] eWords = new String[] { "dog", "cat", "eat", "chase", "run", "a", "the" };
            String[] cWords = new String[] { "狗", "貓", "吃", "追", "跑", "一隻", "這隻" };
            for (int i = 0; i < eWords.Length; i++)
            {
                dict.Add(eWords[i], cWords[i]);
            }
        }
    }
}
