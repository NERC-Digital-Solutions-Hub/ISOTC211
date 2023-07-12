
using NDSH.Geospatial.Metadata.V2003.GML.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NDSH.Geospatial.Metadata.V2003.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems;

namespace NDSH.Geospatial.Metadata.V2003.GML.Coordinate.Systems
{

  [XmlInclude(typeof(ML_TimeCS_Type))] // GMX
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("TimeCSType")]
  public class TimeCSType : AbstractCoordinateSystemType
  {
  }
}