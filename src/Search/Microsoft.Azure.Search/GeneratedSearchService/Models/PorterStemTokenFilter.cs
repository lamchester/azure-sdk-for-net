// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Uses the Porter stemming algorithm to transform the token stream. This
    /// token filter is implemented using Apache Lucene.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.PorterStemTokenFilter")]
    public partial class PorterStemTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the PorterStemTokenFilter class.
        /// </summary>
        public PorterStemTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the PorterStemTokenFilter class.
        /// </summary>
        public PorterStemTokenFilter(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}