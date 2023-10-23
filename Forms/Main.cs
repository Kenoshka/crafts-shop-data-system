using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovik.Classes;
using Kursovik.Tools;
using Kursovik.Forms;

namespace Kursovik
{
    public partial class Main : Form
    {
        string darkwoodPath = "../../Images/dark_wood.jpg";

        List<Tovar> tovars = new List<Tovar>();
        List<TovarCheck> order = new List<TovarCheck>();

        User user;

        Form auth;

        public Main(Form auth, User user)
        {
            this.user = user;

            this.auth = auth;

            InitializeComponent();
            userFio.Text = user.Fio;
            userBalance.Text = user.Balance.ToString();
            userLogin.Text = user.Login;
            userPassword.Text = user.Password;

            dataGridTovars.Columns[0].DataPropertyName = "TovarId";
            dataGridTovars.Columns[1].DataPropertyName = "Picture";
            dataGridTovars.Columns[2].DataPropertyName = "TovarName";
            dataGridTovars.Columns[3].DataPropertyName = "TovarCateg";
            dataGridTovars.Columns[4].DataPropertyName = "TovarPrice";
            dataGridTovars.Columns[5].DataPropertyName = "DaysToProduce";
            dataGridTovars.Columns[0].Visible = false;

            dataOrder.Columns[0].DataPropertyName = "Id";
            dataOrder.Columns[1].DataPropertyName = "TovName";
            dataOrder.Columns[2].DataPropertyName = "Amount";
            dataOrder.Columns[3].DataPropertyName = "Price";

            catalogButton_Click(new object(), new EventArgs());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshTovars();
            AddCategories();
        }

        public void AddCategories()
        {
            searchCateg.Items.Add("Нет");
            List<string> categs = new List<string>();
            categs = TovarsDatabaseHelper.getCategs();
            searchCateg.Items.AddRange(categs.ToArray());
            searchCateg.SelectedIndex = 0;
        }

        public void RefreshTovars()
        {
            tovars = TovarsDatabaseHelper.GetTovars();
            dataGridTovars.DataSource = tovars;
        }

        private void searchTovar_TextChanged(object sender, EventArgs e)
        {
            if (searchTovar.Text == "")
            {
                searchCateg_SelectedIndexChanged(sender, e);
            }
            else
            {
                tovars = tovarSeached(searchTovar.Text);
            }
            dataGridTovars.DataSource = tovars;
        }

        private List<Tovar> tovarSeached(string searchInput)
        {
            List<Tovar> bludoesSearched = new List<Tovar>();

            foreach (Tovar item in tovars)
            {
                if (item.TovarName.ToLower().Contains(searchInput.ToLower()))
                {
                    bludoesSearched.Add(item);
                }
            }
            return bludoesSearched;
        }

        private void catalogButton_Click(object sender, EventArgs e)
        {
            catalogButton.Image = Image.FromFile(darkwoodPath);
            cabinetButton.Image = null;
            lastButton.Image = null;

            panelCat.Visible = true;
            panelCabinet.Visible = false;
            panelLast.Visible = false;
        }

        private void cabinetButton_Click(object sender, EventArgs e)
        {
            catalogButton.Image = null;
            cabinetButton.Image = Image.FromFile(darkwoodPath);
            lastButton.Image = null;

            panelCat.Visible = false;
            panelCabinet.Visible = true;
            panelLast.Visible = false;
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            catalogButton.Image = null;
            cabinetButton.Image = null;
            lastButton.Image = Image.FromFile(darkwoodPath);

            panelCat.Visible = false;
            panelCabinet.Visible = false;
            panelLast.Visible = true;
        }

