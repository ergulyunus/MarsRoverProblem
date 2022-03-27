using MarsRover.Core.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests.HelperTests
{
    public class HelperTest
    {
        [Theory]
        [InlineData("N")]
        [InlineData("W")]
        [InlineData("S")]
        [InlineData("E")]
        public void CheckDirection_With_Correct_Request_Parameter_Then_OK_Test(string param)
        {
            var result = Helper.CheckDirection(param);
            Assert.True(result);
        }

        [Theory]
        [InlineData("A")]
        [InlineData("1")]
        [InlineData("")]
        public void CheckDirection_With_Not_Correct_Request_Parameter_Then_OK_Test(string param)
        {
            var result = Helper.CheckDirection(param);
            Assert.True(!result);
        }
    }
}
