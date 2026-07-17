namespace YandexConfertor_5;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        button1 = new Button();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        richTextBox1 = new RichTextBox();
        textBox4 = new TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        button1.ImageAlign = ContentAlignment.BottomCenter;
        button1.Location = new Point(391, 657);
        button1.Margin = new Padding(300, 4, 300, 4);
        button1.MaximumSize = new Size(163, 55);
        button1.MinimumSize = new Size(163, 55);
        button1.Name = "button1";
        button1.Size = new Size(163, 55);
        button1.TabIndex = 0;
        button1.Text = "Execute";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(14, 175);
        label2.Name = "label2";
        label2.Size = new Size(196, 20);
        label2.TabIndex = 3;
        label2.Text = "Input path of .xlsx or .xls file:";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(14, 265);
        label3.Name = "label3";
        label3.Size = new Size(208, 20);
        label3.TabIndex = 4;
        label3.Text = "Output path of .xlsx or .xls file:";
        label3.Click += label3_Click;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(14, 353);
        label4.Name = "label4";
        label4.Size = new Size(108, 20);
        label4.TabIndex = 5;
        label4.Text = "Yandex API key";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(14, 199);
        textBox1.Margin = new Padding(3, 4, 3, 4);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(661, 27);
        textBox1.TabIndex = 6;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(14, 289);
        textBox2.Margin = new Padding(3, 4, 3, 4);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(661, 27);
        textBox2.TabIndex = 7;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(14, 377);
        textBox3.Margin = new Padding(3, 4, 3, 4);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(661, 27);
        textBox3.TabIndex = 8;
        // 
        // richTextBox1
        // 
        richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        richTextBox1.BackColor = SystemColors.ControlLightLight;
        richTextBox1.Location = new Point(14, 477);
        richTextBox1.Margin = new Padding(3, 4, 3, 4);
        richTextBox1.MinimumSize = new Size(0, 100);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.Size = new Size(914, 171);
        richTextBox1.TabIndex = 9;
        richTextBox1.Text = "";
        // 
        // textBox4
        // 
        textBox4.BorderStyle = BorderStyle.None;
        textBox4.Location = new Point(14, 12);
        textBox4.Multiline = true;
        textBox4.Name = "textBox4";
        textBox4.ReadOnly = true;
        textBox4.Size = new Size(714, 120);
        textBox4.TabIndex = 10;
        textBox4.TabStop = false;
        textBox4.Text = resources.GetString("textBox4.Text");
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(942, 728);
        Controls.Add(textBox4);
        Controls.Add(richTextBox1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(button1);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(750, 750);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private RichTextBox richTextBox1;
    private TextBox textBox4;

    public event EventHandler ButtonClick;

}
