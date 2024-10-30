namespace DST_Toolkit
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_steamapps = new Button();
            gr_server_info = new GroupBox();
            btn_save = new Button();
            txt_max_player = new TextBox();
            txt_password = new TextBox();
            txt_description = new TextBox();
            txt_server_name = new TextBox();
            lb_max_player = new Label();
            lb_password = new Label();
            lb_description = new Label();
            lb_server_name = new Label();
            btn_cluster = new Button();
            lb_steamapps = new Label();
            lb_cluster = new Label();
            fpn_cluster = new FlowLayoutPanel();
            fpn_steamapps = new FlowLayoutPanel();
            gr_klei_server_token = new GroupBox();
            txt_klei_server_token = new TextBox();
            status_strip = new StatusStrip();
            strip_contributor = new ToolStripStatusLabel();
            strip_split_1 = new ToolStripStatusLabel();
            strip_version = new ToolStripStatusLabel();
            strip_split_2 = new ToolStripStatusLabel();
            strip_status = new ToolStripStatusLabel();
            strip_status_content = new ToolStripStatusLabel();
            gr_controls = new GroupBox();
            btn_start_server = new Button();
            btn_create_server = new Button();
            gr_server_info.SuspendLayout();
            fpn_cluster.SuspendLayout();
            fpn_steamapps.SuspendLayout();
            gr_klei_server_token.SuspendLayout();
            status_strip.SuspendLayout();
            gr_controls.SuspendLayout();
            SuspendLayout();
            // 
            // btn_steamapps
            // 
            btn_steamapps.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_steamapps.Location = new Point(3, 3);
            btn_steamapps.Name = "btn_steamapps";
            btn_steamapps.Size = new Size(271, 25);
            btn_steamapps.TabIndex = 0;
            btn_steamapps.Text = "Select folder \"steamapps\"";
            btn_steamapps.UseVisualStyleBackColor = true;
            btn_steamapps.Click += btn_steamapps_Click;
            // 
            // gr_server_info
            // 
            gr_server_info.Controls.Add(btn_save);
            gr_server_info.Controls.Add(txt_max_player);
            gr_server_info.Controls.Add(txt_password);
            gr_server_info.Controls.Add(txt_description);
            gr_server_info.Controls.Add(txt_server_name);
            gr_server_info.Controls.Add(lb_max_player);
            gr_server_info.Controls.Add(lb_password);
            gr_server_info.Controls.Add(lb_description);
            gr_server_info.Controls.Add(lb_server_name);
            gr_server_info.Location = new Point(315, 8);
            gr_server_info.Name = "gr_server_info";
            gr_server_info.Size = new Size(233, 178);
            gr_server_info.TabIndex = 4;
            gr_server_info.TabStop = false;
            gr_server_info.Text = "Server info";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(152, 149);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_max_player
            // 
            txt_max_player.Location = new Point(84, 118);
            txt_max_player.Name = "txt_max_player";
            txt_max_player.Size = new Size(143, 23);
            txt_max_player.TabIndex = 7;
            txt_max_player.TextChanged += txt_max_player_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(84, 84);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(143, 23);
            txt_password.TabIndex = 5;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(84, 50);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(143, 23);
            txt_description.TabIndex = 3;
            txt_description.TextChanged += txt_description_TextChanged;
            // 
            // txt_server_name
            // 
            txt_server_name.Location = new Point(84, 16);
            txt_server_name.Name = "txt_server_name";
            txt_server_name.Size = new Size(143, 23);
            txt_server_name.TabIndex = 1;
            txt_server_name.TextChanged += txt_server_name_TextChanged;
            // 
            // lb_max_player
            // 
            lb_max_player.AutoSize = true;
            lb_max_player.Location = new Point(6, 122);
            lb_max_player.Name = "lb_max_player";
            lb_max_player.Size = new Size(65, 15);
            lb_max_player.TabIndex = 6;
            lb_max_player.Text = "Max player";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(6, 88);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(57, 15);
            lb_password.TabIndex = 4;
            lb_password.Text = "Password";
            // 
            // lb_description
            // 
            lb_description.AutoSize = true;
            lb_description.Location = new Point(6, 54);
            lb_description.Name = "lb_description";
            lb_description.Size = new Size(67, 15);
            lb_description.TabIndex = 2;
            lb_description.Text = "Description";
            // 
            // lb_server_name
            // 
            lb_server_name.AutoSize = true;
            lb_server_name.Location = new Point(6, 19);
            lb_server_name.Name = "lb_server_name";
            lb_server_name.Size = new Size(72, 15);
            lb_server_name.TabIndex = 0;
            lb_server_name.Text = "Server name";
            // 
            // btn_cluster
            // 
            btn_cluster.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn_cluster.Location = new Point(3, 3);
            btn_cluster.Name = "btn_cluster";
            btn_cluster.Size = new Size(271, 25);
            btn_cluster.TabIndex = 0;
            btn_cluster.Text = "Select folder \"Cluster_...\"";
            btn_cluster.UseVisualStyleBackColor = true;
            btn_cluster.Click += btn_cluster_Click;
            // 
            // lb_steamapps
            // 
            lb_steamapps.AutoSize = true;
            lb_steamapps.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_steamapps.Location = new Point(3, 31);
            lb_steamapps.Name = "lb_steamapps";
            lb_steamapps.Size = new Size(240, 15);
            lb_steamapps.TabIndex = 1;
            lb_steamapps.Text = "ex: C:\\Program Files (x86)\\Steam\\steamapps";
            // 
            // lb_cluster
            // 
            lb_cluster.AutoSize = true;
            lb_cluster.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lb_cluster.Location = new Point(3, 31);
            lb_cluster.Name = "lb_cluster";
            lb_cluster.Size = new Size(286, 45);
            lb_cluster.TabIndex = 1;
            lb_cluster.Text = "ex: C:\\Users\\KameDev\\Documents\\Klei\\DoNotStarveTogether\\1586985302\\Cluster_1";
            // 
            // fpn_cluster
            // 
            fpn_cluster.AutoScroll = true;
            fpn_cluster.Controls.Add(btn_cluster);
            fpn_cluster.Controls.Add(lb_cluster);
            fpn_cluster.Location = new Point(12, 102);
            fpn_cluster.Name = "fpn_cluster";
            fpn_cluster.Size = new Size(297, 84);
            fpn_cluster.TabIndex = 2;
            // 
            // fpn_steamapps
            // 
            fpn_steamapps.Controls.Add(btn_steamapps);
            fpn_steamapps.Controls.Add(lb_steamapps);
            fpn_steamapps.Location = new Point(12, 12);
            fpn_steamapps.Name = "fpn_steamapps";
            fpn_steamapps.Size = new Size(297, 84);
            fpn_steamapps.TabIndex = 1;
            // 
            // gr_klei_server_token
            // 
            gr_klei_server_token.Controls.Add(txt_klei_server_token);
            gr_klei_server_token.Location = new Point(12, 192);
            gr_klei_server_token.Name = "gr_klei_server_token";
            gr_klei_server_token.Size = new Size(297, 53);
            gr_klei_server_token.TabIndex = 3;
            gr_klei_server_token.TabStop = false;
            gr_klei_server_token.Text = "Klei server token";
            // 
            // txt_klei_server_token
            // 
            txt_klei_server_token.Location = new Point(6, 22);
            txt_klei_server_token.Name = "txt_klei_server_token";
            txt_klei_server_token.Size = new Size(285, 23);
            txt_klei_server_token.TabIndex = 0;
            txt_klei_server_token.TextChanged += txt_klei_server_token_TextChanged;
            // 
            // status_strip
            // 
            status_strip.Items.AddRange(new ToolStripItem[] { strip_contributor, strip_split_1, strip_version, strip_split_2, strip_status, strip_status_content });
            status_strip.Location = new Point(0, 253);
            status_strip.Name = "status_strip";
            status_strip.Size = new Size(558, 22);
            status_strip.SizingGrip = false;
            status_strip.TabIndex = 0;
            status_strip.Text = "statusStrip1";
            // 
            // strip_contributor
            // 
            strip_contributor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            strip_contributor.Enabled = false;
            strip_contributor.Name = "strip_contributor";
            strip_contributor.Size = new Size(125, 17);
            strip_contributor.Text = "Contributor: KameDev";
            // 
            // strip_split_1
            // 
            strip_split_1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            strip_split_1.Enabled = false;
            strip_split_1.Name = "strip_split_1";
            strip_split_1.Size = new Size(10, 17);
            strip_split_1.Text = "|";
            // 
            // strip_version
            // 
            strip_version.Enabled = false;
            strip_version.Name = "strip_version";
            strip_version.Size = new Size(75, 17);
            strip_version.Text = "Version: 1.0.0";
            // 
            // strip_split_2
            // 
            strip_split_2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            strip_split_2.Enabled = false;
            strip_split_2.Name = "strip_split_2";
            strip_split_2.Size = new Size(10, 17);
            strip_split_2.Text = "|";
            // 
            // strip_status
            // 
            strip_status.ForeColor = Color.DodgerBlue;
            strip_status.Name = "strip_status";
            strip_status.Size = new Size(45, 17);
            strip_status.Text = "Status: ";
            // 
            // strip_status_content
            // 
            strip_status_content.ForeColor = Color.DodgerBlue;
            strip_status_content.Name = "strip_status_content";
            strip_status_content.Size = new Size(48, 17);
            strip_status_content.Text = "Ready...";
            // 
            // gr_controls
            // 
            gr_controls.Controls.Add(btn_start_server);
            gr_controls.Controls.Add(btn_create_server);
            gr_controls.Location = new Point(315, 192);
            gr_controls.Name = "gr_controls";
            gr_controls.Size = new Size(233, 53);
            gr_controls.TabIndex = 5;
            gr_controls.TabStop = false;
            gr_controls.Text = "Controls";
            // 
            // btn_start_server
            // 
            btn_start_server.Location = new Point(119, 22);
            btn_start_server.Name = "btn_start_server";
            btn_start_server.Size = new Size(108, 23);
            btn_start_server.TabIndex = 1;
            btn_start_server.Text = "Start server";
            btn_start_server.UseVisualStyleBackColor = true;
            btn_start_server.Click += btn_start_server_Click;
            // 
            // btn_create_server
            // 
            btn_create_server.Location = new Point(6, 22);
            btn_create_server.Name = "btn_create_server";
            btn_create_server.Size = new Size(108, 23);
            btn_create_server.TabIndex = 0;
            btn_create_server.Text = "Create server";
            btn_create_server.UseVisualStyleBackColor = true;
            btn_create_server.Click += btn_create_server_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 275);
            Controls.Add(gr_controls);
            Controls.Add(status_strip);
            Controls.Add(gr_klei_server_token);
            Controls.Add(fpn_steamapps);
            Controls.Add(fpn_cluster);
            Controls.Add(gr_server_info);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Main";
            Text = "DST Toolkit for Windows";
            gr_server_info.ResumeLayout(false);
            gr_server_info.PerformLayout();
            fpn_cluster.ResumeLayout(false);
            fpn_cluster.PerformLayout();
            fpn_steamapps.ResumeLayout(false);
            fpn_steamapps.PerformLayout();
            gr_klei_server_token.ResumeLayout(false);
            gr_klei_server_token.PerformLayout();
            status_strip.ResumeLayout(false);
            status_strip.PerformLayout();
            gr_controls.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_steamapps;
        private GroupBox gr_server_info;
        private Button btn_cluster;
        private Label lb_steamapps;
        private Label lb_cluster;
        private FlowLayoutPanel fpn_cluster;
        private FlowLayoutPanel fpn_steamapps;
        private GroupBox gr_klei_server_token;
        private TextBox txt_klei_server_token;
        private Label lb_max_player;
        private Label lb_password;
        private Label lb_description;
        private Label lb_server_name;
        private TextBox txt_server_name;
        private TextBox txt_password;
        private TextBox txt_description;
        private Button btn_save;
        private TextBox txt_max_player;
        private StatusStrip status_strip;
        private ToolStripStatusLabel strip_contributor;
        private GroupBox gr_controls;
        private Button btn_start_server;
        private Button btn_create_server;
        private ToolStripStatusLabel strip_split_1;
        private ToolStripStatusLabel strip_version;
        private ToolStripStatusLabel strip_split_2;
        private ToolStripStatusLabel strip_status;
        private ToolStripStatusLabel strip_status_content;
    }
}
