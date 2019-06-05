namespace Assignment2.View.UserOP
{
    partial class SellWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(167, 101);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(198, 26);
            this.titleBox.TabIndex = 3;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(167, 152);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(198, 26);
            this.authorBox.TabIndex = 4;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(167, 202);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(198, 26);
            this.quantityBox.TabIndex = 5;
            this.quantityBox.TextChanged += new System.EventHandler(this.QuantityBox_TextChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(94, 267);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(48, 20);
            this.Label.TabIndex = 6;
            this.Label.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(200, 267);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(57, 20);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "0 RON";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(204, 345);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(86, 40);
            this.sellButton.TabIndex = 8;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // SellWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellWindow";
            this.Text = "SellWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button sellButton;
    }
}