        private void searchCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchCateg.SelectedIndex == 0)
            {
                RefreshTovars();
            }
            else
            {
                tovars = TovarsDatabaseHelper.FilteredLoadFromDB(searchCateg.Text);
                dataGridTovars.DataSource = tovars;
            }
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            if (dataGridTovars.SelectedRows.Count < 1)
            {
                MessageBox.Show("Товар не выбран.");
            }
            else
            {
                if (numericUpDown1.Value != 0)
                {
                    int id = Convert.ToInt32(dataGridTovars.SelectedRows[0].Cells[0].Value);
                    string name = dataGridTovars.SelectedRows[0].Cells[2].Value.ToString();
                    int amount = Convert.ToInt32(numericUpDown1.Value);
                    int price = amount * Convert.ToInt32(dataGridTovars.SelectedRows[0].Cells[4].Value);
                    foreach (TovarCheck tovarCheck in order)
                    {
                        if (tovarCheck.Id == id)
                        {
                            tovarCheck.Amount += amount;
                            tovarCheck.Price = tovarCheck.Amount * Convert.ToInt32(dataGridTovars.SelectedRows[0].Cells[4].Value);
                            RefreshOrder();
                            return;
                        }
                    }
                    TovarCheck tc = new TovarCheck(id, name, amount, price);
                    order.Add(tc);
                    RefreshOrder();
                    numericUpDown1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Возьмите хотя бы одну шт. товара");
                }
            }
        }

        public void RefreshOrder()
        {
            dataOrder.Rows.Clear();
            foreach (TovarCheck tovarCheck in order)
            {
                dataOrder.Rows.Add(tovarCheck.Id, tovarCheck.TovName, tovarCheck.Amount, tovarCheck.Price);
            }
            sumLabel.Text = getZakazSum() + " руб.";
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridTovars.SelectedRows.Count < 1)
            {
                MessageBox.Show("Товар не выбран.");
            }
            else
            {
                int id = Convert.ToInt32(dataOrder.SelectedRows[0].Cells[0].Value);
                foreach (TovarCheck tovarCheck in order)
                {
                    if (tovarCheck.Id == id)
                    {
                        order.Remove(tovarCheck);
                        break;
                    }
                }
            }
            RefreshOrder();
        }

        private double getZakazSum()
        {
            double sum = 0;
            foreach (TovarCheck tovarCheck in order)
            {
                sum += tovarCheck.Price;
            }
            return sum;
        }

        private void oformitOrder_Click(object sender, EventArgs e)
        {
            if (order.Count < 1)
            {
                MessageBox.Show("Добавьте товар в корзину.");
            }
            else
            {
                if (getZakazSum() > user.Balance)
                {
                    MessageBox.Show("Недостаточно средств.");
                }
                else
                {
                    try
                    {
                        int id = ZakazDBHandler.getZakazId();
                        ZakazDBHandler.createZakaz(id, order, user.UserId, getZakazSum()); // ДОБАВИТЬ ЮЗЕР АЙДИ
                        UserDBHelper.updateFunds(user.UserId, -getZakazSum());
                        user.Balance -= getZakazSum();
                        userBalance.Text = user.Balance.ToString();
                        order.Clear();
                        RefreshOrder();
                        MessageBox.Show("Заказ успешно обработан");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!auth.Visible)
            {
                auth.Close();
            }
        }

        private void saveUserData_Click(object sender, EventArgs e)
        {
            if (userLogin.Text != "" && userPassword.Text != "")
            {
                try
                {
                    UserDBHelper.setLoginNpassword(user.UserId, userLogin.Text.Trim(), userPassword.Text.Trim());
                    MessageBox.Show("Данные обновлены. Перезайдите в приложение.");
                    auth.Show();
                    Close();
                } 
                catch
                {
                    MessageBox.Show("Во время обновления данных возникла ошибка. Вероятно, желаемый логин занят.");
                }
            }
            else
            {
                MessageBox.Show("Введите все поля.");
            }
        }

        private void deleteTovar_Click(object sender, EventArgs e)
        {
            if (dataGridTovars.SelectedRows.Count < 1)
            {
                MessageBox.Show("Вы не выбрали товар.");
            }
            else
            {
                int id = Convert.ToInt32(dataGridTovars.SelectedRows[0].Cells[0].Value);
                TovarsDatabaseHelper.deleteTovarDB(id);
                RefreshTovars();
            }
        }

        private void newTovar_Click(object sender, EventArgs e)
        {
            TovarHandle tovarHandle = new TovarHandle(true, 0);
            tovarHandle.ShowDialog();
            RefreshTovars();
        }

        private void editTovar_Click(object sender, EventArgs e)
        {
            if (dataGridTovars.SelectedRows.Count < 1)
            {
                MessageBox.Show("Вы не выбрали товар.");
            }
            else
            {
                int id = Convert.ToInt32(dataGridTovars.SelectedRows[0].Cells[0].Value);
                TovarHandle tovarHandle = new TovarHandle(false, id);
                tovarHandle.ShowDialog();
                RefreshTovars();
            }
        }
    }
}
