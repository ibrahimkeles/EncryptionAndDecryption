namespace EncryptionAndDecryption
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            txtEncryptDecryptedValue = new TextBox();
            txtValues = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnClear = new Button();
            chxChangeCopy = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Green;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(782, 52);
            label1.TabIndex = 0;
            label1.Text = "Data to be Encrypted/Decrypted";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Green;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 291);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(782, 52);
            label2.TabIndex = 1;
            label2.Text = "Encrypted/Decrypted Data";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(754, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(42, 36);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtEncryptDecryptedValue
            // 
            txtEncryptDecryptedValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncryptDecryptedValue.Location = new Point(14, 112);
            txtEncryptDecryptedValue.Multiline = true;
            txtEncryptDecryptedValue.Name = "txtEncryptDecryptedValue";
            txtEncryptDecryptedValue.Size = new Size(782, 176);
            txtEncryptDecryptedValue.TabIndex = 3;
            // 
            // txtValues
            // 
            txtValues.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValues.BackColor = SystemColors.Control;
            txtValues.Location = new Point(14, 346);
            txtValues.Multiline = true;
            txtValues.Name = "txtValues";
            txtValues.ReadOnly = true;
            txtValues.Size = new Size(782, 176);
            txtValues.TabIndex = 4;
            txtValues.TextChanged += txtValues_TextChanged;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEncrypt.Location = new Point(14, 529);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(247, 38);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecrypt.Location = new Point(283, 528);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(247, 38);
            btnDecrypt.TabIndex = 6;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(547, 528);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(249, 38);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // chxChangeCopy
            // 
            chxChangeCopy.AutoSize = true;
            chxChangeCopy.Checked = true;
            chxChangeCopy.CheckState = CheckState.Checked;
            chxChangeCopy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chxChangeCopy.Location = new Point(14, 19);
            chxChangeCopy.Name = "chxChangeCopy";
            chxChangeCopy.Size = new Size(128, 19);
            chxChangeCopy.TabIndex = 8;
            chxChangeCopy.Text = "Copy when change";
            chxChangeCopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 597);
            Controls.Add(chxChangeCopy);
            Controls.Add(btnClear);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtValues);
            Controls.Add(txtEncryptDecryptedValue);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnExit;
        private TextBox txtEncryptDecryptedValue;
        private TextBox txtValues;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnClear;
        private CheckBox chxChangeCopy;
    }
}