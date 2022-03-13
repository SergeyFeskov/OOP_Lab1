using System.Windows.Forms;

namespace OOP_Lab2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lineButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rectTriangleButton = new System.Windows.Forms.Button();
            this.legTextBox = new System.Windows.Forms.TextBox();
            this.rightTriangleButton = new System.Windows.Forms.Button();
            this.quadrangalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 386);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.quadrangalButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lineButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.triangleButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rectTriangleButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.legTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rightTriangleButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(329, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 386);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lineButton
            // 
            this.lineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.lineButton, 2);
            this.lineButton.Location = new System.Drawing.Point(39, 20);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(160, 23);
            this.lineButton.TabIndex = 0;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;           
            // 
            // triangleButton
            // 
            this.triangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.triangleButton, 2);
            this.triangleButton.Location = new System.Drawing.Point(39, 84);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(160, 23);
            this.triangleButton.TabIndex = 3;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "High leg size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;           
            // 
            // rectTriangleButton
            // 
            this.rectTriangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rectTriangleButton, 2);
            this.rectTriangleButton.Location = new System.Drawing.Point(39, 148);
            this.rectTriangleButton.Name = "rectTriangleButton";
            this.rectTriangleButton.Size = new System.Drawing.Size(160, 23);
            this.rectTriangleButton.TabIndex = 4;
            this.rectTriangleButton.Text = "Rectangular triangle";
            this.rectTriangleButton.UseVisualStyleBackColor = true;
            this.rectTriangleButton.Click += new System.EventHandler(this.rectTriangleButton_Click);
            // 
            // legTextBox
            // 
            this.legTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legTextBox.Location = new System.Drawing.Point(145, 214);
            this.legTextBox.Name = "legTextBox";
            this.legTextBox.Size = new System.Drawing.Size(90, 20);
            this.legTextBox.TabIndex = 2;
            this.legTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rightTriangleButton
            // 
            this.rightTriangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rightTriangleButton, 2);
            this.rightTriangleButton.Location = new System.Drawing.Point(39, 276);
            this.rightTriangleButton.Name = "rightTriangleButton";
            this.rightTriangleButton.Size = new System.Drawing.Size(160, 23);
            this.rightTriangleButton.TabIndex = 5;
            this.rightTriangleButton.Text = "Right triangle";
            this.rightTriangleButton.UseVisualStyleBackColor = true;
            // 
            // quadrangalButton
            // 
            this.quadrangalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.quadrangalButton, 2);
            this.quadrangalButton.Location = new System.Drawing.Point(39, 341);
            this.quadrangalButton.Name = "quadrangalButton";
            this.quadrangalButton.Size = new System.Drawing.Size(160, 23);
            this.quadrangalButton.TabIndex = 6;
            this.quadrangalButton.Text = "Quadrangal";
            this.quadrangalButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "OOP_Lab1_Feskov";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button lineButton;
        private Label label1;
        private TextBox legTextBox;
        private Button triangleButton;
        private Button rectTriangleButton;
        private Button rightTriangleButton;
        private Button quadrangalButton;
    }
}

