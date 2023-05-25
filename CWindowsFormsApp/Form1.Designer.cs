namespace CWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.Location = new System.Drawing.Point(274, 216);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(450, 41);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Text = "aiueo@example.com";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(54, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 67);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(481, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.Location = new System.Drawing.Point(274, 72);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(450, 41);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.Text = "name";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

