
namespace Sua_Idade
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cyearbox = new System.Windows.Forms.TextBox();
            this.anoA = new System.Windows.Forms.Label();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.sexo = new System.Windows.Forms.Label();
            this.anoN = new System.Windows.Forms.Label();
            this.byearbox = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namebox.Location = new System.Drawing.Point(173, 52);
            this.namebox.Margin = new System.Windows.Forms.Padding(4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(215, 29);
            this.namebox.TabIndex = 0;
            this.namebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(107, 60);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(56, 21);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Nome:";
            this.nomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cyearbox
            // 
            this.cyearbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cyearbox.Location = new System.Drawing.Point(173, 89);
            this.cyearbox.Margin = new System.Windows.Forms.Padding(4);
            this.cyearbox.Name = "cyearbox";
            this.cyearbox.Size = new System.Drawing.Size(215, 29);
            this.cyearbox.TabIndex = 3;
            this.cyearbox.TextChanged += new System.EventHandler(this.cyearbox_TextChanged);
            // 
            // anoA
            // 
            this.anoA.AutoSize = true;
            this.anoA.Location = new System.Drawing.Point(82, 92);
            this.anoA.Name = "anoA";
            this.anoA.Size = new System.Drawing.Size(81, 21);
            this.anoA.TabIndex = 4;
            this.anoA.Text = "Ano Atual:";
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(82, 268);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(99, 25);
            this.radioM.TabIndex = 5;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(82, 303);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(93, 25);
            this.radioF.TabIndex = 6;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(82, 239);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(46, 21);
            this.sexo.TabIndex = 7;
            this.sexo.Text = "Sexo:";
            this.sexo.Click += new System.EventHandler(this.label3_Click);
            // 
            // anoN
            // 
            this.anoN.AutoSize = true;
            this.anoN.Location = new System.Drawing.Point(21, 134);
            this.anoN.Name = "anoN";
            this.anoN.Size = new System.Drawing.Size(149, 21);
            this.anoN.TabIndex = 8;
            this.anoN.Text = "Ano de Nascimento:";
            // 
            // byearbox
            // 
            this.byearbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.byearbox.Location = new System.Drawing.Point(173, 131);
            this.byearbox.Name = "byearbox";
            this.byearbox.Size = new System.Drawing.Size(168, 29);
            this.byearbox.TabIndex = 9;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.result.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(412, 168);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(283, 30);
            this.result.TabIndex = 10;
            this.result.Text = "                                             ";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(731, 429);
            this.Controls.Add(this.result);
            this.Controls.Add(this.byearbox);
            this.Controls.Add(this.anoN);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.radioF);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.anoA);
            this.Controls.Add(this.cyearbox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.namebox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox cyearbox;
        private System.Windows.Forms.Label anoA;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label anoN;
        private System.Windows.Forms.TextBox byearbox;
        private System.Windows.Forms.Label result;
    }
}

