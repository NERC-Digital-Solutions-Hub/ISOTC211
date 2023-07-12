﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 06/01/2023, 19:41, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums {
  
  /// <summary>
  /// 
  /// </summary>
  public interface IEllipsoidsAlternativeExpression {

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("alternativeExpression", Order = 0)] // TODO: Should [XmlElement be in this interface???
    [JsonProperty("alternativeExpression", Order = 0)]
    public List<EllipsoidAlt_PropertyType> AlternativeExpression {
      get;
      set;
    }

  }

}