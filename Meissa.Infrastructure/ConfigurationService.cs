﻿// <copyright file="ConfigurationService.cs" company="Automate The Planet Ltd.">
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
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Meissa.Infrastructure
{
    public sealed class ConfigurationService
    {
        private static ConfigurationService _instance;

        static ConfigurationService() => Root = InitializeConfiguration();

        public static ConfigurationService Instance => _instance ?? (_instance = new ConfigurationService());

        public static IConfigurationRoot Root { get; }

        private static IConfigurationRoot InitializeConfiguration()
        {
            var filesInExecutionDir = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException());
            var settingsFile =
                filesInExecutionDir.FirstOrDefault(x => x.Contains("meissaSettings") && x.EndsWith(".json", StringComparison.Ordinal));
            var builder = new ConfigurationBuilder();
            if (settingsFile != null)
            {
                builder.AddJsonFile(settingsFile, optional: true, reloadOnChange: true);
            }

            return builder.Build();
        }
    }
}
