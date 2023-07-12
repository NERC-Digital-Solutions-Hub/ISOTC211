
#region Header
// --------------------------------------------------------------------------------
// Title Name        : 
// Member of         : 
// Description       : 
// Created by        : 20/12/2022, 22:16, @gisvlasta.
// Updated by        : 
// Version           : 1.0.0
// GitHub Repository : https://github.com/UoMResearchIT/nerc-digital-solutions-hub
// License           : MIT Licence
// Copyright         : 
//
// Comments          : 
// --------------------------------------------------------------------------------
// XSD               : /2005/gco/gcoBase.xsd
// --------------------------------------------------------------------------------
// <xs:complexType name="AbstractObject_Type" abstract="true">
//   <xs:sequence/>
//   <xs:attributeGroup ref="gco:ObjectIdentification"/>
// </xs:complexType>
// --------------------------------------------------------------------------------
#endregion

#region Imported Namespaces

using AAAA;
using NDSH.Geospatial.Metadata.V2003.Application;
using NDSH.Geospatial.Metadata.V2003.ApplicationSchema;
using NDSH.Geospatial.Metadata.V2003.Common.Citation;
using NDSH.Geospatial.Metadata.V2003.Common.Extent;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Implementation.Names;
using NDSH.Geospatial.Metadata.V2003.ConceptualSchema.Primitive.Multiplicities;
using NDSH.Geospatial.Metadata.V2003.Constraint;
using NDSH.Geospatial.Metadata.V2003.Content;
using NDSH.Geospatial.Metadata.V2003.DataQuality;
using NDSH.Geospatial.Metadata.V2003.DataQuality.Completeness;
using NDSH.Geospatial.Metadata.V2003.DataQuality.Lineage;
using NDSH.Geospatial.Metadata.V2003.DataQuality.LogicalConsistency;
using NDSH.Geospatial.Metadata.V2003.DataQuality.PositionalAccuracy;
using NDSH.Geospatial.Metadata.V2003.DataQuality.TemporalAccuracy;
using NDSH.Geospatial.Metadata.V2003.DataQuality.ThematicAccuracy;
using NDSH.Geospatial.Metadata.V2003.Distribution;
using NDSH.Geospatial.Metadata.V2003.EntitySet;
using NDSH.Geospatial.Metadata.V2003.Extension;
using NDSH.Geospatial.Metadata.V2003.Identification;
using NDSH.Geospatial.Metadata.V2003.Localisation;
using NDSH.Geospatial.Metadata.V2003.Maintenance;
using NDSH.Geospatial.Metadata.V2003.PortrayalCatalogue;
using NDSH.Geospatial.Metadata.V2003.ReferenceSystem;
using NDSH.Geospatial.Metadata.V2003.Service;
using NDSH.Geospatial.Metadata.V2003.SpatialRepresentation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

#endregion

namespace NDSH.Geospatial.Metadata.V2003.Common {

  // TODO: IMPORTANT !!! - Remove this class from the project.
  // TODO: !!! DANGER !!! - Uncomment these XmlIncludes !!!

