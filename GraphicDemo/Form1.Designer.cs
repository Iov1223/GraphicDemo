﻿namespace GraphicDemo
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxChoiseDir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxChoiseDir
            // 
            this.comboBoxChoiseDir.FormattingEnabled = true;
            this.comboBoxChoiseDir.Items.AddRange(new object[] {
            "От края до края",
            "Синусойдный",
            "По периметру"});
            this.comboBoxChoiseDir.Location = new System.Drawing.Point(12, 12);
            this.comboBoxChoiseDir.Name = "comboBoxChoiseDir";
            this.comboBoxChoiseDir.Size = new System.Drawing.Size(203, 24);
            this.comboBoxChoiseDir.TabIndex = 0;
            this.comboBoxChoiseDir.Text = "Выбор направления";
            this.comboBoxChoiseDir.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiseDir_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 449);
            this.Controls.Add(this.comboBoxChoiseDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxChoiseDir;
    }
}

