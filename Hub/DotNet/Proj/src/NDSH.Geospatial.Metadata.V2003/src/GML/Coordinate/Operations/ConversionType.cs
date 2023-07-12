﻿using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NDSH.Geospatial.Metadata.V2003.GML.Coordinate.Operations
{

  [XmlInclude(typeof(ML_Conversion_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("ConversionType")]
  public class ConversionType : AbstractGeneralConversionType
  {
    #region Private fields
    private OperationMethodPropertyType _method;
    private List<AbstractGeneralParameterValuePropertyType> _parameterValue;
    #endregion

    /// <summary>
    /// ConversionType class constructor
    /// </summary>
    public ConversionType()
    {
      _parameterValue = default; //  new List<AbstractGeneralParameterValuePropertyType>();
      _method = default; //  new OperationMethodPropertyType();
    }

    [XmlElement(Order = 0)]
    [JsonProperty("method", Order = 0)]
    public OperationMethodPropertyType method
    {
      get
      {
        return _method;
      }
      set
      {
        if (_method == value)
        {
          return;
        }
        if (_method == null || _method.Equals(value) != true)
        {
          _method = value;
          OnPropertyChanged("method");
        }
      }
    }

    [XmlElement("parameterValue", Order = 1)]
    [JsonProperty("parameterValue", Order = 1)]
    public List<AbstractGeneralParameterValuePropertyType> parameterValue
    {
      get
      {
        return _parameterValue;
      }
      set
      {
        if (_parameterValue == value)
        {
          return;
        }
        if (_parameterValue == null || _parameterValue.Equals(value) != true)
        {
          _parameterValue = value;
          OnPropertyChanged("parameterValue");
        }
      }
    }
  }

}