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
        MainContr control;
        Size panelSize;
        public string NameShop { get; set; }
        public MainForm()
        {
            InitializeComponent();
            panelSize = new Size();
            //Инициализация контролера
            control = new MainContr();
            panelSize = tabPage1.Size;
            //Добавляем обработчик панели
            control.update += update;
            //Очищаем все вкладки
            ShopTabControl.TabPages.Clear();
            //Добавляем обработчик событий переключения вкладки
            ShopTabControl.SelectedIndexChanged += NewTab;
            //Заполняем информацию о магазине
            Salon shop = new Salon();
            shop = control.GetShop()[0];
            NameShop = shop.name;
            nameShop.Text = shop.name;
            phone.Text = shop.PhoneNumber;
            address.Text = shop.adress;
            site.Text = shop.website;
            workBegin.Text = shop.BeginWork;
            workEnd.Text = shop.EndWork;
            update();
        }

        private void NewTab(object sender, EventArgs e)
        {
            Salon shopItem = new Salon();
            if (ShopTabControl.SelectedIndex < 0)
                shopItem = control.GetShop()[0];
            else
                shopItem = control.GetShop()[ShopTabControl.SelectedIndex];
            //Переопределяем поля для корректной записи данных
            //Берём название фирмы, которое открыто в данный момент
            NameShop = shopItem.name;
            nameShop.Text = shopItem.name;
            phone.Text = shopItem.PhoneNumber;
            address.Text = shopItem.adress;
            site.Text = shopItem.website;
            workBegin.Text = shopItem.BeginWork;
            workEnd.Text = shopItem.EndWork;
        }
        private void update()
        {
            ShopTabControl.TabPages.Clear();
            foreach (Salon shopItem in control.GetShop())
            {
                TabPage tab = new TabPage();
                tab.Text = shopItem.name;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Size = panelSize;
               
                tab.Controls.Add(panel);
                ShopTabControl.TabPages.Add(tab);
            }
        }

        private void AddShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.AddShop();

        }

        private void DeleteShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.DeleteShop();
        }

        private void ShowGoods_Click(object sender, EventArgs e)
        {
            Button btm = (Button)sender;
            control.ProductsInfo(NameShop);
        }

        private void ShowEmployees_Click(object sender, EventArgs e)
        {
            Button btm = (Button)sender;
            control.EmployeeInfo(NameShop);
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
