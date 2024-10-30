using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using IWshRuntimeLibrary;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using File = System.IO.File;

namespace DST_Toolkit
{
    public partial class Main : Form
    {
        private string steamapps_path = "";
        private string cluster_path = "";
        private string klei_server_token = "";
        private string list_mods = "";
        private string bat_path = "";

        public Main()
        {
            InitializeComponent();
            initial_default();
        }

        private void initial_default()
        {
            txt_klei_server_token.Text = Properties.Resources.Default.klei_server_token;
            this.klei_server_token = Properties.Resources.Default.klei_server_token;
            bat_path = Properties.Resources.Default.bat_path;
        }

        private void btn_steamapps_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Folder contain game and dedicated server";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                this.lb_steamapps.Text = selectedPath;

                bool first_check = selectedPath.Split('\\').Last().Contains("steamapps");
                if (first_check)
                {
                    this.lb_steamapps.ForeColor = Color.Green;
                    this.steamapps_path = selectedPath;
                    Properties.Resources.Default.steamapps = steamapps_path;
                    Properties.Resources.Default.Save();
                    this.strip_status_content.Text = "Next step...";
                }
                else
                {
                    this.lb_steamapps.ForeColor = Color.Red;
                    this.strip_status_content.Text = "Path is not in correct format";
                }
            }
        }

        private void btn_cluster_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Folder contain save game";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    string cluster_init = Path.Combine(selectedPath, "cluster.ini");
                    this.lb_cluster.Text = selectedPath;

                    bool first_check = File.Exists(cluster_init);
                    if (first_check)
                    {
                        this.lb_cluster.ForeColor = Color.Green;
                        this.cluster_path = selectedPath;
                        Properties.Resources.Default.cluster = cluster_path;
                        Properties.Resources.Default.Save();
                        this.strip_status_content.Text = "Next step...";

                        this.txt_server_name.Text = Common.IniRead(cluster_init, "NETWORK", "cluster_name");
                        this.txt_description.Text = Common.IniRead(cluster_init, "NETWORK", "cluster_description");
                        this.txt_password.Text = Common.IniRead(cluster_init, "NETWORK", "cluster_password");
                        this.txt_max_player.Text = Common.IniRead(cluster_init, "GAMEPLAY", "max_players");
                    }
                    else
                    {
                        this.lb_cluster.ForeColor = Color.Red;
                        this.strip_status_content.Text = "Cluster empty!";
                    }
                }
            }
        }

        private void txt_klei_server_token_TextChanged(object sender, EventArgs e)
        {
            Properties.Resources.Default.klei_server_token = txt_klei_server_token.Text;
            Properties.Resources.Default.Save();
        }

        private void txt_server_name_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_server_name.Text))
            {
                Properties.Resources.Default.server_name = txt_server_name.Text;
                Properties.Resources.Default.Save();
            }
        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_description.Text))
            {
                Properties.Resources.Default.description = txt_description.Text;
                Properties.Resources.Default.Save();
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_password.Text))
            {
                Properties.Resources.Default.password = txt_password.Text;
                Properties.Resources.Default.Save();
            }
        }

        private void txt_max_player_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_max_player.Text))
            {
                Properties.Resources.Default.max_player = int.Parse(txt_max_player.Text);
                Properties.Resources.Default.Save();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cluster_init = Path.Combine(this.cluster_path, "cluster.ini");

            Common.IniWrite(cluster_init, "NETWORK", "cluster_name", " " + this.txt_server_name.Text);
            Common.IniWrite(cluster_init, "NETWORK", "cluster_description", " " + this.txt_description.Text);
            Common.IniWrite(cluster_init, "NETWORK", "cluster_password", " " + this.txt_password.Text);
            Common.IniWrite(cluster_init, "GAMEPLAY", "max_players", " " + this.txt_max_player.Text);

            this.strip_status_content.Text = "Saved!!!";
        }

        private void btn_create_server_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(steamapps_path) && !string.IsNullOrEmpty(cluster_path) && !string.IsNullOrEmpty(klei_server_token))
            {
                this.strip_status_content.Text = "Save token";
                string path = this.cluster_path + "\\cluster_token.txt";
                if (File.Exists(path))
                {
                    using (TextWriter tw = new StreamWriter(path))
                    {
                        if (this.txt_klei_server_token.Text == null)
                        {
                            goto next;
                        }
                        tw.WriteLine(this.txt_klei_server_token.Text);
                        goto next;
                    }
                }
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                    using (TextWriter tw2 = new StreamWriter(path))
                    {
                        tw2.WriteLine(this.txt_klei_server_token.Text);
                    }
                }
            next:
                this.strip_status_content.Text = "Read file mod overrides";
                string file_mod_override = File.ReadAllText(string.Concat(this.cluster_path, "\\Master\\modoverrides.lua"));
                string workshop = "[\"workshop-";
                string output = string.Join(";", from Match m in Regex.Matches(file_mod_override, "\\" + workshop + "(.+?)\"]") select m.Groups[1].Value);
                this.list_mods = output;
                this.strip_status_content.Text = "Copying mods";
                this.copyMod();
                this.strip_status_content.Text = "Creating .bat file";
                this.createBatFile();
            }
            else
            {
                if (string.IsNullOrEmpty(steamapps_path))
                {
                    this.strip_status_content.Text = "Please select 'steamapps' folder!";
                }
                else if (string.IsNullOrEmpty(cluster_path))
                {
                    this.strip_status_content.Text = "Please select 'Cluster_...' folder!";
                }
                else
                {
                    this.strip_status_content.Text = "Please input 'Klei server token'!";
                }
            }
        }

        private void btn_start_server_Click(object sender, EventArgs e)
        {
            try
            {
                RunFile(bat_path);
                this.strip_status_content.Text = "Check cmd or terminal popup";
            }
            catch (FileNotFoundException exp2)
            {
                FileNotFoundException ex2 = exp2;
                MessageBox.Show(((ex2 != null) ? ex2.ToString() : null), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo source = new DirectoryInfo(sourceDirectory);
            DirectoryInfo dir_target = new DirectoryInfo(targetDirectory);
            Main.CopyAll(source, dir_target);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }
            foreach (DirectoryInfo dir_source_subdir in source.GetDirectories())
            {
                DirectoryInfo next_target_subdir = target.CreateSubdirectory(dir_source_subdir.Name);
                Main.CopyAll(dir_source_subdir, next_target_subdir);
            }
        }

        private void copyMod()
        {
            string folder_mods_dst = this.steamapps_path + "\\common\\Don't Starve Together\\mods\\";
            string folder_mod_workshop = this.steamapps_path + "\\workshop\\content\\322330\\";
            string folder_mods_dedicated_dst = this.steamapps_path + "\\common\\Don't Starve Together Dedicated Server\\mods\\";
            foreach (string mod in this.list_mods.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (mod.Trim() != "")
                {
                    if (!Directory.Exists(folder_mods_dst + "workshop-" + mod))
                    {
                        try
                        {
                            Main.Copy(folder_mod_workshop + mod, folder_mods_dedicated_dst + "workshop-" + mod);
                            goto end_one_iteration;
                        }
                        catch (FileNotFoundException exp)
                        {
                            FileNotFoundException ex = exp;
                            MessageBox.Show("Folder workshop-" + mod + " not found. Maybe it hasn't been downloaded yet\n" + ((ex != null) ? ex.ToString() : null), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            goto end_one_iteration;
                        }
                    }
                    try
                    {
                        Main.Copy(folder_mods_dst + "workshop-" + mod, folder_mods_dedicated_dst + "workshop-" + mod);
                    }
                    catch (FileNotFoundException exp2)
                    {
                        FileNotFoundException ex2 = exp2;
                        MessageBox.Show("Folder workshop-" + mod + " not found. Maybe it hasn't been downloaded yet\n" + ((ex2 != null) ? ex2.ToString() : null), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            end_one_iteration:;
            }
        }

        private void createBatFile()
        {
            string name = "MyDedicatedServer";
            bat_path = this.steamapps_path + "\\common\\Don't Starve Together Dedicated Server\\bin64\\" + name + ".bat";
            Properties.Resources.Default.bat_path = bat_path;
            Properties.Resources.Default.Save();

            if (!File.Exists(bat_path))
            {
                File.Create(bat_path).Dispose();
                WriteBatchFileContent(bat_path);
                this.CreateShortcut(name);
                this.strip_status_content.Text = "Done! Check shortcut in your desktop";
            }
            else
            {
                File.Delete(bat_path);
                WriteBatchFileContent(bat_path);
                this.CreateShortcut(name);
                this.strip_status_content.Text = "Done! Check shortcut in your desktop";
            }
        }

        void WriteBatchFileContent(string bat_path)
        {
            string cluster = this.cluster_path.Split("DoNotStarveTogether\\", StringSplitOptions.None).Last<string>();
            using (TextWriter tw = new StreamWriter(bat_path, false))
            {
                tw.WriteLine(string.Concat(new string[]
                {
            "cd /D \"%~dp0\"\nstart \"DST Server Master\" dontstarve_dedicated_server_nullrenderer_x64.exe -cluster ",
            cluster,
            " -shard Master \nstart \"DST Server Caves\" dontstarve_dedicated_server_nullrenderer_x64.exe -cluster ",
            cluster,
            " -shard Caves"
                }));
            }
        }

        private void CreateShortcut(string name)
        {
            object sh_desktop = "Desktop";
            WshShell shell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
            string shortcut_address = string.Concat((string)((dynamic)shell.SpecialFolders.Item(ref sh_desktop)), "\\", name, ".lnk");
            IWshShortcut wsh_shortcut = (IWshShortcut)((dynamic)shell.CreateShortcut(shortcut_address));
            wsh_shortcut.TargetPath = string.Concat(this.steamapps_path, "\\common\\Don't Starve Together Dedicated Server\\bin64\\\\", name, ".bat");
            wsh_shortcut.Save();
        }

        public string FindTextBetween(string text, string left, string right)
        {
            int begin_index = text.IndexOf(left);
            if (begin_index == -1)
            {
                return string.Empty;
            }
            begin_index += left.Length;
            int end_index = text.IndexOf(right, begin_index);
            if (end_index == -1)
            {
                return string.Empty;
            }
            return text.Substring(begin_index, end_index - begin_index).Trim();
        }

        public void RunFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
