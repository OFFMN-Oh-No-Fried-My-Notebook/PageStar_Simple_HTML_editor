using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WebEditor.Form1;

namespace WebEditor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate($"file:///{publicfilepath.filepath}");
            if (!string.IsNullOrEmpty(publicfilepath.filepath))
            {
                try
                {
                    var uri = new Uri(publicfilepath.filepath);
                    webBrowser1.Navigate(uri);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"加载网页失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("没有指定文件路径，请先保存文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
