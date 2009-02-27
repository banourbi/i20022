
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



namespace i20022.tsmt01100103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.011.001.03 name BaselineReportV03 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>BaselnRpt</b> (Baseline Report) of type BaselineReportV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public BaselineReportV03 BaselnRpt;
    }
    
    /// <summary>
    /// Class <b>BaselineReportV03</b> (Baseline Report V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class BaselineReportV03
    {
        
        /// <summary>
        /// Element <b>RptId</b> (Report Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 RptId;
        
        /// <summary>
        /// Element <b>RltdMsgRef</b> (Related Message Reference) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public MessageIdentification1 RltdMsgRef;
        
        /// <summary>
        /// Element <b>RptTp</b> (Report Type) of type ReportType2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ReportType2 RptTp;
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public SimpleIdentificationInformation TxId;
        
        /// <summary>
        /// Element <b>EstblishdBaselnId</b> (Established Baseline Identification) of type DocumentIdentification6.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DocumentIdentification6 EstblishdBaselnId;
        
        /// <summary>
        /// Element <b>TxSts</b> (Transaction Status) of type TransactionStatus4.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public TransactionStatus4 TxSts;
        
        /// <summary>
        /// Element <b>UsrTxRef</b> (User Transaction Reference) of type array of DocumentIdentification5.
        /// </summary>
        [XmlElementAttribute("UsrTxRef", Order=6)]
        public DocumentIdentification5[] UsrTxRef;
        
        /// <summary>
        /// Element <b>Buyr</b> (Buyer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentification26 Buyr;
        
        /// <summary>
        /// Element <b>Sellr</b> (Seller) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public PartyIdentification26 Sellr;
        
        /// <summary>
        /// Element <b>BuyrBk</b> (Buyer Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public BICIdentification1 BuyrBk;
        
        /// <summary>
        /// Element <b>SellrBk</b> (Seller Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public BICIdentification1 SellrBk;
        
        /// <summary>
        /// Element <b>RptdLineItm</b> (Reported Line Item) of type LineItem8.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public LineItem8 RptdLineItm;
        
        /// <summary>
        /// Element <b>ReqForActn</b> (Request For Action) of type PendingActivity2.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public PendingActivity2 ReqForActn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>PercentageTolerance1</b> (Percentage Tolerance 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class PercentageTolerance1
    {
        
        /// <summary>
        /// Element <b>PlusPct</b> (Plus Percent) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal PlusPct;
        
        /// <summary>
        /// Element <b>MnsPct</b> (Minus Percent) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal MnsPct;
    }
    
    /// <summary>
    /// Class <b>Quantity4</b> (Quantity 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>ProductCategory1</b> (Product Category 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>ProductCharacteristics1</b> (Product Characteristics 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>LineItemDetails8</b> (Line Item Details 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class LineItemDetails8
    {
        
        /// <summary>
        /// Element <b>LineItmId</b> (Line Item Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string LineItmId;
        
        /// <summary>
        /// Element <b>PdctNm</b> (Product Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PdctNm;
        
        /// <summary>
        /// Element <b>PdctIdr</b> (Product Identifier) of type array of ProductIdentifier2Choice.
        /// </summary>
        [XmlElementAttribute("PdctIdr", Order=2)]
        public ProductIdentifier2Choice[] PdctIdr;
        
        /// <summary>
        /// Element <b>PdctChrtcs</b> (Product Characteristics) of type array of ProductCharacteristics1Choice.
        /// </summary>
        [XmlElementAttribute("PdctChrtcs", Order=3)]
        public ProductCharacteristics1Choice[] PdctChrtcs;
        
        /// <summary>
        /// Element <b>PdctCtgy</b> (Product Category) of type array of ProductCategory1Choice.
        /// </summary>
        [XmlElementAttribute("PdctCtgy", Order=4)]
        public ProductCategory1Choice[] PdctCtgy;
        
        /// <summary>
        /// Element <b>OrdrdQty</b> (Ordered Quantity) of type Quantity4.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public Quantity4 OrdrdQty;
        
        /// <summary>
        /// Element <b>AccptdQty</b> (Accepted Quantity) of type Quantity4.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public Quantity4 AccptdQty;
        
        /// <summary>
        /// Element <b>OutsdngQty</b> (Outstanding Quantity) of type Quantity4.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public Quantity4 OutsdngQty;
        
        /// <summary>
        /// Element <b>PdgQty</b> (Pending Quantity) of type Quantity4.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public Quantity4 PdgQty;
        
        /// <summary>
        /// Element <b>QtyTlrnce</b> (Quantity Tolerance) of type PercentageTolerance1.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PercentageTolerance1 QtyTlrnce;
        
        /// <summary>
        /// Element <b>OrdrdAmt</b> (Ordered Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public CurrencyAndAmount OrdrdAmt;
        
        /// <summary>
        /// Element <b>AccptdAmt</b> (Accepted Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public CurrencyAndAmount AccptdAmt;
        
        /// <summary>
        /// Element <b>OutsdngAmt</b> (Outstanding Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public CurrencyAndAmount OutsdngAmt;
        
        /// <summary>
        /// Element <b>PdgAmt</b> (Pending Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public CurrencyAndAmount PdgAmt;
        
        /// <summary>
        /// Element <b>PricTlrnce</b> (Price Tolerance) of type PercentageTolerance1.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public PercentageTolerance1 PricTlrnce;
    }
    
    /// <summary>
    /// Class <b>LineItem8</b> (Line Item 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class LineItem8
    {
        
        /// <summary>
        /// Element <b>LineItmDtls</b> (Line Item Details) of type array of LineItemDetails8.
        /// </summary>
        [XmlElementAttribute("LineItmDtls", Order=0)]
        public LineItemDetails8[] LineItmDtls;
        
        /// <summary>
        /// Element <b>OrdrdLineItmsTtlAmt</b> (Ordered Line Items Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CurrencyAndAmount OrdrdLineItmsTtlAmt;
        
        /// <summary>
        /// Element <b>AccptdLineItmsTtlAmt</b> (Accepted Line Items Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount AccptdLineItmsTtlAmt;
        
        /// <summary>
        /// Element <b>OutsdngLineItmsTtlAmt</b> (Outstanding Line Items Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CurrencyAndAmount OutsdngLineItmsTtlAmt;
        
        /// <summary>
        /// Element <b>PdgLineItmsTtlAmt</b> (Pending Line Items Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CurrencyAndAmount PdgLineItmsTtlAmt;
        
        /// <summary>
        /// Element <b>OrdrdTtlNetAmt</b> (Ordered Total Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CurrencyAndAmount OrdrdTtlNetAmt;
        
        /// <summary>
        /// Element <b>AccptdTtlNetAmt</b> (Accepted Total Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CurrencyAndAmount AccptdTtlNetAmt;
        
        /// <summary>
        /// Element <b>OutsdngTtlNetAmt</b> (Outstanding Total Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public CurrencyAndAmount OutsdngTtlNetAmt;
        
        /// <summary>
        /// Element <b>PdgTtlNetAmt</b> (Pending Total Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public CurrencyAndAmount PdgTtlNetAmt;
    }
    
    /// <summary>
    /// Class <b>PostalAddress5</b> (Postal Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>PartyIdentification26</b> (Party Identification 26).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification5</b> (Document Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    /// Class <b>TransactionStatus4</b> (Transaction Status 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class TransactionStatus4
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type BaselineStatus3Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public BaselineStatus3Code Sts;
    }
    
    /// <summary>
    /// Enumeration <b>BaselineStatus3Code</b> (Baseline Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
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
    
    /// <summary>
    /// Class <b>DocumentIdentification6</b> (Document Identification 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class DocumentIdentification6
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
        /// Element <b>AmdmntSeqNb</b> (Amendment Sequence Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AmdmntSeqNb;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>ReportType2</b> (Report Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public class ReportType2
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ReportType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ReportType2Code Tp;
    }
    
    /// <summary>
    /// Enumeration <b>ReportType2Code</b> (Report Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.011.001.03")]
    public enum ReportType2Code
    {
        
        /// <summary>
        /// <b>PREC - Precalculated / Preliminary Announcement: Confirmed</b>.
        /// </summary>
        PREC,
        
        /// <summary>
        /// <b>CURR - Incorrect Currency</b>.
        /// </summary>
        CURR,
    }
}
