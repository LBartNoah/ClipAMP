
namespace ClipAMP
{
    partial class GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.OutputController = new System.Windows.Forms.GroupBox();
            this.NoSpaceCheck = new System.Windows.Forms.CheckBox();
            this.ShowWAMark = new System.Windows.Forms.CheckBox();
            this.SongOutputBox = new System.Windows.Forms.TextBox();
            this.HideButton = new System.Windows.Forms.Button();
            this.UpdateMethod = new System.Windows.Forms.Timer(this.components);
            this.PoweredByText = new System.Windows.Forms.Label();
            this.WhippingText = new System.Windows.Forms.Label();
            this.OutputController.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputController
            // 
            this.OutputController.Controls.Add(this.WhippingText);
            this.OutputController.Controls.Add(this.PoweredByText);
            this.OutputController.Controls.Add(this.NoSpaceCheck);
            this.OutputController.Controls.Add(this.ShowWAMark);
            this.OutputController.Controls.Add(this.SongOutputBox);
            this.OutputController.Location = new System.Drawing.Point(12, 12);
            this.OutputController.Name = "OutputController";
            this.OutputController.Size = new System.Drawing.Size(195, 194);
            this.OutputController.TabIndex = 0;
            this.OutputController.TabStop = false;
            this.OutputController.Text = "Output Settings";
            // 
            // NoSpaceCheck
            // 
            this.NoSpaceCheck.AutoSize = true;
            this.NoSpaceCheck.Location = new System.Drawing.Point(6, 80);
            this.NoSpaceCheck.Name = "NoSpaceCheck";
            this.NoSpaceCheck.Size = new System.Drawing.Size(105, 17);
            this.NoSpaceCheck.TabIndex = 3;
            this.NoSpaceCheck.Text = "Remove Spaces";
            this.NoSpaceCheck.UseVisualStyleBackColor = true;
            // 
            // ShowWAMark
            // 
            this.ShowWAMark.AutoSize = true;
            this.ShowWAMark.Location = new System.Drawing.Point(6, 57);
            this.ShowWAMark.Name = "ShowWAMark";
            this.ShowWAMark.Size = new System.Drawing.Size(150, 17);
            this.ShowWAMark.TabIndex = 2;
            this.ShowWAMark.Text = "Show Winamp Watermark";
            this.ShowWAMark.UseVisualStyleBackColor = true;
            // 
            // SongOutputBox
            // 
            this.SongOutputBox.Location = new System.Drawing.Point(6, 31);
            this.SongOutputBox.Name = "SongOutputBox";
            this.SongOutputBox.ReadOnly = true;
            this.SongOutputBox.Size = new System.Drawing.Size(183, 20);
            this.SongOutputBox.TabIndex = 2;
            this.SongOutputBox.Text = "Song Output....";
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(213, 17);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(109, 189);
            this.HideButton.TabIndex = 1;
            this.HideButton.Text = "Hide ClipAMP";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // UpdateMethod
            // 
            this.UpdateMethod.Interval = 1;
            this.UpdateMethod.Tick += new System.EventHandler(this.UpdateMethod_Tick);
            // 
            // PoweredByText
            // 
            this.PoweredByText.AutoSize = true;
            this.PoweredByText.Location = new System.Drawing.Point(54, 111);
            this.PoweredByText.Name = "PoweredByText";
            this.PoweredByText.Size = new System.Drawing.Size(80, 39);
            this.PoweredByText.TabIndex = 2;
            this.PoweredByText.Text = "Powered By:\r\n- Lots Of Soda\r\n- Snack Breaks";
            this.PoweredByText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WhippingText
            // 
            this.WhippingText.AutoSize = true;
            this.WhippingText.Location = new System.Drawing.Point(15, 159);
            this.WhippingText.Name = "WhippingText";
            this.WhippingText.Size = new System.Drawing.Size(164, 13);
            this.WhippingText.TabIndex = 4;
            this.WhippingText.Text = "Guaranteed to whip the llama\'s....";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 218);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.OutputController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClipAMP";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.OutputController.ResumeLayout(false);
            this.OutputController.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OutputController;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Timer UpdateMethod;
        private System.Windows.Forms.TextBox SongOutputBox;
        private System.Windows.Forms.CheckBox NoSpaceCheck;
        private System.Windows.Forms.CheckBox ShowWAMark;
        private System.Windows.Forms.Label WhippingText;
        private System.Windows.Forms.Label PoweredByText;
    }
}

