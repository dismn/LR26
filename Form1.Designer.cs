
namespace LR26
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sendername = new System.Windows.Forms.TextBox();
            this.adressender = new System.Windows.Forms.TextBox();
            this.namerecipient = new System.Windows.Forms.TextBox();
            this.adresrecipient = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "П.І.Б. відправника:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "П.І.Б. одержувача:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адреса одержувача:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адреса відправника:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Поштовий індекс:";
            // 
            // sendername
            // 
            this.sendername.Location = new System.Drawing.Point(236, 85);
            this.sendername.Name = "sendername";
            this.sendername.Size = new System.Drawing.Size(227, 22);
            this.sendername.TabIndex = 5;
            // 
            // adressender
            // 
            this.adressender.Location = new System.Drawing.Point(236, 124);
            this.adressender.Name = "adressender";
            this.adressender.Size = new System.Drawing.Size(227, 22);
            this.adressender.TabIndex = 6;
            // 
            // namerecipient
            // 
            this.namerecipient.Location = new System.Drawing.Point(236, 168);
            this.namerecipient.Name = "namerecipient";
            this.namerecipient.Size = new System.Drawing.Size(227, 22);
            this.namerecipient.TabIndex = 7;
            // 
            // adresrecipient
            // 
            this.adresrecipient.Location = new System.Drawing.Point(236, 209);
            this.adresrecipient.Name = "adresrecipient";
            this.adresrecipient.Size = new System.Drawing.Size(227, 22);
            this.adresrecipient.TabIndex = 8;
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(236, 247);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(227, 22);
            this.index.TabIndex = 9;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(288, 320);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(128, 36);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Створити";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.index);
            this.Controls.Add(this.adresrecipient);
            this.Controls.Add(this.namerecipient);
            this.Controls.Add(this.adressender);
            this.Controls.Add(this.sendername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sendername;
        private System.Windows.Forms.TextBox adressender;
        private System.Windows.Forms.TextBox namerecipient;
        private System.Windows.Forms.TextBox adresrecipient;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Button createButton;
    }
}

