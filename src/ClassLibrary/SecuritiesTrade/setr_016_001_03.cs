
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



namespace i20022.setr01600103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id setr.016.001.03 name OrderInstructionStatusReportV03 from Securities Trade business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>OrdrInstrStsRptV03</b> (Order Instruction Status Report V03) of type OrderInstructionStatusReportV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public OrderInstructionStatusReportV03 OrdrInstrStsRptV03;
    }
    
    /// <summary>
    /// Class <b>OrderInstructionStatusReportV03</b> (Order Instruction Status Report V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class OrderInstructionStatusReportV03
    {
        
        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 MsgId;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute("OthrRef", typeof(AdditionalReference3), Order=1)]
        [XmlElementAttribute("RltdRef", typeof(AdditionalReference3), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public AdditionalReference3[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>Items1</b> (Items 1) of type array of object.
        /// [XOR] This element can be:
        /// IndvOrdrDtlsRpt (Individual Order Details Report) of type IndividualOrderStatusAndReason2 
        /// OrdrDtlsRpt (Order Details Report) of type OrderStatusAndReason7 
        /// SwtchOrdrDtlsRpt (Switch Order Details Report) of type SwitchOrderStatusAndReason1 
        /// </summary>
        [XmlElementAttribute("IndvOrdrDtlsRpt", typeof(IndividualOrderStatusAndReason2), Order=3)]
        [XmlElementAttribute("OrdrDtlsRpt", typeof(OrderStatusAndReason7), Order=3)]
        [XmlElementAttribute("SwtchOrdrDtlsRpt", typeof(SwitchOrderStatusAndReason1), Order=3)]
        public object[] Items1;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=4)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
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
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class Extension1
    {
        
        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PlcAndNm;
        
        /// <summary>
        /// Element <b>Txt</b> (Text) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Txt;
    }
    
    /// <summary>
    /// Class <b>FundOrderData2</b> (Fund Order Data 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class FundOrderData2
    {
        
        /// <summary>
        /// Element <b>TtlRedAmt</b> (Total Redemption Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveOrHistoricCurrencyAndAmount TtlRedAmt;
        
        /// <summary>
        /// Element <b>TtlSbcptAmt</b> (Total Subscription Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount TtlSbcptAmt;
        
        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAndAmount SttlmAmt;
        
        /// <summary>
        /// Element <b>SttlmMtd</b> (Settlement Method) of type DeliveryReceiptType2Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DeliveryReceiptType2Code SttlmMtd;
        
        /// <summary>
        /// Element <b>SttlmMtdSpecified</b> (Settlement Method Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmMtdSpecified;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute("AddtlCshIn", typeof(ActiveOrHistoricCurrencyAndAmount), Order=4)]
        [XmlElementAttribute("RsltgCshOut", typeof(ActiveOrHistoricCurrencyAndAmount), Order=4)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ActiveOrHistoricCurrencyAndAmount Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
        
        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string UnitCcy;
        
        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string QtdCcy;
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class ActiveOrHistoricCurrencyAndAmount
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
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class ActiveCurrencyAndAmount
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
    /// Enumeration <b>DeliveryReceiptType2Code</b> (Delivery Receipt Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum DeliveryReceiptType2Code
    {
        
        /// <summary>
        /// <b>FREE - Separate Settlement</b>.
        /// </summary>
        FREE,
        
        /// <summary>
        /// <b>APMT - Against Payment Settlement</b>.
        /// </summary>
        APMT,
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType4</b> (Item Choice Type 4).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType4
    {
        
        /// <summary>
        /// <b>AddtlCshIn - Additional Cash In</b>.
        /// </summary>
        AddtlCshIn,
        
        /// <summary>
        /// <b>RsltgCshOut - Resulting Cash Out</b>.
        /// </summary>
        RsltgCshOut,
    }
    
    /// <summary>
    /// Class <b>SwitchLegReferences1</b> (Switch Leg References 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class SwitchLegReferences1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("RedLegId", typeof(string), Order=0)]
        [XmlElementAttribute("SbcptLegId", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
        
        /// <summary>
        /// Element <b>LegRjctnRsn</b> (Leg Rejection Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string LegRjctnRsn;
        
        /// <summary>
        /// Element <b>RprdConds</b> (Repaired Conditions) of type RepairedConditions3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public RepairedConditions3 RprdConds;
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount13.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public InvestmentAccount13 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstrument10 FinInstrmDtls;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>RedLegId - Redemption Leg Identification</b>.
        /// </summary>
        RedLegId,
        
        /// <summary>
        /// <b>SbcptLegId - Subscription Leg Identification</b>.
        /// </summary>
        SbcptLegId,
    }
    
    /// <summary>
    /// Class <b>RepairedConditions3</b> (Repaired Conditions 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class RepairedConditions3
    {
        
        /// <summary>
        /// Element <b>RprdChrg</b> (Repaired Charge) of type array of Charge19.
        /// </summary>
        [XmlElementAttribute("RprdChrg", Order=0)]
        public Charge19[] RprdChrg;
        
        /// <summary>
        /// Element <b>RprdComssn</b> (Repaired Commission) of type array of Commission11.
        /// </summary>
        [XmlElementAttribute("RprdComssn", Order=1)]
        public Commission11[] RprdComssn;
    }
    
    /// <summary>
    /// Class <b>Charge19</b> (Charge 19).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class Charge19
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type ChargeType11Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(ChargeType11Code), Order=0)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAnd13DecimalAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAnd13DecimalAmount), Order=1)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=1)]
        public object Item1;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType11Code</b> (Charge Type 11 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum ChargeType11Code
    {
        
        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,
        
        /// <summary>
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,
        
        /// <summary>
        /// <b>SWIT - Switch</b>.
        /// </summary>
        SWIT,
        
        /// <summary>
        /// <b>DLEV - Dilution Levy</b>.
        /// </summary>
        DLEV,
        
        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
        
        /// <summary>
        /// <b>PENA - Penalty</b>.
        /// </summary>
        PENA,
        
        /// <summary>
        /// <b>POST - Postage Charge</b>.
        /// </summary>
        POST,
        
        /// <summary>
        /// <b>REGF - Regulatory Fee</b>.
        /// </summary>
        REGF,
        
        /// <summary>
        /// <b>SHIP - Shipping Charge</b>.
        /// </summary>
        SHIP,
        
        /// <summary>
        /// <b>CHAR - Charges</b>.
        /// </summary>
        CHAR,
        
        /// <summary>
        /// <b>CDSC - Contingency Deferred Sales Charge</b>.
        /// </summary>
        CDSC,
        
        /// <summary>
        /// <b>CBCH - Correspondent Bank Charge</b>.
        /// </summary>
        CBCH,
        
        /// <summary>
        /// <b>PREM - Premium</b>.
        /// </summary>
        PREM,
        
        /// <summary>
        /// <b>INIT - Initial</b>.
        /// </summary>
        INIT,
        
        /// <summary>
        /// <b>BRKF - Brokerage Fee</b>.
        /// </summary>
        BRKF,
        
        /// <summary>
        /// <b>UCIC - UCITS Commission</b>.
        /// </summary>
        UCIC,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class ActiveCurrencyAnd13DecimalAmount
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
    /// Class <b>Commission11</b> (Commission 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class Commission11
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAnd13DecimalAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAnd13DecimalAmount), Order=0)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type CommissionType6Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(CommissionType6Code), Order=1)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=1)]
        public object Item1;
        
        /// <summary>
        /// Element <b>ComrclAgrmtRef</b> (Commercial Agreement Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ComrclAgrmtRef;
        
        /// <summary>
        /// Element <b>NewComrclAgrmtRefInd</b> (New Commercial Agreement Reference Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool NewComrclAgrmtRefInd;
        
        /// <summary>
        /// Element <b>NewComrclAgrmtRefIndSpecified</b> (New Commercial Agreement Reference Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewComrclAgrmtRefIndSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>CommissionType6Code</b> (Commission Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum CommissionType6Code
    {
        
        /// <summary>
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,
        
        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,
        
        /// <summary>
        /// <b>CDPL - Commission De Placement</b>.
        /// </summary>
        CDPL,
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount13</b> (Investment Account 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class InvestmentAccount13
    {
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>AcctNm</b> (Account Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AcctNm;
        
        /// <summary>
        /// Element <b>AcctDsgnt</b> (Account Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctDsgnt;
        
        /// <summary>
        /// Element <b>OwnrId</b> (Owner Identification) of type array of PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute("OwnrId", Order=3)]
        public PartyIdentification2Choice[] OwnrId;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class AccountIdentification1
    {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class PartyIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class NameAndAddress5
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 Adr;
    }
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class PostalAddress1
    {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType2Code AdrTp;
        
        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified;
        
        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute("AdrLine", Order=1)]
        public string[] AdrLine;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string BldgNb;
        
        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string PstCd;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string CtrySubDvsn;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Ctry;
    }
    
    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum AddressType2Code
    {
        
        /// <summary>
        /// <b>ADDR - Postal</b>.
        /// </summary>
        ADDR,
        
        /// <summary>
        /// <b>PBOX - POBox</b>.
        /// </summary>
        PBOX,
        
        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,
        
        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,
        
        /// <summary>
        /// <b>MLTO - Mail To</b>.
        /// </summary>
        MLTO,
        
        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class GenericIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrument10</b> (Financial Instrument 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class FinancialInstrument10
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification3Choice Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>SplmtryId</b> (Supplementary Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string SplmtryId;
        
        /// <summary>
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string ClssTp;
        
        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FormOfSecurity1Code SctiesForm;
        
        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;
        
        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DistributionPolicy1Code DstrbtnPlcy;
        
        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;
        
        /// <summary>
        /// Element <b>PdctGrp</b> (Product Group) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string PdctGrp;
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class SecurityIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Belgn (Belgian) of type string 
        /// Blmbrg (Bloomberg) of type string 
        /// CTA (CTA) of type string 
        /// CUSIP (CUSIP) of type string 
        /// Cmon (Common) of type string 
        /// Dtch (Dutch) of type string 
        /// ISIN (ISIN) of type string 
        /// OthrPrtryId (Other Proprietary Identification) of type AlternateSecurityIdentification1 
        /// QUICK (QUICK) of type string 
        /// RIC (RIC) of type string 
        /// SCVM (Sicovam) of type string 
        /// SEDOL (SEDOL) of type string 
        /// TckrSymb (Ticker Symbol) of type string 
        /// Vlrn (Valoren) of type string 
        /// Wrtppr (Wertpapier) of type string 
        /// </summary>
        [XmlElementAttribute("Belgn", typeof(string), Order=0)]
        [XmlElementAttribute("Blmbrg", typeof(string), Order=0)]
        [XmlElementAttribute("CTA", typeof(string), Order=0)]
        [XmlElementAttribute("CUSIP", typeof(string), Order=0)]
        [XmlElementAttribute("Cmon", typeof(string), Order=0)]
        [XmlElementAttribute("Dtch", typeof(string), Order=0)]
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("OthrPrtryId", typeof(AlternateSecurityIdentification1), Order=0)]
        [XmlElementAttribute("QUICK", typeof(string), Order=0)]
        [XmlElementAttribute("RIC", typeof(string), Order=0)]
        [XmlElementAttribute("SCVM", typeof(string), Order=0)]
        [XmlElementAttribute("SEDOL", typeof(string), Order=0)]
        [XmlElementAttribute("TckrSymb", typeof(string), Order=0)]
        [XmlElementAttribute("Vlrn", typeof(string), Order=0)]
        [XmlElementAttribute("Wrtppr", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class AlternateSecurityIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("DmstIdSrc", typeof(string), Order=1)]
        [XmlElementAttribute("PrtryIdSrc", typeof(string), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>DmstIdSrc - Domestic Identification Source</b>.
        /// </summary>
        DmstIdSrc,
        
        /// <summary>
        /// <b>PrtryIdSrc - Proprietary Identification Source</b>.
        /// </summary>
        PrtryIdSrc,
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>Belgn - Belgiam</b>.
        /// </summary>
        Belgn,
        
        /// <summary>
        /// <b>Blmbrg - Bloomberg Symbol</b>.
        /// </summary>
        Blmbrg,
        
        /// <summary>
        /// <b>CTA - Consolidated Tape Association</b>.
        /// </summary>
        CTA,
        
        /// <summary>
        /// <b>CUSIP - Committee on Uniform Security Identification Procedures</b>.
        /// </summary>
        CUSIP,
        
        /// <summary>
        /// <b>Cmon - Common</b>.
        /// </summary>
        Cmon,
        
        /// <summary>
        /// <b>Dtch - Dutch</b>.
        /// </summary>
        Dtch,
        
        /// <summary>
        /// <b>ISIN - International Securities Identification Number</b>.
        /// </summary>
        ISIN,
        
        /// <summary>
        /// <b>OthrPrtryId - Other Proprietary Identification</b>.
        /// </summary>
        OthrPrtryId,
        
        /// <summary>
        /// <b>QUICK - QUICK Security Id</b>.
        /// </summary>
        QUICK,
        
        /// <summary>
        /// <b>RIC - RIC Security Id</b>.
        /// </summary>
        RIC,
        
        /// <summary>
        /// <b>SCVM - Sicovam</b>.
        /// </summary>
        SCVM,
        
        /// <summary>
        /// <b>SEDOL - Stock Exchange Daily Official List</b>.
        /// </summary>
        SEDOL,
        
        /// <summary>
        /// <b>TckrSymb - Ticker Symbol</b>.
        /// </summary>
        TckrSymb,
        
        /// <summary>
        /// <b>Vlrn - Valoren</b>.
        /// </summary>
        Vlrn,
        
        /// <summary>
        /// <b>Wrtppr - Wertpapier</b>.
        /// </summary>
        Wrtppr,
    }
    
    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum FormOfSecurity1Code
    {
        
        /// <summary>
        /// <b>BEAR - Bearer Share Exchange</b>.
        /// </summary>
        BEAR,
        
        /// <summary>
        /// <b>REGD - Registered / Registered Share Exchange</b>.
        /// </summary>
        REGD,
    }
    
    /// <summary>
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum DistributionPolicy1Code
    {
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
        
        /// <summary>
        /// <b>ACCU - Accumulation</b>.
        /// </summary>
        ACCU,
    }
    
    /// <summary>
    /// Class <b>SwitchOrderStatusAndReason1</b> (Switch Order Status And Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class SwitchOrderStatusAndReason1
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string OrdrRef;
        
        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ClntRef;
        
        /// <summary>
        /// Element <b>DealRef</b> (Deal Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DealRef;
        
        /// <summary>
        /// Element <b>CxlRef</b> (Cancellation Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string CxlRef;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// Canc (Cancelled) of type CancelledStatus2 
        /// CondlyAccptd (Conditionally Accepted) of type ConditionallyAcceptedStatus2 
        /// InRpr (In Repair) of type InRepairStatus2 
        /// PrtlySttld (Partially Settled) of type PartiallySettledStatus1 
        /// Rjctd (Rejected) of type RejectedStatus6 
        /// Sspd (Suspended) of type SuspendedStatus2 
        /// Sts (Status) of type OrderStatus4Code 
        /// </summary>
        [XmlElementAttribute("Canc", typeof(CancelledStatus2), Order=5)]
        [XmlElementAttribute("CondlyAccptd", typeof(ConditionallyAcceptedStatus2), Order=5)]
        [XmlElementAttribute("InRpr", typeof(InRepairStatus2), Order=5)]
        [XmlElementAttribute("PrtlySttld", typeof(PartiallySettledStatus1), Order=5)]
        [XmlElementAttribute("Rjctd", typeof(RejectedStatus6), Order=5)]
        [XmlElementAttribute("Sspd", typeof(SuspendedStatus2), Order=5)]
        [XmlElementAttribute("Sts", typeof(OrderStatus4Code), Order=5)]
        public object[] Items;
        
        /// <summary>
        /// Element <b>LegInf</b> (Leg Information) of type array of SwitchLegReferences1.
        /// </summary>
        [XmlElementAttribute("LegInf", Order=6)]
        public SwitchLegReferences1[] LegInf;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentification2Choice StsInitr;
        
        /// <summary>
        /// Element <b>OrdrData</b> (Order Data) of type FundOrderData2.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public FundOrderData2 OrdrData;
        
        /// <summary>
        /// Element <b>NewDtls</b> (New Details) of type ExpectedExecutionDetails2.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public ExpectedExecutionDetails2 NewDtls;
    }
    
    /// <summary>
    /// Class <b>CancelledStatus2</b> (Cancelled Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class CancelledStatus2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoSpcfdRsn (No Specified Reason) of type NoReasonCode 
        /// Rsn (Reason) of type CancelledStatusReason2Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoSpcfdRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(CancelledStatusReason2Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>NoReasonCode</b> (No Reason Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum NoReasonCode
    {
        
        /// <summary>
        /// <b>NORE - No Reason</b>.
        /// </summary>
        NORE,
    }
    
    /// <summary>
    /// Enumeration <b>CancelledStatusReason2Code</b> (Cancelled Status Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum CancelledStatusReason2Code
    {
        
        /// <summary>
        /// <b>CANH - Cancelled By Hub</b>.
        /// </summary>
        CANH,
        
        /// <summary>
        /// <b>CANP - Pending</b>.
        /// </summary>
        CANP,
        
        /// <summary>
        /// <b>CXLR - End Of Life</b>.
        /// </summary>
        CXLR,
        
        /// <summary>
        /// <b>CANO - Cancelled By Other</b>.
        /// </summary>
        CANO,
    }
    
    /// <summary>
    /// Class <b>ConditionallyAcceptedStatus2</b> (Conditionally Accepted Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class ConditionallyAcceptedStatus2
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// NoSpcfdRsn (No Specified Reason) of type NoReasonCode 
        /// RsnDtls (Reason Details) of type ConditionallyAcceptedStatusReason2 
        /// </summary>
        [XmlElementAttribute("NoSpcfdRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("RsnDtls", typeof(ConditionallyAcceptedStatusReason2), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>ConditionallyAcceptedStatusReason2</b> (Conditionally Accepted Status Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class ConditionallyAcceptedStatusReason2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type ConditionallyAcceptedStatusReason2Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(ConditionallyAcceptedStatusReason2Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>ConditionallyAcceptedStatusReason2Code</b> (Conditionally Accepted Status Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum ConditionallyAcceptedStatusReason2Code
    {
        
        /// <summary>
        /// <b>DOCC - Awaiting Documents</b>.
        /// </summary>
        DOCC,
        
        /// <summary>
        /// <b>AWRM - Awaiting Redemption Money</b>.
        /// </summary>
        AWRM,
        
        /// <summary>
        /// <b>AWSM - Awaiting Subscription Money</b>.
        /// </summary>
        AWSM,
        
        /// <summary>
        /// <b>DUPL - Duplicate Payment</b>.
        /// </summary>
        DUPL,
        
        /// <summary>
        /// <b>CRED - Borne By Creditor</b>.
        /// </summary>
        CRED,
    }
    
    /// <summary>
    /// Class <b>InRepairStatus2</b> (In Repair Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class InRepairStatus2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// NoSpcfdRsn (No Specified Reason) of type NoReasonCode 
        /// RsnDtls (Reason Details) of type InRepairStatusReason3 
        /// </summary>
        [XmlElementAttribute("NoSpcfdRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("RsnDtls", typeof(InRepairStatusReason3), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>InRepairStatusReason3</b> (In Repair Status Reason 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class InRepairStatusReason3
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type InRepairStatusReason1Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(InRepairStatusReason1Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>InRepairStatusReason1Code</b> (In Repair Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum InRepairStatusReason1Code
    {
        
        /// <summary>
        /// <b>COMA - Commercial Agreement</b>.
        /// </summary>
        COMA,
    }
    
    /// <summary>
    /// Class <b>PartiallySettledStatus1</b> (Partially Settled Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class PartiallySettledStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type SettledStatusReason1Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(SettledStatusReason1Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>SettledStatusReason1Code</b> (Settled Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum SettledStatusReason1Code
    {
        
        /// <summary>
        /// <b>UPST - Units Partially Settled</b>.
        /// </summary>
        UPST,
        
        /// <summary>
        /// <b>CPST - Cash Partially Settled</b>.
        /// </summary>
        CPST,
        
        /// <summary>
        /// <b>UCPS - Units Cash Partially Settled</b>.
        /// </summary>
        UCPS,
    }
    
    /// <summary>
    /// Class <b>RejectedStatus6</b> (Rejected Status 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class RejectedStatus6
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type RejectedStatusReason7Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(RejectedStatusReason7Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>RejectedStatusReason7Code</b> (Rejected Status Reason 7Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum RejectedStatusReason7Code
    {
        
        /// <summary>
        /// <b>POIN - Different Valuation Points</b>.
        /// </summary>
        POIN,
        
        /// <summary>
        /// <b>ICAG - Delivering Agent</b>.
        /// </summary>
        ICAG,
        
        /// <summary>
        /// <b>IDDB - Direct Debit</b>.
        /// </summary>
        IDDB,
        
        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,
        
        /// <summary>
        /// <b>SAFE - Investment Account</b>.
        /// </summary>
        SAFE,
        
        /// <summary>
        /// <b>IPAY - Payment Initiated</b>.
        /// </summary>
        IPAY,
        
        /// <summary>
        /// <b>ICTR - Invalid Credit Transfer</b>.
        /// </summary>
        ICTR,
        
        /// <summary>
        /// <b>DEPT - Settlement Place</b>.
        /// </summary>
        DEPT,
        
        /// <summary>
        /// <b>IVAG - Receiving Agent</b>.
        /// </summary>
        IVAG,
        
        /// <summary>
        /// <b>ISAF - Safekeeping Place</b>.
        /// </summary>
        ISAF,
        
        /// <summary>
        /// <b>DFOR - Due Formation And Organisation</b>.
        /// </summary>
        DFOR,
        
        /// <summary>
        /// <b>DSEC - Financial Instrument Identification</b>.
        /// </summary>
        DSEC,
        
        /// <summary>
        /// <b>BLCA - Account Blocked For Corporate Action</b>.
        /// </summary>
        BLCA,
        
        /// <summary>
        /// <b>BLTR - Account Blocked For Transfer</b>.
        /// </summary>
        BLTR,
        
        /// <summary>
        /// <b>DOCC - Awaiting Documents</b>.
        /// </summary>
        DOCC,
        
        /// <summary>
        /// <b>MONY - Not Enough Cash</b>.
        /// </summary>
        MONY,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>IDNA - Financial Instrument Identification And Name</b>.
        /// </summary>
        IDNA,
        
        /// <summary>
        /// <b>UWAI - Unaccepted Commission Waiving</b>.
        /// </summary>
        UWAI,
        
        /// <summary>
        /// <b>UDCY - Unaccepted Deal Currency</b>.
        /// </summary>
        UDCY,
        
        /// <summary>
        /// <b>UNAV - Unaccepted NAV Currency</b>.
        /// </summary>
        UNAV,
        
        /// <summary>
        /// <b>UPAY - Undue Payment</b>.
        /// </summary>
        UPAY,
        
        /// <summary>
        /// <b>URSC - Unaccepted Requested Settlement Currency</b>.
        /// </summary>
        URSC,
        
        /// <summary>
        /// <b>SHIG - Too High Units Or Amount To Subscribe</b>.
        /// </summary>
        SHIG,
        
        /// <summary>
        /// <b>SLOW - Too Low Units Or Amount To Subscribe</b>.
        /// </summary>
        SLOW,
        
        /// <summary>
        /// <b>ULNK - Unknown Linkages Reference</b>.
        /// </summary>
        ULNK,
        
        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
        
        /// <summary>
        /// <b>ORRF - Duplicate Order Reference</b>.
        /// </summary>
        ORRF,
        
        /// <summary>
        /// <b>IPAC - Instructing Party Not Allowed For Account</b>.
        /// </summary>
        IPAC,
        
        /// <summary>
        /// <b>IOTP - Invalid Order Type</b>.
        /// </summary>
        IOTP,
        
        /// <summary>
        /// <b>NSLA - Not Compliant With SLA</b>.
        /// </summary>
        NSLA,
        
        /// <summary>
        /// <b>CUTO - Cut Off Time</b>.
        /// </summary>
        CUTO,
        
        /// <summary>
        /// <b>LATE - Too Late</b>.
        /// </summary>
        LATE,
        
        /// <summary>
        /// <b>ADEA - After Deadline</b>.
        /// </summary>
        ADEA,
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>DDAT - Settlement Date</b>.
        /// </summary>
        DDAT,
        
        /// <summary>
        /// <b>DQUA - Financial Instrument Quantity</b>.
        /// </summary>
        DQUA,
        
        /// <summary>
        /// <b>DTRD - Trade Date</b>.
        /// </summary>
        DTRD,
        
        /// <summary>
        /// <b>FEEE - Fee Or Commission</b>.
        /// </summary>
        FEEE,
        
        /// <summary>
        /// <b>IEXE - Subscriber Or Redeemer</b>.
        /// </summary>
        IEXE,
        
        /// <summary>
        /// <b>NCRR - Settlement Amount Currency</b>.
        /// </summary>
        NCRR,
        
        /// <summary>
        /// <b>PHYS - Physical Certification</b>.
        /// </summary>
        PHYS,
        
        /// <summary>
        /// <b>PLCE - Place Of Trade</b>.
        /// </summary>
        PLCE,
        
        /// <summary>
        /// <b>SETR - Settlement Transaction</b>.
        /// </summary>
        SETR,
        
        /// <summary>
        /// <b>RTGS - Real Time Gross Settlement System</b>.
        /// </summary>
        RTGS,
        
        /// <summary>
        /// <b>NRGM - No Cancellation Match</b>.
        /// </summary>
        NRGM,
        
        /// <summary>
        /// <b>DMON - Settlement Amount</b>.
        /// </summary>
        DMON,
    }
    
    /// <summary>
    /// Class <b>SuspendedStatus2</b> (Suspended Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class SuspendedStatus2
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// NoSpcfdRsn (No Specified Reason) of type NoReasonCode 
        /// RsnDtls (Reason Details) of type SuspendedStatusReason2 
        /// </summary>
        [XmlElementAttribute("NoSpcfdRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("RsnDtls", typeof(SuspendedStatusReason2), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>SuspendedStatusReason2</b> (Suspended Status Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class SuspendedStatusReason2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type SuspendedStatusReason3Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(SuspendedStatusReason3Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>SuspendedStatusReason3Code</b> (Suspended Status Reason 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum SuspendedStatusReason3Code
    {
        
        /// <summary>
        /// <b>PRIC - Price Suspension</b>.
        /// </summary>
        PRIC,
        
        /// <summary>
        /// <b>FLOW - Overflow</b>.
        /// </summary>
        FLOW,
    }
    
    /// <summary>
    /// Enumeration <b>OrderStatus4Code</b> (Order Status 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public enum OrderStatus4Code
    {
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>COSE - Already Executed</b>.
        /// </summary>
        COSE,
        
        /// <summary>
        /// <b>STNP - Sent To Next Party</b>.
        /// </summary>
        STNP,
        
        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,
        
        /// <summary>
        /// <b>SETT - Settled</b>.
        /// </summary>
        SETT,
        
        /// <summary>
        /// <b>CPNP - Communication Problem Next Party</b>.
        /// </summary>
        CPNP,
        
        /// <summary>
        /// <b>CNFC - Confirmation Amendment</b>.
        /// </summary>
        CNFC,
        
        /// <summary>
        /// <b>DONE - Done For Day</b>.
        /// </summary>
        DONE,
        
        /// <summary>
        /// <b>DONF - Partially Done</b>.
        /// </summary>
        DONF,
        
        /// <summary>
        /// <b>OPOD - Open</b>.
        /// </summary>
        OPOD,
        
        /// <summary>
        /// <b>IACO - Invalid Agent Confirmation</b>.
        /// </summary>
        IACO,
    }
    
    /// <summary>
    /// Class <b>ExpectedExecutionDetails2</b> (Expected Execution Details 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class ExpectedExecutionDetails2
    {
        
        /// <summary>
        /// Element <b>XpctdTradDtTm</b> (Expected Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateAndDateTimeChoice XpctdTradDtTm;
        
        /// <summary>
        /// Element <b>XpctdCshSttlmDt</b> (Expected Cash Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime XpctdCshSttlmDt;
        
        /// <summary>
        /// Element <b>XpctdCshSttlmDtSpecified</b> (Expected Cash Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XpctdCshSttlmDtSpecified;
    }
    
    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class DateAndDateTimeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date", Order=0)]
        [XmlElementAttribute("DtTm", typeof(System.DateTime), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public System.DateTime Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>Dt - Date</b>.
        /// </summary>
        Dt,
        
        /// <summary>
        /// <b>DtTm - Date Time</b>.
        /// </summary>
        DtTm,
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Class <b>FundOrderData1</b> (Fund Order Data 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class FundOrderData1
    {
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount13.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvestmentAccount13 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstrument10 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>UnitsNb</b> (Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstrumentQuantity1 UnitsNb;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveOrHistoricCurrencyAndAmount NetAmt;
        
        /// <summary>
        /// Element <b>GrssAmt</b> (Gross Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ActiveOrHistoricCurrencyAndAmount GrssAmt;
        
        /// <summary>
        /// Element <b>HldgsRedRate</b> (Holdings Redemption Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public decimal HldgsRedRate;
        
        /// <summary>
        /// Element <b>HldgsRedRateSpecified</b> (Holdings Redemption Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HldgsRedRateSpecified;
        
        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public ActiveCurrencyAndAmount SttlmAmt;
        
        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string UnitCcy;
        
        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string QtdCcy;
    }
    
    /// <summary>
    /// Class <b>IndividualOrderStatusAndReason2</b> (Individual Order Status And Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class IndividualOrderStatusAndReason2
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string OrdrRef;
        
        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ClntRef;
        
        /// <summary>
        /// Element <b>DealRef</b> (Deal Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DealRef;
        
        /// <summary>
        /// Element <b>CxlRef</b> (Cancellation Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string CxlRef;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// Canc (Cancelled) of type CancelledStatus2 
        /// CondlyAccptd (Conditionally Accepted) of type ConditionallyAcceptedStatus2 
        /// InRpr (In Repair) of type InRepairStatus2 
        /// PrtlySttld (Partially Settled) of type PartiallySettledStatus1 
        /// Rjctd (Rejected) of type RejectedStatus6 
        /// Sspd (Suspended) of type SuspendedStatus2 
        /// Sts (Status) of type OrderStatus4Code 
        /// </summary>
        [XmlElementAttribute("Canc", typeof(CancelledStatus2), Order=5)]
        [XmlElementAttribute("CondlyAccptd", typeof(ConditionallyAcceptedStatus2), Order=5)]
        [XmlElementAttribute("InRpr", typeof(InRepairStatus2), Order=5)]
        [XmlElementAttribute("PrtlySttld", typeof(PartiallySettledStatus1), Order=5)]
        [XmlElementAttribute("Rjctd", typeof(RejectedStatus6), Order=5)]
        [XmlElementAttribute("Sspd", typeof(SuspendedStatus2), Order=5)]
        [XmlElementAttribute("Sts", typeof(OrderStatus4Code), Order=5)]
        public object[] Items;
        
        /// <summary>
        /// Element <b>RprdConds</b> (Repaired Conditions) of type RepairedConditions3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public RepairedConditions3 RprdConds;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentification2Choice StsInitr;
        
        /// <summary>
        /// Element <b>OrdrData</b> (Order Data) of type FundOrderData1.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public FundOrderData1 OrdrData;
        
        /// <summary>
        /// Element <b>NewDtls</b> (New Details) of type ExpectedExecutionDetails2.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public ExpectedExecutionDetails2 NewDtls;
    }
    
    /// <summary>
    /// Class <b>OrderStatusAndReason7</b> (Order Status And Reason 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class OrderStatusAndReason7
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// Canc (Cancelled) of type CancelledStatus2 
        /// CondlyAccptd (Conditionally Accepted) of type ConditionallyAcceptedStatus2 
        /// PrtlySttld (Partially Settled) of type PartiallySettledStatus1 
        /// Rjctd (Rejected) of type RejectedStatus6 
        /// Sspd (Suspended) of type SuspendedStatus2 
        /// Sts (Status) of type OrderStatus4Code 
        /// </summary>
        [XmlElementAttribute("Canc", typeof(CancelledStatus2), Order=1)]
        [XmlElementAttribute("CondlyAccptd", typeof(ConditionallyAcceptedStatus2), Order=1)]
        [XmlElementAttribute("PrtlySttld", typeof(PartiallySettledStatus1), Order=1)]
        [XmlElementAttribute("Rjctd", typeof(RejectedStatus6), Order=1)]
        [XmlElementAttribute("Sspd", typeof(SuspendedStatus2), Order=1)]
        [XmlElementAttribute("Sts", typeof(OrderStatus4Code), Order=1)]
        public object[] Items;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice StsInitr;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03")]
    public class AdditionalReference3
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice RefIssr;
        
        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MsgNm;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.016.001.03", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <summary>
        /// <b>OthrRef - Other Reference</b>.
        /// </summary>
        OthrRef,
        
        /// <summary>
        /// <b>RltdRef - Related Reference</b>.
        /// </summary>
        RltdRef,
    }
}
