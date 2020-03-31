namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A00 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.lbl_draw = new System.Windows.Forms.Label();
            this.bttn_newGame = new System.Windows.Forms.Button();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.lbl_actualPlayer = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.bttn_changeName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.BackColor = System.Drawing.Color.Yellow;
            this.A00.Font = new System.Drawing.Font("Times New Roman", 55.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A00.Location = new System.Drawing.Point(30, 51);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(100, 100);
            this.A00.TabIndex = 0;
            this.A00.Text = " ";
            this.A00.UseVisualStyleBackColor = false;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.BackColor = System.Drawing.Color.Yellow;
            this.A21.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A21.Location = new System.Drawing.Point(242, 157);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(100, 100);
            this.A21.TabIndex = 1;
            this.A21.Text = " ";
            this.A21.UseVisualStyleBackColor = false;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.BackColor = System.Drawing.Color.Yellow;
            this.A20.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A20.Location = new System.Drawing.Point(242, 51);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(100, 100);
            this.A20.TabIndex = 2;
            this.A20.Text = " ";
            this.A20.UseVisualStyleBackColor = false;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.BackColor = System.Drawing.Color.Yellow;
            this.A12.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A12.Location = new System.Drawing.Point(136, 263);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(100, 100);
            this.A12.TabIndex = 3;
            this.A12.Text = " ";
            this.A12.UseVisualStyleBackColor = false;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.BackColor = System.Drawing.Color.Yellow;
            this.A11.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A11.Location = new System.Drawing.Point(136, 157);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(100, 100);
            this.A11.TabIndex = 4;
            this.A11.Text = " ";
            this.A11.UseVisualStyleBackColor = false;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.BackColor = System.Drawing.Color.Yellow;
            this.A10.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A10.Location = new System.Drawing.Point(136, 51);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(100, 100);
            this.A10.TabIndex = 5;
            this.A10.Text = " ";
            this.A10.UseVisualStyleBackColor = false;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.BackColor = System.Drawing.Color.Yellow;
            this.A02.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A02.Location = new System.Drawing.Point(30, 263);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(100, 100);
            this.A02.TabIndex = 6;
            this.A02.Text = " ";
            this.A02.UseVisualStyleBackColor = false;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.BackColor = System.Drawing.Color.Yellow;
            this.A01.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A01.Location = new System.Drawing.Point(30, 157);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(100, 100);
            this.A01.TabIndex = 7;
            this.A01.Text = " ";
            this.A01.UseVisualStyleBackColor = false;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.BackColor = System.Drawing.Color.Yellow;
            this.A22.Font = new System.Drawing.Font("Times New Roman", 55.8F);
            this.A22.Location = new System.Drawing.Point(242, 263);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(100, 100);
            this.A22.TabIndex = 8;
            this.A22.Text = " ";
            this.A22.UseVisualStyleBackColor = false;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // lbl_draw
            // 
            this.lbl_draw.AutoSize = true;
            this.lbl_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_draw.Location = new System.Drawing.Point(391, 100);
            this.lbl_draw.Name = "lbl_draw";
            this.lbl_draw.Size = new System.Drawing.Size(181, 25);
            this.lbl_draw.TabIndex = 11;
            this.lbl_draw.Text = "Unentschieden: 0";
            // 
            // bttn_newGame
            // 
            this.bttn_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_newGame.Location = new System.Drawing.Point(392, 201);
            this.bttn_newGame.Name = "bttn_newGame";
            this.bttn_newGame.Size = new System.Drawing.Size(272, 56);
            this.bttn_newGame.TabIndex = 12;
            this.bttn_newGame.Text = "Neues Spiel";
            this.bttn_newGame.UseVisualStyleBackColor = true;
            this.bttn_newGame.Click += new System.EventHandler(this.bttn_newGame_Click);
            // 
            // bttn_reset
            // 
            this.bttn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_reset.Location = new System.Drawing.Point(392, 254);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(272, 56);
            this.bttn_reset.TabIndex = 13;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = true;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // bttn_close
            // 
            this.bttn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_close.Location = new System.Drawing.Point(392, 307);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(272, 56);
            this.bttn_close.TabIndex = 14;
            this.bttn_close.Text = "Beenden";
            this.bttn_close.UseVisualStyleBackColor = true;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // lbl_actualPlayer
            // 
            this.lbl_actualPlayer.AutoSize = true;
            this.lbl_actualPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualPlayer.Location = new System.Drawing.Point(27, 9);
            this.lbl_actualPlayer.Name = "lbl_actualPlayer";
            this.lbl_actualPlayer.Size = new System.Drawing.Size(18, 25);
            this.lbl_actualPlayer.TabIndex = 15;
            this.lbl_actualPlayer.Text = " ";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.Location = new System.Drawing.Point(391, 26);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(188, 25);
            this.lbl_X.TabIndex = 16;
            this.lbl_X.Text = "Siege Spieler X: 0";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Y.Location = new System.Drawing.Point(391, 65);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(190, 25);
            this.lbl_Y.TabIndex = 17;
            this.lbl_Y.Text = "Siege Spieler O: 0";
            // 
            // bttn_changeName
            // 
            this.bttn_changeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_changeName.Location = new System.Drawing.Point(392, 148);
            this.bttn_changeName.Name = "bttn_changeName";
            this.bttn_changeName.Size = new System.Drawing.Size(272, 56);
            this.bttn_changeName.TabIndex = 18;
            this.bttn_changeName.Text = "Namen ändern";
            this.bttn_changeName.UseVisualStyleBackColor = true;
            this.bttn_changeName.Click += new System.EventHandler(this.bttn_changeName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(701, 389);
            this.Controls.Add(this.bttn_changeName);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.lbl_actualPlayer);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_reset);
            this.Controls.Add(this.bttn_newGame);
            this.Controls.Add(this.lbl_draw);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A00);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Label lbl_draw;
        private System.Windows.Forms.Button bttn_newGame;
        private System.Windows.Forms.Button bttn_reset;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.Label lbl_actualPlayer;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Button bttn_changeName;
    }
}

