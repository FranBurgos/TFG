﻿using System.IO;
using System.Windows.Forms;

namespace PlantaPiloto.Classes
{
    class GlobalParameters
    {
        public string FilesPath = Path.Combine(Application.StartupPath, "../../ApplicationData");
    }
}