namespace LightCommand_Server
{
    partial class LightCommandServerForm
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
            this.log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.status_groupBox = new System.Windows.Forms.GroupBox();
            this.status_text_label = new System.Windows.Forms.Label();
            this.client_groupBox = new System.Windows.Forms.GroupBox();
            this.client_status_label = new System.Windows.Forms.Label();
            this.server_ip_groupBox = new System.Windows.Forms.GroupBox();
            this.server_ip_label = new System.Windows.Forms.Label();
            this.socket_groupBox = new System.Windows.Forms.GroupBox();
            this.socket_status_label = new System.Windows.Forms.Label();
            this.stop_all_button = new System.Windows.Forms.Button();
            this.comboBox_scripts = new System.Windows.Forms.ComboBox();
            this.button_run = new System.Windows.Forms.Button();
            this.status_groupBox.SuspendLayout();
            this.client_groupBox.SuspendLayout();
            this.server_ip_groupBox.SuspendLayout();
            this.socket_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_richTextBox
            // 
            this.log_richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.log_richTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.log_richTextBox.Location = new System.Drawing.Point(12, 12);
            this.log_richTextBox.Name = "log_richTextBox";
            this.log_richTextBox.ReadOnly = true;
            this.log_richTextBox.Size = new System.Drawing.Size(663, 416);
            this.log_richTextBox.TabIndex = 0;
            this.log_richTextBox.Text = "";
            // 
            // status_groupBox
            // 
            this.status_groupBox.Controls.Add(this.status_text_label);
            this.status_groupBox.Location = new System.Drawing.Point(682, 12);
            this.status_groupBox.Name = "status_groupBox";
            this.status_groupBox.Size = new System.Drawing.Size(240, 83);
            this.status_groupBox.TabIndex = 1;
            this.status_groupBox.TabStop = false;
            this.status_groupBox.Text = "LIGHT STATUS";
            // 
            // status_text_label
            // 
            this.status_text_label.AutoSize = true;
            this.status_text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_text_label.ForeColor = System.Drawing.Color.Gold;
            this.status_text_label.Location = new System.Drawing.Point(6, 25);
            this.status_text_label.Name = "status_text_label";
            this.status_text_label.Size = new System.Drawing.Size(87, 37);
            this.status_text_label.TabIndex = 2;
            this.status_text_label.Text = "IDLE";
            // 
            // client_groupBox
            // 
            this.client_groupBox.Controls.Add(this.client_status_label);
            this.client_groupBox.Location = new System.Drawing.Point(682, 101);
            this.client_groupBox.Name = "client_groupBox";
            this.client_groupBox.Size = new System.Drawing.Size(240, 83);
            this.client_groupBox.TabIndex = 3;
            this.client_groupBox.TabStop = false;
            this.client_groupBox.Text = "CLIENT STATUS";
            // 
            // client_status_label
            // 
            this.client_status_label.AutoSize = true;
            this.client_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_status_label.ForeColor = System.Drawing.Color.Red;
            this.client_status_label.Location = new System.Drawing.Point(6, 26);
            this.client_status_label.Name = "client_status_label";
            this.client_status_label.Size = new System.Drawing.Size(155, 37);
            this.client_status_label.TabIndex = 2;
            this.client_status_label.Text = "WAITING";
            // 
            // server_ip_groupBox
            // 
            this.server_ip_groupBox.Controls.Add(this.server_ip_label);
            this.server_ip_groupBox.Location = new System.Drawing.Point(681, 279);
            this.server_ip_groupBox.Name = "server_ip_groupBox";
            this.server_ip_groupBox.Size = new System.Drawing.Size(241, 42);
            this.server_ip_groupBox.TabIndex = 4;
            this.server_ip_groupBox.TabStop = false;
            this.server_ip_groupBox.Text = "SERVER IP";
            // 
            // server_ip_label
            // 
            this.server_ip_label.AutoSize = true;
            this.server_ip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_ip_label.ForeColor = System.Drawing.Color.Orange;
            this.server_ip_label.Location = new System.Drawing.Point(6, 16);
            this.server_ip_label.Name = "server_ip_label";
            this.server_ip_label.Size = new System.Drawing.Size(97, 20);
            this.server_ip_label.TabIndex = 2;
            this.server_ip_label.Text = "0.0.0.0:0000";
            // 
            // socket_groupBox
            // 
            this.socket_groupBox.Controls.Add(this.socket_status_label);
            this.socket_groupBox.Location = new System.Drawing.Point(682, 190);
            this.socket_groupBox.Name = "socket_groupBox";
            this.socket_groupBox.Size = new System.Drawing.Size(240, 83);
            this.socket_groupBox.TabIndex = 4;
            this.socket_groupBox.TabStop = false;
            this.socket_groupBox.Text = "SOCKET STATUS";
            // 
            // socket_status_label
            // 
            this.socket_status_label.AutoSize = true;
            this.socket_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socket_status_label.ForeColor = System.Drawing.Color.LawnGreen;
            this.socket_status_label.Location = new System.Drawing.Point(2, 28);
            this.socket_status_label.Name = "socket_status_label";
            this.socket_status_label.Size = new System.Drawing.Size(210, 37);
            this.socket_status_label.TabIndex = 2;
            this.socket_status_label.Text = "INITIALIZING";
            // 
            // stop_all_button
            // 
            this.stop_all_button.BackColor = System.Drawing.Color.Salmon;
            this.stop_all_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stop_all_button.Location = new System.Drawing.Point(681, 401);
            this.stop_all_button.Name = "stop_all_button";
            this.stop_all_button.Size = new System.Drawing.Size(241, 27);
            this.stop_all_button.TabIndex = 5;
            this.stop_all_button.Text = "STOP";
            this.stop_all_button.UseMnemonic = false;
            this.stop_all_button.UseVisualStyleBackColor = false;
            this.stop_all_button.Click += new System.EventHandler(this.stop_all_button_Click);
            // 
            // comboBox_scripts
            // 
            this.comboBox_scripts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_scripts.FormattingEnabled = true;
            this.comboBox_scripts.Location = new System.Drawing.Point(682, 327);
            this.comboBox_scripts.Name = "comboBox_scripts";
            this.comboBox_scripts.Size = new System.Drawing.Size(159, 21);
            this.comboBox_scripts.TabIndex = 6;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(847, 325);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 7;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // LightCommandServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(934, 440);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.comboBox_scripts);
            this.Controls.Add(this.stop_all_button);
            this.Controls.Add(this.socket_groupBox);
            this.Controls.Add(this.server_ip_groupBox);
            this.Controls.Add(this.client_groupBox);
            this.Controls.Add(this.status_groupBox);
            this.Controls.Add(this.log_richTextBox);
            this.Name = "LightCommandServerForm";
            this.Text = "LightCommand Server";
            this.status_groupBox.ResumeLayout(false);
            this.status_groupBox.PerformLayout();
            this.client_groupBox.ResumeLayout(false);
            this.client_groupBox.PerformLayout();
            this.server_ip_groupBox.ResumeLayout(false);
            this.server_ip_groupBox.PerformLayout();
            this.socket_groupBox.ResumeLayout(false);
            this.socket_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox log_richTextBox;
        private System.Windows.Forms.GroupBox status_groupBox;
        private System.Windows.Forms.Label status_text_label;
        private System.Windows.Forms.GroupBox client_groupBox;
        private System.Windows.Forms.Label client_status_label;
        private System.Windows.Forms.GroupBox server_ip_groupBox;
        private System.Windows.Forms.Label server_ip_label;
        private System.Windows.Forms.GroupBox socket_groupBox;
        private System.Windows.Forms.Label socket_status_label;
        private System.Windows.Forms.Button stop_all_button;
        private System.Windows.Forms.ComboBox comboBox_scripts;
        private System.Windows.Forms.Button button_run;
    }
}

