namespace Project_Football_Manager
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.ádas = new System.Windows.Forms.Label();
            this.af = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.Label();
            this.fff = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID_Player = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(334, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 214);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 22);
            this.txtID.TabIndex = 1;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cboType.Location = new System.Drawing.Point(132, 323);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 24);
            this.cboType.TabIndex = 2;
            // 
            // ádas
            // 
            this.ádas.AutoSize = true;
            this.ádas.Location = new System.Drawing.Point(38, 218);
            this.ádas.Name = "ádas";
            this.ádas.Size = new System.Drawing.Size(21, 17);
            this.ádas.TabIndex = 3;
            this.ádas.Text = "ID";
            // 
            // af
            // 
            this.af.AutoSize = true;
            this.af.Location = new System.Drawing.Point(38, 258);
            this.af.Name = "af";
            this.af.Size = new System.Drawing.Size(39, 17);
            this.af.TabIndex = 4;
            this.af.Text = "Pass";
            // 
            // xx
            // 
            this.xx.AutoSize = true;
            this.xx.Location = new System.Drawing.Point(38, 295);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(69, 17);
            this.xx.TabIndex = 5;
            this.xx.Text = "ID_Player";
            // 
            // fff
            // 
            this.fff.AutoSize = true;
            this.fff.Location = new System.Drawing.Point(38, 330);
            this.fff.Name = "fff";
            this.fff.Size = new System.Drawing.Size(40, 17);
            this.fff.TabIndex = 6;
            this.fff.Text = "Type";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(132, 258);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 22);
            this.txtPass.TabIndex = 7;
            // 
            // txtID_Player
            // 
            this.txtID_Player.Location = new System.Drawing.Point(132, 290);
            this.txtID_Player.Name = "txtID_Player";
            this.txtID_Player.Size = new System.Drawing.Size(121, 22);
            this.txtID_Player.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete by ID";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 447);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtID_Player);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.fff);
            this.Controls.Add(this.xx);
            this.Controls.Add(this.af);
            this.Controls.Add(this.ádas);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label ádas;
        private System.Windows.Forms.Label af;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.Label fff;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID_Player;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}