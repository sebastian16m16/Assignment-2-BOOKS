namespace Assignment2.View
{
    partial class UserGUI
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
            this.bookshelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDataSet = new Assignment2.BookDataSet();
            this.bookshelfTableAdapter = new Assignment2.BookDataSetTableAdapters.BookshelfTableAdapter();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.titleCheckBox = new System.Windows.Forms.CheckBox();
            this.genreCheckBox = new System.Windows.Forms.CheckBox();
            this.authorCheckBox = new System.Windows.Forms.CheckBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.bookshelfBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookshelfBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Assignment2.DataBase.Database1DataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Assignment2.DataBase.Database1DataSetTableAdapters.BookTableAdapter();
            this.bookshelfBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Assignment2.BookDataSetTableAdapters.TableAdapterManager();
            this.bookDataSet1 = new Assignment2.BookDataSet1();
            this.bookShelfBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bookShelfTableAdapter1 = new Assignment2.BookDataSet1TableAdapters.BookShelfTableAdapter();
            this.tableAdapterManager1 = new Assignment2.BookDataSet1TableAdapters.TableAdapterManager();
            this.resultsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bookshelfBindingSource
            // 
            this.bookshelfBindingSource.DataMember = "Bookshelf";
            this.bookshelfBindingSource.DataSource = this.bookDataSetBindingSource;
            // 
            // bookDataSetBindingSource
            // 
            this.bookDataSetBindingSource.DataSource = this.bookDataSet;
            this.bookDataSetBindingSource.Position = 0;
            // 
            // bookDataSet
            // 
            this.bookDataSet.DataSetName = "BookDataSet";
            this.bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookshelfTableAdapter
            // 
            this.bookshelfTableAdapter.ClearBeforeFill = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(272, 444);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(183, 26);
            this.searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(511, 437);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 40);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // titleCheckBox
            // 
            this.titleCheckBox.AutoSize = true;
            this.titleCheckBox.Location = new System.Drawing.Point(703, 424);
            this.titleCheckBox.Name = "titleCheckBox";
            this.titleCheckBox.Size = new System.Drawing.Size(64, 24);
            this.titleCheckBox.TabIndex = 3;
            this.titleCheckBox.Text = "Title";
            this.titleCheckBox.UseVisualStyleBackColor = true;
            this.titleCheckBox.CheckedChanged += new System.EventHandler(this.TitleCheckBox_CheckedChanged);
            // 
            // genreCheckBox
            // 
            this.genreCheckBox.AutoSize = true;
            this.genreCheckBox.Location = new System.Drawing.Point(703, 506);
            this.genreCheckBox.Name = "genreCheckBox";
            this.genreCheckBox.Size = new System.Drawing.Size(80, 24);
            this.genreCheckBox.TabIndex = 4;
            this.genreCheckBox.Text = "Genre";
            this.genreCheckBox.UseVisualStyleBackColor = true;
            this.genreCheckBox.CheckedChanged += new System.EventHandler(this.GenreCheckBox_CheckedChanged);
            // 
            // authorCheckBox
            // 
            this.authorCheckBox.AutoSize = true;
            this.authorCheckBox.Location = new System.Drawing.Point(703, 465);
            this.authorCheckBox.Name = "authorCheckBox";
            this.authorCheckBox.Size = new System.Drawing.Size(83, 24);
            this.authorCheckBox.TabIndex = 5;
            this.authorCheckBox.Text = "Author";
            this.authorCheckBox.UseVisualStyleBackColor = true;
            this.authorCheckBox.CheckedChanged += new System.EventHandler(this.AuthorCheckBox_CheckedChanged);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.SystemColors.Info;
            this.sellButton.Location = new System.Drawing.Point(511, 497);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(123, 33);
            this.sellButton.TabIndex = 6;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(24, 39);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(71, 37);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bookshelfBindingSource1
            // 
            this.bookshelfBindingSource1.DataMember = "Bookshelf";
            this.bookshelfBindingSource1.DataSource = this.bookDataSet;
            // 
            // bookshelfBindingSource2
            // 
            this.bookshelfBindingSource2.DataMember = "Bookshelf";
            this.bookshelfBindingSource2.DataSource = this.bookDataSetBindingSource;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.database1DataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookshelfBindingSource3
            // 
            this.bookshelfBindingSource3.DataMember = "Bookshelf";
            this.bookshelfBindingSource3.DataSource = this.bookDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookshelfTableAdapter = this.bookshelfTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Assignment2.BookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookDataSet1
            // 
            this.bookDataSet1.DataSetName = "BookDataSet1";
            this.bookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookShelfBindingSource4
            // 
            this.bookShelfBindingSource4.DataMember = "BookShelf";
            this.bookShelfBindingSource4.DataSource = this.bookDataSet1;
            // 
            // bookShelfTableAdapter1
            // 
            this.bookShelfTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BookShelfTableAdapter = this.bookShelfTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Assignment2.BookDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // resultsTable
            // 
            this.resultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsTable.Location = new System.Drawing.Point(127, 75);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowTemplate.Height = 28;
            this.resultsTable.Size = new System.Drawing.Size(955, 244);
            this.resultsTable.TabIndex = 7;
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 620);
            this.Controls.Add(this.resultsTable);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.authorCheckBox);
            this.Controls.Add(this.genreCheckBox);
            this.Controls.Add(this.titleCheckBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Name = "UserGUI";
            this.Text = "UserGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserGUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookshelfBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookShelfBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bookDataSetBindingSource;
        private BookDataSet bookDataSet;
        private System.Windows.Forms.BindingSource bookshelfBindingSource;
        private BookDataSetTableAdapters.BookshelfTableAdapter bookshelfTableAdapter;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox titleCheckBox;
        private System.Windows.Forms.CheckBox genreCheckBox;
        private System.Windows.Forms.CheckBox authorCheckBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource bookshelfBindingSource1;
        private System.Windows.Forms.BindingSource bookshelfBindingSource2;
        private DataBase.Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DataBase.Database1DataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookshelfBindingSource3;
        private BookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BookDataSet1 bookDataSet1;
        private System.Windows.Forms.BindingSource bookShelfBindingSource4;
        private BookDataSet1TableAdapters.BookShelfTableAdapter bookShelfTableAdapter1;
        private BookDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView resultsTable;
    }
}