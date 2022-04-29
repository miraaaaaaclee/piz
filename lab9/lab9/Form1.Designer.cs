namespace lab9
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
            this.btn = new System.Windows.Forms.Button();
            this.pct = new System.Windows.Forms.PictureBox();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.txt = new System.Windows.Forms.TextBox();
            this.file2 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(247, 302);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(311, 42);
            this.btn.TabIndex = 0;
            this.btn.Text = "picture";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(34, 38);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(736, 258);
            this.pct.TabIndex = 1;
            this.pct.TabStop = false;
            this.pct.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            this.file1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(247, 350);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(311, 22);
            this.txt.TabIndex = 2;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // file2
            // 
            this.file2.FileOk += new System.ComponentModel.CancelEventHandler(this.file2_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(311, 47);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.SaveFileDialog file2;
        private System.Windows.Forms.Button btnSave;
    }
}

