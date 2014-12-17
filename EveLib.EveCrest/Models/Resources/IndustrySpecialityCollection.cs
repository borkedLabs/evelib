﻿// ***********************************************************************
// Assembly         : EveLib.EveCrest
// Author           : Lars Kristian
// Created          : 12-16-2014
//
// Last Modified By : Lars Kristian
// Last Modified On : 12-17-2014
// ***********************************************************************
// <copyright file="IndustrySpecialityCollection.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace eZet.EveLib.EveCrestModule.Models.Resources {
    /// <summary>
    /// Represents a CREST /industry/specialities/ response
    /// </summary>
    [DataContract]
    public sealed class IndustrySpecialityCollection : CollectionResource<IndustrySpecialityCollection> {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustrySpecialityCollection"/> class.
        /// </summary>
        public IndustrySpecialityCollection() {
            Version = "application/vnd.ccp.eve.IndustrySpecialityCollection-v1+json";
        }

        /// <summary>
        /// A list of specializations
        /// </summary>
        /// <value>The specialities.</value>
        [DataMember(Name = "items")]
        public IReadOnlyList<IndustrySpeciality> Specialities { get; set; }
    }
}