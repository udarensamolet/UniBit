namespace SDA_46231z_MyProject
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
			this.tbAutoparkSystem = new System.Windows.Forms.TabControl();
			this.tabAddVehicle = new System.Windows.Forms.TabPage();
			this.rtbAddVehicleInfo = new System.Windows.Forms.RichTextBox();
			this.btnAddVehicle = new System.Windows.Forms.Button();
			this.gbAddVehiclePPS = new System.Windows.Forms.GroupBox();
			this.lblAddVehicleInfo = new System.Windows.Forms.Label();
			this.tbAddVehiclePPSDKN = new System.Windows.Forms.TextBox();
			this.lblAddVehiclePPSType = new System.Windows.Forms.Label();
			this.lblAddVehiclePPSDKN = new System.Windows.Forms.Label();
			this.cbAddVehiclePPSType = new System.Windows.Forms.ComboBox();
			this.gbAddVehicleOwner = new System.Windows.Forms.GroupBox();
			this.tbAddVehicleOwnerNameLast = new System.Windows.Forms.TextBox();
			this.lblAddVehicleOwnerNameLast = new System.Windows.Forms.Label();
			this.tbAddVehicleOwnerNameFirst = new System.Windows.Forms.TextBox();
			this.lblAddVehicleOwnerNameFirst = new System.Windows.Forms.Label();
			this.tabFinance = new System.Windows.Forms.TabPage();
			this.lblFinanceMonth = new System.Windows.Forms.Label();
			this.cbFinanceMonth = new System.Windows.Forms.ComboBox();
			this.btnFinanceCalculateOwner = new System.Windows.Forms.Button();
			this.btnFinanceCalculateAll = new System.Windows.Forms.Button();
			this.rtbFinanceResult = new System.Windows.Forms.RichTextBox();
			this.lblFinance = new System.Windows.Forms.Label();
			this.tabPricelist = new System.Windows.Forms.TabPage();
			this.btnPricelistCheck = new System.Windows.Forms.Button();
			this.tbPricelistPrice = new System.Windows.Forms.TextBox();
			this.lblPricelistPrice = new System.Windows.Forms.Label();
			this.lbPricelistType = new System.Windows.Forms.ListBox();
			this.lblPricelistType = new System.Windows.Forms.Label();
			this.tbAutoparkSystem.SuspendLayout();
			this.tabAddVehicle.SuspendLayout();
			this.gbAddVehiclePPS.SuspendLayout();
			this.gbAddVehicleOwner.SuspendLayout();
			this.tabFinance.SuspendLayout();
			this.tabPricelist.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbAutoparkSystem
			// 
			this.tbAutoparkSystem.Controls.Add(this.tabAddVehicle);
			this.tbAutoparkSystem.Controls.Add(this.tabFinance);
			this.tbAutoparkSystem.Controls.Add(this.tabPricelist);
			this.tbAutoparkSystem.Location = new System.Drawing.Point(12, 12);
			this.tbAutoparkSystem.Name = "tbAutoparkSystem";
			this.tbAutoparkSystem.SelectedIndex = 0;
			this.tbAutoparkSystem.Size = new System.Drawing.Size(776, 500);
			this.tbAutoparkSystem.TabIndex = 0;
			// 
			// tabAddVehicle
			// 
			this.tabAddVehicle.BackColor = System.Drawing.Color.Transparent;
			this.tabAddVehicle.Controls.Add(this.rtbAddVehicleInfo);
			this.tabAddVehicle.Controls.Add(this.btnAddVehicle);
			this.tabAddVehicle.Controls.Add(this.gbAddVehiclePPS);
			this.tabAddVehicle.Controls.Add(this.gbAddVehicleOwner);
			this.tabAddVehicle.Location = new System.Drawing.Point(4, 25);
			this.tabAddVehicle.Name = "tabAddVehicle";
			this.tabAddVehicle.Padding = new System.Windows.Forms.Padding(3);
			this.tabAddVehicle.Size = new System.Drawing.Size(768, 471);
			this.tabAddVehicle.TabIndex = 0;
			this.tabAddVehicle.Text = "Въвеждане на ППС";
			// 
			// rtbAddVehicleInfo
			// 
			this.rtbAddVehicleInfo.Location = new System.Drawing.Point(18, 264);
			this.rtbAddVehicleInfo.Name = "rtbAddVehicleInfo";
			this.rtbAddVehicleInfo.Size = new System.Drawing.Size(733, 179);
			this.rtbAddVehicleInfo.TabIndex = 3;
			this.rtbAddVehicleInfo.Text = "";
			// 
			// btnAddVehicle
			// 
			this.btnAddVehicle.Location = new System.Drawing.Point(350, 197);
			this.btnAddVehicle.Name = "btnAddVehicle";
			this.btnAddVehicle.Size = new System.Drawing.Size(75, 23);
			this.btnAddVehicle.TabIndex = 2;
			this.btnAddVehicle.Text = "Запиши";
			this.btnAddVehicle.UseVisualStyleBackColor = true;
			this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
			// 
			// gbAddVehiclePPS
			// 
			this.gbAddVehiclePPS.Controls.Add(this.lblAddVehicleInfo);
			this.gbAddVehiclePPS.Controls.Add(this.tbAddVehiclePPSDKN);
			this.gbAddVehiclePPS.Controls.Add(this.lblAddVehiclePPSType);
			this.gbAddVehiclePPS.Controls.Add(this.lblAddVehiclePPSDKN);
			this.gbAddVehiclePPS.Controls.Add(this.cbAddVehiclePPSType);
			this.gbAddVehiclePPS.Location = new System.Drawing.Point(411, 22);
			this.gbAddVehiclePPS.Name = "gbAddVehiclePPS";
			this.gbAddVehiclePPS.Size = new System.Drawing.Size(340, 139);
			this.gbAddVehiclePPS.TabIndex = 1;
			this.gbAddVehiclePPS.TabStop = false;
			this.gbAddVehiclePPS.Text = "ППС";
			// 
			// lblAddVehicleInfo
			// 
			this.lblAddVehicleInfo.AutoSize = true;
			this.lblAddVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAddVehicleInfo.Location = new System.Drawing.Point(16, 108);
			this.lblAddVehicleInfo.Name = "lblAddVehicleInfo";
			this.lblAddVehicleInfo.Size = new System.Drawing.Size(240, 15);
			this.lblAddVehicleInfo.TabIndex = 8;
			this.lblAddVehicleInfo.Text = "* Въведете на латиница без интервали!";
			// 
			// tbAddVehiclePPSDKN
			// 
			this.tbAddVehiclePPSDKN.Location = new System.Drawing.Point(106, 83);
			this.tbAddVehiclePPSDKN.Name = "tbAddVehiclePPSDKN";
			this.tbAddVehiclePPSDKN.Size = new System.Drawing.Size(228, 22);
			this.tbAddVehiclePPSDKN.TabIndex = 7;
			// 
			// lblAddVehiclePPSType
			// 
			this.lblAddVehiclePPSType.AutoSize = true;
			this.lblAddVehiclePPSType.Location = new System.Drawing.Point(16, 46);
			this.lblAddVehiclePPSType.Name = "lblAddVehiclePPSType";
			this.lblAddVehiclePPSType.Size = new System.Drawing.Size(33, 17);
			this.lblAddVehiclePPSType.TabIndex = 1;
			this.lblAddVehiclePPSType.Text = "Вид";
			// 
			// lblAddVehiclePPSDKN
			// 
			this.lblAddVehiclePPSDKN.AutoSize = true;
			this.lblAddVehiclePPSDKN.Location = new System.Drawing.Point(16, 83);
			this.lblAddVehiclePPSDKN.Name = "lblAddVehiclePPSDKN";
			this.lblAddVehiclePPSDKN.Size = new System.Drawing.Size(38, 17);
			this.lblAddVehiclePPSDKN.TabIndex = 6;
			this.lblAddVehiclePPSDKN.Text = "ДКН";
			// 
			// cbAddVehiclePPSType
			// 
			this.cbAddVehiclePPSType.FormattingEnabled = true;
			this.cbAddVehiclePPSType.Items.AddRange(new object[] {
            "Ремарке",
            "Мотор",
            "Лека кола до 3,5 т.",
            "МПС (между 3,5 т. и 7,5 т.)",
            "МПС (между 7,5 т. и 12 т.)",
            "МПС (над 12 т.)"});
			this.cbAddVehiclePPSType.Location = new System.Drawing.Point(106, 43);
			this.cbAddVehiclePPSType.Name = "cbAddVehiclePPSType";
			this.cbAddVehiclePPSType.Size = new System.Drawing.Size(228, 24);
			this.cbAddVehiclePPSType.TabIndex = 0;
			this.cbAddVehiclePPSType.Text = "Моля изберете";
			// 
			// gbAddVehicleOwner
			// 
			this.gbAddVehicleOwner.Controls.Add(this.tbAddVehicleOwnerNameLast);
			this.gbAddVehicleOwner.Controls.Add(this.lblAddVehicleOwnerNameLast);
			this.gbAddVehicleOwner.Controls.Add(this.tbAddVehicleOwnerNameFirst);
			this.gbAddVehicleOwner.Controls.Add(this.lblAddVehicleOwnerNameFirst);
			this.gbAddVehicleOwner.Location = new System.Drawing.Point(18, 22);
			this.gbAddVehicleOwner.Name = "gbAddVehicleOwner";
			this.gbAddVehicleOwner.Size = new System.Drawing.Size(340, 139);
			this.gbAddVehicleOwner.TabIndex = 0;
			this.gbAddVehicleOwner.TabStop = false;
			this.gbAddVehicleOwner.Text = "Собственик";
			// 
			// tbAddVehicleOwnerNameLast
			// 
			this.tbAddVehicleOwnerNameLast.Location = new System.Drawing.Point(106, 83);
			this.tbAddVehicleOwnerNameLast.Name = "tbAddVehicleOwnerNameLast";
			this.tbAddVehicleOwnerNameLast.Size = new System.Drawing.Size(228, 22);
			this.tbAddVehicleOwnerNameLast.TabIndex = 3;
			// 
			// lblAddVehicleOwnerNameLast
			// 
			this.lblAddVehicleOwnerNameLast.AutoSize = true;
			this.lblAddVehicleOwnerNameLast.Location = new System.Drawing.Point(6, 83);
			this.lblAddVehicleOwnerNameLast.Name = "lblAddVehicleOwnerNameLast";
			this.lblAddVehicleOwnerNameLast.Size = new System.Drawing.Size(70, 17);
			this.lblAddVehicleOwnerNameLast.TabIndex = 2;
			this.lblAddVehicleOwnerNameLast.Text = "Фамилия";
			// 
			// tbAddVehicleOwnerNameFirst
			// 
			this.tbAddVehicleOwnerNameFirst.Location = new System.Drawing.Point(106, 43);
			this.tbAddVehicleOwnerNameFirst.Name = "tbAddVehicleOwnerNameFirst";
			this.tbAddVehicleOwnerNameFirst.Size = new System.Drawing.Size(228, 22);
			this.tbAddVehicleOwnerNameFirst.TabIndex = 1;
			// 
			// lblAddVehicleOwnerNameFirst
			// 
			this.lblAddVehicleOwnerNameFirst.AutoSize = true;
			this.lblAddVehicleOwnerNameFirst.Location = new System.Drawing.Point(6, 43);
			this.lblAddVehicleOwnerNameFirst.Name = "lblAddVehicleOwnerNameFirst";
			this.lblAddVehicleOwnerNameFirst.Size = new System.Drawing.Size(35, 17);
			this.lblAddVehicleOwnerNameFirst.TabIndex = 0;
			this.lblAddVehicleOwnerNameFirst.Text = "Име";
			// 
			// tabFinance
			// 
			this.tabFinance.Controls.Add(this.lblFinanceMonth);
			this.tabFinance.Controls.Add(this.cbFinanceMonth);
			this.tabFinance.Controls.Add(this.btnFinanceCalculateOwner);
			this.tabFinance.Controls.Add(this.btnFinanceCalculateAll);
			this.tabFinance.Controls.Add(this.rtbFinanceResult);
			this.tabFinance.Controls.Add(this.lblFinance);
			this.tabFinance.Location = new System.Drawing.Point(4, 25);
			this.tabFinance.Name = "tabFinance";
			this.tabFinance.Padding = new System.Windows.Forms.Padding(3);
			this.tabFinance.Size = new System.Drawing.Size(768, 471);
			this.tabFinance.TabIndex = 1;
			this.tabFinance.Text = "Финанси";
			this.tabFinance.UseVisualStyleBackColor = true;
			// 
			// lblFinanceMonth
			// 
			this.lblFinanceMonth.AutoSize = true;
			this.lblFinanceMonth.Location = new System.Drawing.Point(415, 29);
			this.lblFinanceMonth.Name = "lblFinanceMonth";
			this.lblFinanceMonth.Size = new System.Drawing.Size(50, 17);
			this.lblFinanceMonth.TabIndex = 7;
			this.lblFinanceMonth.Text = "Месец";
			// 
			// cbFinanceMonth
			// 
			this.cbFinanceMonth.FormattingEnabled = true;
			this.cbFinanceMonth.Items.AddRange(new object[] {
            "Януари",
            "Февруари",
            "Март",
            "Април",
            "Май",
            "Юни",
            "Юли",
            "Август",
            "Септември",
            "Октомври",
            "Ноември",
            "Декември"});
			this.cbFinanceMonth.Location = new System.Drawing.Point(492, 29);
			this.cbFinanceMonth.Name = "cbFinanceMonth";
			this.cbFinanceMonth.Size = new System.Drawing.Size(250, 24);
			this.cbFinanceMonth.TabIndex = 6;
			this.cbFinanceMonth.Text = "Моля изберете";
			// 
			// btnFinanceCalculateOwner
			// 
			this.btnFinanceCalculateOwner.Location = new System.Drawing.Point(378, 387);
			this.btnFinanceCalculateOwner.Name = "btnFinanceCalculateOwner";
			this.btnFinanceCalculateOwner.Size = new System.Drawing.Size(169, 63);
			this.btnFinanceCalculateOwner.TabIndex = 3;
			this.btnFinanceCalculateOwner.Text = "Изчисли приходи за месеца по собственик";
			this.btnFinanceCalculateOwner.UseVisualStyleBackColor = true;
			this.btnFinanceCalculateOwner.Click += new System.EventHandler(this.btnFinanceCalculateOwner_Click);
			// 
			// btnFinanceCalculateAll
			// 
			this.btnFinanceCalculateAll.Location = new System.Drawing.Point(178, 387);
			this.btnFinanceCalculateAll.Name = "btnFinanceCalculateAll";
			this.btnFinanceCalculateAll.Size = new System.Drawing.Size(169, 63);
			this.btnFinanceCalculateAll.TabIndex = 2;
			this.btnFinanceCalculateAll.Text = "Изчисли приходи за месеца общо";
			this.btnFinanceCalculateAll.UseVisualStyleBackColor = true;
			this.btnFinanceCalculateAll.Click += new System.EventHandler(this.btnFinanceCalculateAll_Click);
			// 
			// rtbFinanceResult
			// 
			this.rtbFinanceResult.Location = new System.Drawing.Point(27, 73);
			this.rtbFinanceResult.Name = "rtbFinanceResult";
			this.rtbFinanceResult.Size = new System.Drawing.Size(715, 289);
			this.rtbFinanceResult.TabIndex = 1;
			this.rtbFinanceResult.Text = "";
			// 
			// lblFinance
			// 
			this.lblFinance.AutoSize = true;
			this.lblFinance.Location = new System.Drawing.Point(27, 29);
			this.lblFinance.Name = "lblFinance";
			this.lblFinance.Size = new System.Drawing.Size(202, 17);
			this.lblFinance.TabIndex = 0;
			this.lblFinance.Text = "Очаквани приходи за месеца";
			// 
			// tabPricelist
			// 
			this.tabPricelist.Controls.Add(this.btnPricelistCheck);
			this.tabPricelist.Controls.Add(this.tbPricelistPrice);
			this.tabPricelist.Controls.Add(this.lblPricelistPrice);
			this.tabPricelist.Controls.Add(this.lbPricelistType);
			this.tabPricelist.Controls.Add(this.lblPricelistType);
			this.tabPricelist.Location = new System.Drawing.Point(4, 25);
			this.tabPricelist.Name = "tabPricelist";
			this.tabPricelist.Size = new System.Drawing.Size(768, 471);
			this.tabPricelist.TabIndex = 2;
			this.tabPricelist.Text = "Ценоразпис";
			this.tabPricelist.UseVisualStyleBackColor = true;
			// 
			// btnPricelistCheck
			// 
			this.btnPricelistCheck.Location = new System.Drawing.Point(400, 121);
			this.btnPricelistCheck.Name = "btnPricelistCheck";
			this.btnPricelistCheck.Size = new System.Drawing.Size(323, 34);
			this.btnPricelistCheck.TabIndex = 5;
			this.btnPricelistCheck.Text = "Провери цена";
			this.btnPricelistCheck.UseVisualStyleBackColor = true;
			this.btnPricelistCheck.Click += new System.EventHandler(this.btnPricelistCheck_Click);
			// 
			// tbPricelistPrice
			// 
			this.tbPricelistPrice.Location = new System.Drawing.Point(400, 55);
			this.tbPricelistPrice.Name = "tbPricelistPrice";
			this.tbPricelistPrice.Size = new System.Drawing.Size(323, 22);
			this.tbPricelistPrice.TabIndex = 4;
			// 
			// lblPricelistPrice
			// 
			this.lblPricelistPrice.AutoSize = true;
			this.lblPricelistPrice.Location = new System.Drawing.Point(400, 25);
			this.lblPricelistPrice.Name = "lblPricelistPrice";
			this.lblPricelistPrice.Size = new System.Drawing.Size(43, 17);
			this.lblPricelistPrice.TabIndex = 3;
			this.lblPricelistPrice.Text = "Цена";
			// 
			// lbPricelistType
			// 
			this.lbPricelistType.FormattingEnabled = true;
			this.lbPricelistType.ItemHeight = 16;
			this.lbPricelistType.Items.AddRange(new object[] {
            "Ремарке",
            "Мотор",
            "Лека кола до 3,5 т.",
            "МПС (между 3,5 т. и 7,5 т.)",
            "МПС (между 7,5 т. и 12 т.)",
            "МПС (над 12 т.)"});
			this.lbPricelistType.Location = new System.Drawing.Point(25, 55);
			this.lbPricelistType.Name = "lbPricelistType";
			this.lbPricelistType.Size = new System.Drawing.Size(322, 100);
			this.lbPricelistType.TabIndex = 2;
			// 
			// lblPricelistType
			// 
			this.lblPricelistType.AutoSize = true;
			this.lblPricelistType.Location = new System.Drawing.Point(25, 25);
			this.lblPricelistType.Name = "lblPricelistType";
			this.lblPricelistType.Size = new System.Drawing.Size(33, 17);
			this.lblPricelistType.TabIndex = 0;
			this.lblPricelistType.Text = "Вид";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 517);
			this.Controls.Add(this.tbAutoparkSystem);
			this.MaximumSize = new System.Drawing.Size(812, 564);
			this.MinimumSize = new System.Drawing.Size(812, 564);
			this.Name = "Form1";
			this.Text = "ParkPlace System";
			this.tbAutoparkSystem.ResumeLayout(false);
			this.tabAddVehicle.ResumeLayout(false);
			this.gbAddVehiclePPS.ResumeLayout(false);
			this.gbAddVehiclePPS.PerformLayout();
			this.gbAddVehicleOwner.ResumeLayout(false);
			this.gbAddVehicleOwner.PerformLayout();
			this.tabFinance.ResumeLayout(false);
			this.tabFinance.PerformLayout();
			this.tabPricelist.ResumeLayout(false);
			this.tabPricelist.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbAutoparkSystem;
		private System.Windows.Forms.TabPage tabAddVehicle;
		private System.Windows.Forms.TabPage tabFinance;
		private System.Windows.Forms.GroupBox gbAddVehiclePPS;
		private System.Windows.Forms.TextBox tbAddVehiclePPSDKN;
		private System.Windows.Forms.Label lblAddVehiclePPSType;
		private System.Windows.Forms.Label lblAddVehiclePPSDKN;
		private System.Windows.Forms.ComboBox cbAddVehiclePPSType;
		private System.Windows.Forms.GroupBox gbAddVehicleOwner;
		private System.Windows.Forms.TextBox tbAddVehicleOwnerNameLast;
		private System.Windows.Forms.Label lblAddVehicleOwnerNameLast;
		private System.Windows.Forms.TextBox tbAddVehicleOwnerNameFirst;
		private System.Windows.Forms.Label lblAddVehicleOwnerNameFirst;
		private System.Windows.Forms.TabPage tabPricelist;
		private System.Windows.Forms.TextBox tbPricelistPrice;
		private System.Windows.Forms.Label lblPricelistPrice;
		private System.Windows.Forms.ListBox lbPricelistType;
		private System.Windows.Forms.Label lblPricelistType;
		private System.Windows.Forms.Button btnPricelistCheck;
		private System.Windows.Forms.Button btnFinanceCalculateAll;
		private System.Windows.Forms.RichTextBox rtbFinanceResult;
		private System.Windows.Forms.Label lblFinance;
		private System.Windows.Forms.Label lblAddVehicleInfo;
		private System.Windows.Forms.Button btnAddVehicle;
		private System.Windows.Forms.Button btnFinanceCalculateOwner;
		private System.Windows.Forms.RichTextBox rtbAddVehicleInfo;
		private System.Windows.Forms.Label lblFinanceMonth;
		private System.Windows.Forms.ComboBox cbFinanceMonth;
	}
}

