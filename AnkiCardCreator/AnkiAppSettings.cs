using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace AnkiCardCreator
{
    public static class AnkiAppSettings
    {
        public static string AnkiContentPath;
        public static string AnkiImportPath;
        public static string PixaBayApiKey;

        static AnkiAppSettings()
        {
            LoadSettings();
        }

        public static void LoadSettings()
        {
            XDocument xDoc = XDocument.Load("settings.xml");

            AnkiContentPath = xDoc.Element("SETTINGS").Element("AnkiContentPath").Value;
            AnkiImportPath = xDoc.Element("SETTINGS").Element("AnkiImportPath").Value;
            PixaBayApiKey = xDoc.Element("SETTINGS").Element("PixaBayApiKey").Value;

            if (!Directory.Exists(AnkiContentPath))
            {
                try
                {
                    Directory.CreateDirectory(AnkiContentPath);
                }
                catch (DirectoryNotFoundException)
                {
                    SaveContentChanges(@"C:\AnkiCardCreatorImport");
                    LoadSettings();
                }
            }

            if (!Directory.Exists(AnkiImportPath))
            {
                try
                {
                    Directory.CreateDirectory(AnkiImportPath);
                }
                catch (DriveNotFoundException)
                {
                    SaveContentChanges(@"C:\AnkiCardCreatorImport");
                    LoadSettings();
                }
            }

        }

        public static void SaveContentChanges(string contPath)
        {
            AnkiContentPath = contPath;

            XDocument xDoc = XDocument.Load("settings.xml");

            xDoc.Element("SETTINGS").Element("AnkiContentPath").Value = contPath;

            xDoc.Save("settings.xml");
        }

        public static void SaveImportChanges(string impPath)
        {
            AnkiImportPath = impPath;

            XDocument xDoc = XDocument.Load("settings.xml");

            xDoc.Element("SETTINGS").Element("AnkiImportPath").Value = impPath;

            xDoc.Save("settings.xml");
        }


    }
}
