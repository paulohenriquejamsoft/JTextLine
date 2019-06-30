namespace JTextLine
{
    partial class JTextLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JTextLine));
            this.txtTexto = new MetroFramework.Controls.MetroTextBox();
            this.btnExecutar = new MetroFramework.Controls.MetroButton();
            this.btnCopiarTexto = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            // 
            // 
            // 
            this.txtTexto.CustomButton.Image = null;
            this.txtTexto.CustomButton.Location = new System.Drawing.Point(423, 1);
            this.txtTexto.CustomButton.Name = "";
            this.txtTexto.CustomButton.Size = new System.Drawing.Size(329, 329);
            this.txtTexto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTexto.CustomButton.TabIndex = 1;
            this.txtTexto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTexto.CustomButton.UseSelectable = true;
            this.txtTexto.CustomButton.Visible = false;
            this.txtTexto.Lines = new string[0];
            this.txtTexto.Location = new System.Drawing.Point(24, 60);
            this.txtTexto.MaxLength = 32767;
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.PasswordChar = '\0';
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTexto.SelectedText = "";
            this.txtTexto.SelectionLength = 0;
            this.txtTexto.SelectionStart = 0;
            this.txtTexto.ShortcutsEnabled = true;
            this.txtTexto.Size = new System.Drawing.Size(753, 331);
            this.txtTexto.Style = MetroFramework.MetroColorStyle.Black;
            this.txtTexto.TabIndex = 0;
            this.txtTexto.UseSelectable = true;
            this.txtTexto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTexto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnExecutar
            // 
            this.btnExecutar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExecutar.Location = new System.Drawing.Point(252, 397);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(145, 37);
            this.btnExecutar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseSelectable = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnCopiarTexto
            // 
            this.btnCopiarTexto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCopiarTexto.Location = new System.Drawing.Point(403, 397);
            this.btnCopiarTexto.Name = "btnCopiarTexto";
            this.btnCopiarTexto.Size = new System.Drawing.Size(145, 37);
            this.btnCopiarTexto.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCopiarTexto.TabIndex = 2;
            this.btnCopiarTexto.Text = "Copiar";
            this.btnCopiarTexto.UseSelectable = true;
            this.btnCopiarTexto.Click += new System.EventHandler(this.btnCopiarTexto_Click);
            // 
            // JTextLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopiarTexto);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JTextLine";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Jamsoft Text Line";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTexto;
        private MetroFramework.Controls.MetroButton btnExecutar;
        private MetroFramework.Controls.MetroButton btnCopiarTexto;
    }
}

