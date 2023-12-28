namespace WindowsFormsApp1
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
            this.na = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showall = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // na
            // 
            this.na.AutoSize = true;
            this.na.Location = new System.Drawing.Point(1, 37);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(35, 13);
            this.na.TabIndex = 0;
            this.na.Text = "Name";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(1, 65);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 13);
            this.add.TabIndex = 1;
            this.add.Text = "Address";
            this.add.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(55, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(55, 64);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(186, 20);
            this.address.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 130);
            this.dataGridView1.TabIndex = 3;
            // 
            // showall
            // 
            this.showall.Location = new System.Drawing.Point(4, 90);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(75, 23);
            this.showall.TabIndex = 4;
            this.showall.Text = "showall";
            this.showall.UseVisualStyleBackColor = true;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(85, 90);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 4;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(166, 90);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(4, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(166, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(55, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(188, 20);
            this.id.TabIndex = 2;
            this.id.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.na);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label na;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
    }
}

