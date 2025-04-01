namespace Шаблонизатор_для_приватных_ссылок_RuTube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] idAndKey;
            if (textBox1_SrcURL.Text != "")
            {
                idAndKey = textBox1_SrcURL.Text.Split('/');
                textBox2_HTML.Text = $"<iframe width=\"720\" height=\"405\" src=\"https://rutube.ru/play/embed/{idAndKey[5]}/{idAndKey[6]}\" " +
                    $"frameBorder=\"0\" allow=\"clipboard-write; autoplay\" webkitAllowFullScreen mozallowfullscreen allowFullScreen></iframe>";
                textBox3_FullText.Text = textBox2_HTML.Text + $"<br><br>Если вы видите ошибку, то видео доступно по ссылке: {textBox1_SrcURL.Text}<br>";
            }
            else MessageBox.Show("Пустой ввод");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1_SrcURL.Clear();
            textBox2_HTML.Clear();
            textBox3_FullText.Clear();
        }

        private void button3_copyHTML_Click(object sender, EventArgs e)
        {
            if (textBox2_HTML.Text != "")
            {
                Clipboard.SetText(textBox2_HTML.Text);
                SetButtonTextTemporarily(button3_copyHTML, "Скопировано...");
            }
            else MessageBox.Show("Пустой ввод");
        }

        private void button4_copyFullText_Click(object sender, EventArgs e)
        {
            if (textBox3_FullText.Text != "")
            {
                Clipboard.SetText(textBox3_FullText.Text);
                SetButtonTextTemporarily(button4_copyFullText, "Скопировано...");
            }
            else MessageBox.Show("Пустой ввод");
        }
        private void SetButtonTextTemporarily(Button button, string tempText)
        {
            string initialText = button.Text; // Сохраняем исходный текст текущей кнопки

            button.Text = tempText;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 3000, Enabled = true }; // Таймер на три секунды

            timer.Tick += (s, args) =>
            {
                button.Text = initialText; // Восстанавливаем исходный текст *этой* кнопки
                timer.Stop();
                timer.Dispose();
            };
        }
    }
}
