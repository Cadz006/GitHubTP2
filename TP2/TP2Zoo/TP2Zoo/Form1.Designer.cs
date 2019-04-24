namespace TP2Zoo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Interface = new TP2Zoo.Map();
            this.PnlComm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlStat = new System.Windows.Forms.Panel();
            this.LblVisitStat = new System.Windows.Forms.Label();
            this.LblVisiteur = new System.Windows.Forms.Label();
            this.LblAnimStat = new System.Windows.Forms.Label();
            this.LblAnim = new System.Windows.Forms.Label();
            this.LblCashStat = new System.Windows.Forms.Label();
            this.LblMonnaie = new System.Windows.Forms.Label();
            this.LblStatDate = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.PicVisit = new System.Windows.Forms.PictureBox();
            this.PicAnim = new System.Windows.Forms.PictureBox();
            this.PicArgent = new System.Windows.Forms.PictureBox();
            this.PicDate = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlComm.SuspendLayout();
            this.PnlStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Interface
            // 
            this.Interface.Location = new System.Drawing.Point(63, 0);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(1600, 800);
            this.Interface.TabIndex = 0;
            this.Interface.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A);
            // 
            // PnlComm
            // 
            this.PnlComm.BackColor = System.Drawing.Color.Tan;
            this.PnlComm.Controls.Add(this.panel2);
            this.PnlComm.Controls.Add(this.pictureBox2);
            this.PnlComm.Controls.Add(this.pictureBox1);
            this.PnlComm.Location = new System.Drawing.Point(0, 0);
            this.PnlComm.Name = "PnlComm";
            this.PnlComm.Size = new System.Drawing.Size(64, 800);
            this.PnlComm.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 806);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 60);
            this.panel2.TabIndex = 2;
            // 
            // PnlStat
            // 
            this.PnlStat.BackColor = System.Drawing.Color.Tan;
            this.PnlStat.Controls.Add(this.LblVisitStat);
            this.PnlStat.Controls.Add(this.PicVisit);
            this.PnlStat.Controls.Add(this.PicAnim);
            this.PnlStat.Controls.Add(this.PicArgent);
            this.PnlStat.Controls.Add(this.PicDate);
            this.PnlStat.Controls.Add(this.LblVisiteur);
            this.PnlStat.Controls.Add(this.LblAnimStat);
            this.PnlStat.Controls.Add(this.LblAnim);
            this.PnlStat.Controls.Add(this.LblCashStat);
            this.PnlStat.Controls.Add(this.LblMonnaie);
            this.PnlStat.Controls.Add(this.LblStatDate);
            this.PnlStat.Controls.Add(this.LblDate);
            this.PnlStat.Location = new System.Drawing.Point(0, 800);
            this.PnlStat.Name = "PnlStat";
            this.PnlStat.Size = new System.Drawing.Size(1662, 60);
            this.PnlStat.TabIndex = 2;
            // 
            // LblVisitStat
            // 
            this.LblVisitStat.AutoSize = true;
            this.LblVisitStat.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisitStat.Location = new System.Drawing.Point(1632, 21);
            this.LblVisitStat.Name = "LblVisitStat";
            this.LblVisitStat.Size = new System.Drawing.Size(20, 23);
            this.LblVisitStat.TabIndex = 10;
            this.LblVisitStat.Text = "0";
            // 
            // LblVisiteur
            // 
            this.LblVisiteur.AutoSize = true;
            this.LblVisiteur.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisiteur.Location = new System.Drawing.Point(1347, 18);
            this.LblVisiteur.Name = "LblVisiteur";
            this.LblVisiteur.Size = new System.Drawing.Size(283, 26);
            this.LblVisiteur.TabIndex = 6;
            this.LblVisiteur.Text = "NOMBRE DE VISITEURS :";
            // 
            // LblAnimStat
            // 
            this.LblAnimStat.AutoSize = true;
            this.LblAnimStat.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnimStat.Location = new System.Drawing.Point(1161, 21);
            this.LblAnimStat.Name = "LblAnimStat";
            this.LblAnimStat.Size = new System.Drawing.Size(20, 23);
            this.LblAnimStat.TabIndex = 5;
            this.LblAnimStat.Text = "0";
            // 
            // LblAnim
            // 
            this.LblAnim.AutoSize = true;
            this.LblAnim.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnim.Location = new System.Drawing.Point(885, 18);
            this.LblAnim.Name = "LblAnim";
            this.LblAnim.Size = new System.Drawing.Size(270, 26);
            this.LblAnim.TabIndex = 4;
            this.LblAnim.Text = "NOMBRE D\'ANIMAUX :";
            // 
            // LblCashStat
            // 
            this.LblCashStat.AutoSize = true;
            this.LblCashStat.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCashStat.Location = new System.Drawing.Point(606, 21);
            this.LblCashStat.Name = "LblCashStat";
            this.LblCashStat.Size = new System.Drawing.Size(61, 23);
            this.LblCashStat.TabIndex = 3;
            this.LblCashStat.Text = "1000$";
            // 
            // LblMonnaie
            // 
            this.LblMonnaie.AutoSize = true;
            this.LblMonnaie.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonnaie.Location = new System.Drawing.Point(481, 18);
            this.LblMonnaie.Name = "LblMonnaie";
            this.LblMonnaie.Size = new System.Drawing.Size(119, 26);
            this.LblMonnaie.TabIndex = 2;
            this.LblMonnaie.Text = "ARGENT :";
            // 
            // LblStatDate
            // 
            this.LblStatDate.AutoSize = true;
            this.LblStatDate.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatDate.Location = new System.Drawing.Point(171, 21);
            this.LblStatDate.Name = "LblStatDate";
            this.LblStatDate.Size = new System.Drawing.Size(127, 23);
            this.LblStatDate.TabIndex = 1;
            this.LblStatDate.Text = "24 Avril 2019";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(73, 18);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(92, 26);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date : ";
            // 
            // PicVisit
            // 
            this.PicVisit.BackgroundImage = global::TP2Zoo.Properties.Resources.family;
            this.PicVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicVisit.Location = new System.Drawing.Point(1291, 6);
            this.PicVisit.Name = "PicVisit";
            this.PicVisit.Size = new System.Drawing.Size(50, 50);
            this.PicVisit.TabIndex = 9;
            this.PicVisit.TabStop = false;
            // 
            // PicAnim
            // 
            this.PicAnim.BackgroundImage = global::TP2Zoo.Properties.Resources.LabelAnim;
            this.PicAnim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicAnim.Location = new System.Drawing.Point(829, 6);
            this.PicAnim.Name = "PicAnim";
            this.PicAnim.Size = new System.Drawing.Size(50, 50);
            this.PicAnim.TabIndex = 8;
            this.PicAnim.TabStop = false;
            // 
            // PicArgent
            // 
            this.PicArgent.BackgroundImage = global::TP2Zoo.Properties.Resources.aiga_cashier;
            this.PicArgent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicArgent.Location = new System.Drawing.Point(425, 6);
            this.PicArgent.Name = "PicArgent";
            this.PicArgent.Size = new System.Drawing.Size(50, 50);
            this.PicArgent.TabIndex = 7;
            this.PicArgent.TabStop = false;
            // 
            // PicDate
            // 
            this.PicDate.BackgroundImage = global::TP2Zoo.Properties.Resources.time;
            this.PicDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicDate.Location = new System.Drawing.Point(17, 6);
            this.PicDate.Name = "PicDate";
            this.PicDate.Size = new System.Drawing.Size(50, 50);
            this.PicDate.TabIndex = 3;
            this.PicDate.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox2.BackgroundImage = global::TP2Zoo.Properties.Resources.Animal;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(7, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.BackgroundImage = global::TP2Zoo.Properties.Resources.Janitor;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 864);
            this.Controls.Add(this.PnlStat);
            this.Controls.Add(this.PnlComm);
            this.Controls.Add(this.Interface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Tycoon 32bit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlComm.ResumeLayout(false);
            this.PnlStat.ResumeLayout(false);
            this.PnlStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Map Interface;
        private System.Windows.Forms.Panel PnlComm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlStat;
        private System.Windows.Forms.Label LblVisitStat;
        private System.Windows.Forms.PictureBox PicVisit;
        private System.Windows.Forms.PictureBox PicAnim;
        private System.Windows.Forms.PictureBox PicArgent;
        private System.Windows.Forms.PictureBox PicDate;
        private System.Windows.Forms.Label LblVisiteur;
        private System.Windows.Forms.Label LblAnimStat;
        private System.Windows.Forms.Label LblAnim;
        private System.Windows.Forms.Label LblCashStat;
        private System.Windows.Forms.Label LblMonnaie;
        private System.Windows.Forms.Label LblStatDate;
        private System.Windows.Forms.Label LblDate;
    }
}

