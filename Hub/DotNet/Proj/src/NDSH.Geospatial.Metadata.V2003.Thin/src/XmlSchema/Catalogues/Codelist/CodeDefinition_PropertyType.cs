﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 04/01/2023, 16:36, @gisvlasta.
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("CodeDefinition_PropertyType", Namespace = "http://www.isotc211.org/2005/gmx")]
  [JsonObject("CodeDefinition_PropertyType")]
  public class CodeDefinition_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CodeDefinition_PropertyType"/>.
    /// </summary>
    public CodeDefinition_PropertyType() {
      _codeDefinition  = default; //  new CodeDefinition_Type();
    }

    #endregion

    #region Public Proeprties

    private CodeDefinition_Type _codeDefinition;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CodeDefinition", Order = 0)]
    [JsonProperty("CodeDefinition", Order = 0)]
    public CodeDefinition_Type CodeDefinition {
      get {
        return _codeDefinition;
      }
      set {
        if (_codeDefinition == value) {
          return;
        }
        if (_codeDefinition == null || _codeDefinition.Equals(value) != true) {
          _codeDefinition = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
