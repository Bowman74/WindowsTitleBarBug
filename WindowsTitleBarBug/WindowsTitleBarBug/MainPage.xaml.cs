namespace WindowsTitleBarBug
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            _grid.ItemsSource = "aaaaaaabbbbbbbbccccccccccccddddddddddddddeeeeeeeeefg";
        }
    }
}
