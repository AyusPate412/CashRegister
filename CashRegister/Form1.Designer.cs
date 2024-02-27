namespace CashRegister
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
            this.bananaTitle = new System.Windows.Forms.Label();
            this.airpodsLabel = new System.Windows.Forms.Label();
            this.airpodsInput = new System.Windows.Forms.TextBox();
            this.phonesLabel = new System.Windows.Forms.Label();
            this.phonesInput = new System.Windows.Forms.TextBox();
            this.laptopsInput = new System.Windows.Forms.TextBox();
            this.laptopsLabel = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.calculateChange = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.printReceipt = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bananaTitle
            // 
            this.bananaTitle.AutoSize = true;
            this.bananaTitle.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Bold);
            this.bananaTitle.ForeColor = System.Drawing.Color.Gold;
            this.bananaTitle.Location = new System.Drawing.Point(274, 9);
            this.bananaTitle.Name = "bananaTitle";
            this.bananaTitle.Size = new System.Drawing.Size(213, 51);
            this.bananaTitle.TabIndex = 0;
            this.bananaTitle.Text = "Banana 💻";
            // 
            // airpodsLabel
            // 
            this.airpodsLabel.AutoSize = true;
            this.airpodsLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.airpodsLabel.Location = new System.Drawing.Point(17, 81);
            this.airpodsLabel.Name = "airpodsLabel";
            this.airpodsLabel.Size = new System.Drawing.Size(161, 18);
            this.airpodsLabel.TabIndex = 1;
            this.airpodsLabel.Text = "Number of Airpods";
            this.airpodsLabel.Click += new System.EventHandler(this.airpodsLabel_Click);
            // 
            // airpodsInput
            // 
            this.airpodsInput.Location = new System.Drawing.Point(214, 81);
            this.airpodsInput.Name = "airpodsInput";
            this.airpodsInput.Size = new System.Drawing.Size(67, 20);
            this.airpodsInput.TabIndex = 2;
            this.airpodsInput.TextChanged += new System.EventHandler(this.airpodsBox_TextChanged);
            // 
            // phonesLabel
            // 
            this.phonesLabel.AutoSize = true;
            this.phonesLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.phonesLabel.Location = new System.Drawing.Point(17, 125);
            this.phonesLabel.Name = "phonesLabel";
            this.phonesLabel.Size = new System.Drawing.Size(159, 18);
            this.phonesLabel.TabIndex = 3;
            this.phonesLabel.Text = "Number of Phones";
            // 
            // phonesInput
            // 
            this.phonesInput.Location = new System.Drawing.Point(214, 125);
            this.phonesInput.Name = "phonesInput";
            this.phonesInput.Size = new System.Drawing.Size(67, 20);
            this.phonesInput.TabIndex = 4;
            // 
            // laptopsInput
            // 
            this.laptopsInput.Location = new System.Drawing.Point(214, 167);
            this.laptopsInput.Name = "laptopsInput";
            this.laptopsInput.Size = new System.Drawing.Size(67, 20);
            this.laptopsInput.TabIndex = 5;
            // 
            // laptopsLabel
            // 
            this.laptopsLabel.AutoSize = true;
            this.laptopsLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.laptopsLabel.Location = new System.Drawing.Point(17, 169);
            this.laptopsLabel.Name = "laptopsLabel";
            this.laptopsLabel.Size = new System.Drawing.Size(165, 18);
            this.laptopsLabel.TabIndex = 6;
            this.laptopsLabel.Text = "Number of Laptops";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.calculate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.ForeColor = System.Drawing.Color.Gold;
            this.calculate.Location = new System.Drawing.Point(40, 203);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(226, 33);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.subtotalLabel.Location = new System.Drawing.Point(397, 83);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(88, 18);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal: ";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.taxLabel.Location = new System.Drawing.Point(397, 127);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(44, 18);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            this.taxLabel.Click += new System.EventHandler(this.taxLabel_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Location = new System.Drawing.Point(397, 169);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 18);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.tenderedLabel.Location = new System.Drawing.Point(397, 226);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(91, 18);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(547, 226);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(67, 20);
            this.tenderedInput.TabIndex = 12;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(562, 87);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 13);
            this.subtotalOutput.TabIndex = 13;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(562, 132);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 13);
            this.taxOutput.TabIndex = 14;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Location = new System.Drawing.Point(562, 169);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 13);
            this.totalOutput.TabIndex = 15;
            // 
            // calculateChange
            // 
            this.calculateChange.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateChange.Enabled = false;
            this.calculateChange.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.calculateChange.FlatAppearance.BorderSize = 4;
            this.calculateChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChange.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChange.ForeColor = System.Drawing.Color.Gold;
            this.calculateChange.Location = new System.Drawing.Point(388, 268);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(226, 35);
            this.calculateChange.TabIndex = 16;
            this.calculateChange.Text = "Calculate Change";
            this.calculateChange.UseVisualStyleBackColor = false;
            this.calculateChange.Click += new System.EventHandler(this.calculateChange_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Verdana", 10.75F, System.Drawing.FontStyle.Bold);
            this.changeLabel.Location = new System.Drawing.Point(397, 318);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(75, 18);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(565, 323);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 13);
            this.changeOutput.TabIndex = 18;
            // 
            // receiptOutput
            // 
            this.receiptOutput.AutoSize = true;
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.ForeColor = System.Drawing.Color.Black;
            this.receiptOutput.Location = new System.Drawing.Point(760, 47);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(0, 19);
            this.receiptOutput.TabIndex = 19;
            this.receiptOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printReceipt
            // 
            this.printReceipt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printReceipt.Enabled = false;
            this.printReceipt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.printReceipt.FlatAppearance.BorderSize = 4;
            this.printReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceipt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceipt.ForeColor = System.Drawing.Color.Gold;
            this.printReceipt.Location = new System.Drawing.Point(388, 373);
            this.printReceipt.Name = "printReceipt";
            this.printReceipt.Size = new System.Drawing.Size(226, 35);
            this.printReceipt.TabIndex = 20;
            this.printReceipt.Text = "Print Receipt";
            this.printReceipt.UseVisualStyleBackColor = false;
            this.printReceipt.Click += new System.EventHandler(this.printReceipt_Click);
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newOrder.Enabled = false;
            this.newOrder.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.newOrder.FlatAppearance.BorderSize = 4;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.Color.Gold;
            this.newOrder.Location = new System.Drawing.Point(711, 424);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(226, 35);
            this.newOrder.TabIndex = 21;
            this.newOrder.Text = "New Order";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1107, 461);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.printReceipt);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.laptopsLabel);
            this.Controls.Add(this.laptopsInput);
            this.Controls.Add(this.phonesInput);
            this.Controls.Add(this.phonesLabel);
            this.Controls.Add(this.airpodsInput);
            this.Controls.Add(this.airpodsLabel);
            this.Controls.Add(this.bananaTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Banana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bananaTitle;
        private System.Windows.Forms.Label airpodsLabel;
        private System.Windows.Forms.TextBox airpodsInput;
        private System.Windows.Forms.Label phonesLabel;
        private System.Windows.Forms.TextBox phonesInput;
        private System.Windows.Forms.TextBox laptopsInput;
        private System.Windows.Forms.Label laptopsLabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button printReceipt;
        private System.Windows.Forms.Button newOrder;
    }
}

