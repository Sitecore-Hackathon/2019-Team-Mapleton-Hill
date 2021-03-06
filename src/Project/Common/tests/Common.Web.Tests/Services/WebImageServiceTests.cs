﻿using Common.Web.Services;
using NSubstitute;
using System.IO;
using System.Net;
using Xunit;

namespace Common.Web.Tests.Services
{
    public class WebImageServiceTests
    {
        
        public WebImageServiceTests()
        {

        }

        [Fact]
        public void GivenWebRequest_WhenUrlIsProvided_ReturnStream()
        {
            //arrange
            string webUrl = "https://pbs.twimg.com/media/D0m_OxuVYAAoHay.jpg";
            
            WebClient client = new WebClient();
            var data = client.DownloadData(webUrl);
            Stream expectedStream = new MemoryStream(data);

            WebClient clientSub = Substitute.For<WebClient>();

            //act
            WebImageService sut = new WebImageService();
            sut.WebImageRequest = () => { return new WebClient(); };

            Stream actualStream = sut.GetImage(webUrl);

            //assert
            Assert.Equal(actualStream.Length, expectedStream.Length);
        }
    }
}
