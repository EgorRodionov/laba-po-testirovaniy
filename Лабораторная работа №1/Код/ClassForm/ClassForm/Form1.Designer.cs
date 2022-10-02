
namespace ClassForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoText = new System.Windows.Forms.RichTextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.LabelInputSizeArray = new System.Windows.Forms.Label();
            this.lengthArr = new System.Windows.Forms.TextBox();
            this.AddSizeArr = new System.Windows.Forms.Button();
            this.AddFullMassBtn = new System.Windows.Forms.Button();
            this.fullMassText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelInputFullMass = new System.Windows.Forms.Label();
            this.AddElementArr = new System.Windows.Forms.Button();
            this.ElemText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelInputIndex = new System.Windows.Forms.Label();
            this.SearchIndexBtn = new System.Windows.Forms.Button();
            this.InputIndex = new System.Windows.Forms.TextBox();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.InputElemForMulti = new System.Windows.Forms.TextBox();
            this.labelMultiplication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.Location = new System.Drawing.Point(539, 55);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(249, 334);
            this.InfoText.TabIndex = 0;
            this.InfoText.Text = "";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(694, 395);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(94, 29);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(539, 32);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(102, 20);
            this.Info.TabIndex = 2;
            this.Info.Text = "Информация";
            // 
            // LabelInputSizeArray
            // 
            this.LabelInputSizeArray.AutoSize = true;
            this.LabelInputSizeArray.Location = new System.Drawing.Point(12, 55);
            this.LabelInputSizeArray.Name = "LabelInputSizeArray";
            this.LabelInputSizeArray.Size = new System.Drawing.Size(183, 20);
            this.LabelInputSizeArray.TabIndex = 3;
            this.LabelInputSizeArray.Text = "Введите размер массива";
            // 
            // lengthArr
            // 
            this.lengthArr.Location = new System.Drawing.Point(12, 78);
            this.lengthArr.Multiline = true;
            this.lengthArr.Name = "lengthArr";
            this.lengthArr.Size = new System.Drawing.Size(113, 46);
            this.lengthArr.TabIndex = 4;
            // 
            // AddSizeArr
            // 
            this.AddSizeArr.Location = new System.Drawing.Point(131, 78);
            this.AddSizeArr.Name = "AddSizeArr";
            this.AddSizeArr.Size = new System.Drawing.Size(94, 46);
            this.AddSizeArr.TabIndex = 5;
            this.AddSizeArr.Text = "Добавить";
            this.AddSizeArr.UseVisualStyleBackColor = true;
            this.AddSizeArr.Click += new System.EventHandler(this.AddSizeArr_Click);
            // 
            // AddFullMassBtn
            // 
            this.AddFullMassBtn.Location = new System.Drawing.Point(396, 78);
            this.AddFullMassBtn.Name = "AddFullMassBtn";
            this.AddFullMassBtn.Size = new System.Drawing.Size(94, 46);
            this.AddFullMassBtn.TabIndex = 9;
            this.AddFullMassBtn.Text = "Добавить";
            this.AddFullMassBtn.UseVisualStyleBackColor = true;
            this.AddFullMassBtn.Click += new System.EventHandler(this.AddFullMassBtn_Click);
            // 
            // fullMassText
            // 
            this.fullMassText.Location = new System.Drawing.Point(277, 78);
            this.fullMassText.Multiline = true;
            this.fullMassText.Name = "fullMassText";
            this.fullMassText.Size = new System.Drawing.Size(113, 46);
            this.fullMassText.TabIndex = 8;
            this.fullMassText.Text = "1,2,3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ИЛИ";
            // 
            // LabelInputFullMass
            // 
            this.LabelInputFullMass.AutoSize = true;
            this.LabelInputFullMass.Location = new System.Drawing.Point(277, 55);
            this.LabelInputFullMass.Name = "LabelInputFullMass";
            this.LabelInputFullMass.Size = new System.Drawing.Size(154, 20);
            this.LabelInputFullMass.TabIndex = 11;
            this.LabelInputFullMass.Text = "Введите весь массив";
            // 
            // AddElementArr
            // 
            this.AddElementArr.Location = new System.Drawing.Point(131, 161);
            this.AddElementArr.Name = "AddElementArr";
            this.AddElementArr.Size = new System.Drawing.Size(94, 46);
            this.AddElementArr.TabIndex = 13;
            this.AddElementArr.Text = "Добавить";
            this.AddElementArr.UseVisualStyleBackColor = true;
            this.AddElementArr.Click += new System.EventHandler(this.AddElementArr_Click);
            // 
            // ElemText
            // 
            this.ElemText.Location = new System.Drawing.Point(12, 161);
            this.ElemText.Multiline = true;
            this.ElemText.Name = "ElemText";
            this.ElemText.Size = new System.Drawing.Size(113, 46);
            this.ElemText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите элементы массива";
            // 
            // LabelInputIndex
            // 
            this.LabelInputIndex.AutoSize = true;
            this.LabelInputIndex.Location = new System.Drawing.Point(12, 222);
            this.LabelInputIndex.Name = "LabelInputIndex";
            this.LabelInputIndex.Size = new System.Drawing.Size(246, 20);
            this.LabelInputIndex.TabIndex = 15;
            this.LabelInputIndex.Text = "Введите номер элемента массива";
            // 
            // SearchIndexBtn
            // 
            this.SearchIndexBtn.Location = new System.Drawing.Point(131, 245);
            this.SearchIndexBtn.Name = "SearchIndexBtn";
            this.SearchIndexBtn.Size = new System.Drawing.Size(94, 46);
            this.SearchIndexBtn.TabIndex = 17;
            this.SearchIndexBtn.Text = "Найти";
            this.SearchIndexBtn.UseVisualStyleBackColor = true;
            this.SearchIndexBtn.Click += new System.EventHandler(this.SearchIndexBtn_Click);
            // 
            // InputIndex
            // 
            this.InputIndex.Location = new System.Drawing.Point(12, 245);
            this.InputIndex.Multiline = true;
            this.InputIndex.Name = "InputIndex";
            this.InputIndex.Size = new System.Drawing.Size(113, 46);
            this.InputIndex.TabIndex = 16;
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(131, 343);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(94, 46);
            this.AnswerBtn.TabIndex = 20;
            this.AnswerBtn.Text = "Решить";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // InputElemForMulti
            // 
            this.InputElemForMulti.Location = new System.Drawing.Point(12, 343);
            this.InputElemForMulti.Multiline = true;
            this.InputElemForMulti.Name = "InputElemForMulti";
            this.InputElemForMulti.Size = new System.Drawing.Size(113, 46);
            this.InputElemForMulti.TabIndex = 19;
            // 
            // labelMultiplication
            // 
            this.labelMultiplication.AutoSize = true;
            this.labelMultiplication.Location = new System.Drawing.Point(12, 320);
            this.labelMultiplication.Name = "labelMultiplication";
            this.labelMultiplication.Size = new System.Drawing.Size(421, 20);
            this.labelMultiplication.TabIndex = 18;
            this.labelMultiplication.Text = "Введите элементы массива для вычисления произведения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.InputElemForMulti);
            this.Controls.Add(this.labelMultiplication);
            this.Controls.Add(this.SearchIndexBtn);
            this.Controls.Add(this.InputIndex);
            this.Controls.Add(this.LabelInputIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddElementArr);
            this.Controls.Add(this.ElemText);
            this.Controls.Add(this.LabelInputFullMass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFullMassBtn);
            this.Controls.Add(this.fullMassText);
            this.Controls.Add(this.AddSizeArr);
            this.Controls.Add(this.lengthArr);
            this.Controls.Add(this.LabelInputSizeArray);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.InfoText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoText;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label LabelInputSizeArray;
        private System.Windows.Forms.TextBox lengthArr;
        private System.Windows.Forms.Button AddSizeArr;
        private System.Windows.Forms.Button AddFullMassBtn;
        private System.Windows.Forms.TextBox fullMassText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelInputFullMass;
        private System.Windows.Forms.Button AddElementArr;
        private System.Windows.Forms.TextBox ElemText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelInputIndex;
        private System.Windows.Forms.Button SearchIndexBtn;
        private System.Windows.Forms.TextBox InputIndex;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.TextBox InputElemForMulti;
        private System.Windows.Forms.Label labelMultiplication;
        private System.Windows.Forms.Label label;
    }
}

