
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 30/12/2022, 20:43, @gisvlasta.
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
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.XLinks {

  /// <summary>
  /// 
  /// </summary>
  public interface IType {

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "type", DataType = "string", Namespace = "http://www.w3.org/1999/xlink", Form = XmlSchemaForm.Qualified)]
    public string Type {
      get;
    }

  }

}
