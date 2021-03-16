using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        StoreClass myStore = new StoreClass();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            try
            {
                CarClass c = new CarClass(txt_make.Text, txt_model.Text, int.Parse(txt_mileage.Text), decimal.Parse(txt_price.Text));
                myStore.CarList.Add(c);
            }
            catch (FormatException a)
            {
                MessageBox.Show("please use numbers for mileage and price");
            }
            carInventoryBindingSource.ResetBindings(false);
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            CarClass selected = (CarClass) lst_inventory.SelectedItem;
            myStore.ShoppingList.Add(selected);

            cartBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "£" + total.ToString();

            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;

            cartBindingSource.DataSource = myStore.ShoppingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }
    }
}
