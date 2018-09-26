namespace DoAn2_WinForm_Final_v0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.endsymlist = new System.Windows.Forms.TabControl();
            this.nonterminalsym = new System.Windows.Forms.TabPage();
            this.resetnotendsymbt = new System.Windows.Forms.Button();
            this.deletenotendsymbt = new System.Windows.Forms.Button();
            this.listBoxNonTerminalSym = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addnotendsymbt = new System.Windows.Forms.Button();
            this.newnotendsymtxt = new System.Windows.Forms.TextBox();
            this.terminalsym = new System.Windows.Forms.TabPage();
            this.resetendsymbt = new System.Windows.Forms.Button();
            this.deleteendsymbt = new System.Windows.Forms.Button();
            this.listBoxTerminalSym = new System.Windows.Forms.ListBox();
            this.newendsymtxt = new System.Windows.Forms.TextBox();
            this.addendsymbt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startsym = new System.Windows.Forms.TabPage();
            this.addstartsymtxt = new System.Windows.Forms.TextBox();
            this.resetstartsymbt = new System.Windows.Forms.Button();
            this.addstartsymbt = new System.Windows.Forms.Button();
            this.startsymtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productionset = new System.Windows.Forms.TabPage();
            this.listBoxProductions = new System.Windows.Forms.ListBox();
            this.findfirsttxt = new System.Windows.Forms.TextBox();
            this.findfollowbt = new System.Windows.Forms.Button();
            this.findfirstbt = new System.Windows.Forms.Button();
            this.checkbt = new System.Windows.Forms.Button();
            this.deleteprobt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.resetprobt = new System.Windows.Forms.Button();
            this.addprobt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.endtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.starttxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.exitbt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBoxkq = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.endsymlist.SuspendLayout();
            this.nonterminalsym.SuspendLayout();
            this.terminalsym.SuspendLayout();
            this.startsym.SuspendLayout();
            this.productionset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // endsymlist
            // 
            this.endsymlist.Controls.Add(this.nonterminalsym);
            this.endsymlist.Controls.Add(this.terminalsym);
            this.endsymlist.Controls.Add(this.startsym);
            this.endsymlist.Controls.Add(this.productionset);
            this.endsymlist.Location = new System.Drawing.Point(8, 151);
            this.endsymlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endsymlist.Name = "endsymlist";
            this.endsymlist.SelectedIndex = 0;
            this.endsymlist.Size = new System.Drawing.Size(601, 436);
            this.endsymlist.TabIndex = 0;
            // 
            // nonterminalsym
            // 
            this.nonterminalsym.Controls.Add(this.resetnotendsymbt);
            this.nonterminalsym.Controls.Add(this.deletenotendsymbt);
            this.nonterminalsym.Controls.Add(this.listBoxNonTerminalSym);
            this.nonterminalsym.Controls.Add(this.label2);
            this.nonterminalsym.Controls.Add(this.label1);
            this.nonterminalsym.Controls.Add(this.addnotendsymbt);
            this.nonterminalsym.Controls.Add(this.newnotendsymtxt);
            this.nonterminalsym.Location = new System.Drawing.Point(4, 25);
            this.nonterminalsym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonterminalsym.Name = "nonterminalsym";
            this.nonterminalsym.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonterminalsym.Size = new System.Drawing.Size(593, 407);
            this.nonterminalsym.TabIndex = 0;
            this.nonterminalsym.Text = "Non Terminal Symbols";
            this.nonterminalsym.UseVisualStyleBackColor = true;
            // 
            // resetnotendsymbt
            // 
            this.resetnotendsymbt.Location = new System.Drawing.Point(256, 263);
            this.resetnotendsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetnotendsymbt.Name = "resetnotendsymbt";
            this.resetnotendsymbt.Size = new System.Drawing.Size(75, 38);
            this.resetnotendsymbt.TabIndex = 6;
            this.resetnotendsymbt.Text = "Reset";
            this.resetnotendsymbt.UseVisualStyleBackColor = true;
            this.resetnotendsymbt.Click += new System.EventHandler(this.resetnotendsymbt_Click);
            // 
            // deletenotendsymbt
            // 
            this.deletenotendsymbt.Location = new System.Drawing.Point(256, 213);
            this.deletenotendsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deletenotendsymbt.Name = "deletenotendsymbt";
            this.deletenotendsymbt.Size = new System.Drawing.Size(75, 35);
            this.deletenotendsymbt.TabIndex = 5;
            this.deletenotendsymbt.Text = "Delete";
            this.deletenotendsymbt.UseVisualStyleBackColor = true;
            this.deletenotendsymbt.Click += new System.EventHandler(this.deletenotendsymbt_Click);
            // 
            // listBoxNonTerminalSym
            // 
            this.listBoxNonTerminalSym.FormattingEnabled = true;
            this.listBoxNonTerminalSym.ItemHeight = 16;
            this.listBoxNonTerminalSym.Location = new System.Drawing.Point(11, 102);
            this.listBoxNonTerminalSym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxNonTerminalSym.Name = "listBoxNonTerminalSym";
            this.listBoxNonTerminalSym.Size = new System.Drawing.Size(159, 276);
            this.listBoxNonTerminalSym.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Non Terminal Symbols Set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Non Terminal Symbols";
            // 
            // addnotendsymbt
            // 
            this.addnotendsymbt.Location = new System.Drawing.Point(231, 155);
            this.addnotendsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addnotendsymbt.Name = "addnotendsymbt";
            this.addnotendsymbt.Size = new System.Drawing.Size(135, 37);
            this.addnotendsymbt.TabIndex = 1;
            this.addnotendsymbt.Text = "Add New Symbol";
            this.addnotendsymbt.UseVisualStyleBackColor = true;
            this.addnotendsymbt.Click += new System.EventHandler(this.addnotendsymbt_Click);
            // 
            // newnotendsymtxt
            // 
            this.newnotendsymtxt.Location = new System.Drawing.Point(400, 167);
            this.newnotendsymtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newnotendsymtxt.Name = "newnotendsymtxt";
            this.newnotendsymtxt.Size = new System.Drawing.Size(100, 22);
            this.newnotendsymtxt.TabIndex = 0;
            // 
            // terminalsym
            // 
            this.terminalsym.Controls.Add(this.resetendsymbt);
            this.terminalsym.Controls.Add(this.deleteendsymbt);
            this.terminalsym.Controls.Add(this.listBoxTerminalSym);
            this.terminalsym.Controls.Add(this.newendsymtxt);
            this.terminalsym.Controls.Add(this.addendsymbt);
            this.terminalsym.Controls.Add(this.label4);
            this.terminalsym.Controls.Add(this.label3);
            this.terminalsym.Location = new System.Drawing.Point(4, 25);
            this.terminalsym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.terminalsym.Name = "terminalsym";
            this.terminalsym.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.terminalsym.Size = new System.Drawing.Size(593, 407);
            this.terminalsym.TabIndex = 1;
            this.terminalsym.Text = "Terminal Symbols";
            this.terminalsym.UseVisualStyleBackColor = true;
            // 
            // resetendsymbt
            // 
            this.resetendsymbt.Location = new System.Drawing.Point(255, 289);
            this.resetendsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetendsymbt.Name = "resetendsymbt";
            this.resetendsymbt.Size = new System.Drawing.Size(75, 37);
            this.resetendsymbt.TabIndex = 7;
            this.resetendsymbt.Text = "Reset";
            this.resetendsymbt.UseVisualStyleBackColor = true;
            this.resetendsymbt.Click += new System.EventHandler(this.resetendsymbt_Click);
            // 
            // deleteendsymbt
            // 
            this.deleteendsymbt.Location = new System.Drawing.Point(255, 238);
            this.deleteendsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteendsymbt.Name = "deleteendsymbt";
            this.deleteendsymbt.Size = new System.Drawing.Size(75, 35);
            this.deleteendsymbt.TabIndex = 6;
            this.deleteendsymbt.Text = "Delete";
            this.deleteendsymbt.UseVisualStyleBackColor = true;
            this.deleteendsymbt.Click += new System.EventHandler(this.deleteendsymbt_Click);
            // 
            // listBoxTerminalSym
            // 
            this.listBoxTerminalSym.FormattingEnabled = true;
            this.listBoxTerminalSym.ItemHeight = 16;
            this.listBoxTerminalSym.Location = new System.Drawing.Point(9, 100);
            this.listBoxTerminalSym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTerminalSym.Name = "listBoxTerminalSym";
            this.listBoxTerminalSym.Size = new System.Drawing.Size(172, 292);
            this.listBoxTerminalSym.TabIndex = 5;
            // 
            // newendsymtxt
            // 
            this.newendsymtxt.Location = new System.Drawing.Point(380, 185);
            this.newendsymtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newendsymtxt.Name = "newendsymtxt";
            this.newendsymtxt.Size = new System.Drawing.Size(109, 22);
            this.newendsymtxt.TabIndex = 4;
            // 
            // addendsymbt
            // 
            this.addendsymbt.Location = new System.Drawing.Point(229, 178);
            this.addendsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addendsymbt.Name = "addendsymbt";
            this.addendsymbt.Size = new System.Drawing.Size(129, 33);
            this.addendsymbt.TabIndex = 3;
            this.addendsymbt.Text = "Add New Symbol";
            this.addendsymbt.UseVisualStyleBackColor = true;
            this.addendsymbt.Click += new System.EventHandler(this.addendsymbt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Terminal Symbols Set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Terminal Symbols";
            // 
            // startsym
            // 
            this.startsym.Controls.Add(this.addstartsymtxt);
            this.startsym.Controls.Add(this.resetstartsymbt);
            this.startsym.Controls.Add(this.addstartsymbt);
            this.startsym.Controls.Add(this.startsymtxt);
            this.startsym.Controls.Add(this.label6);
            this.startsym.Controls.Add(this.label5);
            this.startsym.Location = new System.Drawing.Point(4, 25);
            this.startsym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startsym.Name = "startsym";
            this.startsym.Size = new System.Drawing.Size(593, 407);
            this.startsym.TabIndex = 0;
            this.startsym.Text = "Start Symbol";
            // 
            // addstartsymtxt
            // 
            this.addstartsymtxt.Location = new System.Drawing.Point(173, 130);
            this.addstartsymtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addstartsymtxt.Name = "addstartsymtxt";
            this.addstartsymtxt.Size = new System.Drawing.Size(111, 22);
            this.addstartsymtxt.TabIndex = 5;
            // 
            // resetstartsymbt
            // 
            this.resetstartsymbt.Location = new System.Drawing.Point(5, 180);
            this.resetstartsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetstartsymbt.Name = "resetstartsymbt";
            this.resetstartsymbt.Size = new System.Drawing.Size(75, 33);
            this.resetstartsymbt.TabIndex = 4;
            this.resetstartsymbt.Text = "Reset";
            this.resetstartsymbt.UseVisualStyleBackColor = true;
            this.resetstartsymbt.Click += new System.EventHandler(this.resetstartsymbt_Click);
            // 
            // addstartsymbt
            // 
            this.addstartsymbt.Location = new System.Drawing.Point(5, 120);
            this.addstartsymbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addstartsymbt.Name = "addstartsymbt";
            this.addstartsymbt.Size = new System.Drawing.Size(131, 36);
            this.addstartsymbt.TabIndex = 3;
            this.addstartsymbt.Text = "Add Start Symbol";
            this.addstartsymbt.UseVisualStyleBackColor = true;
            this.addstartsymbt.Click += new System.EventHandler(this.addstartsymbt_Click);
            // 
            // startsymtxt
            // 
            this.startsymtxt.Enabled = false;
            this.startsymtxt.Location = new System.Drawing.Point(173, 69);
            this.startsymtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startsymtxt.Name = "startsymtxt";
            this.startsymtxt.ReadOnly = true;
            this.startsymtxt.Size = new System.Drawing.Size(111, 22);
            this.startsymtxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Start Symbol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Symbol";
            // 
            // productionset
            // 
            this.productionset.Controls.Add(this.listBoxProductions);
            this.productionset.Controls.Add(this.findfirsttxt);
            this.productionset.Controls.Add(this.findfollowbt);
            this.productionset.Controls.Add(this.findfirstbt);
            this.productionset.Controls.Add(this.checkbt);
            this.productionset.Controls.Add(this.deleteprobt);
            this.productionset.Controls.Add(this.label11);
            this.productionset.Controls.Add(this.resetprobt);
            this.productionset.Controls.Add(this.addprobt);
            this.productionset.Controls.Add(this.label10);
            this.productionset.Controls.Add(this.endtxt);
            this.productionset.Controls.Add(this.label9);
            this.productionset.Controls.Add(this.starttxt);
            this.productionset.Controls.Add(this.label8);
            this.productionset.Controls.Add(this.label7);
            this.productionset.Location = new System.Drawing.Point(4, 25);
            this.productionset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productionset.Name = "productionset";
            this.productionset.Size = new System.Drawing.Size(593, 407);
            this.productionset.TabIndex = 0;
            this.productionset.Text = "Productions Set";
            // 
            // listBoxProductions
            // 
            this.listBoxProductions.FormattingEnabled = true;
            this.listBoxProductions.ItemHeight = 16;
            this.listBoxProductions.Location = new System.Drawing.Point(331, 95);
            this.listBoxProductions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProductions.Name = "listBoxProductions";
            this.listBoxProductions.Size = new System.Drawing.Size(217, 292);
            this.listBoxProductions.TabIndex = 13;
            // 
            // findfirsttxt
            // 
            this.findfirsttxt.Location = new System.Drawing.Point(128, 309);
            this.findfirsttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findfirsttxt.Name = "findfirsttxt";
            this.findfirsttxt.Size = new System.Drawing.Size(105, 22);
            this.findfirsttxt.TabIndex = 12;
            // 
            // findfollowbt
            // 
            this.findfollowbt.Enabled = false;
            this.findfollowbt.Location = new System.Drawing.Point(5, 355);
            this.findfollowbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findfollowbt.Name = "findfollowbt";
            this.findfollowbt.Size = new System.Drawing.Size(99, 36);
            this.findfollowbt.TabIndex = 11;
            this.findfollowbt.Text = "Find Follow";
            this.findfollowbt.UseVisualStyleBackColor = true;
            this.findfollowbt.Click += new System.EventHandler(this.findfollowbt_Click);
            // 
            // findfirstbt
            // 
            this.findfirstbt.Enabled = false;
            this.findfirstbt.Location = new System.Drawing.Point(5, 302);
            this.findfirstbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findfirstbt.Name = "findfirstbt";
            this.findfirstbt.Size = new System.Drawing.Size(99, 37);
            this.findfirstbt.TabIndex = 10;
            this.findfirstbt.Text = "Find First";
            this.findfirstbt.UseVisualStyleBackColor = true;
            this.findfirstbt.Click += new System.EventHandler(this.findfirstbt_Click);
            // 
            // checkbt
            // 
            this.checkbt.Location = new System.Drawing.Point(5, 247);
            this.checkbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbt.Name = "checkbt";
            this.checkbt.Size = new System.Drawing.Size(99, 36);
            this.checkbt.TabIndex = 1;
            this.checkbt.Text = "Check";
            this.checkbt.UseVisualStyleBackColor = true;
            this.checkbt.Click += new System.EventHandler(this.checkbt_Click);
            // 
            // deleteprobt
            // 
            this.deleteprobt.Location = new System.Drawing.Point(109, 164);
            this.deleteprobt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteprobt.Name = "deleteprobt";
            this.deleteprobt.Size = new System.Drawing.Size(75, 31);
            this.deleteprobt.TabIndex = 9;
            this.deleteprobt.Text = "Delete";
            this.deleteprobt.UseVisualStyleBackColor = true;
            this.deleteprobt.Click += new System.EventHandler(this.deleteprobt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Productions";
            // 
            // resetprobt
            // 
            this.resetprobt.Location = new System.Drawing.Point(217, 164);
            this.resetprobt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetprobt.Name = "resetprobt";
            this.resetprobt.Size = new System.Drawing.Size(75, 31);
            this.resetprobt.TabIndex = 6;
            this.resetprobt.Text = "Reset";
            this.resetprobt.UseVisualStyleBackColor = true;
            this.resetprobt.Click += new System.EventHandler(this.resetprobt_Click);
            // 
            // addprobt
            // 
            this.addprobt.Location = new System.Drawing.Point(5, 164);
            this.addprobt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addprobt.Name = "addprobt";
            this.addprobt.Size = new System.Drawing.Size(75, 31);
            this.addprobt.TabIndex = 5;
            this.addprobt.Text = "Add";
            this.addprobt.UseVisualStyleBackColor = true;
            this.addprobt.Click += new System.EventHandler(this.addprobt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Right Size";
            // 
            // endtxt
            // 
            this.endtxt.Location = new System.Drawing.Point(185, 89);
            this.endtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endtxt.Name = "endtxt";
            this.endtxt.Size = new System.Drawing.Size(87, 22);
            this.endtxt.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "-->";
            // 
            // starttxt
            // 
            this.starttxt.Location = new System.Drawing.Point(5, 87);
            this.starttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.starttxt.Name = "starttxt";
            this.starttxt.Size = new System.Drawing.Size(99, 22);
            this.starttxt.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Left Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Productions Set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(811, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Result";
            // 
            // exitbt
            // 
            this.exitbt.Location = new System.Drawing.Point(1088, 548);
            this.exitbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(73, 34);
            this.exitbt.TabIndex = 3;
            this.exitbt.Text = "Exit";
            this.exitbt.UseVisualStyleBackColor = true;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(357, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(524, 38);
            this.label13.TabIndex = 4;
            this.label13.Text = "Find First And Follow Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1077, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(5, 599);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(549, 90);
            this.label14.TabIndex = 7;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(645, 617);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(328, 72);
            this.label15.TabIndex = 8;
            this.label15.Text = "(2) Trước khi nhập các sản xuất, phải nhập\r\n* Tập các ký hiệu chưa kết thúc\r\n* Tậ" +
    "p các ký hiệu kết thúc\r\n* Ký hiệu bắt đầu\r\n";
            // 
            // richTextBoxkq
            // 
            this.richTextBoxkq.Location = new System.Drawing.Point(613, 178);
            this.richTextBoxkq.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxkq.Name = "richTextBoxkq";
            this.richTextBoxkq.ReadOnly = true;
            this.richTextBoxkq.Size = new System.Drawing.Size(467, 408);
            this.richTextBoxkq.TabIndex = 9;
            this.richTextBoxkq.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(9, 713);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(249, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "(3) Ký hiệu ε được viết thành epl\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 772);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.richTextBoxkq);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.endsymlist);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.endsymlist.ResumeLayout(false);
            this.nonterminalsym.ResumeLayout(false);
            this.nonterminalsym.PerformLayout();
            this.terminalsym.ResumeLayout(false);
            this.terminalsym.PerformLayout();
            this.startsym.ResumeLayout(false);
            this.startsym.PerformLayout();
            this.productionset.ResumeLayout(false);
            this.productionset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage nonterminalsym;
        private System.Windows.Forms.TabPage terminalsym;
        private System.Windows.Forms.TabControl endsymlist;
        private System.Windows.Forms.TabPage startsym;
        private System.Windows.Forms.TabPage productionset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addnotendsymbt;
        private System.Windows.Forms.TextBox newnotendsymtxt;
        private System.Windows.Forms.TextBox newendsymtxt;
        private System.Windows.Forms.Button addendsymbt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addstartsymtxt;
        private System.Windows.Forms.Button resetstartsymbt;
        private System.Windows.Forms.Button addstartsymbt;
        private System.Windows.Forms.TextBox startsymtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetprobt;
        private System.Windows.Forms.Button addprobt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox endtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox starttxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deleteprobt;
        private System.Windows.Forms.TextBox findfirsttxt;
        private System.Windows.Forms.Button findfollowbt;
        private System.Windows.Forms.Button findfirstbt;
        private System.Windows.Forms.Button checkbt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button exitbt;
        private System.Windows.Forms.ListBox listBoxNonTerminalSym;
        private System.Windows.Forms.ListBox listBoxTerminalSym;
        private System.Windows.Forms.ListBox listBoxProductions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button resetnotendsymbt;
        private System.Windows.Forms.Button deletenotendsymbt;
        private System.Windows.Forms.Button resetendsymbt;
        private System.Windows.Forms.Button deleteendsymbt;
        private System.Windows.Forms.RichTextBox richTextBoxkq;
        private System.Windows.Forms.Label label16;
    }
}

