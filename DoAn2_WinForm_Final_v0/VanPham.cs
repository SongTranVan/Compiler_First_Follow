using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn2_WinForm_Final_v0
{
    public class VanPham
    {
        public IList<string> terminal;
        public IList<string> nonterminal;
        public string startsymbol;
        public int numberofproduction;
        public SanXuat[] production;
        public string loi = "";

        public bool kokyhieusudungdaucach()
        {
            foreach (string obj in terminal)
                if (obj.IndexOf(" ") != -1) return false;
            foreach (string obj in nonterminal)
                if (obj.IndexOf(" ") != -1) return false;
            return true;
        }
    
        public bool dasudungkhkt(string s)
        {
            foreach (SanXuat obj in production)
                if (obj.vephai.Contains(s)) return true;
            return false;
        }

        public IList<string> tapkhktchuasudung()
        {
            IList<string> t = new List<string>();
            foreach (string obj in terminal)
                if (!dasudungkhkt(obj)) t.Add(obj);
            return t;
        }

        public bool dasudungkhckt(string s)
        {
            foreach (SanXuat obj in production)
                if (obj.vetrai == s) return true;
            if (dasudungkhkt(s)) return true;
            return false;
        }

        public IList<string> tapkhcktchuasudung()
        {
            IList<string> t = new List<string>();
            foreach (string obj in nonterminal)
                if (!dasudungkhckt(obj)) t.Add(obj);
            return t;
        }

        public bool kosxvetraibangvephai()
        {
            foreach (SanXuat obj in production)
                if ((obj.vetrai.Trim() == obj.vephai[0].Trim()) && (obj.vephai.Count() == 1)) //Note
                    return false;
            return true;
        }


        public IList<string> tapdatdenduoc()
        {

            IList<string> tddduoc = new List<string>();
            tddduoc.Add(startsymbol);
            for (int k = 0; k < tddduoc.Count; k++)
                for (int i = 0; i < numberofproduction; i++)
                    if (tddduoc[k] == production[i].vetrai)
                        foreach (string objvp in production[i].vephai)
                            if (!tddduoc.Contains(objvp) && (nonterminal.Contains(objvp)))
                                tddduoc.Add(objvp);
            return tddduoc;
        }

        public IList<string> tapkodatdenduoc()
        {
            IList<string> t = new List<string>();
            IList<string> t1 = new List<string>();
            t1 = tapdatdenduoc();
            foreach (string obj in nonterminal)
                if (!t1.Contains(obj)) t.Add(obj);
            return t;
        }

        public bool kiemtratinhdung()
        {
            if (terminal.Count == 0)
            {
                loi = "Terminal Symbols Set is empty";
                return false;
            }
            if (nonterminal.Count == 0)
            {
                loi = "Non Terminal Symbols Set is empty";
                return false;
            }
            if (startsymbol == null)
            {
                loi = "Start Symbol is empty";
                return false;
            }
            if (numberofproduction == 0)
            {
                loi = "Number of Producions is 0";
                return false;
            }
            if (!kokyhieusudungdaucach())
            {
                loi = "Symbols have blanks is available";
                return false;
            }
            //kiem tra tat ca cac ky hieu ket thuc da duoc su dung?
            IList<string> t = new List<string>();
            t = tapkhktchuasudung();
            if (t.Count != 0)
            {
                string tmp = "";
                foreach (string obj in t)
                    tmp += obj;
                loi = tmp + " is not used Terminal Symbol";
                return false;
            }
            //kiem tra tat ca cac ky hieu chua ket thuc da duoc su dung?
            t = tapkhcktchuasudung();
            if (t.Count != 0)
            {
                string tmp = "";
                foreach (string obj in t)
                    tmp += obj;
                loi = tmp + " is not used Non Terminal Symbol";
                return false;
            }
            //kiem tra ve trai = ve phai san xuat?
            if (!kosxvetraibangvephai())
            {
                loi = "Left Size = Right Size";
                return false;
            }

            //kiem tra ky hieu khong dat den duoc?
            t = tapkodatdenduoc();
            if (t.Count != 0)
            {
                string tmp = "";
                foreach (string obj in t)
                tmp += obj;
                loi = tmp + " is unreachable symbol";
                return false;
            }
            return true;
        }
        public string timfirst(string s)
        {
            string kq = "";
            bool ok = true;
            for (int i = 0; i < numberofproduction; i++)
                if ((production[i].vetrai == s) && (nonterminal.Contains(production[i].vephai[0])))
                {
                    ok = false;
                    break;
                }
            if (ok)
            {
                for (int i = 0; i < numberofproduction; i++)
                {
                    if (production[i].vetrai == s)
                    {
                        if (!kq.Contains(production[i].vephai[0]))
                            kq += production[i].vephai[0] + "   ";
                    }
                }
                return kq;
            }
            else
            {
                for (int i = 0; i < numberofproduction; i++)
                {
                    if (production[i].vetrai == s)
                    {
                        if (terminal.Contains(production[i].vephai[0]))
                        {
                            if (!kq.Contains(production[i].vephai[0]))
                                kq += production[i].vephai[0] + "   ";
                        }
                        else
                        {
                            if (!timfirst(production[i].vephai[0]).Contains("epl"))
                            {
                                if (!kq.Contains(timfirst(production[i].vephai[0])))
                                    kq += timfirst(production[i].vephai[0]) + "   ";
                            }
                            else
                            {
                                if (nonterminal.Contains(production[i].vephai[1]))
                                {
                                    string kq1 = timfirst(production[i].vephai[0]);
                                    kq1 = kq1.Replace("   epl   ", "");
                                    if (!kq.Contains(kq1))
                                        kq += kq1 + "   ";
                                    if (!kq.Contains(timfirst(production[i].vephai[1])))
                                        kq += timfirst(production[i].vephai[1]) + "   ";
                                }
                                else
                                {
                                    if (!kq.Contains(timfirst(production[i].vephai[0])))
                                        kq += timfirst(production[i].vephai[0]) + "   ";
                                }
                            }
                        }
                    }
                }
                return kq;
            }
        }
        public string timfollow(string s)
        {
            string kq = "";
            int check = 0;
            if (s == startsymbol)
                kq += "$   ";
            bool ok = true;
            for (int i = 0; i < numberofproduction; i++)
                if ((production[i].vephai.Contains(s)))
                {
                    for (int j = 0; j < production[i].sokhvephai; j++)
                        if (production[i].vephai[j] == s)
                        {
                            if (j == (production[i].sokhvephai - 1) || (nonterminal.Contains(production[i].vephai[j + 1])))
                            {
                                ok = false;
                                check = 1;
                                break;
                            }
                        }
                    if (check == 1) break;
                }
            if (ok)
            {
                for (int i = 0; i < numberofproduction; i++)
                {
                    if ((production[i].vephai.Contains(s)))
                    {
                        for (int j = 0; j < production[i].sokhvephai; j++)
                            if (production[i].vephai[j] == s)
                            {
                                if (!kq.Contains(production[i].vephai[j + 1]))
                                    kq += production[i].vephai[j + 1] + "   ";
                            }

                    }
                }
                return kq;
            }
            else
            {
                for (int i = 0; i < numberofproduction; i++)
                {
                    if ((production[i].vephai.Contains(s)))
                    {
                        for (int j = 0; j < production[i].sokhvephai; j++)
                            if (production[i].vephai[j] == s && j < (production[i].sokhvephai - 1) && (terminal.Contains(production[i].vephai[j + 1])))
                            {
                                if (!kq.Contains(production[i].vephai[j + 1]))
                                    kq += production[i].vephai[j + 1] + "   ";
                            }
                            else
                            {
                                if (production[i].vephai[j] == s && j < (production[i].sokhvephai - 1) && (nonterminal.Contains(production[i].vephai[j + 1])))
                                {
                                    if (!timfirst(production[i].vephai[j + 1]).Contains("epl"))
                                    {
                                        if (!kq.Contains(timfirst(production[i].vephai[j + 1])))
                                            kq += timfirst(production[i].vephai[j + 1]) + "   ";
                                    }
                                    else
                                    {
                                        string kq1 = timfirst(production[i].vephai[j + 1]);
                                        kq1 = kq1.Replace("   epl   ", "");
                                        if (!kq.Contains(kq1))
                                            kq += kq1 + "   ";
                                        if (!kq.Contains(timfollow(production[i].vetrai)))
                                            kq += timfollow(production[i].vetrai) + "   ";
                                    }
                                }
                                if (production[i].vephai[j] == s && j == (production[i].sokhvephai - 1))
                                {
                                    if (s != production[i].vetrai)
                                    {
                                        if (!kq.Contains(timfollow(production[i].vetrai)))
                                            kq += timfollow(production[i].vetrai) + "   ";
                                    }
                                }
                            }
                    }
                }
                return kq;
            }
        }
    }
}
