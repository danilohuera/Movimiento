using Movimiento.Common.Models;
using System;
using System.Collections.Generic;

using System.Text;

namespace Movimiento.ViewModels 

{
    using System.Collections.ObjectModel;
    using Common.Models;
    using Movimiento.Services;
    using Xamarin.Forms;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products 
        {
            get { return this.products; }

            set { this.SetValue(ref this.products, value); } 
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            var response = await this.apiService.GetList<Product>("https://localhost:44306", "/api", "/Products");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("error", response.Message, "Accept");
                return;
            }

            var list = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(list);
        }
    }
}
