namespace JTTT
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxTextLookingFor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxConditionType = new System.Windows.Forms.ComboBox();
            this.comboBoxActionType = new System.Windows.Forms.ComboBox();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDeSerialize = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxTasksList = new System.Windows.Forms.ListBox();
            this.checkBoxIsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(78, 75);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(153, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // textBoxTextLookingFor
            // 
            this.textBoxTextLookingFor.Location = new System.Drawing.Point(78, 113);
            this.textBoxTextLookingFor.Name = "textBoxTextLookingFor";
            this.textBoxTextLookingFor.Size = new System.Drawing.Size(153, 20);
            this.textBoxTextLookingFor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsCaseSensitive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxUrl);
            this.groupBox1.Controls.Add(this.textBoxTextLookingFor);
            this.groupBox1.Location = new System.Drawing.Point(18, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxPictureInfo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tekst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Na danej stornie znajduje sie obrazek , ktorego podpis zawiera tresc :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxMail);
            this.groupBox2.Location = new System.Drawing.Point(18, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 148);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBoxInfoEmail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "e-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wyslij na podany adres e-mail wiadomosc ze znalezionym obrazkiem";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(78, 60);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(153, 20);
            this.textBoxMail.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(396, 310);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wybierz typ waunku:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Wybierz typ akcji:";
            // 
            // comboBoxConditionType
            // 
            this.comboBoxConditionType.FormattingEnabled = true;
            this.comboBoxConditionType.Items.AddRange(new object[] {
            "Sprawdź opis obrazka na stronie",
            "Sprawdź nazwę obrazka na stronie"});
            this.comboBoxConditionType.Location = new System.Drawing.Point(80, 395);
            this.comboBoxConditionType.Name = "comboBoxConditionType";
            this.comboBoxConditionType.Size = new System.Drawing.Size(191, 21);
            this.comboBoxConditionType.TabIndex = 10;
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.FormattingEnabled = true;
            this.comboBoxActionType.Items.AddRange(new object[] {
            "Wyślij wiadomość email z załącznikiem",
            "Zapisz plik na dysku w podanej lokalizacji"});
            this.comboBoxActionType.Location = new System.Drawing.Point(80, 439);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(191, 21);
            this.comboBoxActionType.TabIndex = 11;
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(117, 508);
            this.buttonAddToList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(117, 45);
            this.buttonAddToList.TabIndex = 13;
            this.buttonAddToList.Text = "Dodaj do listy";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(632, 228);
            this.buttonDo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(80, 42);
            this.buttonDo.TabIndex = 15;
            this.buttonDo.Text = "Wykonaj!";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(717, 228);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 42);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Czyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDeSerialize
            // 
            this.buttonDeSerialize.Location = new System.Drawing.Point(825, 228);
            this.buttonDeSerialize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeSerialize.Name = "buttonDeSerialize";
            this.buttonDeSerialize.Size = new System.Drawing.Size(78, 19);
            this.buttonDeSerialize.TabIndex = 17;
            this.buttonDeSerialize.Text = "DeSerialize";
            this.buttonDeSerialize.UseVisualStyleBackColor = true;
            this.buttonDeSerialize.Click += new System.EventHandler(this.buttonDeSerialize_Click);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(825, 251);
            this.buttonSerialize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(78, 19);
            this.buttonSerialize.TabIndex = 18;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(99, 483);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(153, 20);
            this.textBoxTaskName.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Wybierz nazwę zadania:";
            // 
            // listBoxTasksList
            // 
            this.listBoxTasksList.FormattingEnabled = true;
            this.listBoxTasksList.Location = new System.Drawing.Point(469, 62);
            this.listBoxTasksList.Name = "listBoxTasksList";
            this.listBoxTasksList.Size = new System.Drawing.Size(324, 95);
            this.listBoxTasksList.TabIndex = 20;
            // 
            // checkBoxIsCaseSensitive
            // 
            this.checkBoxIsCaseSensitive.AutoSize = true;
            this.checkBoxIsCaseSensitive.Location = new System.Drawing.Point(237, 108);
            this.checkBoxIsCaseSensitive.Name = "checkBoxIsCaseSensitive";
            this.checkBoxIsCaseSensitive.Size = new System.Drawing.Size(104, 30);
            this.checkBoxIsCaseSensitive.TabIndex = 5;
            this.checkBoxIsCaseSensitive.Text = "Zwracaj uwagę\r\n na wielkość liter";
            this.checkBoxIsCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 567);
            this.Controls.Add(this.listBoxTasksList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.buttonDeSerialize);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.comboBoxActionType);
            this.Controls.Add(this.comboBoxConditionType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxTextLookingFor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxConditionType;
        private System.Windows.Forms.ComboBox comboBoxActionType;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDeSerialize;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxTasksList;
        private System.Windows.Forms.CheckBox checkBoxIsCaseSensitive;
    }
}

