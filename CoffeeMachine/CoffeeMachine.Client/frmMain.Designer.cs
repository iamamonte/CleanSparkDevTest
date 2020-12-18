namespace CoffeeMachine.Client
{
	partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputSugarCount = new System.Windows.Forms.NumericUpDown();
            this.inputCreamerCount = new System.Windows.Forms.NumericUpDown();
            this.cmbSize = new System.Windows.Forms.ListBox();
            this.btnAddCoffee = new System.Windows.Forms.Button();
            this.txtSugar = new System.Windows.Forms.TextBox();
            this.txtCream = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtCurrentOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentPayment = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVend = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnGetChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSugarCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCreamerCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputSugarCount);
            this.groupBox1.Controls.Add(this.inputCreamerCount);
            this.groupBox1.Controls.Add(this.cmbSize);
            this.groupBox1.Controls.Add(this.btnAddCoffee);
            this.groupBox1.Controls.Add(this.txtSugar);
            this.groupBox1.Controls.Add(this.txtCream);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(218, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a coffee";
            // 
            // inputSugarCount
            // 
            this.inputSugarCount.Location = new System.Drawing.Point(96, 86);
            this.inputSugarCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.inputSugarCount.Name = "inputSugarCount";
            this.inputSugarCount.Size = new System.Drawing.Size(120, 22);
            this.inputSugarCount.TabIndex = 9;
            // 
            // inputCreamerCount
            // 
            this.inputCreamerCount.Location = new System.Drawing.Point(96, 57);
            this.inputCreamerCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.inputCreamerCount.Name = "inputCreamerCount";
            this.inputCreamerCount.Size = new System.Drawing.Size(120, 22);
            this.inputCreamerCount.TabIndex = 8;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.ItemHeight = 16;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbSize.Location = new System.Drawing.Point(96, 29);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(117, 20);
            this.cmbSize.TabIndex = 7;
            // 
            // btnAddCoffee
            // 
            this.btnAddCoffee.Location = new System.Drawing.Point(96, 129);
            this.btnAddCoffee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCoffee.Name = "btnAddCoffee";
            this.btnAddCoffee.Size = new System.Drawing.Size(102, 27);
            this.btnAddCoffee.TabIndex = 6;
            this.btnAddCoffee.Text = "Add to Order";
            this.btnAddCoffee.UseVisualStyleBackColor = true;
            this.btnAddCoffee.Click += new System.EventHandler(this.btnAddCoffee_Click);
            // 
            // txtSugar
            // 
            this.txtSugar.Location = new System.Drawing.Point(96, 87);
            this.txtSugar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSugar.Name = "txtSugar";
            this.txtSugar.Size = new System.Drawing.Size(104, 22);
            this.txtSugar.TabIndex = 5;
            this.txtSugar.Visible = false;
            // 
            // txtCream
            // 
            this.txtCream.Location = new System.Drawing.Point(96, 58);
            this.txtCream.Margin = new System.Windows.Forms.Padding(2);
            this.txtCream.Name = "txtCream";
            this.txtCream.Size = new System.Drawing.Size(104, 22);
            this.txtCream.TabIndex = 4;
            this.txtCream.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sugar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(96, 29);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(104, 22);
            this.txtSize.TabIndex = 0;
            this.txtSize.Visible = false;
            // 
            // txtCurrentOrder
            // 
            this.txtCurrentOrder.Location = new System.Drawing.Point(262, 42);
            this.txtCurrentOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentOrder.Multiline = true;
            this.txtCurrentOrder.Name = "txtCurrentOrder";
            this.txtCurrentOrder.Size = new System.Drawing.Size(368, 129);
            this.txtCurrentOrder.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current order:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddPayment);
            this.groupBox2.Controls.Add(this.txtPayment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(218, 102);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(96, 60);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(102, 27);
            this.btnAddPayment.TabIndex = 7;
            this.btnAddPayment.Text = "Add to Order";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(96, 29);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(104, 22);
            this.txtPayment.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current payment:";
            // 
            // lblCurrentPayment
            // 
            this.lblCurrentPayment.AutoSize = true;
            this.lblCurrentPayment.Location = new System.Drawing.Point(402, 229);
            this.lblCurrentPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPayment.Name = "lblCurrentPayment";
            this.lblCurrentPayment.Size = new System.Drawing.Size(18, 17);
            this.lblCurrentPayment.TabIndex = 10;
            this.lblCurrentPayment.Text = "--";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(402, 201);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(18, 17);
            this.lblOrderTotal.TabIndex = 12;
            this.lblOrderTotal.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Order total:";
            // 
            // btnVend
            // 
            this.btnVend.Location = new System.Drawing.Point(262, 279);
            this.btnVend.Margin = new System.Windows.Forms.Padding(2);
            this.btnVend.Name = "btnVend";
            this.btnVend.Size = new System.Drawing.Size(102, 27);
            this.btnVend.TabIndex = 9;
            this.btnVend.Text = "Vend!";
            this.btnVend.UseVisualStyleBackColor = true;
            this.btnVend.Click += new System.EventHandler(this.btnVend_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(266, 260);
            this.lblErrorMessage.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(119, 17);
            this.lblErrorMessage.TabIndex = 13;
            this.lblErrorMessage.Text = "errror message";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChange.Location = new System.Drawing.Point(562, 284);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(55, 17);
            this.lblChange.TabIndex = 14;
            this.lblChange.Text = "change";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnGetChange
            // 
            this.btnGetChange.Location = new System.Drawing.Point(455, 279);
            this.btnGetChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetChange.Name = "btnGetChange";
            this.btnGetChange.Size = new System.Drawing.Size(102, 27);
            this.btnGetChange.TabIndex = 15;
            this.btnGetChange.Text = "Get Change";
            this.btnGetChange.UseVisualStyleBackColor = true;
            this.btnGetChange.Click += new System.EventHandler(this.btnGetChange_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 333);
            this.Controls.Add(this.btnGetChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnVend);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCurrentPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurrentOrder);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Vending Machine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSugarCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCreamerCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAddCoffee;
		private System.Windows.Forms.TextBox txtSugar;
		private System.Windows.Forms.TextBox txtCream;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.TextBox txtCurrentOrder;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAddPayment;
		private System.Windows.Forms.TextBox txtPayment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblCurrentPayment;
		private System.Windows.Forms.Label lblOrderTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnVend;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox cmbSize;
        private System.Windows.Forms.NumericUpDown inputCreamerCount;
        private System.Windows.Forms.NumericUpDown inputSugarCount;
        private System.Windows.Forms.Button btnGetChange;
    }
}

