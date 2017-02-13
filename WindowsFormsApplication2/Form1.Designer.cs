namespace WindowsFormsApplication2
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelPictureGraf2 = new System.Windows.Forms.Label();
            this.labelPictureGraf1 = new System.Windows.Forms.Label();
            this.Resbutt = new System.Windows.Forms.Button();
            this.clearbutt = new System.Windows.Forms.Button();
            this.labelFO2 = new System.Windows.Forms.Label();
            this.labelFO1 = new System.Windows.Forms.Label();
            this.labelG2 = new System.Windows.Forms.Label();
            this.labelG1 = new System.Windows.Forms.Label();
            this.textBoxGraf2ValueG = new System.Windows.Forms.TextBox();
            this.textBoxGraf1ValueG = new System.Windows.Forms.TextBox();
            this.labelGraf2 = new System.Windows.Forms.Label();
            this.labelGraf1 = new System.Windows.Forms.Label();
            this.labelMFO = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.radioButtonScreen = new System.Windows.Forms.RadioButton();
            this.labelEnterValue = new System.Windows.Forms.Label();
            this.delete_versh1 = new System.Windows.Forms.TextBox();
            this.delete_versh2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_diamGr1 = new System.Windows.Forms.Label();
            this.textBox_diam1 = new System.Windows.Forms.TextBox();
            this.textBox_diam2 = new System.Windows.Forms.TextBox();
            this.label_diamGr2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(400, 80);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 23);
            this.buttonExit.TabIndex = 152;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelPictureGraf2
            // 
            this.labelPictureGraf2.AutoSize = true;
            this.labelPictureGraf2.Location = new System.Drawing.Point(604, 97);
            this.labelPictureGraf2.Name = "labelPictureGraf2";
            this.labelPictureGraf2.Size = new System.Drawing.Size(103, 13);
            this.labelPictureGraf2.TabIndex = 151;
            this.labelPictureGraf2.Text = "Рисунок графа №2";
            // 
            // labelPictureGraf1
            // 
            this.labelPictureGraf1.AutoSize = true;
            this.labelPictureGraf1.Location = new System.Drawing.Point(54, 97);
            this.labelPictureGraf1.Name = "labelPictureGraf1";
            this.labelPictureGraf1.Size = new System.Drawing.Size(103, 13);
            this.labelPictureGraf1.TabIndex = 150;
            this.labelPictureGraf1.Text = "Рисунок графа №1";
            // 
            // Resbutt
            // 
            this.Resbutt.Location = new System.Drawing.Point(400, 27);
            this.Resbutt.Name = "Resbutt";
            this.Resbutt.Size = new System.Drawing.Size(120, 23);
            this.Resbutt.TabIndex = 143;
            this.Resbutt.Text = "Поиск";
            this.Resbutt.UseVisualStyleBackColor = true;
            // 
            // clearbutt
            // 
            this.clearbutt.Location = new System.Drawing.Point(400, 56);
            this.clearbutt.Name = "clearbutt";
            this.clearbutt.Size = new System.Drawing.Size(120, 23);
            this.clearbutt.TabIndex = 149;
            this.clearbutt.Text = "Очистить все поля";
            this.clearbutt.UseVisualStyleBackColor = true;
            // 
            // labelFO2
            // 
            this.labelFO2.AutoSize = true;
            this.labelFO2.Location = new System.Drawing.Point(695, 32);
            this.labelFO2.Name = "labelFO2";
            this.labelFO2.Size = new System.Drawing.Size(67, 13);
            this.labelFO2.TabIndex = 148;
            this.labelFO2.Text = "Массив MFI";
            this.labelFO2.Click += new System.EventHandler(this.labelMFI2_Click);
            // 
            // labelFO1
            // 
            this.labelFO1.AutoSize = true;
            this.labelFO1.Location = new System.Drawing.Point(152, 32);
            this.labelFO1.Name = "labelFO1";
            this.labelFO1.Size = new System.Drawing.Size(67, 13);
            this.labelFO1.TabIndex = 147;
            this.labelFO1.Text = "Массив MFI";
            this.labelFO1.Click += new System.EventHandler(this.labelMFI1_Click);
            // 
            // labelG2
            // 
            this.labelG2.AutoSize = true;
            this.labelG2.Location = new System.Drawing.Point(577, 51);
            this.labelG2.Name = "labelG2";
            this.labelG2.Size = new System.Drawing.Size(30, 13);
            this.labelG2.TabIndex = 137;
            this.labelG2.Text = "G2 =";
            this.labelG2.Click += new System.EventHandler(this.labelG2_Click);
            // 
            // labelG1
            // 
            this.labelG1.AutoSize = true;
            this.labelG1.Location = new System.Drawing.Point(25, 51);
            this.labelG1.Name = "labelG1";
            this.labelG1.Size = new System.Drawing.Size(30, 13);
            this.labelG1.TabIndex = 135;
            this.labelG1.Text = "G1 =";
            this.labelG1.Click += new System.EventHandler(this.labelG1_Click);
            // 
            // textBoxGraf2ValueG
            // 
            this.textBoxGraf2ValueG.Location = new System.Drawing.Point(607, 48);
            this.textBoxGraf2ValueG.Name = "textBoxGraf2ValueG";
            this.textBoxGraf2ValueG.Size = new System.Drawing.Size(291, 20);
            this.textBoxGraf2ValueG.TabIndex = 136;
            // 
            // textBoxGraf1ValueG
            // 
            this.textBoxGraf1ValueG.Location = new System.Drawing.Point(57, 48);
            this.textBoxGraf1ValueG.Name = "textBoxGraf1ValueG";
            this.textBoxGraf1ValueG.Size = new System.Drawing.Size(291, 20);
            this.textBoxGraf1ValueG.TabIndex = 130;
            this.textBoxGraf1ValueG.TextChanged += new System.EventHandler(this.textBoxGraf1ValueG_TextChanged_1);
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
            this.labelGraf1.Click += new System.EventHandler(this.labelGraf1_Click);
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
            // delete_versh1
            // 
            this.delete_versh1.Location = new System.Drawing.Point(183, 74);
            this.delete_versh1.Name = "delete_versh1";
            this.delete_versh1.Size = new System.Drawing.Size(165, 20);
            this.delete_versh1.TabIndex = 165;
            // 
            // delete_versh2
            // 
            this.delete_versh2.Location = new System.Drawing.Point(733, 74);
            this.delete_versh2.Name = "delete_versh2";
            this.delete_versh2.Size = new System.Drawing.Size(165, 20);
            this.delete_versh2.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 167;
            this.label1.Text = "Удаленные вершины:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 168;
            this.label2.Text = "Удаленные вершины:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_diamGr1
            // 
            this.label_diamGr1.AutoSize = true;
            this.label_diamGr1.Location = new System.Drawing.Point(12, 358);
            this.label_diamGr1.Name = "label_diamGr1";
            this.label_diamGr1.Size = new System.Drawing.Size(257, 13);
            this.label_diamGr1.TabIndex = 169;
            this.label_diamGr1.Text = "Диаметр графа после удаления висячих вершин:";
            // 
            // textBox_diam1
            // 
            this.textBox_diam1.Location = new System.Drawing.Point(284, 355);
            this.textBox_diam1.Name = "textBox_diam1";
            this.textBox_diam1.Size = new System.Drawing.Size(64, 20);
            this.textBox_diam1.TabIndex = 170;
            // 
            // textBox_diam2
            // 
            this.textBox_diam2.Location = new System.Drawing.Point(849, 352);
            this.textBox_diam2.Name = "textBox_diam2";
            this.textBox_diam2.Size = new System.Drawing.Size(64, 20);
            this.textBox_diam2.TabIndex = 172;
            // 
            // label_diamGr2
            // 
            this.label_diamGr2.AutoSize = true;
            this.label_diamGr2.Location = new System.Drawing.Point(577, 355);
            this.label_diamGr2.Name = "label_diamGr2";
            this.label_diamGr2.Size = new System.Drawing.Size(257, 13);
            this.label_diamGr2.TabIndex = 171;
            this.label_diamGr2.Text = "Диаметр графа после удаления висячих вершин:";
            this.label_diamGr2.Click += new System.EventHandler(this.label_diam2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 406);
            this.Controls.Add(this.textBox_diam2);
            this.Controls.Add(this.label_diamGr2);
            this.Controls.Add(this.textBox_diam1);
            this.Controls.Add(this.label_diamGr1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_versh2);
            this.Controls.Add(this.delete_versh1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelPictureGraf2);
            this.Controls.Add(this.labelPictureGraf1);
            this.Controls.Add(this.Resbutt);
            this.Controls.Add(this.clearbutt);
            this.Controls.Add(this.labelFO2);
            this.Controls.Add(this.labelFO1);
            this.Controls.Add(this.labelG2);
            this.Controls.Add(this.labelG1);
            this.Controls.Add(this.textBoxGraf2ValueG);
            this.Controls.Add(this.textBoxGraf1ValueG);
            this.Controls.Add(this.labelGraf2);
            this.Controls.Add(this.labelGraf1);
            this.Controls.Add(this.labelMFO);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.radioButtonScreen);
            this.Controls.Add(this.labelEnterValue);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelPictureGraf2;
        private System.Windows.Forms.Label labelPictureGraf1;
        private System.Windows.Forms.Button Resbutt;
        private System.Windows.Forms.Button clearbutt;
        private System.Windows.Forms.Label labelFO2;
        private System.Windows.Forms.Label labelFO1;
        private System.Windows.Forms.Label labelG2;
        private System.Windows.Forms.Label labelG1;
        private System.Windows.Forms.TextBox textBoxGraf2ValueG;
        private System.Windows.Forms.TextBox textBoxGraf1ValueG;
        private System.Windows.Forms.Label labelGraf2;
        private System.Windows.Forms.Label labelGraf1;
        private System.Windows.Forms.Label labelMFO;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RadioButton radioButtonScreen;
        private System.Windows.Forms.Label labelEnterValue;
        private System.Windows.Forms.TextBox delete_versh1;
        private System.Windows.Forms.TextBox delete_versh2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_diamGr1;
        private System.Windows.Forms.TextBox textBox_diam1;
        private System.Windows.Forms.TextBox textBox_diam2;
        private System.Windows.Forms.Label label_diamGr2;
    }
}

