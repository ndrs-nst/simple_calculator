namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.enterButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.num0Button = new System.Windows.Forms.Button();
            this.signChangeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.num3Button = new System.Windows.Forms.Button();
            this.num2Button = new System.Windows.Forms.Button();
            this.num1Button = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.num6Button = new System.Windows.Forms.Button();
            this.num5Button = new System.Windows.Forms.Button();
            this.num4Button = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.num9Button = new System.Windows.Forms.Button();
            this.num8Button = new System.Windows.Forms.Button();
            this.num7Button = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.subDisplayTextBox = new System.Windows.Forms.TextBox();
            this.mainDisplayTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.enterButton, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.decimalButton, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.num0Button, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.signChangeButton, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.addButton, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.num3Button, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.num2Button, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.num1Button, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.substractButton, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.num6Button, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.num5Button, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.num4Button, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.multiplyButton, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.num9Button, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.num8Button, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.num7Button, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.divideButton, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.backspaceButton, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.clearButton, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.clearEntryButton, 0, 0);
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 100);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(396, 321);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.enterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enterButton.Location = new System.Drawing.Point(297, 256);
            this.enterButton.Margin = new System.Windows.Forms.Padding(0);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(99, 65);
            this.enterButton.TabIndex = 19;
            this.enterButton.Text = "=";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.Location = new System.Drawing.Point(198, 256);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(0);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(99, 65);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // num0Button
            // 
            this.num0Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num0Button.Location = new System.Drawing.Point(99, 256);
            this.num0Button.Margin = new System.Windows.Forms.Padding(0);
            this.num0Button.Name = "num0Button";
            this.num0Button.Size = new System.Drawing.Size(99, 65);
            this.num0Button.TabIndex = 17;
            this.num0Button.Text = "0";
            this.num0Button.UseVisualStyleBackColor = true;
            this.num0Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // signChangeButton
            // 
            this.signChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signChangeButton.Location = new System.Drawing.Point(0, 256);
            this.signChangeButton.Margin = new System.Windows.Forms.Padding(0);
            this.signChangeButton.Name = "signChangeButton";
            this.signChangeButton.Size = new System.Drawing.Size(99, 65);
            this.signChangeButton.TabIndex = 16;
            this.signChangeButton.Text = "±";
            this.signChangeButton.UseVisualStyleBackColor = true;
            this.signChangeButton.Click += new System.EventHandler(this.signChangeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(297, 192);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 64);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // num3Button
            // 
            this.num3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3Button.Location = new System.Drawing.Point(198, 192);
            this.num3Button.Margin = new System.Windows.Forms.Padding(0);
            this.num3Button.Name = "num3Button";
            this.num3Button.Size = new System.Drawing.Size(99, 64);
            this.num3Button.TabIndex = 14;
            this.num3Button.Text = "3";
            this.num3Button.UseVisualStyleBackColor = true;
            this.num3Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // num2Button
            // 
            this.num2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2Button.Location = new System.Drawing.Point(99, 192);
            this.num2Button.Margin = new System.Windows.Forms.Padding(0);
            this.num2Button.Name = "num2Button";
            this.num2Button.Size = new System.Drawing.Size(99, 64);
            this.num2Button.TabIndex = 13;
            this.num2Button.Text = "2";
            this.num2Button.UseVisualStyleBackColor = true;
            this.num2Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // num1Button
            // 
            this.num1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1Button.Location = new System.Drawing.Point(0, 192);
            this.num1Button.Margin = new System.Windows.Forms.Padding(0);
            this.num1Button.Name = "num1Button";
            this.num1Button.Size = new System.Drawing.Size(99, 64);
            this.num1Button.TabIndex = 12;
            this.num1Button.Text = "1";
            this.num1Button.UseVisualStyleBackColor = true;
            this.num1Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.substractButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.substractButton.Location = new System.Drawing.Point(297, 128);
            this.substractButton.Margin = new System.Windows.Forms.Padding(0);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(99, 64);
            this.substractButton.TabIndex = 11;
            this.substractButton.Text = "-";
            this.substractButton.UseVisualStyleBackColor = false;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // num6Button
            // 
            this.num6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num6Button.Location = new System.Drawing.Point(198, 128);
            this.num6Button.Margin = new System.Windows.Forms.Padding(0);
            this.num6Button.Name = "num6Button";
            this.num6Button.Size = new System.Drawing.Size(99, 64);
            this.num6Button.TabIndex = 10;
            this.num6Button.Text = "6";
            this.num6Button.UseVisualStyleBackColor = true;
            this.num6Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // num5Button
            // 
            this.num5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num5Button.Location = new System.Drawing.Point(99, 128);
            this.num5Button.Margin = new System.Windows.Forms.Padding(0);
            this.num5Button.Name = "num5Button";
            this.num5Button.Size = new System.Drawing.Size(99, 64);
            this.num5Button.TabIndex = 9;
            this.num5Button.Text = "5";
            this.num5Button.UseVisualStyleBackColor = true;
            this.num5Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // num4Button
            // 
            this.num4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4Button.Location = new System.Drawing.Point(0, 128);
            this.num4Button.Margin = new System.Windows.Forms.Padding(0);
            this.num4Button.Name = "num4Button";
            this.num4Button.Size = new System.Drawing.Size(99, 64);
            this.num4Button.TabIndex = 8;
            this.num4Button.Text = "4";
            this.num4Button.UseVisualStyleBackColor = true;
            this.num4Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyButton.Location = new System.Drawing.Point(297, 64);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(0);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(99, 64);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // num9Button
            // 
            this.num9Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num9Button.Location = new System.Drawing.Point(198, 64);
            this.num9Button.Margin = new System.Windows.Forms.Padding(0);
            this.num9Button.Name = "num9Button";
            this.num9Button.Size = new System.Drawing.Size(99, 64);
            this.num9Button.TabIndex = 6;
            this.num9Button.Text = "9";
            this.num9Button.UseVisualStyleBackColor = true;
            this.num9Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // num8Button
            // 
            this.num8Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num8Button.Location = new System.Drawing.Point(99, 64);
            this.num8Button.Margin = new System.Windows.Forms.Padding(0);
            this.num8Button.Name = "num8Button";
            this.num8Button.Size = new System.Drawing.Size(99, 64);
            this.num8Button.TabIndex = 5;
            this.num8Button.Text = "8";
            this.num8Button.UseVisualStyleBackColor = true;
            this.num8Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // num7Button
            // 
            this.num7Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.num7Button.Location = new System.Drawing.Point(0, 64);
            this.num7Button.Margin = new System.Windows.Forms.Padding(0);
            this.num7Button.Name = "num7Button";
            this.num7Button.Size = new System.Drawing.Size(99, 64);
            this.num7Button.TabIndex = 4;
            this.num7Button.Text = "7";
            this.num7Button.UseVisualStyleBackColor = true;
            this.num7Button.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.divideButton.Location = new System.Drawing.Point(297, 0);
            this.divideButton.Margin = new System.Windows.Forms.Padding(0);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(99, 64);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.backspaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceButton.Location = new System.Drawing.Point(198, 0);
            this.backspaceButton.Margin = new System.Windows.Forms.Padding(0);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(99, 64);
            this.backspaceButton.TabIndex = 2;
            this.backspaceButton.Text = "↩";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.clearButton.Location = new System.Drawing.Point(99, 0);
            this.clearButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 64);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearEntryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryButton.Location = new System.Drawing.Point(0, 0);
            this.clearEntryButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(99, 64);
            this.clearEntryButton.TabIndex = 0;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = false;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // subDisplayTextBox
            // 
            this.subDisplayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subDisplayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.subDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subDisplayTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subDisplayTextBox.Location = new System.Drawing.Point(9, 11);
            this.subDisplayTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.subDisplayTextBox.Name = "subDisplayTextBox";
            this.subDisplayTextBox.ReadOnly = true;
            this.subDisplayTextBox.Size = new System.Drawing.Size(396, 24);
            this.subDisplayTextBox.TabIndex = 0;
            this.subDisplayTextBox.TabStop = false;
            this.subDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainDisplayTextBox
            // 
            this.mainDisplayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDisplayTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplayTextBox.Location = new System.Drawing.Point(9, 35);
            this.mainDisplayTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.mainDisplayTextBox.Name = "mainDisplayTextBox";
            this.mainDisplayTextBox.ReadOnly = true;
            this.mainDisplayTextBox.Size = new System.Drawing.Size(396, 55);
            this.mainDisplayTextBox.TabIndex = 1;
            this.mainDisplayTextBox.TabStop = false;
            this.mainDisplayTextBox.Text = "0";
            this.mainDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 431);
            this.Controls.Add(this.subDisplayTextBox);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.mainDisplayTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subDisplayTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button num0Button;
        private System.Windows.Forms.Button signChangeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button num3Button;
        private System.Windows.Forms.Button num2Button;
        private System.Windows.Forms.Button num1Button;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button num6Button;
        private System.Windows.Forms.Button num5Button;
        private System.Windows.Forms.Button num4Button;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button num9Button;
        private System.Windows.Forms.Button num8Button;
        private System.Windows.Forms.Button num7Button;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.TextBox mainDisplayTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}

