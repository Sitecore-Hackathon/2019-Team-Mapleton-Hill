using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using Common.Web.Models;
using Microsoft.VisualBasic.FileIO;

namespace Common.Web.Providers
{
    public class CsvMediaProvider : ICsvMediaProvider, IDisposable
    {
     //   private Stream _reader;
        private const string _WebType = "Web";
        private const string _FileSystemType = "FileSystem";

        public CsvMediaProvider(string fileLocation)
        {
         //   _reader = File.Open(fileLocation);
        }

        public void Dispose()
        {
          //  _reader.Dispose();
        }

        public List<ICsvMedia> GetMediaList(string fileLocation)
        {
            List<ICsvMedia> result = null;
            using (TextFieldParser parser = new TextFieldParser(fileLocation))
            {
            //    List<string> headers = new List<string>(); 
                result = new List<ICsvMedia>();
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                bool isFirstRow = true;
        
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (isFirstRow)
                    {
                        //foreach (string field in fields)
                        //{
                        //    headers.Add(field);
                        //}
                        isFirstRow = false;
                    }
                    else
                    {
                        int i = 0;
                        CsvMedia media = new CsvMedia();

                        foreach (string field in fields)
                        {
                            if (i == 0)
                            {
                                media.FileLocation = field;
                            }
                            else if (i == 1)
                            {
                                media.FileName = field;
                            }
                            else if (i == 2)
                            {
                                media.ItemName = field;
                            }
                            else if (i == 3)
                            {
                                media.Type = DetermineResourceType(field);
                            }

                            i++;
                        }
                        result.Add(media);
                    }
                }
            }
            return result;
        }

        public ResourceType DetermineResourceType(string source)
        {
            switch (source)
            {
                case _WebType:
                {
                    return ResourceType.Web;
                }
                case _FileSystemType:
                {
                    return ResourceType.FileSystem;
                }
                default:
                {
                    return ResourceType.FileSystem;
                }
            }
        }
    }
}