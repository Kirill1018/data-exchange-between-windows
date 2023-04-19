namespace data_exchange_between_windows
{
    partial class questionnaire
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
            this.fam_name = new System.Windows.Forms.TextBox();
            this.behalf = new System.Windows.Forms.TextBox();
            this.quest = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.Label();
            this.patr = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.Label();
            this.birth_day = new System.Windows.Forms.DateTimePicker();
            this.gender = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.watch_res = new System.Windows.Forms.Button();
            this.nation = new System.Windows.Forms.ComboBox();
            this.town = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fam_name
            // 
            this.fam_name.Location = new System.Drawing.Point(142, 41);
            this.fam_name.Name = "fam_name";
            this.fam_name.Size = new System.Drawing.Size(431, 20);
            this.fam_name.TabIndex = 0;
            // 
            // behalf
            // 
            this.behalf.Location = new System.Drawing.Point(142, 80);
            this.behalf.Name = "behalf";
            this.behalf.Size = new System.Drawing.Size(431, 20);
            this.behalf.TabIndex = 1;
            // 
            // quest
            // 
            this.quest.AutoSize = true;
            this.quest.Location = new System.Drawing.Point(72, 9);
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(42, 13);
            this.quest.TabIndex = 3;
            this.quest.Text = "анкета";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(71, 44);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(53, 13);
            this.surname.TabIndex = 4;
            this.surname.Text = "фамилия";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(72, 83);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(27, 13);
            this.name.TabIndex = 5;
            this.name.Text = "имя";
            // 
            // patronymic
            // 
            this.patronymic.AutoSize = true;
            this.patronymic.Location = new System.Drawing.Point(72, 127);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(52, 13);
            this.patronymic.TabIndex = 6;
            this.patronymic.Text = "отчество";
            // 
            // patr
            // 
            this.patr.Location = new System.Drawing.Point(142, 120);
            this.patr.Name = "patr";
            this.patr.Size = new System.Drawing.Size(431, 20);
            this.patr.TabIndex = 2;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(142, 253);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(431, 20);
            this.telephone.TabIndex = 9;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(72, 173);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(42, 13);
            this.country.TabIndex = 10;
            this.country.Text = "страна";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(72, 215);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(36, 13);
            this.city.TabIndex = 11;
            this.city.Text = "город";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(71, 256);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(50, 13);
            this.phone.TabIndex = 12;
            this.phone.Text = "телефон";
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Location = new System.Drawing.Point(71, 317);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(83, 13);
            this.birthdate.TabIndex = 13;
            this.birthdate.Text = "дата рождения";
            // 
            // birth_day
            // 
            this.birth_day.Location = new System.Drawing.Point(178, 310);
            this.birth_day.Name = "birth_day";
            this.birth_day.Size = new System.Drawing.Size(200, 20);
            this.birth_day.TabIndex = 14;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(71, 361);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(28, 13);
            this.gender.TabIndex = 15;
            this.gender.Text = "пол:";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(178, 359);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(70, 17);
            this.male.TabIndex = 16;
            this.male.TabStop = true;
            this.male.Text = "мужской";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(293, 357);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(69, 17);
            this.female.TabIndex = 17;
            this.female.TabStop = true;
            this.female.Text = "женский";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // watch_res
            // 
            this.watch_res.Location = new System.Drawing.Point(178, 398);
            this.watch_res.Name = "watch_res";
            this.watch_res.Size = new System.Drawing.Size(200, 23);
            this.watch_res.TabIndex = 18;
            this.watch_res.Text = "просмотреть результаты";
            this.watch_res.UseVisualStyleBackColor = true;
            this.watch_res.Click += new System.EventHandler(this.watch_res_Click);
            // 
            // nation
            // 
            this.nation.FormattingEnabled = true;
            this.nation.Items.AddRange(new object[] {
            "беларусь",
            "россия",
            "украина"});
            this.nation.Location = new System.Drawing.Point(142, 173);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(431, 21);
            this.nation.TabIndex = 19;
            this.nation.SelectedIndexChanged += new System.EventHandler(this.nation_SelectedIndexChanged);
            // 
            // town
            // 
            this.town.FormattingEnabled = true;
            this.town.Location = new System.Drawing.Point(142, 212);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(431, 21);
            this.town.TabIndex = 20;
            // 
            // questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.town);
            this.Controls.Add(this.nation);
            this.Controls.Add(this.watch_res);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.birth_day);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.quest);
            this.Controls.Add(this.patr);
            this.Controls.Add(this.behalf);
            this.Controls.Add(this.fam_name);
            this.Name = "questionnaire";
            this.Text = "анкета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fam_name;
        private System.Windows.Forms.TextBox behalf;
        private System.Windows.Forms.Label quest;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label patronymic;
        private System.Windows.Forms.TextBox patr;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.DateTimePicker birth_day;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Button watch_res;
        private System.Windows.Forms.ComboBox nation;
        private System.Windows.Forms.ComboBox town;
    }
}

