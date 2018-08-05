﻿// <copyright file="Testresults.cs" company="Automate The Planet Ltd.">
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
// <auto-generated/>
// ReSharper disable All

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Meissa.Plugins.Protractor.Model
{
    [XmlRoot(ElementName = "test-results")]
    public class Testresults
    {
        [XmlElement(ElementName = "test-suite")]
        public List<Testsuite> Testsuite { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "total")]
        public string Total { get; set; }
        [XmlAttribute(AttributeName = "failures")]
        public string Failures { get; set; }
        [XmlAttribute(AttributeName = "not-run")]
        public string Notrun { get; set; }
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "time")]
        public string Time { get; set; }
    }
}
// ReSharper restore All
