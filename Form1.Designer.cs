
namespace Proyecto__Optimizacion_Gerardo_Barajas
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
            label5 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 377);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 25;
            label5.Text = "Promedio";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(247, 370);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 307);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 23;
            label3.Text = "Paneles";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 300);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 341);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 21;
            label4.Text = "Experimentos";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(247, 335);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(806, 131);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 19;
            button2.Text = "Descarga";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 264);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 18;
            label2.Text = "b";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 257);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(514, 201);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(457, 251);
            dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 195);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 15;
            label1.Text = "a";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 189);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(579, 131);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 13;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 430);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 28;
            label6.Text = "Desv. Estand.";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(247, 423);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 27;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 521);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label5;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private TextBox textBox6;
    }
}
