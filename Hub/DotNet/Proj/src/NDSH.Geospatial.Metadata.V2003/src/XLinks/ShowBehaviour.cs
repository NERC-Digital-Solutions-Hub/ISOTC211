﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 20:56, @gisvlasta.
// Updated by        : 11/01/2023, 18:31, @gisvlasta. - 1.0.1 - Renamed to ShowBehaviour.
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// XSD               : /2005/xlink/xlinks.xsd
// --------------------------------------------------------------------------------
// <annotation>
//   <documentation>
//     The 'show' attribute is used to communicate the desired presentation 
//     of the ending resource on traversal from the starting resource; it's 
//     value should be treated as follows: 
//     new - load ending resource in a new window, frame, pane, or other 
//     presentation context
//     replace - load the resource in the same window, frame, pane, or 
//               other presentation context
//     embed - load ending resource in place of the presentation of the 
//             starting resource
//     other - behavior is unconstrained; examine other markup in the 
//             link for hints 
//     none - behavior is unconstrained 
//   </documentation>
// </annotation>
// <simpleType>
//   <restriction base="string">
//     <enumeration value="new"/>
//     <enumeration value="replace"/>
//     <enumeration value="embed"/>
//     <enumeration value="other"/>
//     <enumeration value="none"/>
//   </restriction>
// </simpleType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XLinks {

  /// <summary>
  /// The enumeration of the values of the 'show' behaviour which is used
  /// to communicate the desired presentation of the ending resource on
  /// traversal from the starting resource.
  /// </summary>
  [Serializable]
  [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/1999/xlink")] // TODO: Should this have a TypeName???
  public enum ShowBehaviour {

    /// <summary>
    /// Load ending resource in a new window, frame, pane, or other presentation context.
    /// </summary>
    [XmlEnum(Name = "new")]
    [EnumMember(Value = "new")]
    New = 0,

    /// <summary>
    /// Load the resource in the same window, frame, pane, or other presentation context.
    /// </summary>
    [XmlEnum(Name = "replace")]
    [EnumMember(Value = "replace")]
    Replace = 1,

    /// <summary>
    /// Load ending resource in place of the presentation of the starting resource.
    /// </summary>
    [XmlEnum(Name = "embed")]
    [EnumMember(Value = "embed")]
    Embed = 2,

    /// <summary>
    /// Behavior is unconstrained; examine other markup in the link for hints.
    /// </summary>
    [XmlEnum(Name = "other")]
    [EnumMember(Value = "other")]
    Other = 3,

    /// <summary>
    /// Behavior is unconstrained.
    /// </summary>
    [XmlEnum(Name = "none")]
    [EnumMember(Value = "none")]
    None = 4,

  }

}
