namespace r12
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDbDataSet = new r12.LibraryDbDataSet();
            this.tovariTableAdapter = new r12.LibraryDbDataSetTableAdapters.TovariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.klientDataGridViewTextBoxColumn,
            this.tovarDataGridViewTextBoxColumn,
            this.kolichestvoDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripLabel,
            this.iDToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(488, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // iDToolStripLabel
            // 
            this.iDToolStripLabel.Name = "iDToolStripLabel";
            this.iDToolStripLabel.Size = new System.Drawing.Size(21, 22);
            this.iDToolStripLabel.Text = "ID:";
            // 
            // iDToolStripTextBox
            // 
            this.iDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iDToolStripTextBox.Name = "iDToolStripTextBox";
            this.iDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // klientDataGridViewTextBoxColumn
            // 
            this.klientDataGridViewTextBoxColumn.DataPropertyName = "Klient";
            this.klientDataGridViewTextBoxColumn.HeaderText = "Klient";
            this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            // 
            // tovarDataGridViewTextBoxColumn
            // 
            this.tovarDataGridViewTextBoxColumn.DataPropertyName = "Tovar";
            this.tovarDataGridViewTextBoxColumn.HeaderText = "Tovar";
            this.tovarDataGridViewTextBoxColumn.Name = "tovarDataGridViewTextBoxColumn";
            // 
            // kolichestvoDataGridViewTextBoxColumn
            // 
            this.kolichestvoDataGridViewTextBoxColumn.DataPropertyName = "kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.HeaderText = "kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.Name = "kolichestvoDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // tovariBindingSource
            // 
            this.tovariBindingSource.DataMember = "Tovari";
            this.tovariBindingSource.DataSource = this.libraryDbDataSet;
            // 
            // libraryDbDataSet
            // 
            this.libraryDbDataSet.DataSetName = "LibraryDbDataSet";
            this.libraryDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovariTableAdapter
            // 
            this.tovariTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 312);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private LibraryDbDataSet libraryDbDataSet;
        private System.Windows.Forms.BindingSource tovariBindingSource;
        private LibraryDbDataSetTableAdapters.TovariTableAdapter tovariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel iDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}