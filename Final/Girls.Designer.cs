namespace Final
{
    partial class Girls
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
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.chicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDanceDataSet = new Final.TableDanceDataSet();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtCup = new System.Windows.Forms.TextBox();
            this.txtDanceCost = new System.Windows.Forms.TextBox();
            this.txtNationalitie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPagination = new System.Windows.Forms.TextBox();
            this.btnFisrt = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.chicasTableAdapter = new Final.TableDanceDataSetTableAdapters.ChicasTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployee
            // 
            this.txtEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chicasBindingSource, "Num_empleado", true));
            this.txtEmployee.Location = new System.Drawing.Point(114, 50);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(100, 20);
            this.txtEmployee.TabIndex = 0;
            // 
            // chicasBindingSource
            // 
            this.chicasBindingSource.DataMember = "Chicas";
            this.chicasBindingSource.DataSource = this.tableDanceDataSet;
            // 
            // tableDanceDataSet
            // 
            this.tableDanceDataSet.DataSetName = "TableDanceDataSet";
            this.tableDanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chicasBindingSource, "Nombre", true));
            this.txtName.Location = new System.Drawing.Point(114, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtTable
            // 
            this.txtTable.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chicasBindingSource, "Pista", true));
            this.txtTable.Location = new System.Drawing.Point(114, 167);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(100, 20);
            this.txtTable.TabIndex = 2;
            // 
            // txtCup
            // 
            this.txtCup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chicasBindingSource, "Copa", true));
            this.txtCup.Location = new System.Drawing.Point(114, 228);
            this.txtCup.Name = "txtCup";
            this.txtCup.Size = new System.Drawing.Size(100, 20);
            this.txtCup.TabIndex = 3;
            // 
            // txtDanceCost
            // 
            this.txtDanceCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chicasBindingSource, "Costo_Baile", true));
            this.txtDanceCost.Location = new System.Drawing.Point(114, 291);
            this.txtDanceCost.Name = "txtDanceCost";
            this.txtDanceCost.Size = new System.Drawing.Size(100, 20);
            this.txtDanceCost.TabIndex = 4;
            // 
            // txtNationalitie
            // 
            this.txtNationalitie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chicasBindingSource, "Nacionalidad", true));
            this.txtNationalitie.Location = new System.Drawing.Point(114, 354);
            this.txtNationalitie.Name = "txtNationalitie";
            this.txtNationalitie.Size = new System.Drawing.Size(100, 20);
            this.txtNationalitie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "No. de empleada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Copa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo de baile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nacionalidad";
            // 
            // txtPagination
            // 
            this.txtPagination.Location = new System.Drawing.Point(240, 462);
            this.txtPagination.Name = "txtPagination";
            this.txtPagination.Size = new System.Drawing.Size(100, 20);
            this.txtPagination.TabIndex = 12;
            // 
            // btnFisrt
            // 
            this.btnFisrt.Location = new System.Drawing.Point(42, 459);
            this.btnFisrt.Name = "btnFisrt";
            this.btnFisrt.Size = new System.Drawing.Size(75, 23);
            this.btnFisrt.TabIndex = 13;
            this.btnFisrt.Text = "Primero";
            this.btnFisrt.UseVisualStyleBackColor = true;
            this.btnFisrt.Click += new System.EventHandler(this.btnFisrt_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(139, 460);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Anterior";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(359, 459);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(450, 460);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "Último";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // chicasTableAdapter
            // 
            this.chicasTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.chicasBindingSource, "Foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(293, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Girls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFisrt);
            this.Controls.Add(this.txtPagination);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNationalitie);
            this.Controls.Add(this.txtDanceCost);
            this.Controls.Add(this.txtCup);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmployee);
            this.Name = "Girls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliga su chica";
            this.Load += new System.EventHandler(this.Girls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtCup;
        private System.Windows.Forms.TextBox txtDanceCost;
        private System.Windows.Forms.TextBox txtNationalitie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPagination;
        private System.Windows.Forms.Button btnFisrt;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private TableDanceDataSet tableDanceDataSet;
        private System.Windows.Forms.BindingSource chicasBindingSource;
        private TableDanceDataSetTableAdapters.ChicasTableAdapter chicasTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}