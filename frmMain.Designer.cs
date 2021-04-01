namespace 가위바위보_게임
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHand = new System.Windows.Forms.Label();
            this.btnK = new System.Windows.Forms.Button();
            this.btnBO = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.lblAiHand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(224, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "가위바위보 게임";
            // 
            // lblHand
            // 
            this.lblHand.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHand.Location = new System.Drawing.Point(77, 180);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(226, 32);
            this.lblHand.TabIndex = 1;
            this.lblHand.Text = "시작 않함";
            this.lblHand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnK
            // 
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnK.Location = new System.Drawing.Point(55, 375);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(164, 34);
            this.btnK.TabIndex = 2;
            this.btnK.Text = "가위";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnBO
            // 
            this.btnBO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBO.Location = new System.Drawing.Point(238, 375);
            this.btnBO.Name = "btnBO";
            this.btnBO.Size = new System.Drawing.Size(164, 34);
            this.btnBO.TabIndex = 2;
            this.btnBO.Text = "바위";
            this.btnBO.UseVisualStyleBackColor = true;
            this.btnBO.Click += new System.EventHandler(this.btnBO_Click);
            // 
            // btnB
            // 
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnB.Location = new System.Drawing.Point(422, 375);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(164, 34);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "보";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // lblAiHand
            // 
            this.lblAiHand.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAiHand.Location = new System.Drawing.Point(324, 180);
            this.lblAiHand.Name = "lblAiHand";
            this.lblAiHand.Size = new System.Drawing.Size(226, 32);
            this.lblAiHand.TabIndex = 1;
            this.lblAiHand.Text = "시작 않함";
            this.lblAiHand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(172, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "나";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(404, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "랜덤";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(455, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "점수: ";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score.Location = new System.Drawing.Point(516, 28);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(19, 19);
            this.score.TabIndex = 3;
            this.score.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 441);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnBO);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAiHand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "가위바위보 게임";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnBO;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Label lblAiHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
    }
}

