
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 05:52, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/xlink/xlinks.xsd
// --------------------------------------------------------------------------------
// <attribute name="title" type="string"/>
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
  public interface ITitle {

    /// <summary>
    /// 
    /// </summary>
    //[XmlAttribute(AttributeName = "title", DataType = "string", Namespace = "http://www.w3.org/1999/xlink")]
    public string Title {
      get;
      set;
    }
    
  }

}
