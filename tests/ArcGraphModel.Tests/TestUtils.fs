﻿module TestUtils

open Xunit
open ControlledVocabulary
open ArcGraphModel
open ArcGraphModel.AnnotationTable

module CvParam =

    open ArcGraphModel

    let termNamesEqual (cvpActual : CvParam) (cvpExpectec : CvParam) =
        Assert.Equal(
            (CvBase.getCvName cvpActual),
            (CvBase.getCvName cvpExpectec)
        )

module UserParam =

    open ArcGraphModel

    let termNamesEqual (upActual : UserParam) (upExpectec : UserParam) =
        Assert.Equal(
            (CvBase.getCvName upActual),
            (CvBase.getCvName upExpectec)
        )

module TokenizedAnnotationTable =
    
    ()