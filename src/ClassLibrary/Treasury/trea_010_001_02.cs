
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



namespace i20022.trea01000102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id trea.010.001.02 name AmendForeignExchangeOptionV02 from Treasury business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AmdFXOptnV02</b> (Amend ForeignExchange Option V02) of type AmendForeignExchangeOptionV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AmendForeignExchangeOptionV02 AmdFXOptnV02;
    }
    
    /// <summary>
    /// Class <b>AmendForeignExchangeOptionV02</b> (Amend Foreign Exchange Option V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public class AmendForeignExchangeOptionV02
    {
        
        /// <summary>
        /// Element <b>TradInf</b> (Trade Information) of type TradeAgreement2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TradeAgreement2 TradInf;
        
        /// <summary>
        /// Element <b>TradgSdId</b> (Trading Side Identification) of type TradePartyIdentification4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TradePartyIdentification4 TradgSdId;
        
        /// <summary>
        /// Element <b>CtrPtySdId</b> (Ctr Party Side Identification) of type TradePartyIdentification4.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TradePartyIdentification4 CtrPtySdId;
        
        /// <summary>
        /// Element <b>Optn</b> (Option) of type Option3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Option3 Optn;
    }
    
    /// <summary>
    /// Class <b>TradeAgreement2</b> (Trade Agreement 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    /// Class <b>PremiumQuote1Choice</b> (Premium Quote 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public class PremiumQuote1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type decimal.
        /// </summary>
        [XmlElementAttribute("PctgOfCallAmt", typeof(decimal), Order=0)]
        [XmlElementAttribute("PctgOfPutAmt", typeof(decimal), Order=0)]
        [XmlElementAttribute("PtsOfCallAmt", typeof(decimal), Order=0)]
        [XmlElementAttribute("PtsOfPutAmt", typeof(decimal), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public decimal Item;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>PctgOfCallAmt - Percentage Of Call Amount</b>.
        /// </summary>
        PctgOfCallAmt,
        
        /// <summary>
        /// <b>PctgOfPutAmt - Percentage Of Put Amount</b>.
        /// </summary>
        PctgOfPutAmt,
        
        /// <summary>
        /// <b>PtsOfCallAmt - Points Of Call Amount</b>.
        /// </summary>
        PtsOfCallAmt,
        
        /// <summary>
        /// <b>PtsOfPutAmt - Points Of Put Amount</b>.
        /// </summary>
        PtsOfPutAmt,
    }
    
    /// <summary>
    /// Class <b>PremiumAmount2</b> (Premium Amount 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public class PremiumAmount2
    {
        
        /// <summary>
        /// Element <b>PrmQt</b> (Premium Quote) of type PremiumQuote1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PremiumQuote1Choice PrmQt;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SttlmPty</b> (Settlement Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification8Choice SttlmPty;
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    /// Class <b>PartyIdentification8Choice</b> (Party Identification 8Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    /// Class <b>AmountsAndValueDate2</b> (Amounts And Value Date 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public class AmountsAndValueDate2
    {
        
        /// <summary>
        /// Element <b>CallAmt</b> (Call Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveOrHistoricCurrencyAndAmount CallAmt;
        
        /// <summary>
        /// Element <b>PutAmt</b> (Put Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount PutAmt;
        
        /// <summary>
        /// Element <b>FnlSttlmDt</b> (Final Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime FnlSttlmDt;
    }
    
    /// <summary>
    /// Class <b>Option3</b> (Option 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public class Option3
    {
        
        /// <summary>
        /// Element <b>OptnAmts</b> (Option Amounts) of type AmountsAndValueDate2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AmountsAndValueDate2 OptnAmts;
        
        /// <summary>
        /// Element <b>StrkPric</b> (Strike Price) of type AgreedRate1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AgreedRate1 StrkPric;
        
        /// <summary>
        /// Element <b>ExrcStyle</b> (Exercise Style) of type OptionStyle2Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public OptionStyle2Code ExrcStyle;
        
        /// <summary>
        /// Element <b>EarlstExrcDt</b> (Earliest Exercise Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime EarlstExrcDt;
        
        /// <summary>
        /// Element <b>EarlstExrcDtSpecified</b> (Earliest Exercise Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EarlstExrcDtSpecified;
        
        /// <summary>
        /// Element <b>XpryDtAndTm</b> (Expiry Date And Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public System.DateTime XpryDtAndTm;
        
        /// <summary>
        /// Element <b>XpryLctn</b> (Expiry Location) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string XpryLctn;
        
        /// <summary>
        /// Element <b>SttlmTp</b> (Settlement Type) of type SettlementType1Code.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public SettlementType1Code SttlmTp;
        
        /// <summary>
        /// Element <b>AddtlOptnInf</b> (Additional Option Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string AddtlOptnInf;
        
        /// <summary>
        /// Element <b>Prm</b> (Premium) of type PremiumAmount2.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public PremiumAmount2 Prm;
    }
    
    /// <summary>
    /// Enumeration <b>OptionStyle2Code</b> (Option Style 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public enum OptionStyle2Code
    {
        
        /// <summary>
        /// <b>AMER - American</b>.
        /// </summary>
        AMER,
        
        /// <summary>
        /// <b>EURO - European</b>.
        /// </summary>
        EURO,
    }
    
    /// <summary>
    /// Enumeration <b>SettlementType1Code</b> (Settlement Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public enum SettlementType1Code
    {
        
        /// <summary>
        /// <b>PRIN - Principal Agent</b>.
        /// </summary>
        PRIN,
        
        /// <summary>
        /// <b>NETO - Netted Off</b>.
        /// </summary>
        NETO,
    }
    
    /// <summary>
    /// Class <b>FundIdentification2</b> (Fund Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
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
    /// Class <b>TradePartyIdentification4</b> (Trade Party Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public class TradePartyIdentification4
    {
        
        /// <summary>
        /// Element <b>FndInf</b> (Fund Information) of type FundIdentification2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FundIdentification2 FndInf;
        
        /// <summary>
        /// Element <b>BuyrOrSellrInd</b> (Buyer Or Seller Indicator) of type OptionParty1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public OptionParty1Code BuyrOrSellrInd;
        
        /// <summary>
        /// Element <b>SubmitgPty</b> (Submitting Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification8Choice SubmitgPty;
        
        /// <summary>
        /// Element <b>TradPty</b> (Trade Party) of type PartyIdentification8Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification8Choice TradPty;
    }
    
    /// <summary>
    /// Enumeration <b>OptionParty1Code</b> (Option Party 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.010.001.02")]
    public enum OptionParty1Code
    {
        
        /// <summary>
        /// <b>SLLR - Seller</b>.
        /// </summary>
        SLLR,
        
        /// <summary>
        /// <b>BYER - Buyer</b>.
        /// </summary>
        BYER,
    }
}
