namespace SortingStrategy
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_AnalisStatus = new System.Windows.Forms.Label();
            this.label_Analis2 = new System.Windows.Forms.Label();
            this.label_Analis1 = new System.Windows.Forms.Label();
            this.button_Analysis = new System.Windows.Forms.Button();
            this.dataGridView_Analysis = new System.Windows.Forms.DataGridView();
            this.CountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BubbleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShellCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_ArrayWork = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.textBox_Permutations = new System.Windows.Forms.TextBox();
            this.textBox_Comparisons = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Sort = new System.Windows.Forms.Button();
            this.radioButton_Shell = new System.Windows.Forms.RadioButton();
            this.radioButton_Bubble = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Generate = new System.Windows.Forms.Button();
            this.trackBar_Generate = new System.Windows.Forms.TrackBar();
            this.textBox_Generate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.pages = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Analysis)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Generate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label_AnalisStatus);
            this.tabPage2.Controls.Add(this.label_Analis2);
            this.tabPage2.Controls.Add(this.label_Analis1);
            this.tabPage2.Controls.Add(this.button_Analysis);
            this.tabPage2.Controls.Add(this.dataGridView_Analysis);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сравнительный анализ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_AnalisStatus
            // 
            this.label_AnalisStatus.Location = new System.Drawing.Point(48, 199);
            this.label_AnalisStatus.Name = "label_AnalisStatus";
            this.label_AnalisStatus.Size = new System.Drawing.Size(108, 80);
            this.label_AnalisStatus.TabIndex = 5;
            // 
            // label_Analis2
            // 
            this.label_Analis2.Location = new System.Drawing.Point(71, 469);
            this.label_Analis2.Name = "label_Analis2";
            this.label_Analis2.Size = new System.Drawing.Size(961, 64);
            this.label_Analis2.TabIndex = 4;
            // 
            // label_Analis1
            // 
            this.label_Analis1.Location = new System.Drawing.Point(71, 371);
            this.label_Analis1.Name = "label_Analis1";
            this.label_Analis1.Size = new System.Drawing.Size(961, 71);
            this.label_Analis1.TabIndex = 3;
            // 
            // button_Analysis
            // 
            this.button_Analysis.Location = new System.Drawing.Point(48, 101);
            this.button_Analysis.Name = "button_Analysis";
            this.button_Analysis.Size = new System.Drawing.Size(108, 64);
            this.button_Analysis.TabIndex = 2;
            this.button_Analysis.Text = "Начать анализ";
            this.button_Analysis.UseVisualStyleBackColor = true;
            this.button_Analysis.Click += new System.EventHandler(this.button_Analysis_Click);
            // 
            // dataGridView_Analysis
            // 
            this.dataGridView_Analysis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_Analysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Analysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountCol,
            this.BubbleCol,
            this.ShellCol});
            this.dataGridView_Analysis.Location = new System.Drawing.Point(185, 46);
            this.dataGridView_Analysis.Name = "dataGridView_Analysis";
            this.dataGridView_Analysis.RowHeadersWidth = 51;
            this.dataGridView_Analysis.RowTemplate.Height = 24;
            this.dataGridView_Analysis.Size = new System.Drawing.Size(875, 306);
            this.dataGridView_Analysis.TabIndex = 0;
            // 
            // CountCol
            // 
            this.CountCol.HeaderText = "Объем выборки";
            this.CountCol.MinimumWidth = 6;
            this.CountCol.Name = "CountCol";
            this.CountCol.ReadOnly = true;
            this.CountCol.Width = 125;
            // 
            // BubbleCol
            // 
            this.BubbleCol.HeaderText = "Метод обмена";
            this.BubbleCol.MinimumWidth = 6;
            this.BubbleCol.Name = "BubbleCol";
            this.BubbleCol.ReadOnly = true;
            this.BubbleCol.Width = 300;
            // 
            // ShellCol
            // 
            this.ShellCol.HeaderText = "Метод Шелла";
            this.ShellCol.MinimumWidth = 6;
            this.ShellCol.Name = "ShellCol";
            this.ShellCol.ReadOnly = true;
            this.ShellCol.Width = 300;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_ArrayWork);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сортировка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_ArrayWork
            // 
            this.textBox_ArrayWork.Location = new System.Drawing.Point(325, 40);
            this.textBox_ArrayWork.Name = "textBox_ArrayWork";
            this.textBox_ArrayWork.ReadOnly = true;
            this.textBox_ArrayWork.Size = new System.Drawing.Size(785, 496);
            this.textBox_ArrayWork.TabIndex = 10;
            this.textBox_ArrayWork.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Time);
            this.groupBox3.Controls.Add(this.textBox_Permutations);
            this.groupBox3.Controls.Add(this.textBox_Comparisons);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 161);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные о сортировке";
            // 
            // textBox_Time
            // 
            this.textBox_Time.Location = new System.Drawing.Point(140, 121);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.ReadOnly = true;
            this.textBox_Time.Size = new System.Drawing.Size(137, 22);
            this.textBox_Time.TabIndex = 5;
            // 
            // textBox_Permutations
            // 
            this.textBox_Permutations.Location = new System.Drawing.Point(140, 78);
            this.textBox_Permutations.Name = "textBox_Permutations";
            this.textBox_Permutations.ReadOnly = true;
            this.textBox_Permutations.Size = new System.Drawing.Size(137, 22);
            this.textBox_Permutations.TabIndex = 4;
            // 
            // textBox_Comparisons
            // 
            this.textBox_Comparisons.Location = new System.Drawing.Point(140, 38);
            this.textBox_Comparisons.Name = "textBox_Comparisons";
            this.textBox_Comparisons.ReadOnly = true;
            this.textBox_Comparisons.Size = new System.Drawing.Size(137, 22);
            this.textBox_Comparisons.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Перестановки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сравнения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Sort);
            this.groupBox2.Controls.Add(this.radioButton_Shell);
            this.groupBox2.Controls.Add(this.radioButton_Bubble);
            this.groupBox2.Location = new System.Drawing.Point(19, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Метод сортировки";
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(162, 32);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(100, 46);
            this.button_Sort.TabIndex = 2;
            this.button_Sort.Text = "Начать сортировку";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // radioButton_Shell
            // 
            this.radioButton_Shell.AutoSize = true;
            this.radioButton_Shell.Location = new System.Drawing.Point(20, 58);
            this.radioButton_Shell.Name = "radioButton_Shell";
            this.radioButton_Shell.Size = new System.Drawing.Size(116, 20);
            this.radioButton_Shell.TabIndex = 1;
            this.radioButton_Shell.TabStop = true;
            this.radioButton_Shell.Text = "Метод Шелла";
            this.radioButton_Shell.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bubble
            // 
            this.radioButton_Bubble.AutoSize = true;
            this.radioButton_Bubble.Location = new System.Drawing.Point(20, 32);
            this.radioButton_Bubble.Name = "radioButton_Bubble";
            this.radioButton_Bubble.Size = new System.Drawing.Size(122, 20);
            this.radioButton_Bubble.TabIndex = 0;
            this.radioButton_Bubble.TabStop = true;
            this.radioButton_Bubble.Text = "Метод обмена";
            this.radioButton_Bubble.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Generate);
            this.groupBox1.Controls.Add(this.trackBar_Generate);
            this.groupBox1.Controls.Add(this.textBox_Generate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 190);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация массива";
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(65, 140);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(148, 35);
            this.button_Generate.TabIndex = 3;
            this.button_Generate.Text = "Сгенерировать";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // trackBar_Generate
            // 
            this.trackBar_Generate.Location = new System.Drawing.Point(6, 30);
            this.trackBar_Generate.Maximum = 50;
            this.trackBar_Generate.Minimum = 2;
            this.trackBar_Generate.Name = "trackBar_Generate";
            this.trackBar_Generate.Size = new System.Drawing.Size(271, 56);
            this.trackBar_Generate.TabIndex = 2;
            this.trackBar_Generate.Value = 2;
            this.trackBar_Generate.Scroll += new System.EventHandler(this.trackBar_Generate_Scroll);
            // 
            // textBox_Generate
            // 
            this.textBox_Generate.Location = new System.Drawing.Point(151, 103);
            this.textBox_Generate.Name = "textBox_Generate";
            this.textBox_Generate.Size = new System.Drawing.Size(100, 22);
            this.textBox_Generate.TabIndex = 1;
            this.textBox_Generate.Text = "2";
            this.textBox_Generate.TextChanged += new System.EventHandler(this.textBox_Generate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во элеметов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip_File";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileOpen,
            this.MenuFileSave});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(59, 24);
            this.MenuFile.Text = "Файл";
            // 
            // MenuFileOpen
            // 
            this.MenuFileOpen.Name = "MenuFileOpen";
            this.MenuFileOpen.Size = new System.Drawing.Size(166, 26);
            this.MenuFileOpen.Text = "Загрузить";
            this.MenuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // MenuFileSave
            // 
            this.MenuFileSave.Name = "MenuFileSave";
            this.MenuFileSave.Size = new System.Drawing.Size(166, 26);
            this.MenuFileSave.Text = "Сохранить";
            this.MenuFileSave.Click += new System.EventHandler(this.MenuFileSave_Click);
            // 
            // pages
            // 
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.Location = new System.Drawing.Point(0, 0);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1243, 585);
            this.pages.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 585);
            this.Controls.Add(this.pages);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Analysis)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Generate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Analysis;
        private System.Windows.Forms.DataGridView dataGridView_Analysis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.TextBox textBox_Permutations;
        private System.Windows.Forms.TextBox textBox_Comparisons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.RadioButton radioButton_Shell;
        private System.Windows.Forms.RadioButton radioButton_Bubble;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.TrackBar trackBar_Generate;
        private System.Windows.Forms.TextBox textBox_Generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFileSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BubbleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShellCol;
        private System.Windows.Forms.Label label_Analis1;
        private System.Windows.Forms.Label label_Analis2;
        private System.Windows.Forms.Label label_AnalisStatus;
        private System.Windows.Forms.RichTextBox textBox_ArrayWork;
    }
}

