namespace QuizApp
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
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonSport = new System.Windows.Forms.Button();
            this.buttonTechnology = new System.Windows.Forms.Button();
            this.buttonGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(313, 52);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(174, 65);
            this.buttonHistory.TabIndex = 0;
            this.buttonHistory.Text = "Historia";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonSport
            // 
            this.buttonSport.Location = new System.Drawing.Point(313, 142);
            this.buttonSport.Name = "buttonSport";
            this.buttonSport.Size = new System.Drawing.Size(174, 70);
            this.buttonSport.TabIndex = 1;
            this.buttonSport.Text = "Sport";
            this.buttonSport.UseVisualStyleBackColor = true;
            this.buttonSport.Click += new System.EventHandler(this.buttonSport_Click);
            // 
            // buttonTechnology
            // 
            this.buttonTechnology.Location = new System.Drawing.Point(313, 232);
            this.buttonTechnology.Name = "buttonTechnology";
            this.buttonTechnology.Size = new System.Drawing.Size(174, 65);
            this.buttonTechnology.TabIndex = 2;
            this.buttonTechnology.Text = "Technologia";
            this.buttonTechnology.UseVisualStyleBackColor = true;
            this.buttonTechnology.Click += new System.EventHandler(this.buttonTechnology_Click);
            // 
            // buttonGeneral
            // 
            this.buttonGeneral.Location = new System.Drawing.Point(313, 327);
            this.buttonGeneral.Name = "buttonGeneral";
            this.buttonGeneral.Size = new System.Drawing.Size(174, 67);
            this.buttonGeneral.TabIndex = 3;
            this.buttonGeneral.Text = "Wiedza ogólna";
            this.buttonGeneral.UseVisualStyleBackColor = true;
            this.buttonGeneral.Click += new System.EventHandler(this.buttonGeneral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeneral);
            this.Controls.Add(this.buttonTechnology);
            this.Controls.Add(this.buttonSport);
            this.Controls.Add(this.buttonHistory);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonSport;
        private System.Windows.Forms.Button buttonTechnology;
        private System.Windows.Forms.Button buttonGeneral;
    }
}