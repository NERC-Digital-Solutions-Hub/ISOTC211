
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 18:56, @gisvlasta.
// Updated by        : 11/01/2023, 18:24, @gisvlasta.
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
// <attribute name="role" type="anyURI"/>
// <attribute name="title" type="string"/>
// <attribute name="label" type="string"/>
// <attributeGroup name="resourceLink">
//   <attribute name="type" type="string" fixed="resource" form="qualified"/>
//   <attribute ref="xlink:role" use="optional"/>
//   <attribute ref="xlink:title" use="optional"/>
//   <attribute ref="xlink:label" use="optional"/>
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

namespace NDSH.Geospatial.Metadata.V2003.XLinks {

  /// <summary>
  /// 
  /// </summary>
  public interface IResourceLink : IType, IRole, ITitle, ILabel {

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(AttributeName = "type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    public new string Type { // TODO: How can this be used in all derived implementations?
      get {
        return "resource";
      }
    }

  }

}