  /// <summary>
  /// 
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(MD_Metadata_Type))]
  
  //[XmlInclude(typeof(MultiplicityRange_Type))]
  //[XmlInclude(typeof(Multiplicity_Type))]
  //[XmlInclude(typeof(DS_DataSet_Type))]
  //[XmlInclude(typeof(AbstractDS_Aggregate_Type))]
  //[XmlInclude(typeof(DS_Initiative_Type))]
  //[XmlInclude(typeof(DS_Series_Type))]
  //[XmlInclude(typeof(DS_ProductionSeries_Type))]
  //[XmlInclude(typeof(DS_Sensor_Type))]
  //[XmlInclude(typeof(DS_Platform_Type))]
  //[XmlInclude(typeof(DS_OtherAggregate_Type))]
  //[XmlInclude(typeof(DS_StereoMate_Type))]
  //[XmlInclude(typeof(PT_Locale_Type))]
  //[XmlInclude(typeof(DQ_Scope_Type))]
  //[XmlInclude(typeof(DQ_DataQuality_Type))]
  //[XmlInclude(typeof(LI_Lineage_Type))]
  //[XmlInclude(typeof(LI_Source_Type))]
  //[XmlInclude(typeof(LI_ProcessStep_Type))]
  //[XmlInclude(typeof(DS_Association_Type))]
  //[XmlInclude(typeof(MD_RepresentativeFraction_Type))]
  //[XmlInclude(typeof(MD_AggregateInformation_Type))]
  //[XmlInclude(typeof(MD_Usage_Type))]
  //[XmlInclude(typeof(MD_Keywords_Type))]
  //[XmlInclude(typeof(MD_BrowseGraphic_Type))]
  //[XmlInclude(typeof(AbstractMD_Identification_Type))]
  //[XmlInclude(typeof(MD_ServiceIdentification_Type))]
  //[XmlInclude(typeof(MD_DataIdentification_Type))]
  //[XmlInclude(typeof(MD_MaintenanceInformation_Type))]
  //[XmlInclude(typeof(MD_Distribution_Type))]
  //[XmlInclude(typeof(MD_Format_Type))]
  //[XmlInclude(typeof(MD_Distributor_Type))]
  //[XmlInclude(typeof(MD_StandardOrderProcess_Type))]
  //[XmlInclude(typeof(MD_DigitalTransferOptions_Type))]
  //[XmlInclude(typeof(MD_Medium_Type))]
  //[XmlInclude(typeof(MD_Constraints_Type))]
  //[XmlInclude(typeof(MD_SecurityConstraints_Type))]
  //[XmlInclude(typeof(MD_LegalConstraints_Type))]
  //[XmlInclude(typeof(MD_PortrayalCatalogueReference_Type))]
  //[XmlInclude(typeof(MD_ApplicationSchemaInformation_Type))]
  //[XmlInclude(typeof(TypeName_Type))]
  //[XmlInclude(typeof(MemberName_Type))]
  //[XmlInclude(typeof(MD_RangeDimension_Type))]
  //[XmlInclude(typeof(MD_Band_Type))]
  //[XmlInclude(typeof(AbstractMD_ContentInformation_Type))]
  //[XmlInclude(typeof(MD_CoverageDescription_Type))]
  //[XmlInclude(typeof(MD_ImageDescription_Type))]
  //[XmlInclude(typeof(MD_FeatureCatalogueDescription_Type))]
  //[XmlInclude(typeof(MD_MetadataExtensionInformation_Type))]
  //[XmlInclude(typeof(MD_ExtendedElementInformation_Type))]
  //[XmlInclude(typeof(MD_GeometricObjects_Type))]
  //[XmlInclude(typeof(MD_Dimension_Type))]
  //[XmlInclude(typeof(AbstractMD_SpatialRepresentation_Type))]
  //[XmlInclude(typeof(MD_VectorSpatialRepresentation_Type))]
  //[XmlInclude(typeof(MD_GridSpatialRepresentation_Type))]
  //[XmlInclude(typeof(MD_Georectified_Type))]
  //[XmlInclude(typeof(MD_Georeferenceable_Type))]
  //[XmlInclude(typeof(AbstractRS_ReferenceSystem_Type))]
  //[XmlInclude(typeof(MD_ReferenceSystem_Type))]
  //[XmlInclude(typeof(AbstractDQ_Result_Type))]
  //[XmlInclude(typeof(DQ_QuantitativeResult_Type))]
  //[XmlInclude(typeof(DQ_ConformanceResult_Type))]
  //[XmlInclude(typeof(AbstractDQ_Element_Type))]
  //[XmlInclude(typeof(AbstractDQ_Completeness_Type))]
  //[XmlInclude(typeof(DQ_CompletenessCommission_Type))]
  //[XmlInclude(typeof(DQ_CompletenessOmission_Type))]
  //[XmlInclude(typeof(AbstractDQ_LogicalConsistency_Type))]
  //[XmlInclude(typeof(DQ_ConceptualConsistency_Type))]
  //[XmlInclude(typeof(DQ_DomainConsistency_Type))]
  //[XmlInclude(typeof(DQ_FormatConsistency_Type))]
  //[XmlInclude(typeof(DQ_TopologicalConsistency_Type))]
  //[XmlInclude(typeof(AbstractDQ_PositionalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
  //[XmlInclude(typeof(AbstractDQ_ThematicAccuracy_Type))]
  //[XmlInclude(typeof(DQ_ThematicClassificationCorrectness_Type))]
  //[XmlInclude(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
  //[XmlInclude(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
  //[XmlInclude(typeof(AbstractDQ_TemporalAccuracy_Type))]
  //[XmlInclude(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
  //[XmlInclude(typeof(DQ_TemporalConsistency_Type))]
  //[XmlInclude(typeof(DQ_TemporalValidity_Type))]
  //[XmlInclude(typeof(CI_Series_Type))]
  //[XmlInclude(typeof(CI_OnlineResource_Type))]
  //[XmlInclude(typeof(CI_Address_Type))]
  //[XmlInclude(typeof(CI_Telephone_Type))]
  //[XmlInclude(typeof(CI_Contact_Type))]
  //[XmlInclude(typeof(CI_ResponsibleParty_Type))]
  //[XmlInclude(typeof(CI_Date_Type))]
  //[XmlInclude(typeof(CI_Citation_Type))]
  //[XmlInclude(typeof(MD_Identifier_Type))]
  //[XmlInclude(typeof(RS_Identifier_Type))]
  //[XmlInclude(typeof(AbstractEX_GeographicExtent_Type))]
  //[XmlInclude(typeof(EX_GeographicDescription_Type))]
  //[XmlInclude(typeof(EX_GeographicBoundingBox_Type))]
  //[XmlInclude(typeof(EX_BoundingPolygon_Type))]
  //[XmlInclude(typeof(PT_FreeText_Type))]
  //[XmlInclude(typeof(EX_Extent_Type))]
  //[XmlInclude(typeof(EX_VerticalExtent_Type))]
  //[XmlInclude(typeof(EX_TemporalExtent_Type))]
  //[XmlInclude(typeof(EX_SpatialTemporalExtent_Type))]
  [XmlType("AbstractObject_Type", Namespace = "http://www.isotc211.org/2005/gco")] // TODO: XmlRoot???
  [JsonObject("AbstractObject_Type")]
  public abstract class AbstractObject_Type : Model, IObjectIdentification {

    #region IObjectIdentification Interface

    private string _id;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("id", DataType = "ID")]
    [JsonProperty("id")]
    public string Id {
      get {
        return _id;
      }
      set {
        if (_id == value) {
          return;
        }
        if (_id == null || _id.Equals(value) != true) {
          _id = value;
          OnPropertyChanged();
        }
      }
    }

    private string _uuid;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("uuid", DataType = "string")]
    [JsonProperty("uuid")]
    public string Uuid {
      get {
        return _uuid;
      }
      set {
        if (_uuid == value) {
          return;
        }
        if (_uuid == null || _uuid.Equals(value) != true) {
          _uuid = value;
          OnPropertyChanged();
        }
      }
    }

    #endregion

  }

}




