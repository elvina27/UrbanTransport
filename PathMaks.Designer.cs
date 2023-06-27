namespace UrbanTransport
{
    partial class PathMaks
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
            System.Windows.Forms.Label idPathLabel;
            System.Windows.Forms.Label startPointLabel;
            System.Windows.Forms.Label endPointLabel;
            System.Windows.Forms.Label distanceLabel;
            this.dB_UrbanTransportDataSet = new UrbanTransport.DB_UrbanTransportDataSet();
            this.pathTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathTableTableAdapter = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.PathTableTableAdapter();
            this.tableAdapterManager = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.TableAdapterManager();
            this.idPathLabel1 = new System.Windows.Forms.Label();
            this.startPointTextBox = new System.Windows.Forms.TextBox();
            this.endPointTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            idPathLabel = new System.Windows.Forms.Label();
            startPointLabel = new System.Windows.Forms.Label();
            endPointLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathTableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPathLabel
            // 
            idPathLabel.AutoSize = true;
            idPathLabel.Location = new System.Drawing.Point(33, 40);
            idPathLabel.Name = "idPathLabel";
            idPathLabel.Size = new System.Drawing.Size(51, 16);
            idPathLabel.TabIndex = 1;
            idPathLabel.Text = "Id Path:";
            // 
            // startPointLabel
            // 
            startPointLabel.AutoSize = true;
            startPointLabel.Location = new System.Drawing.Point(32, 84);
            startPointLabel.Name = "startPointLabel";
            startPointLabel.Size = new System.Drawing.Size(70, 16);
            startPointLabel.TabIndex = 3;
            startPointLabel.Text = "Start Point:";
            // 
            // endPointLabel
            // 
            endPointLabel.AutoSize = true;
            endPointLabel.Location = new System.Drawing.Point(32, 129);
            endPointLabel.Name = "endPointLabel";
            endPointLabel.Size = new System.Drawing.Size(67, 16);
            endPointLabel.TabIndex = 5;
            endPointLabel.Text = "End Point:";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new System.Drawing.Point(32, 173);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(63, 16);
            distanceLabel.TabIndex = 7;
            distanceLabel.Text = "Distance:";
            // 
            // dB_UrbanTransportDataSet
            // 
            this.dB_UrbanTransportDataSet.DataSetName = "DB_UrbanTransportDataSet";
            this.dB_UrbanTransportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pathTableBindingSource
            // 
            this.pathTableBindingSource.DataMember = "PathTable";
            this.pathTableBindingSource.DataSource = this.dB_UrbanTransportDataSet;
            // 
            // pathTableTableAdapter
            // 
            this.pathTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PathTableTableAdapter = this.pathTableTableAdapter;
            this.tableAdapterManager.RouteTableTableAdapter = null;
            this.tableAdapterManager.TransportTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UrbanTransport.DB_UrbanTransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idPathLabel1
            // 
            this.idPathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathTableBindingSource, "IdPath", true));
            this.idPathLabel1.Location = new System.Drawing.Point(128, 40);
            this.idPathLabel1.Name = "idPathLabel1";
            this.idPathLabel1.Size = new System.Drawing.Size(100, 23);
            this.idPathLabel1.TabIndex = 2;
            this.idPathLabel1.Text = "label1";
            // 
            // startPointTextBox
            // 
            this.startPointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathTableBindingSource, "StartPoint", true));
            this.startPointTextBox.Location = new System.Drawing.Point(131, 78);
            this.startPointTextBox.Name = "startPointTextBox";
            this.startPointTextBox.Size = new System.Drawing.Size(149, 22);
            this.startPointTextBox.TabIndex = 4;
            // 
            // endPointTextBox
            // 
            this.endPointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathTableBindingSource, "EndPoint", true));
            this.endPointTextBox.Location = new System.Drawing.Point(131, 123);
            this.endPointTextBox.Name = "endPointTextBox";
            this.endPointTextBox.Size = new System.Drawing.Size(149, 22);
            this.endPointTextBox.TabIndex = 6;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathTableBindingSource, "Distance", true));
            this.distanceTextBox.Location = new System.Drawing.Point(131, 170);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(149, 22);
            this.distanceTextBox.TabIndex = 8;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(27, 243);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "Назад";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(179, 243);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Вперед";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(321, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 102);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для админа";
            this.groupBox1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnAdd.Location = new System.Drawing.Point(18, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Добавление";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnChange.Location = new System.Drawing.Point(18, 67);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(190, 23);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Редактирование";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // PathMaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(distanceLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(endPointLabel);
            this.Controls.Add(this.endPointTextBox);
            this.Controls.Add(startPointLabel);
            this.Controls.Add(this.startPointTextBox);
            this.Controls.Add(idPathLabel);
            this.Controls.Add(this.idPathLabel1);
            this.Name = "PathMaks";
            this.Text = "PathMaks";
            this.Load += new System.EventHandler(this.PathMaks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathTableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_UrbanTransportDataSet dB_UrbanTransportDataSet;
        private System.Windows.Forms.BindingSource pathTableBindingSource;
        private DB_UrbanTransportDataSetTableAdapters.PathTableTableAdapter pathTableTableAdapter;
        private DB_UrbanTransportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idPathLabel1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.TextBox startPointTextBox;
        public System.Windows.Forms.TextBox endPointTextBox;
        public System.Windows.Forms.TextBox distanceTextBox;
    }
}