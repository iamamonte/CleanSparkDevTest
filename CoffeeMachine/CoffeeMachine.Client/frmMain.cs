using CoffeeMachine.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachine.Client
{
	public partial class frmMain : Form
	{
		private readonly ICoffeeVendorService vendorService = new CoffeeVendorService();
		public frmMain()
		{
			InitializeComponent();
			lblChange.Text = "";
			lblErrorMessage.Text = "";
		}

		private void btnAddCoffee_Click(object sender, EventArgs e)
		{
			lblErrorMessage.Text = "";
			lblChange.Text = "";
			CoffeeSize coffeeSize = CoffeeSize.Small;
			//create order item
			switch (cmbSize.SelectedIndex) 
			{
				case 0: coffeeSize = CoffeeSize.Small;
					break;
				case 1: coffeeSize = CoffeeSize.Medium;
					break;
				case 2: coffeeSize = CoffeeSize.Large;
					break;
			}

			//add to order
			try
			{
				var orderItem = new CoffeeOrderItem { Coffee = new Coffee(coffeeSize) };
				for (int i = 0; i < inputCreamerCount.Value; i++)
				{
					orderItem.AddOns.Add(new Creamer());
				}

				for (int i = 0; i < inputSugarCount.Value; i++)
				{
					orderItem.AddOns.Add(new Sugar());
				}

				vendorService.AddToOrder(orderItem);
				txtCurrentOrder.Text = vendorService.DisplayOrder();
			}
			catch (ArgumentOutOfRangeException ex) 
			{
				lblErrorMessage.Text = ex.Message;
				return;
			}

			//show order
			lblOrderTotal.Text = $"${vendorService.TotalOrder()}";
		}

		private void btnAddPayment_Click(object sender, EventArgs e)
		{
			lblErrorMessage.Text = "";
			lblChange.Text = "";
			decimal amount;
			if (!decimal.TryParse(txtPayment.Text, out amount)) 
			{
				//show message
				lblErrorMessage.Text = "Invalid payment input. Please use an increment of $0.05 with a mininum of $0.05 and a maximum of $20.00";
				return;
			}
			try
			{
				vendorService.AddCredits(amount);
				lblCurrentPayment.Text = $"${vendorService.GetCredits()}";
			}
			catch (ArgumentException ex) 
			{
				lblErrorMessage.Text = ex.Message;
			}
		
		}

		private void btnVend_Click(object sender, EventArgs e)
		{
			lblErrorMessage.Text = "";
			lblChange.Text = "";
			if (vendorService.GetOrder().OrderItems.Count == 0) return;
			var totalAmount = vendorService.TotalOrder();
			var creditAvailable = vendorService.GetCredits();
			if (totalAmount > creditAvailable) 
			{
				lblErrorMessage.Text = "Please input more payments in order to fulfill this order.";
				return;
			}

			try
			{
				vendorService.TransactOrder();
				lblCurrentPayment.Text = $"${vendorService.GetCredits()}";
				lblOrderTotal.Text = $"${vendorService.TotalOrder()}";
				txtCurrentOrder.Text = vendorService.DisplayOrder();

			}
			catch (Exception ex) 
			{
				lblErrorMessage.Text = ex.Message;
			}
		}

		private void btnGetChange_Click(object sender, EventArgs e)
		{
			var change = vendorService.DispenseCredits();
			//TODO: Notify user of change.
			if (change > 0) lblChange.Text = $"Here is your change: ${change}";
			lblCurrentPayment.Text = $"${vendorService.GetCredits()}";
			lblOrderTotal.Text = $"${vendorService.TotalOrder()}";
			
		}
	}
}
