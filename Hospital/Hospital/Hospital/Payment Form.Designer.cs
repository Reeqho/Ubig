
namespace Hospital
{
    partial class Payment_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.serviceBox = new System.Windows.Forms.MaskedTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.holderBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastupdatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(54, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ItemPaymentList";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "AddNewItemPayment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.nominal,
            this.notes,
            this.btn_delete,
            this.idDataGridViewTextBoxColumn,
            this.paymentidDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.lastupdatedatDataGridViewTextBoxColumn,
            this.deletedatDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(49, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(Hospital.payment_detail);
            this.bindingSource2.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource2_ListChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.submitbtn);
            this.groupBox2.Controls.Add(this.serviceBox);
            this.groupBox2.Controls.Add(this.dateBox);
            this.groupBox2.Controls.Add(this.totalBox);
            this.groupBox2.Controls.Add(this.numberBox);
            this.groupBox2.Controls.Add(this.holderBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(57, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(46, 343);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(200, 28);
            this.submitbtn.TabIndex = 27;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // serviceBox
            // 
            this.serviceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "service_code", true));
            this.serviceBox.Location = new System.Drawing.Point(252, 216);
            this.serviceBox.Margin = new System.Windows.Forms.Padding(4);
            this.serviceBox.Mask = "000";
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(391, 22);
            this.serviceBox.TabIndex = 26;
            this.serviceBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.serviceBox_MaskInputRejected);
            this.serviceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serviceBox_KeyPress);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Hospital.payment);
            // 
            // dateBox
            // 
            this.dateBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "expiration_date", true));
            this.dateBox.Enabled = false;
            this.dateBox.Location = new System.Drawing.Point(252, 159);
            this.dateBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(391, 22);
            this.dateBox.TabIndex = 25;
            this.dateBox.ValueChanged += new System.EventHandler(this.dateBox_ValueChanged);
            // 
            // totalBox
            // 
            this.totalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "total_payment", true));
            this.totalBox.Enabled = false;
            this.totalBox.Location = new System.Drawing.Point(252, 271);
            this.totalBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(391, 22);
            this.totalBox.TabIndex = 24;
            this.totalBox.TextChanged += new System.EventHandler(this.totalBox_TextChanged);
            // 
            // numberBox
            // 
            this.numberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "primary_account_number", true));
            this.numberBox.Location = new System.Drawing.Point(252, 109);
            this.numberBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(391, 22);
            this.numberBox.TabIndex = 23;
            this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
            // 
            // holderBox
            // 
            this.holderBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holderBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "card_holder_name", true));
            this.holderBox.Location = new System.Drawing.Point(252, 55);
            this.holderBox.Margin = new System.Windows.Forms.Padding(4);
            this.holderBox.Name = "holderBox";
            this.holderBox.Size = new System.Drawing.Size(391, 22);
            this.holderBox.TabIndex = 22;
            this.holderBox.TextChanged += new System.EventHandler(this.holderBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Expiration Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Primary Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Holder Name";
            // 
            // item
            // 
            this.item.DataPropertyName = "item";
            this.item.HeaderText = "item";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 63;
            // 
            // nominal
            // 
            this.nominal.DataPropertyName = "nominal";
            this.nominal.HeaderText = "nominal";
            this.nominal.MinimumWidth = 6;
            this.nominal.Name = "nominal";
            this.nominal.ReadOnly = true;
            this.nominal.Width = 125;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "notes";
            this.notes.MinimumWidth = 6;
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 125;
            // 
            // btn_delete
            // 
            this.btn_delete.HeaderText = "Delete";
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ReadOnly = true;
            this.btn_delete.Text = "Deleted";
            this.btn_delete.UseColumnTextForButtonValue = true;
            this.btn_delete.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDataGridViewTextBoxColumn.Width = 125;
            // 
            // nominalDataGridViewTextBoxColumn
            // 
            this.nominalDataGridViewTextBoxColumn.DataPropertyName = "nominal";
            this.nominalDataGridViewTextBoxColumn.HeaderText = "nominal";
            this.nominalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nominalDataGridViewTextBoxColumn.Name = "nominalDataGridViewTextBoxColumn";
            this.nominalDataGridViewTextBoxColumn.ReadOnly = true;
            this.nominalDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdatDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastupdatedatDataGridViewTextBoxColumn
            // 
            this.lastupdatedatDataGridViewTextBoxColumn.DataPropertyName = "last_updated_at";
            this.lastupdatedatDataGridViewTextBoxColumn.HeaderText = "last_updated_at";
            this.lastupdatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastupdatedatDataGridViewTextBoxColumn.Name = "lastupdatedatDataGridViewTextBoxColumn";
            this.lastupdatedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastupdatedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedatDataGridViewTextBoxColumn
            // 
            this.deletedatDataGridViewTextBoxColumn.DataPropertyName = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.HeaderText = "deleted_at";
            this.deletedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedatDataGridViewTextBoxColumn.Name = "deletedatDataGridViewTextBoxColumn";
            this.deletedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedatDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "payment";
            this.paymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 885);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment_Form";
            this.Text = "Payment_Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.MaskedTextBox serviceBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox holderBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewButtonColumn btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastupdatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
    }
}