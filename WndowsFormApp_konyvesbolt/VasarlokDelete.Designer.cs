namespace WndowsFormApp_konyvesbolt
{
    partial class VasarlokDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_emailcim = new System.Windows.Forms.TextBox();
            this.textBox_felhasznalonev = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_vasarloid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_szuletesidatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Születási dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email-cím";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Felhasználónév";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(277, 147);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(148, 20);
            this.textBox_nev.TabIndex = 4;
            // 
            // textBox_emailcim
            // 
            this.textBox_emailcim.Location = new System.Drawing.Point(277, 215);
            this.textBox_emailcim.Name = "textBox_emailcim";
            this.textBox_emailcim.Size = new System.Drawing.Size(148, 20);
            this.textBox_emailcim.TabIndex = 6;
            // 
            // textBox_felhasznalonev
            // 
            this.textBox_felhasznalonev.Location = new System.Drawing.Point(277, 248);
            this.textBox_felhasznalonev.Name = "textBox_felhasznalonev";
            this.textBox_felhasznalonev.Size = new System.Drawing.Size(148, 20);
            this.textBox_felhasznalonev.TabIndex = 7;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(484, 178);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(174, 47);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_vasarloid
            // 
            this.textBox_vasarloid.Location = new System.Drawing.Point(277, 121);
            this.textBox_vasarloid.Name = "textBox_vasarloid";
            this.textBox_vasarloid.Size = new System.Drawing.Size(148, 20);
            this.textBox_vasarloid.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID";
            // 
            // dateTimePicker_szuletesidatum
            // 
            this.dateTimePicker_szuletesidatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_szuletesidatum.Location = new System.Drawing.Point(277, 178);
            this.dateTimePicker_szuletesidatum.Name = "dateTimePicker_szuletesidatum";
            this.dateTimePicker_szuletesidatum.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker_szuletesidatum.TabIndex = 22;
            // 
            // VasarlokDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_szuletesidatum);
            this.Controls.Add(this.textBox_vasarloid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_felhasznalonev);
            this.Controls.Add(this.textBox_emailcim);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VasarlokDelete";
            this.Text = "VasarlokDelete";
            this.Load += new System.EventHandler(this.VasarlokDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.TextBox textBox_emailcim;
        public System.Windows.Forms.TextBox textBox_felhasznalonev;
        public System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.TextBox textBox_vasarloid;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dateTimePicker_szuletesidatum;
    }
}