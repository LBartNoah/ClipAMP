
namespace ClipAMP_Update
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
            this.MovementPanel = new System.Windows.Forms.Panel();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OptionComponent = new System.Windows.Forms.GroupBox();
            this.OutputData = new System.Windows.Forms.TextBox();
            this.PreviewText = new System.Windows.Forms.Label();
            this.GetPerfectionCheck = new System.Windows.Forms.CheckBox();
            this.ModeInformation = new System.Windows.Forms.Label();
            this.UpdateSongFile = new System.Windows.Forms.Timer(this.components);
            this.MovementPanel.SuspendLayout();
            this.OptionComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovementPanel
            // 
            this.MovementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MovementPanel.Controls.Add(this.ExitButton);
            this.MovementPanel.Controls.Add(this.MinimizeButton);
            this.MovementPanel.Controls.Add(this.ProgramLabel);
            this.MovementPanel.Location = new System.Drawing.Point(-1, -1);
            this.MovementPanel.Name = "MovementPanel";
            this.MovementPanel.Size = new System.Drawing.Size(404, 50);
            this.MovementPanel.TabIndex = 0;
            this.MovementPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovementPanel_MouseDown);
            this.MovementPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovementPanel_MouseMove);
            this.MovementPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovementPanel_MouseUp);
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLabel.ForeColor = System.Drawing.Color.White;
            this.ProgramLabel.Location = new System.Drawing.Point(13, 12);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(176, 25);
            this.ProgramLabel.TabIndex = 1;
            this.ProgramLabel.Text = "ClipAMP v0.0.0.2";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimizeButton.Location = new System.Drawing.Point(331, 8);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(27, 32);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(364, 8);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 32);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OptionComponent
            // 
            this.OptionComponent.Controls.Add(this.ModeInformation);
            this.OptionComponent.Controls.Add(this.GetPerfectionCheck);
            this.OptionComponent.Location = new System.Drawing.Point(12, 106);
            this.OptionComponent.Name = "OptionComponent";
            this.OptionComponent.Size = new System.Drawing.Size(378, 164);
            this.OptionComponent.TabIndex = 1;
            this.OptionComponent.TabStop = false;
            // 
            // OutputData
            // 
            this.OutputData.Location = new System.Drawing.Point(112, 62);
            this.OutputData.Multiline = true;
            this.OutputData.Name = "OutputData";
            this.OutputData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.OutputData.Size = new System.Drawing.Size(278, 38);
            this.OutputData.TabIndex = 2;
            this.OutputData.Text = "Waiting for Winamp to open and return a currently playing song...";
            this.OutputData.WordWrap = false;
            // 
            // PreviewText
            // 
            this.PreviewText.AutoSize = true;
            this.PreviewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewText.ForeColor = System.Drawing.Color.White;
            this.PreviewText.Location = new System.Drawing.Point(13, 72);
            this.PreviewText.Name = "PreviewText";
            this.PreviewText.Size = new System.Drawing.Size(92, 15);
            this.PreviewText.TabIndex = 3;
            this.PreviewText.Text = "Output Preview:";
            // 
            // GetPerfectionCheck
            // 
            this.GetPerfectionCheck.AutoSize = true;
            this.GetPerfectionCheck.Checked = true;
            this.GetPerfectionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GetPerfectionCheck.ForeColor = System.Drawing.Color.White;
            this.GetPerfectionCheck.Location = new System.Drawing.Point(33, 40);
            this.GetPerfectionCheck.Name = "GetPerfectionCheck";
            this.GetPerfectionCheck.Size = new System.Drawing.Size(104, 17);
            this.GetPerfectionCheck.TabIndex = 0;
            this.GetPerfectionCheck.Text = "Perfection Mode";
            this.GetPerfectionCheck.UseVisualStyleBackColor = true;
            // 
            // ModeInformation
            // 
            this.ModeInformation.AutoSize = true;
            this.ModeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeInformation.ForeColor = System.Drawing.Color.White;
            this.ModeInformation.Location = new System.Drawing.Point(30, 60);
            this.ModeInformation.Name = "ModeInformation";
            this.ModeInformation.Size = new System.Drawing.Size(318, 60);
            this.ModeInformation.TabIndex = 1;
            this.ModeInformation.Text = resources.GetString("ModeInformation.Text");
            // 
            // UpdateSongFile
            // 
            this.UpdateSongFile.Interval = 1;
            this.UpdateSongFile.Tick += new System.EventHandler(this.UpdateSongFile_Tick);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(402, 289);
            this.ControlBox = false;
            this.Controls.Add(this.PreviewText);
            this.Controls.Add(this.OutputData);
            this.Controls.Add(this.OptionComponent);
            this.Controls.Add(this.MovementPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.MovementPanel.ResumeLayout(false);
            this.MovementPanel.PerformLayout();
            this.OptionComponent.ResumeLayout(false);
            this.OptionComponent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MovementPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.GroupBox OptionComponent;
        private System.Windows.Forms.Label ModeInformation;
        private System.Windows.Forms.CheckBox GetPerfectionCheck;
        private System.Windows.Forms.TextBox OutputData;
        private System.Windows.Forms.Label PreviewText;
        private System.Windows.Forms.Timer UpdateSongFile;
    }
}

