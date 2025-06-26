namespace RTLVuln
{
    partial class MainForm
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
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.openTool = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsJsonFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsCSVFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsSQLServerDBFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsExcelxlsxFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSystemVerilog = new System.Windows.Forms.CheckBox();
            this.btnSyntaxCheck = new System.Windows.Forms.Button();
            this.btnBugAdder = new System.Windows.Forms.Button();
            this.btnCopyVulnerablePrompt = new System.Windows.Forms.Button();
            this.chkIsTestEnvironment = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCopyCategorizePrompt = new System.Windows.Forms.Button();
            this.btnCopyPrompt = new System.Windows.Forms.Button();
            this.btnCopyVulnerableResponse = new System.Windows.Forms.Button();
            this.btnCopyResponse = new System.Windows.Forms.Button();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.chkFunctionality = new System.Windows.Forms.CheckBox();
            this.chkSyntax = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbVulnerableResponse = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbVulnerableInstruction = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnDeepSeek = new System.Windows.Forms.Button();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.rtbInstruction = new System.Windows.Forms.RichTextBox();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDs = new System.Windows.Forms.Label();
            this.treeViewJson = new System.Windows.Forms.TreeView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkDeepSeek = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.menuFile.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.White;
            this.menuFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTool,
            this.editToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuFile.Size = new System.Drawing.Size(1802, 28);
            this.menuFile.TabIndex = 1;
            this.menuFile.Text = "Open";
            // 
            // openTool
            // 
            this.openTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.openTool.Name = "openTool";
            this.openTool.Size = new System.Drawing.Size(46, 24);
            this.openTool.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsJsonFileToolStripMenuItem,
            this.saveAsCSVFileToolStripMenuItem,
            this.saveAsSQLServerDBFIleToolStripMenuItem,
            this.saveAsExcelxlsxFileToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsJsonFileToolStripMenuItem
            // 
            this.saveAsJsonFileToolStripMenuItem.Name = "saveAsJsonFileToolStripMenuItem";
            this.saveAsJsonFileToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.saveAsJsonFileToolStripMenuItem.Text = "Save As Json (.json) File";
            this.saveAsJsonFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsJsonFileToolStripMenuItem_Click);
            // 
            // saveAsCSVFileToolStripMenuItem
            // 
            this.saveAsCSVFileToolStripMenuItem.Name = "saveAsCSVFileToolStripMenuItem";
            this.saveAsCSVFileToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.saveAsCSVFileToolStripMenuItem.Text = "Save As CSV (.csv) File";
            // 
            // saveAsSQLServerDBFIleToolStripMenuItem
            // 
            this.saveAsSQLServerDBFIleToolStripMenuItem.Name = "saveAsSQLServerDBFIleToolStripMenuItem";
            this.saveAsSQLServerDBFIleToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.saveAsSQLServerDBFIleToolStripMenuItem.Text = "Save As SQL Server DB (.mdf) FIle";
            this.saveAsSQLServerDBFIleToolStripMenuItem.Click += new System.EventHandler(this.saveAsSQLServerDBFIleToolStripMenuItem_Click);
            // 
            // saveAsExcelxlsxFileToolStripMenuItem
            // 
            this.saveAsExcelxlsxFileToolStripMenuItem.Name = "saveAsExcelxlsxFileToolStripMenuItem";
            this.saveAsExcelxlsxFileToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.saveAsExcelxlsxFileToolStripMenuItem.Text = "Save As Excel (.xlsx) File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.addColumnToolStripMenuItem.Text = "Add Column";
            this.addColumnToolStripMenuItem.Click += new System.EventHandler(this.addColumnToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblWait);
            this.panelMain.Controls.Add(this.groupBox2);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.btnBugAdder);
            this.panelMain.Controls.Add(this.btnCopyVulnerablePrompt);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.btnCopyCategorizePrompt);
            this.panelMain.Controls.Add(this.btnCopyPrompt);
            this.panelMain.Controls.Add(this.btnCopyVulnerableResponse);
            this.panelMain.Controls.Add(this.btnCopyResponse);
            this.panelMain.Controls.Add(this.tbCategory);
            this.panelMain.Controls.Add(this.chkFunctionality);
            this.panelMain.Controls.Add(this.chkSyntax);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.rtbReason);
            this.panelMain.Controls.Add(this.lblCategory);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.rtbVulnerableResponse);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.rtbVulnerableInstruction);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.lblTotalRecords);
            this.panelMain.Controls.Add(this.btnAddNode);
            this.panelMain.Controls.Add(this.btnCompare);
            this.panelMain.Controls.Add(this.btnDeepSeek);
            this.panelMain.Controls.Add(this.rtbResponse);
            this.panelMain.Controls.Add(this.rtbInstruction);
            this.panelMain.Controls.Add(this.btnCollapse);
            this.panelMain.Controls.Add(this.btnExpand);
            this.panelMain.Controls.Add(this.progressBar1);
            this.panelMain.Controls.Add(this.lblDs);
            this.panelMain.Controls.Add(this.treeViewJson);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 28);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1802, 791);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSystemVerilog);
            this.groupBox1.Controls.Add(this.btnSyntaxCheck);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1446, 597);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 120);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iverilog check";
            // 
            // chkSystemVerilog
            // 
            this.chkSystemVerilog.AutoSize = true;
            this.chkSystemVerilog.Checked = true;
            this.chkSystemVerilog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSystemVerilog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSystemVerilog.Location = new System.Drawing.Point(7, 40);
            this.chkSystemVerilog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSystemVerilog.Name = "chkSystemVerilog";
            this.chkSystemVerilog.Size = new System.Drawing.Size(251, 22);
            this.chkSystemVerilog.TabIndex = 31;
            this.chkSystemVerilog.Text = "To enable SystemVerilog features";
            this.chkSystemVerilog.UseVisualStyleBackColor = true;
            // 
            // btnSyntaxCheck
            // 
            this.btnSyntaxCheck.BackColor = System.Drawing.Color.DimGray;
            this.btnSyntaxCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyntaxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyntaxCheck.ForeColor = System.Drawing.Color.White;
            this.btnSyntaxCheck.Location = new System.Drawing.Point(7, 68);
            this.btnSyntaxCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSyntaxCheck.Name = "btnSyntaxCheck";
            this.btnSyntaxCheck.Size = new System.Drawing.Size(154, 40);
            this.btnSyntaxCheck.TabIndex = 29;
            this.btnSyntaxCheck.TabStop = false;
            this.btnSyntaxCheck.Text = "Check Syntax";
            this.btnSyntaxCheck.UseVisualStyleBackColor = false;
            this.btnSyntaxCheck.Click += new System.EventHandler(this.btnSyntaxCheck_Click);
            // 
            // btnBugAdder
            // 
            this.btnBugAdder.BackColor = System.Drawing.Color.DimGray;
            this.btnBugAdder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBugAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBugAdder.ForeColor = System.Drawing.Color.White;
            this.btnBugAdder.Location = new System.Drawing.Point(994, 726);
            this.btnBugAdder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBugAdder.Name = "btnBugAdder";
            this.btnBugAdder.Size = new System.Drawing.Size(74, 40);
            this.btnBugAdder.TabIndex = 28;
            this.btnBugAdder.Text = "Bug";
            this.btnBugAdder.UseVisualStyleBackColor = false;
            this.btnBugAdder.Visible = false;
            this.btnBugAdder.Click += new System.EventHandler(this.btnBugAdder_Click);
            // 
            // btnCopyVulnerablePrompt
            // 
            this.btnCopyVulnerablePrompt.BackColor = System.Drawing.Color.DimGray;
            this.btnCopyVulnerablePrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyVulnerablePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyVulnerablePrompt.ForeColor = System.Drawing.Color.White;
            this.btnCopyVulnerablePrompt.Location = new System.Drawing.Point(181, 328);
            this.btnCopyVulnerablePrompt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyVulnerablePrompt.Name = "btnCopyVulnerablePrompt";
            this.btnCopyVulnerablePrompt.Size = new System.Drawing.Size(295, 40);
            this.btnCopyVulnerablePrompt.TabIndex = 27;
            this.btnCopyVulnerablePrompt.TabStop = false;
            this.btnCopyVulnerablePrompt.Text = "Copy Vulnerable Prompt";
            this.btnCopyVulnerablePrompt.UseVisualStyleBackColor = false;
            this.btnCopyVulnerablePrompt.Visible = false;
            this.btnCopyVulnerablePrompt.Click += new System.EventHandler(this.btnCopyVulnerablePrompt_Click);
            // 
            // chkIsTestEnvironment
            // 
            this.chkIsTestEnvironment.AutoSize = true;
            this.chkIsTestEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsTestEnvironment.Location = new System.Drawing.Point(29, 48);
            this.chkIsTestEnvironment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIsTestEnvironment.Name = "chkIsTestEnvironment";
            this.chkIsTestEnvironment.Size = new System.Drawing.Size(180, 24);
            this.chkIsTestEnvironment.TabIndex = 26;
            this.chkIsTestEnvironment.Text = "Is Test Environment";
            this.chkIsTestEnvironment.UseVisualStyleBackColor = true;
            this.chkIsTestEnvironment.CheckedChanged += new System.EventHandler(this.chkIsTestEnvironment_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1802, 57);
            this.panel1.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(332, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(774, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Security of LLMs against Backdoor Attacks Dataset Generation";
            // 
            // btnCopyCategorizePrompt
            // 
            this.btnCopyCategorizePrompt.BackColor = System.Drawing.Color.DimGray;
            this.btnCopyCategorizePrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyCategorizePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyCategorizePrompt.ForeColor = System.Drawing.Color.White;
            this.btnCopyCategorizePrompt.Location = new System.Drawing.Point(1120, 452);
            this.btnCopyCategorizePrompt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyCategorizePrompt.Name = "btnCopyCategorizePrompt";
            this.btnCopyCategorizePrompt.Size = new System.Drawing.Size(303, 66);
            this.btnCopyCategorizePrompt.TabIndex = 8;
            this.btnCopyCategorizePrompt.Text = "Copy Categorize Prompt";
            this.btnCopyCategorizePrompt.UseVisualStyleBackColor = false;
            this.btnCopyCategorizePrompt.Visible = false;
            this.btnCopyCategorizePrompt.Click += new System.EventHandler(this.btnCopyCategorizePrompt_Click);
            // 
            // btnCopyPrompt
            // 
            this.btnCopyPrompt.BackColor = System.Drawing.Color.DimGray;
            this.btnCopyPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPrompt.ForeColor = System.Drawing.Color.White;
            this.btnCopyPrompt.Location = new System.Drawing.Point(1120, 374);
            this.btnCopyPrompt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyPrompt.Name = "btnCopyPrompt";
            this.btnCopyPrompt.Size = new System.Drawing.Size(303, 73);
            this.btnCopyPrompt.TabIndex = 7;
            this.btnCopyPrompt.Text = "Copy Prompt";
            this.btnCopyPrompt.UseVisualStyleBackColor = false;
            this.btnCopyPrompt.Visible = false;
            this.btnCopyPrompt.Click += new System.EventHandler(this.btnCopyPrompt_Click);
            // 
            // btnCopyVulnerableResponse
            // 
            this.btnCopyVulnerableResponse.BackColor = System.Drawing.Color.DimGray;
            this.btnCopyVulnerableResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyVulnerableResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyVulnerableResponse.ForeColor = System.Drawing.Color.White;
            this.btnCopyVulnerableResponse.Location = new System.Drawing.Point(688, 527);
            this.btnCopyVulnerableResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyVulnerableResponse.Name = "btnCopyVulnerableResponse";
            this.btnCopyVulnerableResponse.Size = new System.Drawing.Size(271, 40);
            this.btnCopyVulnerableResponse.TabIndex = 24;
            this.btnCopyVulnerableResponse.TabStop = false;
            this.btnCopyVulnerableResponse.Text = "Copy Vulnerable Response";
            this.btnCopyVulnerableResponse.UseVisualStyleBackColor = false;
            this.btnCopyVulnerableResponse.Visible = false;
            this.btnCopyVulnerableResponse.Click += new System.EventHandler(this.btnCopyVulnerableResponse_Click);
            // 
            // btnCopyResponse
            // 
            this.btnCopyResponse.BackColor = System.Drawing.Color.DimGray;
            this.btnCopyResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyResponse.ForeColor = System.Drawing.Color.White;
            this.btnCopyResponse.Location = new System.Drawing.Point(756, 330);
            this.btnCopyResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyResponse.Name = "btnCopyResponse";
            this.btnCopyResponse.Size = new System.Drawing.Size(203, 40);
            this.btnCopyResponse.TabIndex = 23;
            this.btnCopyResponse.TabStop = false;
            this.btnCopyResponse.Text = "Copy Response";
            this.btnCopyResponse.UseVisualStyleBackColor = false;
            this.btnCopyResponse.Visible = false;
            this.btnCopyResponse.Click += new System.EventHandler(this.btnCopyResponse_Click);
            // 
            // tbCategory
            // 
            this.tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategory.Location = new System.Drawing.Point(169, 721);
            this.tbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(791, 30);
            this.tbCategory.TabIndex = 6;
            this.tbCategory.Tag = "Please fill category";
            this.tbCategory.Visible = false;
            // 
            // chkFunctionality
            // 
            this.chkFunctionality.AutoSize = true;
            this.chkFunctionality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFunctionality.Location = new System.Drawing.Point(1117, 721);
            this.chkFunctionality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFunctionality.Name = "chkFunctionality";
            this.chkFunctionality.Size = new System.Drawing.Size(156, 29);
            this.chkFunctionality.TabIndex = 15;
            this.chkFunctionality.TabStop = false;
            this.chkFunctionality.Text = "Functionality";
            this.chkFunctionality.UseVisualStyleBackColor = true;
            this.chkFunctionality.Visible = false;
            // 
            // chkSyntax
            // 
            this.chkSyntax.AutoSize = true;
            this.chkSyntax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSyntax.Location = new System.Drawing.Point(1317, 721);
            this.chkSyntax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSyntax.Name = "chkSyntax";
            this.chkSyntax.Size = new System.Drawing.Size(101, 29);
            this.chkSyntax.TabIndex = 6;
            this.chkSyntax.TabStop = false;
            this.chkSyntax.Text = "Syntax";
            this.chkSyntax.UseVisualStyleBackColor = true;
            this.chkSyntax.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(979, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Reason";
            // 
            // rtbReason
            // 
            this.rtbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReason.Location = new System.Drawing.Point(983, 572);
            this.rtbReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(437, 145);
            this.rtbReason.TabIndex = 5;
            this.rtbReason.Tag = "Please fill Reason";
            this.rtbReason.Text = "";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(58, 726);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 25);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vuln. Response";
            // 
            // rtbVulnerableResponse
            // 
            this.rtbVulnerableResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVulnerableResponse.Location = new System.Drawing.Point(523, 572);
            this.rtbVulnerableResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbVulnerableResponse.Name = "rtbVulnerableResponse";
            this.rtbVulnerableResponse.Size = new System.Drawing.Size(437, 145);
            this.rtbVulnerableResponse.TabIndex = 4;
            this.rtbVulnerableResponse.Tag = "Please fill Vulnerable Response";
            this.rtbVulnerableResponse.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vulnerable Instruction";
            // 
            // rtbVulnerableInstruction
            // 
            this.rtbVulnerableInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVulnerableInstruction.Location = new System.Drawing.Point(57, 572);
            this.rtbVulnerableInstruction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbVulnerableInstruction.Name = "rtbVulnerableInstruction";
            this.rtbVulnerableInstruction.Size = new System.Drawing.Size(437, 145);
            this.rtbVulnerableInstruction.TabIndex = 3;
            this.rtbVulnerableInstruction.Tag = "Please fill Vulnerable Instruction";
            this.rtbVulnerableInstruction.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Response";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Instruction";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(1222, 66);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(0, 25);
            this.lblTotalRecords.TabIndex = 11;
            // 
            // btnAddNode
            // 
            this.btnAddNode.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNode.ForeColor = System.Drawing.Color.White;
            this.btnAddNode.Location = new System.Drawing.Point(1439, 97);
            this.btnAddNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(174, 40);
            this.btnAddNode.TabIndex = 10;
            this.btnAddNode.Text = "Add/Edit Node";
            this.btnAddNode.UseVisualStyleBackColor = false;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            this.btnAddNode.MouseHover += new System.EventHandler(this.btnAddNode_MouseHover);
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.DimGray;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.ForeColor = System.Drawing.Color.White;
            this.btnCompare.Location = new System.Drawing.Point(966, 374);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(148, 144);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnDeepSeek
            // 
            this.btnDeepSeek.BackColor = System.Drawing.Color.DimGray;
            this.btnDeepSeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeepSeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeepSeek.ForeColor = System.Drawing.Color.White;
            this.btnDeepSeek.Location = new System.Drawing.Point(1439, 164);
            this.btnDeepSeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeepSeek.Name = "btnDeepSeek";
            this.btnDeepSeek.Size = new System.Drawing.Size(174, 40);
            this.btnDeepSeek.TabIndex = 11;
            this.btnDeepSeek.Text = "Deepseek Api";
            this.btnDeepSeek.UseVisualStyleBackColor = false;
            this.btnDeepSeek.Click += new System.EventHandler(this.btnDeepSeek_Click);
            // 
            // rtbResponse
            // 
            this.rtbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResponse.Location = new System.Drawing.Point(523, 374);
            this.rtbResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(437, 145);
            this.rtbResponse.TabIndex = 2;
            this.rtbResponse.Tag = "Please fill Response";
            this.rtbResponse.Text = "";
            // 
            // rtbInstruction
            // 
            this.rtbInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstruction.Location = new System.Drawing.Point(57, 374);
            this.rtbInstruction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbInstruction.Name = "rtbInstruction";
            this.rtbInstruction.Size = new System.Drawing.Size(431, 145);
            this.rtbInstruction.TabIndex = 1;
            this.rtbInstruction.Tag = "Please fill Instruction";
            this.rtbInstruction.Text = "";
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.DimGray;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Location = new System.Drawing.Point(371, 62);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(67, 32);
            this.btnCollapse.TabIndex = 13;
            this.btnCollapse.TabStop = false;
            this.btnCollapse.Text = "-";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.DimGray;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.White;
            this.btnExpand.Location = new System.Drawing.Point(299, 62);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(67, 32);
            this.btnExpand.TabIndex = 12;
            this.btnExpand.TabStop = false;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 316);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1362, 8);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // lblDs
            // 
            this.lblDs.AutoSize = true;
            this.lblDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDs.Location = new System.Drawing.Point(64, 69);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(79, 25);
            this.lblDs.TabIndex = 1;
            this.lblDs.Text = "Dataset";
            // 
            // treeViewJson
            // 
            this.treeViewJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewJson.ItemHeight = 28;
            this.treeViewJson.Location = new System.Drawing.Point(57, 97);
            this.treeViewJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewJson.Name = "treeViewJson";
            this.treeViewJson.Size = new System.Drawing.Size(1363, 215);
            this.treeViewJson.TabIndex = 14;
            this.treeViewJson.TabStop = false;
            this.treeViewJson.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewJson_AfterSelect);
            // 
            // chkDeepSeek
            // 
            this.chkDeepSeek.AutoSize = true;
            this.chkDeepSeek.Checked = true;
            this.chkDeepSeek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeepSeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeepSeek.Location = new System.Drawing.Point(29, 76);
            this.chkDeepSeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDeepSeek.Name = "chkDeepSeek";
            this.chkDeepSeek.Size = new System.Drawing.Size(174, 24);
            this.chkDeepSeek.TabIndex = 31;
            this.chkDeepSeek.Text = "Is DeepSeek Cloud";
            this.chkDeepSeek.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkIsTestEnvironment);
            this.groupBox2.Controls.Add(this.chkDeepSeek);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1446, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 168);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 38);
            this.label6.TabIndex = 33;
            this.label6.Text = "DeepSeek not checked means use API via LM Studio";
            // 
            // lblWait
            // 
            this.lblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.Location = new System.Drawing.Point(1441, 212);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(219, 45);
            this.lblWait.TabIndex = 33;
            this.lblWait.Text = "Please wait for a moment while processing your request...";
            this.lblWait.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 819);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuFile);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFile;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem openTool;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TreeView treeViewJson;
        private System.Windows.Forms.Label lblDs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.RichTextBox rtbInstruction;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Button btnDeepSeek;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.ToolStripMenuItem saveAsJsonFileToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbVulnerableInstruction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbVulnerableResponse;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.CheckBox chkFunctionality;
        private System.Windows.Forms.CheckBox chkSyntax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbReason;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnCopyResponse;
        private System.Windows.Forms.Button btnCopyVulnerableResponse;
        private System.Windows.Forms.Button btnCopyPrompt;
        private System.Windows.Forms.Button btnCopyCategorizePrompt;
        private System.Windows.Forms.ToolStripMenuItem saveAsCSVFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsSQLServerDBFIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsExcelxlsxFileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkIsTestEnvironment;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button btnCopyVulnerablePrompt;
        private System.Windows.Forms.Button btnBugAdder;
        private System.Windows.Forms.Button btnSyntaxCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSystemVerilog;
        private System.Windows.Forms.CheckBox chkDeepSeek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWait;
    }
}

