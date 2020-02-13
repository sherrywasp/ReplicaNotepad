namespace ReplicaNotepad
{
    partial class FormGoTo
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
            this.label1 = new System.Windows.Forms.Label();
            this.numLineNum = new System.Windows.Forms.NumericUpDown();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "行 号：";
            // 
            // numLineNum
            // 
            this.numLineNum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLineNum.Location = new System.Drawing.Point(75, 12);
            this.numLineNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numLineNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLineNum.Name = "numLineNum";
            this.numLineNum.Size = new System.Drawing.Size(120, 27);
            this.numLineNum.TabIndex = 0;
            this.numLineNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLineNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGoTo
            // 
            this.btnGoTo.AutoSize = true;
            this.btnGoTo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGoTo.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoTo.Location = new System.Drawing.Point(28, 56);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(75, 29);
            this.btnGoTo.TabIndex = 1;
            this.btnGoTo.Text = "转 到";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(109, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 96);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.numLineNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGoTo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "转到指定行";
            ((System.ComponentModel.ISupportInitialize)(this.numLineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLineNum;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnCancel;
    }
}