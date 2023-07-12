﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 28/12/2022, 18:57, @gisvlasta.
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
using NDSH.Geospatial.Metadata.V2003.GML.Units;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Derived.UnitsOfMeasure {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("UomLength_PropertyType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("UomLength_PropertyType")]
  public class UomLength_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UomLength_PropertyType"/>..
    /// </summary>
    public UomLength_PropertyType() {
      _unitDefinition  = default; //  new UnitDefinitionType();
    }

    #endregion

    #region Public Properties

    private UnitDefinitionType _unitDefinition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UnitDefinition", Namespace = "http://www.opengis.net/gml", Order = 0)]
    [JsonProperty("UnitDefinition", Order = 0)]
    public UnitDefinitionType UnitDefinition {
      get {
        return _unitDefinition;
      }
      set {
        if (_unitDefinition == value) {
          return;
        }
        if (_unitDefinition == null || _unitDefinition.Equals(value) != true) {
          _unitDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}