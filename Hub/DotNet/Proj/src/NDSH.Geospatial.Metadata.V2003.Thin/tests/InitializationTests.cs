﻿using Xunit;

namespace NDSH.Geospatial.Metadata.V2003.Thin.Tests {

  /// <summary>
  /// Provides object initialization tests.
  /// </summary>
  public class InitializationTests {

    /// <summary>
    /// Tests the initialization of types inheriting from root object
    /// <see cref="NDSH.Geospatial.Metadata.V19136.Common.AbstractObject_Type"/>.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to initialize.</param>
    [Theory]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.MX_Aggregate_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.MX_DataFile_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.MX_DataSet_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.MX_SupportFile_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Extended.Anchor_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Extended.FileName_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Extended.MimeFileType_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CT_CodelistCatalogue_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CT_CrsCatalogue_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CT_UomCatalogue_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure.ML_BaseUnit_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure.ML_ConventionalUnit_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure.ML_DerivedUnit_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure.ML_UnitDefinition_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.UnitsOfMeasure.UomAlternativeExpression_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystemAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystemAxisAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CrsAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.DatumAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.EllipsoidAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.OperationAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.OperationMethodAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.OperationParameterAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.PrimeMeridianAlt_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums.ML_Ellipsoid_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums.ML_EngineeringDatum_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums.ML_GeodeticDatum_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums.ML_ImageDatum_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums.ML_PrimeMeridian_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums.ML_TemporalDatum_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.Datums.ML_VerticalDatum_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_AffineCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_CartesianCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_CoordinateSystemAxis_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_CylindricalCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_EllipsoidalCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_LinearCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_PolarCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_SphericalCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_TimeCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_UserDefinedCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateSystems.ML_VerticalCS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_CompoundCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_DerivedCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_EngineeringCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_GeodeticCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_ImageCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_ProjectedCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_TemporalCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateReferenceSystems.ML_VerticalCRS_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations.ML_ConcatenatedOperation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations.ML_Conversion_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations.ML_OperationMethod_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations.ML_OperationParameterGroup_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations.ML_OperationParameter_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations.ML_Transformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist.CodeAlternativeExpression_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist.CodeDefinition_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist.ML_CodeDefinition_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist.ML_CodeListDictionary_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation.MD_Dimension_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation.MD_GeometricObjects_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation.MD_Georectified_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation.MD_Georeferenceable_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation.MD_GridSpatialRepresentation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.SpatialRepresentation.MD_VectorSpatialRepresentation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_Interface_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_Operation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_PlatformNeutralServiceSpecification_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_PlatformSpecificServiceSpecification_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_PortSpecification_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_Port_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_ServiceSpecification_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Model.SV_Service_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata.SV_CoupledResource_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata.SV_OperationChainMetadata_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata.SV_OperationChain_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata.SV_OperationMetadata_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata.SV_Parameter_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Service.Metadata.SV_ServiceIdentification_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem.MD_Identifier_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem.MD_ReferenceSystem_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ReferenceSystem.RS_Identifier_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.PortrayalCatalogue.MD_PortrayalCatalogueReference_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Maintenance.MD_MaintenanceInformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Localisation.LocalisedCharacterString_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Localisation.PT_FreeText_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Localisation.PT_LocaleContainer_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Localisation.PT_Locale_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation.AbstractMI_GeolocationInformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation.MI_GCPCollection_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation.MI_GCP_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation.MI_Georectified_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.SpatialRepresentation.MI_Georeferenceable_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.EntitySet.MI_Metadata_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.LE_Algorithm_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.LE_NominalResolution_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.LE_Processing_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.LE_ProcessStepReport_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.LE_ProcessStep_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.LE_Source_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.MX_ImgDataFile_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.QE_CoverageResult_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.DataQuality.QE_Usability_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content.MI_Band_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content.MI_CoverageDescription_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content.MI_ImageDescription_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Content.MI_RangeElementDescription_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_AcquisitionInformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_EnvironmentalRecord_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_Event_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_Instrument_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_Objective_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_Operation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_Plan_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_PlatformPass_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_Platform_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_RequestedDate_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Imagery.Acquisition.MI_Requirement_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.DS_Association_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.MD_AggregateInformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.MD_BrowseGraphic_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.MD_DataIdentification_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.MD_Keywords_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.MD_RepresentativeFraction_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.MD_Resolution_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Identification.MD_Usage_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Extension.MD_ExtendedElementInformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Extension.MD_MetadataExtensionInformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.EntitySet.MD_Metadata_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Distribution.MD_DigitalTransferOptions_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Distribution.MD_Distribution_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Distribution.MD_Distributor_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Distribution.MD_Format_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Distribution.MD_Medium_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Distribution.MD_StandardOrderProcess_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.DQ_ConformanceResult_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.DQ_DataQuality_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.DQ_QuantitativeResult_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.DQ_Scope_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.ThematicAccuracy.DQ_NonQuantitativeAttributeAccuracy_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.ThematicAccuracy.DQ_QuantitativeAttributeAccuracy_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.ThematicAccuracy.DQ_ThematicClassificationCorrectness_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.TemporalAccuracy.DQ_AccuracyOfATimeMeasurement_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.TemporalAccuracy.DQ_TemporalConsistency_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.TemporalAccuracy.DQ_TemporalValidity_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.PositionalAccuracy.DQ_AbsoluteExternalPositionalAccuracy_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.PositionalAccuracy.DQ_GriddedDataPositionalAccuracy_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.PositionalAccuracy.DQ_RelativeInternalPositionalAccuracy_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.LogicalConsistency.DQ_ConceptualConsistency_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.LogicalConsistency.DQ_DomainConsistency_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.LogicalConsistency.DQ_FormatConsistency_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.LogicalConsistency.DQ_TopologicalConsistency_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage.LI_Lineage_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage.LI_ProcessStep_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Lineage.LI_Source_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Completeness.DQ_CompletenessCommission_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.DataQuality.Completeness.DQ_CompletenessOmission_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Constraint.MD_LegalConstraints_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Constraint.MD_SecurityConstraints_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Binary_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Numerics.UnlimitedInteger_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Multiplicities.MultiplicityRange_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Primitive.Multiplicities.Multiplicity_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names.MemberName_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Names.TypeName_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.CodeListValue_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent.EX_BoundingPolygon_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent.EX_Extent_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent.EX_GeographicBoundingBox_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent.EX_GeographicDescription_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent.EX_SpatialTemporalExtent_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent.EX_TemporalExtent_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Extent.EX_VerticalExtent_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_Address_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_Citation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_Contact_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_Date_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_OnlineResource_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_ResponsibleParty_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_Series_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Common.Citation.CI_Telephone_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_DataSet_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_Initiative_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_OtherAggregate_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_Platform_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_ProductionSeries_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_Sensor_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_Series_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Application.DS_StereoMate_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ApplicationSchema.MD_ApplicationSchemaInformation_Type))]
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist.ClAlternativeExpression_Type))] // show
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.ConceptualSchema.Implementation.Records.RecordType_Type))] // show
    // problematic cases
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Content.MD_Band_Type))] //something weird with the namespaces
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Content.MD_CoverageDescription_Type))] //something weird with the namespaces
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Content.MD_FeatureCatalogueDescription_Type))] //something weird with the namespaces
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Content.MD_ImageDescription_Type))] //something weird with the namespaces
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Content.MD_RangeDimension_Type))] //something weird with the namespaces
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Constraint.MD_Constraints_Type))] //something weird with the namespaces
    //[InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.Maintenance.MD_ScopeDescription_Type))] // object
    //[InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.Codelist.CodeListDictionary_Type))] // Enum
    [InlineData(typeof(NDSH.Geospatial.Metadata.V2003.Thin.XmlSchema.Catalogues.CRS.Multilingual.CoordinateOperations.ML_PassThroughOperation_Type))] //List<string>
    public void InitializationTypeTest(Type type) {
      var instance = Helper.GetDummyObject(type);
    }

  }

}
