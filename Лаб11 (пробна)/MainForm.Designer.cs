namespace Lab11_Variant7
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnCreate1 = new System.Windows.Forms.Button();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnCreate2 = new System.Windows.Forms.Button();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.btnDifference = new System.Windows.Forms.Button();
            this.btnCompareGreater = new System.Windows.Forms.Button();
            this.btnCompareLess = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.btnCreateFromNumber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(12, 32);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(200, 20);
            this.txtInput1.TabIndex = 0;
            // 
            // btnCreate1
            // 
            this.btnCreate1.Location = new System.Drawing.Point(218, 30);
            this.btnCreate1.Name = "btnCreate1";
            this.btnCreate1.Size = new System.Drawing.Size(75, 23);
            this.btnCreate1.TabIndex = 1;
            this.btnCreate1.Text = "Створити";
            this.btnCreate1.UseVisualStyleBackColor = true;
            this.btnCreate1.Click += new System.EventHandler(this.btnCreate1_Click);
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Location = new System.Drawing.Point(12, 55);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(77, 13);
            this.lblStatus1.TabIndex = 2;
            this.lblStatus1.Text = "Стрічка 1: ---";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(12, 91);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(200, 20);
            this.txtInput2.TabIndex = 3;
            // 
            // btnCreate2
            // 
            this.btnCreate2.Location = new System.Drawing.Point(218, 89);
            this.btnCreate2.Name = "btnCreate2";
            this.btnCreate2.Size = new System.Drawing.Size(75, 23);
            this.btnCreate2.TabIndex = 4;
            this.btnCreate2.Text = "Створити";
            this.btnCreate2.UseVisualStyleBackColor = true;
            this.btnCreate2.Click += new System.EventHandler(this.btnCreate2_Click);
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(12, 114);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(77, 13);
            this.lblStatus2.TabIndex = 5;
            this.lblStatus2.Text = "Стрічка 2: ---";
            // 
            // btnDifference
            // 
            this.btnDifference.Location = new System.Drawing.Point(12, 190);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(120, 23);
            this.btnDifference.TabIndex = 6;
            this.btnDifference.Text = "Різниця";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // btnCompareGreater
            // 
            this.btnCompareGreater.Location = new System.Drawing.Point(138, 190);
            this.btnCompareGreater.Name = "btnCompareGreater";
            this.btnCompareGreater.Size = new System.Drawing.Size(120, 23);
            this.btnCompareGreater.TabIndex = 7;
            this.btnCompareGreater.Text = "Порівняти (>)";
            this.btnCompareGreater.UseVisualStyleBackColor = true;
            this.btnCompareGreater.Click += new System.EventHandler(this.btnCompareGreater_Click);
            // 
            // btnCompareLess
            // 
            this.btnCompareLess.Location = new System.Drawing.Point(264, 190);
            this.btnCompareLess.Name = "btnCompareLess";
            this.btnCompareLess.Size = new System.Drawing.Size(120, 23);
            this.btnCompareLess.TabIndex = 8;
            this.btnCompareLess.Text = "Порівняти (<)";
            this.btnCompareLess.UseVisualStyleBackColor = true;
            this.btnCompareLess.Click += new System.EventHandler(this.btnCompareLess_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(12, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Результат";
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(299, 30);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 10;
            this.btnClear1.Text = "Очистити";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(299, 89);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(75, 23);
            this.btnClear2.TabIndex = 11;
            this.btnClear2.Text = "Очистити";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(12, 150);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(200, 20);
            this.txtNumberInput.TabIndex = 12;
            // 
            // btnCreateFromNumber
            // 
            this.btnCreateFromNumber.Location = new System.Drawing.Point(218, 148);
            this.btnCreateFromNumber.Name = "btnCreateFromNumber";
            this.btnCreateFromNumber.Size = new System.Drawing.Size(156, 23);
            this.btnCreateFromNumber.TabIndex = 13;
            this.btnCreateFromNumber.Text = "Створити стрічку з числа";
            this.btnCreateFromNumber.UseVisualStyleBackColor = true;
            this.btnCreateFromNumber.Click += new System.EventHandler(this.btnCreateFromNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Десяткова стрічка 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Десяткова стрічка 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Створити стрічку з числа:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateFromNumber);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompareLess);
            this.Controls.Add(this.btnCompareGreater);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.btnCreate2);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.btnCreate1);
            this.Controls.Add(this.txtInput1);
            this.Name = "MainForm";
            this.Text = "Лабораторна робота №11. Варіант 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Button btnCreate1;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnCreate2;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Button btnCompareGreater;
        private System.Windows.Forms.Button btnCompareLess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Button btnCreateFromNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}