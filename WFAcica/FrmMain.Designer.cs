namespace WFAcica
{
    partial class FrmMain
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
            this.btnTallozas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFileok = new System.Windows.Forms.ListBox();
            this.lblEleresiUt = new System.Windows.Forms.Label();
            this.btnElozo = new System.Windows.Forms.Button();
            this.btnKovetkezo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.gbKerdes = new System.Windows.Forms.GroupBox();
            this.rb02 = new System.Windows.Forms.RadioButton();
            this.rb04 = new System.Windows.Forms.RadioButton();
            this.rb03 = new System.Windows.Forms.RadioButton();
            this.rb01 = new System.Windows.Forms.RadioButton();
            this.btnValasz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.gbKerdes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTallozas
            // 
            this.btnTallozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTallozas.Location = new System.Drawing.Point(24, 27);
            this.btnTallozas.Name = "btnTallozas";
            this.btnTallozas.Size = new System.Drawing.Size(558, 47);
            this.btnTallozas.TabIndex = 0;
            this.btnTallozas.Text = "Tallozas";
            this.btnTallozas.UseVisualStyleBackColor = true;
            this.btnTallozas.Click += new System.EventHandler(this.btnTallozas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiválasztott mappa:";
            // 
            // lbFileok
            // 
            this.lbFileok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbFileok.FormattingEnabled = true;
            this.lbFileok.ItemHeight = 25;
            this.lbFileok.Items.AddRange(new object[] {
            "Tallózás után itt lehet ellenőrizni a file-okat"});
            this.lbFileok.Location = new System.Drawing.Point(24, 136);
            this.lbFileok.Name = "lbFileok";
            this.lbFileok.ScrollAlwaysVisible = true;
            this.lbFileok.Size = new System.Drawing.Size(558, 79);
            this.lbFileok.TabIndex = 2;
            // 
            // lblEleresiUt
            // 
            this.lblEleresiUt.AutoSize = true;
            this.lblEleresiUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEleresiUt.Location = new System.Drawing.Point(208, 94);
            this.lblEleresiUt.Name = "lblEleresiUt";
            this.lblEleresiUt.Size = new System.Drawing.Size(0, 25);
            this.lblEleresiUt.TabIndex = 1;
            // 
            // btnElozo
            // 
            this.btnElozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElozo.Location = new System.Drawing.Point(24, 284);
            this.btnElozo.Name = "btnElozo";
            this.btnElozo.Size = new System.Drawing.Size(134, 47);
            this.btnElozo.TabIndex = 0;
            this.btnElozo.Text = "E";
            this.btnElozo.UseVisualStyleBackColor = true;
            this.btnElozo.Click += new System.EventHandler(this.btnElozo_Click);
            // 
            // btnKovetkezo
            // 
            this.btnKovetkezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKovetkezo.Location = new System.Drawing.Point(448, 284);
            this.btnKovetkezo.Name = "btnKovetkezo";
            this.btnKovetkezo.Size = new System.Drawing.Size(134, 47);
            this.btnKovetkezo.TabIndex = 0;
            this.btnKovetkezo.Text = "K";
            this.btnKovetkezo.UseVisualStyleBackColor = true;
            this.btnKovetkezo.Click += new System.EventHandler(this.btnKovetkezo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Itt tesztelem a tesztet:";
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(382, 361);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(200, 200);
            this.pbKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKep.TabIndex = 3;
            this.pbKep.TabStop = false;
            // 
            // gbKerdes
            // 
            this.gbKerdes.Controls.Add(this.rb02);
            this.gbKerdes.Controls.Add(this.rb04);
            this.gbKerdes.Controls.Add(this.rb03);
            this.gbKerdes.Controls.Add(this.rb01);
            this.gbKerdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbKerdes.Location = new System.Drawing.Point(24, 361);
            this.gbKerdes.Name = "gbKerdes";
            this.gbKerdes.Size = new System.Drawing.Size(340, 124);
            this.gbKerdes.TabIndex = 4;
            this.gbKerdes.TabStop = false;
            this.gbKerdes.Text = "#####";
            // 
            // rb02
            // 
            this.rb02.AutoSize = true;
            this.rb02.Location = new System.Drawing.Point(191, 45);
            this.rb02.Name = "rb02";
            this.rb02.Size = new System.Drawing.Size(66, 29);
            this.rb02.TabIndex = 0;
            this.rb02.TabStop = true;
            this.rb02.Text = "###";
            this.rb02.UseVisualStyleBackColor = true;
            // 
            // rb04
            // 
            this.rb04.AutoSize = true;
            this.rb04.Location = new System.Drawing.Point(191, 80);
            this.rb04.Name = "rb04";
            this.rb04.Size = new System.Drawing.Size(66, 29);
            this.rb04.TabIndex = 0;
            this.rb04.TabStop = true;
            this.rb04.Text = "###";
            this.rb04.UseVisualStyleBackColor = true;
            // 
            // rb03
            // 
            this.rb03.AutoSize = true;
            this.rb03.Location = new System.Drawing.Point(7, 80);
            this.rb03.Name = "rb03";
            this.rb03.Size = new System.Drawing.Size(66, 29);
            this.rb03.TabIndex = 0;
            this.rb03.TabStop = true;
            this.rb03.Text = "###";
            this.rb03.UseVisualStyleBackColor = true;
            // 
            // rb01
            // 
            this.rb01.AutoSize = true;
            this.rb01.Location = new System.Drawing.Point(7, 45);
            this.rb01.Name = "rb01";
            this.rb01.Size = new System.Drawing.Size(66, 29);
            this.rb01.TabIndex = 0;
            this.rb01.TabStop = true;
            this.rb01.Text = "###";
            this.rb01.UseVisualStyleBackColor = true;
            // 
            // btnValasz
            // 
            this.btnValasz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnValasz.Location = new System.Drawing.Point(24, 514);
            this.btnValasz.Name = "btnValasz";
            this.btnValasz.Size = new System.Drawing.Size(340, 47);
            this.btnValasz.TabIndex = 0;
            this.btnValasz.Text = "V";
            this.btnValasz.UseVisualStyleBackColor = true;
            this.btnValasz.Click += new System.EventHandler(this.btnValasz_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 575);
            this.Controls.Add(this.gbKerdes);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.lbFileok);
            this.Controls.Add(this.lblEleresiUt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKovetkezo);
            this.Controls.Add(this.btnValasz);
            this.Controls.Add(this.btnElozo);
            this.Controls.Add(this.btnTallozas);
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.gbKerdes.ResumeLayout(false);
            this.gbKerdes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTallozas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFileok;
        private System.Windows.Forms.Label lblEleresiUt;
        private System.Windows.Forms.Button btnElozo;
        private System.Windows.Forms.Button btnKovetkezo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.GroupBox gbKerdes;
        private System.Windows.Forms.RadioButton rb02;
        private System.Windows.Forms.RadioButton rb04;
        private System.Windows.Forms.RadioButton rb03;
        private System.Windows.Forms.RadioButton rb01;
        private System.Windows.Forms.Button btnValasz;
    }
}

