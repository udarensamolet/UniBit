namespace VSP_46231z_10
{
	partial class FormAnimalInfo
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
			this.labelHeader = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxType = new System.Windows.Forms.TextBox();
			this.radioButtonNeuteredYes = new System.Windows.Forms.RadioButton();
			this.radioButtonNeuteredNo = new System.Windows.Forms.RadioButton();
			this.buttonCheckVaxDate = new System.Windows.Forms.Button();
			this.radioButtonVaxYes = new System.Windows.Forms.RadioButton();
			this.radioButtonVaxNo = new System.Windows.Forms.RadioButton();
			this.groupBoxVax = new System.Windows.Forms.GroupBox();
			this.dateTimePickerVax = new System.Windows.Forms.DateTimePicker();
			this.labelAge = new System.Windows.Forms.Label();
			this.textBoxAge = new System.Windows.Forms.TextBox();
			this.textBoxCheckInfo = new System.Windows.Forms.TextBox();
			this.groupBoxOwnerInfo = new System.Windows.Forms.GroupBox();
			this.textBoxOwnerPhone = new System.Windows.Forms.TextBox();
			this.textBoxOwnerName = new System.Windows.Forms.TextBox();
			this.labelOwnerPhone = new System.Windows.Forms.Label();
			this.labelOwnerName = new System.Windows.Forms.Label();
			this.groupBoxAnimalData = new System.Windows.Forms.GroupBox();
			this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
			this.radioButtonNeuteredUnknown = new System.Windows.Forms.RadioButton();
			this.groupBoxAvatar = new System.Windows.Forms.GroupBox();
			this.buttonChoseAvatar = new System.Windows.Forms.Button();
			this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
			this.groupBoxCheck = new System.Windows.Forms.GroupBox();
			this.labelFinalInfo = new System.Windows.Forms.Label();
			this.labelCheckInfo = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.openAvatarDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogInfo = new System.Windows.Forms.SaveFileDialog();
			this.richTextBoxFinalInfo = new System.Windows.Forms.RichTextBox();
			this.buttonGenerateFinalInfo = new System.Windows.Forms.Button();
			this.radioButtonSexMale = new System.Windows.Forms.RadioButton();
			this.radioButtonSexFemale = new System.Windows.Forms.RadioButton();
			this.checkBoxSexGivenBirth = new System.Windows.Forms.CheckBox();
			this.groupBoxSex = new System.Windows.Forms.GroupBox();
			this.groupBoxNeutered = new System.Windows.Forms.GroupBox();
			this.groupBoxVax.SuspendLayout();
			this.groupBoxOwnerInfo.SuspendLayout();
			this.groupBoxAnimalData.SuspendLayout();
			this.groupBoxAvatar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
			this.groupBoxCheck.SuspendLayout();
			this.groupBoxSex.SuspendLayout();
			this.groupBoxNeutered.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelHeader
			// 
			this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelHeader.AutoSize = true;
			this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHeader.Location = new System.Drawing.Point(598, 19);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Size = new System.Drawing.Size(240, 24);
			this.labelHeader.TabIndex = 0;
			this.labelHeader.Text = "Информация за пациента";
			// 
			// labelName
			// 
			this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(10, 36);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 17);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Име";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Location = new System.Drawing.Point(12, 71);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(123, 17);
			this.labelBirthDate.TabIndex = 2;
			this.labelBirthDate.Text = "Дата на раждане";
			// 
			// labelType
			// 
			this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(11, 140);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(33, 17);
			this.labelType.TabIndex = 3;
			this.labelType.Text = "Вид";
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxName.Location = new System.Drawing.Point(153, 31);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(387, 22);
			this.textBoxName.TabIndex = 6;
			this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
			// 
			// textBoxType
			// 
			this.textBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxType.Location = new System.Drawing.Point(152, 135);
			this.textBoxType.Name = "textBoxType";
			this.textBoxType.Size = new System.Drawing.Size(387, 22);
			this.textBoxType.TabIndex = 8;
			this.textBoxType.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
			// 
			// radioButtonNeuteredYes
			// 
			this.radioButtonNeuteredYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNeuteredYes.AutoSize = true;
			this.radioButtonNeuteredYes.Location = new System.Drawing.Point(9, 19);
			this.radioButtonNeuteredYes.Name = "radioButtonNeuteredYes";
			this.radioButtonNeuteredYes.Size = new System.Drawing.Size(48, 21);
			this.radioButtonNeuteredYes.TabIndex = 10;
			this.radioButtonNeuteredYes.Text = "Да";
			this.radioButtonNeuteredYes.UseVisualStyleBackColor = true;
			// 
			// radioButtonNeuteredNo
			// 
			this.radioButtonNeuteredNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNeuteredNo.AutoSize = true;
			this.radioButtonNeuteredNo.Location = new System.Drawing.Point(78, 19);
			this.radioButtonNeuteredNo.Name = "radioButtonNeuteredNo";
			this.radioButtonNeuteredNo.Size = new System.Drawing.Size(47, 21);
			this.radioButtonNeuteredNo.TabIndex = 11;
			this.radioButtonNeuteredNo.Text = "Не";
			this.radioButtonNeuteredNo.UseVisualStyleBackColor = true;
			this.radioButtonNeuteredNo.CheckedChanged += new System.EventHandler(this.RadioButtonNeuteredNo_CheckedChanged);
			// 
			// buttonCheckVaxDate
			// 
			this.buttonCheckVaxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCheckVaxDate.Location = new System.Drawing.Point(40, 189);
			this.buttonCheckVaxDate.Name = "buttonCheckVaxDate";
			this.buttonCheckVaxDate.Size = new System.Drawing.Size(359, 26);
			this.buttonCheckVaxDate.TabIndex = 12;
			this.buttonCheckVaxDate.Text = "Проверка на дата за предстояща ваксина";
			this.buttonCheckVaxDate.UseVisualStyleBackColor = true;
			this.buttonCheckVaxDate.Click += new System.EventHandler(this.ButtonCheckVaxDate_Click);
			// 
			// radioButtonVaxYes
			// 
			this.radioButtonVaxYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonVaxYes.AutoSize = true;
			this.radioButtonVaxYes.Location = new System.Drawing.Point(40, 75);
			this.radioButtonVaxYes.Name = "radioButtonVaxYes";
			this.radioButtonVaxYes.Size = new System.Drawing.Size(305, 21);
			this.radioButtonVaxYes.TabIndex = 14;
			this.radioButtonVaxYes.TabStop = true;
			this.radioButtonVaxYes.Text = "Да (Изберете дата на последна ваксина)";
			this.radioButtonVaxYes.UseVisualStyleBackColor = true;
			this.radioButtonVaxYes.CheckedChanged += new System.EventHandler(this.RadioButtonVaxYes_CheckedChanged);
			// 
			// radioButtonVaxNo
			// 
			this.radioButtonVaxNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonVaxNo.AutoSize = true;
			this.radioButtonVaxNo.Location = new System.Drawing.Point(40, 40);
			this.radioButtonVaxNo.Name = "radioButtonVaxNo";
			this.radioButtonVaxNo.Size = new System.Drawing.Size(47, 21);
			this.radioButtonVaxNo.TabIndex = 15;
			this.radioButtonVaxNo.TabStop = true;
			this.radioButtonVaxNo.Text = "Не";
			this.radioButtonVaxNo.UseVisualStyleBackColor = true;
			this.radioButtonVaxNo.CheckedChanged += new System.EventHandler(this.RadioButtonVaxNo_CheckedChanged);
			// 
			// groupBoxVax
			// 
			this.groupBoxVax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxVax.Controls.Add(this.dateTimePickerVax);
			this.groupBoxVax.Controls.Add(this.radioButtonVaxYes);
			this.groupBoxVax.Controls.Add(this.buttonCheckVaxDate);
			this.groupBoxVax.Controls.Add(this.radioButtonVaxNo);
			this.groupBoxVax.Location = new System.Drawing.Point(565, 31);
			this.groupBoxVax.Name = "groupBoxVax";
			this.groupBoxVax.Size = new System.Drawing.Size(445, 251);
			this.groupBoxVax.TabIndex = 16;
			this.groupBoxVax.TabStop = false;
			this.groupBoxVax.Text = "Имунизация";
			// 
			// dateTimePickerVax
			// 
			this.dateTimePickerVax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerVax.Location = new System.Drawing.Point(62, 119);
			this.dateTimePickerVax.Name = "dateTimePickerVax";
			this.dateTimePickerVax.Size = new System.Drawing.Size(337, 22);
			this.dateTimePickerVax.TabIndex = 17;
			// 
			// labelAge
			// 
			this.labelAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelAge.AutoSize = true;
			this.labelAge.Location = new System.Drawing.Point(12, 106);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(63, 17);
			this.labelAge.TabIndex = 17;
			this.labelAge.Text = "Възраст";
			// 
			// textBoxAge
			// 
			this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAge.Location = new System.Drawing.Point(152, 101);
			this.textBoxAge.Name = "textBoxAge";
			this.textBoxAge.Size = new System.Drawing.Size(387, 22);
			this.textBoxAge.TabIndex = 18;
			this.textBoxAge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxAge_MouseClick);
			this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
			// 
			// textBoxCheckInfo
			// 
			this.textBoxCheckInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCheckInfo.Location = new System.Drawing.Point(9, 58);
			this.textBoxCheckInfo.Multiline = true;
			this.textBoxCheckInfo.Name = "textBoxCheckInfo";
			this.textBoxCheckInfo.Size = new System.Drawing.Size(1412, 92);
			this.textBoxCheckInfo.TabIndex = 20;
			this.textBoxCheckInfo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
			// 
			// groupBoxOwnerInfo
			// 
			this.groupBoxOwnerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerPhone);
			this.groupBoxOwnerInfo.Controls.Add(this.textBoxOwnerName);
			this.groupBoxOwnerInfo.Controls.Add(this.labelOwnerPhone);
			this.groupBoxOwnerInfo.Controls.Add(this.labelOwnerName);
			this.groupBoxOwnerInfo.Location = new System.Drawing.Point(15, 373);
			this.groupBoxOwnerInfo.Name = "groupBoxOwnerInfo";
			this.groupBoxOwnerInfo.Size = new System.Drawing.Size(1436, 74);
			this.groupBoxOwnerInfo.TabIndex = 21;
			this.groupBoxOwnerInfo.TabStop = false;
			this.groupBoxOwnerInfo.Text = "Информация за собственик";
			// 
			// textBoxOwnerPhone
			// 
			this.textBoxOwnerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOwnerPhone.Location = new System.Drawing.Point(916, 36);
			this.textBoxOwnerPhone.Name = "textBoxOwnerPhone";
			this.textBoxOwnerPhone.Size = new System.Drawing.Size(514, 22);
			this.textBoxOwnerPhone.TabIndex = 3;
			this.textBoxOwnerPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxOwnerPhone_Validating);
			// 
			// textBoxOwnerName
			// 
			this.textBoxOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOwnerName.Location = new System.Drawing.Point(47, 36);
			this.textBoxOwnerName.Name = "textBoxOwnerName";
			this.textBoxOwnerName.Size = new System.Drawing.Size(514, 22);
			this.textBoxOwnerName.TabIndex = 2;
			this.textBoxOwnerName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpty_Validating);
			// 
			// labelOwnerPhone
			// 
			this.labelOwnerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelOwnerPhone.AutoSize = true;
			this.labelOwnerPhone.Location = new System.Drawing.Point(830, 39);
			this.labelOwnerPhone.Name = "labelOwnerPhone";
			this.labelOwnerPhone.Size = new System.Drawing.Size(68, 17);
			this.labelOwnerPhone.TabIndex = 1;
			this.labelOwnerPhone.Text = "Телефон";
			// 
			// labelOwnerName
			// 
			this.labelOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelOwnerName.AutoSize = true;
			this.labelOwnerName.Location = new System.Drawing.Point(6, 36);
			this.labelOwnerName.Name = "labelOwnerName";
			this.labelOwnerName.Size = new System.Drawing.Size(35, 17);
			this.labelOwnerName.TabIndex = 0;
			this.labelOwnerName.Text = "Име";
			// 
			// groupBoxAnimalData
			// 
			this.groupBoxAnimalData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAnimalData.Controls.Add(this.groupBoxNeutered);
			this.groupBoxAnimalData.Controls.Add(this.groupBoxSex);
			this.groupBoxAnimalData.Controls.Add(this.dateTimePickerBirth);
			this.groupBoxAnimalData.Controls.Add(this.groupBoxAvatar);
			this.groupBoxAnimalData.Controls.Add(this.labelName);
			this.groupBoxAnimalData.Controls.Add(this.labelBirthDate);
			this.groupBoxAnimalData.Controls.Add(this.labelType);
			this.groupBoxAnimalData.Controls.Add(this.textBoxAge);
			this.groupBoxAnimalData.Controls.Add(this.labelAge);
			this.groupBoxAnimalData.Controls.Add(this.groupBoxVax);
			this.groupBoxAnimalData.Controls.Add(this.textBoxName);
			this.groupBoxAnimalData.Controls.Add(this.textBoxType);
			this.groupBoxAnimalData.Location = new System.Drawing.Point(15, 46);
			this.groupBoxAnimalData.Name = "groupBoxAnimalData";
			this.groupBoxAnimalData.Size = new System.Drawing.Size(1436, 307);
			this.groupBoxAnimalData.TabIndex = 22;
			this.groupBoxAnimalData.TabStop = false;
			this.groupBoxAnimalData.Text = "Информация за животното";
			// 
			// dateTimePickerBirth
			// 
			this.dateTimePickerBirth.Location = new System.Drawing.Point(152, 66);
			this.dateTimePickerBirth.Name = "dateTimePickerBirth";
			this.dateTimePickerBirth.Size = new System.Drawing.Size(287, 22);
			this.dateTimePickerBirth.TabIndex = 24;
			// 
			// radioButtonNeuteredUnknown
			// 
			this.radioButtonNeuteredUnknown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonNeuteredUnknown.AutoSize = true;
			this.radioButtonNeuteredUnknown.Checked = true;
			this.radioButtonNeuteredUnknown.Location = new System.Drawing.Point(149, 21);
			this.radioButtonNeuteredUnknown.Name = "radioButtonNeuteredUnknown";
			this.radioButtonNeuteredUnknown.Size = new System.Drawing.Size(107, 21);
			this.radioButtonNeuteredUnknown.TabIndex = 20;
			this.radioButtonNeuteredUnknown.TabStop = true;
			this.radioButtonNeuteredUnknown.Text = "Неизвестно";
			this.radioButtonNeuteredUnknown.UseVisualStyleBackColor = true;
			// 
			// groupBoxAvatar
			// 
			this.groupBoxAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxAvatar.Controls.Add(this.buttonChoseAvatar);
			this.groupBoxAvatar.Controls.Add(this.pictureBoxAvatar);
			this.groupBoxAvatar.Location = new System.Drawing.Point(1032, 31);
			this.groupBoxAvatar.Name = "groupBoxAvatar";
			this.groupBoxAvatar.Size = new System.Drawing.Size(377, 251);
			this.groupBoxAvatar.TabIndex = 19;
			this.groupBoxAvatar.TabStop = false;
			this.groupBoxAvatar.Text = "Снимка";
			// 
			// buttonChoseAvatar
			// 
			this.buttonChoseAvatar.Location = new System.Drawing.Point(199, 121);
			this.buttonChoseAvatar.Name = "buttonChoseAvatar";
			this.buttonChoseAvatar.Size = new System.Drawing.Size(139, 23);
			this.buttonChoseAvatar.TabIndex = 1;
			this.buttonChoseAvatar.Text = "Избери снимка";
			this.buttonChoseAvatar.UseVisualStyleBackColor = true;
			this.buttonChoseAvatar.Click += new System.EventHandler(this.ButtonChoseAvatar_Click);
			// 
			// pictureBoxAvatar
			// 
			this.pictureBoxAvatar.Location = new System.Drawing.Point(21, 30);
			this.pictureBoxAvatar.Name = "pictureBoxAvatar";
			this.pictureBoxAvatar.Size = new System.Drawing.Size(135, 185);
			this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxAvatar.TabIndex = 0;
			this.pictureBoxAvatar.TabStop = false;
			// 
			// groupBoxCheck
			// 
			this.groupBoxCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxCheck.Controls.Add(this.buttonGenerateFinalInfo);
			this.groupBoxCheck.Controls.Add(this.richTextBoxFinalInfo);
			this.groupBoxCheck.Controls.Add(this.labelFinalInfo);
			this.groupBoxCheck.Controls.Add(this.labelCheckInfo);
			this.groupBoxCheck.Controls.Add(this.buttonSave);
			this.groupBoxCheck.Controls.Add(this.textBoxCheckInfo);
			this.groupBoxCheck.Location = new System.Drawing.Point(15, 470);
			this.groupBoxCheck.Name = "groupBoxCheck";
			this.groupBoxCheck.Size = new System.Drawing.Size(1436, 471);
			this.groupBoxCheck.TabIndex = 23;
			this.groupBoxCheck.TabStop = false;
			this.groupBoxCheck.Text = "Преглед";
			// 
			// labelFinalInfo
			// 
			this.labelFinalInfo.AutoSize = true;
			this.labelFinalInfo.Location = new System.Drawing.Point(6, 184);
			this.labelFinalInfo.Name = "labelFinalInfo";
			this.labelFinalInfo.Size = new System.Drawing.Size(166, 17);
			this.labelFinalInfo.TabIndex = 24;
			this.labelFinalInfo.Text = "Заключение от преглед";
			// 
			// labelCheckInfo
			// 
			this.labelCheckInfo.AutoSize = true;
			this.labelCheckInfo.Location = new System.Drawing.Point(6, 38);
			this.labelCheckInfo.Name = "labelCheckInfo";
			this.labelCheckInfo.Size = new System.Drawing.Size(170, 17);
			this.labelCheckInfo.TabIndex = 23;
			this.labelCheckInfo.Text = "Информация от преглед";
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(833, 390);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(247, 42);
			this.buttonSave.TabIndex = 21;
			this.buttonSave.Text = "Запиши файл";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// openAvatarDialog
			// 
			this.openAvatarDialog.FileName = "openFileDialog1";
			this.openAvatarDialog.Filter = "Image files(*.jpg;*.gif)|*jpg;*gif|All Files(*.*)|*.*";
			// 
			// richTextBoxFinalInfo
			// 
			this.richTextBoxFinalInfo.Location = new System.Drawing.Point(9, 204);
			this.richTextBoxFinalInfo.Name = "richTextBoxFinalInfo";
			this.richTextBoxFinalInfo.Size = new System.Drawing.Size(1412, 149);
			this.richTextBoxFinalInfo.TabIndex = 25;
			this.richTextBoxFinalInfo.Text = "";
			// 
			// buttonGenerateFinalInfo
			// 
			this.buttonGenerateFinalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGenerateFinalInfo.Location = new System.Drawing.Point(371, 390);
			this.buttonGenerateFinalInfo.Name = "buttonGenerateFinalInfo";
			this.buttonGenerateFinalInfo.Size = new System.Drawing.Size(247, 42);
			this.buttonGenerateFinalInfo.TabIndex = 26;
			this.buttonGenerateFinalInfo.Text = "Генерирай заключение";
			this.buttonGenerateFinalInfo.UseVisualStyleBackColor = true;
			this.buttonGenerateFinalInfo.Click += new System.EventHandler(this.ButtonGenerateFinalInfo_Click);
			// 
			// radioButtonSexMale
			// 
			this.radioButtonSexMale.AutoSize = true;
			this.radioButtonSexMale.Location = new System.Drawing.Point(6, 21);
			this.radioButtonSexMale.Name = "radioButtonSexMale";
			this.radioButtonSexMale.Size = new System.Drawing.Size(58, 21);
			this.radioButtonSexMale.TabIndex = 25;
			this.radioButtonSexMale.TabStop = true;
			this.radioButtonSexMale.Text = "Мъж";
			this.radioButtonSexMale.UseVisualStyleBackColor = true;
			this.radioButtonSexMale.CheckedChanged += new System.EventHandler(this.RadioButtonSexMale_CheckedChanged);
			// 
			// radioButtonSexFemale
			// 
			this.radioButtonSexFemale.AutoSize = true;
			this.radioButtonSexFemale.Location = new System.Drawing.Point(78, 21);
			this.radioButtonSexFemale.Name = "radioButtonSexFemale";
			this.radioButtonSexFemale.Size = new System.Drawing.Size(66, 21);
			this.radioButtonSexFemale.TabIndex = 26;
			this.radioButtonSexFemale.TabStop = true;
			this.radioButtonSexFemale.Text = "Жена";
			this.radioButtonSexFemale.UseVisualStyleBackColor = true;
			this.radioButtonSexFemale.CheckedChanged += new System.EventHandler(this.RadioButtonSexFemale_CheckedChanged);
			// 
			// checkBoxSexGivenBirth
			// 
			this.checkBoxSexGivenBirth.AutoSize = true;
			this.checkBoxSexGivenBirth.Location = new System.Drawing.Point(150, 21);
			this.checkBoxSexGivenBirth.Name = "checkBoxSexGivenBirth";
			this.checkBoxSexGivenBirth.Size = new System.Drawing.Size(88, 21);
			this.checkBoxSexGivenBirth.TabIndex = 27;
			this.checkBoxSexGivenBirth.Text = "Раждала";
			this.checkBoxSexGivenBirth.UseVisualStyleBackColor = true;
			// 
			// groupBoxSex
			// 
			this.groupBoxSex.Controls.Add(this.checkBoxSexGivenBirth);
			this.groupBoxSex.Controls.Add(this.radioButtonSexMale);
			this.groupBoxSex.Controls.Add(this.radioButtonSexFemale);
			this.groupBoxSex.Location = new System.Drawing.Point(15, 166);
			this.groupBoxSex.Name = "groupBoxSex";
			this.groupBoxSex.Size = new System.Drawing.Size(527, 55);
			this.groupBoxSex.TabIndex = 27;
			this.groupBoxSex.TabStop = false;
			this.groupBoxSex.Text = "Пол";
			// 
			// groupBoxNeutered
			// 
			this.groupBoxNeutered.Controls.Add(this.radioButtonNeuteredUnknown);
			this.groupBoxNeutered.Controls.Add(this.radioButtonNeuteredYes);
			this.groupBoxNeutered.Controls.Add(this.radioButtonNeuteredNo);
			this.groupBoxNeutered.Location = new System.Drawing.Point(15, 227);
			this.groupBoxNeutered.Name = "groupBoxNeutered";
			this.groupBoxNeutered.Size = new System.Drawing.Size(525, 55);
			this.groupBoxNeutered.TabIndex = 27;
			this.groupBoxNeutered.TabStop = false;
			this.groupBoxNeutered.Text = "Кастриран";
			// 
			// FormAnimalInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1469, 953);
			this.Controls.Add(this.groupBoxCheck);
			this.Controls.Add(this.groupBoxAnimalData);
			this.Controls.Add(this.groupBoxOwnerInfo);
			this.Controls.Add(this.labelHeader);
			this.MaximumSize = new System.Drawing.Size(1487, 1000);
			this.MinimumSize = new System.Drawing.Size(1487, 1000);
			this.Name = "FormAnimalInfo";
			this.Text = "Пациентско досие на животно";
			this.groupBoxVax.ResumeLayout(false);
			this.groupBoxVax.PerformLayout();
			this.groupBoxOwnerInfo.ResumeLayout(false);
			this.groupBoxOwnerInfo.PerformLayout();
			this.groupBoxAnimalData.ResumeLayout(false);
			this.groupBoxAnimalData.PerformLayout();
			this.groupBoxAvatar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
			this.groupBoxCheck.ResumeLayout(false);
			this.groupBoxCheck.PerformLayout();
			this.groupBoxSex.ResumeLayout(false);
			this.groupBoxSex.PerformLayout();
			this.groupBoxNeutered.ResumeLayout(false);
			this.groupBoxNeutered.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxType;
		private System.Windows.Forms.RadioButton radioButtonNeuteredYes;
		private System.Windows.Forms.RadioButton radioButtonNeuteredNo;
		private System.Windows.Forms.Button buttonCheckVaxDate;
		private System.Windows.Forms.RadioButton radioButtonVaxYes;
		private System.Windows.Forms.RadioButton radioButtonVaxNo;
		private System.Windows.Forms.GroupBox groupBoxVax;
		private System.Windows.Forms.DateTimePicker dateTimePickerVax;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.TextBox textBoxAge;
		private System.Windows.Forms.TextBox textBoxCheckInfo;
		private System.Windows.Forms.GroupBox groupBoxOwnerInfo;
		private System.Windows.Forms.TextBox textBoxOwnerPhone;
		private System.Windows.Forms.TextBox textBoxOwnerName;
		private System.Windows.Forms.Label labelOwnerPhone;
		private System.Windows.Forms.Label labelOwnerName;
		private System.Windows.Forms.GroupBox groupBoxAnimalData;
		private System.Windows.Forms.GroupBox groupBoxCheck;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.RadioButton radioButtonNeuteredUnknown;
		private System.Windows.Forms.GroupBox groupBoxAvatar;
		private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
		private System.Windows.Forms.Button buttonChoseAvatar;
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.OpenFileDialog openAvatarDialog;
		private System.Windows.Forms.Label labelCheckInfo;
		private System.Windows.Forms.Label labelFinalInfo;
		private System.Windows.Forms.SaveFileDialog saveFileDialogInfo;
		private System.Windows.Forms.RichTextBox richTextBoxFinalInfo;
		private System.Windows.Forms.Button buttonGenerateFinalInfo;
		private System.Windows.Forms.RadioButton radioButtonSexFemale;
		private System.Windows.Forms.RadioButton radioButtonSexMale;
		private System.Windows.Forms.CheckBox checkBoxSexGivenBirth;
		private System.Windows.Forms.GroupBox groupBoxNeutered;
		private System.Windows.Forms.GroupBox groupBoxSex;
	}
}

