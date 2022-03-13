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
            this.circleButton = new System.Windows.Forms.Button();
            this.RadXTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quadrangalButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rectTriangleButton = new System.Windows.Forms.Button();
            this.rightTriangleButton = new System.Windows.Forms.Button();
            this.legTextBox = new System.Windows.Forms.TextBox();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.RadYTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.circleButton, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.RadXTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.quadrangalButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lineButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.triangleButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rectTriangleButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rightTriangleButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.legTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ellipseButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.RadYTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(367, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 386);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // circleButton
            // 
            this.circleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.circleButton, 2);
            this.circleButton.Location = new System.Drawing.Point(20, 321);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(160, 23);
            this.circleButton.TabIndex = 12;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // RadXTextBox
            // 
            this.RadXTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadXTextBox.Location = new System.Drawing.Point(123, 287);
            this.RadXTextBox.Name = "RadXTextBox";
            this.RadXTextBox.Size = new System.Drawing.Size(74, 20);
            this.RadXTextBox.TabIndex = 11;
            this.RadXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Horizontal radius:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quadrangalButton
            // 
            this.quadrangalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.quadrangalButton, 2);
            this.quadrangalButton.Location = new System.Drawing.Point(20, 181);
            this.quadrangalButton.Name = "quadrangalButton";
            this.quadrangalButton.Size = new System.Drawing.Size(160, 23);
            this.quadrangalButton.TabIndex = 6;
            this.quadrangalButton.Text = "Quadrangal";
            this.quadrangalButton.UseVisualStyleBackColor = true;
            this.quadrangalButton.Click += new System.EventHandler(this.quadrangalButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.lineButton, 2);
            this.lineButton.Location = new System.Drawing.Point(20, 6);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(160, 23);
            this.lineButton.TabIndex = 0;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.triangleButton, 2);
            this.triangleButton.Location = new System.Drawing.Point(20, 41);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(160, 23);
            this.triangleButton.TabIndex = 3;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "High leg size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rectTriangleButton
            // 
            this.rectTriangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rectTriangleButton, 2);
            this.rectTriangleButton.Location = new System.Drawing.Point(20, 76);
            this.rectTriangleButton.Name = "rectTriangleButton";
            this.rectTriangleButton.Size = new System.Drawing.Size(160, 23);
            this.rectTriangleButton.TabIndex = 4;
            this.rectTriangleButton.Text = "Rectangular triangle";
            this.rectTriangleButton.UseVisualStyleBackColor = true;
            this.rectTriangleButton.Click += new System.EventHandler(this.rectTriangleButton_Click);
            // 
            // rightTriangleButton
            // 
            this.rightTriangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rightTriangleButton, 2);
            this.rightTriangleButton.Location = new System.Drawing.Point(20, 146);
            this.rightTriangleButton.Name = "rightTriangleButton";
            this.rightTriangleButton.Size = new System.Drawing.Size(160, 23);
            this.rightTriangleButton.TabIndex = 5;
            this.rightTriangleButton.Text = "Right triangle";
            this.rightTriangleButton.UseVisualStyleBackColor = true;
            this.rightTriangleButton.Click += new System.EventHandler(this.rightTriangleButton_Click);
            // 
            // legTextBox
            // 
            this.legTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.legTextBox.Location = new System.Drawing.Point(123, 112);
            this.legTextBox.Name = "legTextBox";
            this.legTextBox.Size = new System.Drawing.Size(74, 20);
            this.legTextBox.TabIndex = 2;
            this.legTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ellipseButton
            // 
            this.ellipseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.ellipseButton, 2);
            this.ellipseButton.Location = new System.Drawing.Point(20, 216);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(160, 23);
            this.ellipseButton.TabIndex = 7;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // RadYTextBox
            // 
            this.RadYTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadYTextBox.Location = new System.Drawing.Point(123, 252);
            this.RadYTextBox.Name = "RadYTextBox";
            this.RadYTextBox.Size = new System.Drawing.Size(74, 20);
            this.RadYTextBox.TabIndex = 8;
            this.RadYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vertical radius:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 30);
            this.panel1.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.Location = new System.Drawing.Point(17, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            this.panel1.ResumeLayout(false);
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
        private Button ellipseButton;
        private Label label3;
        private TextBox RadYTextBox;
        private Label label2;
        private TextBox RadXTextBox;
        private Button circleButton;
        private Panel panel1;
        private Button clearButton;
    }
}

