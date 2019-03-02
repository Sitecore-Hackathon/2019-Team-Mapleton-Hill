using Common.Web.Models;
using Common.Web.Services;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

            WebRequest request = WebRequest.Create(webUrl);
            Stream expectedStream = request.GetResponse().GetResponseStream();

            HttpWebResponse responseSub = Substitute.For<HttpWebResponse>();
            responseSub.GetResponseStream().Returns(expectedStream);
            HttpWebRequest webRequestSub = Substitute.For<HttpWebRequest>();
            webRequestSub.GetResponse().Returns(x => responseSub);

            //act
            WebImageService sut = new WebImageService();
            sut.WebImageRequest = (string url) => { return webRequestSub; };

            Stream actualStream = sut.GetImage(webUrl);

            //assert
            Assert.Equal(actualStream, expectedStream);
        }
    }
}
