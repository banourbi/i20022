
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



namespace i20022.setr01600102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id setr.016.001.02 name OrderInstructionStatusReportV02 from Securities Trade business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>setr01600102</b> (setr 01600102) of type setr01600102.
        /// </summary>
        [XmlElementAttribute("setr.016.001.02", Order=0)]
        public setr01600102 setr01600102;
    }
    
    /// <summary>
    /// Class <b>setr01600102</b> (setr 01600102).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="setr.016.001.02", Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class setr01600102
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute("OthrRef", typeof(AdditionalReference3), Order=0)]
        [XmlElementAttribute("RltdRef", typeof(AdditionalReference3), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public AdditionalReference3[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AdditionalReference3 MstrRef;
        
        /// <summary>
        /// Element <b>Items1</b> (Items 1) of type array of object.
        /// [XOR] This element can be:
        /// IndvOrdrDtlsRpt (Individual Order Details Report) of type IndividualOrderStatusAndReason1 
        /// OrdrDtlsRpt (Order Details Report) of type OrderStatusAndReason3 
        /// </summary>
        [XmlElementAttribute("IndvOrdrDtlsRpt", typeof(IndividualOrderStatusAndReason1), Order=3)]
        [XmlElementAttribute("OrdrDtlsRpt", typeof(OrderStatusAndReason3), Order=3)]
        public object[] Items1;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02", IncludeInSchema=false)]
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
    /// Class <b>ExpectedExecutionDetails1</b> (Expected Execution Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class ExpectedExecutionDetails1
    {
        
        /// <summary>
        /// Element <b>XpctdTradDtTm</b> (Expected Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateAndDateTimeChoice XpctdTradDtTm;
        
        /// <summary>
        /// Element <b>XpctdSttlmDt</b> (Expected Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime XpctdSttlmDt;
        
        /// <summary>
        /// Element <b>XpctdSttlmDtSpecified</b> (Expected Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XpctdSttlmDtSpecified;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02", IncludeInSchema=false)]
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
    /// Class <b>SecurityIdentification1Choice</b> (Security Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class SecurityIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AltrnId (Alternate Identification) of type AlternateSecurityIdentification1 
        /// Blmbrg (Bloomberg) of type string 
        /// CTA (CTA) of type string 
        /// Cmon (Common) of type string 
        /// ISIN (ISIN) of type string 
        /// RIC (RIC) of type string 
        /// TckrSymb (Ticker Symbol) of type string 
        /// </summary>
        [XmlElementAttribute("AltrnId", typeof(AlternateSecurityIdentification1), Order=0)]
        [XmlElementAttribute("Blmbrg", typeof(string), Order=0)]
        [XmlElementAttribute("CTA", typeof(string), Order=0)]
        [XmlElementAttribute("Cmon", typeof(string), Order=0)]
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("RIC", typeof(string), Order=0)]
        [XmlElementAttribute("TckrSymb", typeof(string), Order=0)]
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
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>AltrnId - Alternate Identification</b>.
        /// </summary>
        AltrnId,
        
        /// <summary>
        /// <b>Blmbrg - Bloomberg Symbol</b>.
        /// </summary>
        Blmbrg,
        
        /// <summary>
        /// <b>CTA - Consolidated Tape Association</b>.
        /// </summary>
        CTA,
        
        /// <summary>
        /// <b>Cmon - Common</b>.
        /// </summary>
        Cmon,
        
        /// <summary>
        /// <b>ISIN - International Securities Identification Number</b>.
        /// </summary>
        ISIN,
        
        /// <summary>
        /// <b>RIC - RIC Security Id</b>.
        /// </summary>
        RIC,
        
        /// <summary>
        /// <b>TckrSymb - Ticker Symbol</b>.
        /// </summary>
        TckrSymb,
    }
    
    /// <summary>
    /// Class <b>FinancialInstrument6</b> (Financial Instrument 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class FinancialInstrument6
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification1Choice Id;
        
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
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class AccountIdentification1
    {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount13</b> (Investment Account 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    /// Class <b>InvestmentAccountOrFinancialInstrument1Choice</b> (Investment Account Or Financial Instrument 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class InvestmentAccountOrFinancialInstrument1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// FinInstrm (Financial Instrument) of type FinancialInstrument6 
        /// InvstmtAcct (Investment Account) of type InvestmentAccount13 
        /// </summary>
        [XmlElementAttribute("FinInstrm", typeof(FinancialInstrument6), Order=0)]
        [XmlElementAttribute("InvstmtAcct", typeof(InvestmentAccount13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CommissionType1</b> (Commission Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class CommissionType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type CommissionType5Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CommissionType5Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CommissionType5Code</b> (Commission Type 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public enum CommissionType5Code
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
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>Commission7</b> (Commission 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class Commission7
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
        /// Element <b>Tp</b> (Type) of type CommissionType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CommissionType1 Tp;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    /// Class <b>ChargeType1</b> (Charge Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class ChargeType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type ChargeType6Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ChargeType6Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType6Code</b> (Charge Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public enum ChargeType6Code
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
        /// <b>MANF - Management Fee</b>.
        /// </summary>
        MANF,
        
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
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>CDSC - Contingency Deferred Sales Charge</b>.
        /// </summary>
        CDSC,
        
        /// <summary>
        /// <b>EQUL - Equalisation</b>.
        /// </summary>
        EQUL,
        
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
    }
    
    /// <summary>
    /// Class <b>Charge11</b> (Charge 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class Charge11
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
        /// Element <b>Tp</b> (Type) of type ChargeType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ChargeType1 Tp;
    }
    
    /// <summary>
    /// Class <b>RepairedConditions2</b> (Repaired Conditions 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class RepairedConditions2
    {
        
        /// <summary>
        /// Element <b>RprdChrg</b> (Repaired Charge) of type array of Charge11.
        /// </summary>
        [XmlElementAttribute("RprdChrg", Order=0)]
        public Charge11[] RprdChrg;
        
        /// <summary>
        /// Element <b>RprdComssn</b> (Repaired Commission) of type array of Commission7.
        /// </summary>
        [XmlElementAttribute("RprdComssn", Order=1)]
        public Commission7[] RprdComssn;
    }
    
    /// <summary>
    /// Class <b>InRepairStatusReason1</b> (In Repair Status Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class InRepairStatusReason1
    {
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>InRepairStatus1</b> (In Repair Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class InRepairStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoRsn (No Reason) of type NoReasonCode 
        /// Rsn (Reason) of type InRepairStatusReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(InRepairStatusReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
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
    /// Enumeration <b>NoReasonCode</b> (No Reason Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public enum NoReasonCode
    {
        
        /// <summary>
        /// <b>NORE - No Reason</b>.
        /// </summary>
        NORE,
    }
    
    /// <summary>
    /// Class <b>IndividualOrderStatusAndReason1</b> (Individual Order Status And Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class IndividualOrderStatusAndReason1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Canc (Cancelled) of type CancelledStatus1 
        /// CondlyAccptd (Conditionally Accepted) of type ConditionallyAcceptedStatus1 
        /// InRpr (In Repair) of type InRepairStatus1 
        /// Rjctd (Rejected) of type RejectedStatus3 
        /// RprdConds (Repaired Conditions) of type RepairedConditions2 
        /// Sspd (Suspended) of type SuspendedStatus1 
        /// Sts (Status) of type OrderStatus2Code 
        /// </summary>
        [XmlElementAttribute("Canc", typeof(CancelledStatus1), Order=0)]
        [XmlElementAttribute("CondlyAccptd", typeof(ConditionallyAcceptedStatus1), Order=0)]
        [XmlElementAttribute("InRpr", typeof(InRepairStatus1), Order=0)]
        [XmlElementAttribute("Rjctd", typeof(RejectedStatus3), Order=0)]
        [XmlElementAttribute("RprdConds", typeof(RepairedConditions2), Order=0)]
        [XmlElementAttribute("Sspd", typeof(SuspendedStatus1), Order=0)]
        [XmlElementAttribute("Sts", typeof(OrderStatus2Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string OrdrRef;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice StsInitr;
        
        /// <summary>
        /// Element <b>InvstmtAcctOrFinInstrm</b> (Investment Account Or Financial Instrument) of type InvestmentAccountOrFinancialInstrument1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentAccountOrFinancialInstrument1Choice InvstmtAcctOrFinInstrm;
        
        /// <summary>
        /// Element <b>NewDtls</b> (New Details) of type ExpectedExecutionDetails1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ExpectedExecutionDetails1 NewDtls;
    }
    
    /// <summary>
    /// Class <b>CancelledStatus1</b> (Cancelled Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class CancelledStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoRsn (No Reason) of type NoReasonCode 
        /// Rsn (Reason) of type CancelledStatusReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(CancelledStatusReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CancelledStatusReason1</b> (Cancelled Status Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class CancelledStatusReason1
    {
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>ConditionallyAcceptedStatus1</b> (Conditionally Accepted Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class ConditionallyAcceptedStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoRsn (No Reason) of type NoReasonCode 
        /// Rsn (Reason) of type ConditionallyAcceptedStatusReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(ConditionallyAcceptedStatusReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>ConditionallyAcceptedStatusReason1</b> (Conditionally Accepted Status Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class ConditionallyAcceptedStatusReason1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type array of ConditionallyAcceptedStatusReason1Code.
        /// </summary>
        [XmlElementAttribute("Strd", Order=0)]
        public ConditionallyAcceptedStatusReason1Code[] Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>ConditionallyAcceptedStatusReason1Code</b> (Conditionally Accepted Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public enum ConditionallyAcceptedStatusReason1Code
    {
        
        /// <summary>
        /// <b>AWMO - ?undefined?</b>.
        /// </summary>
        AWMO,
        
        /// <summary>
        /// <b>AWSH - Awaiting Shares From Counterparty</b>.
        /// </summary>
        AWSH,
        
        /// <summary>
        /// <b>DOCC - Awaiting Documents</b>.
        /// </summary>
        DOCC,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>RejectedStatus3</b> (Rejected Status 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class RejectedStatus3
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type RejectedStatusReason6 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(RejectedStatusReason6), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>RejectedStatusReason6</b> (Rejected Status Reason 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class RejectedStatusReason6
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type RejectedStatusReason5Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RejectedStatusReason5Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>RejectedStatusReason5Code</b> (Rejected Status Reason 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public enum RejectedStatusReason5Code
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
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>SuspendedStatus1</b> (Suspended Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class SuspendedStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoRsn (No Reason) of type NoReasonCode 
        /// Rsn (Reason) of type SuspendedStatusReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(SuspendedStatusReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SuspendedStatusReason1</b> (Suspended Status Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class SuspendedStatusReason1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type array of SuspendedStatusReason2Code.
        /// </summary>
        [XmlElementAttribute("Strd", Order=0)]
        public SuspendedStatusReason2Code[] Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>SuspendedStatusReason2Code</b> (Suspended Status Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public enum SuspendedStatusReason2Code
    {
        
        /// <summary>
        /// <b>PRIC - Price Suspension</b>.
        /// </summary>
        PRIC,
        
        /// <summary>
        /// <b>FLOW - Overflow</b>.
        /// </summary>
        FLOW,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Enumeration <b>OrderStatus2Code</b> (Order Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public enum OrderStatus2Code
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
    }
    
    /// <summary>
    /// Class <b>OrderStatusAndReason3</b> (Order Status And Reason 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02")]
    public class OrderStatusAndReason3
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Canc (Cancelled) of type CancelledStatus1 
        /// CondlyAccptd (Conditionally Accepted) of type ConditionallyAcceptedStatus1 
        /// Rjctd (Rejected) of type RejectedStatus3 
        /// Sspd (Suspended) of type SuspendedStatus1 
        /// Sts (Status) of type OrderStatus2Code 
        /// </summary>
        [XmlElementAttribute("Canc", typeof(CancelledStatus1), Order=0)]
        [XmlElementAttribute("CondlyAccptd", typeof(ConditionallyAcceptedStatus1), Order=0)]
        [XmlElementAttribute("Rjctd", typeof(RejectedStatus3), Order=0)]
        [XmlElementAttribute("Sspd", typeof(SuspendedStatus1), Order=0)]
        [XmlElementAttribute("Sts", typeof(OrderStatus2Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice StsInitr;
        
        /// <summary>
        /// Element <b>SwtchOrdrLegId</b> (Switch Order Leg Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string SwtchOrdrLegId;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.016.001.02", IncludeInSchema=false)]
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
