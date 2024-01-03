
namespace EvaluasiLKS
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hero1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hero2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hero1TotalPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hero2TotalPowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fightDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EvaluasiLKS.FightHistory);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hero1IDDataGridViewTextBoxColumn,
            this.hero2IDDataGridViewTextBoxColumn,
            this.hero1TotalPowerDataGridViewTextBoxColumn,
            this.hero2TotalPowerDataGridViewTextBoxColumn,
            this.fightDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(76, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(925, 191);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // hero1IDDataGridViewTextBoxColumn
            // 
            this.hero1IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hero1IDDataGridViewTextBoxColumn.DataPropertyName = "Hero1ID";
            this.hero1IDDataGridViewTextBoxColumn.HeaderText = "Hero 1";
            this.hero1IDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hero1IDDataGridViewTextBoxColumn.Name = "hero1IDDataGridViewTextBoxColumn";
            this.hero1IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hero2IDDataGridViewTextBoxColumn
            // 
            this.hero2IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hero2IDDataGridViewTextBoxColumn.DataPropertyName = "Hero2ID";
            this.hero2IDDataGridViewTextBoxColumn.HeaderText = "Hero 2";
            this.hero2IDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hero2IDDataGridViewTextBoxColumn.Name = "hero2IDDataGridViewTextBoxColumn";
            this.hero2IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hero1TotalPowerDataGridViewTextBoxColumn
            // 
            this.hero1TotalPowerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hero1TotalPowerDataGridViewTextBoxColumn.DataPropertyName = "Hero1TotalPower";
            this.hero1TotalPowerDataGridViewTextBoxColumn.HeaderText = "Hero1 Total Power";
            this.hero1TotalPowerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hero1TotalPowerDataGridViewTextBoxColumn.Name = "hero1TotalPowerDataGridViewTextBoxColumn";
            this.hero1TotalPowerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hero2TotalPowerDataGridViewTextBoxColumn
            // 
            this.hero2TotalPowerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hero2TotalPowerDataGridViewTextBoxColumn.DataPropertyName = "Hero2TotalPower";
            this.hero2TotalPowerDataGridViewTextBoxColumn.HeaderText = "Hero 2 Total Power";
            this.hero2TotalPowerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hero2TotalPowerDataGridViewTextBoxColumn.Name = "hero2TotalPowerDataGridViewTextBoxColumn";
            this.hero2TotalPowerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fightDateDataGridViewTextBoxColumn
            // 
            this.fightDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fightDateDataGridViewTextBoxColumn.DataPropertyName = "FightDate";
            this.fightDateDataGridViewTextBoxColumn.HeaderText = "Fight Date";
            this.fightDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fightDateDataGridViewTextBoxColumn.Name = "fightDateDataGridViewTextBoxColumn";
            this.fightDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fight Report";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hero1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hero2IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hero1TotalPowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hero2TotalPowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fightDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}