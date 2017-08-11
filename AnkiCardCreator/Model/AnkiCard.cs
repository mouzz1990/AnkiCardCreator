﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Threading;

namespace AnkiCardCreator.Model
{
    public class AnkiCard
    {
        public string Word { get; set; }
        public string Translation { get; set; }
        public string Transcription { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        string ImgPath { get; set; }

        //string filePath = @"C:/AnkiImport/import.txt";
        string filePath = string.Format("{0}/AnkiImport/import.txt", Environment.CurrentDirectory);
        string imgPath = @"AnkiImage";
        public string PathToAnkiContent { get; set; }

        public AnkiCard(string w, string tr, string ts, string url)
        {
            Word = w;
            Translation = tr;
            Transcription = ts;
            ImageUrl = url;

            ImgPath = imgPath + "/" + Word + ".jpg";
            ImageName = Word + ".jpg";

            //PathToAnkiContent = @"C:/Users/operator/AppData/Roaming/Anki2/Дима/collection.media";
            PathToAnkiContent = LoadSettings();
         }

        public override string ToString()
        {
            return String.Format("{0};{1};[{2}];<img src=\"{3}\">", Word, Translation, Transcription, ImageName);
        }

        void DownloadImage()
        {
            if (!Directory.Exists(imgPath))
            {
                Directory.CreateDirectory(imgPath);
            }

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(ImageUrl, ImgPath);
            }

            File.Copy(ImgPath, PathToAnkiContent + "/" + ImageName, true);
            
            Thread.Sleep(300);

            File.Delete(ImgPath);
        }

        public void SaveCard()
        {
            if (!Directory.Exists(string.Format("{0}/AnkiImport", Environment.CurrentDirectory)))
            {
                Directory.CreateDirectory(string.Format("{0}/AnkiImport", Environment.CurrentDirectory));
            }

            DownloadImage();
            
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(this);
            }
        }

        string LoadSettings()
        {
            XDocument xDoc = XDocument.Load("settings.xml");
            string path = xDoc.Element("SETTINGS").Element("AnkiContentPath").Value;

            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException();

            return path;
        }
    }
}
