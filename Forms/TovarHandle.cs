using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovik.Tools;
using Kursovik.Classes;
using System.IO;

namespace Kursovik.Forms
{
    public partial class TovarHandle : Form
    {
        string picPath = "placeholder.png";

        bool isNew = false;
        int id = 0;
        public TovarHandle(bool isNew, int id)
        {
            InitializeComponent();
            this.isNew = isNew;
            this.id = id;
        }

        private void TovarHandle_Load(object sender, EventArgs e)
        {
            List<string> categs = new List<string>();
            categs = TovarsDatabaseHelper.getCategs();
            tovarCat.Items.AddRange(categs.ToArray());

            tovarPic.Image = Image.FromFile("../../Images/Tovars/" + picPath);

            if (!isNew)
            {
                Tovar tovar = TovarsDatabaseHelper.getTovarByID(id);
                tovarPic.Image = tovar.Picture;
                tovarName.Text = tovar.TovarName;
                tovarCat.Text = tovar.TovarCateg;
                tovarPrice.Value = Convert.ToDecimal(tovar.TovarPrice);
                tovarDays.Value = tovar.DaysToProduce;
                picPath = tovar.picPath;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (tovarName.Text != "" &&
                    tovarCat.Text != "")
            {
                if (isNew)
                {
                    TovarsDatabaseHelper.addTovarDB(tovarName.Text, tovarCat.Text, Convert.ToInt32(tovarPrice.Value), Convert.ToInt32(tovarDays.Value), picPath);
                    Close();
                }
                else
                {
                    TovarsDatabaseHelper.editTovarDB(id, tovarName.Text, tovarCat.Text, Convert.ToInt32(tovarPrice.Value), Convert.ToInt32(tovarDays.Value), picPath);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Введите все данные.");
            }
        }

        private void newTovar_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "pic.png";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.EndsWith(".png") ||
                openFileDialog1.FileName.EndsWith(".jpg") ||
                openFileDialog1.FileName.EndsWith(".jpeg"))
            {
                string[] pathParts = openFileDialog1.FileName.Split('\\');
                string selfName = pathParts[pathParts.Length - 1];
                Console.WriteLine(selfName);
                try
                {
                    File.Copy(openFileDialog1.FileName, "../../Images/Tovars/" + selfName);
                }
                catch
                {
                    MessageBox.Show("Файл уже существует.");
                }
                picPath = selfName;
                tovarPic.Image = Image.FromFile("../../Images/Tovars/" + picPath);
            }
            else
            {
                MessageBox.Show("Выберите подходящий формат фото.");
            }
        }
    }
}
