
namespace test2
{
    partial class formDB
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
            this.txtChannel = new System.Windows.Forms.Label();
            this.txtRule = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtBookie = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtSta = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "STT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bookie";
            // 
            // txtChannel
            // 
            this.txtChannel.AutoSize = true;
            this.txtChannel.Location = new System.Drawing.Point(298, 36);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(60, 17);
            this.txtChannel.TabIndex = 3;
            this.txtChannel.Text = "Channel";
            // 
            // txtRule
            // 
            this.txtRule.AutoSize = true;
            this.txtRule.Location = new System.Drawing.Point(298, 83);
            this.txtRule.Name = "txtRule";
            this.txtRule.Size = new System.Drawing.Size(37, 17);
            this.txtRule.TabIndex = 4;
            this.txtRule.Text = "Rule";
            // 
            // txtS
            // 
            this.txtS.AutoSize = true;
            this.txtS.Location = new System.Drawing.Point(298, 131);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(17, 17);
            this.txtS.TabIndex = 5;
            this.txtS.Text = "S";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(548, 36);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(48, 17);
            this.txtStatus.TabIndex = 6;
            this.txtStatus.Text = "Status";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(119, 33);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(128, 22);
            this.txtSTT.TabIndex = 7;
            // 
            // txtBookie
            // 
            this.txtBookie.Location = new System.Drawing.Point(119, 128);
            this.txtBookie.Name = "txtBookie";
            this.txtBookie.Size = new System.Drawing.Size(128, 22);
            this.txtBookie.TabIndex = 8;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(119, 80);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(128, 22);
            this.txtAccount.TabIndex = 8;
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(364, 33);
            this.txtCha.Name = "txtCha";
            this.txtCha.Size = new System.Drawing.Size(128, 22);
            this.txtCha.TabIndex = 9;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(364, 80);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(128, 22);
            this.txtR.TabIndex = 10;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(364, 128);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(128, 22);
            this.txtSu.TabIndex = 11;
            // 
            // txtSta
            // 
            this.txtSta.FormattingEnabled = true;
            this.txtSta.Items.AddRange(new object[] {
            "Run",
            "Stop"});
            this.txtSta.Location = new System.Drawing.Point(600, 33);
            this.txtSta.Name = "txtSta";
            this.txtSta.Size = new System.Drawing.Size(140, 24);
            this.txtSta.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 207);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(282, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(474, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 43);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(666, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 43);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 182);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 43);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSta);
            this.Controls.Add(this.txtSu);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtBookie);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtRule);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formDB";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.formDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtChannel;
        private System.Windows.Forms.Label txtRule;
        private System.Windows.Forms.Label txtS;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtBookie;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.ComboBox txtSta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}