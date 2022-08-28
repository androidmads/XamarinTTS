using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace XamarinTTS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ConvertClicked(object sender, EventArgs e)
        {
            var locales = await TextToSpeech.GetLocalesAsync();

            // Grab the first locale
            var locale = locales.FirstOrDefault();

            var settings = new SpeechOptions()
            {
                Volume = (float)(volume.Value),
                Pitch = (float)(pitch.Value),
                Locale = locale
            };
            await TextToSpeech.SpeakAsync(entry_tts.Text, settings);
        }
    }
}
