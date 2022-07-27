

using Microsoft.Maui.Controls.Shapes;

namespace GridTest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        CreateWideButton();

    }


    void CreateWideButton()
    {

       int numberOfColumns = 10;
        int numberOfRows = 10;
        int spacing = 5;

        double percentagePerColumn = 100d / (double)numberOfColumns;
        double percentagePerRow = 100d / (double)numberOfRows;

        ColumnDefinitionCollection columns = new ColumnDefinitionCollection();
        RowDefinitionCollection rows = new RowDefinitionCollection();

        for (int i = 0; i < numberOfColumns; i++)
        {
            columns.Add(new ColumnDefinition() { Width = new GridLength(percentagePerColumn, GridUnitType.Star) });

        }

        for (int i = 0; i < numberOfRows; i++)
        {

            rows.Add(new RowDefinition() { Height = new GridLength(percentagePerRow, GridUnitType.Star) });

        }

        MainGrid.RowDefinitions = rows;
        MainGrid.ColumnDefinitions = columns;

        MainGrid.RowSpacing = spacing;
        MainGrid.ColumnSpacing = spacing;

        Grid wideGrid = new Grid { BackgroundColor = Color.FromRgba(1f, 1f, 0.2f, 1f),Margin =5};
        wideGrid.Add(new Label { BackgroundColor = Color.FromRgba(0.4f, 0.6f, 0.2f, 0.5f), Margin = 20, Text = "Column span = 8", VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.Center });
        Grid.SetColumnSpan(wideGrid, 8);
        MainGrid.Add(wideGrid, 0, 0);


        Grid wideGrid2 = new Grid { BackgroundColor = Color.FromRgba(1f, 1f, 0.2f, 1f), Margin = 5 };
        wideGrid2.Add(new BoxView { Color = Color.FromRgba(0.5f, 1f, 0.5f, 1f), Margin = 20 });
        Grid.SetColumnSpan(wideGrid2, 6);
        Grid.SetRowSpan(wideGrid2, 6);
        MainGrid.Add(wideGrid2, 0, 1);

        Grid grid = new Grid { BackgroundColor = Color.FromRgba(0.5f, 1f, 0.2f, 1f), Margin = 5 };
        grid.Add(new Label { Margin = 20, BackgroundColor = Color.FromRgba(0.7f, 0.6f, 0f, 0.5f), Text = "Span = 1", VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.Center });
        MainGrid.Add(grid, 0,9);
    
    }
    
  
}

