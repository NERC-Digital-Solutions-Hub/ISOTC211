﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 14/01/2023, 02:53, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using NDSH.Geospatial.Metadata.V2003.Thin.Service.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_CouplingType_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_CouplingType_PropertyType")]
  public class SV_CouplingType_PropertyType : NilReasonModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_CouplingType_PropertyType"/>.
    /// </summary>
    public SV_CouplingType_PropertyType() {
      _sv_CouplingType = new CodeListValue_Type();
    }

    #endregion

    #region Public Properties

    private CodeListValue_Type _sv_CouplingType;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_ServiceType", Order = 0)]
    [JsonProperty("SV_ServiceType", Order = 0)]
    public CodeListValue_Type SV_ServiceType {
      get {
        return _sv_CouplingType;
      }
      set {
        if (_sv_CouplingType == value) {
          return;
        }
        if (_sv_CouplingType == null || _sv_CouplingType.Equals(value) != true) {
          _sv_CouplingType = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}