namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMainCourse = new System.Windows.Forms.GroupBox();
            radio495 = new System.Windows.Forms.RadioButton();
            radio595 = new System.Windows.Forms.RadioButton();
            radio695 = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtSalesTax = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnPlaceOrder = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            addon3 = new System.Windows.Forms.CheckBox();
            addon2 = new System.Windows.Forms.CheckBox();
            addon1 = new System.Windows.Forms.CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(radio495);
            gbxMainCourse.Controls.Add(radio595);
            gbxMainCourse.Controls.Add(radio695);
            gbxMainCourse.Location = new System.Drawing.Point(49, 28);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Size = new System.Drawing.Size(227, 163);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // radio495
            // 
            radio495.AutoSize = true;
            radio495.Location = new System.Drawing.Point(21, 128);
            radio495.Name = "radio495";
            radio495.Size = new System.Drawing.Size(141, 29);
            radio495.TabIndex = 2;
            radio495.Text = "Salad - $4.95";
            radio495.UseVisualStyleBackColor = true;
            radio495.CheckedChanged += radio495_CheckedChanged;
            // 
            // radio595
            // 
            radio595.AutoSize = true;
            radio595.Location = new System.Drawing.Point(21, 83);
            radio595.Name = "radio595";
            radio595.Size = new System.Drawing.Size(137, 29);
            radio595.TabIndex = 1;
            radio595.Text = "Pizza - $5.95";
            radio595.UseVisualStyleBackColor = true;
            radio595.CheckedChanged += radio595_CheckedChanged;
            // 
            // radio695
            // 
            radio695.AutoSize = true;
            radio695.Checked = true;
            radio695.Location = new System.Drawing.Point(21, 40);
            radio695.Name = "radio695";
            radio695.Size = new System.Drawing.Size(189, 29);
            radio695.TabIndex = 0;
            radio695.TabStop = true;
            radio695.Text = "Hamburger - $6.95";
            radio695.UseVisualStyleBackColor = true;
            radio695.CheckedChanged += radio695_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(49, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(371, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new System.Drawing.Point(160, 127);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(150, 31);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 25);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Enabled = false;
            txtSalesTax.Location = new System.Drawing.Point(160, 83);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new System.Drawing.Size(150, 31);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new System.Drawing.Point(160, 38);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(150, 31);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new System.Drawing.Point(456, 234);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(111, 42);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(457, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(111, 42);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addon3);
            groupBox1.Controls.Add(addon2);
            groupBox1.Controls.Add(addon1);
            groupBox1.Location = new System.Drawing.Point(307, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(300, 150);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add-on items ($0.75/each)";
            // 
            // addon3
            // 
            addon3.AutoSize = true;
            addon3.Location = new System.Drawing.Point(29, 101);
            addon3.Name = "addon3";
            addon3.Size = new System.Drawing.Size(131, 29);
            addon3.TabIndex = 2;
            addon3.Text = "French Fries";
            addon3.UseVisualStyleBackColor = true;
            addon3.CheckedChanged += addon3_CheckedChanged;
            // 
            // addon2
            // 
            addon2.AutoSize = true;
            addon2.Location = new System.Drawing.Point(29, 66);
            addon2.Name = "addon2";
            addon2.Size = new System.Drawing.Size(231, 29);
            addon2.TabIndex = 1;
            addon2.Text = "Ketchup, Mustard, Mayo";
            addon2.UseVisualStyleBackColor = true;
            addon2.CheckedChanged += addon2_CheckedChanged;
            // 
            // addon1
            // 
            addon1.AutoSize = true;
            addon1.Location = new System.Drawing.Point(29, 31);
            addon1.Name = "addon1";
            addon1.Size = new System.Drawing.Size(246, 29);
            addon1.TabIndex = 0;
            addon1.Text = "Lettuce, Tomatoes, Onions";
            addon1.UseVisualStyleBackColor = true;
            addon1.CheckedChanged += addon1_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(619, 457);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kyleigh's Lunch Order";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radio495;
        private System.Windows.Forms.RadioButton radio595;
        private System.Windows.Forms.RadioButton radio695;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox addon3;
        private System.Windows.Forms.CheckBox addon2;
        private System.Windows.Forms.CheckBox addon1;
    }
}

