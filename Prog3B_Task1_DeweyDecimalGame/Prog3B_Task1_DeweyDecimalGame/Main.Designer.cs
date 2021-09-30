
namespace Prog3B_Task1_DeweyDecimalGame
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnReplaceBooks = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnCallNums = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplaceBooks
            // 
            this.btnReplaceBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(129)))), ((int)(((byte)(118)))));
            this.btnReplaceBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReplaceBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceBooks.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceBooks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReplaceBooks.Location = new System.Drawing.Point(91, 262);
            this.btnReplaceBooks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReplaceBooks.Name = "btnReplaceBooks";
            this.btnReplaceBooks.Size = new System.Drawing.Size(171, 59);
            this.btnReplaceBooks.TabIndex = 0;
            this.btnReplaceBooks.Text = "Replace Books";
            this.btnReplaceBooks.UseVisualStyleBackColor = false;
            this.btnReplaceBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIdentify
            // 
            this.btnIdentify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.btnIdentify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentify.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIdentify.Location = new System.Drawing.Point(551, 263);
            this.btnIdentify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(198, 61);
            this.btnIdentify.TabIndex = 1;
            this.btnIdentify.Text = "Identifying Areas";
            this.btnIdentify.UseVisualStyleBackColor = false;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnCallNums
            // 
            this.btnCallNums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(150)))), ((int)(((byte)(249)))));
            this.btnCallNums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallNums.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallNums.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCallNums.Location = new System.Drawing.Point(282, 263);
            this.btnCallNums.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCallNums.Name = "btnCallNums";
            this.btnCallNums.Size = new System.Drawing.Size(243, 58);
            this.btnCallNums.TabIndex = 2;
            this.btnCallNums.Text = "Finding Call Numbers";
            this.btnCallNums.UseVisualStyleBackColor = false;
            this.btnCallNums.Click += new System.EventHandler(this.btnCallNums_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(226, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dewey Decimal Game";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCallNums);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.btnReplaceBooks);
            this.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplaceBooks;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnCallNums;
        private System.Windows.Forms.Label label1;
    }
}

