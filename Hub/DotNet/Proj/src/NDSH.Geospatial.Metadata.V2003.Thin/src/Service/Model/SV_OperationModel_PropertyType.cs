﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 15/01/2023, 19:42, @gisvlasta.
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.Service.Model {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("SV_OperationModel_PropertyType", Namespace = "http://www.isotc211.org/2005/srv")]
  [JsonObject("SV_OperationModel_PropertyType")]
  public class SV_OperationModel_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="SV_OperationModel_PropertyType"/>.
    /// </summary>
    public SV_OperationModel_PropertyType() {
      _sv_OperationModel = new SV_OperationModel_Type();
    }

    #endregion

    #region Public Properties

    private SV_OperationModel_Type _sv_OperationModel;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SV_OperationModel", Order = 0)]
    [JsonProperty("SV_OperationModel", Order = 0)]
    public SV_OperationModel_Type SV_OperationModel {
      get {
        return _sv_OperationModel;
      }
      set {
        if (_sv_OperationModel == value) {
          return;
        }
        if (_sv_OperationModel.Equals(value) != true) {
          _sv_OperationModel = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
