using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebEditor
{
    public partial class Form1 : Form
    {
        private int _timer_tick_eat_text = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            richTextBox1.Text = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta charset=\"UTF-8\" />\r\n    <title>title</title>\r\n</head>\r\n<body>\r\n    \r\n</body>\r\n</html>";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string k = "HTML编辑器  ▶你知道吗：";
            _timer_tick_eat_text += 1;
            switch (_timer_tick_eat_text)
            {
                case 1:
                    this.Text = $"{k}<a href>是互联网的粘合剂哦 (＾▽＾)ﾉ ♪";
                    break;
                case 2:
                    this.Text = $"{k}HTML文档开头必须写 <!DOCTYPE html>";
                    break;
                case 3:
                    this.Text = $"{k}<div>是个万能积木盒子 ( •̀ ω •́ )✧";
                    break;
                case 4:
                    this.Text = $"{k}空格在HTML里要写成 &nbsp;呢 ╮(╯▽╰)╭";
                    break;
                case 5:
                    this.Text = $"{k}<meta charset=\"UTF-8\">能防乱码 (￣ω￣*)";
                    break;
                case 6:
                    this.Text = $"{k}<script>让网页动起来哦 (ノ◕ヮ◕)ノ*:･ﾟ✧";
                    break;
                case 7:
                    this.Text = $"{k}表格要用 <table><tr><td>来搭建 (´･ω･`)?";
                    break;
                case 8:
                    this.Text = $"{k}图片要用 <img src=\"图片地址\"> 来插入 (๑•́ ₃ •̀๑)";
                    break;
                case 9:
                    this.Text = $"{k}超链接要用 <a href=\"网址\">来创建哦 (๑•̀ㅂ•́)و✧";
                    break;
                case 10:
                    this.Text = $"{k}<!-- 注释 -->是写给程序员的悄悄话 (✿◡‿◡)";
                    break;
                case 11:
                    this.Text = $"{k}<form>是数据收集专家 ฅ(^ω^ฅ)";
                    break;
                default:

                    _timer_tick_eat_text = 0;
                    break;
            }
            
        }
        private string patch_for_save = "";
        public class publicfilepath
        {
            public static string filepath = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                publicfilepath.filepath = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.UTF8);
                Form2 f2 = new Form2();
                f2.Show();
                MessageBox.Show("保存成功");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta charset=\"UTF-8\" />\r\n    <title>title</title>\r\n</head>\r\n<body>\r\n    \r\n</body>\r\n</html>";
        }
    }
}
