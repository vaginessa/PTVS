﻿// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.PythonTools.Options {
    sealed class SuppressDialogOptions {
        private readonly PythonToolsService _service;

        private const string Category = "SuppressDialog";

        private const string SwitchEvaluatorSetting = "SwitchEvaluator";

        internal SuppressDialogOptions(PythonToolsService service) {
            _service = service;
            Load();
        }

        public void Load() {
            SwitchEvaluator = _service.LoadString(SwitchEvaluatorSetting, Category);
        }

        public void Save() {
            _service.SaveString(SwitchEvaluatorSetting, Category, SwitchEvaluator);
        }

        public void Reset() {
            SwitchEvaluator = null;
        }

        public string SwitchEvaluator { get; set; }
    }
}
