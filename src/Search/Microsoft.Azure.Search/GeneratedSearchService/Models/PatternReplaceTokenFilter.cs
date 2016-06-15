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
    /// A token filter which applies a pattern to each token in the stream,
    /// replacing match occurrences with the specified replacement string.
    /// This token filter is implemented using Apache Lucene.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.PatternReplaceTokenFilter")]
    public partial class PatternReplaceTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the PatternReplaceTokenFilter class.
        /// </summary>
        public PatternReplaceTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the PatternReplaceTokenFilter class.
        /// </summary>
        public PatternReplaceTokenFilter(string name, string pattern, string replacement)
            : base(name)
        {
            Pattern = pattern;
            Replacement = replacement;
        }

        /// <summary>
        /// Gets or sets a regular expression pattern.
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the replacement text.
        /// </summary>
        [JsonProperty(PropertyName = "replacement")]
        public string Replacement { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (Pattern == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Pattern");
            }
            if (Replacement == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Replacement");
            }
        }
    }
}