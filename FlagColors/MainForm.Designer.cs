﻿namespace FlagColors
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            flagsListView = new ListView();
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            filterButtonResetShapes = new Button();
            groupBox1 = new GroupBox();
            filterCheckBoxTriangles = new CheckBox();
            filterCheckBoxWriting = new CheckBox();
            filterCheckBoxMoon = new CheckBox();
            filterCheckBoxDiagonal = new CheckBox();
            filterCheckBoxVertical = new CheckBox();
            filterCheckBoxHorizontal = new CheckBox();
            filterCheckBoxCrosses = new CheckBox();
            label5 = new Label();
            filterCheckBoxExactMatch = new CheckBox();
            filterCheckBoxPurple = new CheckBox();
            filterButtonResetName = new Button();
            filterTextBoxName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            filterCheckBoxPicture = new CheckBox();
            filterCheckBoxWhite = new CheckBox();
            filterCheckBoxBlack = new CheckBox();
            filterCheckBoxBlue = new CheckBox();
            filterCheckBoxGreen = new CheckBox();
            filterCheckBoxYellow = new CheckBox();
            filterCheckBoxRed = new CheckBox();
            tabPage2 = new TabPage();
            editorCheckBoxWriting = new CheckBox();
            editorCheckBoxMoon = new CheckBox();
            label6 = new Label();
            editorCheckBoxTriangles = new CheckBox();
            editorCheckBoxCrosses = new CheckBox();
            editorCheckBoxDiagonal = new CheckBox();
            editorCheckBoxVertical = new CheckBox();
            editorCheckBoxHorizontal = new CheckBox();
            editorCheckBoxWhite = new CheckBox();
            editorButtonLoad = new Button();
            editorButtonSave = new Button();
            editorCheckBoxBlack = new CheckBox();
            editorCheckBoxPicture = new CheckBox();
            label2 = new Label();
            editorCheckBoxPurple = new CheckBox();
            editorCheckBoxBlue = new CheckBox();
            editorCheckBoxGreen = new CheckBox();
            editorCheckBoxYellow = new CheckBox();
            editorCheckBoxRed = new CheckBox();
            label1 = new Label();
            editorTextBoxCountry = new TextBox();
            editorButtonRename = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // flagsListView
            // 
            flagsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flagsListView.LargeImageList = imageList1;
            flagsListView.Location = new Point(12, 204);
            flagsListView.Name = "flagsListView";
            flagsListView.Size = new Size(946, 354);
            flagsListView.TabIndex = 1;
            flagsListView.UseCompatibleStateImageBehavior = false;
            flagsListView.ItemSelectionChanged += OnItemSelectionChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(128, 64);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(948, 190);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += OnTabControlSelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(filterButtonResetShapes);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(filterCheckBoxTriangles);
            tabPage1.Controls.Add(filterCheckBoxWriting);
            tabPage1.Controls.Add(filterCheckBoxMoon);
            tabPage1.Controls.Add(filterCheckBoxDiagonal);
            tabPage1.Controls.Add(filterCheckBoxVertical);
            tabPage1.Controls.Add(filterCheckBoxHorizontal);
            tabPage1.Controls.Add(filterCheckBoxCrosses);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(filterCheckBoxExactMatch);
            tabPage1.Controls.Add(filterCheckBoxPurple);
            tabPage1.Controls.Add(filterButtonResetName);
            tabPage1.Controls.Add(filterTextBoxName);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(filterCheckBoxPicture);
            tabPage1.Controls.Add(filterCheckBoxWhite);
            tabPage1.Controls.Add(filterCheckBoxBlack);
            tabPage1.Controls.Add(filterCheckBoxBlue);
            tabPage1.Controls.Add(filterCheckBoxGreen);
            tabPage1.Controls.Add(filterCheckBoxYellow);
            tabPage1.Controls.Add(filterCheckBoxRed);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(940, 158);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Filter";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(6, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(928, 10);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // filterButtonResetShapes
            // 
            filterButtonResetShapes.Location = new Point(580, 50);
            filterButtonResetShapes.Name = "filterButtonResetShapes";
            filterButtonResetShapes.Size = new Size(73, 57);
            filterButtonResetShapes.TabIndex = 25;
            filterButtonResetShapes.Text = "Reset shapes";
            filterButtonResetShapes.UseVisualStyleBackColor = true;
            filterButtonResetShapes.Click += OnFilterButtonResetShapesClick;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(928, 10);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // filterCheckBoxTriangles
            // 
            filterCheckBoxTriangles.AutoSize = true;
            filterCheckBoxTriangles.Location = new Point(215, 83);
            filterCheckBoxTriangles.Name = "filterCheckBoxTriangles";
            filterCheckBoxTriangles.Size = new Size(103, 24);
            filterCheckBoxTriangles.TabIndex = 20;
            filterCheckBoxTriangles.Text = "TRIANGLES";
            filterCheckBoxTriangles.UseVisualStyleBackColor = true;
            filterCheckBoxTriangles.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxWriting
            // 
            filterCheckBoxWriting.AutoSize = true;
            filterCheckBoxWriting.Location = new Point(478, 83);
            filterCheckBoxWriting.Name = "filterCheckBoxWriting";
            filterCheckBoxWriting.Size = new Size(88, 24);
            filterCheckBoxWriting.TabIndex = 19;
            filterCheckBoxWriting.Text = "WRITING";
            filterCheckBoxWriting.UseVisualStyleBackColor = true;
            filterCheckBoxWriting.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxMoon
            // 
            filterCheckBoxMoon.AutoSize = true;
            filterCheckBoxMoon.Location = new Point(324, 83);
            filterCheckBoxMoon.Name = "filterCheckBoxMoon";
            filterCheckBoxMoon.Size = new Size(148, 24);
            filterCheckBoxMoon.TabIndex = 18;
            filterCheckBoxMoon.Text = "CRESCENT MOON";
            filterCheckBoxMoon.UseVisualStyleBackColor = true;
            filterCheckBoxMoon.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxDiagonal
            // 
            filterCheckBoxDiagonal.AutoSize = true;
            filterCheckBoxDiagonal.Location = new Point(425, 53);
            filterCheckBoxDiagonal.Name = "filterCheckBoxDiagonal";
            filterCheckBoxDiagonal.Size = new Size(144, 24);
            filterCheckBoxDiagonal.TabIndex = 17;
            filterCheckBoxDiagonal.Text = "DIAGONAL LINES";
            filterCheckBoxDiagonal.UseVisualStyleBackColor = true;
            filterCheckBoxDiagonal.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxVertical
            // 
            filterCheckBoxVertical.AutoSize = true;
            filterCheckBoxVertical.Location = new Point(286, 53);
            filterCheckBoxVertical.Name = "filterCheckBoxVertical";
            filterCheckBoxVertical.Size = new Size(133, 24);
            filterCheckBoxVertical.TabIndex = 16;
            filterCheckBoxVertical.Text = "VERTICAL LINES";
            filterCheckBoxVertical.UseVisualStyleBackColor = true;
            filterCheckBoxVertical.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxHorizontal
            // 
            filterCheckBoxHorizontal.AutoSize = true;
            filterCheckBoxHorizontal.Location = new Point(120, 53);
            filterCheckBoxHorizontal.Name = "filterCheckBoxHorizontal";
            filterCheckBoxHorizontal.Size = new Size(160, 24);
            filterCheckBoxHorizontal.TabIndex = 15;
            filterCheckBoxHorizontal.Text = "HORIZONTAL LINES";
            filterCheckBoxHorizontal.UseVisualStyleBackColor = true;
            filterCheckBoxHorizontal.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxCrosses
            // 
            filterCheckBoxCrosses.AutoSize = true;
            filterCheckBoxCrosses.Location = new Point(120, 83);
            filterCheckBoxCrosses.Name = "filterCheckBoxCrosses";
            filterCheckBoxCrosses.Size = new Size(89, 24);
            filterCheckBoxCrosses.TabIndex = 14;
            filterCheckBoxCrosses.Text = "CROSSES";
            filterCheckBoxCrosses.UseVisualStyleBackColor = true;
            filterCheckBoxCrosses.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 53);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 13;
            label5.Text = "Select shapes";
            // 
            // filterCheckBoxExactMatch
            // 
            filterCheckBoxExactMatch.AutoSize = true;
            filterCheckBoxExactMatch.Location = new Point(780, 10);
            filterCheckBoxExactMatch.Name = "filterCheckBoxExactMatch";
            filterCheckBoxExactMatch.Size = new Size(108, 24);
            filterCheckBoxExactMatch.TabIndex = 12;
            filterCheckBoxExactMatch.Text = "Exact match";
            filterCheckBoxExactMatch.UseVisualStyleBackColor = true;
            filterCheckBoxExactMatch.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxPurple
            // 
            filterCheckBoxPurple.AutoSize = true;
            filterCheckBoxPurple.BackColor = Color.MediumOrchid;
            filterCheckBoxPurple.Location = new Point(418, 10);
            filterCheckBoxPurple.Name = "filterCheckBoxPurple";
            filterCheckBoxPurple.Size = new Size(78, 24);
            filterCheckBoxPurple.TabIndex = 11;
            filterCheckBoxPurple.Text = "PURPLE";
            filterCheckBoxPurple.UseVisualStyleBackColor = false;
            filterCheckBoxPurple.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterButtonResetName
            // 
            filterButtonResetName.Location = new Point(270, 127);
            filterButtonResetName.Name = "filterButtonResetName";
            filterButtonResetName.Size = new Size(142, 27);
            filterButtonResetName.TabIndex = 10;
            filterButtonResetName.Text = "Reset name";
            filterButtonResetName.UseVisualStyleBackColor = true;
            filterButtonResetName.Click += OnFilterButtonResetClick;
            // 
            // filterTextBoxName
            // 
            filterTextBoxName.Location = new Point(120, 128);
            filterTextBoxName.Name = "filterTextBoxName";
            filterTextBoxName.Size = new Size(144, 26);
            filterTextBoxName.TabIndex = 9;
            filterTextBoxName.TextChanged += OnFilterTextBoxNameTextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 8;
            label4.Text = "Type name...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 7;
            label3.Text = "Select colors";
            // 
            // filterCheckBoxPicture
            // 
            filterCheckBoxPicture.AutoSize = true;
            filterCheckBoxPicture.Location = new Point(659, 10);
            filterCheckBoxPicture.Name = "filterCheckBoxPicture";
            filterCheckBoxPicture.Size = new Size(84, 24);
            filterCheckBoxPicture.TabIndex = 6;
            filterCheckBoxPicture.Text = "PICTURE";
            filterCheckBoxPicture.UseVisualStyleBackColor = true;
            filterCheckBoxPicture.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxWhite
            // 
            filterCheckBoxWhite.AutoSize = true;
            filterCheckBoxWhite.BackColor = Color.Gainsboro;
            filterCheckBoxWhite.Location = new Point(580, 10);
            filterCheckBoxWhite.Name = "filterCheckBoxWhite";
            filterCheckBoxWhite.Size = new Size(73, 24);
            filterCheckBoxWhite.TabIndex = 5;
            filterCheckBoxWhite.Text = "WHITE";
            filterCheckBoxWhite.UseVisualStyleBackColor = false;
            filterCheckBoxWhite.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxBlack
            // 
            filterCheckBoxBlack.AutoSize = true;
            filterCheckBoxBlack.BackColor = Color.DimGray;
            filterCheckBoxBlack.Location = new Point(502, 10);
            filterCheckBoxBlack.Name = "filterCheckBoxBlack";
            filterCheckBoxBlack.Size = new Size(72, 24);
            filterCheckBoxBlack.TabIndex = 4;
            filterCheckBoxBlack.Text = "BLACK";
            filterCheckBoxBlack.UseVisualStyleBackColor = false;
            filterCheckBoxBlack.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxBlue
            // 
            filterCheckBoxBlue.AutoSize = true;
            filterCheckBoxBlue.BackColor = Color.DodgerBlue;
            filterCheckBoxBlue.Location = new Point(350, 10);
            filterCheckBoxBlue.Name = "filterCheckBoxBlue";
            filterCheckBoxBlue.Size = new Size(62, 24);
            filterCheckBoxBlue.TabIndex = 3;
            filterCheckBoxBlue.Text = "BLUE";
            filterCheckBoxBlue.UseVisualStyleBackColor = false;
            filterCheckBoxBlue.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxGreen
            // 
            filterCheckBoxGreen.AutoSize = true;
            filterCheckBoxGreen.BackColor = Color.LimeGreen;
            filterCheckBoxGreen.Location = new Point(270, 10);
            filterCheckBoxGreen.Name = "filterCheckBoxGreen";
            filterCheckBoxGreen.Size = new Size(74, 24);
            filterCheckBoxGreen.TabIndex = 2;
            filterCheckBoxGreen.Text = "GREEN";
            filterCheckBoxGreen.UseVisualStyleBackColor = false;
            filterCheckBoxGreen.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxYellow
            // 
            filterCheckBoxYellow.AutoSize = true;
            filterCheckBoxYellow.BackColor = Color.Yellow;
            filterCheckBoxYellow.Location = new Point(182, 10);
            filterCheckBoxYellow.Name = "filterCheckBoxYellow";
            filterCheckBoxYellow.Size = new Size(82, 24);
            filterCheckBoxYellow.TabIndex = 1;
            filterCheckBoxYellow.Text = "YELLOW";
            filterCheckBoxYellow.UseVisualStyleBackColor = false;
            filterCheckBoxYellow.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // filterCheckBoxRed
            // 
            filterCheckBoxRed.AutoSize = true;
            filterCheckBoxRed.BackColor = Color.Red;
            filterCheckBoxRed.Location = new Point(120, 10);
            filterCheckBoxRed.Name = "filterCheckBoxRed";
            filterCheckBoxRed.Size = new Size(56, 24);
            filterCheckBoxRed.TabIndex = 0;
            filterCheckBoxRed.Text = "RED";
            filterCheckBoxRed.UseVisualStyleBackColor = false;
            filterCheckBoxRed.CheckedChanged += OnFilterCheckBoxCheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(editorCheckBoxWriting);
            tabPage2.Controls.Add(editorCheckBoxMoon);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(editorCheckBoxTriangles);
            tabPage2.Controls.Add(editorCheckBoxCrosses);
            tabPage2.Controls.Add(editorCheckBoxDiagonal);
            tabPage2.Controls.Add(editorCheckBoxVertical);
            tabPage2.Controls.Add(editorCheckBoxHorizontal);
            tabPage2.Controls.Add(editorCheckBoxWhite);
            tabPage2.Controls.Add(editorButtonLoad);
            tabPage2.Controls.Add(editorButtonSave);
            tabPage2.Controls.Add(editorCheckBoxBlack);
            tabPage2.Controls.Add(editorCheckBoxPicture);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(editorCheckBoxPurple);
            tabPage2.Controls.Add(editorCheckBoxBlue);
            tabPage2.Controls.Add(editorCheckBoxGreen);
            tabPage2.Controls.Add(editorCheckBoxYellow);
            tabPage2.Controls.Add(editorCheckBoxRed);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(editorTextBoxCountry);
            tabPage2.Controls.Add(editorButtonRename);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(940, 158);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // editorCheckBoxWriting
            // 
            editorCheckBoxWriting.AutoSize = true;
            editorCheckBoxWriting.Location = new Point(478, 83);
            editorCheckBoxWriting.Name = "editorCheckBoxWriting";
            editorCheckBoxWriting.Size = new Size(88, 24);
            editorCheckBoxWriting.TabIndex = 24;
            editorCheckBoxWriting.Text = "WRITING";
            editorCheckBoxWriting.UseVisualStyleBackColor = true;
            editorCheckBoxWriting.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxMoon
            // 
            editorCheckBoxMoon.AutoSize = true;
            editorCheckBoxMoon.Location = new Point(324, 83);
            editorCheckBoxMoon.Name = "editorCheckBoxMoon";
            editorCheckBoxMoon.Size = new Size(148, 24);
            editorCheckBoxMoon.TabIndex = 23;
            editorCheckBoxMoon.Text = "CRESCENT MOON";
            editorCheckBoxMoon.UseVisualStyleBackColor = true;
            editorCheckBoxMoon.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 53);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 22;
            label6.Text = "Assign shapes";
            // 
            // editorCheckBoxTriangles
            // 
            editorCheckBoxTriangles.AutoSize = true;
            editorCheckBoxTriangles.Location = new Point(215, 83);
            editorCheckBoxTriangles.Name = "editorCheckBoxTriangles";
            editorCheckBoxTriangles.Size = new Size(103, 24);
            editorCheckBoxTriangles.TabIndex = 21;
            editorCheckBoxTriangles.Text = "TRIANGLES";
            editorCheckBoxTriangles.UseVisualStyleBackColor = true;
            editorCheckBoxTriangles.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxCrosses
            // 
            editorCheckBoxCrosses.AutoSize = true;
            editorCheckBoxCrosses.Location = new Point(120, 83);
            editorCheckBoxCrosses.Name = "editorCheckBoxCrosses";
            editorCheckBoxCrosses.Size = new Size(89, 24);
            editorCheckBoxCrosses.TabIndex = 20;
            editorCheckBoxCrosses.Text = "CROSSES";
            editorCheckBoxCrosses.UseVisualStyleBackColor = true;
            editorCheckBoxCrosses.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxDiagonal
            // 
            editorCheckBoxDiagonal.AutoSize = true;
            editorCheckBoxDiagonal.Location = new Point(425, 53);
            editorCheckBoxDiagonal.Name = "editorCheckBoxDiagonal";
            editorCheckBoxDiagonal.Size = new Size(144, 24);
            editorCheckBoxDiagonal.TabIndex = 19;
            editorCheckBoxDiagonal.Text = "DIAGONAL LINES";
            editorCheckBoxDiagonal.UseVisualStyleBackColor = true;
            editorCheckBoxDiagonal.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxVertical
            // 
            editorCheckBoxVertical.AutoSize = true;
            editorCheckBoxVertical.Location = new Point(286, 53);
            editorCheckBoxVertical.Name = "editorCheckBoxVertical";
            editorCheckBoxVertical.Size = new Size(133, 24);
            editorCheckBoxVertical.TabIndex = 18;
            editorCheckBoxVertical.Text = "VERTICAL LINES";
            editorCheckBoxVertical.UseVisualStyleBackColor = true;
            editorCheckBoxVertical.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxHorizontal
            // 
            editorCheckBoxHorizontal.AutoSize = true;
            editorCheckBoxHorizontal.Location = new Point(120, 53);
            editorCheckBoxHorizontal.Name = "editorCheckBoxHorizontal";
            editorCheckBoxHorizontal.Size = new Size(160, 24);
            editorCheckBoxHorizontal.TabIndex = 17;
            editorCheckBoxHorizontal.Text = "HORIZONTAL LINES";
            editorCheckBoxHorizontal.UseVisualStyleBackColor = true;
            editorCheckBoxHorizontal.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxWhite
            // 
            editorCheckBoxWhite.AutoSize = true;
            editorCheckBoxWhite.BackColor = Color.Gainsboro;
            editorCheckBoxWhite.Location = new Point(580, 10);
            editorCheckBoxWhite.Name = "editorCheckBoxWhite";
            editorCheckBoxWhite.Size = new Size(73, 24);
            editorCheckBoxWhite.TabIndex = 16;
            editorCheckBoxWhite.Text = "WHITE";
            editorCheckBoxWhite.UseVisualStyleBackColor = false;
            editorCheckBoxWhite.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorButtonLoad
            // 
            editorButtonLoad.Location = new Point(771, 40);
            editorButtonLoad.Name = "editorButtonLoad";
            editorButtonLoad.Size = new Size(163, 27);
            editorButtonLoad.TabIndex = 15;
            editorButtonLoad.Text = "Load data...";
            editorButtonLoad.UseVisualStyleBackColor = true;
            editorButtonLoad.Click += OnEditorButtonLoadClick;
            // 
            // editorButtonSave
            // 
            editorButtonSave.Location = new Point(771, 7);
            editorButtonSave.Name = "editorButtonSave";
            editorButtonSave.Size = new Size(163, 27);
            editorButtonSave.TabIndex = 14;
            editorButtonSave.Text = "Save data...";
            editorButtonSave.UseVisualStyleBackColor = true;
            editorButtonSave.Click += OnEditorButtonSaveClick;
            // 
            // editorCheckBoxBlack
            // 
            editorCheckBoxBlack.AutoSize = true;
            editorCheckBoxBlack.BackColor = Color.DimGray;
            editorCheckBoxBlack.Location = new Point(502, 10);
            editorCheckBoxBlack.Name = "editorCheckBoxBlack";
            editorCheckBoxBlack.Size = new Size(72, 24);
            editorCheckBoxBlack.TabIndex = 13;
            editorCheckBoxBlack.Text = "BLACK";
            editorCheckBoxBlack.UseVisualStyleBackColor = false;
            editorCheckBoxBlack.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxPicture
            // 
            editorCheckBoxPicture.AutoSize = true;
            editorCheckBoxPicture.Location = new Point(659, 10);
            editorCheckBoxPicture.Name = "editorCheckBoxPicture";
            editorCheckBoxPicture.Size = new Size(84, 24);
            editorCheckBoxPicture.TabIndex = 12;
            editorCheckBoxPicture.Text = "PICTURE";
            editorCheckBoxPicture.UseVisualStyleBackColor = true;
            editorCheckBoxPicture.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 11;
            label2.Text = "Name country";
            // 
            // editorCheckBoxPurple
            // 
            editorCheckBoxPurple.AutoSize = true;
            editorCheckBoxPurple.BackColor = Color.MediumOrchid;
            editorCheckBoxPurple.Location = new Point(418, 10);
            editorCheckBoxPurple.Name = "editorCheckBoxPurple";
            editorCheckBoxPurple.Size = new Size(78, 24);
            editorCheckBoxPurple.TabIndex = 10;
            editorCheckBoxPurple.Text = "PURPLE";
            editorCheckBoxPurple.UseVisualStyleBackColor = false;
            editorCheckBoxPurple.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxBlue
            // 
            editorCheckBoxBlue.AutoSize = true;
            editorCheckBoxBlue.BackColor = Color.DodgerBlue;
            editorCheckBoxBlue.Location = new Point(350, 10);
            editorCheckBoxBlue.Name = "editorCheckBoxBlue";
            editorCheckBoxBlue.Size = new Size(62, 24);
            editorCheckBoxBlue.TabIndex = 9;
            editorCheckBoxBlue.Text = "BLUE";
            editorCheckBoxBlue.UseVisualStyleBackColor = false;
            editorCheckBoxBlue.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxGreen
            // 
            editorCheckBoxGreen.AutoSize = true;
            editorCheckBoxGreen.BackColor = Color.LimeGreen;
            editorCheckBoxGreen.Location = new Point(270, 10);
            editorCheckBoxGreen.Name = "editorCheckBoxGreen";
            editorCheckBoxGreen.Size = new Size(74, 24);
            editorCheckBoxGreen.TabIndex = 8;
            editorCheckBoxGreen.Text = "GREEN";
            editorCheckBoxGreen.UseVisualStyleBackColor = false;
            editorCheckBoxGreen.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxYellow
            // 
            editorCheckBoxYellow.AutoSize = true;
            editorCheckBoxYellow.BackColor = Color.Yellow;
            editorCheckBoxYellow.ForeColor = SystemColors.ControlText;
            editorCheckBoxYellow.Location = new Point(182, 10);
            editorCheckBoxYellow.Name = "editorCheckBoxYellow";
            editorCheckBoxYellow.Size = new Size(82, 24);
            editorCheckBoxYellow.TabIndex = 7;
            editorCheckBoxYellow.Text = "YELLOW";
            editorCheckBoxYellow.UseVisualStyleBackColor = false;
            editorCheckBoxYellow.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // editorCheckBoxRed
            // 
            editorCheckBoxRed.AutoSize = true;
            editorCheckBoxRed.BackColor = Color.Red;
            editorCheckBoxRed.Location = new Point(120, 10);
            editorCheckBoxRed.Name = "editorCheckBoxRed";
            editorCheckBoxRed.Size = new Size(56, 24);
            editorCheckBoxRed.TabIndex = 5;
            editorCheckBoxRed.Text = "RED";
            editorCheckBoxRed.UseVisualStyleBackColor = false;
            editorCheckBoxRed.CheckedChanged += OnEditorCheckBoxCheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 4;
            label1.Text = "Assign colors";
            // 
            // editorTextBoxCountry
            // 
            editorTextBoxCountry.Location = new Point(120, 128);
            editorTextBoxCountry.Name = "editorTextBoxCountry";
            editorTextBoxCountry.Size = new Size(144, 26);
            editorTextBoxCountry.TabIndex = 1;
            editorTextBoxCountry.TextChanged += OnEditorEditorTextBoxCountryEditorTextChanged;
            // 
            // editorButtonRename
            // 
            editorButtonRename.Location = new Point(270, 127);
            editorButtonRename.Name = "editorButtonRename";
            editorButtonRename.Size = new Size(142, 27);
            editorButtonRename.TabIndex = 0;
            editorButtonRename.Text = "Rename";
            editorButtonRename.UseVisualStyleBackColor = true;
            editorButtonRename.Click += OnEditorEditorButtonRenameClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 570);
            Controls.Add(tabControl1);
            Controls.Add(flagsListView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlagColors by kaydol v1.02";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView flagsListView;
        private ImageList imageList1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button editorButtonRename;
        private TextBox editorTextBoxCountry;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private CheckBox editorCheckBoxRed;
        private CheckBox editorCheckBoxYellow;
        private CheckBox editorCheckBoxPurple;
        private CheckBox editorCheckBoxBlue;
        private CheckBox editorCheckBoxGreen;
        private CheckBox editorCheckBoxPicture;
        private Label label2;
        private CheckBox editorCheckBoxBlack;
        private Button editorButtonSave;
        private Button editorButtonLoad;
        private CheckBox editorCheckBoxWhite;
        private CheckBox filterCheckBoxBlack;
        private CheckBox filterCheckBoxBlue;
        private CheckBox filterCheckBoxGreen;
        private CheckBox filterCheckBoxYellow;
        private CheckBox filterCheckBoxRed;
        private CheckBox filterCheckBoxPicture;
        private CheckBox filterCheckBoxWhite;
        private Label label3;
        private Label label4;
        private TextBox filterTextBoxName;
        private Button filterButtonResetName;
        private CheckBox filterCheckBoxPurple;
        private CheckBox filterCheckBoxExactMatch;
        private Label label5;
        private CheckBox filterCheckBoxCrosses;
        private CheckBox filterCheckBoxMoon;
        private CheckBox filterCheckBoxDiagonal;
        private CheckBox filterCheckBoxVertical;
        private CheckBox filterCheckBoxHorizontal;
        private CheckBox filterCheckBoxWriting;
        private CheckBox filterCheckBoxTriangles;
        private GroupBox groupBox1;
        private Button filterButtonResetShapes;
        private GroupBox groupBox2;
        private CheckBox editorCheckBoxTriangles;
        private CheckBox editorCheckBoxCrosses;
        private CheckBox editorCheckBoxDiagonal;
        private CheckBox editorCheckBoxVertical;
        private CheckBox editorCheckBoxHorizontal;
        private Label label6;
        private CheckBox editorCheckBoxWriting;
        private CheckBox editorCheckBoxMoon;
    }
}