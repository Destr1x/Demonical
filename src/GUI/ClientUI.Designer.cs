namespace Demonical.src.GUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Combat = new System.Windows.Forms.TabPage();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.LDelay = new System.Windows.Forms.TrackBar();
            this.LDelayLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.RDelay = new System.Windows.Forms.TrackBar();
            this.RDelayLabel = new System.Windows.Forms.Label();
            this.Combat.SuspendLayout();
            this.TabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // Combat
            // 
            this.Combat.BackColor = System.Drawing.Color.Black;
            this.Combat.Controls.Add(this.RDelayLabel);
            this.Combat.Controls.Add(this.RDelay);
            this.Combat.Controls.Add(this.button2);
            this.Combat.Controls.Add(this.LDelayLabel);
            this.Combat.Controls.Add(this.LDelay);
            this.Combat.Controls.Add(this.button1);
            this.Combat.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Combat, "Combat");
            this.Combat.Name = "Combat";
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.Combat);
            resources.ApplyResources(this.TabMenu, "TabMenu");
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LDelay
            // 
            resources.ApplyResources(this.LDelay, "LDelay");
            this.LDelay.Name = "LDelay";
            // 
            // LDelayLabel
            // 
            resources.ApplyResources(this.LDelayLabel, "LDelayLabel");
            this.LDelayLabel.Name = "LDelayLabel";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // RDelay
            // 
            resources.ApplyResources(this.RDelay, "RDelay");
            this.RDelay.Name = "RDelay";
            // 
            // RDelayLabel
            // 
            resources.ApplyResources(this.RDelayLabel, "RDelayLabel");
            this.RDelayLabel.Name = "RDelayLabel";
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.TabMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Demonical_Load);
            this.Combat.ResumeLayout(false);
            this.Combat.PerformLayout();
            this.TabMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Combat;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar LDelay;
        private System.Windows.Forms.Label LDelayLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label RDelayLabel;
        private System.Windows.Forms.TrackBar RDelay;
    }
}