using System.Collections.Generic;
using Xamarin.Forms;

namespace MvvmContextActionSample.Views.ViewCells
{
    public class SampleViewCell : ViewCell
    {

        private Page _page;

        public SampleViewCell(Page page)
        {
            _page = page;

            foreach (var contextAction in CreateContextActions())
                ContextActions.Add(contextAction);

            this.View = CreateGrid();
        }

        public IList<MenuItem> CreateContextActions()
        {
            var deleteAction = new MenuItem {Text = "Delete", IsDestructive = true}; 
            deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            deleteAction.SetBinding(MenuItem.CommandProperty, new Binding("BindingContext.DeleteSampleCommand", source: _page));

            var returnActions = new List<MenuItem> {deleteAction};

            return returnActions;
        }

        public Grid CreateGrid()
        {
            var grid = new Grid {Padding = new Thickness(10, 5, 10, 5)};
            var columnDefinition = new ColumnDefinition {Width = GridLength.Auto};
            grid.ColumnDefinitions.Add(columnDefinition);

            var rowDefinition = new RowDefinition {Height = GridLength.Auto};
            grid.RowDefinitions.Add(rowDefinition);
            var label = new Label();

            label.SetBinding(Label.TextProperty,new Binding("Description"));
            grid.Children.Add(label);
            return grid;
        }
    }
}
