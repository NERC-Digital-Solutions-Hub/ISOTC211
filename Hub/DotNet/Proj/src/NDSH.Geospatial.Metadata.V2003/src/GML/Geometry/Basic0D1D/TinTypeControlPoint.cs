﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.GML.Geometry.Basic0D1D {

  [Serializable]
  [XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TinTypeControlPoint")]
  public class TinTypeControlPoint : Model {
    #region Private fields
    private object _item;
    #endregion

    [XmlElement("pointProperty", typeof(PointPropertyType), Order = 0)]
    [XmlElement("pos", typeof(DirectPositionType), Order = 0)]
    [XmlElement("posList", typeof(DirectPositionListType), Order = 0)]
    public object Item {
      get {
        return _item;
      }
      set {
        if (_item == value) {
          return;
        }
        if (_item == null || _item.Equals(value) != true) {
          _item = value;
          OnPropertyChanged("Item");
        }
      }
    }
  }

}
