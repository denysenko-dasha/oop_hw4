using System.Collections.ObjectModel;

namespace Shop;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Good> GoodList { get; set; }

	public MainPage()
	{
		InitializeComponent();
		GoodList = new ObservableCollection<Good>();

        CollectionView.ItemsSource = GoodList;
	}

	private async void OnAddClicked(object? sender, EventArgs e)
	{
		string choice = await DisplayActionSheetAsync("Choose what to add:", "Cancel", "Exit", "Product", "Book");

		if (choice == "Product")
		{
			Product product = new Product(85, "Ukraine", "12.12.01","Milk",  "bla", "12.12.12", 1, "l");
			GoodList.Add(product);
		}
		else if (choice == "Book")
		{
			Book book = new Book(85, "Ukraine", "12.12.01","Book1",  "bla", 31, "bla", ["author"]);

			GoodList.Add(book);
		}
	}
	private async void OnDeleteClicked(object? sender, EventArgs e)
	{
		Good? chosen = CollectionView.SelectedItem as Good;
		if (chosen != null)
		{
			GoodList.Remove(chosen);
		}
		
	}
}
