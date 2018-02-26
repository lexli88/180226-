namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucTripleClickEvent1 = new WindowsFormsApplication1.UCTripleClickEvent();
            this.SuspendLayout();
            // 
            // ucTripleClickEvent1
            // 
            this.ucTripleClickEvent1.Location = new System.Drawing.Point(29, 50);
            this.ucTripleClickEvent1.Name = "ucTripleClickEvent1";
            this.ucTripleClickEvent1.Size = new System.Drawing.Size(327, 174);
            this.ucTripleClickEvent1.TabIndex = 0;
            this.ucTripleClickEvent1.Load += new System.EventHandler(this.ucTripleClickEvent1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 236);
            this.Controls.Add(this.ucTripleClickEvent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCTripleClickEvent ucTripleClickEvent1;
    }
}

