namespace SoapboxLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleBar = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.serversLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.executablesLabel = new System.Windows.Forms.Label();
            this.executableComboBox = new SoapboxLauncher.Extensions.FlatCombo();
            this.serverComboBox = new SoapboxLauncher.Extensions.FlatCombo();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.titleBar.Controls.Add(this.minButton);
            this.titleBar.Controls.Add(this.closeButton);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(280, 26);
            this.titleBar.TabIndex = 0;
            this.titleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.titleBar_Paint);
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.Transparent;
            this.minButton.Location = new System.Drawing.Point(230, 1);
            this.minButton.Margin = new System.Windows.Forms.Padding(0);
            this.minButton.Name = "minButton";
            this.minButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.minButton.Size = new System.Drawing.Size(24, 24);
            this.minButton.TabIndex = 8;
            this.minButton.Text = "_";
            this.minButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.minButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.minButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(255, 1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.UseCompatibleTextRendering = true;
            this.closeButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.closeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // serversLabel
            // 
            this.serversLabel.AutoSize = true;
            this.serversLabel.Location = new System.Drawing.Point(11, 41);
            this.serversLabel.Name = "serversLabel";
            this.serversLabel.Size = new System.Drawing.Size(44, 13);
            this.serversLabel.TabIndex = 0;
            this.serversLabel.Text = "Server: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(11, 91);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-Mail: ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(14, 108);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 22);
            this.emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(14, 158);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(250, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password: ";
            // 
            // executablesLabel
            // 
            this.executablesLabel.AutoSize = true;
            this.executablesLabel.Location = new System.Drawing.Point(11, 191);
            this.executablesLabel.Name = "executablesLabel";
            this.executablesLabel.Size = new System.Drawing.Size(43, 13);
            this.executablesLabel.TabIndex = 7;
            this.executablesLabel.Text = "Client: ";
            // 
            // executableComboBox
            // 
            this.executableComboBox.BackColor = System.Drawing.Color.Black;
            this.executableComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.executableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.executableComboBox.FormattingEnabled = true;
            this.executableComboBox.Location = new System.Drawing.Point(14, 208);
            this.executableComboBox.Name = "executableComboBox";
            this.executableComboBox.Size = new System.Drawing.Size(250, 23);
            this.executableComboBox.TabIndex = 4;
            // 
            // serverComboBox
            // 
            this.serverComboBox.BackColor = System.Drawing.Color.Black;
            this.serverComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.serverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Location = new System.Drawing.Point(14, 58);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(250, 23);
            this.serverComboBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(280, 280);
            this.ControlBox = false;
            this.Controls.Add(this.executableComboBox);
            this.Controls.Add(this.executablesLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.serverComboBox);
            this.Controls.Add(this.serversLabel);
            this.Controls.Add(this.titleBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soapbox Launcher";
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label minButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label serversLabel;
        private Extensions.FlatCombo serverComboBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private Extensions.FlatCombo executableComboBox;
        private System.Windows.Forms.Label executablesLabel;
    }
}

