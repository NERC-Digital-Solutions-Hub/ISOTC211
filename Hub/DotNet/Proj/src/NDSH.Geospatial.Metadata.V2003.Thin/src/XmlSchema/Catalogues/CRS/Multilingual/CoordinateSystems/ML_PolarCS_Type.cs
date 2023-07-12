﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 05/01/2023, 03:03, @gisvlasta.
// Updated by        : 10/01/2023, 20:29, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.GML.Coordinate.Systems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems
{

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("ML_PolarCS", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("ML_PolarCS", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("ML_PolarCS")]
  public class ML_PolarCS_Type : PolarCSType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="ML_PolarCS_Type"/>.
    /// </summary>
    public ML_PolarCS_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _alternativeExpression  = default; //  new List<CoordinateSystemAlt_PropertyType>();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public new XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private List<CoordinateSystemAlt_PropertyType> _alternativeExpression;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("alternativeExpression", Order = 0)]
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<CoordinateSystemAlt_PropertyType> AlternativeExpression {
      get {
        return _alternativeExpression;
      }
      set {
        if (_alternativeExpression == value) {
          return;
        }
        if (_alternativeExpression == null || _alternativeExpression.Equals(value) != true) {
          _alternativeExpression = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
