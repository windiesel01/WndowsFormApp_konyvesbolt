namespace WndowsFormApp_konyvesbolt
{
    partial class VasarlokInsert
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
            this.button_feltoltes = new System.Windows.Forms.Button();
            this.textBox_felhasznalonev = new System.Windows.Forms.TextBox();
            this.textBox_emailcim = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_szuletesidatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button_feltoltes
            // 
            this.button_feltoltes.Location = new System.Drawing.Point(489, 196);
            this.button_feltoltes.Name = "button_feltoltes";
            this.button_feltoltes.Size = new System.Drawing.Size(174, 47);
            this.button_feltoltes.TabIndex = 17;
            this.button_feltoltes.Text = "Feltöltés";
            this.button_feltoltes.UseVisualStyleBackColor = true;
            this.button_feltoltes.Click += new System.EventHandler(this.button_feltoltes_Click);
            // 
            // textBox_felhasznalonev
            // 
            this.textBox_felhasznalonev.Location = new System.Drawing.Point(282, 266);
            this.textBox_felhasznalonev.Name = "textBox_felhasznalonev";
            this.textBox_felhasznalonev.Size = new System.Drawing.Size(148, 20);
            this.textBox_felhasznalonev.TabIndex = 16;
            // 
            // textBox_emailcim
            // 
            this.textBox_emailcim.Location = new System.Drawing.Point(282, 233);
            this.textBox_emailcim.Name = "textBox_emailcim";
            this.textBox_emailcim.Size = new System.Drawing.Size(148, 20);
            this.textBox_emailcim.TabIndex = 15;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(282, 165);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(148, 20);
            this.textBox_nev.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Felhasználónév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email-cím";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Születási dátum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Név:";
            // 
            // dateTimePicker_szuletesidatum
            // 
            this.dateTimePicker_szuletesidatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_szuletesidatum.Location = new System.Drawing.Point(282, 196);
            this.dateTimePicker_szuletesidatum.Name = "dateTimePicker_szuletesidatum";
            this.dateTimePicker_szuletesidatum.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker_szuletesidatum.TabIndex = 21;
            // 
            // VasarlokInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_szuletesidatum);
            this.Controls.Add(this.button_feltoltes);
            this.Controls.Add(this.textBox_felhasznalonev);
            this.Controls.Add(this.textBox_emailcim);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VasarlokInsert";
            this.Text = "VasarlokInsert";
            this.Load += new System.EventHandler(this.VasarlokInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_feltoltes;
        public System.Windows.Forms.TextBox textBox_felhasznalonev;
        public System.Windows.Forms.TextBox textBox_emailcim;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.DateTimePicker dateTimePicker_szuletesidatum;
    }
}