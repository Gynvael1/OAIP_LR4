using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ОАИП_ЛР4_Малых;

namespace SortingStrategy
{
    public partial class MainForm : Form
    {
        private int[] currentArray;
        private readonly Context context;
        private BackgroundWorker sortingWorker;
        private BackgroundWorker analysisWorker;
        private StringBuilder logBuilder = new StringBuilder();
        private bool isSorted = false;

        public MainForm()
        {
            InitializeComponent();
            context = new Context(new BubbleSort());
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            trackBar_Generate.Minimum = 2;
            trackBar_Generate.Maximum = 50;
            trackBar_Generate.Value = 10;
            textBox_Generate.Text = trackBar_Generate.Value.ToString();

            trackBar_Generate.Scroll += trackBar_Generate_Scroll;
            textBox_Generate.TextChanged += textBox_Generate_TextChanged;

            dataGridView_Analysis.Columns.Clear();
            dataGridView_Analysis.Columns.Add("CountCol", "Объем выборки");
            dataGridView_Analysis.Columns.Add("BubbleCol", "Метод обмена (С/П/Время)");
            dataGridView_Analysis.Columns.Add("ShellCol", "Метод Шелла (С/П/Время)");

            sortingWorker = new BackgroundWorker { WorkerReportsProgress = true };
            sortingWorker.DoWork += SortingWorker_DoWork;
            sortingWorker.ProgressChanged += SortingWorker_ProgressChanged;
            sortingWorker.RunWorkerCompleted += SortingWorker_RunWorkerCompleted;

            analysisWorker = new BackgroundWorker { WorkerReportsProgress = true };
            analysisWorker.DoWork += AnalysisWorker_DoWork;
            analysisWorker.ProgressChanged += AnalysisWorker_ProgressChanged;
            analysisWorker.RunWorkerCompleted += AnalysisWorker_RunWorkerCompleted;

            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
        }

        private void trackBar_Generate_Scroll(object sender, EventArgs e)
        {
            textBox_Generate.Text = trackBar_Generate.Value.ToString();
        }

