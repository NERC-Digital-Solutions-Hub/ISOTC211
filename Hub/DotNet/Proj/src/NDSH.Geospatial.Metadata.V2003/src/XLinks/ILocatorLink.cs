﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 06:10, @gisvlasta.
// Updated by        : 12/01/2023, 00:42, @gisvlasta.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
// <attribute name="href" type="anyURI"/>
// <attribute name="role" type="anyURI"/>
// <attribute name="title" type="string"/>
// <attribute name="label" type="string"/>
// <attributeGroup name="locatorLink">
//   <attribute name="type" type="string" fixed="locator" form="qualified"/>
//   <attribute ref="xlink:href" use="required"/>
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
using System.ComponentModel.DataAnnotations;
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
  public interface ILocatorLink : IType, IHref, IRole, ITitle, ILabel {

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(AttributeName = "type", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    public new string Type { // TODO: How can this be used in all derived implementations?
      get {
        return "locator";
      }
    }

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(AttributeName = "href", DataType = "anyURI", Namespace = "http://www.w3.org/1999/xlink")]
    [Required()]
    public new string Href {
      get;
      set;
    }

  }

}
