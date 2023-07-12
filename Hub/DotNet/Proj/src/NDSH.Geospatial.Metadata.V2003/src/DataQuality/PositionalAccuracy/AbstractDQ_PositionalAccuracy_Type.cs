﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 22/12/2022, 20:49, @gisvlasta.
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
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.DataQuality.PositionalAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
  [XmlInclude(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
  [XmlInclude(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
  [XmlType("AbstractDQ_PositionalAccuracy", Namespace = "http://www.isotc211.org/2005/gmd")]
  [XmlRoot("AbstractDQ_PositionalAccuracy", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
  [JsonObject("AbstractDQ_PositionalAccuracy")]
  public abstract class AbstractDQ_PositionalAccuracy_Type : AbstractDQ_Element_Type {

  }

}