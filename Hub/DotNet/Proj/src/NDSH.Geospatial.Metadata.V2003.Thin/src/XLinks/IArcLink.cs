
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 06:17, @gisvlasta.
// Updated by        : 12/01/2023, 00:46, @gisvlasta.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
// <attribute name="arcrole" type="anyURI"/>
// <attribute name="title" type="string"/>
// <attribute name="from" type="string"/>
// <attribute name="to" type="string"/>
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
// <attributeGroup name="arcLink">
//   <attribute name="type" type="string" fixed="arc" form="qualified"/>
//   <attribute ref="xlink:arcrole" use="optional"/>
//   <attribute ref="xlink:title" use="optional"/>
//   <attribute ref="xlink:show" use="optional"/>
//   <attribute ref="xlink:actuate" use="optional"/>
//   <attribute ref="xlink:from" use="optional"/>
//   <attribute ref="xlink:to" use="optional"/>
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
  public interface IArcLink : IType, IArcRole, ITitle, IShow, IActuate, IFrom, ITo {

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(AttributeName = "type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    public new string Type { // TODO: How can this be used in all derived implementations?
      get {
        return "arc";
      }
    }

  }

}
