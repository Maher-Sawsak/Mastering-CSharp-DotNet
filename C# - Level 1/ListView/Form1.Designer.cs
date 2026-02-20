namespace ListView
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFillRandomly = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbDeteail = new System.Windows.Forms.RadioButton();
            this.gbGander = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbView.SuspendLayout();
            this.gbGander.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Turquoise;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmName});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(8, 181);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 305);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 109;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 150;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "images (1)-Photoroom.png");
            this.imageList2.Images.SetKeyName(1, "images-Photoroom.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images (1)-Photoroom.png");
            this.imageList1.Images.SetKeyName(1, "images-Photoroom.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(356, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 47);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFillRandomly
            // 
            this.btnFillRandomly.Location = new System.Drawing.Point(487, 17);
            this.btnFillRandomly.Name = "btnFillRandomly";
            this.btnFillRandomly.Size = new System.Drawing.Size(125, 47);
            this.btnFillRandomly.TabIndex = 3;
            this.btnFillRandomly.Text = "Fill Random";
            this.btnFillRandomly.UseVisualStyleBackColor = true;
            this.btnFillRandomly.Click += new System.EventHandler(this.btnFillRandomly_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(63, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(130, 22);
            this.txtId.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 5;
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.rbSmall);
            this.gbView.Controls.Add(this.rbTile);
            this.gbView.Controls.Add(this.rbLarge);
            this.gbView.Controls.Add(this.rbList);
            this.gbView.Controls.Add(this.rbDeteail);
            this.gbView.Location = new System.Drawing.Point(677, 29);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(234, 168);
            this.gbView.TabIndex = 7;
            this.gbView.TabStop = false;
            this.gbView.Text = "View";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(5, 74);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(84, 20);
            this.rbSmall.TabIndex = 10;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small Icon";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(6, 100);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(46, 20);
            this.rbTile.TabIndex = 11;
            this.rbTile.TabStop = true;
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.rbTile_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(115, 47);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(85, 20);
            this.rbLarge.TabIndex = 12;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large Icon";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(115, 74);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(48, 20);
            this.rbList.TabIndex = 13;
            this.rbList.TabStop = true;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbDeteail
            // 
            this.rbDeteail.AutoSize = true;
            this.rbDeteail.Location = new System.Drawing.Point(6, 46);
            this.rbDeteail.Name = "rbDeteail";
            this.rbDeteail.Size = new System.Drawing.Size(58, 20);
            this.rbDeteail.TabIndex = 9;
            this.rbDeteail.TabStop = true;
            this.rbDeteail.Text = "Detail";
            this.rbDeteail.UseVisualStyleBackColor = true;
            this.rbDeteail.CheckedChanged += new System.EventHandler(this.rbDeteail_CheckedChanged);
            // 
            // gbGander
            // 
            this.gbGander.Controls.Add(this.rbFemale);
            this.gbGander.Controls.Add(this.rbMale);
            this.gbGander.Location = new System.Drawing.Point(39, 106);
            this.gbGander.Name = "gbGander";
            this.gbGander.Size = new System.Drawing.Size(175, 69);
            this.gbGander.TabIndex = 8;
            this.gbGander.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(77, 34);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(65, 20);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 34);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(52, 20);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(5, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name :";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(935, 547);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.gbGander);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnFillRandomly);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            this.gbGander.ResumeLayout(false);
            this.gbGander.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFillRandomly;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbDeteail;
        private System.Windows.Forms.GroupBox gbGander;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmName;
    }
}

