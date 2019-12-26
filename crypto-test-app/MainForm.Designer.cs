namespace crypto_test_app
{
    partial class MainForm
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
            this.txt_message = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_list = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.btn_details = new System.Windows.Forms.Button();
            this.lbl_info_2 = new System.Windows.Forms.Label();
            this.txt_message_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(49, 12);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(167, 20);
            this.txt_message.TabIndex = 0;
            this.txt_message.Text = "coins/list";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(13, 15);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(30, 13);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "Link:";
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(222, 10);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(75, 23);
            this.btn_list.TabIndex = 2;
            this.btn_list.Text = "List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(16, 38);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(281, 251);
            this.list.TabIndex = 3;
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(524, 10);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(75, 23);
            this.btn_details.TabIndex = 6;
            this.btn_details.Text = "Detail";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // lbl_info_2
            // 
            this.lbl_info_2.AutoSize = true;
            this.lbl_info_2.Location = new System.Drawing.Point(315, 15);
            this.lbl_info_2.Name = "lbl_info_2";
            this.lbl_info_2.Size = new System.Drawing.Size(30, 13);
            this.lbl_info_2.TabIndex = 5;
            this.lbl_info_2.Text = "Link:";
            // 
            // txt_message_2
            // 
            this.txt_message_2.Location = new System.Drawing.Point(351, 12);
            this.txt_message_2.Name = "txt_message_2";
            this.txt_message_2.Size = new System.Drawing.Size(167, 20);
            this.txt_message_2.TabIndex = 4;
            this.txt_message_2.Text = "coins/{id}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.lbl_info_2);
            this.Controls.Add(this.txt_message_2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.txt_message);
            this.Name = "MainForm";
            this.Text = "crypto-test-app v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Label lbl_info_2;
        private System.Windows.Forms.TextBox txt_message_2;
        private System.Windows.Forms.Label label1;
    }
}

