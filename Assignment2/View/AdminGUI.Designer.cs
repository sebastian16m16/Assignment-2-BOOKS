namespace Assignment2.View
{
    partial class AdminGUI
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
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Assignment2.DataBase.Database1DataSet();
            this.bookTableAdapter = new Assignment2.DataBase.Database1DataSetTableAdapters.BookTableAdapter();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Assignment2.DataBase.Database1DataSetTableAdapters.TableAdapterManager();
            this.bookDataSet = new Assignment2.BookDataSet();
            this.bookshelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookshelfTableAdapter = new Assignment2.BookDataSetTableAdapters.BookshelfTableAdapter();
            this.tableAdapterManager1 = new Assignment2.BookDataSetTableAdapters.TableAdapterManager();
            this.bookshelfBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookshelfBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSet1 = new Assignment2.BookDataSet1();
            this.bookShelfBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bookShelfTableAdapter1 = new Assignment2.BookDataSet1TableAdapters.BookShelfTableAdapter();
            this.tableAdapterManager2 = new Assignment2.BookDataSet1TableAdapters.TableAdapterManager();
            this.resultsTable = new System.Windows.Forms.DataGridView();
            this.bookShelfBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(253, 302);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(110, 40);
            this.viewAllButton.TabIndex = 1;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(420, 302);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(120, 40);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(593, 302);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(115, 40);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(760, 302);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 40);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 29);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.UpdateOrder = Assignment2.DataBase.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookshelfBindingSource
            // 
            this.bookshelfBindingSource.DataMember = "Bookshelf";
            this.bookshelfBindingSource.DataSource = this.bookDataSet;
            // 
            // bookshelfTableAdapter
            // 
            this.bookshelfTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BookshelfTableAdapter = this.bookshelfTableAdapter;
            this.tableAdapterManager1.LoginTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Assignment2.BookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookshelfBindingSource1
            // 
            this.bookshelfBindingSource1.DataMember = "Bookshelf";
            this.bookshelfBindingSource1.DataSource = this.bookDataSet;
            // 
            // bookshelfBindingSource2
            // 
            this.bookshelfBindingSource2.DataMember = "Bookshelf";
            this.bookshelfBindingSource2.DataSource = this.bookDataSet;
            // 
            // bookDataSet1
            // 
            this.bookDataSet1.DataSetName = "BookDataSet1";
            this.bookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookShelfBindingSource3
            // 
            this.bookShelfBindingSource3.DataMember = "BookShelf";
            this.bookShelfBindingSource3.DataSource = this.bookDataSet1;
            // 
            // bookShelfTableAdapter1
            // 
            this.bookShelfTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.BookShelfTableAdapter = this.bookShelfTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = Assignment2.BookDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // resultsTable
            // 
            this.resultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsTable.Location = new System.Drawing.Point(120, 58);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowTemplate.Height = 28;
            this.resultsTable.Size = new System.Drawing.Size(1005, 220);
            this.resultsTable.TabIndex = 5;
            // 
            // bookShelfBindingSource4
            // 
            this.bookShelfBindingSource4.DataMember = "BookShelf";
            this.bookShelfBindingSource4.DataSource = this.bookDataSet1;
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 450);
            this.Controls.Add(this.resultsTable);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.viewAllButton);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminGUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataBase.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DataBase.Database1DataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private DataBase.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BookDataSet bookDataSet;
        private System.Windows.Forms.BindingSource bookshelfBindingSource;
        private BookDataSetTableAdapters.BookshelfTableAdapter bookshelfTableAdapter;
        private BookDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bookshelfBindingSource1;
        private System.Windows.Forms.BindingSource bookshelfBindingSource2;
        private BookDataSet1 bookDataSet1;
        private System.Windows.Forms.BindingSource bookShelfBindingSource3;
        private BookDataSet1TableAdapters.BookShelfTableAdapter bookShelfTableAdapter1;
        private BookDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView resultsTable;
        private System.Windows.Forms.BindingSource bookShelfBindingSource4;
    }
}