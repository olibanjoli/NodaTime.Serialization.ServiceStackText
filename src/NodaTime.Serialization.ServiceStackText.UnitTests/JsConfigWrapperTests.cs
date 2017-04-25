﻿using System;
using Xunit;

namespace NodaTime.Serialization.ServiceStackText.UnitTests
{
    public class JsConfigWrapperTests
    {
        [Fact]
        public void SetDeserializerMemberByName_InvalidName_Throws()
        {
            Assert.Throws<MemberAccessException>(
                () => JsConfigWrapper<object>.SetDeserializerMemberByName("nope", null));
        }
    }
}