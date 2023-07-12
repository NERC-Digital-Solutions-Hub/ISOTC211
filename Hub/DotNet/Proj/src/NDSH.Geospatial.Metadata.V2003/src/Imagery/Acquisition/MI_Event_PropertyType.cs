
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 25/01/2023, 23:38, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          :
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Imagery.Acquisition {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("MI_Event_PropertyType", Namespace = "http://www.isotc211.org/2005/gmi")]
  [JsonObject("MI_Event_PropertyType")]
  public class MI_Event_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="MI_Event_PropertyType"/>.
    /// </summary>
    public MI_Event_PropertyType() {
      _mi_Event = default; // new MI_Event_Type();
    }

    #endregion

    #region Public Properties

    private MI_Event_Type _mi_Event;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MI_Event", Order = 0)]
    [JsonProperty("MI_Event", Order = 0)]
    public MI_Event_Type MI_Event {
      get {
        return _mi_Event;
      }
      set {
        if (_mi_Event == value) {
          return;
        }
        if (_mi_Event == null || _mi_Event.Equals(value) != true) {
          _mi_Event = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
