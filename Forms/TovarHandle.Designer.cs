
namespace Kursovik.Forms
{
    partial class TovarHandle
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
            this.tovarPic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newTovar = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tovarName = new System.Windows.Forms.TextBox();
            this.tovarPrice = new System.Windows.Forms.NumericUpDown();
            this.tovarDays = new System.Windows.Forms.NumericUpDown();
            this.tovarCat = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tovarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarDays)).BeginInit();
            this.SuspendLayout();
            // 
            // tovarPic
            // 
            this.tovarPic.Location = new System.Drawing.Point(12, 69);
            this.tovarPic.Name = "tovarPic";
            this.tovarPic.Size = new System.Drawing.Size(161, 105);
            this.tovarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tovarPic.TabIndex = 0;
            this.tovarPic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Картинка";
            // 
            // newTovar
            // 
            this.newTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.newTovar.FlatAppearance.BorderSize = 0;
            this.newTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTovar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTovar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newTovar.Location = new System.Drawing.Point(12, 180);
            this.newTovar.Name = "newTovar";
            this.newTovar.Size = new System.Drawing.Size(161, 41);
            this.newTovar.TabIndex = 12;
            this.newTovar.Text = "Выбрать";
            this.newTovar.UseVisualStyleBackColor = false;
            this.newTovar.Click += new System.EventHandler(this.newTovar_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveButton.Location = new System.Drawing.Point(322, 280);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(161, 41);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(317, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(310, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(368, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(221, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дней на изготовку";
            // 
            // tovarName
            // 
            this.tovarName.Font = new System.Drawing.Font("Berlin Sans FB", 16F);
            this.tovarName.Location = new System.Drawing.Point(442, 69);
            this.tovarName.Name = "tovarName";
            this.tovarName.Size = new System.Drawing.Size(321, 31);
            this.tovarName.TabIndex = 18;
            // 
            // tovarPrice
            // 
            this.tovarPrice.Font = new System.Drawing.Font("Berlin Sans FB", 16F);
            this.tovarPrice.Location = new System.Drawing.Point(442, 147);
            this.tovarPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tovarPrice.Name = "tovarPrice";
            this.tovarPrice.Size = new System.Drawing.Size(120, 31);
            this.tovarPrice.TabIndex = 19;
            // 
            // tovarDays
            // 
            this.tovarDays.Font = new System.Drawing.Font("Berlin Sans FB", 16F);
            this.tovarDays.Location = new System.Drawing.Point(442, 184);
            this.tovarDays.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tovarDays.Name = "tovarDays";
            this.tovarDays.Size = new System.Drawing.Size(120, 31);
            this.tovarDays.TabIndex = 20;
            // 
            // tovarCat
            // 
            this.tovarCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tovarCat.Font = new System.Drawing.Font("Arial", 18F);
            this.tovarCat.FormattingEnabled = true;
            this.tovarCat.Location = new System.Drawing.Point(441, 107);
            this.tovarCat.Name = "tovarCat";
            this.tovarCat.Size = new System.Drawing.Size(322, 35);
            this.tovarCat.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TovarHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovik.Properties.Resources.light_wood;
            this.ClientSize = new System.Drawing.Size(792, 333);
            this.Controls.Add(this.tovarCat);
            this.Controls.Add(this.tovarDays);
            this.Controls.Add(this.tovarPrice);
            this.Controls.Add(this.tovarName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newTovar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tovarPic);
            this.Name = "TovarHandle";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.TovarHandle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tovarPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newTovar;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tovarName;
        private System.Windows.Forms.NumericUpDown tovarPrice;
        private System.Windows.Forms.NumericUpDown tovarDays;
        private System.Windows.Forms.ComboBox tovarCat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}