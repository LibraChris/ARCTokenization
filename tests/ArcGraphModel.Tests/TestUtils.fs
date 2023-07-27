﻿module TestUtils

open Xunit
open ControlledVocabulary
open ArcGraphModel
open ArcGraphModel.AnnotationTable

module CvParam =

    let termNamesEqual (cvpExpectec : CvParam) (cvpActual : CvParam) =
        Assert.Equal(
            (CvBase.getCvName cvpExpectec),
            (CvBase.getCvName cvpActual)
        )

    let hasTermName (expectedName : string) (cvpActual : CvParam) =
        Assert.Equal(
            expectedName,
            (CvBase.getCvName cvpActual)
        )

    let accessionsEqual (cvpExpectec : CvParam) (cvpActual : CvParam) =
        Assert.Equal(
            (CvBase.getCvAccession cvpExpectec),
            (CvBase.getCvAccession cvpActual)
        )

    let hasAccession (expectedID : string) (cvpActual : CvParam) =
        Assert.Equal(
            expectedID,
            (CvBase.getCvAccession cvpActual)
        )

    let refUrisEqual (cvpExpectec : CvParam) (cvpActual : CvParam) =
        Assert.Equal(
            (CvBase.getCvRef cvpExpectec),
            (CvBase.getCvRef cvpActual)
        )

    let hasRefUri (expectedRefUri : string) (cvpActual : CvParam) =
        Assert.Equal(
            expectedRefUri,
            (CvBase.getCvRef cvpActual)
        )

    let valuesEqual (cvpExpectec : CvParam) (cvpActual : CvParam) =
        Assert.Equal(
            (Param.getParamValue cvpExpectec),
            (Param.getParamValue cvpActual)
        )

    let hasValue (expectedValue : ParamValue) (cvpActual : CvParam) =
        Assert.Equal(
            expectedValue,
            (Param.getParamValue cvpActual)
        )

    let structuralEquality (cvpExpectec : CvParam) (cvpActual : CvParam) =
        termNamesEqual cvpExpectec cvpActual
        accessionsEqual cvpExpectec cvpActual
        refUrisEqual cvpExpectec cvpActual
        valuesEqual cvpExpectec cvpActual
        

module UserParam =

    open ArcGraphModel

    let termNamesEqual (upActual : UserParam) (upExpectec : UserParam) =
        Assert.Equal(
            (CvBase.getCvName upActual),
            (CvBase.getCvName upExpectec)
        )

module TokenizedAnnotationTable =
    
    let hasIOColumnAmount (expectedIOColumnAmount : int) (table : TokenizedAnnotationTable) =
        Assert.Equal(expectedIOColumnAmount, table.IOColumns.Length)

    let hasTermRelatedBuildingBlockAmount (expectedTermRelatedBuildingBlockAmount : int) (table : TokenizedAnnotationTable) =
        Assert.Equal(expectedTermRelatedBuildingBlockAmount, table.TermRelatedBuildingBlocks.Length)
