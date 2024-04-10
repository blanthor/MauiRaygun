namespace MauiRaygun
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            if(count % 5 == 0)
            {
                throw new Exception("Unhandled Exception from Counter");
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
