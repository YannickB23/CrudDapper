
namespace CrudDapper
{
    partial class frmBooksApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.grvBooks = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblId1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 153);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(30, 214);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(82, 29);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(30, 332);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 29);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(30, 277);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 29);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(217, 153);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(300, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(217, 339);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(217, 277);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(300, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(217, 214);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(300, 22);
            this.txtAuthor.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(262, 382);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(196, 34);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert New Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(262, 422);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(262, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAppTitle.Location = new System.Drawing.Point(17, 24);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(442, 38);
            this.lblAppTitle.TabIndex = 11;
            this.lblAppTitle.Text = "CRUD Form for the book app";
            // 
            // grvBooks
            // 
            this.grvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBooks.Location = new System.Drawing.Point(547, 37);
            this.grvBooks.Name = "grvBooks";
            this.grvBooks.RowHeadersWidth = 51;
            this.grvBooks.RowTemplate.Height = 24;
            this.grvBooks.Size = new System.Drawing.Size(834, 324);
            this.grvBooks.TabIndex = 12;
            this.grvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvBooks_CellDoubleClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(211, 98);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 32);
            this.lblId.TabIndex = 13;
            // 
            // lblId1
            // 
            this.lblId1.AutoSize = true;
            this.lblId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId1.Location = new System.Drawing.Point(30, 101);
            this.lblId1.Name = "lblId1";
            this.lblId1.Size = new System.Drawing.Size(33, 29);
            this.lblId1.TabIndex = 14;
            this.lblId1.Text = "Id";
            // 
            // frmBooksApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 441);
            this.Controls.Add(this.lblId1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grvBooks);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmBooksApp";
            this.Text = "BooksApp";
            this.Load += new System.EventHandler(this.frmBooksApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.DataGridView grvBooks;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblId1;
    }
}

