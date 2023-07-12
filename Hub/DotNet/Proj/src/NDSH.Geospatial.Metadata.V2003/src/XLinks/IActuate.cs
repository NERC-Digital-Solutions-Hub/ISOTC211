
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 05:46, @gisvlasta.
// Updated by        : 12/01/2023, 17:16, @gisvlasta.
//                     13/01/2023, 02:53, @gisvlasta.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
// --------------------------------------------------------------------------------
// <attribute name="actuate">
//   <simpleType>
//     <restriction base="string">
//       <enumeration value="onLoad"/>
//       <enumeration value="onRequest"/>
//       <enumeration value="other"/>
//       <enumeration value="none"/>
//     </restriction>
//   </simpleType>
// </attribute>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XLinks {

  /// <summary>
  /// 
  /// </summary>
  public interface IActuate {

    /// <summary>
    ///   <para>
    ///     The Actuate attribute is used to communicate the desired timing of traversal
    ///     from the starting resource to the ending resource.
    ///   </para>
    ///   <para>
    ///     Use the <see cref="ActuateBehaviours"/> static property to access all valid string values
    ///     used in the <see cref="Actuate"/> property.
    ///     Select a valid value using as a key an <see cref="ActuateBehaviour"/> enumerated value.
    ///   </para>
    ///   <para>
    ///   <b>Example:</b>
    ///   <example>
    ///     <code>
    ///       <see cref="Actuate"/> = <see cref="ActuateBehaviours"/>[<see cref="ActuateBehaviour.None"/>]
    ///     </code>
    ///   </example>
    ///   </para>
    /// </summary>
    //[XmlAttribute(AttributeName = "actuate", DataType = "string", Namespace = "http://www.w3.org/1999/xlink")]
    public string Actuate {
      get;
      set;
    }

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Actuate"/> property.
    /// </summary>
    /// <remarks>
    /// Implementations need to provide all the <see cref="string"/> representations
    /// of the <see cref="ActuateBehaviour"/> enumeration values.
    /// </remarks>
    public static ReadOnlyDictionary<ActuateBehaviour, string> ActuateBehaviours =
      new ReadOnlyDictionary<ActuateBehaviour, string>(new Dictionary<ActuateBehaviour, string>(4) {
        { ActuateBehaviour.OnLoad, ActuateBehaviour.OnLoad.GetXmlEnumName() },
        { ActuateBehaviour.OnRequest, ActuateBehaviour.OnRequest.GetXmlEnumName() },
        { ActuateBehaviour.Other, ActuateBehaviour.Other.GetXmlEnumName() },
        { ActuateBehaviour.None,ActuateBehaviour.None.GetXmlEnumName() }
      });

  }

}
