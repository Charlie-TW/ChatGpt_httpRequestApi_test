namespace CsWinFormsApp_ChatGptTest
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_ask = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(111, 22);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(394, 27);
            this.textBox_input.TabIndex = 0;
            // 
            // label_ask
            // 
            this.label_ask.AutoSize = true;
            this.label_ask.Location = new System.Drawing.Point(13, 22);
            this.label_ask.Name = "label_ask";
            this.label_ask.Size = new System.Drawing.Size(92, 20);
            this.label_ask.TabIndex = 1;
            this.label_ask.Text = "請輸入問題：";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(511, 20);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(94, 29);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "發送";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Location = new System.Drawing.Point(12, 60);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(593, 378);
            this.richTextBox_result.TabIndex = 3;
            this.richTextBox_result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_result);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_ask);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_input;
        private Label label_ask;
        private Button button_submit;
        private RichTextBox richTextBox_result;
    }
}