//[XmlInclude(typeof(MultiplicityRange_Type))]
//[XmlInclude(typeof(Multiplicity_Type))]
//[XmlInclude(typeof(DS_DataSet_Type))]
//[XmlInclude(typeof(AbstractDS_Aggregate_Type))]
//[XmlInclude(typeof(DS_Initiative_Type))]
//[XmlInclude(typeof(DS_Series_Type))]
//[XmlInclude(typeof(DS_ProductionSeries_Type))]
//[XmlInclude(typeof(DS_Sensor_Type))]
//[XmlInclude(typeof(DS_Platform_Type))]
//[XmlInclude(typeof(DS_OtherAggregate_Type))]
//[XmlInclude(typeof(DS_StereoMate_Type))]
//[XmlInclude(typeof(MD_Metadata_Type))]
//[XmlInclude(typeof(PT_Locale_Type))]
//[XmlInclude(typeof(DQ_Scope_Type))]
//[XmlInclude(typeof(DQ_DataQuality_Type))]
//[XmlInclude(typeof(LI_Lineage_Type))]
//[XmlInclude(typeof(LI_Source_Type))]
//[XmlInclude(typeof(LI_ProcessStep_Type))]
//[XmlInclude(typeof(DS_Association_Type))]
//[XmlInclude(typeof(MD_RepresentativeFraction_Type))]
//[XmlInclude(typeof(MD_AggregateInformation_Type))]
//[XmlInclude(typeof(MD_Usage_Type))]
//[XmlInclude(typeof(MD_Keywords_Type))]
//[XmlInclude(typeof(MD_BrowseGraphic_Type))]
//[XmlInclude(typeof(AbstractMD_Identification_Type))]
//[XmlInclude(typeof(MD_ServiceIdentification_Type))]
//[XmlInclude(typeof(MD_DataIdentification_Type))]
//[XmlInclude(typeof(MD_MaintenanceInformation_Type))]
//[XmlInclude(typeof(MD_Distribution_Type))]
//[XmlInclude(typeof(MD_Format_Type))]
//[XmlInclude(typeof(MD_Distributor_Type))]
//[XmlInclude(typeof(MD_StandardOrderProcess_Type))]
//[XmlInclude(typeof(MD_DigitalTransferOptions_Type))]
//[XmlInclude(typeof(MD_Medium_Type))]
//[XmlInclude(typeof(MD_Constraints_Type))]
//[XmlInclude(typeof(MD_SecurityConstraints_Type))]
//[XmlInclude(typeof(MD_LegalConstraints_Type))]
//[XmlInclude(typeof(MD_PortrayalCatalogueReference_Type))]
//[XmlInclude(typeof(MD_ApplicationSchemaInformation_Type))]
//[XmlInclude(typeof(TypeName_Type))]
//[XmlInclude(typeof(MemberName_Type))]
//[XmlInclude(typeof(MD_RangeDimension_Type))]
//[XmlInclude(typeof(MD_Band_Type))]
//[XmlInclude(typeof(AbstractMD_ContentInformation_Type))]
//[XmlInclude(typeof(MD_CoverageDescription_Type))]
//[XmlInclude(typeof(MD_ImageDescription_Type))]
//[XmlInclude(typeof(MD_FeatureCatalogueDescription_Type))]
//[XmlInclude(typeof(MD_MetadataExtensionInformation_Type))]
//[XmlInclude(typeof(MD_ExtendedElementInformation_Type))]
//[XmlInclude(typeof(MD_GeometricObjects_Type))]
//[XmlInclude(typeof(MD_Dimension_Type))]
//[XmlInclude(typeof(AbstractMD_SpatialRepresentation_Type))]
//[XmlInclude(typeof(MD_VectorSpatialRepresentation_Type))]
//[XmlInclude(typeof(MD_GridSpatialRepresentation_Type))]
//[XmlInclude(typeof(MD_Georectified_Type))]
//[XmlInclude(typeof(MD_Georeferenceable_Type))]
//[XmlInclude(typeof(AbstractRS_ReferenceSystem_Type))]
//[XmlInclude(typeof(MD_ReferenceSystem_Type))]
//[XmlInclude(typeof(AbstractDQ_Result_Type))]
//[XmlInclude(typeof(DQ_QuantitativeResult_Type))]
//[XmlInclude(typeof(DQ_ConformanceResult_Type))]
//[XmlInclude(typeof(AbstractDQ_Element_Type))]
//[XmlInclude(typeof(AbstractDQ_Completeness_Type))]
//[XmlInclude(typeof(DQ_CompletenessCommission_Type))]
//[XmlInclude(typeof(DQ_CompletenessOmission_Type))]
//[XmlInclude(typeof(AbstractDQ_LogicalConsistency_Type))]
//[XmlInclude(typeof(DQ_ConceptualConsistency_Type))]
//[XmlInclude(typeof(DQ_DomainConsistency_Type))]
//[XmlInclude(typeof(DQ_FormatConsistency_Type))]
//[XmlInclude(typeof(DQ_TopologicalConsistency_Type))]
//[XmlInclude(typeof(AbstractDQ_PositionalAccuracy_Type))]
//[XmlInclude(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
//[XmlInclude(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
//[XmlInclude(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
//[XmlInclude(typeof(AbstractDQ_ThematicAccuracy_Type))]
//[XmlInclude(typeof(DQ_ThematicClassificationCorrectness_Type))]
//[XmlInclude(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
//[XmlInclude(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
//[XmlInclude(typeof(AbstractDQ_TemporalAccuracy_Type))]
//[XmlInclude(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
//[XmlInclude(typeof(DQ_TemporalConsistency_Type))]
//[XmlInclude(typeof(DQ_TemporalValidity_Type))]
//[XmlInclude(typeof(CI_Series_Type))]
//[XmlInclude(typeof(CI_OnlineResource_Type))]
//[XmlInclude(typeof(CI_Address_Type))]
//[XmlInclude(typeof(CI_Telephone_Type))]
//[XmlInclude(typeof(CI_Contact_Type))]
//[XmlInclude(typeof(CI_ResponsibleParty_Type))]
//[XmlInclude(typeof(CI_Date_Type))]
//[XmlInclude(typeof(CI_Citation_Type))]
//[XmlInclude(typeof(MD_Identifier_Type))]
//[XmlInclude(typeof(RS_Identifier_Type))]
//[XmlInclude(typeof(AbstractEX_GeographicExtent_Type))]
//[XmlInclude(typeof(EX_GeographicDescription_Type))]
//[XmlInclude(typeof(EX_GeographicBoundingBox_Type))]
//[XmlInclude(typeof(EX_BoundingPolygon_Type))]
//[XmlInclude(typeof(PT_FreeText_Type))]
//[XmlInclude(typeof(EX_Extent_Type))]
//[XmlInclude(typeof(EX_VerticalExtent_Type))]
//[XmlInclude(typeof(EX_TemporalExtent_Type))]
//[XmlInclude(typeof(EX_SpatialTemporalExtent_Type))]