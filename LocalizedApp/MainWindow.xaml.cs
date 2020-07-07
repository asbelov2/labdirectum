namespace LocalizedApp
{
    using System;
    using System.Reflection;
    using System.Resources;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes new instance of MainWindow
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Method for button click event
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event parameters</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TextMessages.HelloMessage);
        }

        /// <summary>
        /// Method for initialization of window event
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event parameters</param>
        private void Window_Initialized(object sender, EventArgs e)
        {
            var resMan = new ResourceManager("LocalizedApp.TextMessages", Assembly.GetExecutingAssembly());
            MessageBox.Show(resMan.GetString("HelloMessage", new System.Globalization.CultureInfo("en")));
        }
    }
}
