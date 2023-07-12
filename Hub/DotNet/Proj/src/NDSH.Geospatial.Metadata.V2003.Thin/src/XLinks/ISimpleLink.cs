
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 20:44, @gisvlasta.
// Updated by        : 11/01/2023, 00:43, @gisvlasta.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
// --------------------------------------------------------------------------------
// <attribute name="href" type="anyURI"/>
// <attribute name="role" type="anyURI"/>
// <attribute name="arcrole" type="anyURI"/>
// <attribute name="title" type="string"/>
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
// <attributeGroup name="simpleLink">
//   <attribute name="type" type="string" fixed="simple" form="qualified"/>
//   <attribute ref="xlink:href" use="optional"/>
//   <attribute ref="xlink:role" use="optional"/>
//   <attribute ref="xlink:arcrole" use="optional"/>
//   <attribute ref="xlink:title" use="optional"/>
//   <attribute ref="xlink:show" use="optional"/>
//   <attribute ref="xlink:actuate" use="optional"/>
// </attributeGroup>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
  public interface ISimpleLink : IType, IHref, IRole, IArcRole, ITitle, IShow, IActuate {

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(AttributeName = "type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    public new string Type { // TODO: How can this be used in all derived implementations?
      get { 
        return "simple";
      }
    }

  }

}
