using System.Windows.Controls;

namespace RouletteNeoWPF.Views
{
    /// <summary>
    /// Interaction logic for YouWonView.xaml
    /// </summary>
    public partial class YouWonView : UserControl
    {
        public YouWonView(string userName)
        {
            InitializeComponent();

            CongratzTextBlock.Text = $"Congratulations {userName}";
        }
    }
}
