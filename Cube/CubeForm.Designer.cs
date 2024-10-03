namespace Cube
{
    partial class CubeForm
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
            this.redScroll = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeScroll = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.greenScroll = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.blueScroll = new System.Windows.Forms.HScrollBar();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redScroll
            // 
            this.redScroll.Location = new System.Drawing.Point(67, 536);
            this.redScroll.Maximum = 264;
            this.redScroll.Name = "redScroll";
            this.redScroll.Size = new System.Drawing.Size(234, 27);
            this.redScroll.TabIndex = 0;
            this.redScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redScroll_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piros:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Méret:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeScroll
            // 
            this.sizeScroll.Location = new System.Drawing.Point(67, 494);
            this.sizeScroll.Maximum = 109;
            this.sizeScroll.Name = "sizeScroll";
            this.sizeScroll.Size = new System.Drawing.Size(234, 27);
            this.sizeScroll.TabIndex = 2;
            this.sizeScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sizeScroll_Scroll);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zöld:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenScroll
            // 
            this.greenScroll.Location = new System.Drawing.Point(67, 577);
            this.greenScroll.Maximum = 264;
            this.greenScroll.Name = "greenScroll";
            this.greenScroll.Size = new System.Drawing.Size(234, 27);
            this.greenScroll.TabIndex = 6;
            this.greenScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenScroll_Scroll);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kék:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueScroll
            // 
            this.blueScroll.Location = new System.Drawing.Point(67, 617);
            this.blueScroll.Maximum = 264;
            this.blueScroll.Name = "blueScroll";
            this.blueScroll.Size = new System.Drawing.Size(234, 27);
            this.blueScroll.TabIndex = 4;
            this.blueScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueScroll_Scroll);
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greenLabel.ForeColor = System.Drawing.Color.White;
            this.greenLabel.Location = new System.Drawing.Point(304, 577);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(52, 27);
            this.greenLabel.TabIndex = 11;
            this.greenLabel.Text = "0";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(304, 617);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(52, 27);
            this.blueLabel.TabIndex = 10;
            this.blueLabel.Text = "0";
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeLabel
            // 
            this.sizeLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sizeLabel.ForeColor = System.Drawing.Color.White;
            this.sizeLabel.Location = new System.Drawing.Point(304, 494);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(52, 27);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "1";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(304, 536);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(52, 27);
            this.redLabel.TabIndex = 8;
            this.redLabel.Text = "0";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greenScroll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blueScroll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeScroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redScroll);
            this.Name = "CubeForm";
            this.Text = "Kocka";
            this.Resize += new System.EventHandler(this.CubeForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar redScroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar sizeScroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar greenScroll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar blueScroll;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label redLabel;
    }
}

