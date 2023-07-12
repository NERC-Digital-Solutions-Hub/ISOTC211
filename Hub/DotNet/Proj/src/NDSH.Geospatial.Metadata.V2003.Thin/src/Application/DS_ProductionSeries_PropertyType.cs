﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 29/12/2022, 17:36, @gisvlasta.
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.Application {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DS_ProductionSeries_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DS_ProductionSeries_PropertyType")]
  public class DS_ProductionSeries_PropertyType : ObjectReference_PropertyType {
    
    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DS_ProductionSeries_PropertyType"/>.
    /// </summary>
    public DS_ProductionSeries_PropertyType() {
      _ds_ProductionSeries  = default; //  new DS_ProductionSeries_Type();
    }

    #endregion

    #region Public Properties

    private DS_ProductionSeries_Type _ds_ProductionSeries;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DS_ProductionSeries", Order = 0)]
    [JsonProperty("DS_ProductionSeries", Order = 0)]
    public DS_ProductionSeries_Type DS_ProductionSeries {
      get {
        return _ds_ProductionSeries;
      }
      set {
        if (_ds_ProductionSeries == value) {
          return;
        }
        if (_ds_ProductionSeries == null || _ds_ProductionSeries.Equals(value) != true) {
          _ds_ProductionSeries = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}