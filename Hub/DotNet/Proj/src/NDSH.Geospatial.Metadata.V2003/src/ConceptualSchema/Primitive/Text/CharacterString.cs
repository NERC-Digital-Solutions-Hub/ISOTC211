
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 13/02/2023, 03:15, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Common;
using NDSH.Geospatial.Metadata.V2003.Localisation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Text {

  // TODO: REMOVE CLASS !!!

  /// <summary>
  /// 
  /// </summary>
  //[TypeConverter(typeof(CharacterString_PropertyTypeConverter))]
  [XmlInclude(typeof(LanguageCodeProperty))]
  //[XmlInclude(typeof(LanguageCode_PropertyType))]
  //[XmlInclude(typeof(PT_FreeText_PropertyType))] // TODO: Check this include.
  [Serializable]
  [XmlType("CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
  [JsonObject("CharacterString")]
  public class CharacterString : NilReasonModel, IValue {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="CharacterString"/>.
    /// </summary>
    public CharacterString() {

    }

    /// <summary>
    /// Initializes the <see cref="CharacterString"/>.
    /// </summary>
    /// <param name="value">The <see cref="string"/> to set.</param>
    public CharacterString(string value) {
      this.Value = value;
    }

    #endregion

    #region Operator Overloading

    /// <summary>
    /// 
    /// </summary>
    /// <param name="characterString"></param>
    public static implicit operator string(CharacterString characterString) {
      return characterString.Value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    public static implicit operator CharacterString(string s) {
      return new CharacterString(s);
    }

    #endregion

    #region IValue Interface

    private string _value;

    /// <summary>
    /// 
    /// </summary>
    [XmlText(DataType = "string")]
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

  }

}
