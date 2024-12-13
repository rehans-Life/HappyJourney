﻿namespace HappyJourney
{
    partial class Payment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumer = new System.Windows.Forms.TextBox();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.lblCvv = new System.Windows.Forms.Label();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.lblBaseFares = new System.Windows.Forms.Label();
            this.lblAdditionalServices = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblGrandTotalPrice = new System.Windows.Forms.Label();
            this.lblVatPrice = new System.Windows.Forms.Label();
            this.lblAdditionalServicesPrice = new System.Windows.Forms.Label();
            this.lblBaseFaresPrice = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.inboxToolStripMenuItem,
            this.composeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1472, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.inboxToolStripMenuItem.Text = "Inbox";
            // 
            // composeToolStripMenuItem
            // 
            this.composeToolStripMenuItem.Name = "composeToolStripMenuItem";
            this.composeToolStripMenuItem.Size = new System.Drawing.Size(135, 36);
            this.composeToolStripMenuItem.Text = "Compose";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(682, 76);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(149, 37);
            this.lblPayment.TabIndex = 1;
            this.lblPayment.Text = "Payment";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPaymentMethod.Location = new System.Drawing.Point(520, 158);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(187, 25);
            this.lblPaymentMethod.TabIndex = 2;
            this.lblPaymentMethod.Text = "Payment method";
            this.lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(525, 192);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(470, 33);
            this.cmbPaymentMethod.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCardNumber.Location = new System.Drawing.Point(520, 267);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(150, 25);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "Card Number";
            this.lblCardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCardNumer
            // 
            this.txtCardNumer.Location = new System.Drawing.Point(525, 299);
            this.txtCardNumer.Name = "txtCardNumer";
            this.txtCardNumer.Size = new System.Drawing.Size(470, 31);
            this.txtCardNumer.TabIndex = 5;
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiration.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblExpiration.Location = new System.Drawing.Point(520, 379);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(118, 25);
            this.lblExpiration.TabIndex = 6;
            this.lblExpiration.Text = "Expiration";
            this.lblExpiration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(777, 411);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(218, 31);
            this.txtCvv.TabIndex = 9;
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCvv.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCvv.Location = new System.Drawing.Point(772, 379);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(58, 25);
            this.lblCvv.TabIndex = 8;
            this.lblCvv.Text = "CVV";
            this.lblCvv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExpiration
            // 
            this.txtExpiration.Location = new System.Drawing.Point(525, 411);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(218, 31);
            this.txtExpiration.TabIndex = 10;
            // 
            // lblBaseFares
            // 
            this.lblBaseFares.AutoSize = true;
            this.lblBaseFares.Location = new System.Drawing.Point(495, 475);
            this.lblBaseFares.Name = "lblBaseFares";
            this.lblBaseFares.Size = new System.Drawing.Size(115, 25);
            this.lblBaseFares.TabIndex = 11;
            this.lblBaseFares.Text = "Base fares";
            // 
            // lblAdditionalServices
            // 
            this.lblAdditionalServices.AutoSize = true;
            this.lblAdditionalServices.Location = new System.Drawing.Point(495, 520);
            this.lblAdditionalServices.Name = "lblAdditionalServices";
            this.lblAdditionalServices.Size = new System.Drawing.Size(196, 25);
            this.lblAdditionalServices.TabIndex = 12;
            this.lblAdditionalServices.Text = "Additional Services";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(495, 568);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(102, 25);
            this.lblVat.TabIndex = 13;
            this.lblVat.Text = "VAT 10%";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(495, 614);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(136, 25);
            this.lblGrandTotal.TabIndex = 14;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblGrandTotalPrice
            // 
            this.lblGrandTotalPrice.AutoSize = true;
            this.lblGrandTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalPrice.Location = new System.Drawing.Point(930, 614);
            this.lblGrandTotalPrice.Name = "lblGrandTotalPrice";
            this.lblGrandTotalPrice.Size = new System.Drawing.Size(66, 25);
            this.lblGrandTotalPrice.TabIndex = 18;
            this.lblGrandTotalPrice.Text = "Price";
            // 
            // lblVatPrice
            // 
            this.lblVatPrice.AutoSize = true;
            this.lblVatPrice.Location = new System.Drawing.Point(930, 568);
            this.lblVatPrice.Name = "lblVatPrice";
            this.lblVatPrice.Size = new System.Drawing.Size(61, 25);
            this.lblVatPrice.TabIndex = 17;
            this.lblVatPrice.Text = "Price";
            // 
            // lblAdditionalServicesPrice
            // 
            this.lblAdditionalServicesPrice.AutoSize = true;
            this.lblAdditionalServicesPrice.Location = new System.Drawing.Point(930, 520);
            this.lblAdditionalServicesPrice.Name = "lblAdditionalServicesPrice";
            this.lblAdditionalServicesPrice.Size = new System.Drawing.Size(61, 25);
            this.lblAdditionalServicesPrice.TabIndex = 16;
            this.lblAdditionalServicesPrice.Text = "Price";
            // 
            // lblBaseFaresPrice
            // 
            this.lblBaseFaresPrice.AutoSize = true;
            this.lblBaseFaresPrice.Location = new System.Drawing.Point(930, 475);
            this.lblBaseFaresPrice.Name = "lblBaseFaresPrice";
            this.lblBaseFaresPrice.Size = new System.Drawing.Size(61, 25);
            this.lblBaseFaresPrice.TabIndex = 15;
            this.lblBaseFaresPrice.Text = "Price";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Black;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(695, 646);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(136, 46);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1472, 719);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblGrandTotalPrice);
            this.Controls.Add(this.lblVatPrice);
            this.Controls.Add(this.lblAdditionalServicesPrice);
            this.Controls.Add(this.lblBaseFaresPrice);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblAdditionalServices);
            this.Controls.Add(this.lblBaseFares);
            this.Controls.Add(this.txtExpiration);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.txtCardNumer);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composeToolStripMenuItem;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumer;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.Label lblBaseFares;
        private System.Windows.Forms.Label lblAdditionalServices;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblGrandTotalPrice;
        private System.Windows.Forms.Label lblVatPrice;
        private System.Windows.Forms.Label lblAdditionalServicesPrice;
        private System.Windows.Forms.Label lblBaseFaresPrice;
        private System.Windows.Forms.Button btnPay;
    }
}