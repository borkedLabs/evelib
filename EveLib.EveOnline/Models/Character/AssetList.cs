﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace eZet.EveLib.Modules.Models.Character {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class AssetList {


        [XmlElement("rowset")]
        public EveOnlineRowCollection<Item> Items { get; set; }

        public ICollection<Item> Flatten() {
            return flatten(Items);
        }

        private ICollection<Item> flatten(ICollection<Item> items) {
            var list = new List<Item>();
            var stack = new Stack<Item>(items);
            while (stack.Count > 0) {
                var current = stack.Pop();
                list.Add(current);
                foreach (var child in current.Items)
                    stack.Push(child);
            }
            return list;
        }
        
        [Serializable]
        [XmlRoot("row")]
        public class Item {
            [XmlAttribute("itemID")]
            public long ItemId { get; set; }

            [XmlAttribute("locationID")]
            public long LocationId { get; set; }

            [XmlAttribute("typeID")]
            public long TypeId { get; set; }

            [XmlAttribute("quantity")]
            public int Quantity { get; set; }

            [XmlAttribute("flag")]
            public int Flag { get; set; }

            [XmlAttribute("singleton")]
            public bool Singleton { get; set; }

            [XmlElement("rowset")]
            public EveOnlineRowCollection<Item> Items { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class Asset {
            [XmlAttribute("itemID")]
            public long ItemId { get; set; }

            [XmlAttribute("typeID")]
            public long TypeId { get; set; }

            [XmlAttribute("quantity")]
            public int Quantity { get; set; }

            [XmlAttribute("flag")]
            public int Flag { get; set; }

            [XmlAttribute("singleton")]
            public bool Singleton { get; set; }

            [XmlElement("rowset")]
            public EveOnlineRowCollection<Item> Items { get; set; }
        }
    }
}