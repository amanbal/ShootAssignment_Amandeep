namespace ShootAssignment_Amandeep
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDeadOrAlive = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLoader = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.btnAway = new System.Windows.Forms.Button();
            this.btnRuleToPlay = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeadOrAlive
            // 
            this.lblDeadOrAlive.AutoSize = true;
            this.lblDeadOrAlive.BackColor = System.Drawing.Color.Maroon;
            this.lblDeadOrAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadOrAlive.ForeColor = System.Drawing.Color.Black;
            this.lblDeadOrAlive.Location = new System.Drawing.Point(382, 33);
            this.lblDeadOrAlive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadOrAlive.Name = "lblDeadOrAlive";
            this.lblDeadOrAlive.Size = new System.Drawing.Size(255, 42);
            this.lblDeadOrAlive.TabIndex = 9;
            this.lblDeadOrAlive.Text = "Dead or Alive";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(52, 130);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(248, 25);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "Please Enter Your Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(341, 130);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 22);
            this.txtUserName.TabIndex = 16;
            // 
            // btnLoader
            // 
            this.btnLoader.BackColor = System.Drawing.Color.White;
            this.btnLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoader.Image = ((System.Drawing.Image)(resources.GetObject("btnLoader.Image")));
            this.btnLoader.Location = new System.Drawing.Point(662, 33);
            this.btnLoader.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoader.Name = "btnLoader";
            this.btnLoader.Size = new System.Drawing.Size(393, 154);
            this.btnLoader.TabIndex = 17;
            this.btnLoader.Text = "Load The Death";
            this.btnLoader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoader.UseVisualStyleBackColor = false;
            this.btnLoader.Click += new System.EventHandler(this.btnLoader_Click);
            // 
            // btnShot
            // 
            this.btnShot.BackColor = System.Drawing.Color.Silver;
            this.btnShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShot.Image = ((System.Drawing.Image)(resources.GetObject("btnShot.Image")));
            this.btnShot.Location = new System.Drawing.Point(662, 226);
            this.btnShot.Margin = new System.Windows.Forms.Padding(4);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(393, 199);
            this.btnShot.TabIndex = 18;
            this.btnShot.Text = "Shot Now";
            this.btnShot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShot.UseVisualStyleBackColor = false;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // btnAway
            // 
            this.btnAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAway.Image = ((System.Drawing.Image)(resources.GetObject("btnAway.Image")));
            this.btnAway.Location = new System.Drawing.Point(662, 497);
            this.btnAway.Margin = new System.Windows.Forms.Padding(4);
            this.btnAway.Name = "btnAway";
            this.btnAway.Size = new System.Drawing.Size(393, 144);
            this.btnAway.TabIndex = 19;
            this.btnAway.Text = "2X Forgiven Lives";
            this.btnAway.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAway.UseVisualStyleBackColor = true;
            this.btnAway.Click += new System.EventHandler(this.btnAway_Click);
            // 
            // btnRuleToPlay
            // 
            this.btnRuleToPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRuleToPlay.BackgroundImage")));
            this.btnRuleToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRuleToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuleToPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRuleToPlay.Location = new System.Drawing.Point(57, 254);
            this.btnRuleToPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnRuleToPlay.Name = "btnRuleToPlay";
            this.btnRuleToPlay.Size = new System.Drawing.Size(307, 143);
            this.btnRuleToPlay.TabIndex = 20;
            this.btnRuleToPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRuleToPlay.UseVisualStyleBackColor = true;
            this.btnRuleToPlay.Click += new System.EventHandler(this.btnRuleToPlay_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.Image")));
            this.btnPlayAgain.Location = new System.Drawing.Point(57, 483);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(307, 158);
            this.btnPlayAgain.TabIndex = 21;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 690);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnRuleToPlay);
            this.Controls.Add(this.btnAway);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.btnLoader);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDeadOrAlive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeadOrAlive;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLoader;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnAway;
        private System.Windows.Forms.Button btnRuleToPlay;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}

