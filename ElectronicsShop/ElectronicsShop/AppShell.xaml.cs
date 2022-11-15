﻿using ElectronicsShop.Views;

namespace ElectronicsShop;

public partial class AppShell : Shell
{
	public AppShell()
	{
        InitializeComponent();

        BindingContext = new AppShellViewModel();

        Routing.RegisterRoute(nameof(ProductsListView), typeof(ProductsListView));
        Routing.RegisterRoute(nameof(AuthorizationView), typeof(AuthorizationView));
        Routing.RegisterRoute(nameof(RegistrationView), typeof(RegistrationView));
        Routing.RegisterRoute(nameof(CartView), typeof(CartView));
        Routing.RegisterRoute(nameof(ProductView), typeof(ProductView));
    }
}
