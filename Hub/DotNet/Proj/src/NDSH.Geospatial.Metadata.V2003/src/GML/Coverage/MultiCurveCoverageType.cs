
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

namespace NDSH.Geospatial.Metadata.V2003.GML.Coverage {


  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml")]
  [JsonObject("MultiCurveCoverageType")]
  public class MultiCurveCoverageType : AbstractDiscreteCoverageType {
  }
}