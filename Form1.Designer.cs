namespace Шаблонизатор_для_приватных_ссылок_RuTube
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1_SrcURL = new TextBox();
            textBox2_HTML = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1_urlGen = new Button();
            label3 = new Label();
            textBox3_FullText = new TextBox();
            button2_clearFolders = new Button();
            button3_copyHTML = new Button();
            button4_copyFullText = new Button();
            SuspendLayout();
            // 
            // textBox1_SrcURL
            // 
            textBox1_SrcURL.Location = new Point(12, 35);
            textBox1_SrcURL.Name = "textBox1_SrcURL";
            textBox1_SrcURL.Size = new Size(487, 23);
            textBox1_SrcURL.TabIndex = 0;
            // 
            // textBox2_HTML
            // 
            textBox2_HTML.Location = new Point(12, 87);
            textBox2_HTML.Name = "textBox2_HTML";
            textBox2_HTML.Size = new Size(487, 23);
            textBox2_HTML.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Исходная ссылка:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Код для вставки:";
            // 
            // button1_urlGen
            // 
            button1_urlGen.Location = new Point(505, 35);
            button1_urlGen.Name = "button1_urlGen";
            button1_urlGen.Size = new Size(147, 23);
            button1_urlGen.TabIndex = 4;
            button1_urlGen.Text = "Генерировать ссылку";
            button1_urlGen.UseVisualStyleBackColor = true;
            button1_urlGen.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 5;
            label3.Text = "Код с текстом для вставки:";
            // 
            // textBox3_FullText
            // 
            textBox3_FullText.Location = new Point(12, 131);
            textBox3_FullText.Name = "textBox3_FullText";
            textBox3_FullText.Size = new Size(487, 23);
            textBox3_FullText.TabIndex = 6;
            // 
            // button2_clearFolders
            // 
            button2_clearFolders.Location = new Point(658, 34);
            button2_clearFolders.Name = "button2_clearFolders";
            button2_clearFolders.Size = new Size(147, 23);
            button2_clearFolders.TabIndex = 7;
            button2_clearFolders.Text = "Очистить";
            button2_clearFolders.UseVisualStyleBackColor = true;
            button2_clearFolders.Click += button2_Click;
            // 
            // button3_copyHTML
            // 
            button3_copyHTML.Location = new Point(505, 87);
            button3_copyHTML.Name = "button3_copyHTML";
            button3_copyHTML.Size = new Size(147, 23);
            button3_copyHTML.TabIndex = 8;
            button3_copyHTML.Text = "Копировать";
            button3_copyHTML.UseVisualStyleBackColor = true;
            button3_copyHTML.Click += button3_copyHTML_Click;
            // 
            // button4_copyFullText
            // 
            button4_copyFullText.Location = new Point(505, 131);
            button4_copyFullText.Name = "button4_copyFullText";
            button4_copyFullText.Size = new Size(147, 23);
            button4_copyFullText.TabIndex = 9;
            button4_copyFullText.Text = "Копировать";
            button4_copyFullText.UseVisualStyleBackColor = true;
            button4_copyFullText.Click += button4_copyFullText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 183);
            Controls.Add(button4_copyFullText);
            Controls.Add(button3_copyHTML);
            Controls.Add(button2_clearFolders);
            Controls.Add(textBox3_FullText);
            Controls.Add(label3);
            Controls.Add(button1_urlGen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2_HTML);
            Controls.Add(textBox1_SrcURL);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "RUTUBE PRIVATE URL TO HTML GENERATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1_SrcURL;
        private TextBox textBox2_HTML;
        private Label label1;
        private Label label2;
        private Button button1_urlGen;
        private Label label3;
        private TextBox textBox3_FullText;
        private Button button2_clearFolders;
        private Button button3_copyHTML;
        private Button button4_copyFullText;
    }
}
