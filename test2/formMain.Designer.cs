
namespace test2
{
    partial class Main
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnChannel = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(138, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(192, 12);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(138, 50);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnBot
            // 
            this.btnBot.Location = new System.Drawing.Point(93, 90);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(138, 50);
            this.btnBot.TabIndex = 2;
            this.btnBot.Text = "Bot";
            this.btnBot.UseVisualStyleBackColor = true;
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(372, 12);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(138, 50);
            this.btnCompany.TabIndex = 2;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "Bookie";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnChannel
            // 
            this.btnChannel.Location = new System.Drawing.Point(276, 90);
            this.btnChannel.Name = "btnChannel";
            this.btnChannel.Size = new System.Drawing.Size(138, 50);
            this.btnChannel.TabIndex = 4;
            this.btnChannel.Text = "Channel";
            this.btnChannel.UseVisualStyleBackColor = true;
            // 
            // btnRule
            // 
            this.btnRule.Location = new System.Drawing.Point(454, 90);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(138, 50);
            this.btnRule.TabIndex = 5;
            this.btnRule.Text = "Rule";
            this.btnRule.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 192);
            this.Controls.Add(this.btnRule);
            this.Controls.Add(this.btnChannel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnBot);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnDashboard);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnChannel;
        private System.Windows.Forms.Button btnRule;
    }
}

