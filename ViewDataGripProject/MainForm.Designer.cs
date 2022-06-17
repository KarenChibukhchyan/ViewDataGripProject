namespace ViewDataGripProject;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxAge = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnAge});
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(504, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(504, 343);
            this.dataGridView1.TabIndex = 0;
            //
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 300;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            // 
            // checkBoxAge
            // 
            this.checkBoxAge.AutoSize = true;
            this.checkBoxAge.Location = new System.Drawing.Point(12, 64);
            this.checkBoxAge.Name = "checkBoxAge";
            this.checkBoxAge.Size = new System.Drawing.Size(90, 19);
            this.checkBoxAge.TabIndex = 3;
            this.checkBoxAge.Text = "Filter by age";
            this.checkBoxAge.UseVisualStyleBackColor = true;
            this.checkBoxAge.CheckedChanged += new System.EventHandler(this.checkBoxAge_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(12, 35);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(101, 19);
            this.checkBoxName.TabIndex = 4;
            this.checkBoxName.Text = "Filter by name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Enabled = false;
            this.textBoxAge.Location = new System.Drawing.Point(125, 60);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 23);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.Leave += new System.EventHandler(this.textBoxAge_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(125, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(125, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Location = new System.Drawing.Point(12, 6);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(82, 19);
            this.checkBoxID.TabIndex = 8;
            this.checkBoxID.Text = "Filter by ID";
            this.checkBoxID.UseVisualStyleBackColor = true;
            this.checkBoxID.CheckedChanged += new System.EventHandler(this.checkBoxID_CheckedChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ViewDataGripProject.Person);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(ViewDataGripProject.Person);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.checkBoxID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxAge);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 489);
            this.Name = "MainForm";
            this.Text = "Person Service Example";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DataGridView dataGridView1;
    private CheckBox checkBoxAge;
    private CheckBox checkBoxName;
    private TextBox textBoxAge;
    private TextBox textBoxName;
    private DataGridViewTextBoxColumn ColumnID;
    private DataGridViewTextBoxColumn ColumnName;
    private DataGridViewTextBoxColumn ColumnAge;
    private TextBox textBoxID;
    private CheckBox checkBoxID;
    private BindingSource personBindingSource;
    private BindingSource personBindingSource1;
}