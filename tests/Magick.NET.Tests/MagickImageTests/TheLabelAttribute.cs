﻿// Copyright 2013-2021 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using ImageMagick;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class MagickImageTests
    {
        public class TheLabelAttribute
        {
            [Fact]
            public void ShouldGetTheLabelAttribute()
            {
                using (var image = new MagickImage())
                {
                    image.SetAttribute("label", "foo");

                    Assert.Equal("foo", image.Label);
                }
            }

            [Fact]
            public void ShouldSetTheLabelAttribute()
            {
                using (var image = new MagickImage())
                {
                    image.Label = "foo";

                    Assert.Equal("foo", image.GetAttribute("label"));
                }
            }

            [Fact]
            public void ShouldRemoveTheLabelAttributeWhenSetToNull()
            {
                using (var image = new MagickImage())
                {
                    image.SetAttribute("label", "foo");

                    image.Label = null;

                    Assert.Null(image.GetAttribute("label"));
                }
            }
        }
    }
}
