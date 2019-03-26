namespace ElanApp
{
    partial class AdvertisementAdding
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
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.nUMBER = new System.Windows.Forms.Label();
            this.button_addhouse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adress";
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(63, 148);
            this.textBox_adress.Multiline = true;
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(165, 70);
            this.textBox_adress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add house";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(63, 295);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(165, 20);
            this.textBox_price.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(383, 148);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(140, 20);
            this.textBox_phonenumber.TabIndex = 6;
            // 
            // nUMBER
            // 
            this.nUMBER.AutoSize = true;
            this.nUMBER.Location = new System.Drawing.Point(392, 105);
            this.nUMBER.Name = "nUMBER";
            this.nUMBER.Size = new System.Drawing.Size(78, 13);
            this.nUMBER.TabIndex = 5;
            this.nUMBER.Text = "Phone Number";
            // 
            // button_addhouse
            // 
            this.button_addhouse.Location = new System.Drawing.Point(530, 380);
            this.button_addhouse.Name = "button_addhouse";
            this.button_addhouse.Size = new System.Drawing.Size(96, 41);
            this.button_addhouse.TabIndex = 9;
            this.button_addhouse.Text = "Add";
            this.button_addhouse.UseVisualStyleBackColor = true;
            this.button_addhouse.Click += new System.EventHandler(this.button_addhouse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = " ";
            // 
            // AdvertisementAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_addhouse);
            this.Controls.Add(this.textBox_phonenumber);
            this.Controls.Add(this.nUMBER);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.label1);
            this.Name = "AdvertisementAdding";
            this.Text = "AdvertisementAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.Label nUMBER;
        private System.Windows.Forms.Button button_addhouse;
        private System.Windows.Forms.Label label4;
    }
}