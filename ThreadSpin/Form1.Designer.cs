namespace ThreadSpin
{
    partial class Form1
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
            this.list_Text = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_ThreadCount = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Text
            // 
            this.list_Text.FormattingEnabled = true;
            this.list_Text.Location = new System.Drawing.Point(12, 12);
            this.list_Text.Name = "list_Text";
            this.list_Text.Size = new System.Drawing.Size(384, 511);
            this.list_Text.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(456, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(122, 38);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label_ThreadCount
            // 
            this.label_ThreadCount.AutoSize = true;
            this.label_ThreadCount.Location = new System.Drawing.Point(453, 148);
            this.label_ThreadCount.Name = "label_ThreadCount";
            this.label_ThreadCount.Size = new System.Drawing.Size(72, 13);
            this.label_ThreadCount.TabIndex = 2;
            this.label_ThreadCount.Text = "Thread Count";
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(456, 56);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(122, 38);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 537);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.label_ThreadCount);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.list_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Text;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label_ThreadCount;
        private System.Windows.Forms.Button btn_Stop;
    }
}

