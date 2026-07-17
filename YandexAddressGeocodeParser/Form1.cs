namespace YandexConfertor_5;

public partial class Form1 : Form
{
    public string InputExcelPath => this.textBox1.Text;

    public string OutputExcelPath => this.textBox2.Text;

    public string YandexApiKey => this.textBox3.Text;

    public void AppendToRichTextBox(string text)
    {
        this.richTextBox1.AppendText(text + Environment.NewLine);
    }

    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.richTextBox1.AppendText("Processing...\n");
        EventHandler buttonClick = this.ButtonClick;
        if (buttonClick == null)
            return;
        buttonClick((object)this, EventArgs.Empty);
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
