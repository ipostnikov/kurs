namespace KursovoiProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_exit = new System.Windows.Forms.Button();
            this.labelPictureGraf2 = new System.Windows.Forms.Label();
            this.labelPictureGraf1 = new System.Windows.Forms.Label();
            this.Resbutt = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.labelFO2 = new System.Windows.Forms.Label();
            this.labelFO1 = new System.Windows.Forms.Label();
            this.labelG2 = new System.Windows.Forms.Label();
            this.labelG1 = new System.Windows.Forms.Label();
            this.tb_v2 = new System.Windows.Forms.TextBox();
            this.tb_v1 = new System.Windows.Forms.TextBox();
            this.labelGraf2 = new System.Windows.Forms.Label();
            this.labelGraf1 = new System.Windows.Forms.Label();
            this.labelMFO = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.radioButtonScreen = new System.Windows.Forms.RadioButton();
            this.labelEnterValue = new System.Windows.Forms.Label();
            this.tb_dv1 = new System.Windows.Forms.TextBox();
            this.tb_dv2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_diamGr1 = new System.Windows.Forms.Label();
            this.tb_d1 = new System.Windows.Forms.TextBox();
            this.tb_d2 = new System.Windows.Forms.TextBox();
            this.label_diamGr2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_res1 = new System.Windows.Forms.TabPage();
            this.rtb_res1 = new System.Windows.Forms.RichTextBox();
            this.tab_picture1 = new System.Windows.Forms.TabPage();
            this.GViever1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_res2 = new System.Windows.Forms.TabPage();
            this.rtb_res2 = new System.Windows.Forms.RichTextBox();
            this.tab_pict2 = new System.Windows.Forms.TabPage();
            this.GViever2 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.rb_manual = new System.Windows.Forms.RadioButton();
            this.rb_file = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_e2 = new System.Windows.Forms.TextBox();
            this.tb_e1 = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tab_res1.SuspendLayout();
            this.tab_picture1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tab_res2.SuspendLayout();
            this.tab_pict2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(411, 181);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(120, 23);
            this.b_exit.TabIndex = 152;
            this.b_exit.Text = "Выход";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // labelPictureGraf2
            // 
            this.labelPictureGraf2.AutoSize = true;
            this.labelPictureGraf2.Location = new System.Drawing.Point(606, 126);
            this.labelPictureGraf2.Name = "labelPictureGraf2";
            this.labelPictureGraf2.Size = new System.Drawing.Size(103, 13);
            this.labelPictureGraf2.TabIndex = 151;
            this.labelPictureGraf2.Text = "Рисунок графа №2";
            // 
            // labelPictureGraf1
            // 
            this.labelPictureGraf1.AutoSize = true;
            this.labelPictureGraf1.Location = new System.Drawing.Point(12, 126);
            this.labelPictureGraf1.Name = "labelPictureGraf1";
            this.labelPictureGraf1.Size = new System.Drawing.Size(103, 13);
            this.labelPictureGraf1.TabIndex = 150;
            this.labelPictureGraf1.Text = "Рисунок графа №1";
            // 
            // Resbutt
            // 
            this.Resbutt.Location = new System.Drawing.Point(411, 106);
            this.Resbutt.Name = "Resbutt";
            this.Resbutt.Size = new System.Drawing.Size(120, 23);
            this.Resbutt.TabIndex = 143;
            this.Resbutt.Text = "Поиск";
            this.Resbutt.UseVisualStyleBackColor = true;
            this.Resbutt.Click += new System.EventHandler(this.Resbutt_Click);
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(411, 142);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(120, 23);
            this.b_clear.TabIndex = 149;
            this.b_clear.Text = "Очистить все поля";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // labelFO2
            // 
            this.labelFO2.AutoSize = true;
            this.labelFO2.Location = new System.Drawing.Point(695, 32);
            this.labelFO2.Name = "labelFO2";
            this.labelFO2.Size = new System.Drawing.Size(67, 13);
            this.labelFO2.TabIndex = 148;
            this.labelFO2.Text = "Массив MFI";
            // 
            // labelFO1
            // 
            this.labelFO1.AutoSize = true;
            this.labelFO1.Location = new System.Drawing.Point(152, 32);
            this.labelFO1.Name = "labelFO1";
            this.labelFO1.Size = new System.Drawing.Size(67, 13);
            this.labelFO1.TabIndex = 147;
            this.labelFO1.Text = "Массив MFI";
            // 
            // labelG2
            // 
            this.labelG2.AutoSize = true;
            this.labelG2.Location = new System.Drawing.Point(566, 51);
            this.labelG2.Name = "labelG2";
            this.labelG2.Size = new System.Drawing.Size(37, 13);
            this.labelG2.TabIndex = 137;
            this.labelG2.Text = "VG2 =";
            // 
            // labelG1
            // 
            this.labelG1.AutoSize = true;
            this.labelG1.Location = new System.Drawing.Point(14, 51);
            this.labelG1.Name = "labelG1";
            this.labelG1.Size = new System.Drawing.Size(37, 13);
            this.labelG1.TabIndex = 135;
            this.labelG1.Text = "VG1 =";
            // 
            // tb_v2
            // 
            this.tb_v2.Location = new System.Drawing.Point(607, 48);
            this.tb_v2.Name = "tb_v2";
            this.tb_v2.Size = new System.Drawing.Size(291, 20);
            this.tb_v2.TabIndex = 136;
            // 
            // tb_v1
            // 
            this.tb_v1.Location = new System.Drawing.Point(57, 48);
            this.tb_v1.Name = "tb_v1";
            this.tb_v1.Size = new System.Drawing.Size(291, 20);
            this.tb_v1.TabIndex = 130;
            // 
            // labelGraf2
            // 
            this.labelGraf2.AutoSize = true;
            this.labelGraf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraf2.Location = new System.Drawing.Point(695, 7);
            this.labelGraf2.Name = "labelGraf2";
            this.labelGraf2.Size = new System.Drawing.Size(60, 13);
            this.labelGraf2.TabIndex = 125;
            this.labelGraf2.Text = "Граф №2";
            // 
            // labelGraf1
            // 
            this.labelGraf1.AutoSize = true;
            this.labelGraf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraf1.Location = new System.Drawing.Point(152, 7);
            this.labelGraf1.Name = "labelGraf1";
            this.labelGraf1.Size = new System.Drawing.Size(60, 13);
            this.labelGraf1.TabIndex = 124;
            this.labelGraf1.Text = "Граф №1";
            // 
            // labelMFO
            // 
            this.labelMFO.AutoSize = true;
            this.labelMFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMFO.Location = new System.Drawing.Point(307, -122);
            this.labelMFO.Name = "labelMFO";
            this.labelMFO.Size = new System.Drawing.Size(315, 25);
            this.labelMFO.TabIndex = 123;
            this.labelMFO.Text = "FO - представление графов";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(337, -86);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(257, 26);
            this.labelInfo.TabIndex = 122;
            this.labelInfo.Text = "            Ввод с файла: \"Ввод данных с файла\"\r\n(поставить галочку) и нажать кно" +
    "пку \"Проверка\"";
            // 
            // radioButtonScreen
            // 
            this.radioButtonScreen.AutoSize = true;
            this.radioButtonScreen.Checked = true;
            this.radioButtonScreen.Location = new System.Drawing.Point(426, -36);
            this.radioButtonScreen.Name = "radioButtonScreen";
            this.radioButtonScreen.Size = new System.Drawing.Size(61, 17);
            this.radioButtonScreen.TabIndex = 120;
            this.radioButtonScreen.TabStop = true;
            this.radioButtonScreen.Text = "экрана";
            this.radioButtonScreen.UseVisualStyleBackColor = true;
            // 
            // labelEnterValue
            // 
            this.labelEnterValue.AutoSize = true;
            this.labelEnterValue.Location = new System.Drawing.Point(423, -52);
            this.labelEnterValue.Name = "labelEnterValue";
            this.labelEnterValue.Size = new System.Drawing.Size(81, 13);
            this.labelEnterValue.TabIndex = 119;
            this.labelEnterValue.Text = "Ввод данных с";
            // 
            // tb_dv1
            // 
            this.tb_dv1.Enabled = false;
            this.tb_dv1.Location = new System.Drawing.Point(185, 103);
            this.tb_dv1.Name = "tb_dv1";
            this.tb_dv1.Size = new System.Drawing.Size(165, 20);
            this.tb_dv1.TabIndex = 165;
            // 
            // tb_dv2
            // 
            this.tb_dv2.Enabled = false;
            this.tb_dv2.Location = new System.Drawing.Point(735, 103);
            this.tb_dv2.Name = "tb_dv2";
            this.tb_dv2.Size = new System.Drawing.Size(165, 20);
            this.tb_dv2.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Удаленные вершины:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 168;
            this.label2.Text = "Удаленные вершины:";
            // 
            // label_diamGr1
            // 
            this.label_diamGr1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_diamGr1.AutoSize = true;
            this.label_diamGr1.Location = new System.Drawing.Point(14, 387);
            this.label_diamGr1.Name = "label_diamGr1";
            this.label_diamGr1.Size = new System.Drawing.Size(257, 13);
            this.label_diamGr1.TabIndex = 169;
            this.label_diamGr1.Text = "Диаметр графа после удаления висячих вершин:";
            // 
            // tb_d1
            // 
            this.tb_d1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_d1.Enabled = false;
            this.tb_d1.Location = new System.Drawing.Point(286, 384);
            this.tb_d1.Name = "tb_d1";
            this.tb_d1.Size = new System.Drawing.Size(64, 20);
            this.tb_d1.TabIndex = 170;
            // 
            // tb_d2
            // 
            this.tb_d2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_d2.Enabled = false;
            this.tb_d2.Location = new System.Drawing.Point(836, 381);
            this.tb_d2.Name = "tb_d2";
            this.tb_d2.Size = new System.Drawing.Size(64, 20);
            this.tb_d2.TabIndex = 172;
            // 
            // label_diamGr2
            // 
            this.label_diamGr2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_diamGr2.AutoSize = true;
            this.label_diamGr2.Location = new System.Drawing.Point(566, 384);
            this.label_diamGr2.Name = "label_diamGr2";
            this.label_diamGr2.Size = new System.Drawing.Size(257, 13);
            this.label_diamGr2.TabIndex = 171;
            this.label_diamGr2.Text = "Диаметр графа после удаления висячих вершин:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_res1);
            this.tabControl1.Controls.Add(this.tab_picture1);
            this.tabControl1.Location = new System.Drawing.Point(15, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 235);
            this.tabControl1.TabIndex = 173;
            // 
            // tab_res1
            // 
            this.tab_res1.Controls.Add(this.rtb_res1);
            this.tab_res1.Location = new System.Drawing.Point(4, 22);
            this.tab_res1.Name = "tab_res1";
            this.tab_res1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_res1.Size = new System.Drawing.Size(392, 209);
            this.tab_res1.TabIndex = 0;
            this.tab_res1.Text = "Решение";
            this.tab_res1.UseVisualStyleBackColor = true;
            // 
            // rtb_res1
            // 
            this.rtb_res1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_res1.Location = new System.Drawing.Point(-2, 0);
            this.rtb_res1.Name = "rtb_res1";
            this.rtb_res1.Size = new System.Drawing.Size(391, 206);
            this.rtb_res1.TabIndex = 0;
            this.rtb_res1.Text = "";
            // 
            // tab_picture1
            // 
            this.tab_picture1.Controls.Add(this.GViever1);
            this.tab_picture1.Location = new System.Drawing.Point(4, 22);
            this.tab_picture1.Name = "tab_picture1";
            this.tab_picture1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_picture1.Size = new System.Drawing.Size(392, 209);
            this.tab_picture1.TabIndex = 1;
            this.tab_picture1.Text = "Рисунок";
            this.tab_picture1.UseVisualStyleBackColor = true;
            // 
            // GViever1
            // 
            this.GViever1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GViever1.ArrowheadLength = 10D;
            this.GViever1.AsyncLayout = false;
            this.GViever1.AutoScroll = true;
            this.GViever1.BackwardEnabled = false;
            this.GViever1.BuildHitTree = true;
            this.GViever1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.GViever1.EdgeInsertButtonVisible = true;
            this.GViever1.FileName = "";
            this.GViever1.ForwardEnabled = false;
            this.GViever1.Graph = null;
            this.GViever1.InsertingEdge = false;
            this.GViever1.LayoutAlgorithmSettingsButtonVisible = true;
            this.GViever1.LayoutEditingEnabled = true;
            this.GViever1.Location = new System.Drawing.Point(0, 0);
            this.GViever1.LooseOffsetForRouting = 0.25D;
            this.GViever1.MouseHitDistance = 0.05D;
            this.GViever1.Name = "GViever1";
            this.GViever1.NavigationVisible = true;
            this.GViever1.NeedToCalculateLayout = true;
            this.GViever1.OffsetForRelaxingInRouting = 0.6D;
            this.GViever1.PaddingForEdgeRouting = 8D;
            this.GViever1.PanButtonPressed = false;
            this.GViever1.SaveAsImageEnabled = true;
            this.GViever1.SaveAsMsaglEnabled = true;
            this.GViever1.SaveButtonVisible = true;
            this.GViever1.SaveGraphButtonVisible = true;
            this.GViever1.SaveInVectorFormatEnabled = true;
            this.GViever1.Size = new System.Drawing.Size(392, 209);
            this.GViever1.TabIndex = 0;
            this.GViever1.TightOffsetForRouting = 0.125D;
            this.GViever1.ToolBarIsVisible = true;
            this.GViever1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("GViever1.Transform")));
            this.GViever1.UndoRedoButtonsVisible = true;
            this.GViever1.WindowZoomButtonPressed = false;
            this.GViever1.ZoomF = 1D;
            this.GViever1.ZoomFraction = 0.5D;
            this.GViever1.ZoomWhenMouseWheelScroll = true;
            this.GViever1.ZoomWindowThreshold = 0.05D;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab_res2);
            this.tabControl2.Controls.Add(this.tab_pict2);
            this.tabControl2.Location = new System.Drawing.Point(609, 142);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(400, 235);
            this.tabControl2.TabIndex = 174;
            // 
            // tab_res2
            // 
            this.tab_res2.Controls.Add(this.rtb_res2);
            this.tab_res2.Location = new System.Drawing.Point(4, 22);
            this.tab_res2.Name = "tab_res2";
            this.tab_res2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_res2.Size = new System.Drawing.Size(392, 209);
            this.tab_res2.TabIndex = 0;
            this.tab_res2.Text = "Решение";
            this.tab_res2.UseVisualStyleBackColor = true;
            // 
            // rtb_res2
            // 
            this.rtb_res2.Location = new System.Drawing.Point(2, 1);
            this.rtb_res2.Name = "rtb_res2";
            this.rtb_res2.Size = new System.Drawing.Size(388, 205);
            this.rtb_res2.TabIndex = 0;
            this.rtb_res2.Text = "";
            // 
            // tab_pict2
            // 
            this.tab_pict2.Controls.Add(this.GViever2);
            this.tab_pict2.Location = new System.Drawing.Point(4, 22);
            this.tab_pict2.Name = "tab_pict2";
            this.tab_pict2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pict2.Size = new System.Drawing.Size(392, 209);
            this.tab_pict2.TabIndex = 1;
            this.tab_pict2.Text = "Рисунок";
            this.tab_pict2.UseVisualStyleBackColor = true;
            // 
            // GViever2
            // 
            this.GViever2.ArrowheadLength = 10D;
            this.GViever2.AsyncLayout = false;
            this.GViever2.AutoScroll = true;
            this.GViever2.BackwardEnabled = false;
            this.GViever2.BuildHitTree = true;
            this.GViever2.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.GViever2.EdgeInsertButtonVisible = true;
            this.GViever2.FileName = "";
            this.GViever2.ForwardEnabled = false;
            this.GViever2.Graph = null;
            this.GViever2.InsertingEdge = false;
            this.GViever2.LayoutAlgorithmSettingsButtonVisible = true;
            this.GViever2.LayoutEditingEnabled = true;
            this.GViever2.Location = new System.Drawing.Point(0, 0);
            this.GViever2.LooseOffsetForRouting = 0.25D;
            this.GViever2.MouseHitDistance = 0.05D;
            this.GViever2.Name = "GViever2";
            this.GViever2.NavigationVisible = true;
            this.GViever2.NeedToCalculateLayout = true;
            this.GViever2.OffsetForRelaxingInRouting = 0.6D;
            this.GViever2.PaddingForEdgeRouting = 8D;
            this.GViever2.PanButtonPressed = false;
            this.GViever2.SaveAsImageEnabled = true;
            this.GViever2.SaveAsMsaglEnabled = true;
            this.GViever2.SaveButtonVisible = true;
            this.GViever2.SaveGraphButtonVisible = true;
            this.GViever2.SaveInVectorFormatEnabled = true;
            this.GViever2.Size = new System.Drawing.Size(392, 213);
            this.GViever2.TabIndex = 0;
            this.GViever2.TightOffsetForRouting = 0.125D;
            this.GViever2.ToolBarIsVisible = true;
            this.GViever2.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("GViever2.Transform")));
            this.GViever2.UndoRedoButtonsVisible = true;
            this.GViever2.WindowZoomButtonPressed = false;
            this.GViever2.ZoomF = 1D;
            this.GViever2.ZoomFraction = 0.5D;
            this.GViever2.ZoomWhenMouseWheelScroll = true;
            this.GViever2.ZoomWindowThreshold = 0.05D;
            // 
            // rb_manual
            // 
            this.rb_manual.AutoSize = true;
            this.rb_manual.Location = new System.Drawing.Point(411, 73);
            this.rb_manual.Name = "rb_manual";
            this.rb_manual.Size = new System.Drawing.Size(87, 17);
            this.rb_manual.TabIndex = 175;
            this.rb_manual.Text = "Ручной ввод";
            this.rb_manual.UseVisualStyleBackColor = true;
            // 
            // rb_file
            // 
            this.rb_file.AutoSize = true;
            this.rb_file.Location = new System.Drawing.Point(411, 50);
            this.rb_file.Name = "rb_file";
            this.rb_file.Size = new System.Drawing.Size(94, 17);
            this.rb_file.TabIndex = 176;
            this.rb_file.Text = "Ввод с файла";
            this.rb_file.UseVisualStyleBackColor = true;
            this.rb_file.CheckedChanged += new System.EventHandler(this.rb_file_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 180;
            this.label3.Text = "EG2 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 178;
            this.label4.Text = "EG1 =";
            // 
            // tb_e2
            // 
            this.tb_e2.Location = new System.Drawing.Point(607, 74);
            this.tb_e2.Name = "tb_e2";
            this.tb_e2.Size = new System.Drawing.Size(291, 20);
            this.tb_e2.TabIndex = 179;
            // 
            // tb_e1
            // 
            this.tb_e1.Location = new System.Drawing.Point(57, 74);
            this.tb_e1.Name = "tb_e1";
            this.tb_e1.Size = new System.Drawing.Size(291, 20);
            this.tb_e1.TabIndex = 177;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_e2);
            this.Controls.Add(this.tb_e1);
            this.Controls.Add(this.rb_file);
            this.Controls.Add(this.rb_manual);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_d2);
            this.Controls.Add(this.label_diamGr2);
            this.Controls.Add(this.tb_d1);
            this.Controls.Add(this.label_diamGr1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dv2);
            this.Controls.Add(this.tb_dv1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.labelPictureGraf2);
            this.Controls.Add(this.labelPictureGraf1);
            this.Controls.Add(this.Resbutt);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.labelFO2);
            this.Controls.Add(this.labelFO1);
            this.Controls.Add(this.labelG2);
            this.Controls.Add(this.labelG1);
            this.Controls.Add(this.tb_v2);
            this.Controls.Add(this.tb_v1);
            this.Controls.Add(this.labelGraf2);
            this.Controls.Add(this.labelGraf1);
            this.Controls.Add(this.labelMFO);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.radioButtonScreen);
            this.Controls.Add(this.labelEnterValue);
            this.Name = "Form1";
            this.Text = "v";
            this.tabControl1.ResumeLayout(false);
            this.tab_res1.ResumeLayout(false);
            this.tab_picture1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tab_res2.ResumeLayout(false);
            this.tab_pict2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label labelPictureGraf2;
        private System.Windows.Forms.Label labelPictureGraf1;
        private System.Windows.Forms.Button Resbutt;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Label labelFO2;
        private System.Windows.Forms.Label labelFO1;
        private System.Windows.Forms.Label labelG2;
        private System.Windows.Forms.Label labelG1;
        private System.Windows.Forms.TextBox tb_v2;
        private System.Windows.Forms.TextBox tb_v1;
        private System.Windows.Forms.Label labelGraf2;
        private System.Windows.Forms.Label labelGraf1;
        private System.Windows.Forms.Label labelMFO;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RadioButton radioButtonScreen;
        private System.Windows.Forms.Label labelEnterValue;
        private System.Windows.Forms.TextBox tb_dv1;
        private System.Windows.Forms.TextBox tb_dv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_diamGr1;
        private System.Windows.Forms.TextBox tb_d1;
        private System.Windows.Forms.TextBox tb_d2;
        private System.Windows.Forms.Label label_diamGr2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_res1;
        private System.Windows.Forms.TabPage tab_picture1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_res2;
        private System.Windows.Forms.TabPage tab_pict2;
        private System.Windows.Forms.RadioButton rb_manual;
        private System.Windows.Forms.RadioButton rb_file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_e2;
        private System.Windows.Forms.TextBox tb_e1;
        private System.Windows.Forms.RichTextBox rtb_res1;
        private System.Windows.Forms.RichTextBox rtb_res2;
        private Microsoft.Msagl.GraphViewerGdi.GViewer GViever1;
        private Microsoft.Msagl.GraphViewerGdi.GViewer GViever2;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

