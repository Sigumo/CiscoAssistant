namespace CiscoClientHelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsPages = new System.Windows.Forms.TabControl();
            this.assistantSettings = new System.Windows.Forms.TabPage();
            this.closeToTrayBox = new System.Windows.Forms.CheckBox();
            this.connectionSettings = new System.Windows.Forms.TabPage();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectDirectoryButton = new System.Windows.Forms.Button();
            this.anyConnectDirectoryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hostNameBox = new System.Windows.Forms.TextBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.settingsPages.SuspendLayout();
            this.assistantSettings.SuspendLayout();
            this.connectionSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPages
            // 
            this.settingsPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPages.Controls.Add(this.assistantSettings);
            this.settingsPages.Controls.Add(this.connectionSettings);
            this.settingsPages.Location = new System.Drawing.Point(12, 12);
            this.settingsPages.Name = "settingsPages";
            this.settingsPages.SelectedIndex = 0;
            this.settingsPages.Size = new System.Drawing.Size(776, 397);
            this.settingsPages.TabIndex = 0;
            // 
            // assistantSettings
            // 
            this.assistantSettings.Controls.Add(this.closeToTrayBox);
            this.assistantSettings.Location = new System.Drawing.Point(4, 24);
            this.assistantSettings.Name = "assistantSettings";
            this.assistantSettings.Padding = new System.Windows.Forms.Padding(3);
            this.assistantSettings.Size = new System.Drawing.Size(768, 369);
            this.assistantSettings.TabIndex = 0;
            this.assistantSettings.Text = "Настройки ассистента";
            this.assistantSettings.UseVisualStyleBackColor = true;
            // 
            // closeToTrayBox
            // 
            this.closeToTrayBox.AutoSize = true;
            this.closeToTrayBox.Location = new System.Drawing.Point(6, 6);
            this.closeToTrayBox.Name = "closeToTrayBox";
            this.closeToTrayBox.Size = new System.Drawing.Size(213, 19);
            this.closeToTrayBox.TabIndex = 0;
            this.closeToTrayBox.Text = "Сворачивать в трей при закрытии";
            this.closeToTrayBox.UseVisualStyleBackColor = true;
            this.closeToTrayBox.CheckedChanged += new System.EventHandler(this.CloseToTrayBox_CheckedChanged);
            // 
            // connectionSettings
            // 
            this.connectionSettings.Controls.Add(this.userNameBox);
            this.connectionSettings.Controls.Add(this.label3);
            this.connectionSettings.Controls.Add(this.selectDirectoryButton);
            this.connectionSettings.Controls.Add(this.anyConnectDirectoryBox);
            this.connectionSettings.Controls.Add(this.label2);
            this.connectionSettings.Controls.Add(this.label1);
            this.connectionSettings.Controls.Add(this.hostNameBox);
            this.connectionSettings.Location = new System.Drawing.Point(4, 24);
            this.connectionSettings.Name = "connectionSettings";
            this.connectionSettings.Padding = new System.Windows.Forms.Padding(3);
            this.connectionSettings.Size = new System.Drawing.Size(768, 369);
            this.connectionSettings.TabIndex = 1;
            this.connectionSettings.Text = "Настройки подключения";
            this.connectionSettings.UseVisualStyleBackColor = true;
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(248, 122);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(196, 23);
            this.userNameBox.TabIndex = 6;
            this.userNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя пользователя";
            // 
            // selectDirectoryButton
            // 
            this.selectDirectoryButton.Location = new System.Drawing.Point(531, 63);
            this.selectDirectoryButton.Name = "selectDirectoryButton";
            this.selectDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.selectDirectoryButton.TabIndex = 4;
            this.selectDirectoryButton.Text = "Обзор";
            this.selectDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // anyConnectDirectoryBox
            // 
            this.anyConnectDirectoryBox.Location = new System.Drawing.Point(248, 63);
            this.anyConnectDirectoryBox.Name = "anyConnectDirectoryBox";
            this.anyConnectDirectoryBox.ReadOnly = true;
            this.anyConnectDirectoryBox.Size = new System.Drawing.Size(277, 23);
            this.anyConnectDirectoryBox.TabIndex = 3;
            this.anyConnectDirectoryBox.TextChanged += new System.EventHandler(this.AnyConnectDirectoryBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Место установки Cisco Anyconnect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес сервера";
            // 
            // hostNameBox
            // 
            this.hostNameBox.Location = new System.Drawing.Point(248, 9);
            this.hostNameBox.Name = "hostNameBox";
            this.hostNameBox.Size = new System.Drawing.Size(196, 23);
            this.hostNameBox.TabIndex = 0;
            this.hostNameBox.TextChanged += new System.EventHandler(this.HostNameBox_TextChanged);
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsButton.Location = new System.Drawing.Point(628, 415);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 1;
            this.saveSettingsButton.Text = "Сохранить";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(709, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.settingsPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.settingsPages.ResumeLayout(false);
            this.assistantSettings.ResumeLayout(false);
            this.assistantSettings.PerformLayout();
            this.connectionSettings.ResumeLayout(false);
            this.connectionSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl settingsPages;
        private TabPage assistantSettings;
        private TabPage connectionSettings;
        private CheckBox closeToTrayBox;
        private Button saveSettingsButton;
        private Button cancelButton;
        private Label label1;
        private TextBox hostNameBox;
        private Button selectDirectoryButton;
        private TextBox anyConnectDirectoryBox;
        private Label label2;
        private TextBox userNameBox;
        private Label label3;
    }
}