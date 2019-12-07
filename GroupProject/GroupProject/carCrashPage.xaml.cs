using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.SimpleAudioPlayer;
using System.Reflection;
using System.IO;

namespace GroupProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class carCrashPage : ContentPage
    {
        public carCrashPage()
        {
            InitializeComponent();

            ISimpleAudioPlayer crashPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            crashPlayer.Load(GetStreamFromFile("carCrashSound.wav"));
            crashPlayer.Play();
        }

        private void youDied_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new startPage());

        }
        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("GroupProject" + filename);
            return stream;
        }
    }
}