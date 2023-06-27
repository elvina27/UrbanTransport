namespace UrbanTransport
{
    partial class AddPath
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dB_UrbanTransportDataSet1 = new UrbanTransport.DB_UrbanTransportDataSet();
            this.transportTableTableAdapter1 = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.TransportTableTableAdapter();
            this.pathTableTableAdapter1 = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.PathTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(188, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Добавление пути";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(205, 270);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Добавить";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.saveClick);
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDistance.Location = new System.Drawing.Point(229, 196);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(278, 28);
            this.txtDistance.TabIndex = 18;
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtEndPoint.Location = new System.Drawing.Point(229, 145);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(278, 28);
            this.txtEndPoint.TabIndex = 17;
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtStartPoint.Location = new System.Drawing.Point(229, 92);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.Size = new System.Drawing.Size(278, 28);
            this.txtStartPoint.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Расстояние";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Конечный пункт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Начальный пункт";
            // 
            // dB_UrbanTransportDataSet1
            // 
            this.dB_UrbanTransportDataSet1.DataSetName = "DB_UrbanTransportDataSet";
            this.dB_UrbanTransportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportTableTableAdapter1
            // 
            this.transportTableTableAdapter1.ClearBeforeFill = true;
            // 
            // pathTableTableAdapter1
            // 
            this.pathTableTableAdapter1.ClearBeforeFill = true;
            // 
            // AddPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 318);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.txtStartPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddPath";
            this.Text = "Добавление пути";
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DB_UrbanTransportDataSet dB_UrbanTransportDataSet1;
        private DB_UrbanTransportDataSetTableAdapters.TransportTableTableAdapter transportTableTableAdapter1;
        private DB_UrbanTransportDataSetTableAdapters.PathTableTableAdapter pathTableTableAdapter1;
    }
}