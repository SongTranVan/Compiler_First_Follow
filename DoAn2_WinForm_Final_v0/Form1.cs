using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn2_WinForm_Final_v0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VanPham vp = new VanPham();
        bool checkvetrai = true;
        bool checkvephai = true;
        string loivetrai = "";
        string loivephai = "";

        public void resetSetting()
        {
            findfirstbt.Enabled = false;
            findfollowbt.Enabled = false;
            richTextBoxkq.Clear();
            findfirsttxt.Clear();
        }
        //enter non terminal symbol
        private void addnotendsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            string tmp = newnotendsymtxt.Text;
            if (newnotendsymtxt.Text.Contains(" "))
            {
                MessageBox.Show("Symbol can not add Blanks", "Error");
                newnotendsymtxt.ResetText();
            }
            else if (newnotendsymtxt.TextLength == 0)
            {
                MessageBox.Show("Symbol can not be empty", "Error");
                newnotendsymtxt.ResetText();
            }
            else if (listBoxNonTerminalSym.Items.Contains(tmp))
            {
                MessageBox.Show("Symbol can not be duplicate", "Error");
                newnotendsymtxt.ResetText();
            }
            else
            {
                listBoxNonTerminalSym.Items.Add(newnotendsymtxt.Text);
                newnotendsymtxt.ResetText();
            }
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Close();
        }

        //enter terminal symbol
        private void addendsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            string tmp = newendsymtxt.Text;
            if (newendsymtxt.Text.Contains(" "))
            {
                MessageBox.Show("Symbol can not add Blanks", "Error");
                newendsymtxt.ResetText();
            }
            else if (newendsymtxt.TextLength == 0)
            {
                MessageBox.Show("Symbol can not be empty", "Error");
                newendsymtxt.ResetText();
            }
            else if (listBoxTerminalSym.Items.Contains(tmp))
            {
                MessageBox.Show("Symbol can not be duplicate", "Error");
                newendsymtxt.ResetText();
            }
            else
            {
                listBoxTerminalSym.Items.Add(newendsymtxt.Text);
                newendsymtxt.ResetText();
            }
        }

        private void addstartsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            if (addstartsymtxt.TextLength >= 2)
            {
                MessageBox.Show("Only have one Start Symbol", "Error");
            }
            else
            {
                startsymtxt.ResetText();
                startsymtxt.Text = addstartsymtxt.Text;
                addstartsymtxt.ResetText();
            }
        }

        private void resetstartsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            startsymtxt.ResetText();
            addstartsymtxt.ResetText();
        }

        private void addprobt_Click(object sender, EventArgs e)
        {
            resetSetting();
            char[] c = new char[] { ' ' };
            string[] tmprightsize = endtxt.Text.Split(c, StringSplitOptions.RemoveEmptyEntries);
            if (starttxt.Text.Contains(" "))
            {
                MessageBox.Show("Only have one Start Symbol and can not have Blanks");
            }
            else if (tmprightsize.Length == 0)
            {
                MessageBox.Show("Right Size can not empty");
            }
            else
            {
                string tmp_startsym = "";
                string arrow_sym = "-->";
                string tmp_endsym = "";
                string tmp_prod = "";
                tmp_startsym = starttxt.Text;
                tmp_endsym = endtxt.Text;
                tmp_prod = tmp_startsym +" "+ arrow_sym + " "+ tmp_endsym;
                listBoxProductions.Items.Add(tmp_prod);
                starttxt.ResetText();
                endtxt.ResetText();
            }
        }

        private void deleteprobt_Click(object sender, EventArgs e)
        {
            resetSetting();
            while (listBoxProductions.SelectedIndices.Count != 0)
            {
                listBoxProductions.Items.RemoveAt(listBoxProductions.SelectedIndices[0]);
            }
        }

        private void resetprobt_Click(object sender, EventArgs e)
        {
            resetSetting();
            listBoxProductions.Items.Clear();
        }

        private void checkbt_Click(object sender, EventArgs e)
        {
            //dua cac khckt vao van pham
            vp.nonterminal = new List<string>();
            for (int i = 0; i < listBoxNonTerminalSym.Items.Count; i++)
            {
                vp.nonterminal.Add(listBoxNonTerminalSym.Items[i].ToString());
            }

            //dua cac khkt vao van pham
            vp.terminal = new List<string>();
            for (int i = 0; i < listBoxTerminalSym.Items.Count; i++)
            {
                vp.terminal.Add(listBoxTerminalSym.Items[i].ToString());
            }
            //dua khbd vao van pham
            vp.startsymbol = startsymtxt.Text;
            //lay so san xuat
            vp.numberofproduction = listBoxProductions.Items.Count;

            //khoi tao cac san xuat
            vp.production = new SanXuat[vp.numberofproduction];
            char[] c = new char[] { ' ' };
            for (int i = 0; i < vp.numberofproduction; i++)
            {
                string tmpvetrai = "";
                string[] tach;

                //xu ly cho ve trai
                string tmp = listBoxProductions.Items[i].ToString();
                for (int p = 0; p < tmp.IndexOf(">") - 3; p++)
                {
                    tmpvetrai += tmp[p];
                }
                vp.production[i].vetrai = tmpvetrai;

                //xu ly cho ve phai
                //tao string de luu cac ky tu sau dau -->
                string tmp3 = "";
                for (int j = tmp.IndexOf(">") + 2; j < tmp.Length; j++)
                {
                    tmp3 += tmp[j];
                }
                //xoa dau cach
                tach = tmp3.Split(c, StringSplitOptions.RemoveEmptyEntries);
                //dem so ky hieu ve phai
                vp.production[i].sokhvephai = tach.Length;
                vp.production[i].vephai = new string[vp.production[i].sokhvephai];
                //dua lan luot cac ky hieu vao
                for (int k = 0; k < vp.production[i].sokhvephai; k++)
                {
                    vp.production[i].vephai[k] = tach[k];
                }
            }

            //kiem tra cac ky hieu o ve phai da duoc dinh nghia hay chua
            for (int l =0; l < vp.numberofproduction; l++)
            {
                foreach (string obj in vp.production[l].vephai)
                {
                    if (vp.terminal.Contains(obj) || vp.nonterminal.Contains(obj) || "epl".Contains(obj))
                    {
                        checkvephai = true;
                    }
                    else
                    {
                        loivephai = obj + " is undefined Symbol! ";
                        checkvephai = false;
                        break; //thoat vong lap foreach
                    }                    
                }
                if (checkvephai == false) break; //thoat vong lap for
            }

            //kiem tra cac ky hieu o ve trai da dc dinh nghia hay chua
            foreach (SanXuat obj in vp.production)
            {
                if ((!vp.nonterminal.Contains(obj.vetrai)))
                {
                    loivetrai = obj.vetrai + " is undefined Symbol! ";
                    checkvetrai = false;
                    break;
                }
                else
                {
                    checkvetrai = true;
                }
            }
            if ((checkvetrai == false) && (checkvephai == false)) vp.loi = loivetrai + " " + loivephai; 
            else if ((checkvetrai == false) && (checkvephai == true)) vp.loi = loivetrai;
            else if ((checkvetrai == true) && (checkvephai == false)) vp.loi = loivephai;
            if (vp.kiemtratinhdung() == true && checkvetrai == true && checkvephai == true)
            {
                MessageBox.Show("Compile Success","Success");
                findfirstbt.Enabled = true;
                findfollowbt.Enabled = true;
                richTextBoxkq.Clear();
            }
            else
            {
                MessageBox.Show(vp.loi, "Error");
            }


        }

        private void deletenotendsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            while (listBoxNonTerminalSym.SelectedIndices.Count != 0)
            {
                listBoxNonTerminalSym.Items.RemoveAt(listBoxNonTerminalSym.SelectedIndices[0]);
            }
        }

        private void resetnotendsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            listBoxNonTerminalSym.Items.Clear();
        }

        private void deleteendsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            while (listBoxTerminalSym.SelectedIndices.Count != 0)
            {
                listBoxTerminalSym.Items.RemoveAt(listBoxTerminalSym.SelectedIndices[0]);
            }
        }

        private void resetendsymbt_Click(object sender, EventArgs e)
        {
            resetSetting();
            listBoxTerminalSym.Items.Clear();
        }

        private void findfirstbt_Click(object sender, EventArgs e)
        {         
            if (findfirsttxt.Text == null)
            {
                MessageBox.Show("Please enter value to find First");
            }
            else
            {
                richTextBoxkq.Clear();
                string[] tachkq;
                char[] c = new char[] { ' ' };
                tachkq = findfirsttxt.Text.Split(c, StringSplitOptions.RemoveEmptyEntries);
                if (vp.terminal.Contains(tachkq[0]))
                    richTextBoxkq.Text = "First(" + findfirsttxt.Text.Trim() + "): " + tachkq[0] + "\n";
                else
                {
                    if (vp.timfirst(tachkq[0]) == "")
                        MessageBox.Show("Wrong value! Please enter again!");
                    else
                    richTextBoxkq.Text = "First(" + findfirsttxt.Text.Trim() + "): " + String.Format("{0,5}", vp.timfirst(tachkq[0])) + "\n";
                }
            }
        }

        private void findfollowbt_Click(object sender, EventArgs e)
        {
            richTextBoxkq.Clear();
            string ketqua = "";
            foreach (string obj in vp.nonterminal)
                ketqua += "Follow(" + obj + "): " + String.Format("{0,5}",vp.timfollow(obj)) + "\n";
            richTextBoxkq.Text = ketqua;
        }
    }
}
