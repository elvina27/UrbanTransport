namespace UrbanTransport
{
    partial class Route
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
            this.dataGridViewRoute = new System.Windows.Forms.DataGridView();
            this.routeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_UrbanTransportDataSet = new UrbanTransport.DB_UrbanTransportDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSortV = new System.Windows.Forms.Button();
            this.btnSortU = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBoxRoute = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.routeTableTableAdapter = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.RouteTableTableAdapter();
            this.txtMain = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new UrbanTransport.DB_UrbanTransportDataSetTableAdapters.TableAdapterManager();
            this.idRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numRouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPassengersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numStopsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindTransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet)).BeginInit();
            this.groupBoxRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRoute
            // 
            this.dataGridViewRoute.AllowUserToAddRows = false;
            this.dataGridViewRoute.AllowUserToDeleteRows = false;
            this.dataGridViewRoute.AutoGenerateColumns = false;
            this.dataGridViewRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRouteDataGridViewTextBoxColumn,
            this.numRouteDataGridViewTextBoxColumn,
            this.numPassengersDataGridViewTextBoxColumn,
            this.numStopsDataGridViewTextBoxColumn,
            this.numCarsDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.kindTransDataGridViewTextBoxColumn});
            this.dataGridViewRoute.DataSource = this.routeTableBindingSource;
            this.dataGridViewRoute.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewRoute.Name = "dataGridViewRoute";
            this.dataGridViewRoute.ReadOnly = true;
            this.dataGridViewRoute.RowHeadersWidth = 51;
            this.dataGridViewRoute.RowTemplate.Height = 24;
            this.dataGridViewRoute.Size = new System.Drawing.Size(929, 269);
            this.dataGridViewRoute.TabIndex = 0;
            // 
            // routeTableBindingSource
            // 
            this.routeTableBindingSource.DataMember = "RouteTable";
            this.routeTableBindingSource.DataSource = this.dB_UrbanTransportDataSet;
            // 
            // dB_UrbanTransportDataSet
            // 
            this.dB_UrbanTransportDataSet.DataSetName = "DB_UrbanTransportDataSet";
            this.dB_UrbanTransportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(380, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Маршруты";
            // 
            // btnSortV
            // 
            this.btnSortV.Location = new System.Drawing.Point(28, 406);
            this.btnSortV.Name = "btnSortV";
            this.btnSortV.Size = new System.Drawing.Size(246, 53);
            this.btnSortV.TabIndex = 10;
            this.btnSortV.Text = "Сортировка номеров маршрута по возрастанию";
            this.btnSortV.UseVisualStyleBackColor = true;
            this.btnSortV.Click += new System.EventHandler(this.btnSortV_Click);
            // 
            // btnSortU
            // 
            this.btnSortU.Location = new System.Drawing.Point(28, 466);
            this.btnSortU.Name = "btnSortU";
            this.btnSortU.Size = new System.Drawing.Size(246, 53);
            this.btnSortU.TabIndex = 11;
            this.btnSortU.Text = "Сортировка номеров маршрута по убыванию";
            this.btnSortU.UseVisualStyleBackColor = true;
            this.btnSortU.Click += new System.EventHandler(this.btnSortU_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(414, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фильтр";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DataSource = this.routeTableBindingSource;
            this.cmbFilter.DisplayMember = "NumRoute";
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(320, 395);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(246, 24);
            this.cmbFilter.TabIndex = 13;
            this.cmbFilter.ValueMember = "NumRoute";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(320, 436);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(196, 23);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
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
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnDelete.Location = new System.Drawing.Point(18, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удаление";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(320, 503);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(196, 23);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBoxRoute
            // 
            this.groupBoxRoute.Controls.Add(this.btnAdd);
            this.groupBoxRoute.Controls.Add(this.btnChange);
            this.groupBoxRoute.Controls.Add(this.btnDelete);
            this.groupBoxRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxRoute.Location = new System.Drawing.Point(717, 384);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(224, 135);
            this.groupBoxRoute.TabIndex = 21;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "Для админа";
            this.groupBoxRoute.Visible = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(320, 465);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(196, 23);
            this.btnShowAll.TabIndex = 22;
            this.btnShowAll.Text = "Показать все";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // routeTableTableAdapter
            // 
            this.routeTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(12, 12);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(109, 23);
            this.txtMain.TabIndex = 23;
            this.txtMain.Text = "Главное меню";
            this.txtMain.UseVisualStyleBackColor = true;
            this.txtMain.Click += new System.EventHandler(this.txtMain_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PathTableTableAdapter = null;
            this.tableAdapterManager1.RouteTableTableAdapter = this.routeTableTableAdapter;
            this.tableAdapterManager1.TransportTableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = UrbanTransport.DB_UrbanTransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idRouteDataGridViewTextBoxColumn
            // 
            this.idRouteDataGridViewTextBoxColumn.DataPropertyName = "IdRoute";
            this.idRouteDataGridViewTextBoxColumn.HeaderText = "Код маршрута";
            this.idRouteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRouteDataGridViewTextBoxColumn.Name = "idRouteDataGridViewTextBoxColumn";
            this.idRouteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRouteDataGridViewTextBoxColumn.Visible = false;
            this.idRouteDataGridViewTextBoxColumn.Width = 125;
            // 
            // numRouteDataGridViewTextBoxColumn
            // 
            this.numRouteDataGridViewTextBoxColumn.DataPropertyName = "NumRoute";
            this.numRouteDataGridViewTextBoxColumn.HeaderText = "Номер маршрута";
            this.numRouteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numRouteDataGridViewTextBoxColumn.Name = "numRouteDataGridViewTextBoxColumn";
            this.numRouteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numRouteDataGridViewTextBoxColumn.Width = 125;
            // 
            // numPassengersDataGridViewTextBoxColumn
            // 
            this.numPassengersDataGridViewTextBoxColumn.DataPropertyName = "NumPassengers";
            this.numPassengersDataGridViewTextBoxColumn.HeaderText = "Кол-во пассажиров в день";
            this.numPassengersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numPassengersDataGridViewTextBoxColumn.Name = "numPassengersDataGridViewTextBoxColumn";
            this.numPassengersDataGridViewTextBoxColumn.ReadOnly = true;
            this.numPassengersDataGridViewTextBoxColumn.Width = 125;
            // 
            // numStopsDataGridViewTextBoxColumn
            // 
            this.numStopsDataGridViewTextBoxColumn.DataPropertyName = "NumStops";
            this.numStopsDataGridViewTextBoxColumn.HeaderText = "Кол-во остановок в пути";
            this.numStopsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numStopsDataGridViewTextBoxColumn.Name = "numStopsDataGridViewTextBoxColumn";
            this.numStopsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numStopsDataGridViewTextBoxColumn.Width = 125;
            // 
            // numCarsDataGridViewTextBoxColumn
            // 
            this.numCarsDataGridViewTextBoxColumn.DataPropertyName = "NumCars";
            this.numCarsDataGridViewTextBoxColumn.HeaderText = "Кол-во машин на маршруте";
            this.numCarsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numCarsDataGridViewTextBoxColumn.Name = "numCarsDataGridViewTextBoxColumn";
            this.numCarsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numCarsDataGridViewTextBoxColumn.Width = 125;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Код пути";
            this.pathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Width = 125;
            // 
            // kindTransDataGridViewTextBoxColumn
            // 
            this.kindTransDataGridViewTextBoxColumn.DataPropertyName = "KindTrans";
            this.kindTransDataGridViewTextBoxColumn.HeaderText = "Код вида транспорта";
            this.kindTransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kindTransDataGridViewTextBoxColumn.Name = "kindTransDataGridViewTextBoxColumn";
            this.kindTransDataGridViewTextBoxColumn.ReadOnly = true;
            this.kindTransDataGridViewTextBoxColumn.Width = 125;
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 545);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSortU);
            this.Controls.Add(this.btnSortV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRoute);
            this.Name = "Route";
            this.Text = "Маршруты";
            this.Load += new System.EventHandler(this.Route_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_UrbanTransportDataSet)).EndInit();
            this.groupBoxRoute.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSortV;
        private System.Windows.Forms.Button btnSortU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnShowAll;
        private DB_UrbanTransportDataSet dB_UrbanTransportDataSet;
        private System.Windows.Forms.BindingSource routeTableBindingSource;
        private DB_UrbanTransportDataSetTableAdapters.RouteTableTableAdapter routeTableTableAdapter;
        private System.Windows.Forms.Button txtMain;
        public System.Windows.Forms.DataGridView dataGridViewRoute;
        public System.Windows.Forms.GroupBox groupBoxRoute;
        private DB_UrbanTransportDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPassengersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numStopsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCarsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindTransDataGridViewTextBoxColumn;
    }
}