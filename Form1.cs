using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void a01(object sender, EventArgs e)
        {
            OpenFileDialog b01 = new OpenFileDialog();
            b01.InitialDirectory = Application.StartupPath;
            b01.Title = "请选择要打开的文件";
            b01.Filter = "(网页文件*.html)|*.html";
            b01.FilterIndex = 1;
            b01.Multiselect = true;
            Class1 a001 = new Class1();
            if (b01.ShowDialog() == DialogResult.OK)
            {
                string[] b02 = b01.FileNames;
                for (int i = 0; i < b02.Length; i++)
                {
                    if (textBox1.Text.Contains(b02[i]) != true)
                    {
                        textBox1.Text += b02[i] + System.Environment.NewLine;
                        a001.c02(b02[i]);
                    }
                    else
                    {
                        MessageBox.Show("文件名已存在，请确认文件或修改文件名！", "文件名已存在");
                        continue;
                    }
                    for (int i01 = 0; i01 < a001.c01.Count; i01++)
                    {
                        if (i01 != a001.c01.Count - 1)
                        {
                            textBox3.Text += a001.c01[i01] + System.Environment.NewLine;
                        }
                        else
                        {
                            textBox3.Text += a001.c01[i01];
                        }
                    }
                }
            }
        }

        private void a02(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox3.Text, true);
            MessageBox.Show("图片链接复制完成，感谢您的使用！", "操作成功");
        }
    }
}
