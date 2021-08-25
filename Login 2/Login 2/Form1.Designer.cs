
namespace Login_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ACCESS = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.PictureBox();
            this.Z = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 263);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.DimGray;
            this.ID.Location = new System.Drawing.Point(301, 103);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(381, 22);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            // 
            // PASSWORD
            // 
            this.PASSWORD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PASSWORD.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.ForeColor = System.Drawing.Color.DimGray;
            this.PASSWORD.Location = new System.Drawing.Point(301, 162);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(381, 22);
            this.PASSWORD.TabIndex = 2;
            this.PASSWORD.Text = "PASSWORD";
            this.PASSWORD.Enter += new System.EventHandler(this.PASSWORD_Enter);
            this.PASSWORD.Leave += new System.EventHandler(this.PASSWORD_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // ACCESS
            // 
            this.ACCESS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ACCESS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ACCESS.FlatAppearance.BorderSize = 0;
            this.ACCESS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ACCESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACCESS.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCESS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ACCESS.Location = new System.Drawing.Point(301, 217);
            this.ACCESS.Name = "ACCESS";
            this.ACCESS.Size = new System.Drawing.Size(381, 37);
            this.ACCESS.TabIndex = 4;
            this.ACCESS.Text = "ACCESS";
            this.ACCESS.UseVisualStyleBackColor = false;
            // 
            // X
            // 
            this.X.Image = ((System.Drawing.Image)(resources.GetObject("X.Image")));
            this.X.Location = new System.Drawing.Point(753, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(25, 22);
            this.X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X.TabIndex = 5;
            this.X.TabStop = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Z
            // 
            this.Z.Image = ((System.Drawing.Image)(resources.GetObject("Z.Image")));
            this.Z.Location = new System.Drawing.Point(712, 0);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(35, 22);
            this.Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Z.TabIndex = 6;
            this.Z.TabStop = false;
            this.Z.Click += new System.EventHandler(this.Z_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.X);
            this.Controls.Add(this.ACCESS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ACCESS;
        private System.Windows.Forms.PictureBox X;
        private System.Windows.Forms.PictureBox Z;
    }
}

