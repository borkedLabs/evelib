﻿using System.Runtime.Serialization;
using eZet.EveLib.Modules.Models.Entities;

namespace eZet.EveLib.Modules.Models.Resources {
    [DataContract]
    public sealed class CrestMarketGroup : CrestLinkedResource<CrestMarketGroup> {
        public CrestMarketGroup() {
            Version = "application/vnd.ccp.eve.MarketGroup-v1+json";
        }

        [DataMember(Name = "name")]
        public string Blueprints { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "types")]
        public CrestHref<CrestMarketTypeCollection> Types { get; set; }
    }
}