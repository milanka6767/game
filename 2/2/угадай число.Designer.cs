namespace меню
{
    partial class угадай_число
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.IbIHint = new System.Windows.Forms.Label();
            this.IbIAttempts = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.IbIWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(227, 180);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(303, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "txtInput";
            // 
            // IbIHint
            // 
            this.IbIHint.AutoSize = true;
            this.IbIHint.Location = new System.Drawing.Point(224, 144);
            this.IbIHint.Name = "IbIHint";
            this.IbIHint.Size = new System.Drawing.Size(81, 16);
            this.IbIHint.TabIndex = 1;
            this.IbIHint.Text = "Подсказка:";
            // 
            // IbIAttempts
            // 
            this.IbIAttempts.AutoSize = true;
            this.IbIAttempts.Location = new System.Drawing.Point(344, 235);
            this.IbIAttempts.Name = "IbIAttempts";
            this.IbIAttempts.Size = new System.Drawing.Size(77, 16);
            this.IbIAttempts.TabIndex = 2;
            this.IbIAttempts.Text = "Попытки: 0";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(227, 272);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "угадать!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(455, 272);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "заново";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // IbIWin
            // 
            this.IbIWin.AutoSize = true;
            this.IbIWin.Location = new System.Drawing.Point(335, 311);
            this.IbIWin.Name = "IbIWin";
            this.IbIWin.Size = new System.Drawing.Size(95, 16);
            this.IbIWin.TabIndex = 5;
            this.IbIWin.Text = "ВЫ УГАДАЛИ!";
            this.IbIWin.Visible = false;
            // 
            // угадай_число
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IbIWin);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.IbIAttempts);
            this.Controls.Add(this.IbIHint);
            this.Controls.Add(this.txtInput);
            this.Name = "угадай_число";
            this.Text = "угадай_число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label IbIHint;
        private System.Windows.Forms.Label IbIAttempts;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label IbIWin;
    }
}