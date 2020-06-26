namespace WindowsFormsApp2
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
            this.playerTier = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minionTier = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minionDemand = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minionOdds = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerTier
            // 
            this.playerTier.FormattingEnabled = true;
            this.playerTier.Items.AddRange(new object[] {
            "Tavern Tier 1",
            "Tavern Tier 2",
            "Tavern Tier 3",
            "Tavern Tier 4",
            "Tavern Tier 5",
            "Tavern Tier 6"});
            this.playerTier.Location = new System.Drawing.Point(12, 25);
            this.playerTier.Name = "playerTier";
            this.playerTier.Size = new System.Drawing.Size(217, 82);
            this.playerTier.TabIndex = 0;
            this.playerTier.SelectedIndexChanged += new System.EventHandler(this.playerTier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What Tavern Tier are you?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // minionTier
            // 
            this.minionTier.FormattingEnabled = true;
            this.minionTier.Items.AddRange(new object[] {
            "Tavern Tier 1",
            "Tavern Tier 2",
            "Tavern Tier 3",
            "Tavern Tier 4",
            "Tavern Tier 5",
            "Tavern Tier 6"});
            this.minionTier.Location = new System.Drawing.Point(12, 141);
            this.minionTier.Name = "minionTier";
            this.minionTier.Size = new System.Drawing.Size(217, 82);
            this.minionTier.TabIndex = 2;
            this.minionTier.Visible = false;
            this.minionTier.SelectedIndexChanged += new System.EventHandler(this.minionTier_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "What Tavern Tier is the minion you want the odds for?";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // minionDemand
            // 
            this.minionDemand.FormattingEnabled = true;
            this.minionDemand.Items.AddRange(new object[] {
            "No Demand",
            "Low Demand",
            "Medium Demand",
            "High Demand",
            "Very High Demand"});
            this.minionDemand.Location = new System.Drawing.Point(12, 260);
            this.minionDemand.Name = "minionDemand";
            this.minionDemand.Size = new System.Drawing.Size(219, 69);
            this.minionDemand.TabIndex = 4;
            this.minionDemand.Visible = false;
            this.minionDemand.SelectedIndexChanged += new System.EventHandler(this.minionDemand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "What is the demand for the minion?";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Odds for getting the minion";
            this.label4.Visible = false;
            // 
            // minionOdds
            // 
            this.minionOdds.Location = new System.Drawing.Point(363, 77);
            this.minionOdds.Name = "minionOdds";
            this.minionOdds.ReadOnly = true;
            this.minionOdds.Size = new System.Drawing.Size(140, 20);
            this.minionOdds.TabIndex = 8;
            this.minionOdds.Visible = false;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(400, 154);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(69, 69);
            this.button.TabIndex = 10;
            this.button.Text = "Calculate";
            this.button.UseVisualStyleBackColor = true;
            this.button.Visible = false;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 259);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 70);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "When you press calculate this will give you the probabilty of getting atleast one" +
    " of the specfic minion from that tavern tier based on your tavern tier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 354);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.minionOdds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minionDemand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minionTier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerTier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Battlegrounds Minion Odds";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playerTier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox minionTier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox minionDemand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minionOdds;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

