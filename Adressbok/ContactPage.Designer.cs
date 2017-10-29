﻿namespace Adressbok
{
	partial class ContactPage
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.inputName = new System.Windows.Forms.TextBox();
			this.inputType = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.labelAddress = new System.Windows.Forms.Label();
			this.dataGridAddress = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAddress)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::Adressbok.Properties.Resources.pp;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Name";
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.Location = new System.Drawing.Point(325, 200);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "Save";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// inputName
			// 
			this.inputName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputName.Location = new System.Drawing.Point(3, 16);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(276, 20);
			this.inputName.TabIndex = 4;
			// 
			// inputType
			// 
			this.inputType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputType.FormattingEnabled = true;
			this.inputType.Location = new System.Drawing.Point(3, 55);
			this.inputType.Name = "inputType";
			this.inputType.Size = new System.Drawing.Size(276, 21);
			this.inputType.TabIndex = 5;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(190, 0);
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.inputType, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.inputName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.dataGridAddress, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelAddress, 0, 4);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 179);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Contact type";
			// 
			// labelAddress
			// 
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(3, 79);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(45, 13);
			this.labelAddress.TabIndex = 7;
			this.labelAddress.Text = "Address";
			// 
			// dataGridAddress
			// 
			this.dataGridAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridAddress.Location = new System.Drawing.Point(3, 102);
			this.dataGridAddress.Name = "dataGridAddress";
			this.dataGridAddress.Size = new System.Drawing.Size(276, 74);
			this.dataGridAddress.TabIndex = 6;
			// 
			// ContactPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 235);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.pictureBox1);
			this.MinimumSize = new System.Drawing.Size(337, 195);
			this.Name = "ContactPage";
			this.Text = "ContactPage";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridAddress)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.ComboBox inputType;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.DataGridView dataGridAddress;
	}
}