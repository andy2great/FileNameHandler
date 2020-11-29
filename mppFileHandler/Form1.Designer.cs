namespace mppFileHandler
{
    partial class formMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFilesSection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sperator1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.chkDateCreation = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrevisualisation = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFolder1 = new System.Windows.Forms.Label();
            this.chkCustomText = new System.Windows.Forms.CheckBox();
            this.txtCustomBox = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.excludedFiles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sperator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFilesSection
            // 
            this.labelFilesSection.AutoSize = true;
            this.labelFilesSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilesSection.Location = new System.Drawing.Point(12, 9);
            this.labelFilesSection.Name = "labelFilesSection";
            this.labelFilesSection.Size = new System.Drawing.Size(171, 29);
            this.labelFilesSection.TabIndex = 0;
            this.labelFilesSection.Text = "Folder Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // labelSeperator
            // 
            this.labelSeperator.AutoSize = true;
            this.labelSeperator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSeperator.Location = new System.Drawing.Point(169, 162);
            this.labelSeperator.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.labelSeperator.Name = "labelSeperator";
            this.labelSeperator.Size = new System.Drawing.Size(0, 13);
            this.labelSeperator.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Action";
            // 
            // sperator1
            // 
            this.sperator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sperator1.Location = new System.Drawing.Point(201, 7);
            this.sperator1.Name = "sperator1";
            this.sperator1.Size = new System.Drawing.Size(1, 353);
            this.sperator1.TabIndex = 7;
            this.sperator1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(428, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 351);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(17, 69);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(166, 23);
            this.buttonSelectFolder.TabIndex = 9;
            this.buttonSelectFolder.Text = "Folder 1";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Location = new System.Drawing.Point(14, 51);
            this.labelFolderName.MaximumSize = new System.Drawing.Size(171, 0);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(55, 13);
            this.labelFolderName.TabIndex = 10;
            this.labelFolderName.Text = "First folder";
            // 
            // chkDateCreation
            // 
            this.chkDateCreation.AutoSize = true;
            this.chkDateCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateCreation.Location = new System.Drawing.Point(231, 73);
            this.chkDateCreation.Name = "chkDateCreation";
            this.chkDateCreation.Size = new System.Drawing.Size(98, 17);
            this.chkDateCreation.TabIndex = 11;
            this.chkDateCreation.Text = "add taken date";
            this.chkDateCreation.UseVisualStyleBackColor = true;
            this.chkDateCreation.CheckedChanged += new System.EventHandler(this.chkDateCreation_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Previsualisation";
            // 
            // lblPrevisualisation
            // 
            this.lblPrevisualisation.AutoSize = true;
            this.lblPrevisualisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisualisation.Location = new System.Drawing.Point(9, 455);
            this.lblPrevisualisation.Name = "lblPrevisualisation";
            this.lblPrevisualisation.Size = new System.Drawing.Size(131, 13);
            this.lblPrevisualisation.TabIndex = 13;
            this.lblPrevisualisation.Text = "{orginal name}.{extension}";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(12, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 1);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Selected folders";
            // 
            // labelFolder1
            // 
            this.labelFolder1.AutoSize = true;
            this.labelFolder1.Location = new System.Drawing.Point(9, 384);
            this.labelFolder1.Name = "labelFolder1";
            this.labelFolder1.Size = new System.Drawing.Size(45, 13);
            this.labelFolder1.TabIndex = 16;
            this.labelFolder1.Text = "Folder 1";
            // 
            // chkCustomText
            // 
            this.chkCustomText.AutoSize = true;
            this.chkCustomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomText.Location = new System.Drawing.Point(231, 96);
            this.chkCustomText.Name = "chkCustomText";
            this.chkCustomText.Size = new System.Drawing.Size(101, 17);
            this.chkCustomText.TabIndex = 17;
            this.chkCustomText.Text = "add custom text";
            this.chkCustomText.UseVisualStyleBackColor = true;
            this.chkCustomText.CheckedChanged += new System.EventHandler(this.chkCustomText_CheckedChanged);
            // 
            // txtCustomBox
            // 
            this.txtCustomBox.Enabled = false;
            this.txtCustomBox.Location = new System.Drawing.Point(231, 120);
            this.txtCustomBox.Multiline = true;
            this.txtCustomBox.Name = "txtCustomBox";
            this.txtCustomBox.Size = new System.Drawing.Size(180, 20);
            this.txtCustomBox.TabIndex = 18;
            this.txtCustomBox.TextChanged += new System.EventHandler(this.txtCustomBox_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(446, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 33);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start rumble!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // loader
            // 
            this.loader.Location = new System.Drawing.Point(446, 108);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(155, 32);
            this.loader.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Targeted Files";
            // 
            // excludedFiles
            // 
            this.excludedFiles.Location = new System.Drawing.Point(16, 120);
            this.excludedFiles.Multiline = true;
            this.excludedFiles.Name = "excludedFiles";
            this.excludedFiles.Size = new System.Drawing.Size(166, 50);
            this.excludedFiles.TabIndex = 22;
            this.excludedFiles.Text = "JPG;PNG;GIF;";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 475);
            this.Controls.Add(this.excludedFiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCustomBox);
            this.Controls.Add(this.chkCustomText);
            this.Controls.Add(this.labelFolder1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPrevisualisation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkDateCreation);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sperator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSeperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilesSection);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.Text = "mppFolderHandler";
            ((System.ComponentModel.ISupportInitialize)(this.sperator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilesSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSeperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox sperator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.CheckBox chkDateCreation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrevisualisation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFolder1;
        private System.Windows.Forms.CheckBox chkCustomText;
        private System.Windows.Forms.TextBox txtCustomBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar loader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox excludedFiles;
    }
}

