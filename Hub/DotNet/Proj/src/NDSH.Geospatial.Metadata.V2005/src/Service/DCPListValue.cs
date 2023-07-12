﻿
#region Header
// Title Name        : 
// Member of         : NDSH.Geospatial.Metadata.V2005.dll
// Description       : 
// Created by        : 08/11/2022, 22:00, @gisvlasta.
// Updated by        : 17/12/2022, 03:14, @gisvlasta - Cleaned Xml Serialization Attributes.
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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2005.Service {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  public enum DCPListValue {

    // TODO: Make sure what are the actual enum values (check spec)

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "COM")]
    [EnumMember(Value = "COM")]
    COM,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "CORBA")]
    [EnumMember(Value = "CORBA")]
    CORBA,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "JAVA")]
    [EnumMember(Value = "JAVA")]
    JAVA,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "SQL")]
    [EnumMember(Value = "SQL")]
    SQL,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "WebServices")]
    [EnumMember(Value = "WebServices")]
    WebServices,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "XML")]
    [EnumMember(Value = "XML")]
    XML,

  }

}
