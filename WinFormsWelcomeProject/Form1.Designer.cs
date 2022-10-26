namespace WinFormsWelcomeProject
{
    partial class MainForm
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
            this.btnHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnModalForm = new System.Windows.Forms.Button();
            this.btnNotModalForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHello.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHello.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHello.Location = new System.Drawing.Point(175, 170);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(311, 87);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Сказать привет!";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            this.btnHello.MouseEnter += new System.EventHandler(this.btnHello_MouseEnter);
            this.btnHello.MouseLeave += new System.EventHandler(this.btnHello_MouseLeave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(175, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 50);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHello.Location = new System.Drawing.Point(175, 25);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(105, 45);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "label1";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // btnModalForm
            // 
            this.btnModalForm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModalForm.Location = new System.Drawing.Point(35, 339);
            this.btnModalForm.Name = "btnModalForm";
            this.btnModalForm.Size = new System.Drawing.Size(214, 92);
            this.btnModalForm.TabIndex = 3;
            this.btnModalForm.Text = "Открыть модальное окно";
            this.btnModalForm.UseVisualStyleBackColor = true;
            this.btnModalForm.Click += new System.EventHandler(this.btnModalForm_Click);
            // 
            // btnNotModalForm
            // 
            this.btnNotModalForm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotModalForm.Location = new System.Drawing.Point(370, 339);
            this.btnNotModalForm.Name = "btnNotModalForm";
            this.btnNotModalForm.Size = new System.Drawing.Size(214, 92);
            this.btnNotModalForm.TabIndex = 3;
            this.btnNotModalForm.Text = "Открыть немодальное окно";
            this.btnNotModalForm.UseVisualStyleBackColor = true;
            this.btnNotModalForm.Click += new System.EventHandler(this.btnNotModalForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(640, 461);
            this.Controls.Add(this.btnNotModalForm);
            this.Controls.Add(this.btnModalForm);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHello);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.Text = "Первое приложение WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHello;
        private TextBox txtName;
        private Label lblHello;
        private Button btnModalForm;
        private Button btnNotModalForm;
    }
}