        private void textBox_Generate_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Generate.Text, out int value) && value >= 2 && value <= 50)
                trackBar_Generate.Value = value;
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            GenerateArray();
            isSorted = false;
            MenuFileSave.Enabled = false;
        }

        private void GenerateArray()
        {
            currentArray = new int[trackBar_Generate.Value];
            var rnd = new Random();
            for (int i = 0; i < currentArray.Length; i++)
                currentArray[i] = rnd.Next(-999, 1000);

            textBox_ArrayWork.Clear();
            logBuilder.Clear();
            logBuilder.AppendLine($"Исходный массив: {string.Join(" ", currentArray)}");
            textBox_ArrayWork.Text = logBuilder.ToString();
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (!radioButton_Bubble.Checked && !radioButton_Shell.Checked)
            {
                MessageBox.Show("Выберите метод сортировки!");
                return;
            }

            if (currentArray == null || currentArray.Length == 0)
            {
                MessageBox.Show("Сгенерируйте или загрузите массив!");
                return;
            }

            context.Strategy = radioButton_Bubble.Checked
                ? (IStrategy)new BubbleSort()
                : (IStrategy)new ShellSort();

            logBuilder.Clear();
            logBuilder.AppendLine($"Исходный массив: {string.Join(" ", currentArray)}");
            logBuilder.AppendLine($"\nНачало сортировки методом {(radioButton_Bubble.Checked ? "Обмена" : "Шелла")}:");

            textBox_ArrayWork.Text = logBuilder.ToString();
            sortingWorker.RunWorkerAsync();
        }

        private void SortingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            context.Array = (int[])currentArray.Clone();
            context.Execute(msg =>
            {
                logBuilder.AppendLine(msg);
                sortingWorker.ReportProgress(0, msg);
            }, out int comparisons, out int permutations);

            sw.Stop();
            e.Result = new object[] { comparisons, permutations, sw.Elapsed };
        }

        private void SortingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBox_ArrayWork.AppendText($"{e.UserState}\n");
        }

        private void SortingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show($"Ошибка: {e.Error.Message}");
                return;
            }

            var result = (object[])e.Result;
            textBox_Comparisons.Text = result[0].ToString();
            textBox_Permutations.Text = result[1].ToString();
            textBox_Time.Text = ((TimeSpan)result[2]).ToString(@"hh\:mm\:ss\.fff");

            logBuilder.AppendLine($"\nОтсортированный массив: {string.Join(" ", context.Array)}");

            textBox_ArrayWork.Text = logBuilder.ToString();
            isSorted = true;
            MenuFileSave.Enabled = true;
            
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog1.FileName);
                    string[] elements = content.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    currentArray = Array.ConvertAll(elements, s => int.Parse(s.Trim()));
                    textBox_ArrayWork.Text = $"Загруженный массив:\n{string.Join(" ", currentArray)}";
                    isSorted = false;
                    MenuFileSave.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки: {ex.Message}");
                }
            }
        }

        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            if (!isSorted || logBuilder.Length == 0)
            {
                MessageBox.Show("Сначала выполните сортировку!");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                File.WriteAllText(filePath, logBuilder.ToString());

                string fileName = Path.GetFileName(filePath);

                MessageBox.Show($"Файл сохранен: {fileName}", "Сохранение завершено");
            }
        }

        private void button_Analysis_Click(object sender, EventArgs e)
        {
            dataGridView_Analysis.Rows.Clear();
            button_Analysis.Enabled = false;
            label_AnalisStatus.Text = "Производится анализ...";
            dataGridView_Analysis.Rows.Clear();
            analysisWorker.RunWorkerAsync();
        }

        private void AnalysisWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] sizes = { 10, 100, 1000, 10000, 100000 };
            foreach (int size in sizes)
            {
                int[] testArray = GenerateTestArray(size);
                var bubbleResult = AnalyzeSorting(testArray, new BubbleSort());
                var shellResult = AnalyzeSorting(testArray, new ShellSort());
                analysisWorker.ReportProgress(0, new AnalysisResult(size, bubbleResult, shellResult));
            }
        }

        private AnalysisData AnalyzeSorting(int[] array, IStrategy strategy)
        {
            int[] clone = (int[])array.Clone();
            var sw = Stopwatch.StartNew();
            strategy.Algorithm(clone, null, out int comp, out int perm);
            sw.Stop();
            return new AnalysisData(comp, perm, sw.Elapsed);
        }

        private void AnalysisWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var result = (AnalysisResult)e.UserState;
            dataGridView_Analysis.Rows.Add(
                result.Size,
                $"C: {result.Bubble.Comparisons} П: {result.Bubble.Permutations} t: {result.Bubble.Time}",
                $"C: {result.Shell.Comparisons} П: {result.Shell.Permutations} t: {result.Shell.Time}"
            );
        }

        private void AnalysisWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label_AnalisStatus.Text = "Анализ завершен";
            UpdateAnalysisLabels();
        }

        private void UpdateAnalysisLabels()
        {
            int maxBubbleComp = 0, minShellComp = int.MaxValue;
            int worstSize = 0, bestSize = 0;

            foreach (DataGridViewRow row in dataGridView_Analysis.Rows)
            {
                if (row.Cells["BubbleCol"].Value != null)
                {
                    string[] parts = row.Cells["BubbleCol"].Value.ToString().Split(' ');
                    int comp = int.Parse(parts[1]);
                    if (comp > maxBubbleComp)
                    {
                        maxBubbleComp = comp;
                        worstSize = (int)row.Cells["CountCol"].Value;
                    }
                }

                if (row.Cells["ShellCol"].Value != null)
                {
                    string[] parts = row.Cells["ShellCol"].Value.ToString().Split(' ');
                    int comp = int.Parse(parts[1]);
                    if (comp < minShellComp)
                    {
                        minShellComp = comp;
                        bestSize = (int)row.Cells["CountCol"].Value;
                    }
                }
            }

            label_Analis1.Text = $"Метод обмена: {maxBubbleComp} сравнений (худший для {worstSize} элементов)";
            label_Analis2.Text = $"Метод Шелла: {minShellComp} сравнений (лучший для {bestSize} элементов)";
        }

        private int[] GenerateTestArray(int size)
        {
            var arr = new int[size];
            var rnd = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(-9999, 10000);
            return arr;
        }
    }

    public class AnalysisResult
    {
        public int Size { get; }
        public AnalysisData Bubble { get; }
        public AnalysisData Shell { get; }

        public AnalysisResult(int size, AnalysisData bubble, AnalysisData shell)
        {
            Size = size;
            Bubble = bubble;
            Shell = shell;
        }
    }

    public class AnalysisData
    {
        public int Comparisons { get; }
        public int Permutations { get; }
        public string Time { get; }

        public AnalysisData(int comp, int perm, TimeSpan time)
        {
            Comparisons = comp;
            Permutations = perm;
            Time = time.ToString(@"hh\:mm\:ss\.fff");
        }
    }

}