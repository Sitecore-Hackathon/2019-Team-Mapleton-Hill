using Common.Web.Models;
using Common.Web.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Common.Web.Tests.Services
{
    public class FileImageServiceTests
    {
        [Fact]
        public void GivenFileRequest_WhenPathIsProvided_ReturnStream()
        {
            //arrange
            string filePathDummy = "Dummies\\sc-hackathon.png";
            Stream expectedStream = Stream.Null;

            using (FileStream fileStream = new FileStream(filePathDummy, FileMode.Open))
            {
                fileStream.CopyTo(expectedStream);
                fileStream.Close();
            }
            
            //act
            FileImageService sut = new FileImageService();
            
            Stream actualStream = sut.GetImage(filePathDummy);

            //assert
            Assert.Equal(actualStream, expectedStream);
        }
    }
}
