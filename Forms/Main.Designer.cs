
namespace Kursovik
{
    partial class Main
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
            this.catalogButton = new System.Windows.Forms.Button();
            this.cabinetButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.panelCat = new System.Windows.Forms.Panel();
            this.editTovar = new System.Windows.Forms.Button();
            this.newTovar = new System.Windows.Forms.Button();
            this.deleteTovar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.searchCateg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTovar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridTovars = new System.Windows.Forms.DataGridView();
            this.TovarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.TovarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TovarCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TovarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysToProduce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCabinet = new System.Windows.Forms.Panel();
            this.saveUserData = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userFio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLast = new System.Windows.Forms.Panel();
            this.sumLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.oformitOrder = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.dataOrder = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TovName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTovars)).BeginInit();
            this.panelCabinet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // catalogButton
            // 
            this.catalogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.catalogButton.FlatAppearance.BorderSize = 0;
            this.catalogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.catalogButton.Location = new System.Drawing.Point(51, 64);
            this.catalogButton.Name = "catalogButton";
            this.catalogButton.Size = new System.Drawing.Size(148, 81);
            this.catalogButton.TabIndex = 0;
            this.catalogButton.Text = "Каталог";
            this.catalogButton.UseVisualStyleBackColor = false;
            this.catalogButton.Click += new System.EventHandler(this.catalogButton_Click);
            // 
            // cabinetButton
            // 
            this.cabinetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cabinetButton.FlatAppearance.BorderSize = 0;
            this.cabinetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cabinetButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cabinetButton.Location = new System.Drawing.Point(205, 64);
            this.cabinetButton.Name = "cabinetButton";
            this.cabinetButton.Size = new System.Drawing.Size(148, 81);
            this.cabinetButton.TabIndex = 1;
            this.cabinetButton.Text = "Личный кабинет";
            this.cabinetButton.UseVisualStyleBackColor = false;
            this.cabinetButton.Click += new System.EventHandler(this.cabinetButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lastButton.FlatAppearance.BorderSize = 0;
            this.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lastButton.Location = new System.Drawing.Point(359, 64);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(162, 81);
            this.lastButton.TabIndex = 2;
            this.lastButton.Text = "Корзина";
            this.lastButton.UseVisualStyleBackColor = false;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // panelCat
            // 
            this.panelCat.BackgroundImage = global::Kursovik.Properties.Resources.dark_wood;
            this.panelCat.Controls.Add(this.editTovar);
            this.panelCat.Controls.Add(this.newTovar);
            this.panelCat.Controls.Add(this.deleteTovar);
            this.panelCat.Controls.Add(this.numericUpDown1);
            this.panelCat.Controls.Add(this.label4);
            this.panelCat.Controls.Add(this.addToCart);
            this.panelCat.Controls.Add(this.searchCateg);
            this.panelCat.Controls.Add(this.label3);
            this.panelCat.Controls.Add(this.searchTovar);
            this.panelCat.Controls.Add(this.label2);
            this.panelCat.Controls.Add(this.dataGridTovars);
            this.panelCat.Location = new System.Drawing.Point(35, 145);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(906, 392);
            this.panelCat.TabIndex = 3;
            // 
            // editTovar
            // 
            this.editTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.editTovar.FlatAppearance.BorderSize = 0;
            this.editTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTovar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTovar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editTovar.Location = new System.Drawing.Point(710, 118);
            this.editTovar.Name = "editTovar";
            this.editTovar.Size = new System.Drawing.Size(174, 41);
            this.editTovar.TabIndex = 12;
            this.editTovar.Text = "Редактировать товар";
            this.editTovar.UseVisualStyleBackColor = false;
            this.editTovar.Click += new System.EventHandler(this.editTovar_Click);
            // 
            // newTovar
            // 
            this.newTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.newTovar.FlatAppearance.BorderSize = 0;
            this.newTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTovar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTovar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newTovar.Location = new System.Drawing.Point(710, 71);
            this.newTovar.Name = "newTovar";
            this.newTovar.Size = new System.Drawing.Size(174, 41);
            this.newTovar.TabIndex = 11;
            this.newTovar.Text = "Новый товар";
            this.newTovar.UseVisualStyleBackColor = false;
            this.newTovar.Click += new System.EventHandler(this.newTovar_Click);
            // 
            // deleteTovar
            // 
            this.deleteTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.deleteTovar.FlatAppearance.BorderSize = 0;
            this.deleteTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTovar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTovar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteTovar.Location = new System.Drawing.Point(710, 24);
            this.deleteTovar.Name = "deleteTovar";
            this.deleteTovar.Size = new System.Drawing.Size(174, 41);
            this.deleteTovar.TabIndex = 10;
            this.deleteTovar.Text = "Удалить товар";
            this.deleteTovar.UseVisualStyleBackColor = false;
            this.deleteTovar.Click += new System.EventHandler(this.deleteTovar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.numericUpDown1.Location = new System.Drawing.Point(788, 233);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 34);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(705, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кол-во";
            // 
            // addToCart
            // 
            this.addToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addToCart.FlatAppearance.BorderSize = 0;
            this.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCart.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addToCart.Location = new System.Drawing.Point(710, 280);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(174, 77);
            this.addToCart.TabIndex = 6;
            this.addToCart.Text = "Добавить в корзину";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // searchCateg
            // 
            this.searchCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCateg.Font = new System.Drawing.Font("Arial", 18F);
            this.searchCateg.FormattingEnabled = true;
            this.searchCateg.Location = new System.Drawing.Point(416, 25);
            this.searchCateg.Name = "searchCateg";
            this.searchCateg.Size = new System.Drawing.Size(265, 35);
            this.searchCateg.TabIndex = 7;
            this.searchCateg.SelectedIndexChanged += new System.EventHandler(this.searchCateg_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(301, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категория";
            // 
            // searchTovar
            // 
            this.searchTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.searchTovar.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.searchTovar.Location = new System.Drawing.Point(85, 25);
            this.searchTovar.Name = "searchTovar";
            this.searchTovar.Size = new System.Drawing.Size(180, 34);
            this.searchTovar.TabIndex = 5;
            this.searchTovar.TextChanged += new System.EventHandler(this.searchTovar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск";
            // 
            // dataGridTovars
            // 
            this.dataGridTovars.AllowUserToAddRows = false;
            this.dataGridTovars.AllowUserToDeleteRows = false;
            this.dataGridTovars.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridTovars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTovars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TovarId,
            this.Picture,
            this.TovarName,
            this.TovarCateg,
            this.TovarPrice,
            this.DaysToProduce});
            this.dataGridTovars.Location = new System.Drawing.Point(25, 77);
            this.dataGridTovars.Name = "dataGridTovars";
            this.dataGridTovars.ReadOnly = true;
            this.dataGridTovars.RowTemplate.Height = 80;
            this.dataGridTovars.Size = new System.Drawing.Size(656, 280);
            this.dataGridTovars.TabIndex = 0;
            // 
            // TovarId
            // 
            this.TovarId.HeaderText = "TovarId";
            this.TovarId.Name = "TovarId";
            this.TovarId.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "Картинка";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // TovarName
            // 
            this.TovarName.HeaderText = "Название";
            this.TovarName.Name = "TovarName";
            this.TovarName.ReadOnly = true;
            this.TovarName.Width = 180;
            // 
            // TovarCateg
            // 
            this.TovarCateg.HeaderText = "Категория";
            this.TovarCateg.Name = "TovarCateg";
            this.TovarCateg.ReadOnly = true;
            this.TovarCateg.Width = 150;
            // 
            // TovarPrice
            // 
            this.TovarPrice.HeaderText = "Цена";
            this.TovarPrice.Name = "TovarPrice";
            this.TovarPrice.ReadOnly = true;
            this.TovarPrice.Width = 50;
            // 
            // DaysToProduce
            // 
            this.DaysToProduce.HeaderText = "Дней на изготовку";
            this.DaysToProduce.Name = "DaysToProduce";
            this.DaysToProduce.ReadOnly = true;
            this.DaysToProduce.Width = 70;
            // 
            // panelCabinet
            // 
            this.panelCabinet.BackgroundImage = global::Kursovik.Properties.Resources.dark_wood;
            this.panelCabinet.Controls.Add(this.saveUserData);
            this.panelCabinet.Controls.Add(this.userPassword);
            this.panelCabinet.Controls.Add(this.label9);
            this.panelCabinet.Controls.Add(this.userBalance);
            this.panelCabinet.Controls.Add(this.label7);
            this.panelCabinet.Controls.Add(this.userLogin);
            this.panelCabinet.Controls.Add(this.label6);
            this.panelCabinet.Controls.Add(this.userFio);
            this.panelCabinet.Controls.Add(this.pictureBox1);
            this.panelCabinet.Location = new System.Drawing.Point(35, 145);
            this.panelCabinet.Name = "panelCabinet";
            this.panelCabinet.Size = new System.Drawing.Size(906, 392);
            this.panelCabinet.TabIndex = 4;
            // 
            // saveUserData
            // 
            this.saveUserData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.saveUserData.FlatAppearance.BorderSize = 0;
            this.saveUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserData.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveUserData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.saveUserData.Location = new System.Drawing.Point(89, 327);
            this.saveUserData.Name = "saveUserData";
            this.saveUserData.Size = new System.Drawing.Size(174, 41);
            this.saveUserData.TabIndex = 12;
            this.saveUserData.Text = "Сохранить";
            this.saveUserData.UseVisualStyleBackColor = false;
            this.saveUserData.Click += new System.EventHandler(this.saveUserData_Click);
            // 
            // userPassword
            // 
            this.userPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userPassword.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.userPassword.Location = new System.Drawing.Point(170, 265);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(164, 34);
            this.userPassword.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(84, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Пароль";
            // 
            // userBalance
            // 
            this.userBalance.AutoSize = true;
            this.userBalance.BackColor = System.Drawing.Color.Transparent;
            this.userBalance.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userBalance.Location = new System.Drawing.Point(392, 96);
            this.userBalance.Name = "userBalance";
            this.userBalance.Size = new System.Drawing.Size(111, 35);
            this.userBalance.TabIndex = 7;
            this.userBalance.Text = "Баланс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(260, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Баланс: ";
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userLogin.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.userLogin.Location = new System.Drawing.Point(170, 207);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(164, 34);
            this.userLogin.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(96, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Логин";
            // 
            // userFio
            // 
            this.userFio.AutoSize = true;
            this.userFio.BackColor = System.Drawing.Color.Transparent;
            this.userFio.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userFio.Location = new System.Drawing.Point(259, 28);
            this.userFio.Name = "userFio";
            this.userFio.Size = new System.Drawing.Size(335, 34);
            this.userFio.TabIndex = 1;
            this.userFio.Text = "Фамилия Имя Отчество";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursovik.Properties.Resources.profile_pic;
            this.pictureBox1.Location = new System.Drawing.Point(91, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLast
            // 
            this.panelLast.BackgroundImage = global::Kursovik.Properties.Resources.dark_wood;
            this.panelLast.Controls.Add(this.sumLabel);
            this.panelLast.Controls.Add(this.label10);
            this.panelLast.Controls.Add(this.oformitOrder);
            this.panelLast.Controls.Add(this.deleteOrder);
            this.panelLast.Controls.Add(this.dataOrder);
            this.panelLast.Location = new System.Drawing.Point(35, 145);
            this.panelLast.Name = "panelLast";
            this.panelLast.Size = new System.Drawing.Size(906, 392);
            this.panelLast.TabIndex = 5;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.BackColor = System.Drawing.Color.Transparent;
            this.sumLabel.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sumLabel.Location = new System.Drawing.Point(693, 328);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(68, 26);
            this.sumLabel.TabIndex = 9;
            this.sumLabel.Text = "0 руб.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(693, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "Сумма:";
            // 
            // oformitOrder
            // 
            this.oformitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.oformitOrder.FlatAppearance.BorderSize = 0;
            this.oformitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oformitOrder.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oformitOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.oformitOrder.Location = new System.Drawing.Point(698, 194);
            this.oformitOrder.Name = "oformitOrder";
            this.oformitOrder.Size = new System.Drawing.Size(195, 89);
            this.oformitOrder.TabIndex = 7;
            this.oformitOrder.Text = "Оформить покупку";
            this.oformitOrder.UseVisualStyleBackColor = false;
            this.oformitOrder.Click += new System.EventHandler(this.oformitOrder_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.deleteOrder.FlatAppearance.BorderSize = 0;
            this.deleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteOrder.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteOrder.Location = new System.Drawing.Point(698, 94);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(195, 89);
            this.deleteOrder.TabIndex = 6;
            this.deleteOrder.Text = "Удалить выбранное";
            this.deleteOrder.UseVisualStyleBackColor = false;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // dataOrder
            // 
            this.dataOrder.AllowUserToAddRows = false;
            this.dataOrder.AllowUserToDeleteRows = false;
            this.dataOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TovName,
            this.Amount,
            this.Price});
            this.dataOrder.Location = new System.Drawing.Point(31, 32);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.ReadOnly = true;
            this.dataOrder.Size = new System.Drawing.Size(650, 322);
            this.dataOrder.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TovName
            // 
            this.TovName.HeaderText = "Товар";
            this.TovName.Name = "TovName";
            this.TovName.ReadOnly = true;
            this.TovName.Width = 200;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Сумма";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovik.Properties.Resources.light_wood;
            this.ClientSize = new System.Drawing.Size(971, 551);
            this.Controls.Add(this.panelLast);
            this.Controls.Add(this.panelCat);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.cabinetButton);
            this.Controls.Add(this.catalogButton);
            this.Controls.Add(this.panelCabinet);
            this.Name = "Main";
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelCat.ResumeLayout(false);
            this.panelCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTovars)).EndInit();
            this.panelCabinet.ResumeLayout(false);
            this.panelCabinet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLast.ResumeLayout(false);
            this.panelLast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catalogButton;
        private System.Windows.Forms.Button cabinetButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Panel panelCat;
        private System.Windows.Forms.Panel panelCabinet;
        private System.Windows.Forms.Panel panelLast;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userFio;
        private System.Windows.Forms.ComboBox searchCateg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridTovars;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label userBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button oformitOrder;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.DataGridView dataOrder;
        private System.Windows.Forms.Button newTovar;
        private System.Windows.Forms.Button deleteTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TovName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveUserData;
        private System.Windows.Forms.DataGridViewTextBoxColumn TovarId;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn TovarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TovarCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TovarPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysToProduce;
        private System.Windows.Forms.Button editTovar;
    }
}

