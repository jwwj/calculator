using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace 计算器
{
    public partial class Form1 : Form
    {
        int p = 0;
        double t1 = 0;
        bool t = true;
        bool r = true;
        bool w = true;
        public void an(double a)
        {
            if ((textBox2.Text == "0") && (t = true) || (textBox2.Text == "ERROR!"))
            {
                textBox2.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + a;
                textBox2.Text = textBox2.Text + a;
            }
           else if ((textBox2.Text != "0") || (textBox2.Text != "ERROR!"))
            {
                textBox1.Text = textBox1.Text + a;
                textBox2.Text = textBox2.Text + a;
            }
        }
        public void an(string a)
        {
            if ((textBox2.Text == "0") && (t = false) || (textBox2.Text == "ERROR!"))
            {
                textBox2.Text = "";
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + a;
                textBox2.Text = textBox2.Text + a;
            }
            if ((textBox2.Text != "0") || (textBox2.Text != "ERROR!"))
            {
                textBox1.Text = textBox1.Text + a;
                textBox2.Text = textBox2.Text + a;
            }
            t = true;
        }
        public void ac(string a)
        {
            string str = textBox2.Text;
            char c;
            c = Convert.ToChar(str.Substring(str.Length - 1));
            if (p == 0 )
            {

                if (textBox2.Text != "ERROR!" && c != '.')
                {
                    if (w == true)  t1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "0";
                    textBox2.Text = textBox2.Text + a;
                    w = true;
                }
                else if (textBox2.Text == "ERROR!") { textBox1.Text = "0"; };
            }

            else if (p != 0 )
            {
                
                //MessageBox.Show(str.Substring(str.Length - 1));
                if ( (c != '+' && c != '-' && c != '×' && c != '÷'))
                {
                    button11.PerformClick();//w=true;p=0;
                    if (textBox2.Text != "ERROR!" && c != '.') 
                    {
                        t1 = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "0";
                        textBox2.Text = textBox2.Text + a;
                    }
                }
                else if (c == '+' || c == '-' || c == '×' || c == '÷')
                {

                    //  if (w == true) button11.PerformClick();
                    //t1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "0";
                    if (textBox2.Text != "ERROR!" && c != '.')
                        textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1) + a;
                    else if (textBox2.Text == "ERROR!") { }
                    else
                    {
                        t1 = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = "0";
                        textBox2.Text = textBox2.Text + a;
                    };
                    //  Button button11 = new Button();  
                }
            }
           
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            an(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            an(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            an(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            an(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            an(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            an(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            an(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            an(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            an(9);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            an(0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            char c;
            c = Convert.ToChar(str.Substring(str.Length - 1));
            if ((textBox1.Text.IndexOf(".") < 0) && (r = true)&&(textBox2.Text!="ERROR!")&& (c != '+' && c != '-' && c != '×' && c != '÷'))
            { an("."); }
             if (textBox2.Text == "ERROR!"||c == '+' || c == '-' || c == '×' || c == '÷') { an("0."); }
            // else if (String.IsNullOrEmpty(textBox1.Text) == true) an("0.");
            else { };
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ac("+");p = 1;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            ac("-");p = 2;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            ac("×");p = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ac("÷");p = 4;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            double t2 = 0;
            string str = textBox2.Text;
            char c;
            c = Convert.ToChar(str.Substring(str.Length - 1));
             if (c=='0'||c=='1'||c=='2'||c=='3'||c=='4'||c=='5'||c=='6'||c=='7'||c=='8'||c=='9'||c==')') 
            {
                t2 = Convert.ToDouble(textBox1.Text);
                //else { t2 = 0; textBox2.Text = "ERROR!"; }
                switch (p)
                {
                    case 0:
                        {
                            textBox2.Text = "ERROR!";
                            break;
                        }
                    case 1:
                        {
                            textBox2.Text = (t1 + t2).ToString();
                            textBox1.Text = (t1 + t2).ToString();
                            //   r = false;
                            p = 0; break;
                        }
                    case 2:
                        {
                            textBox2.Text = (t1 - t2).ToString();
                            textBox1.Text = (t1 - t2).ToString(); p = 0; break;
                        }
                    case 3:
                        {
                            textBox2.Text = (t1 * t2).ToString();
                            textBox1.Text = (t1 * t2).ToString(); p = 0; break;
                        }
                    case 4:
                        {
                            if (t2 != 0)
                            {
                                textBox2.Text = (t1 / t2).ToString();
                                textBox1.Text = (t1 / t2).ToString(); p = 0; break;
                            }
                            else
                            {
                                textBox1.Text = "";
                                textBox2.Text = "ERROR!";
                                p = 0;
                                break;
                            }
                        }
                }
            }
            else if(c=='+'||c=='-'||c=='×'||c=='÷'){ textBox2.Text = "ERROR!"; textBox1.Text = "0"; p = 0; }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "0" && textBox2.Text != "ERROR!")
            {
                string str = textBox2.Text;
                char c;
                c = Convert.ToChar(str.Substring(str.Length - 1));
                if (c == '+' || c == '-' || c == '×' || c == '÷')
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    p = 0;
                    w = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                }
            }
            if (textBox2.Text == "") textBox2.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            p = 0;
            t1 = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //this.SetStyle(ControlStyles.UserPaint |
            //   ControlStyles.AllPaintingInWmPaint |
            //   ControlStyles.OptimizedDoubleBuffer, true);
            //this.UpdateStyles();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
          //  TextRenderer.DrawText(pevent.Graphics, this.textBox2.Text, this.Font, new Point(5, 5), this.ForeColor);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox1.Text = "0";
            // textBox2.Enabled = false;
           // textBox2.ForeColor = Color.MediumBlue;
           // textBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            /* textBox1.Text = textBox1.Text.Insert(0, "-");
             if (textBox2.Text.IndexOf("+") < 0 && textBox2.Text.IndexOf("-") < 0 && textBox2.Text.IndexOf("×") < 0 && textBox2.Text.IndexOf("÷") < 0)
             {
                 textBox2.Text = textBox2.Text.Insert(0, "-(");
                 textBox2.Text = textBox2.Text.Insert(textBox2.Text.Length, ")");
             }
             else if (textBox2.Text.IndexOf("+") == 1)
             {
                 textBox2.Text = textBox2.Text.Insert(textBox2.Text.IndexOf("+") + 1, "(-");
                 textBox2.Text = textBox2.Text.Insert(textBox2.Text.Length, ")");
             }
             else if (textBox2.Text.IndexOf("×") == 1)
             {
                 textBox2.Text = textBox2.Text.Insert(textBox2.Text.IndexOf("+") + 1, "(-");
                 textBox2.Text = textBox2.Text.Insert(textBox2.Text.Length, ")");
             }
             else if (textBox2.Text.IndexOf("÷") == 1)
             {
                 textBox2.Text = textBox2.Text.Insert(textBox2.Text.IndexOf("+") + 1, "(-");
                 textBox2.Text = textBox2.Text.Insert(textBox2.Text.Length, ")");
             }
             else if (textBox2.Text.IndexOf("-") >= 0)
             {
                 string str = textBox2.Text;
                 char c,h;
                 c = Convert.ToChar(str.Substring(0,1));
                 h= Convert.ToChar(str.Substring(str.Length - 1));
                 //MessageBox.Show(str.Substring(0,1));
                 if (c != '-')
                 {
                     if()
                     textBox2.Text = textBox2.Text.Insert(textBox2.Text.IndexOf("-") + 1, "(-");
                    // textBox2.Text = textBox2.Text.Insert(textBox2.Text.Length, "");
                 }
                else if (c == '-'-)
                 {
                     textBox2.Text = textBox2.Text.Replace(textBox2.Text, "-()");
                     textBox1.Text = textBox1.Text.Insert(0, "-");
                 }
             }*/
            MessageBox.Show("SORRY\n此按钮尚未开发~~\n敬请期待~~\nps:\n   (好吧，我坦白）\n  （其实我就是懒得写了)\n   (先将就的用哇~)\n   (=.=b)\n\t\t---by.jwj~");
        }
    }
}
