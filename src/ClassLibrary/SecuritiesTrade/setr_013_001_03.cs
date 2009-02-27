
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



namespace i20022.setr01300103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id setr.013.001.03 name SwitchOrderV03 from Securities Trade business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>SwtchOrdrV03</b> (Switch Order V03) of type SwitchOrderV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SwitchOrderV03 SwtchOrdrV03;
    }
    
    /// <summary>
    /// Class <b>SwitchOrderV03</b> (Switch Order V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class SwitchOrderV03
    {
        
        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 MsgId;
        
        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdditionalReference3 PoolRef;
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute("PrvsRef", Order=2)]
        public AdditionalReference3[] PrvsRef;
        
        /// <summary>
        /// Element <b>MsgPgntn</b> (Message Pagination) of type Pagination.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Pagination MsgPgntn;
        
        /// <summary>
        /// Element <b>SwtchOrdrDtls</b> (Switch Order Details) of type array of SwitchOrder4.
        /// </summary>
        [XmlElementAttribute("SwtchOrdrDtls", Order=4)]
        public SwitchOrder4[] SwtchOrdrDtls;
        
        /// <summary>
        /// Element <b>CpyDtls</b> (Copy Details) of type CopyInformation2.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CopyInformation2 CpyDtls;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=6)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>CopyInformation2</b> (Copy Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class CopyInformation2
    {
        
        /// <summary>
        /// Element <b>CpyInd</b> (Copy Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool CpyInd;
        
        /// <summary>
        /// Element <b>OrgnlRcvr</b> (Original Receiver) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BICIdentification1 OrgnlRcvr;
    }
    
    /// <summary>
    /// Class <b>ForeignExchangeTerms6</b> (Foreign Exchange Terms 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class ForeignExchangeTerms6
    {
        
        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string UnitCcy;
        
        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string QtdCcy;
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal XchgRate;
        
        /// <summary>
        /// Element <b>QtnDt</b> (Quotation Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime QtnDt;
        
        /// <summary>
        /// Element <b>QtnDtSpecified</b> (Quotation Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtnDtSpecified;
        
        /// <summary>
        /// Element <b>QtgInstn</b> (Quoting Institution) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice QtgInstn;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Class <b>PaymentInstrument11Choice</b> (Payment Instrument 11 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class PaymentInstrument11Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BkrsDrftDtls (Bankers Draft Details) of type Cheque3 
        /// CdtTrfDtls (Credit Transfer Details) of type CreditTransfer6 
        /// ChqDtls (Cheque Details) of type Cheque3 
        /// CshAcctDtls (Cash Account Details) of type InvestmentAccount20 
        /// </summary>
        [XmlElementAttribute("BkrsDrftDtls", typeof(Cheque3), Order=0)]
        [XmlElementAttribute("CdtTrfDtls", typeof(CreditTransfer6), Order=0)]
        [XmlElementAttribute("ChqDtls", typeof(Cheque3), Order=0)]
        [XmlElementAttribute("CshAcctDtls", typeof(InvestmentAccount20), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType9.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType9 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>Cheque3</b> (Cheque 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Cheque3
    {
        
        /// <summary>
        /// Element <b>Nb</b> (Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nb;
        
        /// <summary>
        /// Element <b>PyeeId</b> (Payee Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice PyeeId;
        
        /// <summary>
        /// Element <b>DrweeId</b> (Drawee Identification) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstitutionIdentification3Choice DrweeId;
        
        /// <summary>
        /// Element <b>DrwrId</b> (Drawer Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification2Choice DrwrId;
    }
    
    /// <summary>
    /// Class <b>FinancialInstitutionIdentification3Choice</b> (Financial Institution Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class FinancialInstitutionIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BIC (BIC) of type string 
        /// ClrSysMmbId (Clearing System Member Identification) of type ClearingSystemMemberIdentificationChoice 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type SimpleIdentificationInformation 
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentificationChoice), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(SimpleIdentificationInformation), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>ClearingSystemMemberIdentificationChoice</b> (Clearing System Member Identification Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class ClearingSystemMemberIdentificationChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("ATBLZ", typeof(string), Order=0)]
        [XmlElementAttribute("AUBSBs", typeof(string), Order=0)]
        [XmlElementAttribute("AUBSBx", typeof(string), Order=0)]
        [XmlElementAttribute("CACPA", typeof(string), Order=0)]
        [XmlElementAttribute("CHBC", typeof(string), Order=0)]
        [XmlElementAttribute("CHSIC", typeof(string), Order=0)]
        [XmlElementAttribute("DEBLZ", typeof(string), Order=0)]
        [XmlElementAttribute("ESNCC", typeof(string), Order=0)]
        [XmlElementAttribute("GBSC", typeof(string), Order=0)]
        [XmlElementAttribute("HKNCC", typeof(string), Order=0)]
        [XmlElementAttribute("IENSC", typeof(string), Order=0)]
        [XmlElementAttribute("ITNCC", typeof(string), Order=0)]
        [XmlElementAttribute("NZNCC", typeof(string), Order=0)]
        [XmlElementAttribute("PTNCC", typeof(string), Order=0)]
        [XmlElementAttribute("RUCB", typeof(string), Order=0)]
        [XmlElementAttribute("USCH", typeof(string), Order=0)]
        [XmlElementAttribute("USCHU", typeof(string), Order=0)]
        [XmlElementAttribute("USFW", typeof(string), Order=0)]
        [XmlElementAttribute("ZANCC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType7</b> (Item Choice Type 7).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType7
    {
        
        /// <summary>
        /// <b>ATBLZ - Austrian Bankleitzahl Identifier</b>.
        /// </summary>
        ATBLZ,
        
        /// <summary>
        /// <b>AUBSBs - Small Network Identifier</b>.
        /// </summary>
        AUBSBs,
        
        /// <summary>
        /// <b>AUBSBx - Extensive Branch Network Identifier</b>.
        /// </summary>
        AUBSBx,
        
        /// <summary>
        /// <b>CACPA - Canadian Payments ARN Identifier</b>.
        /// </summary>
        CACPA,
        
        /// <summary>
        /// <b>CHBC - Swiss BC Identifier</b>.
        /// </summary>
        CHBC,
        
        /// <summary>
        /// <b>CHSIC - Swiss SIC Identifier</b>.
        /// </summary>
        CHSIC,
        
        /// <summary>
        /// <b>DEBLZ - German Bankleitzahl Identifier</b>.
        /// </summary>
        DEBLZ,
        
        /// <summary>
        /// <b>ESNCC - Spanish Domestic Interbanking Identifier</b>.
        /// </summary>
        ESNCC,
        
        /// <summary>
        /// <b>GBSC - UK Domestic Sort Code Identifier</b>.
        /// </summary>
        GBSC,
        
        /// <summary>
        /// <b>HKNCC - Hong Kong Bank Identifier</b>.
        /// </summary>
        HKNCC,
        
        /// <summary>
        /// <b>IENSC - Irish NSC Identifier</b>.
        /// </summary>
        IENSC,
        
        /// <summary>
        /// <b>ITNCC - Italian Domestic Identifier</b>.
        /// </summary>
        ITNCC,
        
        /// <summary>
        /// <b>NZNCC - New Zealand NCC Identifier</b>.
        /// </summary>
        NZNCC,
        
        /// <summary>
        /// <b>PTNCC - Portuguese NCC Identifier</b>.
        /// </summary>
        PTNCC,
        
        /// <summary>
        /// <b>RUCB - Russian Central Bank Identification Code Identifier</b>.
        /// </summary>
        RUCB,
        
        /// <summary>
        /// <b>USCH - CHIPS Participant Identifier</b>.
        /// </summary>
        USCH,
        
        /// <summary>
        /// <b>USCHU - CHIPS Universal Identifier</b>.
        /// </summary>
        USCHU,
        
        /// <summary>
        /// <b>USFW - Fedwire Routing Number Identifier</b>.
        /// </summary>
        USFW,
        
        /// <summary>
        /// <b>ZANCC - South African NCC Identifier</b>.
        /// </summary>
        ZANCC,
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>CreditTransfer6</b> (Credit Transfer 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class CreditTransfer6
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice Dbtr;
        
        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AccountIdentificationAndName3 DbtrAcct;
        
        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public FinancialInstitutionIdentification3Choice DbtrAgt;
        
        /// <summary>
        /// Element <b>DbtrAgtAcct</b> (Debtor Agent Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public AccountIdentificationAndName3 DbtrAgtAcct;
        
        /// <summary>
        /// Element <b>IntrmyAgt1</b> (Intermediary Agent 1) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstitutionIdentification3Choice IntrmyAgt1;
        
        /// <summary>
        /// Element <b>IntrmyAgt1Acct</b> (Intermediary Agent 1Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public AccountIdentificationAndName3 IntrmyAgt1Acct;
        
        /// <summary>
        /// Element <b>IntrmyAgt2</b> (Intermediary Agent 2) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public FinancialInstitutionIdentification3Choice IntrmyAgt2;
        
        /// <summary>
        /// Element <b>IntrmyAgt2Acct</b> (Intermediary Agent 2Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public AccountIdentificationAndName3 IntrmyAgt2Acct;
        
        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public FinancialInstitutionIdentification3Choice CdtrAgt;
        
        /// <summary>
        /// Element <b>CdtrAgtAcct</b> (Creditor Agent Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public AccountIdentificationAndName3 CdtrAgtAcct;
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public PartyIdentification2Choice Cdtr;
        
        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public AccountIdentificationAndName3 CdtrAcct;
    }
    
    /// <summary>
    /// Class <b>AccountIdentificationAndName3</b> (Account Identification And Name 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class AccountIdentificationAndName3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type CashAccountIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CashAccountIdentification1Choice Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
    }
    
    /// <summary>
    /// Class <b>CashAccountIdentification1Choice</b> (Cash Account Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class CashAccountIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BBAN (BBAN) of type string 
        /// DmstAcct (Domestic Account) of type SimpleIdentificationInformation 
        /// IBAN (IBAN) of type string 
        /// UPIC (UPIC) of type string 
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("DmstAcct", typeof(SimpleIdentificationInformation), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType6.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType6</b> (Item Choice Type 6).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType6
    {
        
        /// <summary>
        /// <b>BBAN - Basic Bank Account Number</b>.
        /// </summary>
        BBAN,
        
        /// <summary>
        /// <b>DmstAcct - Domestic Account</b>.
        /// </summary>
        DmstAcct,
        
        /// <summary>
        /// <b>IBAN - International Bank Account Number</b>.
        /// </summary>
        IBAN,
        
        /// <summary>
        /// <b>UPIC - Universal Promotional Identification Code</b>.
        /// </summary>
        UPIC,
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount20</b> (Investment Account 20).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class InvestmentAccount20
    {
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type FundCashAccount2Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(FundCashAccount2Code), Order=1)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=1)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class AccountIdentification1
    {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Enumeration <b>FundCashAccount2Code</b> (Fund Cash Account 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum FundCashAccount2Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CPFO - Pension Fund Ordinary</b>.
        /// </summary>
        CPFO,
        
        /// <summary>
        /// <b>CPFS - Pension Fund Special</b>.
        /// </summary>
        CPFS,
        
        /// <summary>
        /// <b>SRSA - Retirement Scheme</b>.
        /// </summary>
        SRSA,
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType9</b> (Item Choice Type 9).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType9
    {
        
        /// <summary>
        /// <b>BkrsDrftDtls - Bankers Draft Details</b>.
        /// </summary>
        BkrsDrftDtls,
        
        /// <summary>
        /// <b>CdtTrfDtls - Credit Transfer Details</b>.
        /// </summary>
        CdtTrfDtls,
        
        /// <summary>
        /// <b>ChqDtls - Cheque Details</b>.
        /// </summary>
        ChqDtls,
        
        /// <summary>
        /// <b>CshAcctDtls - Cash Account Details</b>.
        /// </summary>
        CshAcctDtls,
    }
    
    /// <summary>
    /// Class <b>BranchData</b> (Branch Data).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class BranchData
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PostalAddress1 PstlAdr;
    }
    
    /// <summary>
    /// Class <b>DirectDebitMandate4</b> (Direct Debit Mandate 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class DirectDebitMandate4
    {
        
        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentificationAndName3 DbtrAcct;
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice Dbtr;
        
        /// <summary>
        /// Element <b>DbtrTaxIdNb</b> (Debtor Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string DbtrTaxIdNb;
        
        /// <summary>
        /// Element <b>DbtrNtlRegnNb</b> (Debtor National Registration Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DbtrNtlRegnNb;
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice Cdtr;
        
        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstitutionIdentification3Choice DbtrAgt;
        
        /// <summary>
        /// Element <b>DbtrAgtBrnch</b> (Debtor Agent Branch) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public BranchData DbtrAgtBrnch;
        
        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public FinancialInstitutionIdentification3Choice CdtrAgt;
        
        /// <summary>
        /// Element <b>CdtrAgtBrnch</b> (Creditor Agent Branch) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BranchData CdtrAgtBrnch;
        
        /// <summary>
        /// Element <b>RegnId</b> (Registration Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string RegnId;
        
        /// <summary>
        /// Element <b>MndtId</b> (Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string MndtId;
    }
    
    /// <summary>
    /// Class <b>PaymentCard2</b> (Payment Card 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class PaymentCard2
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CardType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CardType1Code Tp;
        
        /// <summary>
        /// Element <b>Nb</b> (Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nb;
        
        /// <summary>
        /// Element <b>HldrNm</b> (Holder Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string HldrNm;
        
        /// <summary>
        /// Element <b>StartDt</b> (Start Date) of type string.
        /// </summary>
        [XmlElementAttribute(DataType="gYearMonth", Order=3)]
        public string StartDt;
        
        /// <summary>
        /// Element <b>XpryDt</b> (Expiry Date) of type string.
        /// </summary>
        [XmlElementAttribute(DataType="gYearMonth", Order=4)]
        public string XpryDt;
        
        /// <summary>
        /// Element <b>CardIssrNm</b> (Card Issuer Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string CardIssrNm;
        
        /// <summary>
        /// Element <b>CardIssrId</b> (Card Issuer Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification2Choice CardIssrId;
        
        /// <summary>
        /// Element <b>SctyCd</b> (Security Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string SctyCd;
        
        /// <summary>
        /// Element <b>SeqNb</b> (Sequence Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string SeqNb;
    }
    
    /// <summary>
    /// Enumeration <b>CardType1Code</b> (Card Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum CardType1Code
    {
        
        /// <summary>
        /// <b>CRDT - Credit Card</b>.
        /// </summary>
        CRDT,
        
        /// <summary>
        /// <b>DBIT - Debit Card</b>.
        /// </summary>
        DBIT,
    }
    
    /// <summary>
    /// Class <b>PaymentInstrument12Choice</b> (Payment Instrument 12 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class PaymentInstrument12Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BkrsDrftDtls (Bankers Draft Details) of type Cheque3 
        /// CdtTrfDtls (Credit Transfer Details) of type CreditTransfer6 
        /// ChqDtls (Cheque Details) of type Cheque3 
        /// CshAcctDtls (Cash Account Details) of type InvestmentAccount20 
        /// DrctDbtDtls (Direct Debit Details) of type DirectDebitMandate4 
        /// PmtCardDtls (Payment Card Details) of type PaymentCard2 
        /// </summary>
        [XmlElementAttribute("BkrsDrftDtls", typeof(Cheque3), Order=0)]
        [XmlElementAttribute("CdtTrfDtls", typeof(CreditTransfer6), Order=0)]
        [XmlElementAttribute("ChqDtls", typeof(Cheque3), Order=0)]
        [XmlElementAttribute("CshAcctDtls", typeof(InvestmentAccount20), Order=0)]
        [XmlElementAttribute("DrctDbtDtls", typeof(DirectDebitMandate4), Order=0)]
        [XmlElementAttribute("PmtCardDtls", typeof(PaymentCard2), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType8 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType8</b> (Item Choice Type 8).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType8
    {
        
        /// <summary>
        /// <b>BkrsDrftDtls - Bankers Draft Details</b>.
        /// </summary>
        BkrsDrftDtls,
        
        /// <summary>
        /// <b>CdtTrfDtls - Credit Transfer Details</b>.
        /// </summary>
        CdtTrfDtls,
        
        /// <summary>
        /// <b>ChqDtls - Cheque Details</b>.
        /// </summary>
        ChqDtls,
        
        /// <summary>
        /// <b>CshAcctDtls - Cash Account Details</b>.
        /// </summary>
        CshAcctDtls,
        
        /// <summary>
        /// <b>DrctDbtDtls - Direct Debit Details</b>.
        /// </summary>
        DrctDbtDtls,
        
        /// <summary>
        /// <b>PmtCardDtls - Payment Card Details</b>.
        /// </summary>
        PmtCardDtls,
    }
    
    /// <summary>
    /// Class <b>CashInOrOut5Choice</b> (Cash In Or Out 5Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class CashInOrOut5Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CshInPmtInstrm (Cash In Payment Instrument) of type PaymentInstrument12Choice 
        /// CshOutPmtInstrm (Cash Out Payment Instrument) of type PaymentInstrument11Choice 
        /// </summary>
        [XmlElementAttribute("CshInPmtInstrm", typeof(PaymentInstrument12Choice), Order=0)]
        [XmlElementAttribute("CshOutPmtInstrm", typeof(PaymentInstrument11Choice), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PaymentTransaction25</b> (Payment Transaction 25).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class PaymentTransaction25
    {
        
        /// <summary>
        /// Element <b>CshInOrOut</b> (Cash In Or Out) of type CashInOrOut5Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CashInOrOut5Choice CshInOrOut;
    }
    
    /// <summary>
    /// Class <b>FundSettlementParameters4</b> (Fund Settlement Parameters 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class FundSettlementParameters4
    {
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SttlmDtSpecified</b> (Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmDtSpecified;
        
        /// <summary>
        /// Element <b>SttlmPlc</b> (Settlement Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice SttlmPlc;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice SfkpgPlc;
        
        /// <summary>
        /// Element <b>SctiesSttlmSysId</b> (Securities Settlement System Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string SctiesSttlmSysId;
        
        /// <summary>
        /// Element <b>RcvgSdDtls</b> (Receiving Side Details) of type ReceivingPartiesAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ReceivingPartiesAndAccount3 RcvgSdDtls;
        
        /// <summary>
        /// Element <b>DlvrgSdDtls</b> (Delivering Side Details) of type DeliveringPartiesAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DeliveringPartiesAndAccount3 DlvrgSdDtls;
    }
    
    /// <summary>
    /// Class <b>ReceivingPartiesAndAccount3</b> (Receiving Parties And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class ReceivingPartiesAndAccount3
    {
        
        /// <summary>
        /// Element <b>RcvrsCtdnDtls</b> (Receivers Custodian Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentificationAndAccount3 RcvrsCtdnDtls;
        
        /// <summary>
        /// Element <b>RcvrsIntrmyDtls</b> (Receivers Intermediary Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentificationAndAccount3 RcvrsIntrmyDtls;
        
        /// <summary>
        /// Element <b>RcvgAgtDtls</b> (Receiving Agent Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentificationAndAccount3 RcvgAgtDtls;
    }
    
    /// <summary>
    /// Class <b>PartyIdentificationAndAccount3</b> (Party Identification And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class PartyIdentificationAndAccount3
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice PtyId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
    }
    
    /// <summary>
    /// Class <b>DeliveringPartiesAndAccount3</b> (Delivering Parties And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class DeliveringPartiesAndAccount3
    {
        
        /// <summary>
        /// Element <b>DlvrrsCtdnDtls</b> (Deliverers Custodian Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentificationAndAccount3 DlvrrsCtdnDtls;
        
        /// <summary>
        /// Element <b>DlvrrsIntrmyDtls</b> (Deliverers Intermediary Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentificationAndAccount3 DlvrrsIntrmyDtls;
        
        /// <summary>
        /// Element <b>DlvrgAgtDtls</b> (Delivering Agent Details) of type PartyIdentificationAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentificationAndAccount3 DlvrgAgtDtls;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentQuantity6Choice</b> (Financial Instrument Quantity 6Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class FinancialInstrumentQuantity6Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// GrssAmt (Gross Amount) of type ActiveOrHistoricCurrencyAndAmount 
        /// NetAmt (Net Amount) of type ActiveOrHistoricCurrencyAndAmount 
        /// PctgOfTtlRedAmt (Percentage Of Total Redemption Amount) of type decimal 
        /// UnitsNb (Units Number) of type FinancialInstrumentQuantity1 
        /// </summary>
        [XmlElementAttribute("GrssAmt", typeof(ActiveOrHistoricCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("NetAmt", typeof(ActiveOrHistoricCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("PctgOfTtlRedAmt", typeof(decimal), Order=0)]
        [XmlElementAttribute("UnitsNb", typeof(FinancialInstrumentQuantity1), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType5.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType5</b> (Item Choice Type 5).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType5
    {
        
        /// <summary>
        /// <b>GrssAmt - Gross Amount</b>.
        /// </summary>
        GrssAmt,
        
        /// <summary>
        /// <b>NetAmt - Net Amount</b>.
        /// </summary>
        NetAmt,
        
        /// <summary>
        /// <b>PctgOfTtlRedAmt - Percentage Of Total Redemption Amount</b>.
        /// </summary>
        PctgOfTtlRedAmt,
        
        /// <summary>
        /// <b>UnitsNb - Units Number</b>.
        /// </summary>
        UnitsNb,
    }
    
    /// <summary>
    /// Class <b>SwitchSubscriptionLegOrder3</b> (Switch Subscription Leg Order 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class SwitchSubscriptionLegOrder3
    {
        
        /// <summary>
        /// Element <b>LegId</b> (Leg Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string LegId;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstrument10 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>FinInstrmQtyChc</b> (Financial Instrument Quantity Choice) of type FinancialInstrumentQuantity6Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstrumentQuantity6Choice FinInstrmQtyChc;
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount21.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentAccount21 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>ReqdSttlmCcy</b> (Requested Settlement Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string ReqdSttlmCcy;
        
        /// <summary>
        /// Element <b>ReqdNAVCcy</b> (Requested NAV Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string ReqdNAVCcy;
        
        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge17.
        /// </summary>
        [XmlElementAttribute("ChrgDtls", Order=7)]
        public Charge17[] ChrgDtls;
        
        /// <summary>
        /// Element <b>ComssnDtls</b> (Commission Details) of type array of Commission10.
        /// </summary>
        [XmlElementAttribute("ComssnDtls", Order=8)]
        public Commission10[] ComssnDtls;
        
        /// <summary>
        /// Element <b>SttlmAndCtdyDtls</b> (Settlement And Custody Details) of type FundSettlementParameters4.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public FundSettlementParameters4 SttlmAndCtdyDtls;
        
        /// <summary>
        /// Element <b>PhysDlvryInd</b> (Physical Delivery Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public bool PhysDlvryInd;
        
        /// <summary>
        /// Element <b>TaxDtls</b> (Tax Details) of type array of Tax16.
        /// </summary>
        [XmlElementAttribute("TaxDtls", Order=11)]
        public Tax16[] TaxDtls;
        
        /// <summary>
        /// Element <b>NonStdSttlmInf</b> (Non Standard Settlement Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public string NonStdSttlmInf;
        
        /// <summary>
        /// Element <b>PhysDlvryDtls</b> (Physical Delivery Details) of type NameAndAddress4.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public NameAndAddress4 PhysDlvryDtls;
        
        /// <summary>
        /// Element <b>Equlstn</b> (Equalisation) of type Equalisation1.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public Equalisation1 Equlstn;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrument10</b> (Financial Instrument 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType2
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
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType3
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Class <b>InvestmentAccount21</b> (Investment Account 21).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class InvestmentAccount21
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
        
        /// <summary>
        /// Element <b>OrdrOrgtrElgblty</b> (Order Originator Eligibility) of type OrderOriginatorEligibility1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public OrderOriginatorEligibility1Code OrdrOrgtrElgblty;
        
        /// <summary>
        /// Element <b>OrdrOrgtrElgbltySpecified</b> (Order Originator Eligibility Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdrOrgtrElgbltySpecified;
        
        /// <summary>
        /// Element <b>SubAcctDtls</b> (Sub Account Details) of type SubAccount1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public SubAccount1 SubAcctDtls;
    }
    
    /// <summary>
    /// Enumeration <b>OrderOriginatorEligibility1Code</b> (Order Originator Eligibility 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum OrderOriginatorEligibility1Code
    {
        
        /// <summary>
        /// <b>ELIG - Eligible</b>.
        /// </summary>
        ELIG,
        
        /// <summary>
        /// <b>RETL - Retail</b>.
        /// </summary>
        RETL,
        
        /// <summary>
        /// <b>PROF - Professional</b>.
        /// </summary>
        PROF,
    }
    
    /// <summary>
    /// Class <b>SubAccount1</b> (Sub Account 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class SubAccount1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Chrtc</b> (Characteristic) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Chrtc;
    }
    
    /// <summary>
    /// Enumeration <b>IncomePreference1Code</b> (Income Preference 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum IncomePreference1Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
    }
    
    /// <summary>
    /// Class <b>Charge17</b> (Charge 17).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Charge17
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
        /// ChrgBsis (Charge Basis) of type TaxationBasis2Code 
        /// XtndedChrgBsis (Extended Charge Basis) of type string 
        /// </summary>
        [XmlElementAttribute("ChrgBsis", typeof(TaxationBasis2Code), Order=1)]
        [XmlElementAttribute("XtndedChrgBsis", typeof(string), Order=1)]
        public object Item1;
        
        /// <summary>
        /// Element <b>Item2</b> (Item 2) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAnd13DecimalAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAnd13DecimalAmount), Order=2)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=2)]
        public object Item2;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification2Choice RcptId;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType11Code</b> (Charge Type 11 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Enumeration <b>TaxationBasis2Code</b> (Taxation Basis 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum TaxationBasis2Code
    {
        
        /// <summary>
        /// <b>FLAT - Flat</b>.
        /// </summary>
        FLAT,
        
        /// <summary>
        /// <b>PERU - Per Unit</b>.
        /// </summary>
        PERU,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Class <b>Commission10</b> (Commission 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Commission10
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type CommissionType6Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(CommissionType6Code), Order=0)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Bsis (Basis) of type TaxationBasis4Code 
        /// XtndedBsis (Extended Basis) of type string 
        /// </summary>
        [XmlElementAttribute("Bsis", typeof(TaxationBasis4Code), Order=1)]
        [XmlElementAttribute("XtndedBsis", typeof(string), Order=1)]
        public object Item1;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
        
        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public decimal Rate;
        
        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateSpecified;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice RcptId;
        
        /// <summary>
        /// Element <b>ComrclAgrmtRef</b> (Commercial Agreement Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string ComrclAgrmtRef;
        
        /// <summary>
        /// Element <b>WvgDtls</b> (Waiving Details) of type CommissionWaiver3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CommissionWaiver3 WvgDtls;
    }
    
    /// <summary>
    /// Enumeration <b>CommissionType6Code</b> (Commission Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Enumeration <b>TaxationBasis4Code</b> (Taxation Basis 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum TaxationBasis4Code
    {
        
        /// <summary>
        /// <b>FLAT - Flat</b>.
        /// </summary>
        FLAT,
        
        /// <summary>
        /// <b>PERU - Per Unit</b>.
        /// </summary>
        PERU,
        
        /// <summary>
        /// <b>GRAM - Gross Amount</b>.
        /// </summary>
        GRAM,
        
        /// <summary>
        /// <b>NEAM - Net Amount</b>.
        /// </summary>
        NEAM,
    }
    
    /// <summary>
    /// Class <b>CommissionWaiver3</b> (Commission Waiver 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class CommissionWaiver3
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// InstrBsis (Instruction Basis) of type WaivingInstruction1Code 
        /// XtndedInstrBsis (Extended Instruction Basis) of type string 
        /// </summary>
        [XmlElementAttribute("InstrBsis", typeof(WaivingInstruction1Code), Order=0)]
        [XmlElementAttribute("XtndedInstrBsis", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>WvdRate</b> (Waived Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal WvdRate;
    }
    
    /// <summary>
    /// Enumeration <b>WaivingInstruction1Code</b> (Waiving Instruction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum WaivingInstruction1Code
    {
        
        /// <summary>
        /// <b>WICA - Waive In Cash</b>.
        /// </summary>
        WICA,
        
        /// <summary>
        /// <b>WIUN - Waive In Units</b>.
        /// </summary>
        WIUN,
    }
    
    /// <summary>
    /// Class <b>Tax16</b> (Tax 16).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Tax16
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type TaxType10Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(TaxType10Code), Order=0)]
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
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Ctry;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification2Choice RcptId;
        
        /// <summary>
        /// Element <b>XmptnInd</b> (Exemption Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool XmptnInd;
        
        /// <summary>
        /// Element <b>Item2</b> (Item 2) of type object.
        /// [XOR] This element can be:
        /// XmptnRsn (Exemption Reason) of type TaxExemptReason1Code 
        /// XtndedXmptnRsn (Extended Exemption Reason) of type string 
        /// </summary>
        [XmlElementAttribute("XmptnRsn", typeof(TaxExemptReason1Code), Order=5)]
        [XmlElementAttribute("XtndedXmptnRsn", typeof(string), Order=5)]
        public object Item2;
        
        /// <summary>
        /// Element <b>TaxClctnDtls</b> (Tax Calculation Details) of type TaxCalculationInformation5.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public TaxCalculationInformation5 TaxClctnDtls;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType10Code</b> (Tax Type 10 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum TaxType10Code
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
        /// <b>KAPA - Capital Gain Tax</b>.
        /// </summary>
        KAPA,
        
        /// <summary>
        /// <b>INPO - Interim Profit Tax</b>.
        /// </summary>
        INPO,
        
        /// <summary>
        /// <b>STAM - Stamp Duty</b>.
        /// </summary>
        STAM,
        
        /// <summary>
        /// <b>WTAX - Wealth Tax</b>.
        /// </summary>
        WTAX,
        
        /// <summary>
        /// <b>INHT - Inheritance Tax</b>.
        /// </summary>
        INHT,
        
        /// <summary>
        /// <b>SOSU - Solidarity Surcharge</b>.
        /// </summary>
        SOSU,
        
        /// <summary>
        /// <b>CTAX - Tax Credit</b>.
        /// </summary>
        CTAX,
        
        /// <summary>
        /// <b>GIFT - Gift Tax</b>.
        /// </summary>
        GIFT,
        
        /// <summary>
        /// <b>COAX - Consumption Tax</b>.
        /// </summary>
        COAX,
        
        /// <summary>
        /// <b>AKT1 - Aktiengewinn 1</b>.
        /// </summary>
        AKT1,
        
        /// <summary>
        /// <b>AKT2 - Aktiengewinn 2</b>.
        /// </summary>
        AKT2,
        
        /// <summary>
        /// <b>ZWIS - Zwischengewinn</b>.
        /// </summary>
        ZWIS,
    }
    
    /// <summary>
    /// Enumeration <b>TaxExemptReason1Code</b> (Tax Exempt Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum TaxExemptReason1Code
    {
        
        /// <summary>
        /// <b>NONE - None</b>.
        /// </summary>
        NONE,
        
        /// <summary>
        /// <b>MASA - Maxi ISA</b>.
        /// </summary>
        MASA,
        
        /// <summary>
        /// <b>MISA - Mini Cash ISA</b>.
        /// </summary>
        MISA,
        
        /// <summary>
        /// <b>SISA - Mini Stocks And Shares ISA</b>.
        /// </summary>
        SISA,
        
        /// <summary>
        /// <b>IISA - Mini Insurance ISA</b>.
        /// </summary>
        IISA,
        
        /// <summary>
        /// <b>CUYP - Current Year Payment</b>.
        /// </summary>
        CUYP,
        
        /// <summary>
        /// <b>PRYP - Prior Year Payment</b>.
        /// </summary>
        PRYP,
        
        /// <summary>
        /// <b>ASTR - Asset Transfer</b>.
        /// </summary>
        ASTR,
        
        /// <summary>
        /// <b>EMPY - Employee Prior Year</b>.
        /// </summary>
        EMPY,
        
        /// <summary>
        /// <b>EMCY - Employee Current Year</b>.
        /// </summary>
        EMCY,
        
        /// <summary>
        /// <b>EPRY - Employer Prior Year</b>.
        /// </summary>
        EPRY,
        
        /// <summary>
        /// <b>ECYE - Employer Current Year</b>.
        /// </summary>
        ECYE,
        
        /// <summary>
        /// <b>NFPI - Non Fund Prototype IRA</b>.
        /// </summary>
        NFPI,
        
        /// <summary>
        /// <b>NFQP - Non Fund Qualified Plan</b>.
        /// </summary>
        NFQP,
        
        /// <summary>
        /// <b>DECP - Defined Contribution Plan</b>.
        /// </summary>
        DECP,
        
        /// <summary>
        /// <b>IRAC - Individual Retirement Account</b>.
        /// </summary>
        IRAC,
        
        /// <summary>
        /// <b>IRAR - Individual Retirement Account Rollover</b>.
        /// </summary>
        IRAR,
        
        /// <summary>
        /// <b>KEOG - KEOGH</b>.
        /// </summary>
        KEOG,
        
        /// <summary>
        /// <b>PFSP - Profit Sharing Plan</b>.
        /// </summary>
        PFSP,
        
        /// <summary>
        /// <b>Item401K - Item 401K</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("401K")]
        Item401K,
        
        /// <summary>
        /// <b>SIRA - Self Directed IRA</b>.
        /// </summary>
        SIRA,
        
        /// <summary>
        /// <b>Item403B - Item 403B</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("403B")]
        Item403B,
        
        /// <summary>
        /// <b>Item457X - Item 457X</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("457X")]
        Item457X,
        
        /// <summary>
        /// <b>RIRA - Roth IRA Fund Prototype</b>.
        /// </summary>
        RIRA,
        
        /// <summary>
        /// <b>RIAN - Roth IRA Non Prototype</b>.
        /// </summary>
        RIAN,
        
        /// <summary>
        /// <b>RCRF - Roth Conversion IRAFund Prototype</b>.
        /// </summary>
        RCRF,
        
        /// <summary>
        /// <b>RCIP - Roth Conversion IRANon Prototype</b>.
        /// </summary>
        RCIP,
        
        /// <summary>
        /// <b>EIFP - Education IRAFund Prototype</b>.
        /// </summary>
        EIFP,
        
        /// <summary>
        /// <b>EIOP - Education IRANon Prototype</b>.
        /// </summary>
        EIOP,
    }
    
    /// <summary>
    /// Class <b>TaxCalculationInformation5</b> (Tax Calculation Information 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class TaxCalculationInformation5
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Bsis (Basis) of type TaxationBasis2Code 
        /// XtndedBsis (Extended Basis) of type string 
        /// </summary>
        [XmlElementAttribute("Bsis", typeof(TaxationBasis2Code), Order=0)]
        [XmlElementAttribute("XtndedBsis", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress4</b> (Name And Address 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class NameAndAddress4
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
    /// Class <b>Equalisation1</b> (Equalisation 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Equalisation1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveOrHistoricCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Rate;
        
        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateSpecified;
    }
    
    /// <summary>
    /// Class <b>DeliveryParameters3</b> (Delivery Parameters 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class DeliveryParameters3
    {
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type NameAndAddress4.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public NameAndAddress4 Adr;
        
        /// <summary>
        /// Element <b>IssdCertNb</b> (Issued Certificate Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IssdCertNb;
    }
    
    /// <summary>
    /// Class <b>FundSettlementParameters3</b> (Fund Settlement Parameters 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class FundSettlementParameters3
    {
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SttlmDtSpecified</b> (Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmDtSpecified;
        
        /// <summary>
        /// Element <b>SttlmPlc</b> (Settlement Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice SttlmPlc;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice SfkpgPlc;
        
        /// <summary>
        /// Element <b>SctiesSttlmSysId</b> (Securities Settlement System Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string SctiesSttlmSysId;
        
        /// <summary>
        /// Element <b>RcvgSdDtls</b> (Receiving Side Details) of type ReceivingPartiesAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ReceivingPartiesAndAccount3 RcvgSdDtls;
        
        /// <summary>
        /// Element <b>DlvrgSdDtls</b> (Delivering Side Details) of type DeliveringPartiesAndAccount3.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DeliveringPartiesAndAccount3 DlvrgSdDtls;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentQuantity5Choice</b> (Financial Instrument Quantity 5Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class FinancialInstrumentQuantity5Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// GrssAmt (Gross Amount) of type ActiveOrHistoricCurrencyAndAmount 
        /// HldgsRedRate (Holdings Redemption Rate) of type decimal 
        /// NetAmt (Net Amount) of type ActiveOrHistoricCurrencyAndAmount 
        /// PctgOfTtlSbcptAmt (Percentage Of Total Subscription Amount) of type decimal 
        /// UnitsNb (Units Number) of type FinancialInstrumentQuantity1 
        /// </summary>
        [XmlElementAttribute("GrssAmt", typeof(ActiveOrHistoricCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("HldgsRedRate", typeof(decimal), Order=0)]
        [XmlElementAttribute("NetAmt", typeof(ActiveOrHistoricCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("PctgOfTtlSbcptAmt", typeof(decimal), Order=0)]
        [XmlElementAttribute("UnitsNb", typeof(FinancialInstrumentQuantity1), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType4</b> (Item Choice Type 4).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType4
    {
        
        /// <summary>
        /// <b>GrssAmt - Gross Amount</b>.
        /// </summary>
        GrssAmt,
        
        /// <summary>
        /// <b>HldgsRedRate - Holdings Redemption Rate</b>.
        /// </summary>
        HldgsRedRate,
        
        /// <summary>
        /// <b>NetAmt - Net Amount</b>.
        /// </summary>
        NetAmt,
        
        /// <summary>
        /// <b>PctgOfTtlSbcptAmt - Percentage Of Total Subscription Amount</b>.
        /// </summary>
        PctgOfTtlSbcptAmt,
        
        /// <summary>
        /// <b>UnitsNb - Units Number</b>.
        /// </summary>
        UnitsNb,
    }
    
    /// <summary>
    /// Class <b>SwitchRedemptionLegOrder3</b> (Switch Redemption Leg Order 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class SwitchRedemptionLegOrder3
    {
        
        /// <summary>
        /// Element <b>LegId</b> (Leg Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string LegId;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstrument10 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>FinInstrmQtyChc</b> (Financial Instrument Quantity Choice) of type FinancialInstrumentQuantity5Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstrumentQuantity5Choice FinInstrmQtyChc;
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount21.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentAccount21 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>Grp1Or2Units</b> (Group 1Or 2Units) of type UKTaxGroupUnitCode.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public UKTaxGroupUnitCode Grp1Or2Units;
        
        /// <summary>
        /// Element <b>Grp1Or2UnitsSpecified</b> (Group 1Or 2Units Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Grp1Or2UnitsSpecified;
        
        /// <summary>
        /// Element <b>ReqdSttlmCcy</b> (Requested Settlement Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string ReqdSttlmCcy;
        
        /// <summary>
        /// Element <b>ReqdNAVCcy</b> (Requested NAV Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string ReqdNAVCcy;
        
        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge17.
        /// </summary>
        [XmlElementAttribute("ChrgDtls", Order=8)]
        public Charge17[] ChrgDtls;
        
        /// <summary>
        /// Element <b>ComssnDtls</b> (Commission Details) of type array of Commission10.
        /// </summary>
        [XmlElementAttribute("ComssnDtls", Order=9)]
        public Commission10[] ComssnDtls;
        
        /// <summary>
        /// Element <b>TaxDtls</b> (Tax Details) of type array of Tax16.
        /// </summary>
        [XmlElementAttribute("TaxDtls", Order=10)]
        public Tax16[] TaxDtls;
        
        /// <summary>
        /// Element <b>SttlmAndCtdyDtls</b> (Settlement And Custody Details) of type FundSettlementParameters3.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public FundSettlementParameters3 SttlmAndCtdyDtls;
        
        /// <summary>
        /// Element <b>PhysDlvryInd</b> (Physical Delivery Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public bool PhysDlvryInd;
        
        /// <summary>
        /// Element <b>PhysDlvryDtls</b> (Physical Delivery Details) of type DeliveryParameters3.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public DeliveryParameters3 PhysDlvryDtls;
        
        /// <summary>
        /// Element <b>NonStdSttlmInf</b> (Non Standard Settlement Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public string NonStdSttlmInf;
        
        /// <summary>
        /// Element <b>Equlstn</b> (Equalisation) of type Equalisation1.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public Equalisation1 Equlstn;
    }
    
    /// <summary>
    /// Enumeration <b>UKTaxGroupUnitCode</b> (UK Tax Group Unit Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum UKTaxGroupUnitCode
    {
        
        /// <summary>
        /// <b>GRP1 - Group 1</b>.
        /// </summary>
        GRP1,
        
        /// <summary>
        /// <b>GRP2 - Group 2</b>.
        /// </summary>
        GRP2,
    }
    
    /// <summary>
    /// Class <b>Account7</b> (Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Account7
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>Intermediary8</b> (Intermediary 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Intermediary8
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice Id;
        
        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Account7 Acct;
        
        /// <summary>
        /// Element <b>OrdrOrgtrElgblty</b> (Order Originator Eligibility) of type OrderOriginatorEligibility1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public OrderOriginatorEligibility1Code OrdrOrgtrElgblty;
        
        /// <summary>
        /// Element <b>OrdrOrgtrElgbltySpecified</b> (Order Originator Eligibility Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdrOrgtrElgbltySpecified;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Role (Role) of type InvestmentFundRole2Code 
        /// XtndedRole (Extended Role) of type string 
        /// </summary>
        [XmlElementAttribute("Role", typeof(InvestmentFundRole2Code), Order=3)]
        [XmlElementAttribute("XtndedRole", typeof(string), Order=3)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>InvestmentFundRole2Code</b> (Investment Fund Role 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum InvestmentFundRole2Code
    {
        
        /// <summary>
        /// <b>FMCO - Fund Management Company</b>.
        /// </summary>
        FMCO,
        
        /// <summary>
        /// <b>REGI - Registrar</b>.
        /// </summary>
        REGI,
        
        /// <summary>
        /// <b>TRAG - Transfer Agent</b>.
        /// </summary>
        TRAG,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
        
        /// <summary>
        /// <b>CONC - Concentrator</b>.
        /// </summary>
        CONC,
        
        /// <summary>
        /// <b>UCL1 - Underlying Client 1</b>.
        /// </summary>
        UCL1,
        
        /// <summary>
        /// <b>UCL2 - Underlying Client 2</b>.
        /// </summary>
        UCL2,
        
        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,
    }
    
    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType
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
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Class <b>SwitchOrder4</b> (Switch Order 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class SwitchOrder4
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>OrdrDtTm</b> (Order Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime OrdrDtTm;
        
        /// <summary>
        /// Element <b>OrdrDtTmSpecified</b> (Order Date Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdrDtTmSpecified;
        
        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string OrdrRef;
        
        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string ClntRef;
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount21.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public InvestmentAccount21 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>TtlRedAmt</b> (Total Redemption Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public ActiveOrHistoricCurrencyAndAmount TtlRedAmt;
        
        /// <summary>
        /// Element <b>TtlSbcptAmt</b> (Total Subscription Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public ActiveOrHistoricCurrencyAndAmount TtlSbcptAmt;
        
        /// <summary>
        /// Element <b>ReqdFutrTradDt</b> (Requested Future Trade Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime ReqdFutrTradDt;
        
        /// <summary>
        /// Element <b>ReqdFutrTradDtSpecified</b> (Requested Future Trade Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReqdFutrTradDtSpecified;
        
        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public ActiveCurrencyAndAmount SttlmAmt;
        
        /// <summary>
        /// Element <b>CshSttlmDt</b> (Cash Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=9)]
        public System.DateTime CshSttlmDt;
        
        /// <summary>
        /// Element <b>CshSttlmDtSpecified</b> (Cash Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CshSttlmDtSpecified;
        
        /// <summary>
        /// Element <b>SttlmMtd</b> (Settlement Method) of type DeliveryReceiptType2Code.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public DeliveryReceiptType2Code SttlmMtd;
        
        /// <summary>
        /// Element <b>SttlmMtdSpecified</b> (Settlement Method Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmMtdSpecified;
        
        /// <summary>
        /// Element <b>XpryDtTm</b> (Expiry Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public DateAndDateTimeChoice XpryDtTm;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute("AddtlCshIn", typeof(ActiveOrHistoricCurrencyAndAmount), Order=12)]
        [XmlElementAttribute("RsltgCshOut", typeof(ActiveOrHistoricCurrencyAndAmount), Order=12)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ActiveOrHistoricCurrencyAndAmount Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
        
        /// <summary>
        /// Element <b>RltdPtyDtls</b> (Related Party Details) of type array of Intermediary8.
        /// </summary>
        [XmlElementAttribute("RltdPtyDtls", Order=14)]
        public Intermediary8[] RltdPtyDtls;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// CxlRght (Cancellation Right) of type CancellationRight1Code 
        /// XtndedCxlRght (Extended Cancellation Right) of type string 
        /// </summary>
        [XmlElementAttribute("CxlRght", typeof(CancellationRight1Code), Order=15)]
        [XmlElementAttribute("XtndedCxlRght", typeof(string), Order=15)]
        public object Item1;
        
        /// <summary>
        /// Element <b>RedLegDtls</b> (Redemption Leg Details) of type array of SwitchRedemptionLegOrder3.
        /// </summary>
        [XmlElementAttribute("RedLegDtls", Order=16)]
        public SwitchRedemptionLegOrder3[] RedLegDtls;
        
        /// <summary>
        /// Element <b>SbcptLegDtls</b> (Subscription Leg Details) of type array of SwitchSubscriptionLegOrder3.
        /// </summary>
        [XmlElementAttribute("SbcptLegDtls", Order=17)]
        public SwitchSubscriptionLegOrder3[] SbcptLegDtls;
        
        /// <summary>
        /// Element <b>CshSttlmDtls</b> (Cash Settlement Details) of type PaymentTransaction25.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public PaymentTransaction25 CshSttlmDtls;
        
        /// <summary>
        /// Element <b>FXDtls</b> (ForeignExchange Details) of type ForeignExchangeTerms6.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public ForeignExchangeTerms6 FXDtls;
        
        /// <summary>
        /// Element <b>FinAdvc</b> (Financial Advice) of type FinancialAdvice1Code.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public FinancialAdvice1Code FinAdvc;
        
        /// <summary>
        /// Element <b>FinAdvcSpecified</b> (Financial Advice Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinAdvcSpecified;
        
        /// <summary>
        /// Element <b>NgtdTrad</b> (Negotiated Trade) of type NegotiatedTrade1Code.
        /// </summary>
        [XmlElementAttribute(Order=21)]
        public NegotiatedTrade1Code NgtdTrad;
        
        /// <summary>
        /// Element <b>NgtdTradSpecified</b> (Negotiated Trade Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NgtdTradSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>DeliveryReceiptType2Code</b> (Delivery Receipt Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType1
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
    /// Enumeration <b>CancellationRight1Code</b> (Cancellation Right 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum CancellationRight1Code
    {
        
        /// <summary>
        /// <b>VALI - Entitled</b>.
        /// </summary>
        VALI,
        
        /// <summary>
        /// <b>NOXO - Execution Only</b>.
        /// </summary>
        NOXO,
        
        /// <summary>
        /// <b>NOWA - Waiver Agreement</b>.
        /// </summary>
        NOWA,
        
        /// <summary>
        /// <b>NOIN - Institutional</b>.
        /// </summary>
        NOIN,
    }
    
    /// <summary>
    /// Enumeration <b>FinancialAdvice1Code</b> (Financial Advice 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum FinancialAdvice1Code
    {
        
        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,
        
        /// <summary>
        /// <b>NREC - Not Received</b>.
        /// </summary>
        NREC,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }
    
    /// <summary>
    /// Enumeration <b>NegotiatedTrade1Code</b> (Negotiated Trade 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public enum NegotiatedTrade1Code
    {
        
        /// <summary>
        /// <b>NEGO - Negotiated</b>.
        /// </summary>
        NEGO,
        
        /// <summary>
        /// <b>NNGO - Not Negotiated</b>.
        /// </summary>
        NNGO,
        
        /// <summary>
        /// <b>UNKW - Unknown</b>.
        /// </summary>
        UNKW,
    }
    
    /// <summary>
    /// Class <b>Pagination</b> (Pagination).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
    public class Pagination
    {
        
        /// <summary>
        /// Element <b>PgNb</b> (Page Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PgNb;
        
        /// <summary>
        /// Element <b>LastPgInd</b> (Last Page Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool LastPgInd;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.013.001.03")]
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
}
