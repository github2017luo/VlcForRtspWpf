using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AxAXVLC;

namespace VlcForRtspWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AxVLCPlugin2 vlc;

        [Display]
        public int MyProperty { get; set; }

        public MainWindow()
        {
            InitializeComponent();


            string s = null;

            var r = s?.ToString() ?? string.Empty;
            return;


            vlc = new AxVLCPlugin2();
            windowsFormsHost.Child = vlc;



            int i = 1;
            while (i == 0b1)
            {
                try
                {
                    Debug.WriteLine("try");
                    //return;
                    Application.Current.Shutdown();
                }
                catch (Exception)
                {

                }
                finally
                {
                    Debug.WriteLine("finalyl");
                }

                Debug.WriteLine("end of while.");
            }

            Debug.WriteLine("at the end.");
        }

        private void btnPlayLocalFile_Click(object sender, RoutedEventArgs e)
        {
            String localFile = @"file:///C:\Users\e.chitgar\Desktop\12-25-27.mp4";
            int id = vlc.playlist.add(localFile);
            vlc.playlist.playItem(id);
        }

        private void btnPlayRtspStream_Click(object sender, RoutedEventArgs e)
        {
            string rtspUrl = "rtsp://root:root@192.168.1.114/axis-media/media.amp?videocodec=h264&resolution=800x450&fps=8&compression=50";
            int id = vlc.playlist.add(rtspUrl);
            vlc.playlist.playItem(id);
        }
    }
}