﻿// <copyright file="GetFileName_Should.cs" company="Automate The Planet Ltd.">
// Copyright 2018 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://bellatrix.solutions/</site>
using System.IO;
using AutoFixture;
using NUnit.Framework;

namespace Meissa.Infrastructure.UnitTests.PathProviderTests
{
    [TestFixture]
    public class GetFileName_Should
    {
        [Test]
        public void ReturnNewUniqueFilePath()
        {
            // Arrange
            var fixture = new Fixture();

            // Act
            var pathProvider = new PathProvider();
            string actualFileName = pathProvider.GetFileName(fixture.Create<string>());

            // Assert
            Assert.That(File.Exists(actualFileName), Is.False);
        }
    }
}