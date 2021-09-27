
namespace Game_2D {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rtbMap = new System.Windows.Forms.RichTextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.cbxAttacks = new System.Windows.Forms.ComboBox();
            this.redAttackChance = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMap
            // 
            this.rtbMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMap.Location = new System.Drawing.Point(12, 12);
            this.rtbMap.Name = "rtbMap";
            this.rtbMap.Size = new System.Drawing.Size(95, 164);
            this.rtbMap.TabIndex = 0;
            this.rtbMap.Text = "xxxxx\nx...x\nx...x\nx...x\nxxxxx";
            this.rtbMap.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(401, 181);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(94, 29);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(492, 216);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(94, 29);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(401, 251);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(94, 29);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(311, 216);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(94, 29);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(311, 54);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(50, 20);
            this.lblStats.TabIndex = 5;
            this.lblStats.Text = "label1";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(172, 216);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(94, 29);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "ATTACK";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // cbxAttacks
            // 
            this.cbxAttacks.FormattingEnabled = true;
            this.cbxAttacks.Location = new System.Drawing.Point(145, 148);
            this.cbxAttacks.Name = "cbxAttacks";
            this.cbxAttacks.Size = new System.Drawing.Size(151, 28);
            this.cbxAttacks.TabIndex = 7;
            // 
            // redAttackChance
            // 
            this.redAttackChance.Location = new System.Drawing.Point(157, 252);
            this.redAttackChance.Name = "redAttackChance";
            this.redAttackChance.Size = new System.Drawing.Size(125, 120);
            this.redAttackChance.TabIndex = 8;
            this.redAttackChance.Text = "Attack succesful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.redAttackChance);
            this.Controls.Add(this.cbxAttacks);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.rtbMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMap;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ComboBox cbxAttacks;
        private System.Windows.Forms.RichTextBox redAttackChance;
    }
}

