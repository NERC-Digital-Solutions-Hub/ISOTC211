
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 05:46, @gisvlasta.
// Updated by        : 12/01/2023, 17:16, @gisvlasta.
//                     13/01/2023, 02:56, @gisvlasta.
// Version           : 1.0.2
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
// --------------------------------------------------------------------------------
// <attribute name="show">
//   <simpleType>
//     <restriction base="string">
//       <enumeration value="new"/>
//       <enumeration value="replace"/>
//       <enumeration value="embed"/>
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

namespace NDSH.Geospatial.Metadata.V2003.Thin.XLinks {

  /// <summary>
  /// 
  /// </summary>
  public interface IShow {

    /// <summary>
    ///   <para>
    ///     The Show attribute is used to communicate the desired presentation
    ///     of the ending resource on traversal from the starting resource.
    ///   </para>
    ///   <para>
    ///     Use the <see cref="ShowBehaviours"/> static property to access all valid string values
    ///     used in the <see cref="Show"/> property.
    ///     Select a valid value using as a key an <see cref="ShowBehaviour"/> enumerated value.
    ///   </para>
    ///   <para>
    ///   <b>Example:</b>
    ///   <example>
    ///     <code>
    ///       <see cref="Show"/> = <see cref="ShowBehaviours"/>[<see cref="ShowBehaviour.None"/>]
    ///     </code>
    ///   </example>
    ///   </para>
    /// </summary>
    //[XmlAttribute(AttributeName = "show", DataType = "string", Namespace = "http://www.w3.org/1999/xlink")]
    public string Show { // TODO: Make sure if a validation attribute can be addded here.
      get;
      set;
    }

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Show"/> property.
    /// </summary>
    /// <remarks>
    /// Implementations need to provide all the <see cref="string"/> representations
    /// of the <see cref="ShowBehaviour"/> enumeration values.
    /// </remarks>
    public static ReadOnlyDictionary<ShowBehaviour, string> ShowBehaviours =
      new ReadOnlyDictionary<ShowBehaviour, string>(new Dictionary<ShowBehaviour, string>(5) {
        { ShowBehaviour.New, ShowBehaviour.New.GetXmlEnumName() },
        { ShowBehaviour.Replace, ShowBehaviour.Replace.GetXmlEnumName() },
        { ShowBehaviour.Embed, ShowBehaviour.Embed.GetXmlEnumName() },
        { ShowBehaviour.Other, ShowBehaviour.Other.GetXmlEnumName() },
        { ShowBehaviour.None, ShowBehaviour.None.GetXmlEnumName() }
      });

  }

}
