﻿namespace MayTinhCaNhan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH MÁY TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số A";
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(242, 125);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(400, 35);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoA_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số B";
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(242, 198);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(400, 35);
            this.txtSoB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(242, 276);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(400, 35);
            this.txtKetQua.TabIndex = 2;
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCong.Location = new System.Drawing.Point(201, 341);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(81, 64);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTru.Location = new System.Drawing.Point(307, 341);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(81, 64);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = false;
            this.btnTru.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNhan.Location = new System.Drawing.Point(415, 341);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(81, 64);
            this.btnNhan.TabIndex = 3;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = false;
            this.btnNhan.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.Color.Cyan;
            this.btnChia.Location = new System.Drawing.Point(520, 341);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(81, 64);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = false;
            this.btnChia.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH MÁY TÍNH";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

