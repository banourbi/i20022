
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



namespace i20022.trea00700102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id trea.007.001.02 name NonDeliverableForwardNotificationV02 from Treasury business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>NDFNtfctnV02</b> (NonDeliverableForward Notification V02) of type NonDeliverableForwardNotificationV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public NonDeliverableForwardNotificationV02 NDFNtfctnV02;
    }
    
    /// <summary>
    /// Class <b>NonDeliverableForwardNotificationV02</b> (Non Deliverable Forward Notification V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class NonDeliverableForwardNotificationV02
    {
        
        /// <summary>
        /// Element <b>TradgSdId</b> (Trading Side Identification) of type TradePartyIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TradePartyIdentification3 TradgSdId;
        
        /// <summary>
        /// Element <b>CtrPtySdId</b> (Ctr Party Side Identification) of type TradePartyIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TradePartyIdentification3 CtrPtySdId;
        
        /// <summary>
        /// Element <b>OpngData</b> (Opening Data) of type OpeningData2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public OpeningData2 OpngData;
        
        /// <summary>
        /// Element <b>ValtnData</b> (Valuation Data) of type ClosingData2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ClosingData2 ValtnData;
        
        /// <summary>
        /// Element <b>TradInfAndSts</b> (Trade Information And Status) of type TradeStatus1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public TradeStatus1 TradInfAndSts;
        
        /// <summary>
        /// Element <b>SttlmData</b> (Settlement Data) of type SettlementData2.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public SettlementData2 SttlmData;
    }
    
    /// <summary>
    /// Class <b>TradePartyIdentification3</b> (Trade Party Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class TradePartyIdentification3
    {
        
        /// <summary>
        /// Element <b>FndInf</b> (Fund Information) of type FundIdentification2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FundIdentification2 FndInf;
        
        /// <summary>
        /// Element <b>SubmitgPty</b> (Submitting Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification8Choice SubmitgPty;
        
        /// <summary>
        /// Element <b>TradPty</b> (Trade Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification8Choice TradPty;
    }
    
    /// <summary>
    /// Class <b>FundIdentification2</b> (Fund Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class FundIdentification2
    {
        
        /// <summary>
        /// Element <b>FndId</b> (Fund Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string FndId;
        
        /// <summary>
        /// Element <b>AcctIdWthCtdn</b> (Account Identification With Custodian) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AcctIdWthCtdn;
        
        /// <summary>
        /// Element <b>CtdnId</b> (Custodian Identification) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification8Choice CtdnId;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification8Choice</b> (Party Identification 8Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class PartyIdentification8Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type PartyIdentification22 
        /// NmAndAdr (Name And Address) of type NameAndAddress8 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(PartyIdentification22), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress8), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification22</b> (Party Identification 22).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class PartyIdentification22
    {
        
        /// <summary>
        /// Element <b>BICOrBEI</b> (BIC Or BEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BICOrBEI;
        
        /// <summary>
        /// Element <b>AltrntvIdr</b> (Alternative Identifier) of type array of string.
        /// </summary>
        [XmlElementAttribute("AltrntvIdr", Order=1)]
        public string[] AltrntvIdr;
    }
    
    /// <summary>
    /// Class <b>SettlementData2</b> (Settlement Data 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class SettlementData2
    {
        
        /// <summary>
        /// Element <b>CshFlowUnqRef</b> (Cash Flow Unique Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string CshFlowUnqRef;
        
        /// <summary>
        /// Element <b>SttlmSysUnqRef</b> (Settlement System Unique Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SttlmSysUnqRef;
        
        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveOrHistoricCurrencyAndAmount SttlmAmt;
        
        /// <summary>
        /// Element <b>SttldAmt</b> (Settled Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveOrHistoricCurrencyAndAmount SttldAmt;
        
        /// <summary>
        /// Element <b>RjctdAmt</b> (Rejected Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ActiveOrHistoricCurrencyAndAmount RjctdAmt;
        
        /// <summary>
        /// Element <b>PngPty</b> (Paying Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification8Choice PngPty;
        
        /// <summary>
        /// Element <b>RcvgPty</b> (Receiving Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification8Choice RcvgPty;
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// SttlmSts (Settlement Status) of type SettlementStatus1Code 
        /// XtndedSttlmSts (Extended Settlement Status) of type string 
        /// </summary>
        [XmlElementAttribute("SttlmSts", typeof(SettlementStatus1Code), Order=8)]
        [XmlElementAttribute("XtndedSttlmSts", typeof(string), Order=8)]
        public object Item;
        
        /// <summary>
        /// Element <b>SttlmStsSubTp</b> (Settlement Status Sub Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string SttlmStsSubTp;
        
        /// <summary>
        /// Element <b>Sspd</b> (Suspended) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public bool Sspd;
        
        /// <summary>
        /// Element <b>Pdg</b> (Pending) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public bool Pdg;
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
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
    /// Enumeration <b>SettlementStatus1Code</b> (Settlement Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public enum SettlementStatus1Code
    {
        
        /// <summary>
        /// <b>AAUT - Awaiting Authorisation</b>.
        /// </summary>
        AAUT,
        
        /// <summary>
        /// <b>ASTL - Accepted For Settlement</b>.
        /// </summary>
        ASTL,
        
        /// <summary>
        /// <b>STCR - Settlement Transaction Created</b>.
        /// </summary>
        STCR,
        
        /// <summary>
        /// <b>RJCT - Payment Rejected</b>.
        /// </summary>
        RJCT,
        
        /// <summary>
        /// <b>SPLT - Split Vote Not Allowed</b>.
        /// </summary>
        SPLT,
        
        /// <summary>
        /// <b>PSTL - Partially Settled</b>.
        /// </summary>
        PSTL,
        
        /// <summary>
        /// <b>STLD - Settled</b>.
        /// </summary>
        STLD,
        
        /// <summary>
        /// <b>ACCF - Awaiting Creation Confirmation</b>.
        /// </summary>
        ACCF,
        
        /// <summary>
        /// <b>ARCF - Awaiting Rescind Confirmation</b>.
        /// </summary>
        ARCF,
    }
    
    /// <summary>
    /// Class <b>TradeStatus1</b> (Trade Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class TradeStatus1
    {
        
        /// <summary>
        /// Element <b>AllgdTrad</b> (Alleged Trade) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool AllgdTrad;
        
        /// <summary>
        /// Element <b>AllgdTradSpecified</b> (Alleged Trade Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllgdTradSpecified;
        
        /// <summary>
        /// Element <b>MtchgSysUnqRef</b> (Matching System Unique Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string MtchgSysUnqRef;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Sts (Status) of type TradeStatus1Code 
        /// XtndedSts (Extended Status) of type string 
        /// </summary>
        [XmlElementAttribute("Sts", typeof(TradeStatus1Code), Order=2)]
        [XmlElementAttribute("XtndedSts", typeof(string), Order=2)]
        public object Item;
        
        /// <summary>
        /// Element <b>StsSubTp</b> (Status Sub Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string StsSubTp;
        
        /// <summary>
        /// Element <b>StsTm</b> (Status Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public System.DateTime StsTm;
        
        /// <summary>
        /// Element <b>StsTmSpecified</b> (Status Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StsTmSpecified;
        
        /// <summary>
        /// Element <b>StsOrgtr</b> (Status Originator) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string StsOrgtr;
    }
    
    /// <summary>
    /// Enumeration <b>TradeStatus1Code</b> (Trade Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public enum TradeStatus1Code
    {
        
        /// <summary>
        /// <b>INVA - Invalid</b>.
        /// </summary>
        INVA,
        
        /// <summary>
        /// <b>VALI - Entitled</b>.
        /// </summary>
        VALI,
        
        /// <summary>
        /// <b>REGC - Regulatory Checked</b>.
        /// </summary>
        REGC,
        
        /// <summary>
        /// <b>UMTC - Unmatched</b>.
        /// </summary>
        UMTC,
        
        /// <summary>
        /// <b>VMTC - Matched Valued</b>.
        /// </summary>
        VMTC,
        
        /// <summary>
        /// <b>RSCD - Rescinded</b>.
        /// </summary>
        RSCD,
        
        /// <summary>
        /// <b>STLD - Settled</b>.
        /// </summary>
        STLD,
        
        /// <summary>
        /// <b>PSTL - Partially Settled</b>.
        /// </summary>
        PSTL,
        
        /// <summary>
        /// <b>REGS - Regulatory Suspended / Regulation S Exchange</b>.
        /// </summary>
        REGS,
        
        /// <summary>
        /// <b>FMTC - Matched</b>.
        /// </summary>
        FMTC,
        
        /// <summary>
        /// <b>SRJC - Settlement Rejected</b>.
        /// </summary>
        SRJC,
        
        /// <summary>
        /// <b>RJCT - Payment Rejected</b>.
        /// </summary>
        RJCT,
        
        /// <summary>
        /// <b>OPMA - Option Mature</b>.
        /// </summary>
        OPMA,
    }
    
    /// <summary>
    /// Class <b>ValuationData2</b> (Valuation Data 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class ValuationData2
    {
        
        /// <summary>
        /// Element <b>ValtnRef</b> (Valuation Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string ValtnRef;
        
        /// <summary>
        /// Element <b>SttlmCcy</b> (Settlement Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SttlmCcy;
        
        /// <summary>
        /// Element <b>AddtlValtnInf</b> (Additional Valuation Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AddtlValtnInf;
        
        /// <summary>
        /// Element <b>SttlmPty</b> (Settlement Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification8Choice SttlmPty;
    }
    
    /// <summary>
    /// Class <b>ClosingData2</b> (Closing Data 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class ClosingData2
    {
        
        /// <summary>
        /// Element <b>TradDt</b> (Trade Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime TradDt;
        
        /// <summary>
        /// Element <b>NtfctnId</b> (Notification Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string NtfctnId;
        
        /// <summary>
        /// Element <b>CmonRef</b> (Common Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CmonRef;
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string RltdRef;
        
        /// <summary>
        /// Element <b>AmdOrCclRsn</b> (Amend Or Cancel Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string AmdOrCclRsn;
        
        /// <summary>
        /// Element <b>TradAmts</b> (Trade Amounts) of type AmountsAndValueDate1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public AmountsAndValueDate1 TradAmts;
        
        /// <summary>
        /// Element <b>ValtnRate</b> (Valuation Rate) of type AgreedRate1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public AgreedRate1 ValtnRate;
        
        /// <summary>
        /// Element <b>ValtnInf</b> (Valuation Information) of type ValuationData2.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public ValuationData2 ValtnInf;
    }
    
    /// <summary>
    /// Class <b>AmountsAndValueDate1</b> (Amounts And Value Date 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class AmountsAndValueDate1
    {
        
        /// <summary>
        /// Element <b>TradgSdBuyAmt</b> (Trading Side Buy Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveOrHistoricCurrencyAndAmount TradgSdBuyAmt;
        
        /// <summary>
        /// Element <b>TradgSdSellAmt</b> (Trading Side Sell Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount TradgSdSellAmt;
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime SttlmDt;
    }
    
    /// <summary>
    /// Class <b>AgreedRate1</b> (Agreed Rate 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class AgreedRate1
    {
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal XchgRate;
        
        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string UnitCcy;
        
        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string QtdCcy;
    }
    
    /// <summary>
    /// Class <b>NonDeliverableForwardValuationConditions2</b> (Non Deliverable Forward Valuation Conditions 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class NonDeliverableForwardValuationConditions2
    {
        
        /// <summary>
        /// Element <b>SttlmCcy</b> (Settlement Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string SttlmCcy;
        
        /// <summary>
        /// Element <b>ValtnDt</b> (Valuation Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime ValtnDt;
        
        /// <summary>
        /// Element <b>AddtlValtnInf</b> (Additional Valuation Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AddtlValtnInf;
        
        /// <summary>
        /// Element <b>SttlmPty</b> (Settlement Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification8Choice SttlmPty;
    }
    
    /// <summary>
    /// Class <b>OpeningData2</b> (Opening Data 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class OpeningData2
    {
        
        /// <summary>
        /// Element <b>TradDt</b> (Trade Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime TradDt;
        
        /// <summary>
        /// Element <b>NtfctnId</b> (Notification Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string NtfctnId;
        
        /// <summary>
        /// Element <b>CmonRef</b> (Common Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CmonRef;
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string RltdRef;
        
        /// <summary>
        /// Element <b>AmdOrCclRsn</b> (Amend Or Cancel Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string AmdOrCclRsn;
        
        /// <summary>
        /// Element <b>TradAmts</b> (Trade Amounts) of type AmountsAndValueDate1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public AmountsAndValueDate1 TradAmts;
        
        /// <summary>
        /// Element <b>AgrdRate</b> (Agreed Rate) of type AgreedRate1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public AgreedRate1 AgrdRate;
        
        /// <summary>
        /// Element <b>ValtnConds</b> (Valuation Conditions) of type NonDeliverableForwardValuationConditions2.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public NonDeliverableForwardValuationConditions2 ValtnConds;
    }
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
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
    /// Class <b>NameAndAddress8</b> (Name And Address 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.007.001.02")]
    public class NameAndAddress8
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
        
        /// <summary>
        /// Element <b>AltrntvIdr</b> (Alternative Identifier) of type array of string.
        /// </summary>
        [XmlElementAttribute("AltrntvIdr", Order=2)]
        public string[] AltrntvIdr;
    }
}
