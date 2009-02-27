
//                                      ______    ____   
//                                     |____  | "|__  |  
//                                      _   | |     | |  
//                                     | |  | |   __| |  
//                                     |_|  |_|  |_____| 
//                                                       
//  ---------------------------------------------------  
// |     _   ____     ___     ___    ____    ____      | 
// |    (_) |___ \   / _ \   / _ \  |___ \  |___ \     | 
// |    | |   __) | | | | | | | | |   __) |   __) |    | 
// |    | |  / __/  | |_| | | |_| |  / __/   / __/     | 
// |    |_| |_____|  \___/   \___/  |_____| |_____|    | 
// |                                                   | 
// |    AN ISO 20022 OPEN-SOURCE .NET CLASS LIBRARY    | 
// |            FOR MESSAGING APPLICATIONS             | 
// |                                                   | 
// |        Copyright (C) 2008 Mauricio Leventer       | 
// |                mleventer@i20022.com               | 
// |                                                   | 
//  ---------------------------------------------------  
//                                                       
// L I C E N S E                                         
//                                                       
// This program is free software; you can redistribute it
// and/or modify it under the terms of the GNU General   
// Public License as published by the Free Software      
// Foundation; either version 2 of the License, or (at   
// your option) any later version.                       
//                                                       
// This program is distributed in the hope that it will  
// be useful, but WITHOUT ANY WARRANTY; without even the 
// implied warranty of MERCHANTABILITY or FITNESS FOR A  
// PARTICULAR PURPOSE. See the GNU General Public License
// for more details.                                     
//                                                       
// You should have received a copy of the GNU General    
// Public License along with this program; if not, write 
// to the Free Software Foundation, Inc.,                
// 59 Temple Place, Suite 330, Boston, MA                
// 02111-1307 USA.                                       
//
//
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;



