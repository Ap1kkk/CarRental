using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        MainController control;
        Size panelSize;
        public string NameShop { get; set; }
        public MainForm()
        {
            InitializeComponent();
            panelSize = new Size();
            //Инициализация контролера
            control = new MainController();
            panelSize = tabPage1.Size;
            //Добавляем обработчик панели
            control.OnUpdate += update;
            //Очищаем все вкладки
            ShopTabControl.TabPages.Clear();
            //Добавляем обработчик событий переключения вкладки
            ShopTabControl.SelectedIndexChanged += NewTab;
            //Заполняем информацию о магазине
            CarSalon shop = new CarSalon();
            shop = control.GetShop()[0];
            NameShop = shop.Name;
            nameShop.Text = shop.Name;
            phone.Text = shop.PhoneNumber;
            address.Text = shop.Adress;
            site.Text = shop.Website;
            workBegin.Text = shop.BeginWork;
            workEnd.Text = shop.EndWork;
            update();
        }

        private void NewTab(object sender, EventArgs e)
        {
            CarSalon shopItem = new CarSalon();
            if (ShopTabControl.SelectedIndex < 0)
                shopItem = control.GetShop()[0];
            else
                shopItem = control.GetShop()[ShopTabControl.SelectedIndex];
            //Переопределяем поля для корректной записи данных
            //Берём название фирмы, которое открыто в данный момент
            NameShop = shopItem.Name;
            nameShop.Text = shopItem.Name;
            phone.Text = shopItem.PhoneNumber;
            address.Text = shopItem.Adress;
            site.Text = shopItem.Website;
            workBegin.Text = shopItem.BeginWork;
            workEnd.Text = shopItem.EndWork;
        }
        private void update()
        {
            ShopTabControl.TabPages.Clear();
            foreach (CarSalon shopItem in control.GetShop())
            {
                TabPage tab = new TabPage();
                tab.Text = shopItem.Name;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = panelSize;
               
                tab.Controls.Add(panel);
                ShopTabControl.TabPages.Add(tab);
            }
        }

        private void AddShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.AddSalon();

        }

        private void DeleteShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.DeleteSalon();
        }

        private void ShowGoods_Click(object sender, EventArgs e)
        {
            Button btm = (Button)sender;
            control.ShowProductsInfo(NameShop);
        }

        private void ShowEmployees_Click(object sender, EventArgs e)
        {
            Button btm = (Button)sender;
            control.ShowEmployeeInfo(NameShop);
        }

        private void ShowOrders_Click(object sender, EventArgs e)
        {
            Button btm = (Button)sender;
            control.OrderInfo(NameShop);
        }

        private void SaveInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.Save();
        }
    }
}
