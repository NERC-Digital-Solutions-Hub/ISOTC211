﻿
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 02/01/2023, 23:37, @gisvlasta.
// Updated by        : 13/01/2023, 15:29, @gisvlasta.
// Version           : 1.0.1
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/basicTypes.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="RecordType_Type">
//   <xs:simpleContent>
//     <xs:extension base="xs:string">
//       <xs:attributeGroup ref="xlink:simpleLink"/>
//     </xs:extension>
//  </xs:simpleContent>
// </xs:complexType>
// <xs:element name="RecordType" type="gco:RecordType_Type"/>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Properties;
using NDSH.Geospatial.Metadata.V2003.Thin.XLinks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Records {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("RecordType", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("RecordType")]
  public class RecordType_Type : Model, ISimpleLink {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="RecordType_Type"/>.
    /// </summary>
    public RecordType_Type() {
      //_type  = default; //  "simple"; // TODO: Should the value of the Type property be: "simple"???
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Actuate"/> property.
    /// </summary>
    public static ReadOnlyDictionary<ActuateBehaviour, string> ActuateBehaviours {
      get {
        return ISimpleLink.ActuateBehaviours;
      }
    }

    /// <summary>
    /// Gets the dictionary of all the valid strings used in the <see cref="Show"/> property.
    /// </summary>
    public static ReadOnlyDictionary<ShowBehaviour, string> ShowBehaviours {
      get {
        return ISimpleLink.ShowBehaviours;
      }
    }

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText]
    [JsonProperty("Value")]
    public string Value {
      get {
        return _value;
      }
      set {
        if (_value == value) {
          return;
        }
        if (_value == null || _value.Equals(value) != true) {
          _value = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

    #region ISimpleLink Interface

    //private string _type;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "type", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    public string Type {
      get {
        return "simple";
      }
      //set {
      //  if (_type == value) {
      //    return;
      //  }
      //  if (_type == null || _type.Equals(value) != true) {
      //    _type = value;
      //    OnPropertyChanged();
      //  }
      //}
    }

    private string _href;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "href", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
    [JsonProperty("href")]
    public string Href {
      get {
        return _href;
      }
      set {
        if (_href == value) {
          return;
        }
        if (_href == null || _href.Equals(value) != true) {
          _href = value;
          OnPropertyChanged();
        }
      }
    }

    private string _role;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "role", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
    public string Role {
      get {
        return _role;
      }
      set {
        if (_role == value) {
          return;
        }
        if (_role == null || _role.Equals(value) != true) {
          _role = value;
          OnPropertyChanged();
        }
      }
    }

    private string _arcrole;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "arcrole",  Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink", DataType = "anyURI")]
    [JsonProperty("arcrole")]
    public string ArcRole {
      get {
        return _arcrole;
      }
      set {
        if (_arcrole == value) {
          return;
        }
        if (_arcrole == null || _arcrole.Equals(value) != true) {
          _arcrole = value;
          OnPropertyChanged();
        }
      }
    }

    private string _title;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(AttributeName = "title", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    public string Title {
      get {
        return _title;
      }
      set {
        if (_title == value) {
          return;
        }
        if (_title == null || _title.Equals(value) != true) {
          _title = value;
          OnPropertyChanged();
        }
      }
    }

    private string _show;

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
    /// <exception cref="Exception">
    /// The exception is thrown when the property is attempted to be set to a <see cref="string"/>
    /// value that is not in the list of the accepted values.
    /// </exception>
    [XmlAttribute(AttributeName = "show", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("show")]
    public string Show {
      get {
        return _show;
      }
      set {
        if (_show == value) {
          return;
        }
        if (_show == null || _show.Equals(value) != true) {
          if (!IShow.ShowBehaviours.Values.ToList().Contains(value)) {
            throw new Exception(Resources.StringNotMemberOfEnumeration);
          }
          _show = value;
          OnPropertyChanged();
        }
      }
    }

    private string _actuate;

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
    /// <exception cref="Exception">
    /// The exception is thrown when the property is attempted to be set to a <see cref="string"/>
    /// value that is not in the list of the accepted values.
    /// </exception>
    [XmlAttribute("actuate", DataType = "string", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
    [JsonProperty("actuate")]
    public string Actuate {
      get {
        return _actuate;
      }
      set {
        if (_actuate == value) {
          return;
        }
        if (_actuate == null || _actuate.Equals(value) != true) {
          if (!IActuate.ActuateBehaviours.Values.ToList().Contains(value)) {
            throw new Exception(Resources.StringNotMemberOfEnumeration);
          }
          _actuate = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
