
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



namespace i20022.trea00500102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id trea.005.001.02 name AmendNonDeliverableForwardValuationV02 from Treasury business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AmdNDFValtnV02</b> (Amend NonDeliverableForward Valuation V02) of type AmendNonDeliverableForwardValuationV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AmendNonDeliverableForwardValuationV02 AmdNDFValtnV02;
    }
    
    /// <summary>
    /// Class <b>AmendNonDeliverableForwardValuationV02</b> (Amend Non Deliverable Forward Valuation V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
    public class AmendNonDeliverableForwardValuationV02
    {
        
        /// <summary>
        /// Element <b>TradInf</b> (Trade Information) of type TradeAgreement2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TradeAgreement2 TradInf;
        
        /// <summary>
        /// Element <b>TradgSdId</b> (Trading Side Identification) of type TradePartyIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TradePartyIdentification3 TradgSdId;
        
        /// <summary>
        /// Element <b>CtrPtySdId</b> (Ctr Party Side Identification) of type TradePartyIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TradePartyIdentification3 CtrPtySdId;
        
        /// <summary>
        /// Element <b>TradAmts</b> (Trade Amounts) of type AmountsAndValueDate1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public AmountsAndValueDate1 TradAmts;
        
        /// <summary>
        /// Element <b>ValtnRate</b> (Valuation Rate) of type AgreedRate1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public AgreedRate1 ValtnRate;
        
        /// <summary>
        /// Element <b>ValtnInf</b> (Valuation Information) of type ValuationData2.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public ValuationData2 ValtnInf;
    }
    
    /// <summary>
    /// Class <b>TradeAgreement2</b> (Trade Agreement 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
    public class TradeAgreement2
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
        /// Element <b>AmdOrCclRsn</b> (Amend Or Cancel Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string AmdOrCclRsn;
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string RltdRef;
    }
    
    /// <summary>
    /// Class <b>ValuationData2</b> (Valuation Data 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    /// Class <b>PartyIdentification8Choice</b> (Party Identification 8Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    /// Class <b>NameAndAddress8</b> (Name And Address 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    /// Class <b>AgreedRate1</b> (Agreed Rate 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    /// Class <b>AmountsAndValueDate1</b> (Amounts And Value Date 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    /// Class <b>FundIdentification2</b> (Fund Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
    /// Class <b>TradePartyIdentification3</b> (Trade Party Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.005.001.02")]
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
}
