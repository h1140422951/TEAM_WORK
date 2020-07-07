namespace 电子族谱管理系统
{
    partial class 注册界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(注册界面));
            this.label1 = new System.Windows.Forms.Label();
            this.注册账号 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.注册密码 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.族谱号 = new System.Windows.Forms.TextBox();
            this.注册2 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(132, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // 注册账号
            // 
            this.注册账号.Location = new System.Drawing.Point(211, 45);
            this.注册账号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.注册账号.Name = "注册账号";
            this.注册账号.Size = new System.Drawing.Size(160, 25);
            this.注册账号.TabIndex = 1;
            this.注册账号.TextChanged += new System.EventHandler(this.注册账号_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(375, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(132, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码：";
            // 
            // 注册密码
            // 
            this.注册密码.Location = new System.Drawing.Point(211, 109);
            this.注册密码.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.注册密码.Name = "注册密码";
            this.注册密码.PasswordChar = '*';
            this.注册密码.Size = new System.Drawing.Size(160, 25);
            this.注册密码.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(375, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(117, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "族谱号：";
            // 
            // 族谱号
            // 
            this.族谱号.Location = new System.Drawing.Point(211, 172);
            this.族谱号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.族谱号.Name = "族谱号";
            this.族谱号.Size = new System.Drawing.Size(160, 25);
            this.族谱号.TabIndex = 7;
            // 
            // 注册2
            // 
            this.注册2.BackColor = System.Drawing.Color.White;
            this.注册2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.注册2.ForeColor = System.Drawing.Color.Black;
            this.注册2.Location = new System.Drawing.Point(136, 231);
            this.注册2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.注册2.Name = "注册2";
            this.注册2.Size = new System.Drawing.Size(67, 34);
            this.注册2.TabIndex = 8;
            this.注册2.Text = "注册";
            this.注册2.UseVisualStyleBackColor = false;
            this.注册2.Click += new System.EventHandler(this.button1_Click);
            // 
            // 取消
            // 
            this.取消.BackColor = System.Drawing.Color.White;
            this.取消.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.取消.ForeColor = System.Drawing.Color.Black;
            this.取消.Location = new System.Drawing.Point(303, 231);
            this.取消.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(67, 34);
            this.取消.TabIndex = 9;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = false;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(407, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "(*为必填内容)";
            // 
            // 注册界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 306);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.注册2);
            this.Controls.Add(this.族谱号);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.注册密码);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.注册账号);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "注册界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 注册账号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 注册密码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 族谱号;
        private System.Windows.Forms.Button 注册2;
        private System.Windows.Forms.Button 取消;
        private System.Windows.Forms.Label label6;
    }
}