using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GenerationsSkillEdit
{
    public partial class MainForm : Form
    {
        Properties.Settings Settings = Properties.Settings.Default;

        int[] SkillBase = { 0xA124, 0xA1B4  };
        int[] SkillSetNameBase = { 0xA188, 0xA218 };

        string[] SkillSetNameParts = {
            "Super",
            "Last",
            "Beat",
            "Counter",
            "Star",
            "Maniac",
            "Pace",
            "Booster",
            "Love",
            "Assist",
            "Down",
            "Revenge",
            "Fight",
            "Jump",
            "Board",
            "Best",
            "Driver",
            "Start",
            "Fighter",
            "Ride",
            "Arrange",
            "Golden",
            "Kit",
            "After",
            "Laser",
            "Holder",
            "Blitz",
            "Spice",
            "Guard",
            "Improv",
            "Air",
            "Auto",
            "Sign",
            "Stop",
            "Access",
            "New",
            "Smart",
            "Ignition",
            "Jet",
            "Time",
            "Dash",
            "Style",
            "Big",
            "Sonic",
            "Spark",
            "Perfect",
            "Play",
            "Skillz",
            "Color",
            "Back",
            "Barrier",
            "Just",
            "Breaker",
            "Sky",
            "Image",
            "Unreal",
            "Runner",
            "Speed",
            "Series",
            "Safety",
            "Dump",
            "Catch",
            "Quick",
            "Cool",
            "Shot",
            "Sharp",
            "Skill",
            "Great",
            "Open",
            "Maker",
            "Guide",
            "Trial",
            "Attack",
            "Energy",
            "Show",
            "Set",
            "Lead",
            "Master",
            "Hyper",
            "Free",
            "Race",
            "Symbol",
            "Number",
            "Impulse",
            "Magic",
            "Power",
            "Crusher",
            "Shock",
            "Life",
            "Course",
            "Stand",
            "Change",
            "System",
            "Game",
            "Jinx",
            "Up",
            "Risk",
            "Charge",
            "Trick",
            "Theme",
            "Skill Set",
            "A",
            "B",
            "C",
            "D",
            "E"
        };

        public MainForm()
        {
            InitializeComponent();
        }

        string filename;
        byte[] filecontents;

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Settings.MRUList == null)
                Settings.MRUList = new System.Collections.Specialized.StringCollection();
            System.Collections.Specialized.StringCollection mru = new System.Collections.Specialized.StringCollection();
            foreach (string item in Settings.MRUList)
                if (File.Exists(item))
                {
                    mru.Add(item);
                    recentFilesToolStripMenuItem.DropDownItems.Add(item.Replace("&", "&&"));
                }
            Settings.MRUList = mru;
            if (mru.Count > 0) recentFilesToolStripMenuItem.DropDownItems.RemoveAt(0);
            skillSetNameSelect1.Items.AddRange((object[])SkillSetNameParts);
            skillSetNameSelect2.Items.AddRange((object[])SkillSetNameParts);
            if (Program.Arguments.Length > 0)
                LoadFile(Program.Arguments[0]);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (filename != null)
                switch (MessageBox.Show(this, "Do you want to save?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        saveToolStripMenuItem_Click(this, EventArgs.Empty);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            Settings.Save();
        }

        private void LoadFile(string filename)
        {
            byte[] file = File.ReadAllBytes(filename);
            this.filename = filename;
            filecontents = file;
            if (Settings.MRUList.Count == 0)
                recentFilesToolStripMenuItem.DropDownItems.RemoveAt(0);
            if (Settings.MRUList.Contains(filename))
            {
                recentFilesToolStripMenuItem.DropDownItems.RemoveAt(Settings.MRUList.IndexOf(filename));
                Settings.MRUList.Remove(filename);
            }
            Settings.MRUList.Insert(0, filename);
            recentFilesToolStripMenuItem.DropDownItems.Insert(0, new ToolStripMenuItem(filename));
            bool chgchr = characterSelect.SelectedIndex == 0;
            characterSelect.SelectedIndex = 0;
            if (chgchr) ChangeCharacter();
            saveToolStripMenuItem.Enabled = saveAsToolStripMenuItem.Enabled = panel1.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename != null)
                switch (MessageBox.Show(this, "Do you want to save?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        saveToolStripMenuItem_Click(this, EventArgs.Empty);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            using (OpenFileDialog a = new OpenFileDialog()
            {
                DefaultExt = "sav",
                Filter = "Save Files|*.sav|All Files|*.*"
            })
                if (a.ShowDialog(this) == DialogResult.OK)
                    LoadFile(a.FileName);
        }

        private void SaveFile()
        {
            File.WriteAllBytes(filename, filecontents);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog()
            {
                DefaultExt = "sav",
                Filter = "Save Files|*.sav|All Files|*.*",
                InitialDirectory = Path.GetDirectoryName(filename),
                FileName = Path.GetFileName(filename)
            })
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    filename = dlg.FileName;
                    SaveFile();
                }
        }

        private void recentFilesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            fileToolStripMenuItem.DropDown.Close();
            if (filename != null)
                switch (MessageBox.Show(this, "Do you want to save?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        saveToolStripMenuItem_Click(this, EventArgs.Empty);
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            LoadFile(Settings.MRUList[recentFilesToolStripMenuItem.DropDownItems.IndexOf(e.ClickedItem)]);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void characterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCharacter();
        }

        private void ChangeCharacter()
        {
            skillSetSelect.Items.Clear();
            int addr = SkillSetNameBase[characterSelect.SelectedIndex];
            for (int i = 0; i < 5; i++)
            {
                int part1 = BitConverter.ToInt32(filecontents, addr);
                if (part1 >= 900) part1 -= 800;
                addr += 4;
                int part2 = BitConverter.ToInt32(filecontents, addr);
                if (part2 >= 900) part2 -= 800;
                addr += 4;
                if (part2 > 100 & part1 <= 100)
                    skillSetSelect.Items.Add(SkillSetNameParts[part1] + " " + SkillSetNameParts[part2]);
                else
                    skillSetSelect.Items.Add(SkillSetNameParts[part1] + " & " + SkillSetNameParts[part2]);
            }
            skillSetSelect.SelectedIndex = 0;
        }

        private void skillSetSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skillSetSelect.SelectedIndex != -1)
                ChangeSkillSet();
        }

        private void ChangeSkillSet()
        {
            int addr = SkillBase[characterSelect.SelectedIndex] + (skillSetSelect.SelectedIndex * 0x14);
            skill1Select.SelectedIndex = BitConverter.ToInt32(filecontents, addr) + 1;
            addr += 4;
            skill2Select.SelectedIndex = BitConverter.ToInt32(filecontents, addr) + 1;
            addr += 4;
            skill3Select.SelectedIndex = BitConverter.ToInt32(filecontents, addr) + 1;
            addr += 4;
            skill4Select.SelectedIndex = BitConverter.ToInt32(filecontents, addr) + 1;
            addr += 4;
            skill5Select.SelectedIndex = BitConverter.ToInt32(filecontents, addr) + 1;
            addr = SkillSetNameBase[characterSelect.SelectedIndex] + (skillSetSelect.SelectedIndex * 8);
            int part = BitConverter.ToInt32(filecontents, addr);
            if (part >= 900) part -= 800;
            skillSetNameSelect1.SelectedIndex = part;
            addr += 4;
            part = BitConverter.ToInt32(filecontents, addr);
            if (part >= 900) part -= 800;
            skillSetNameSelect2.SelectedIndex = part;
        }

        private void skill1Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            BitConverter.GetBytes(skill1Select.SelectedIndex - 1).CopyTo(filecontents,
                SkillBase[characterSelect.SelectedIndex] + (skillSetSelect.SelectedIndex * 0x14));
        }

        private void skill2Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            BitConverter.GetBytes(skill2Select.SelectedIndex - 1).CopyTo(filecontents,
                SkillBase[characterSelect.SelectedIndex] + 4 + (skillSetSelect.SelectedIndex * 0x14));
        }

        private void skill3Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            BitConverter.GetBytes(skill3Select.SelectedIndex - 1).CopyTo(filecontents,
                SkillBase[characterSelect.SelectedIndex] + 8 + (skillSetSelect.SelectedIndex * 0x14));
        }

        private void skill4Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            BitConverter.GetBytes(skill4Select.SelectedIndex - 1).CopyTo(filecontents,
                SkillBase[characterSelect.SelectedIndex] + 0xC + (skillSetSelect.SelectedIndex * 0x14));
        }

        private void skill5Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            BitConverter.GetBytes(skill5Select.SelectedIndex - 1).CopyTo(filecontents,
                SkillBase[characterSelect.SelectedIndex] + 0x10 + (skillSetSelect.SelectedIndex * 0x14));
        }

        private void skillSetNameSelect1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BitConverter.GetBytes(skillSetNameSelect1.SelectedIndex).CopyTo(filecontents,
                SkillSetNameBase[characterSelect.SelectedIndex] + (skillSetSelect.SelectedIndex * 8));
        }

        private void skillSetNameSelect2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BitConverter.GetBytes(skillSetNameSelect2.SelectedIndex).CopyTo(filecontents,
                SkillSetNameBase[characterSelect.SelectedIndex] + (skillSetSelect.SelectedIndex * 8) + 4);
        }
    }
}