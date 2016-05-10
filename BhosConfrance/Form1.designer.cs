namespace BhosConfrance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.poly_label = new System.Windows.Forms.Label();
            this.Polybutton = new System.Windows.Forms.Button();
            this.Exp_button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PointsButton = new System.Windows.Forms.Button();
            this.Linear_Button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MatrixButton = new System.Windows.Forms.Button();
            this.linear_label = new System.Windows.Forms.Label();
            this.exp_label = new System.Windows.Forms.Label();
            this.power_button = new System.Windows.Forms.Button();
            this.clearData_button = new System.Windows.Forms.Button();
            this.ComboButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.power_pow = new System.Windows.Forms.Label();
            this.exppow = new System.Windows.Forms.Label();
            this.power_label = new System.Windows.Forms.Label();
            this.combo_label = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.combo_pow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // poly_label
            // 
            this.poly_label.AutoSize = true;
            this.poly_label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poly_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.poly_label.Location = new System.Drawing.Point(372, 462);
            this.poly_label.Name = "poly_label";
            this.poly_label.Size = new System.Drawing.Size(106, 18);
            this.poly_label.TabIndex = 14;
            this.poly_label.Text = "poly_label";
            // 
            // Polybutton
            // 
            this.Polybutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Polybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polybutton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.Polybutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Polybutton.Location = new System.Drawing.Point(8, 306);
            this.Polybutton.Name = "Polybutton";
            this.Polybutton.Size = new System.Drawing.Size(129, 31);
            this.Polybutton.TabIndex = 7;
            this.Polybutton.Text = "POLYNOMIAL";
            this.Polybutton.UseVisualStyleBackColor = true;
            this.Polybutton.Click += new System.EventHandler(this.Polybutton_Click);
            // 
            // Exp_button
            // 
            this.Exp_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Exp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exp_button.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.Exp_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exp_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exp_button.Location = new System.Drawing.Point(8, 250);
            this.Exp_button.Name = "Exp_button";
            this.Exp_button.Size = new System.Drawing.Size(129, 30);
            this.Exp_button.TabIndex = 9;
            this.Exp_button.Text = "EXPONENTIAL";
            this.Exp_button.UseVisualStyleBackColor = true;
            this.Exp_button.Click += new System.EventHandler(this.Exp_button_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearButton.Location = new System.Drawing.Point(806, 370);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(86, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PointsButton
            // 
            this.PointsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PointsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PointsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointsButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PointsButton.Location = new System.Drawing.Point(147, 306);
            this.PointsButton.Name = "PointsButton";
            this.PointsButton.Size = new System.Drawing.Size(103, 31);
            this.PointsButton.TabIndex = 4;
            this.PointsButton.Text = "SCATTER";
            this.PointsButton.UseVisualStyleBackColor = false;
            this.PointsButton.Click += new System.EventHandler(this.PointsButton_Click);
            // 
            // Linear_Button
            // 
            this.Linear_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Linear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Linear_Button.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.Linear_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Linear_Button.Location = new System.Drawing.Point(264, 306);
            this.Linear_Button.Name = "Linear_Button";
            this.Linear_Button.Size = new System.Drawing.Size(89, 31);
            this.Linear_Button.TabIndex = 10;
            this.Linear_Button.Text = "LINEAR";
            this.Linear_Button.UseVisualStyleBackColor = true;
            this.Linear_Button.Click += new System.EventHandler(this.Linear_Button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.Info;
            this.numericUpDown1.Location = new System.Drawing.Point(135, 360);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(8, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 183);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnX
            // 
            this.ColumnX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnY
            // 
            this.ColumnY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Order of polynom";
            // 
            // MatrixButton
            // 
            this.MatrixButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatrixButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.MatrixButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MatrixButton.Location = new System.Drawing.Point(3, 478);
            this.MatrixButton.Name = "MatrixButton";
            this.MatrixButton.Size = new System.Drawing.Size(128, 31);
            this.MatrixButton.TabIndex = 6;
            this.MatrixButton.Text = "MatrixSolver";
            this.MatrixButton.UseVisualStyleBackColor = true;
            this.MatrixButton.Click += new System.EventHandler(this.MatrixButton_Click);
            // 
            // linear_label
            // 
            this.linear_label.AutoSize = true;
            this.linear_label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linear_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linear_label.Location = new System.Drawing.Point(372, 381);
            this.linear_label.Name = "linear_label";
            this.linear_label.Size = new System.Drawing.Size(101, 18);
            this.linear_label.TabIndex = 13;
            this.linear_label.Text = "y=0,00x+b";
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exp_label.Location = new System.Drawing.Point(376, 425);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(78, 18);
            this.exp_label.TabIndex = 15;
            this.exp_label.Text = "y=0,00e";
            // 
            // power_button
            // 
            this.power_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.power_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power_button.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.power_button.Location = new System.Drawing.Point(148, 250);
            this.power_button.Name = "power_button";
            this.power_button.Size = new System.Drawing.Size(103, 30);
            this.power_button.TabIndex = 16;
            this.power_button.Text = "POWER";
            this.power_button.UseVisualStyleBackColor = true;
            this.power_button.Click += new System.EventHandler(this.power_button_Click);
            // 
            // clearData_button
            // 
            this.clearData_button.Location = new System.Drawing.Point(292, 18);
            this.clearData_button.Name = "clearData_button";
            this.clearData_button.Size = new System.Drawing.Size(41, 23);
            this.clearData_button.TabIndex = 17;
            this.clearData_button.Text = "Clear";
            this.clearData_button.UseVisualStyleBackColor = true;
            this.clearData_button.Click += new System.EventHandler(this.clearData_button_Click);
            // 
            // ComboButton
            // 
            this.ComboButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ComboButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.ComboButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboButton.Location = new System.Drawing.Point(264, 250);
            this.ComboButton.Name = "ComboButton";
            this.ComboButton.Size = new System.Drawing.Size(89, 30);
            this.ComboButton.TabIndex = 18;
            this.ComboButton.Text = "COMBO";
            this.ComboButton.UseVisualStyleBackColor = true;
            this.ComboButton.Click += new System.EventHandler(this.ComboButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.power_pow);
            this.panel1.Controls.Add(this.exppow);
            this.panel1.Controls.Add(this.power_label);
            this.panel1.Controls.Add(this.combo_label);
            this.panel1.Controls.Add(this.ComboButton);
            this.panel1.Controls.Add(this.clearData_button);
            this.panel1.Controls.Add(this.power_button);
            this.panel1.Controls.Add(this.linear_label);
            this.panel1.Controls.Add(this.MatrixButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.Linear_Button);
            this.panel1.Controls.Add(this.PointsButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.Exp_button);
            this.panel1.Controls.Add(this.Polybutton);
            this.panel1.Controls.Add(this.zedGraphControl1);
            this.panel1.Controls.Add(this.poly_label);
            this.panel1.Controls.Add(this.exp_label);
            this.panel1.Controls.Add(this.combo_pow);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 512);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BhosConfrance.Properties.Resources.Untitled_31;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(752, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 47);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(264, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Optimum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // power_pow
            // 
            this.power_pow.AutoSize = true;
            this.power_pow.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.power_pow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.power_pow.Location = new System.Drawing.Point(601, 415);
            this.power_pow.Name = "power_pow";
            this.power_pow.Size = new System.Drawing.Size(34, 13);
            this.power_pow.TabIndex = 22;
            this.power_pow.Text = "0,00x";
            // 
            // exppow
            // 
            this.exppow.AutoSize = true;
            this.exppow.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exppow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exppow.Location = new System.Drawing.Point(444, 415);
            this.exppow.Name = "exppow";
            this.exppow.Size = new System.Drawing.Size(34, 13);
            this.exppow.TabIndex = 21;
            this.exppow.Text = "0,00x";
            // 
            // power_label
            // 
            this.power_label.AutoSize = true;
            this.power_label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.power_label.Location = new System.Drawing.Point(530, 425);
            this.power_label.Name = "power_label";
            this.power_label.Size = new System.Drawing.Size(78, 18);
            this.power_label.TabIndex = 20;
            this.power_label.Text = "y=0,00x";
            // 
            // combo_label
            // 
            this.combo_label.AutoSize = true;
            this.combo_label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.combo_label.Location = new System.Drawing.Point(530, 381);
            this.combo_label.Name = "combo_label";
            this.combo_label.Size = new System.Drawing.Size(249, 18);
            this.combo_label.TabIndex = 19;
            this.combo_label.Text = "0,00ln(x)+0,00cos(x)+0,00e";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(368, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(532, 364);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // combo_pow
            // 
            this.combo_pow.AutoSize = true;
            this.combo_pow.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_pow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.combo_pow.Location = new System.Drawing.Point(770, 371);
            this.combo_pow.Name = "combo_pow";
            this.combo_pow.Size = new System.Drawing.Size(13, 13);
            this.combo_pow.TabIndex = 23;
            this.combo_pow.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(919, 526);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurveFitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label poly_label;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button Polybutton;
        private System.Windows.Forms.Button Exp_button;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PointsButton;
        private System.Windows.Forms.Button Linear_Button;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MatrixButton;
        private System.Windows.Forms.Label linear_label;
        private System.Windows.Forms.Label exp_label;
        private System.Windows.Forms.Button power_button;
        private System.Windows.Forms.Button clearData_button;
        private System.Windows.Forms.Button ComboButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label power_label;
        private System.Windows.Forms.Label combo_label;
        private System.Windows.Forms.Label exppow;
        private System.Windows.Forms.Label power_pow;
        private System.Windows.Forms.Label combo_pow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

