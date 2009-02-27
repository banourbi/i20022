
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



namespace i20022.seev00200102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.002.001.02 name MeetingCancellationV02 from Securities Events business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>MtgCxl</b> (Meeting Cancellation) of type MeetingCancellationV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MeetingCancellationV02 MtgCxl;
    }
    
    /// <summary>
    /// Class <b>MeetingCancellationV02</b> (Meeting Cancellation V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class MeetingCancellationV02
    {
        
        /// <summary>
        /// Element <b>CxlId</b> (Cancellation Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 CxlId;
        
        /// <summary>
        /// Element <b>MsgCxl</b> (Message Cancellation) of type AmendInformation1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AmendInformation1 MsgCxl;
        
        /// <summary>
        /// Element <b>MtgRef</b> (Meeting Reference) of type MeetingReference2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public MeetingReference2 MtgRef;
        
        /// <summary>
        /// Element <b>NtifngPty</b> (Notifying Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification9Choice NtifngPty;
        
        /// <summary>
        /// Element <b>Scty</b> (Security) of type array of SecurityPosition5.
        /// </summary>
        [XmlElementAttribute("Scty", Order=4)]
        public SecurityPosition5[] Scty;
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type MeetingCancellationReason1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public MeetingCancellationReason1 Rsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
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
    /// Class <b>MeetingCancellationReason1</b> (Meeting Cancellation Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class MeetingCancellationReason1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type MeetingCancellationReason2Code 
        /// XtndedCd (Extended Code) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(MeetingCancellationReason2Code), Order=0)]
        [XmlElementAttribute("XtndedCd", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>CxlRsn</b> (Cancellation Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string CxlRsn;
    }
    
    /// <summary>
    /// Enumeration <b>MeetingCancellationReason2Code</b> (Meeting Cancellation Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public enum MeetingCancellationReason2Code
    {
        
        /// <summary>
        /// <b>QORM - Quorum</b>.
        /// </summary>
        QORM,
        
        /// <summary>
        /// <b>PROC - Processing</b>.
        /// </summary>
        PROC,
        
        /// <summary>
        /// <b>WITH - With / Withdrawal</b>.
        /// </summary>
        WITH,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification5</b> (Generic Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class GenericIdentification5
    {
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Issr;
        
        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Inf;
        
        /// <summary>
        /// Element <b>Nrrtv</b> (Narrative) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Nrrtv;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification3</b> (Party Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class PartyIdentification3
    {
        
        /// <summary>
        /// Element <b>BICOrBEI</b> (BIC Or BEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BICOrBEI;
    }
    
    /// <summary>
    /// Class <b>SafekeepingPlaceAsCodeAndPartyIdentification</b> (Safekeeping Place As Code And Party Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class SafekeepingPlaceAsCodeAndPartyIdentification
    {
        
        /// <summary>
        /// Element <b>PlcSfkpg</b> (Place Safekeeping) of type SafekeepingPlace1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SafekeepingPlace1Code PlcSfkpg;
        
        /// <summary>
        /// Element <b>Nrrtv</b> (Narrative) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nrrtv;
        
        /// <summary>
        /// Element <b>Pty</b> (Party) of type PartyIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification3 Pty;
    }
    
    /// <summary>
    /// Enumeration <b>SafekeepingPlace1Code</b> (Safekeeping Place 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public enum SafekeepingPlace1Code
    {
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
        
        /// <summary>
        /// <b>ICSD - Shares Held At ICSD</b>.
        /// </summary>
        ICSD,
        
        /// <summary>
        /// <b>NCSD - Shares Held At NCSD</b>.
        /// </summary>
        NCSD,
        
        /// <summary>
        /// <b>SHHE - Shares Held Elsewhere</b>.
        /// </summary>
        SHHE,
    }
    
    /// <summary>
    /// Class <b>SafekeepingPlaceFormatChoice</b> (Safekeeping Place Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class SafekeepingPlaceFormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Id (Identification) of type SafekeepingPlaceAsCodeAndPartyIdentification 
        /// IdAsCtry (Identification As Country) of type string 
        /// IdAsDSS (Identification As DSS) of type GenericIdentification5 
        /// </summary>
        [XmlElementAttribute("Id", typeof(SafekeepingPlaceAsCodeAndPartyIdentification), Order=0)]
        [XmlElementAttribute("IdAsCtry", typeof(string), Order=0)]
        [XmlElementAttribute("IdAsDSS", typeof(GenericIdentification5), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
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
    /// Class <b>UnitOrFaceAmountChoice</b> (Unit Or Face Amount Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class UnitOrFaceAmountChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// FaceAmt (Face Amount) of type CurrencyAndAmount 
        /// Unit (Unit) of type decimal 
        /// </summary>
        [XmlElementAttribute("FaceAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("Unit", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>HoldingBalance3</b> (Holding Balance 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class HoldingBalance3
    {
        
        /// <summary>
        /// Element <b>Bal</b> (Balance) of type UnitOrFaceAmountChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public UnitOrFaceAmountChoice Bal;
        
        /// <summary>
        /// Element <b>BalTp</b> (Balance Type) of type SecuritiesEntryType2Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SecuritiesEntryType2Code BalTp;
        
        /// <summary>
        /// Element <b>BalTpSpecified</b> (Balance Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BalTpSpecified;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type SafekeepingPlaceFormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public SafekeepingPlaceFormatChoice SfkpgPlc;
        
        /// <summary>
        /// Element <b>Dt</b> (Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime Dt;
        
        /// <summary>
        /// Element <b>DtSpecified</b> (Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DtSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>SecuritiesEntryType2Code</b> (Securities Entry Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public enum SecuritiesEntryType2Code
    {
        
        /// <summary>
        /// <b>BLOK - Blocked</b>.
        /// </summary>
        BLOK,
        
        /// <summary>
        /// <b>ELIG - Eligible</b>.
        /// </summary>
        ELIG,
        
        /// <summary>
        /// <b>PEND - Pending Delivery</b>.
        /// </summary>
        PEND,
        
        /// <summary>
        /// <b>PENR - Pending Receipt</b>.
        /// </summary>
        PENR,
        
        /// <summary>
        /// <b>NOMI - Nominee</b>.
        /// </summary>
        NOMI,
        
        /// <summary>
        /// <b>SETD - Settled</b>.
        /// </summary>
        SETD,
        
        /// <summary>
        /// <b>BORR - Borrowed</b>.
        /// </summary>
        BORR,
        
        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,
        
        /// <summary>
        /// <b>SPOS - Street Position</b>.
        /// </summary>
        SPOS,
        
        /// <summary>
        /// <b>TRAD - Trade</b>.
        /// </summary>
        TRAD,
        
        /// <summary>
        /// <b>COLI - Collateral In</b>.
        /// </summary>
        COLI,
        
        /// <summary>
        /// <b>COLO - Collateral Out</b>.
        /// </summary>
        COLO,
        
        /// <summary>
        /// <b>UNBA - Uninstructed Balance</b>.
        /// </summary>
        UNBA,
        
        /// <summary>
        /// <b>INBA - Instructed Balance</b>.
        /// </summary>
        INBA,
        
        /// <summary>
        /// <b>REGO - Out For Registration</b>.
        /// </summary>
        REGO,
    }
    
    /// <summary>
    /// Class <b>EligiblePosition2</b> (Eligible Position 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class EligiblePosition2
    {
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AcctId;
        
        /// <summary>
        /// Element <b>AcctOwnr</b> (Account Owner) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification9Choice AcctOwnr;
        
        /// <summary>
        /// Element <b>HldgBal</b> (Holding Balance) of type array of HoldingBalance3.
        /// </summary>
        [XmlElementAttribute("HldgBal", Order=2)]
        public HoldingBalance3[] HldgBal;
        
        /// <summary>
        /// Element <b>RghtsHldr</b> (Rights Holder) of type array of PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute("RghtsHldr", Order=3)]
        public PartyIdentification9Choice[] RghtsHldr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification9Choice</b> (Party Identification 9Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class PartyIdentification9Choice
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
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
    /// Class <b>AlternateFinancialInstrumentIdentification1</b> (Alternate Financial Instrument Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class AlternateFinancialInstrumentIdentification1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("DmstIdSrc", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryIdSrc", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02", IncludeInSchema=false)]
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
    /// Class <b>SecurityIdentification3</b> (Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class SecurityIdentification3
    {
        
        /// <summary>
        /// Element <b>ISIN</b> (ISIN) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string ISIN;
        
        /// <summary>
        /// Element <b>TckrSymb</b> (Ticker Symbol) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string TckrSymb;
        
        /// <summary>
        /// Element <b>CUSIP</b> (CUSIP) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CUSIP;
        
        /// <summary>
        /// Element <b>SEDOL</b> (SEDOL) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string SEDOL;
        
        /// <summary>
        /// Element <b>QUICK</b> (QUICK) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string QUICK;
        
        /// <summary>
        /// Element <b>OthrId</b> (Other Identification) of type AlternateFinancialInstrumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public AlternateFinancialInstrumentIdentification1 OthrId;
    }
    
    /// <summary>
    /// Class <b>SecurityPosition5</b> (Security Position 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class SecurityPosition5
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification3 Id;
        
        /// <summary>
        /// Element <b>Pos</b> (Position) of type array of EligiblePosition2.
        /// </summary>
        [XmlElementAttribute("Pos", Order=1)]
        public EligiblePosition2[] Pos;
    }
    
    /// <summary>
    /// Class <b>MeetingReference2</b> (Meeting Reference 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class MeetingReference2
    {
        
        /// <summary>
        /// Element <b>MtgId</b> (Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MtgId;
        
        /// <summary>
        /// Element <b>IssrMtgId</b> (Issuer Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IssrMtgId;
        
        /// <summary>
        /// Element <b>MtgDtAndTm</b> (Meeting Date And Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public System.DateTime MtgDtAndTm;
        
        /// <summary>
        /// Element <b>MtgDtAndTmSpecified</b> (Meeting Date And Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MtgDtAndTmSpecified;
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type MeetingType2Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public MeetingType2Code Tp;
        
        /// <summary>
        /// Element <b>TpSpecified</b> (Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpSpecified;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Clssfctn (Classification) of type MeetingTypeClassification1Code 
        /// XtndedClssfctn (Extended Classification) of type string 
        /// </summary>
        [XmlElementAttribute("Clssfctn", typeof(MeetingTypeClassification1Code), Order=4)]
        [XmlElementAttribute("XtndedClssfctn", typeof(string), Order=4)]
        public object Item;
        
        /// <summary>
        /// Element <b>Lctn</b> (Location) of type array of PostalAddress1.
        /// </summary>
        [XmlElementAttribute("Lctn", Order=5)]
        public PostalAddress1[] Lctn;
    }
    
    /// <summary>
    /// Enumeration <b>MeetingType2Code</b> (Meeting Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public enum MeetingType2Code
    {
        
        /// <summary>
        /// <b>XMET - Extraordinary</b>.
        /// </summary>
        XMET,
        
        /// <summary>
        /// <b>GMET - General</b>.
        /// </summary>
        GMET,
        
        /// <summary>
        /// <b>MIXD - Mixed</b>.
        /// </summary>
        MIXD,
        
        /// <summary>
        /// <b>SPCL - Special</b>.
        /// </summary>
        SPCL,
    }
    
    /// <summary>
    /// Enumeration <b>MeetingTypeClassification1Code</b> (Meeting Type Classification 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public enum MeetingTypeClassification1Code
    {
        
        /// <summary>
        /// <b>AMET - Annual</b>.
        /// </summary>
        AMET,
        
        /// <summary>
        /// <b>OMET - Ordinary General Meeting</b>.
        /// </summary>
        OMET,
        
        /// <summary>
        /// <b>CLAS - Class</b>.
        /// </summary>
        CLAS,
        
        /// <summary>
        /// <b>ISSU - Issuer Initiated</b>.
        /// </summary>
        ISSU,
        
        /// <summary>
        /// <b>VRHI - Voting Rights Holder Initiated</b>.
        /// </summary>
        VRHI,
        
        /// <summary>
        /// <b>CORT - Court</b>.
        /// </summary>
        CORT,
    }
    
    /// <summary>
    /// Class <b>MessageIdentification</b> (Message Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class MessageIdentification
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>AmendInformation1</b> (Amend Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.002.001.02")]
    public class AmendInformation1
    {
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type MessageIdentification.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification PrvsRef;
        
        /// <summary>
        /// Element <b>RcnfrmInstrs</b> (Reconfirm Instructions) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool RcnfrmInstrs;
    }
}
