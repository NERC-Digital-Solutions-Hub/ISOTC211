﻿
#region Header
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 23/12/2022, 01:49, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
#endregion

#region Imported Namespaces

using NDSH.Geospatial.Metadata.V2003.Thin.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.TemporalAccuracy {

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlType("DQ_TemporalConsistency_PropertyType", Namespace = "http://www.isotc211.org/2005/gmd")]
  [JsonObject("DQ_TemporalConsistency_PropertyType")]
  public class DQ_TemporalConsistency_PropertyType : ObjectReference_PropertyType {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="DQ_TemporalConsistency_PropertyType"/>.
    /// </summary>
    public DQ_TemporalConsistency_PropertyType()
    {
      _dq_TemporalConsistency = new DQ_TemporalConsistency_Type();
    }

    #endregion

    #region Public Properties

    private DQ_TemporalConsistency_Type _dq_TemporalConsistency;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DQ_TemporalConsistency", Order = 0)]
    [JsonProperty("DQ_TemporalConsistency", Order = 0)]
    public DQ_TemporalConsistency_Type DQ_TemporalConsistency
    {
      get
      {
        return _dq_TemporalConsistency;
      }
      set
      {
        if (_dq_TemporalConsistency == value)
        {
          return;
        }
        if (_dq_TemporalConsistency == null || _dq_TemporalConsistency.Equals(value) != true)
        {
          _dq_TemporalConsistency = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}
