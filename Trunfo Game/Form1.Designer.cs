namespace Trunfo_Game
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
            Jogador = new ListBox();
            Maquina = new ListBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            pictureBoxJogador = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJogador).BeginInit();
            SuspendLayout();
            // 
            // Jogador
            // 
            Jogador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Jogador.FormattingEnabled = true;
            Jogador.ItemHeight = 28;
            Jogador.Location = new Point(12, 22);
            Jogador.Name = "Jogador";
            Jogador.Size = new Size(373, 368);
            Jogador.TabIndex = 0;
            // 
            // Maquina
            // 
            Maquina.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Maquina.FormattingEnabled = true;
            Maquina.ItemHeight = 28;
            Maquina.Location = new Point(403, 22);
            Maquina.Name = "Maquina";
            Maquina.Size = new Size(373, 368);
            Maquina.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(465, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 158);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 212);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 4;
            label1.Text = "Jogador";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 298);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 327);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 356);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(33, 269);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Chute";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(33, 298);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Defesa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(33, 327);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Passe";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(33, 356);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Velocidade";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(564, 269);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(564, 299);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 23);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(564, 327);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(186, 23);
            textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(564, 356);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(186, 23);
            textBox8.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(545, 212);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 17;
            label2.Text = "Jogador";
            // 
            // button5
            // 
            button5.Location = new Point(127, 415);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 18;
            button5.Text = "Começar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Location = new Point(465, 415);
            button6.Name = "button6";
            button6.Size = new Size(101, 25);
            button6.TabIndex = 19;
            button6.Text = "Proxima rodada";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            // 
            // pictureBoxJogador
            // 
            pictureBoxJogador.Location = new Point(74, 51);
            pictureBoxJogador.Name = "pictureBoxJogador";
            pictureBoxJogador.Size = new Size(245, 158);
            pictureBoxJogador.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxJogador.TabIndex = 20;
            pictureBoxJogador.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxJogador);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(Maquina);
            Controls.Add(Jogador);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxJogador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Jogador;
        private ListBox Maquina;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label2;
        private Button button5;
        private Button button6;
        private PictureBox pictureBoxJogador;
    }
}