﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 15:13, @gisvlasta.
// Updated by        : 10/01/2023, 02:03, @gisvlasta. - 1.0.1: Added xmlns field.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Localisation;
using NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual {

  /// <summary>
  /// 
  /// </summary>
  /// <remarks>
  /// XML attributes contraints: - 1) Id is mandatory - 2) codeSpace (type xsd:anyURI) is mandatory
  /// </remarks>
  [Serializable]
  [XmlType("CrsAlt", Namespace = "http://www.isotc211.org/2005/gmx")]
  [XmlRoot("CrsAlt", Namespace = "http://www.isotc211.org/2005/gmx", IsNullable = false)]
  [JsonObject("CrsAlt")]
  public class CrsAlt_Type : AbstractCRSType, IAlternative {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CrsAlt_Type"/>.
    /// </summary>
    public CrsAlt_Type() {

      xmlns = new XmlSerializerNamespaces();
      xmlns.Add("gmx", "http://www.isotc211.org/2005/gmx");

      _locale  = default; //  new PT_Locale_PropertyType();

    }

    #endregion

    #region Public Fields

    /// <summary>
    /// 
    /// </summary>
    [XmlNamespaceDeclarations()]
    public XmlSerializerNamespaces xmlns;

    #endregion

    #region IAlternative Interface

    private PT_Locale_PropertyType _locale;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("locale", Order = 0)]
    [JsonProperty("locale", Order = 0)]
    public PT_Locale_PropertyType Locale { // TODO: Compare with CodeListValue_Type - Extract Interface???
      get {
        return _locale;
      }
      set {
        if (_locale == value) {
          return;
        }
        if (_locale == null || _locale.Equals(value) != true) {
          _locale = value;
          OnPropertyChanged();
        }
      }
    }

    private string _codeSpace;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("codeSpace", DataType = "anyURI")]
    [JsonProperty("codeSpace")]
    [Required()] // TODO: codeSpace (type xsd:anyURI) is mandatory - Should this be in the interface?
    public string CodeSpace { // TODO: Compare with CodeListValue_Type - Extract Interface???
      get {
        return _codeSpace;
      }
      set {
        if (_codeSpace == value) {
          return;
        }
        if (_codeSpace == null || _codeSpace.Equals(value) != true) {
          _codeSpace = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
