namespace Asignment6
{
    partial class FRMEmployees
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
            this.TBLData = new System.Windows.Forms.TableLayoutPanel();
            this.LBLID = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.LBLName = new System.Windows.Forms.Label();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.LBLPhone = new System.Windows.Forms.Label();
            this.TXTPhone = new System.Windows.Forms.TextBox();
            this.LBLAddress = new System.Windows.Forms.Label();
            this.TXTAddress = new System.Windows.Forms.TextBox();
            this.Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNClear = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNEdit = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNSho = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.BTNFind = new System.Windows.Forms.Button();
            this.TBLData.SuspendLayout();
            this.Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBLData
            // 
            this.TBLData.AutoSize = true;
            this.TBLData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TBLData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TBLData.ColumnCount = 4;
            this.TBLData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TBLData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TBLData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TBLData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TBLData.Controls.Add(this.LBLID, 1, 1);
            this.TBLData.Controls.Add(this.TXTID, 2, 1);
            this.TBLData.Controls.Add(this.LBLName, 1, 2);
            this.TBLData.Controls.Add(this.TXTName, 2, 2);
            this.TBLData.Controls.Add(this.LBLPhone, 1, 3);
            this.TBLData.Controls.Add(this.TXTPhone, 2, 3);
            this.TBLData.Controls.Add(this.LBLAddress, 1, 4);
            this.TBLData.Controls.Add(this.TXTAddress, 2, 4);
            this.TBLData.Controls.Add(this.Buttons, 1, 5);
            this.TBLData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBLData.Location = new System.Drawing.Point(0, 0);
            this.TBLData.Name = "TBLData";
            this.TBLData.RowCount = 7;
            this.TBLData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TBLData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TBLData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TBLData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TBLData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TBLData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TBLData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TBLData.Size = new System.Drawing.Size(800, 450);
            this.TBLData.TabIndex = 0;
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLID.Location = new System.Drawing.Point(203, 65);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(192, 63);
            this.LBLID.TabIndex = 0;
            this.LBLID.Text = "الم&عرف";
            this.LBLID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTID
            // 
            this.TXTID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTID.Location = new System.Drawing.Point(402, 68);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(192, 20);
            this.TXTID.TabIndex = 1;
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLName.Location = new System.Drawing.Point(203, 129);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(192, 63);
            this.LBLName.TabIndex = 2;
            this.LBLName.Text = "الا&سم";
            this.LBLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTName
            // 
            this.TXTName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTName.Location = new System.Drawing.Point(402, 132);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(192, 20);
            this.TXTName.TabIndex = 3;
            // 
            // LBLPhone
            // 
            this.LBLPhone.AutoSize = true;
            this.LBLPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLPhone.Location = new System.Drawing.Point(203, 193);
            this.LBLPhone.Name = "LBLPhone";
            this.LBLPhone.Size = new System.Drawing.Size(192, 63);
            this.LBLPhone.TabIndex = 4;
            this.LBLPhone.Text = "ال&هاتف";
            // 
            // TXTPhone
            // 
            this.TXTPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTPhone.Location = new System.Drawing.Point(402, 196);
            this.TXTPhone.Name = "TXTPhone";
            this.TXTPhone.Size = new System.Drawing.Size(192, 20);
            this.TXTPhone.TabIndex = 5;
            // 
            // LBLAddress
            // 
            this.LBLAddress.AutoSize = true;
            this.LBLAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLAddress.Location = new System.Drawing.Point(203, 257);
            this.LBLAddress.Name = "LBLAddress";
            this.LBLAddress.Size = new System.Drawing.Size(192, 63);
            this.LBLAddress.TabIndex = 6;
            this.LBLAddress.Text = "الع&نوان";
            this.LBLAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTAddress
            // 
            this.TXTAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTAddress.Location = new System.Drawing.Point(402, 260);
            this.TXTAddress.Name = "TXTAddress";
            this.TXTAddress.Size = new System.Drawing.Size(192, 20);
            this.TXTAddress.TabIndex = 7;
            // 
            // Buttons
            // 
            this.Buttons.AutoSize = true;
            this.Buttons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TBLData.SetColumnSpan(this.Buttons, 2);
            this.Buttons.Controls.Add(this.BTNClear);
            this.Buttons.Controls.Add(this.BTNAdd);
            this.Buttons.Controls.Add(this.BTNEdit);
            this.Buttons.Controls.Add(this.BTNDelete);
            this.Buttons.Controls.Add(this.BTNSho);
            this.Buttons.Controls.Add(this.BTNExit);
            this.Buttons.Controls.Add(this.BTNFind);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttons.Location = new System.Drawing.Point(203, 324);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(391, 57);
            this.Buttons.TabIndex = 8;
            // 
            // BTNClear
            // 
            this.BTNClear.AutoSize = true;
            this.BTNClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNClear.Location = new System.Drawing.Point(3, 3);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(74, 23);
            this.BTNClear.TabIndex = 0;
            this.BTNClear.Text = "تفريغ الح&قول";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.AutoSize = true;
            this.BTNAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNAdd.Location = new System.Drawing.Point(83, 3);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(43, 23);
            this.BTNAdd.TabIndex = 1;
            this.BTNAdd.Text = "إ&ضافة";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNEdit
            // 
            this.BTNEdit.AutoSize = true;
            this.BTNEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNEdit.Location = new System.Drawing.Point(132, 3);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.Size = new System.Drawing.Size(43, 23);
            this.BTNEdit.TabIndex = 2;
            this.BTNEdit.Text = "&تعديل";
            this.BTNEdit.UseVisualStyleBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.AutoSize = true;
            this.BTNDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNDelete.Location = new System.Drawing.Point(181, 3);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(40, 23);
            this.BTNDelete.TabIndex = 3;
            this.BTNDelete.Text = "&حذف";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNSho
            // 
            this.BTNSho.AutoSize = true;
            this.BTNSho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNSho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNSho.Location = new System.Drawing.Point(227, 3);
            this.BTNSho.Name = "BTNSho";
            this.BTNSho.Size = new System.Drawing.Size(40, 23);
            this.BTNSho.TabIndex = 4;
            this.BTNSho.Text = "إ&ظهار";
            this.BTNSho.UseVisualStyleBackColor = true;
            // 
            // BTNExit
            // 
            this.BTNExit.AutoSize = true;
            this.BTNExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNExit.Location = new System.Drawing.Point(273, 3);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(41, 23);
            this.BTNExit.TabIndex = 6;
            this.BTNExit.Text = "&خروج";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // BTNFind
            // 
            this.BTNFind.AutoSize = true;
            this.BTNFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNFind.Location = new System.Drawing.Point(320, 3);
            this.BTNFind.Name = "BTNFind";
            this.BTNFind.Size = new System.Drawing.Size(37, 23);
            this.BTNFind.TabIndex = 5;
            this.BTNFind.Text = "&بحث";
            this.BTNFind.UseVisualStyleBackColor = true;
            // 
            // FRMEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBLData);
            this.Name = "FRMEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الواجب السادس الموظفين";
            this.TBLData.ResumeLayout(false);
            this.TBLData.PerformLayout();
            this.Buttons.ResumeLayout(false);
            this.Buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TBLData;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.Label LBLPhone;
        private System.Windows.Forms.TextBox TXTPhone;
        private System.Windows.Forms.Label LBLAddress;
        private System.Windows.Forms.TextBox TXTAddress;
        private System.Windows.Forms.FlowLayoutPanel Buttons;
        private System.Windows.Forms.Button BTNClear;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNEdit;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNSho;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Button BTNFind;
    }
}

