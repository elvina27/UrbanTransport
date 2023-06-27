namespace UrbanTransport
{
    partial class AddRoute
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumPas = new System.Windows.Forms.TextBox();
            this.txtNumRoute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCars = new System.Windows.Forms.TextBox();
            this.txtNumStops = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPath = new System.Windows.Forms.ComboBox();
            this.pathTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_UrbanTransportDataSet = new UrbanTransport.DB_UrbanTransportDataSet();
            this.cmbKindTrans = new System.Windows.Forms.ComboBox();
            this.transportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.pathTableTableAdapter = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.PathTableTableAdapter();
            this.transportTableTableAdapter = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.TransportTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pathTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кол-во пассажиров в день";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер маршрута";
            // 
            // txtNumPas
            // 
            this.txtNumPas.Location = new System.Drawing.Point(260, 137);
            this.txtNumPas.Name = "txtNumPas";
            this.txtNumPas.Size = new System.Drawing.Size(294, 22);
            this.txtNumPas.TabIndex = 6;
            // 
            // txtNumRoute
            // 
            this.txtNumRoute.Location = new System.Drawing.Point(260, 109);
            this.txtNumRoute.Name = "txtNumRoute";
            this.txtNumRoute.Size = new System.Drawing.Size(294, 22);
            this.txtNumRoute.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(176, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Добавление маршрута";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Кол-во машин на маршруте";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Кол-во остановок на пути";
            // 
            // txtNumCars
            // 
            this.txtNumCars.Location = new System.Drawing.Point(260, 193);
            this.txtNumCars.Name = "txtNumCars";
            this.txtNumCars.Size = new System.Drawing.Size(294, 22);
            this.txtNumCars.TabIndex = 13;
            // 
            // txtNumStops
            // 
            this.txtNumStops.Location = new System.Drawing.Point(260, 165);
            this.txtNumStops.Name = "txtNumStops";
            this.txtNumStops.Size = new System.Drawing.Size(294, 22);
            this.txtNumStops.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Вид странспорта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Путь";
            // 
            // cmbPath
            // 
            this.cmbPath.DataSource = this.pathTableBindingSource;
            this.cmbPath.DisplayMember = "IdPath";
            this.cmbPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPath.FormattingEnabled = true;
            this.cmbPath.Location = new System.Drawing.Point(260, 221);
            this.cmbPath.Name = "cmbPath";
            this.cmbPath.Size = new System.Drawing.Size(294, 24);
            this.cmbPath.TabIndex = 20;
            this.cmbPath.ValueMember = "IdPath";
            // 
            // pathTableBindingSource
            // 
            this.pathTableBindingSource.DataMember = "PathTable";
            this.pathTableBindingSource.DataSource = this.dB_UrbanTransportDataSet;
            // 
            // dB_UrbanTransportDataSet
            // 
            this.dB_UrbanTransportDataSet.DataSetName = "DB_UrbanTransportDataSet";
            this.dB_UrbanTransportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKindTrans
            // 
            this.cmbKindTrans.DataSource = this.transportTableBindingSource;
            this.cmbKindTrans.DisplayMember = "IdKindTrans";
            this.cmbKindTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKindTrans.FormattingEnabled = true;
            this.cmbKindTrans.Location = new System.Drawing.Point(260, 249);
            this.cmbKindTrans.Name = "cmbKindTrans";
            this.cmbKindTrans.Size = new System.Drawing.Size(294, 24);
            this.cmbKindTrans.TabIndex = 21;
            this.cmbKindTrans.ValueMember = "IdKindTrans";
            // 
            // transportTableBindingSource
            // 
            this.transportTableBindingSource.DataMember = "TransportTable";
            this.transportTableBindingSource.DataSource = this.dB_UrbanTransportDataSet;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveClick);
            // 
            // pathTableTableAdapter
            // 
            this.pathTableTableAdapter.ClearBeforeFill = true;
            // 
            // transportTableTableAdapter
            // 
            this.transportTableTableAdapter.ClearBeforeFill = true;
            // 
            // AddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 353);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbKindTrans);
            this.Controls.Add(this.cmbPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumCars);
            this.Controls.Add(this.txtNumStops);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumPas);
            this.Controls.Add(this.txtNumRoute);
            this.Name = "AddRoute";
            this.Text = "Добавление маршрута";
            this.Load += new System.EventHandler(this.AddRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pathTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumPas;
        private System.Windows.Forms.TextBox txtNumRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCars;
        private System.Windows.Forms.TextBox txtNumStops;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPath;
        private System.Windows.Forms.ComboBox cmbKindTrans;
        private System.Windows.Forms.Button btnSave;
        private DB_UrbanTransportDataSet dB_UrbanTransportDataSet;
        private System.Windows.Forms.BindingSource pathTableBindingSource;
        private DB_UrbanTransportDataSetTableAdapters.PathTableTableAdapter pathTableTableAdapter;
        private System.Windows.Forms.BindingSource transportTableBindingSource;
        private DB_UrbanTransportDataSetTableAdapters.TransportTableTableAdapter transportTableTableAdapter;
    }
}