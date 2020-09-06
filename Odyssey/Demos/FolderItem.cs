using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.IO;
using System.Reflection;

namespace Demos
{
    public class FolderItem
    {
        public string Folder { get; set; }
        public ImageSource Image { get; set; }

        public FolderItem()
            : base()
        {
            ImageSourceConverter isc = new ImageSourceConverter();
            Image = new BitmapImage(new Uri("openfolderHS.png", UriKind.Relative));
        }
    }
}
