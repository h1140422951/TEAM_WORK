namespace 电子族谱管理系统
{
    partial class 修改信息界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(修改信息界面));
            this.label6 = new System.Windows.Forms.Label();
            this.取消修改 = new System.Windows.Forms.Button();
            this.修改 = new System.Windows.Forms.Button();
            this.族谱号 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.修改密码 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(432, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "(*为必填内容)";
            // 
            // 取消修改
            // 
            this.取消修改.BackColor = System.Drawing.Color.White;
            this.取消修改.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.取消修改.ForeColor = System.Drawing.Color.Black;
            this.取消修改.Location = new System.Drawing.Point(331, 245);
            this.取消修改.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.取消修改.Name = "取消修改";
            this.取消修改.Size = new System.Drawing.Size(67, 34);
            this.取消修改.TabIndex = 21;
            this.取消修改.Text = "取消";
            this.取消修改.UseVisualStyleBackColor = false;
            this.取消修改.Click += new System.EventHandler(this.取消修改_Click);
            // 
            // 修改
            // 
            this.修改.BackColor = System.Drawing.Color.White;
            this.修改.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.修改.ForeColor = System.Drawing.Color.Black;
            this.修改.Location = new System.Drawing.Point(164, 245);
            this.修改.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(67, 34);
            this.修改.TabIndex = 20;
            this.修改.Text = "修改";
            this.修改.UseVisualStyleBackColor = false;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // 族谱号
            // 
            this.族谱号.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.族谱号.Location = new System.Drawing.Point(239, 186);
            this.族谱号.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.族谱号.Name = "族谱号";
            this.族谱号.Size = new System.Drawing.Size(160, 30);
            this.族谱号.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(145, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "族谱号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(403, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // 修改密码
            // 
            this.修改密码.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.修改密码.Location = new System.Drawing.Point(239, 122);
            this.修改密码.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.修改密码.Name = "修改密码";
            this.修改密码.PasswordChar = '*';
            this.修改密码.Size = new System.Drawing.Size(160, 30);
            this.修改密码.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(160, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "密码：";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(236, 69);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 22;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(160, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "账号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // 修改信息界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 374);
            this.Controls.Add(this.label);
            this.Controls.Add(this.取消修改);
            this.Controls.Add(this.修改);
            this.Controls.Add(this.族谱号);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.修改密码);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "修改信息界面";
            this.Text = "修改信息界面";
            this.Load += new System.EventHandler(this.修改信息界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button 取消修改;
        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.TextBox 族谱号;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 修改密码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}