﻿
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 16/12/2022, 19:17, @gisvlasta - Cleaned Xml Serialization Attributes.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Common.Citation {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlRoot("CI_RoleCode", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [XmlType("CI_RoleCode", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("CI_RoleCode")]
  public class CI_RoleCode : Model {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CI_RoleCode"/>.
    /// </summary>
    public CI_RoleCode() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmd", "http://www.isotc211.org/2005/gmd");

      _value = default; // TODO: is this correct?

    }

    #endregion

    #region Private fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region Public Properties

    private CI_RoleCodeValue _value;
    
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "value")]
    [JsonProperty("value")]
    [JsonConverter(typeof(StringEnumConverter))]
    public CI_RoleCodeValue Value {
      get {
        return _value;
      }
      set {
        if (_value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion
    
  }

}
