using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileSystem
{
    public partial class Form1 : Form
    {
        string FPath = "D:\\";
        string fullPath = Environment.GetCommandLineArgs()[0];

        public Form1()
        {
            InitializeComponent();
            fullPath = Environment.GetCommandLineArgs()[0] + ".txt";
            if (File.Exists(fullPath))
                listBox1.Items.AddRange(File.ReadAllLines(fullPath));

            SetFileAndFolderImage();
            GetFiles();
        }

        #region Directories
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            if (item.ImageIndex == 1)
            {
                FPath = FPath + item.Text + "\\";
                GetFiles();
            }
        }

        private void GetFiles()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();

            AddFolderOrFile(Directory.GetDirectories(FPath));
            AddFolderOrFile(Directory.GetFiles(FPath));

            listView1.EndUpdate();
        }

        private void AddFolderOrFile(string[] names)
        {
            foreach (string name in names)
            {
                FileAttributes attributes = File.GetAttributes(name);
                switch (attributes)
                {
                    case FileAttributes.Directory:
                        string dir = Path.GetFileName(name);
                        listView1.Items.Add(dir, 1);
                        break;
                    case FileAttributes.Archive:
                        string file = Path.GetFileName(name);
                        listView1.Items.Add(file, 0);
                        break;
                    case FileAttributes.Hidden: continue;
                }
            }
        }

        private void SetFileAndFolderImage()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(new Bitmap(@"D:\Кодинг\Проекты C# (VS Community)\Практика и уроки\FlenovBookPractice\FileSystem\Assert\fileIco.png"));
            imageList.Images.Add(new Bitmap(@"D:\Кодинг\Проекты C# (VS Community)\Практика и уроки\FlenovBookPractice\FileSystem\Assert\folderIco.png"));
            listView1.LargeImageList = imageList;
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter($"{fullPath}", true))
            {
                foreach (string line in listBox1.Items)
                    writer.WriteLine(line);
            }
        }
    }
}