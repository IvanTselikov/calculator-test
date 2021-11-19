
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.ClearTablo = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.MultipliedBy = new System.Windows.Forms.Button();
            this.DividedBy = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.ClearLastCharacter = new System.Windows.Forms.Button();
            this.Tablo = new System.Windows.Forms.Label();
            this.Equal = new System.Windows.Forms.Button();
            this.ChangeSign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.One.Location = new System.Drawing.Point(8, 11);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(56, 51);
            this.One.TabIndex = 0;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Two.Location = new System.Drawing.Point(71, 11);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(56, 51);
            this.Two.TabIndex = 1;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Three.Location = new System.Drawing.Point(146, 148);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(56, 51);
            this.Three.TabIndex = 2;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Six.Location = new System.Drawing.Point(146, 205);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(56, 51);
            this.Six.TabIndex = 5;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Five.Location = new System.Drawing.Point(84, 205);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(56, 51);
            this.Five.TabIndex = 4;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Four.Location = new System.Drawing.Point(21, 205);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(56, 51);
            this.Four.TabIndex = 3;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Seven.Location = new System.Drawing.Point(21, 262);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(56, 51);
            this.Seven.TabIndex = 6;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Eight.Location = new System.Drawing.Point(84, 262);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(56, 51);
            this.Eight.TabIndex = 7;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Nine.Location = new System.Drawing.Point(146, 262);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(56, 51);
            this.Nine.TabIndex = 8;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.numButton_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Zero.Location = new System.Drawing.Point(84, 319);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(56, 51);
            this.Zero.TabIndex = 9;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.numButton_Click);
            // 
            // ClearTablo
            // 
            this.ClearTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearTablo.Location = new System.Drawing.Point(334, 205);
            this.ClearTablo.Name = "ClearTablo";
            this.ClearTablo.Size = new System.Drawing.Size(55, 108);
            this.ClearTablo.TabIndex = 10;
            this.ClearTablo.Text = "C";
            this.ClearTablo.UseVisualStyleBackColor = true;
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Plus.Location = new System.Drawing.Point(208, 148);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(56, 51);
            this.Plus.TabIndex = 11;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(208, 205);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(56, 51);
            this.Minus.TabIndex = 12;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // MultipliedBy
            // 
            this.MultipliedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.MultipliedBy.Location = new System.Drawing.Point(208, 262);
            this.MultipliedBy.Name = "MultipliedBy";
            this.MultipliedBy.Size = new System.Drawing.Size(56, 51);
            this.MultipliedBy.TabIndex = 13;
            this.MultipliedBy.Text = "*";
            this.MultipliedBy.UseVisualStyleBackColor = true;
            // 
            // DividedBy
            // 
            this.DividedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.DividedBy.Location = new System.Drawing.Point(208, 320);
            this.DividedBy.Name = "DividedBy";
            this.DividedBy.Size = new System.Drawing.Size(56, 50);
            this.DividedBy.TabIndex = 14;
            this.DividedBy.Text = "/";
            this.DividedBy.UseVisualStyleBackColor = true;
            // 
            // Comma
            // 
            this.Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comma.Location = new System.Drawing.Point(146, 319);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(55, 51);
            this.Comma.TabIndex = 15;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.Comma_Click);
            // 
            // ClearLastCharacter
            // 
            this.ClearLastCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearLastCharacter.Location = new System.Drawing.Point(334, 148);
            this.ClearLastCharacter.Name = "ClearLastCharacter";
            this.ClearLastCharacter.Size = new System.Drawing.Size(55, 51);
            this.ClearLastCharacter.TabIndex = 16;
            this.ClearLastCharacter.Text = "<---";
            this.ClearLastCharacter.UseVisualStyleBackColor = true;
            // 
            // Tablo
            // 
            this.Tablo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Tablo.Location = new System.Drawing.Point(12, 44);
            this.Tablo.Name = "Tablo";
            this.Tablo.Size = new System.Drawing.Size(252, 80);
            this.Tablo.TabIndex = 17;
            this.Tablo.Text = "0";
            this.Tablo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Equal.Location = new System.Drawing.Point(270, 148);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(58, 222);
            this.Equal.TabIndex = 18;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            // 
            // ChangeSign
            // 
            this.ChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.ChangeSign.Location = new System.Drawing.Point(335, 319);
            this.ChangeSign.Name = "ChangeSign";
            this.ChangeSign.Size = new System.Drawing.Size(54, 51);
            this.ChangeSign.TabIndex = 19;
            this.ChangeSign.Text = "+/-";
            this.ChangeSign.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.One);
            this.panel1.Controls.Add(this.Two);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 249);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 397);
            this.Controls.Add(this.ChangeSign);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Tablo);
            this.Controls.Add(this.ClearLastCharacter);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.DividedBy);
            this.Controls.Add(this.MultipliedBy);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.ClearTablo);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(441, 436);
            this.MinimumSize = new System.Drawing.Size(441, 436);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button ClearTablo;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button MultipliedBy;
        private System.Windows.Forms.Button DividedBy;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button ClearLastCharacter;
        private System.Windows.Forms.Label Tablo;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button ChangeSign;
        private System.Windows.Forms.Panel panel1;
    }
}

