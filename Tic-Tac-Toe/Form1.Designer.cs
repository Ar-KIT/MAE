namespace Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbt1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            reset = new Button();
            NG = new Button();
            po_score = new TextBox();
            px_score = new TextBox();
            lbl3 = new Label();
            SuspendLayout();
            // 
            // tbt1
            // 
            tbt1.BackColor = Color.DeepPink;
            tbt1.BorderStyle = BorderStyle.None;
            tbt1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbt1.ForeColor = Color.LightPink;
            tbt1.Location = new Point(289, 0);
            tbt1.Multiline = true;
            tbt1.Name = "tbt1";
            tbt1.ReadOnly = true;
            tbt1.Size = new Size(588, 94);
            tbt1.TabIndex = 0;
            tbt1.Text = "TIC - TAC - TOE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightPink;
            label1.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(665, 123);
            label1.Name = "label1";
            label1.Size = new Size(145, 36);
            label1.TabIndex = 13;
            label1.Text = "PLAYER X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightPink;
            label2.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(665, 185);
            label2.Name = "label2";
            label2.Size = new Size(148, 36);
            label2.TabIndex = 14;
            label2.Text = "PLAYER O:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(53, 97);
            button1.Name = "button1";
            button1.Size = new Size(153, 146);
            button1.TabIndex = 17;
            button1.Tag = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(236, 97);
            button2.Name = "button2";
            button2.Size = new Size(153, 146);
            button2.TabIndex = 18;
            button2.Tag = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(417, 97);
            button3.Name = "button3";
            button3.Size = new Size(153, 146);
            button3.TabIndex = 19;
            button3.Tag = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightPink;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(417, 267);
            button6.Name = "button6";
            button6.Size = new Size(153, 146);
            button6.TabIndex = 22;
            button6.Tag = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightPink;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(236, 267);
            button5.Name = "button5";
            button5.Size = new Size(153, 146);
            button5.TabIndex = 21;
            button5.Tag = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightPink;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(53, 267);
            button4.Name = "button4";
            button4.Size = new Size(153, 146);
            button4.TabIndex = 20;
            button4.Tag = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LightPink;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(417, 438);
            button9.Name = "button9";
            button9.Size = new Size(153, 146);
            button9.TabIndex = 25;
            button9.Tag = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightPink;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(236, 438);
            button8.Name = "button8";
            button8.Size = new Size(153, 146);
            button8.TabIndex = 24;
            button8.Tag = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightPink;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(53, 438);
            button7.Name = "button7";
            button7.Size = new Size(153, 146);
            button7.TabIndex = 23;
            button7.Tag = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // reset
            // 
            reset.BackColor = Color.LightPink;
            reset.FlatStyle = FlatStyle.Flat;
            reset.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            reset.Location = new Point(701, 399);
            reset.Name = "reset";
            reset.Size = new Size(176, 47);
            reset.TabIndex = 26;
            reset.Text = "RESET";
            reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button10_Click);
            // 
            // NG
            // 
            NG.BackColor = Color.LightPink;
            NG.FlatStyle = FlatStyle.Flat;
            NG.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NG.Location = new Point(701, 470);
            NG.Name = "NG";
            NG.Size = new Size(176, 49);
            NG.TabIndex = 27;
            NG.Text = "EXIT";
            NG.UseVisualStyleBackColor = false;
            this.NG.Click += new System.EventHandler(this.NG_Click);
            // 
            // po_score
            // 
            po_score.Enabled = false;
            po_score.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            po_score.Location = new Point(843, 195);
            po_score.Multiline = true;
            po_score.Name = "po_score";
            po_score.Size = new Size(70, 36);
            po_score.TabIndex = 30;
            po_score.Text = "0";
            // 
            // px_score
            // 
            px_score.Enabled = false;
            px_score.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            px_score.Location = new Point(843, 123);
            px_score.Multiline = true;
            px_score.Name = "px_score";
            px_score.Size = new Size(70, 36);
            px_score.TabIndex = 29;
            px_score.Text = "0";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.DeepPink;
            lbl3.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(142, 608);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(22, 36);
            lbl3.TabIndex = 31;
            lbl3.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1294, 670);
            Controls.Add(lbl3);
            Controls.Add(po_score);
            Controls.Add(px_score);
            Controls.Add(NG);
            Controls.Add(reset);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbt1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbt1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button reset;
        private Button NG;
        protected internal TextBox po_score;
        private TextBox px_score;
        private Label lbl3;
    }
}