namespace i20022.tsmt01700103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.017.001.03 name ForwardDataSetSubmissionReportV03 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>FwdDataSetSubmissnRpt</b> (Forward Data Set Submission Report) of type ForwardDataSetSubmissionReportV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ForwardDataSetSubmissionReportV03 FwdDataSetSubmissnRpt;
    }
    
    /// <summary>
    /// Class <b>ForwardDataSetSubmissionReportV03</b> (Forward Data Set Submission Report V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ForwardDataSetSubmissionReportV03
    {
        
        /// <summary>
        /// Element <b>RptId</b> (Report Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 RptId;
        
        /// <summary>
        /// Element <b>RltdTxRefs</b> (Related Transaction References) of type array of DataSetSubmissionReferences4.
        /// </summary>
        [XmlElementAttribute("RltdTxRefs", Order=1)]
        public DataSetSubmissionReferences4[] RltdTxRefs;
        
        /// <summary>
        /// Element <b>CmonSubmissnRef</b> (Common Submission Reference) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public SimpleIdentificationInformation CmonSubmissnRef;
        
        /// <summary>
        /// Element <b>Submitr</b> (Submitter) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public BICIdentification1 Submitr;
        
        /// <summary>
        /// Element <b>BuyrBk</b> (Buyer Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public BICIdentification1 BuyrBk;
        
        /// <summary>
        /// Element <b>SellrBk</b> (Seller Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public BICIdentification1 SellrBk;
        
        /// <summary>
        /// Element <b>ComrclDataSet</b> (Commercial Data Set) of type CommercialDataSet3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CommercialDataSet3 ComrclDataSet;
        
        /// <summary>
        /// Element <b>TrnsprtDataSet</b> (Transport Data Set) of type TransportDataSet3.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public TransportDataSet3 TrnsprtDataSet;
        
        /// <summary>
        /// Element <b>InsrncDataSet</b> (Insurance Data Set) of type InsuranceDataSet1.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public InsuranceDataSet1 InsrncDataSet;
        
        /// <summary>
        /// Element <b>CertDataSet</b> (Certificate Data Set) of type array of CertificateDataSet1.
        /// </summary>
        [XmlElementAttribute("CertDataSet", Order=9)]
        public CertificateDataSet1[] CertDataSet;
        
        /// <summary>
        /// Element <b>OthrCertDataSet</b> (Other Certificate Data Set) of type array of OtherCertificateDataSet1.
        /// </summary>
        [XmlElementAttribute("OthrCertDataSet", Order=10)]
        public OtherCertificateDataSet1[] OthrCertDataSet;
        
        /// <summary>
        /// Element <b>ReqForActn</b> (Request For Action) of type PendingActivity2.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public PendingActivity2 ReqForActn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class MessageIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>PendingActivity2</b> (Pending Activity 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class PendingActivity2
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type Action2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Action2Code Tp;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Enumeration <b>Action2Code</b> (Action 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum Action2Code
    {
        
        /// <summary>
        /// <b>SBTW - Submit Twin</b>.
        /// </summary>
        SBTW,
        
        /// <summary>
        /// <b>RSTW - Re Submit Twin</b>.
        /// </summary>
        RSTW,
        
        /// <summary>
        /// <b>RSBS - Re Submit Baseline</b>.
        /// </summary>
        RSBS,
        
        /// <summary>
        /// <b>ARDM - Accept Or Reject Data Set Mis Matches</b>.
        /// </summary>
        ARDM,
        
        /// <summary>
        /// <b>ARCS - Accept Or Reject Change Of Status</b>.
        /// </summary>
        ARCS,
        
        /// <summary>
        /// <b>ARES - Accept Or Reject Extension Of Status</b>.
        /// </summary>
        ARES,
        
        /// <summary>
        /// <b>WAIT - Wait For Baseline Established</b>.
        /// </summary>
        WAIT,
        
        /// <summary>
        /// <b>UPDT - Update And Resend</b>.
        /// </summary>
        UPDT,
        
        /// <summary>
        /// <b>SBDS - Submit Data Set</b>.
        /// </summary>
        SBDS,
        
        /// <summary>
        /// <b>ARBA - Accept Or Reject Baseline Amendment</b>.
        /// </summary>
        ARBA,
        
        /// <summary>
        /// <b>ARRO - Accept Or Reject Baseline And Role</b>.
        /// </summary>
        ARRO,
        
        /// <summary>
        /// <b>CINR - Check Invoice Reference</b>.
        /// </summary>
        CINR,
    }
    
    /// <summary>
    /// Class <b>OtherCertificateDataSet1</b> (Other Certificate Data Set 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class OtherCertificateDataSet1
    {
        
        /// <summary>
        /// Element <b>DataSetId</b> (Data Set Identification) of type DocumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification1 DataSetId;
        
        /// <summary>
        /// Element <b>CertId</b> (Certificate Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string CertId;
        
        /// <summary>
        /// Element <b>CertTp</b> (Certificate Type) of type TradeCertificateType2Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TradeCertificateType2Code CertTp;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime IsseDt;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification26 Issr;
        
        /// <summary>
        /// Element <b>CertInf</b> (Certificate Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("CertInf", Order=5)]
        public string[] CertInf;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification1</b> (Document Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class DocumentIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Vrsn</b> (Version) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Vrsn;
        
        /// <summary>
        /// Element <b>Submitr</b> (Submitter) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public BICIdentification1 Submitr;
    }
    
    /// <summary>
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Enumeration <b>TradeCertificateType2Code</b> (Trade Certificate Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum TradeCertificateType2Code
    {
        
        /// <summary>
        /// <b>BENE - Unemployment Disability Benefit</b>.
        /// </summary>
        BENE,
        
        /// <summary>
        /// <b>SHIP - Shipping Charge</b>.
        /// </summary>
        SHIP,
        
        /// <summary>
        /// <b>UND1 - Undefined 1</b>.
        /// </summary>
        UND1,
        
        /// <summary>
        /// <b>UND2 - Undefined 2</b>.
        /// </summary>
        UND2,
    }
    
    /// <summary>
    /// Class <b>PartyIdentification26</b> (Party Identification 26).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class PartyIdentification26
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public GenericIdentification4 PrtryId;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress5.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PostalAddress5 PstlAdr;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class GenericIdentification4
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IdTp;
    }
    
    /// <summary>
    /// Class <b>PostalAddress5</b> (Postal Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class PostalAddress5
    {
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>PstCdId</b> (Post Code Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PstCdId;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string CtrySubDvsn;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string Ctry;
    }
    
    /// <summary>
    /// Class <b>DatePeriodDetails</b> (Date Period Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class DatePeriodDetails
    {
        
        /// <summary>
        /// Element <b>FrDt</b> (From Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime FrDt;
        
        /// <summary>
        /// Element <b>ToDt</b> (To Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime ToDt;
    }
    
    /// <summary>
    /// Class <b>CertifiedCharacteristics1Choice</b> (Certified Characteristics 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class CertifiedCharacteristics1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Anlys (Analysis) of type string 
        /// HlthIndctn (Health Indication) of type bool 
        /// Orgn (Origin) of type string 
        /// PhytosntryIndctn (Phytosanitary Indication) of type bool 
        /// Qlty (Quality) of type string 
        /// Qty (Quantity) of type Quantity4 
        /// Wght (Weight) of type Quantity4 
        /// </summary>
        [XmlElementAttribute("Anlys", typeof(string), Order=0)]
        [XmlElementAttribute("HlthIndctn", typeof(bool), Order=0)]
        [XmlElementAttribute("Orgn", typeof(string), Order=0)]
        [XmlElementAttribute("PhytosntryIndctn", typeof(bool), Order=0)]
        [XmlElementAttribute("Qlty", typeof(string), Order=0)]
        [XmlElementAttribute("Qty", typeof(Quantity4), Order=0)]
        [XmlElementAttribute("Wght", typeof(Quantity4), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>Quantity4</b> (Quantity 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class Quantity4
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrUnitOfMeasr (Other Unit Of Measure) of type string 
        /// UnitOfMeasrCd (Unit Of Measure Code) of type UnitOfMeasure4Code 
        /// </summary>
        [XmlElementAttribute("OthrUnitOfMeasr", typeof(string), Order=0)]
        [XmlElementAttribute("UnitOfMeasrCd", typeof(UnitOfMeasure4Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Val</b> (Value) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Val;
        
        /// <summary>
        /// Element <b>Fctr</b> (Factor) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Fctr;
    }
    
    /// <summary>
    /// Enumeration <b>UnitOfMeasure4Code</b> (Unit Of Measure 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum UnitOfMeasure4Code
    {
        
        /// <summary>
        /// <b>KGM - Kilogram</b>.
        /// </summary>
        KGM,
        
        /// <summary>
        /// <b>EA - Each</b>.
        /// </summary>
        EA,
        
        /// <summary>
        /// <b>LTN - GBTon</b>.
        /// </summary>
        LTN,
        
        /// <summary>
        /// <b>MTR - Metre</b>.
        /// </summary>
        MTR,
        
        /// <summary>
        /// <b>INH - Inch</b>.
        /// </summary>
        INH,
        
        /// <summary>
        /// <b>LY - Yard</b>.
        /// </summary>
        LY,
        
        /// <summary>
        /// <b>GLI - GBGallon</b>.
        /// </summary>
        GLI,
        
        /// <summary>
        /// <b>GRM - Gram</b>.
        /// </summary>
        GRM,
        
        /// <summary>
        /// <b>CMT - Centimetre</b>.
        /// </summary>
        CMT,
        
        /// <summary>
        /// <b>MTK - Square Metre</b>.
        /// </summary>
        MTK,
        
        /// <summary>
        /// <b>FOT - Foot</b>.
        /// </summary>
        FOT,
        
        /// <summary>
        /// <b>Item1A - Item 1A</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1A")]
        Item1A,
        
        /// <summary>
        /// <b>INK - Square Inch</b>.
        /// </summary>
        INK,
        
        /// <summary>
        /// <b>FTK - Square Foot</b>.
        /// </summary>
        FTK,
        
        /// <summary>
        /// <b>MIK - Square Mile</b>.
        /// </summary>
        MIK,
        
        /// <summary>
        /// <b>ONZ - Ounce</b>.
        /// </summary>
        ONZ,
        
        /// <summary>
        /// <b>PTI - GBPint</b>.
        /// </summary>
        PTI,
        
        /// <summary>
        /// <b>PT - USPint</b>.
        /// </summary>
        PT,
        
        /// <summary>
        /// <b>QTI - GBQuart</b>.
        /// </summary>
        QTI,
        
        /// <summary>
        /// <b>QT - USQuart</b>.
        /// </summary>
        QT,
        
        /// <summary>
        /// <b>GLL - USGallon</b>.
        /// </summary>
        GLL,
        
        /// <summary>
        /// <b>MMT - Millimetre</b>.
        /// </summary>
        MMT,
        
        /// <summary>
        /// <b>KTM - Kilometre</b>.
        /// </summary>
        KTM,
        
        /// <summary>
        /// <b>YDK - Square Yard</b>.
        /// </summary>
        YDK,
        
        /// <summary>
        /// <b>MMK - Square Millimetre</b>.
        /// </summary>
        MMK,
        
        /// <summary>
        /// <b>CMK - Square Centimetre</b>.
        /// </summary>
        CMK,
        
        /// <summary>
        /// <b>KMK - Square Kilometre</b>.
        /// </summary>
        KMK,
        
        /// <summary>
        /// <b>MMQ - Cubic Millimetre</b>.
        /// </summary>
        MMQ,
        
        /// <summary>
        /// <b>CLT - Centilitre</b>.
        /// </summary>
        CLT,
        
        /// <summary>
        /// <b>LTR - Litre</b>.
        /// </summary>
        LTR,
        
        /// <summary>
        /// <b>LBR - Pound</b>.
        /// </summary>
        LBR,
        
        /// <summary>
        /// <b>STN - USTon</b>.
        /// </summary>
        STN,
        
        /// <summary>
        /// <b>BLL - USBarrel</b>.
        /// </summary>
        BLL,
        
        /// <summary>
        /// <b>BX - Box</b>.
        /// </summary>
        BX,
        
        /// <summary>
        /// <b>BO - Bottle</b>.
        /// </summary>
        BO,
        
        /// <summary>
        /// <b>CT - Carton</b>.
        /// </summary>
        CT,
        
        /// <summary>
        /// <b>CH - Container</b>.
        /// </summary>
        CH,
        
        /// <summary>
        /// <b>CR - Crate</b>.
        /// </summary>
        CR,
        
        /// <summary>
        /// <b>INQ - Cubic Inch</b>.
        /// </summary>
        INQ,
        
        /// <summary>
        /// <b>MTQ - Cubic Meter</b>.
        /// </summary>
        MTQ,
        
        /// <summary>
        /// <b>OZI - GBFluid Ounce</b>.
        /// </summary>
        OZI,
        
        /// <summary>
        /// <b>OZA - USFluid Ounce</b>.
        /// </summary>
        OZA,
        
        /// <summary>
        /// <b>BG - Bag</b>.
        /// </summary>
        BG,
        
        /// <summary>
        /// <b>BL - Bale</b>.
        /// </summary>
        BL,
        
        /// <summary>
        /// <b>TNE - Metric Ton</b>.
        /// </summary>
        TNE,
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>Anlys - Analysis</b>.
        /// </summary>
        Anlys,
        
        /// <summary>
        /// <b>HlthIndctn - Health Indication</b>.
        /// </summary>
        HlthIndctn,
        
        /// <summary>
        /// <b>Orgn - Origin</b>.
        /// </summary>
        Orgn,
        
        /// <summary>
        /// <b>PhytosntryIndctn - Phytosanitary Indication</b>.
        /// </summary>
        PhytosntryIndctn,
        
        /// <summary>
        /// <b>Qlty - Quality</b>.
        /// </summary>
        Qlty,
        
        /// <summary>
        /// <b>Qty - Quantity</b>.
        /// </summary>
        Qty,
        
        /// <summary>
        /// <b>Wght - Weight</b>.
        /// </summary>
        Wght,
    }
    
    /// <summary>
    /// Class <b>LineItemAndPOIdentification1</b> (Line Item And PO Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class LineItemAndPOIdentification1
    {
        
        /// <summary>
        /// Element <b>LineItmId</b> (Line Item Identification) of type array of string.
        /// </summary>
        [XmlElementAttribute("LineItmId", Order=0)]
        public string[] LineItmId;
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentIdentification7 PurchsOrdrRef;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification7</b> (Document Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class DocumentIdentification7
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>DtOfIsse</b> (Date Of Issue) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime DtOfIsse;
    }
    
    /// <summary>
    /// Class <b>CertificateDataSet1</b> (Certificate Data Set 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class CertificateDataSet1
    {
        
        /// <summary>
        /// Element <b>DataSetId</b> (Data Set Identification) of type DocumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification1 DataSetId;
        
        /// <summary>
        /// Element <b>CertTp</b> (Certificate Type) of type TradeCertificateType1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TradeCertificateType1Code CertTp;
        
        /// <summary>
        /// Element <b>LineItm</b> (Line Item) of type array of LineItemAndPOIdentification1.
        /// </summary>
        [XmlElementAttribute("LineItm", Order=2)]
        public LineItemAndPOIdentification1[] LineItm;
        
        /// <summary>
        /// Element <b>CertfdChrtcs</b> (Certified Characteristics) of type CertifiedCharacteristics1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CertifiedCharacteristics1Choice CertfdChrtcs;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime IsseDt;
        
        /// <summary>
        /// Element <b>PlcOfIsse</b> (Place Of Issue) of type PostalAddress5.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PostalAddress5 PlcOfIsse;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification26 Issr;
        
        /// <summary>
        /// Element <b>InspctnDt</b> (Inspection Date) of type DatePeriodDetails.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public DatePeriodDetails InspctnDt;
        
        /// <summary>
        /// Element <b>AuthrsdInspctrInd</b> (Authorised Inspector Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public bool AuthrsdInspctrInd;
        
        /// <summary>
        /// Element <b>AuthrsdInspctrIndSpecified</b> (Authorised Inspector Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AuthrsdInspctrIndSpecified;
        
        /// <summary>
        /// Element <b>CertId</b> (Certificate Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string CertId;
        
        /// <summary>
        /// Element <b>Trnsprt</b> (Transport) of type SingleTransport3.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public SingleTransport3 Trnsprt;
        
        /// <summary>
        /// Element <b>GoodsDesc</b> (Goods Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string GoodsDesc;
        
        /// <summary>
        /// Element <b>Consgnr</b> (Consignor) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public PartyIdentification26 Consgnr;
        
        /// <summary>
        /// Element <b>Consgn</b> (Consignee) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public PartyIdentification26 Consgn;
        
        /// <summary>
        /// Element <b>Manfctr</b> (Manufacturer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public PartyIdentification26 Manfctr;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("AddtlInf", Order=15)]
        public string[] AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TradeCertificateType1Code</b> (Trade Certificate Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum TradeCertificateType1Code
    {
        
        /// <summary>
        /// <b>ANLY - Analysis</b>.
        /// </summary>
        ANLY,
        
        /// <summary>
        /// <b>QUAL - Quality</b>.
        /// </summary>
        QUAL,
        
        /// <summary>
        /// <b>QUAN - Quantity</b>.
        /// </summary>
        QUAN,
        
        /// <summary>
        /// <b>WEIG - Weight</b>.
        /// </summary>
        WEIG,
        
        /// <summary>
        /// <b>ORIG - Origin</b>.
        /// </summary>
        ORIG,
        
        /// <summary>
        /// <b>HEAL - Health</b>.
        /// </summary>
        HEAL,
        
        /// <summary>
        /// <b>PHYT - Phytosanitary</b>.
        /// </summary>
        PHYT,
    }
    
    /// <summary>
    /// Class <b>SingleTransport3</b> (Single Transport 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class SingleTransport3
    {
        
        /// <summary>
        /// Element <b>TrnsprtByAir</b> (Transport By Air) of type TransportByAir2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TransportByAir2 TrnsprtByAir;
        
        /// <summary>
        /// Element <b>TrnsprtBySea</b> (Transport By Sea) of type TransportBySea4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TransportBySea4 TrnsprtBySea;
        
        /// <summary>
        /// Element <b>TrnsprtByRoad</b> (Transport By Road) of type TransportByRoad2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TransportByRoad2 TrnsprtByRoad;
        
        /// <summary>
        /// Element <b>TrnsprtByRail</b> (Transport By Rail) of type TransportByRail2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public TransportByRail2 TrnsprtByRail;
    }
    
    /// <summary>
    /// Class <b>TransportByAir2</b> (Transport By Air 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportByAir2
    {
        
        /// <summary>
        /// Element <b>DprtureAirprt</b> (Departure Airport) of type AirportName1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AirportName1Choice DprtureAirprt;
        
        /// <summary>
        /// Element <b>DstnAirprt</b> (Destination Airport) of type AirportName1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AirportName1Choice DstnAirprt;
        
        /// <summary>
        /// Element <b>AirCrrierNm</b> (Air Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AirCrrierNm;
    }
    
    /// <summary>
    /// Class <b>AirportName1Choice</b> (Airport Name 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class AirportName1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AirprtCd (Airport Code) of type string 
        /// OthrAirprtDesc (Other Airport Description) of type AirportDescription1 
        /// </summary>
        [XmlElementAttribute("AirprtCd", typeof(string), Order=0)]
        [XmlElementAttribute("OthrAirprtDesc", typeof(AirportDescription1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AirportDescription1</b> (Airport Description 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class AirportDescription1
    {
        
        /// <summary>
        /// Element <b>Twn</b> (Town) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Twn;
        
        /// <summary>
        /// Element <b>AirprtNm</b> (Airport Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AirprtNm;
    }
    
    /// <summary>
    /// Class <b>TransportBySea4</b> (Transport By Sea 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportBySea4
    {
        
        /// <summary>
        /// Element <b>PortOfLoadng</b> (Port Of Loading) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PortOfLoadng;
        
        /// <summary>
        /// Element <b>PortOfDschrge</b> (Port Of Discharge) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PortOfDschrge;
        
        /// <summary>
        /// Element <b>VsslNm</b> (Vessel Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string VsslNm;
        
        /// <summary>
        /// Element <b>SeaCrrierNm</b> (Sea Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string SeaCrrierNm;
    }
    
    /// <summary>
    /// Class <b>TransportByRoad2</b> (Transport By Road 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportByRoad2
    {
        
        /// <summary>
        /// Element <b>PlcOfRct</b> (Place Of Receipt) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PlcOfRct;
        
        /// <summary>
        /// Element <b>PlcOfDlvry</b> (Place Of Delivery) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PlcOfDlvry;
        
        /// <summary>
        /// Element <b>RoadCrrierNm</b> (Road Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string RoadCrrierNm;
    }
    
    /// <summary>
    /// Class <b>TransportByRail2</b> (Transport By Rail 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportByRail2
    {
        
        /// <summary>
        /// Element <b>PlcOfRct</b> (Place Of Receipt) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PlcOfRct;
        
        /// <summary>
        /// Element <b>PlcOfDlvry</b> (Place Of Delivery) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PlcOfDlvry;
        
        /// <summary>
        /// Element <b>RailCrrierNm</b> (Rail Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string RailCrrierNm;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification29Choice</b> (Party Identification 29 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class PartyIdentification29Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BIC (BIC) of type string 
        /// NmAndAdr (Name And Address) of type PartyIdentification26 
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(PartyIdentification26), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>InsuranceDataSet1</b> (Insurance Data Set 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class InsuranceDataSet1
    {
        
        /// <summary>
        /// Element <b>DataSetId</b> (Data Set Identification) of type DocumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification1 DataSetId;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification26 Issr;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime IsseDt;
        
        /// <summary>
        /// Element <b>FctvDt</b> (Effective Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime FctvDt;
        
        /// <summary>
        /// Element <b>FctvDtSpecified</b> (Effective Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FctvDtSpecified;
        
        /// <summary>
        /// Element <b>PlcOfIsse</b> (Place Of Issue) of type PostalAddress5.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PostalAddress5 PlcOfIsse;
        
        /// <summary>
        /// Element <b>InsrncDocId</b> (Insurance Document Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string InsrncDocId;
        
        /// <summary>
        /// Element <b>Trnsprt</b> (Transport) of type SingleTransport3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public SingleTransport3 Trnsprt;
        
        /// <summary>
        /// Element <b>InsrdAmt</b> (Insured Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public CurrencyAndAmount InsrdAmt;
        
        /// <summary>
        /// Element <b>InsrdGoodsDesc</b> (Insured Goods Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string InsrdGoodsDesc;
        
        /// <summary>
        /// Element <b>InsrncConds</b> (Insurance Conditions) of type array of string.
        /// </summary>
        [XmlElementAttribute("InsrncConds", Order=9)]
        public string[] InsrncConds;
        
        /// <summary>
        /// Element <b>InsrncClauses</b> (Insurance Clauses) of type array of InsuranceClauses1Code.
        /// </summary>
        [XmlElementAttribute("InsrncClauses", Order=10)]
        public InsuranceClauses1Code[] InsrncClauses;
        
        /// <summary>
        /// Element <b>Assrd</b> (Assured) of type PartyIdentification29Choice.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public PartyIdentification29Choice Assrd;
        
        /// <summary>
        /// Element <b>ClmsPyblAt</b> (Claims Payable At) of type PostalAddress5.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public PostalAddress5 ClmsPyblAt;
        
        /// <summary>
        /// Element <b>ClmsPyblIn</b> (Claims Payable In) of type string.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public string ClmsPyblIn;
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class CurrencyAndAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Enumeration <b>InsuranceClauses1Code</b> (Insurance Clauses 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum InsuranceClauses1Code
    {
        
        /// <summary>
        /// <b>ICCA - Institute Cargo Clause A</b>.
        /// </summary>
        ICCA,
        
        /// <summary>
        /// <b>ICCB - Institute Cargo Clause B</b>.
        /// </summary>
        ICCB,
        
        /// <summary>
        /// <b>ICCC - Institute Cargo Clause C</b>.
        /// </summary>
        ICCC,
        
        /// <summary>
        /// <b>ICAI - Institute Cargo Clause Air</b>.
        /// </summary>
        ICAI,
        
        /// <summary>
        /// <b>IWCC - Institute War Clause Cargo</b>.
        /// </summary>
        IWCC,
        
        /// <summary>
        /// <b>ISCC - Institute Strikes Clause Cargo</b>.
        /// </summary>
        ISCC,
        
        /// <summary>
        /// <b>IREC - Institute Replacement Clause</b>.
        /// </summary>
        IREC,
        
        /// <summary>
        /// <b>ICLC - Institute Classification Clause</b>.
        /// </summary>
        ICLC,
        
        /// <summary>
        /// <b>ISMC - ISMCode Endorsement</b>.
        /// </summary>
        ISMC,
        
        /// <summary>
        /// <b>CMCC - Computer Millenium Clause Cargo</b>.
        /// </summary>
        CMCC,
        
        /// <summary>
        /// <b>IRCE - Institute Radioactive Contamination Exclusion Clause</b>.
        /// </summary>
        IRCE,
    }
    
    /// <summary>
    /// Class <b>MultimodalTransport3</b> (Multimodal Transport 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class MultimodalTransport3
    {
        
        /// <summary>
        /// Element <b>TakngInChrg</b> (Taking In Charge) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TakngInChrg;
        
        /// <summary>
        /// Element <b>PlcOfFnlDstn</b> (Place Of Final Destination) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PlcOfFnlDstn;
    }
    
    /// <summary>
    /// Class <b>SingleTransport5</b> (Single Transport 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class SingleTransport5
    {
        
        /// <summary>
        /// Element <b>TrnsprtByAir</b> (Transport By Air) of type array of TransportByAir2.
        /// </summary>
        [XmlElementAttribute("TrnsprtByAir", Order=0)]
        public TransportByAir2[] TrnsprtByAir;
        
        /// <summary>
        /// Element <b>TrnsprtBySea</b> (Transport By Sea) of type array of TransportBySea4.
        /// </summary>
        [XmlElementAttribute("TrnsprtBySea", Order=1)]
        public TransportBySea4[] TrnsprtBySea;
        
        /// <summary>
        /// Element <b>TrnsprtByRoad</b> (Transport By Road) of type array of TransportByRoad2.
        /// </summary>
        [XmlElementAttribute("TrnsprtByRoad", Order=2)]
        public TransportByRoad2[] TrnsprtByRoad;
        
        /// <summary>
        /// Element <b>TrnsprtByRail</b> (Transport By Rail) of type array of TransportByRail2.
        /// </summary>
        [XmlElementAttribute("TrnsprtByRail", Order=3)]
        public TransportByRail2[] TrnsprtByRail;
    }
    
    /// <summary>
    /// Class <b>TransportMeans2</b> (Transport Means 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportMeans2
    {
        
        /// <summary>
        /// Element <b>IndvTrnsprt</b> (Individual Transport) of type SingleTransport5.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SingleTransport5 IndvTrnsprt;
        
        /// <summary>
        /// Element <b>MltmdlTrnsprt</b> (Multimodal Transport) of type MultimodalTransport3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public MultimodalTransport3 MltmdlTrnsprt;
    }
    
    /// <summary>
    /// Class <b>Quantity3</b> (Quantity 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class Quantity3
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrUnitOfMeasr (Other Unit Of Measure) of type string 
        /// UnitOfMeasrCd (Unit Of Measure Code) of type UnitOfMeasure4Code 
        /// </summary>
        [XmlElementAttribute("OthrUnitOfMeasr", typeof(string), Order=0)]
        [XmlElementAttribute("UnitOfMeasrCd", typeof(UnitOfMeasure4Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Val</b> (Value) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Val;
    }
    
    /// <summary>
    /// Class <b>Consignment1</b> (Consignment 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class Consignment1
    {
        
        /// <summary>
        /// Element <b>TtlQty</b> (Total Quantity) of type Quantity3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Quantity3 TtlQty;
        
        /// <summary>
        /// Element <b>TtlVol</b> (Total Volume) of type Quantity3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Quantity3 TtlVol;
        
        /// <summary>
        /// Element <b>TtlWght</b> (Total Weight) of type Quantity3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Quantity3 TtlWght;
    }
    
    /// <summary>
    /// Class <b>TransportedGoods1</b> (Transported Goods 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportedGoods1
    {
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification7 PurchsOrdrRef;
        
        /// <summary>
        /// Element <b>GoodsDesc</b> (Goods Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string GoodsDesc;
        
        /// <summary>
        /// Element <b>BuyrDfndInf</b> (Buyer Defined Information) of type array of UserDefinedInformation1.
        /// </summary>
        [XmlElementAttribute("BuyrDfndInf", Order=2)]
        public UserDefinedInformation1[] BuyrDfndInf;
        
        /// <summary>
        /// Element <b>SellrDfndInf</b> (Seller Defined Information) of type array of UserDefinedInformation1.
        /// </summary>
        [XmlElementAttribute("SellrDfndInf", Order=3)]
        public UserDefinedInformation1[] SellrDfndInf;
    }
    
    /// <summary>
    /// Class <b>UserDefinedInformation1</b> (User Defined Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class UserDefinedInformation1
    {
        
        /// <summary>
        /// Element <b>Labl</b> (Label) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Labl;
        
        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Inf;
    }
    
    /// <summary>
    /// Class <b>TransportDetails2</b> (Transport Details 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportDetails2
    {
        
        /// <summary>
        /// Element <b>TrnsprtDocRef</b> (Transport Document Reference) of type array of DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute("TrnsprtDocRef", Order=0)]
        public DocumentIdentification7[] TrnsprtDocRef;
        
        /// <summary>
        /// Element <b>TrnsprtdGoods</b> (Transported Goods) of type array of TransportedGoods1.
        /// </summary>
        [XmlElementAttribute("TrnsprtdGoods", Order=1)]
        public TransportedGoods1[] TrnsprtdGoods;
        
        /// <summary>
        /// Element <b>Consgnmt</b> (Consignment) of type Consignment1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Consignment1 Consgnmt;
        
        /// <summary>
        /// Element <b>RtgSummry</b> (Routing Summary) of type TransportMeans2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public TransportMeans2 RtgSummry;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute("ActlShipmntDt", typeof(System.DateTime), DataType="date", Order=4)]
        [XmlElementAttribute("PropsdShipmntDt", typeof(System.DateTime), DataType="date", Order=4)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public System.DateTime Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
        
        /// <summary>
        /// Element <b>Incotrms</b> (Incoterms) of type Incoterms2.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public Incoterms2 Incotrms;
        
        /// <summary>
        /// Element <b>FrghtChrgs</b> (Freight Charges) of type Charge13.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public Charge13 FrghtChrgs;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>ActlShipmntDt - Actual Shipment Date</b>.
        /// </summary>
        ActlShipmntDt,
        
        /// <summary>
        /// <b>PropsdShipmntDt - Proposed Shipment Date</b>.
        /// </summary>
        PropsdShipmntDt,
    }
    
    /// <summary>
    /// Class <b>Incoterms2</b> (Incoterms 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class Incoterms2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type Incoterms1Code 
        /// Othr (Other) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(Incoterms1Code), Order=0)]
        [XmlElementAttribute("Othr", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Lctn</b> (Location) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Lctn;
    }
    
    /// <summary>
    /// Enumeration <b>Incoterms1Code</b> (Incoterms 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum Incoterms1Code
    {
        
        /// <summary>
        /// <b>EXW - Ex Works</b>.
        /// </summary>
        EXW,
        
        /// <summary>
        /// <b>FCA - Free Carrier</b>.
        /// </summary>
        FCA,
        
        /// <summary>
        /// <b>FAS - Free Alongside Ship</b>.
        /// </summary>
        FAS,
        
        /// <summary>
        /// <b>FOB - Free On Board</b>.
        /// </summary>
        FOB,
        
        /// <summary>
        /// <b>CFR - Cost And Freight</b>.
        /// </summary>
        CFR,
        
        /// <summary>
        /// <b>CIF - Cost Insurance And Freight</b>.
        /// </summary>
        CIF,
        
        /// <summary>
        /// <b>CPT - Carriage Paid</b>.
        /// </summary>
        CPT,
        
        /// <summary>
        /// <b>CIP - Carriage And Insurance Paid</b>.
        /// </summary>
        CIP,
        
        /// <summary>
        /// <b>DAF - Delivered At Frontier</b>.
        /// </summary>
        DAF,
        
        /// <summary>
        /// <b>DES - Delivered Ex Ship</b>.
        /// </summary>
        DES,
        
        /// <summary>
        /// <b>DEQ - Delivered Ex Quay</b>.
        /// </summary>
        DEQ,
        
        /// <summary>
        /// <b>DDU - Delivered Duty Unpaid</b>.
        /// </summary>
        DDU,
        
        /// <summary>
        /// <b>DDP - Delivered Duty Paid</b>.
        /// </summary>
        DDP,
    }
    
    /// <summary>
    /// Class <b>Charge13</b> (Charge 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class Charge13
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type FreightCharges1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FreightCharges1Code Tp;
        
        /// <summary>
        /// Element <b>Chrgs</b> (Charges) of type array of ChargesDetails2.
        /// </summary>
        [XmlElementAttribute("Chrgs", Order=1)]
        public ChargesDetails2[] Chrgs;
    }
    
    /// <summary>
    /// Enumeration <b>FreightCharges1Code</b> (Freight Charges 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum FreightCharges1Code
    {
        
        /// <summary>
        /// <b>CLCT - Collect</b>.
        /// </summary>
        CLCT,
        
        /// <summary>
        /// <b>PRPD - Prepaid</b>.
        /// </summary>
        PRPD,
    }
    
    /// <summary>
    /// Class <b>ChargesDetails2</b> (Charges Details 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ChargesDetails2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrChrgsTp (Other Charges Type) of type string 
        /// Tp (Type) of type ChargeType8Code 
        /// </summary>
        [XmlElementAttribute("OthrChrgsTp", typeof(string), Order=0)]
        [XmlElementAttribute("Tp", typeof(ChargeType8Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType8Code</b> (Charge Type 8Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum ChargeType8Code
    {
        
        /// <summary>
        /// <b>SIGN - Signature Service</b>.
        /// </summary>
        SIGN,
        
        /// <summary>
        /// <b>STDE - Storage At Destination</b>.
        /// </summary>
        STDE,
        
        /// <summary>
        /// <b>STOR - Storage At Origin</b>.
        /// </summary>
        STOR,
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>PICK - Pick Up</b>.
        /// </summary>
        PICK,
        
        /// <summary>
        /// <b>DNGR - Dangerous Goods Fee</b>.
        /// </summary>
        DNGR,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>INSU - Insurance Premium</b>.
        /// </summary>
        INSU,
        
        /// <summary>
        /// <b>COLF - Collect Freight</b>.
        /// </summary>
        COLF,
        
        /// <summary>
        /// <b>CHOR - Clearance And Handling At Origin</b>.
        /// </summary>
        CHOR,
        
        /// <summary>
        /// <b>CHDE - Clearance And Handling At Destination</b>.
        /// </summary>
        CHDE,
        
        /// <summary>
        /// <b>AIRF - Air Way Bill Fee</b>.
        /// </summary>
        AIRF,
        
        /// <summary>
        /// <b>TRPT - Transport Charges</b>.
        /// </summary>
        TRPT,
    }
    
    /// <summary>
    /// Class <b>TransportDataSet3</b> (Transport Data Set 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class TransportDataSet3
    {
        
        /// <summary>
        /// Element <b>DataSetId</b> (Data Set Identification) of type DocumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification1 DataSetId;
        
        /// <summary>
        /// Element <b>Buyr</b> (Buyer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification26 Buyr;
        
        /// <summary>
        /// Element <b>Sellr</b> (Seller) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification26 Sellr;
        
        /// <summary>
        /// Element <b>Consgnr</b> (Consignor) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification26 Consgnr;
        
        /// <summary>
        /// Element <b>Consgn</b> (Consignee) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification26 Consgn;
        
        /// <summary>
        /// Element <b>ShipTo</b> (Ship To) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification26 ShipTo;
        
        /// <summary>
        /// Element <b>TrnsprtInf</b> (Transport Information) of type TransportDetails2.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public TransportDetails2 TrnsprtInf;
    }
    
    /// <summary>
    /// Class <b>CashAccountType2</b> (Cash Account Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class CashAccountType2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CashAccountType4Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CashAccountType4Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CashAccountType4Code</b> (Cash Account Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum CashAccountType4Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CHAR - Charges</b>.
        /// </summary>
        CHAR,
        
        /// <summary>
        /// <b>COMM - Commission</b>.
        /// </summary>
        COMM,
        
        /// <summary>
        /// <b>TAXE - Tax</b>.
        /// </summary>
        TAXE,
        
        /// <summary>
        /// <b>CISH - Cash Income</b>.
        /// </summary>
        CISH,
        
        /// <summary>
        /// <b>TRAS - Cash Trading</b>.
        /// </summary>
        TRAS,
        
        /// <summary>
        /// <b>SACC - Settlement</b>.
        /// </summary>
        SACC,
        
        /// <summary>
        /// <b>CACC - Current</b>.
        /// </summary>
        CACC,
        
        /// <summary>
        /// <b>SVGS - Savings</b>.
        /// </summary>
        SVGS,
        
        /// <summary>
        /// <b>ONDP - Over Night Deposit</b>.
        /// </summary>
        ONDP,
        
        /// <summary>
        /// <b>MGLD - Marginal Lending</b>.
        /// </summary>
        MGLD,
        
        /// <summary>
        /// <b>NREX - Non Resident External</b>.
        /// </summary>
        NREX,
        
        /// <summary>
        /// <b>MOMA - Money Market</b>.
        /// </summary>
        MOMA,
        
        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,
        
        /// <summary>
        /// <b>SLRY - Salary</b>.
        /// </summary>
        SLRY,
        
        /// <summary>
        /// <b>ODFT - Overdraft</b>.
        /// </summary>
        ODFT,
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class SimpleIdentificationInformation2
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification3Choice</b> (Account Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class AccountIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BBAN (BBAN) of type string 
        /// IBAN (IBAN) of type string 
        /// PrtryAcct (Proprietary Account) of type SimpleIdentificationInformation2 
        /// UPIC (UPIC) of type string 
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryAcct", typeof(SimpleIdentificationInformation2), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>BBAN - Basic Bank Account Number</b>.
        /// </summary>
        BBAN,
        
        /// <summary>
        /// <b>IBAN - International Bank Account Number</b>.
        /// </summary>
        IBAN,
        
        /// <summary>
        /// <b>PrtryAcct - Proprietary Account</b>.
        /// </summary>
        PrtryAcct,
        
        /// <summary>
        /// <b>UPIC - Universal Promotional Identification Code</b>.
        /// </summary>
        UPIC,
    }
    
    /// <summary>
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class CashAccount7
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification3Choice Id;
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccountType2 Tp;
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Nm;
    }
    
    /// <summary>
    /// Class <b>PostalAddress2</b> (Postal Address 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class PostalAddress2
    {
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>PstCdId</b> (Post Code Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PstCdId;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string CtrySubDvsn;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string Ctry;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress6</b> (Name And Address 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class NameAndAddress6
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress2 Adr;
    }
    
    /// <summary>
    /// Class <b>FinancialInstitutionIdentification4Choice</b> (Financial Institution Identification 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class FinancialInstitutionIdentification4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BIC (BIC) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress6 
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress6), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SettlementTerms2</b> (Settlement Terms 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class SettlementTerms2
    {
        
        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type FinancialInstitutionIdentification4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancialInstitutionIdentification4Choice CdtrAgt;
        
        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccount7 CdtrAcct;
    }
    
    /// <summary>
    /// Class <b>PaymentPeriod1</b> (Payment Period 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class PaymentPeriod1
    {
        
        /// <summary>
        /// Element <b>Cd</b> (Code) of type PaymentTime1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PaymentTime1Code Cd;
        
        /// <summary>
        /// Element <b>NbOfDays</b> (Number Of Days) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal NbOfDays;
        
        /// <summary>
        /// Element <b>NbOfDaysSpecified</b> (Number Of Days Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NbOfDaysSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentTime1Code</b> (Payment Time 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum PaymentTime1Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>EMTD - End Of Month Of Delivery</b>.
        /// </summary>
        EMTD,
        
        /// <summary>
        /// <b>EPRD - End Of Period After Delivery</b>.
        /// </summary>
        EPRD,
        
        /// <summary>
        /// <b>PRMD - End Of Period After End Of Delivery Month</b>.
        /// </summary>
        PRMD,
        
        /// <summary>
        /// <b>IREC - Institute Replacement Clause</b>.
        /// </summary>
        IREC,
        
        /// <summary>
        /// <b>PRMR - End Of Period After End Of Receipt Month</b>.
        /// </summary>
        PRMR,
        
        /// <summary>
        /// <b>EPRR - End Of Period After Receipt</b>.
        /// </summary>
        EPRR,
        
        /// <summary>
        /// <b>EMTR - End Of Month Of Receipt</b>.
        /// </summary>
        EMTR,
    }
    
    /// <summary>
    /// Class <b>PaymentTerms1</b> (Payment Terms 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class PaymentTerms1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrPmtTerms (Other Payment Terms) of type string 
        /// PmtCd (Payment Code) of type PaymentPeriod1 
        /// </summary>
        [XmlElementAttribute("OthrPmtTerms", typeof(string), Order=0)]
        [XmlElementAttribute("PmtCd", typeof(PaymentPeriod1), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// Pctg (Percentage) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=1)]
        [XmlElementAttribute("Pctg", typeof(decimal), Order=1)]
        public object Item1;
    }
    
    /// <summary>
    /// Class <b>Tax12</b> (Tax 12).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class Tax12
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrTaxTp (Other Tax Type) of type string 
        /// Tp (Type) of type TaxType9Code 
        /// </summary>
        [XmlElementAttribute("OthrTaxTp", typeof(string), Order=0)]
        [XmlElementAttribute("Tp", typeof(TaxType9Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType9Code</b> (Tax Type 9Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum TaxType9Code
    {
        
        /// <summary>
        /// <b>PROV - Provincial</b>.
        /// </summary>
        PROV,
        
        /// <summary>
        /// <b>NATI - National Tax</b>.
        /// </summary>
        NATI,
        
        /// <summary>
        /// <b>STAT - State Tax</b>.
        /// </summary>
        STAT,
        
        /// <summary>
        /// <b>WITH - With / Withdrawal</b>.
        /// </summary>
        WITH,
        
        /// <summary>
        /// <b>STAM - Stamp Duty</b>.
        /// </summary>
        STAM,
        
        /// <summary>
        /// <b>COAX - Consumption Tax</b>.
        /// </summary>
        COAX,
        
        /// <summary>
        /// <b>VATA - Value Added Tax</b>.
        /// </summary>
        VATA,
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
    }
    
    /// <summary>
    /// Class <b>Adjustment4</b> (Adjustment 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class Adjustment4
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrAdjstmntTp (Other Adjustment Type) of type string 
        /// Tp (Type) of type AdjustmentType2Code 
        /// </summary>
        [XmlElementAttribute("OthrAdjstmntTp", typeof(string), Order=0)]
        [XmlElementAttribute("Tp", typeof(AdjustmentType2Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Drctn</b> (Direction) of type AdjustmentDirection1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdjustmentDirection1Code Drctn;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Enumeration <b>AdjustmentType2Code</b> (Adjustment Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum AdjustmentType2Code
    {
        
        /// <summary>
        /// <b>REBA - Rebate</b>.
        /// </summary>
        REBA,
        
        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
        
        /// <summary>
        /// <b>CREN - Credit Note</b>.
        /// </summary>
        CREN,
        
        /// <summary>
        /// <b>SURC - Surcharge</b>.
        /// </summary>
        SURC,
    }
    
    /// <summary>
    /// Enumeration <b>AdjustmentDirection1Code</b> (Adjustment Direction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum AdjustmentDirection1Code
    {
        
        /// <summary>
        /// <b>ADDD - Added</b>.
        /// </summary>
        ADDD,
        
        /// <summary>
        /// <b>SUBS - Substracted</b>.
        /// </summary>
        SUBS,
    }
    
    /// <summary>
    /// Class <b>ProductCategory1</b> (Product Category 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ProductCategory1
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ProductCategory1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProductCategory1Code Tp;
        
        /// <summary>
        /// Element <b>Ctgy</b> (Category) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Ctgy;
    }
    
    /// <summary>
    /// Enumeration <b>ProductCategory1Code</b> (Product Category 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum ProductCategory1Code
    {
        
        /// <summary>
        /// <b>HRTR - Harmonized Tariff Code Name</b>.
        /// </summary>
        HRTR,
        
        /// <summary>
        /// <b>QOTA - Quota Category</b>.
        /// </summary>
        QOTA,
        
        /// <summary>
        /// <b>PRGP - Product Group</b>.
        /// </summary>
        PRGP,
        
        /// <summary>
        /// <b>LOBU - Line Of Business</b>.
        /// </summary>
        LOBU,
        
        /// <summary>
        /// <b>GNDR - Gender</b>.
        /// </summary>
        GNDR,
    }
    
    /// <summary>
    /// Class <b>ProductCategory1Choice</b> (Product Category 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ProductCategory1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrPdctCtgy (Other Product Category) of type GenericIdentification4 
        /// StrdPdctCtgy (Structured Product Category) of type ProductCategory1 
        /// </summary>
        [XmlElementAttribute("OthrPdctCtgy", typeof(GenericIdentification4), Order=0)]
        [XmlElementAttribute("StrdPdctCtgy", typeof(ProductCategory1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>ProductCharacteristics1</b> (Product Characteristics 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ProductCharacteristics1
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ProductCharacteristics1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProductCharacteristics1Code Tp;
        
        /// <summary>
        /// Element <b>Chrtcs</b> (Characteristics) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Chrtcs;
    }
    
    /// <summary>
    /// Enumeration <b>ProductCharacteristics1Code</b> (Product Characteristics 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum ProductCharacteristics1Code
    {
        
        /// <summary>
        /// <b>BISP - Buyers Item Specification</b>.
        /// </summary>
        BISP,
        
        /// <summary>
        /// <b>CHNR - Chassis Number</b>.
        /// </summary>
        CHNR,
        
        /// <summary>
        /// <b>CLOR - Colour</b>.
        /// </summary>
        CLOR,
        
        /// <summary>
        /// <b>EDSP - Engine Displacement</b>.
        /// </summary>
        EDSP,
        
        /// <summary>
        /// <b>ENNR - Engine Number</b>.
        /// </summary>
        ENNR,
        
        /// <summary>
        /// <b>OPTN - Option</b>.
        /// </summary>
        OPTN,
        
        /// <summary>
        /// <b>ORCR - Origin Criterion</b>.
        /// </summary>
        ORCR,
        
        /// <summary>
        /// <b>PCTV - Percentage By Volume</b>.
        /// </summary>
        PCTV,
        
        /// <summary>
        /// <b>SISP - Sellers Item Specification</b>.
        /// </summary>
        SISP,
        
        /// <summary>
        /// <b>SIZE - Size</b>.
        /// </summary>
        SIZE,
        
        /// <summary>
        /// <b>SZRG - Size Range</b>.
        /// </summary>
        SZRG,
        
        /// <summary>
        /// <b>SPRM - Special Remarks</b>.
        /// </summary>
        SPRM,
        
        /// <summary>
        /// <b>STOR - Storage At Origin</b>.
        /// </summary>
        STOR,
        
        /// <summary>
        /// <b>VINR - Vehicle Identification Number</b>.
        /// </summary>
        VINR,
    }
    
    /// <summary>
    /// Class <b>ProductCharacteristics1Choice</b> (Product Characteristics 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ProductCharacteristics1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrPdctChrtcs (Other Product Characteristics) of type GenericIdentification4 
        /// StrdPdctChrtcs (Structured Product Characteristics) of type ProductCharacteristics1 
        /// </summary>
        [XmlElementAttribute("OthrPdctChrtcs", typeof(GenericIdentification4), Order=0)]
        [XmlElementAttribute("StrdPdctChrtcs", typeof(ProductCharacteristics1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>ProductIdentifier2</b> (Product Identifier 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ProductIdentifier2
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ProductIdentifier2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProductIdentifier2Code Tp;
        
        /// <summary>
        /// Element <b>Idr</b> (Identifier) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Idr;
    }
    
    /// <summary>
    /// Enumeration <b>ProductIdentifier2Code</b> (Product Identifier 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum ProductIdentifier2Code
    {
        
        /// <summary>
        /// <b>BINR - Buyers Item Number</b>.
        /// </summary>
        BINR,
        
        /// <summary>
        /// <b>COMD - Commercial Description Code Name</b>.
        /// </summary>
        COMD,
        
        /// <summary>
        /// <b>EANC - EAN</b>.
        /// </summary>
        EANC,
        
        /// <summary>
        /// <b>HRTR - Harmonized Tariff Code Name</b>.
        /// </summary>
        HRTR,
        
        /// <summary>
        /// <b>MANI - Manufacturers Item Number</b>.
        /// </summary>
        MANI,
        
        /// <summary>
        /// <b>MODL - Model Number</b>.
        /// </summary>
        MODL,
        
        /// <summary>
        /// <b>PART - Formal Partnership</b>.
        /// </summary>
        PART,
        
        /// <summary>
        /// <b>QOTA - Quota Category</b>.
        /// </summary>
        QOTA,
        
        /// <summary>
        /// <b>STYL - Style Number</b>.
        /// </summary>
        STYL,
        
        /// <summary>
        /// <b>SUPI - Suppliers Item Number</b>.
        /// </summary>
        SUPI,
        
        /// <summary>
        /// <b>UPCC - Universal Product Code</b>.
        /// </summary>
        UPCC,
    }
    
    /// <summary>
    /// Class <b>ProductIdentifier2Choice</b> (Product Identifier 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class ProductIdentifier2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrPdctIdr (Other Product Identifier) of type GenericIdentification4 
        /// StrdPdctIdr (Structured Product Identifier) of type ProductIdentifier2 
        /// </summary>
        [XmlElementAttribute("OthrPdctIdr", typeof(GenericIdentification4), Order=0)]
        [XmlElementAttribute("StrdPdctIdr", typeof(ProductIdentifier2), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>UnitPrice9</b> (Unit Price 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class UnitPrice9
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrUnitOfMeasr (Other Unit Of Measure) of type string 
        /// UnitOfMeasrCd (Unit Of Measure Code) of type UnitOfMeasure4Code 
        /// </summary>
        [XmlElementAttribute("OthrUnitOfMeasr", typeof(string), Order=0)]
        [XmlElementAttribute("UnitOfMeasrCd", typeof(UnitOfMeasure4Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>Fctr</b> (Factor) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Fctr;
    }
    
    /// <summary>
    /// Class <b>LineItemDetails9</b> (Line Item Details 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class LineItemDetails9
    {
        
        /// <summary>
        /// Element <b>LineItmId</b> (Line Item Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string LineItmId;
        
        /// <summary>
        /// Element <b>Qty</b> (Quantity) of type Quantity4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Quantity4 Qty;
        
        /// <summary>
        /// Element <b>UnitPric</b> (Unit Price) of type UnitPrice9.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public UnitPrice9 UnitPric;
        
        /// <summary>
        /// Element <b>PdctNm</b> (Product Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string PdctNm;
        
        /// <summary>
        /// Element <b>PdctIdr</b> (Product Identifier) of type array of ProductIdentifier2Choice.
        /// </summary>
        [XmlElementAttribute("PdctIdr", Order=4)]
        public ProductIdentifier2Choice[] PdctIdr;
        
        /// <summary>
        /// Element <b>PdctChrtcs</b> (Product Characteristics) of type array of ProductCharacteristics1Choice.
        /// </summary>
        [XmlElementAttribute("PdctChrtcs", Order=5)]
        public ProductCharacteristics1Choice[] PdctChrtcs;
        
        /// <summary>
        /// Element <b>PdctCtgy</b> (Product Category) of type array of ProductCategory1Choice.
        /// </summary>
        [XmlElementAttribute("PdctCtgy", Order=6)]
        public ProductCategory1Choice[] PdctCtgy;
        
        /// <summary>
        /// Element <b>PdctOrgn</b> (Product Origin) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string PdctOrgn;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type array of Adjustment4.
        /// </summary>
        [XmlElementAttribute("Adjstmnt", Order=8)]
        public Adjustment4[] Adjstmnt;
        
        /// <summary>
        /// Element <b>FrghtChrgs</b> (Freight Charges) of type Charge13.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public Charge13 FrghtChrgs;
        
        /// <summary>
        /// Element <b>Tax</b> (Tax) of type array of Tax12.
        /// </summary>
        [XmlElementAttribute("Tax", Order=10)]
        public Tax12[] Tax;
        
        /// <summary>
        /// Element <b>TtlAmt</b> (Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public CurrencyAndAmount TtlAmt;
    }
    
    /// <summary>
    /// Class <b>LineItem9</b> (Line Item 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class LineItem9
    {
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification7 PurchsOrdrRef;
        
        /// <summary>
        /// Element <b>FnlSubmissn</b> (Final Submission) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool FnlSubmissn;
        
        /// <summary>
        /// Element <b>ComrclLineItms</b> (Commercial Line Items) of type array of LineItemDetails9.
        /// </summary>
        [XmlElementAttribute("ComrclLineItms", Order=2)]
        public LineItemDetails9[] ComrclLineItms;
        
        /// <summary>
        /// Element <b>LineItmsTtlAmt</b> (Line Items Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CurrencyAndAmount LineItmsTtlAmt;
        
        /// <summary>
        /// Element <b>Incotrms</b> (Incoterms) of type Incoterms2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public Incoterms2 Incotrms;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type array of Adjustment4.
        /// </summary>
        [XmlElementAttribute("Adjstmnt", Order=5)]
        public Adjustment4[] Adjstmnt;
        
        /// <summary>
        /// Element <b>FrghtChrgs</b> (Freight Charges) of type Charge13.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public Charge13 FrghtChrgs;
        
        /// <summary>
        /// Element <b>Tax</b> (Tax) of type array of Tax12.
        /// </summary>
        [XmlElementAttribute("Tax", Order=7)]
        public Tax12[] Tax;
        
        /// <summary>
        /// Element <b>TtlNetAmt</b> (Total Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public CurrencyAndAmount TtlNetAmt;
        
        /// <summary>
        /// Element <b>BuyrDfndInf</b> (Buyer Defined Information) of type array of UserDefinedInformation1.
        /// </summary>
        [XmlElementAttribute("BuyrDfndInf", Order=9)]
        public UserDefinedInformation1[] BuyrDfndInf;
        
        /// <summary>
        /// Element <b>SellrDfndInf</b> (Seller Defined Information) of type array of UserDefinedInformation1.
        /// </summary>
        [XmlElementAttribute("SellrDfndInf", Order=10)]
        public UserDefinedInformation1[] SellrDfndInf;
    }
    
    /// <summary>
    /// Class <b>InvoiceIdentification1</b> (Invoice Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class InvoiceIdentification1
    {
        
        /// <summary>
        /// Element <b>InvcNb</b> (Invoice Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string InvcNb;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime IsseDt;
    }
    
    /// <summary>
    /// Class <b>CommercialDataSet3</b> (Commercial Data Set 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class CommercialDataSet3
    {
        
        /// <summary>
        /// Element <b>DataSetId</b> (Data Set Identification) of type DocumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification1 DataSetId;
        
        /// <summary>
        /// Element <b>ComrclDocRef</b> (Commercial Document Reference) of type InvoiceIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public InvoiceIdentification1 ComrclDocRef;
        
        /// <summary>
        /// Element <b>Buyr</b> (Buyer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification26 Buyr;
        
        /// <summary>
        /// Element <b>Sellr</b> (Seller) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification26 Sellr;
        
        /// <summary>
        /// Element <b>BllTo</b> (Bill To) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification26 BllTo;
        
        /// <summary>
        /// Element <b>Goods</b> (Goods) of type array of LineItem9.
        /// </summary>
        [XmlElementAttribute("Goods", Order=5)]
        public LineItem9[] Goods;
        
        /// <summary>
        /// Element <b>PmtTerms</b> (Payment Terms) of type array of PaymentTerms1.
        /// </summary>
        [XmlElementAttribute("PmtTerms", Order=6)]
        public PaymentTerms1[] PmtTerms;
        
        /// <summary>
        /// Element <b>SttlmTerms</b> (Settlement Terms) of type SettlementTerms2.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public SettlementTerms2 SttlmTerms;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification3</b> (Document Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class DocumentIdentification3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Vrsn</b> (Version) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Vrsn;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification5</b> (Document Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class DocumentIdentification5
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdIssr</b> (Identification Issuer) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BICIdentification1 IdIssr;
    }
    
    /// <summary>
    /// Class <b>DataSetSubmissionReferences4</b> (Data Set Submission References 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public class DataSetSubmissionReferences4
    {
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TxId;
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentIdentification7 PurchsOrdrRef;
        
        /// <summary>
        /// Element <b>UsrTxRef</b> (User Transaction Reference) of type array of DocumentIdentification5.
        /// </summary>
        [XmlElementAttribute("UsrTxRef", Order=2)]
        public DocumentIdentification5[] UsrTxRef;
        
        /// <summary>
        /// Element <b>ForcdMtch</b> (Forced Match) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool ForcdMtch;
        
        /// <summary>
        /// Element <b>EstblishdBaselnId</b> (Established Baseline Identification) of type DocumentIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DocumentIdentification3 EstblishdBaselnId;
        
        /// <summary>
        /// Element <b>TxSts</b> (Transaction Status) of type BaselineStatus3Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public BaselineStatus3Code TxSts;
    }
    
    /// <summary>
    /// Enumeration <b>BaselineStatus3Code</b> (Baseline Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.017.001.03")]
    public enum BaselineStatus3Code
    {
        
        /// <summary>
        /// <b>PROP - Proposed</b>.
        /// </summary>
        PROP,
        
        /// <summary>
        /// <b>CLSD - Closed</b>.
        /// </summary>
        CLSD,
        
        /// <summary>
        /// <b>PMTC - Partially Matched</b>.
        /// </summary>
        PMTC,
        
        /// <summary>
        /// <b>ESTD - Established</b>.
        /// </summary>
        ESTD,
        
        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
        
        /// <summary>
        /// <b>AMRQ - Amendment Requested</b>.
        /// </summary>
        AMRQ,
        
        /// <summary>
        /// <b>RARQ - Re Activate Requested</b>.
        /// </summary>
        RARQ,
        
        /// <summary>
        /// <b>CLRQ - Close Requested</b>.
        /// </summary>
        CLRQ,
        
        /// <summary>
        /// <b>SCRQ - Complete Requested</b>.
        /// </summary>
        SCRQ,
        
        /// <summary>
        /// <b>SERQ - Status Extension Requested</b>.
        /// </summary>
        SERQ,
        
        /// <summary>
        /// <b>DARQ - Data Set Acceptance Requested</b>.
        /// </summary>
        DARQ,
    }
}
