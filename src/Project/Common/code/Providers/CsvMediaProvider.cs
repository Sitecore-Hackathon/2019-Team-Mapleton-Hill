using Common.Web.Models;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

namespace Common.Web.Providers
{
    public class CsvMediaProvider : ICsvMediaProvider
    {
        /// <summary>
        /// Parse Csv file to get image data to be uploaded
        /// </summary>
        /// <param name="fileLocation"></param>
        /// <returns></returns>
        public List<ICsvMedia> ParseFile(string fileLocation)
        {
            List<ICsvMedia> result = null;
            using (TextFieldParser parser = new TextFieldParser(fileLocation))
            {
                result = new List<ICsvMedia>();
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                bool isFirstRow = true;
        
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (isFirstRow)
                    {
                        //Ignore head row
                        isFirstRow = false;
                    }
                    else
                    {
                        int i = 0;
                        CsvMedia media = new CsvMedia();

                        foreach (string field in fields)
                        {
                            //First column: File Location
                            if (i == 0) 
                            {
                                media.FileLocation = field;
                            }
                            //Second column: File name
                            else if (i == 1) 
                            {
                                media.FileName = field;
                            }
                            //Third column: Media Item name 
                            else if (i == 2)
                            {
                                media.ItemName = field;
                            }

                            i++;
                        }
                        result.Add(media);
                    }
                }
            }
            return result;
        }
    }
}