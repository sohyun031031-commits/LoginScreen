namespace LoginScreen
{
    partial class LoginScreen
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
            lblAppName = new TextBox();
            btnLogin = new Button();
            txtID = new TextBox();
            txtPW = new TextBox();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.BackColor = SystemColors.Control;
            lblAppName.BorderStyle = BorderStyle.None;
            lblAppName.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(122, 36);
            lblAppName.Name = "lblAppName";
            lblAppName.ReadOnly = true;
            lblAppName.Size = new Size(177, 86);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.TextChanged += textBox1_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 192, 255);
            btnLogin.Location = new Point(166, 347);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(83, 44);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(81, 172);
            txtID.Name = "txtID";
            txtID.Size = new Size(257, 39);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(81, 246);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(257, 39);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(btnLogin);
            Controls.Add(lblAppName);
            Name = "LoginScreen";
            Text = "Login Screen";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblAppName;
        private Button btnLogin;
        private TextBox txtID;
        private TextBox txtPW;
    }
}
