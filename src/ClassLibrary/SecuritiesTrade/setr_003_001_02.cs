
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



namespace i20022.setr00300102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id setr.003.001.02 name RedemptionBulkOrderConfirmationV02 from Securities Trade business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>setr00300102</b> (setr 00300102) of type setr00300102.
        /// </summary>
        [XmlElementAttribute("setr.003.001.02", Order=0)]
        public setr00300102 setr00300102;
    }
    
    /// <summary>
    /// Class <b>setr00300102</b> (setr 00300102).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="setr.003.001.02", Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class setr00300102
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AdditionalReference3 MstrRef;
        
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
        /// Element <b>RltdRef</b> (Related Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public AdditionalReference3 RltdRef;
        
        /// <summary>
        /// Element <b>BlkExctnDtls</b> (Bulk Execution Details) of type RedemptionBulkExecution2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public RedemptionBulkExecution2 BlkExctnDtls;
        
        /// <summary>
        /// Element <b>IntrmyDtls</b> (Intermediary Details) of type array of Intermediary4.
        /// </summary>
        [XmlElementAttribute("IntrmyDtls", Order=5)]
        public Intermediary4[] IntrmyDtls;
        
        /// <summary>
        /// Element <b>CpyDtls</b> (Copy Details) of type CopyInformation1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CopyInformation1 CpyDtls;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=7)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>CopyInformation1</b> (Copy Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class CopyInformation1
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
    /// Class <b>Account2</b> (Account 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class Account2
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
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>Intermediary4</b> (Intermediary 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class Intermediary4
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice Id;
        
        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Account2 Acct;
        
        /// <summary>
        /// Element <b>Role</b> (Role) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Role;
    }
    
    /// <summary>
    /// Class <b>CashAccountType1</b> (Cash Account Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class CashAccountType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type FundCashAccount1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FundCashAccount1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>FundCashAccount1Code</b> (Fund Cash Account 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum FundCashAccount1Code
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
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount15</b> (Investment Account 15).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class InvestmentAccount15
    {
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccountType1 Tp;
    }
    
    /// <summary>
    /// Class <b>Cheque3</b> (Cheque 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType5.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType5</b> (Item Choice Type 5).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType5
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
    /// Class <b>Debtor2</b> (Debtor 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class Debtor2
    {
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice Dbtr;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentificationAndName3 AcctId;
        
        /// <summary>
        /// Element <b>FrstAgt</b> (First Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstitutionIdentification3Choice FrstAgt;
    }
    
    /// <summary>
    /// Class <b>AccountIdentificationAndName3</b> (Account Identification And Name 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType4
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
    /// Class <b>Creditor2</b> (Creditor 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class Creditor2
    {
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice Cdtr;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentificationAndName3 AcctId;
        
        /// <summary>
        /// Element <b>FnlAgt</b> (Final Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstitutionIdentification3Choice FnlAgt;
    }
    
    /// <summary>
    /// Class <b>CreditTransfer3</b> (Credit Transfer 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class CreditTransfer3
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>CdtrDtls</b> (Creditor Details) of type Creditor2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Creditor2 CdtrDtls;
        
        /// <summary>
        /// Element <b>DbtrDtls</b> (Debtor Details) of type Debtor2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Debtor2 DbtrDtls;
    }
    
    /// <summary>
    /// Class <b>PaymentInstrument7Choice</b> (Payment Instrument 7Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class PaymentInstrument7Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AcctDtls (Account Details) of type InvestmentAccount15 
        /// CdtTrfDtls (Credit Transfer Details) of type CreditTransfer3 
        /// ChqDtls (Cheque Details) of type Cheque3 
        /// </summary>
        [XmlElementAttribute("AcctDtls", typeof(InvestmentAccount15), Order=0)]
        [XmlElementAttribute("CdtTrfDtls", typeof(CreditTransfer3), Order=0)]
        [XmlElementAttribute("ChqDtls", typeof(Cheque3), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PaymentTransaction18</b> (Payment Transaction 18).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class PaymentTransaction18
    {
        
        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount SttlmAmt;
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SttlmDtSpecified</b> (Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmDtSpecified;
        
        /// <summary>
        /// Element <b>PmtInstrm</b> (Payment Instrument) of type PaymentInstrument7Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PaymentInstrument7Choice PmtInstrm;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>NameAndAddress4</b> (Name And Address 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>DeliveryParameters3</b> (Delivery Parameters 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>DeliveringPartiesAndAccount3</b> (Delivering Parties And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>PartyIdentificationAndAccount3</b> (Party Identification And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>ReceivingPartiesAndAccount3</b> (Receiving Parties And Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>FundSettlementParameters3</b> (Fund Settlement Parameters 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>EUCapitalGain1</b> (EU Capital Gain 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class EUCapitalGain1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type EUCapitalGain1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public EUCapitalGain1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>EUCapitalGain1Code</b> (EU Capital Gain 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum EUCapitalGain1Code
    {
        
        /// <summary>
        /// <b>EUSI - Capital Gain In Scope</b>.
        /// </summary>
        EUSI,
        
        /// <summary>
        /// <b>EUSO - Capital Gain Out Scope</b>.
        /// </summary>
        EUSO,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>TaxCalculationInformation3</b> (Tax Calculation Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TaxCalculationInformation3
    {
        
        /// <summary>
        /// Element <b>Bsis</b> (Basis) of type TaxationBasis1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxationBasis1 Bsis;
        
        /// <summary>
        /// Element <b>EUCptlGn</b> (EU Capital Gain) of type EUCapitalGain1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public EUCapitalGain1 EUCptlGn;
        
        /// <summary>
        /// Element <b>TaxblAmt</b> (Taxable Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAnd13DecimalAmount TaxblAmt;
    }
    
    /// <summary>
    /// Class <b>TaxationBasis1</b> (Taxation Basis 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TaxationBasis1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TaxationBasis3Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxationBasis3Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TaxationBasis3Code</b> (Taxation Basis 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum TaxationBasis3Code
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
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>TaxExemptionReason1</b> (Tax Exemption Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TaxExemptionReason1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TaxExemptReason2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxExemptReason2Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TaxExemptReason2Code</b> (Tax Exempt Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum TaxExemptReason2Code
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
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>TaxType2</b> (Tax Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TaxType2
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TaxType5Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxType5Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType5Code</b> (Tax Type 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum TaxType5Code
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
        /// <b>EUTR - EUTax Retention</b>.
        /// </summary>
        EUTR,
        
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
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>Tax7</b> (Tax 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class Tax7
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type TaxType2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxType2 Tp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
        
        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal Rate;
        
        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateSpecified;
        
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
        /// Element <b>XmptnRsn</b> (Exemption Reason) of type TaxExemptionReason1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public TaxExemptionReason1 XmptnRsn;
        
        /// <summary>
        /// Element <b>TaxClctnDtls</b> (Tax Calculation Details) of type TaxCalculationInformation3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public TaxCalculationInformation3 TaxClctnDtls;
    }
    
    /// <summary>
    /// Class <b>TotalTaxes2</b> (Total Taxes 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TotalTaxes2
    {
        
        /// <summary>
        /// Element <b>TtlAmtOfTaxs</b> (Total Amount Of Taxes) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount TtlAmtOfTaxs;
        
        /// <summary>
        /// Element <b>TaxDtls</b> (Tax Details) of type array of Tax7.
        /// </summary>
        [XmlElementAttribute("TaxDtls", Order=1)]
        public Tax7[] TaxDtls;
    }
    
    /// <summary>
    /// Class <b>WaivingType1</b> (Waiving Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class WaivingType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type WaivingInstruction2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public WaivingInstruction2Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>WaivingInstruction2Code</b> (Waiving Instruction 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum WaivingInstruction2Code
    {
        
        /// <summary>
        /// <b>WICA - Waive In Cash</b>.
        /// </summary>
        WICA,
        
        /// <summary>
        /// <b>WIUN - Waive In Units</b>.
        /// </summary>
        WIUN,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>CommissionWaiver2</b> (Commission Waiver 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class CommissionWaiver2
    {
        
        /// <summary>
        /// Element <b>InstrBsis</b> (Instruction Basis) of type WaivingType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public WaivingType1 InstrBsis;
        
        /// <summary>
        /// Element <b>WvdRate</b> (Waived Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal WvdRate;
    }
    
    /// <summary>
    /// Class <b>CommissionType1</b> (Commission Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>Commission6</b> (Commission 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class Commission6
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CommissionType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CommissionType1 Tp;
        
        /// <summary>
        /// Element <b>Bsis</b> (Basis) of type TaxationBasis1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TaxationBasis1 Bsis;
        
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
        /// Element <b>WvgDtls</b> (Waiving Details) of type CommissionWaiver2.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CommissionWaiver2 WvgDtls;
    }
    
    /// <summary>
    /// Class <b>TotalCommissions2</b> (Total Commissions 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TotalCommissions2
    {
        
        /// <summary>
        /// Element <b>TtlAmtOfComssns</b> (Total Amount Of Commissions) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount TtlAmtOfComssns;
        
        /// <summary>
        /// Element <b>ComssnDtls</b> (Commission Details) of type array of Commission6.
        /// </summary>
        [XmlElementAttribute("ComssnDtls", Order=1)]
        public Commission6[] ComssnDtls;
    }
    
    /// <summary>
    /// Class <b>ChargeType1</b> (Charge Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>Charge10</b> (Charge 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class Charge10
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ChargeType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ChargeType1 Tp;
        
        /// <summary>
        /// Element <b>ChrgBsis</b> (Charge Basis) of type TaxationBasis1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TaxationBasis1 ChrgBsis;
        
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
    }
    
    /// <summary>
    /// Class <b>TotalCharges2</b> (Total Charges 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TotalCharges2
    {
        
        /// <summary>
        /// Element <b>TtlAmtOfChrgs</b> (Total Amount Of Charges) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount TtlAmtOfChrgs;
        
        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge10.
        /// </summary>
        [XmlElementAttribute("ChrgDtls", Order=1)]
        public Charge10[] ChrgDtls;
    }
    
    /// <summary>
    /// Class <b>ForeignExchangeTerms4</b> (Foreign Exchange Terms 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class ForeignExchangeTerms4
    {
        
        /// <summary>
        /// Element <b>BuyAmt</b> (Buy Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount BuyAmt;
        
        /// <summary>
        /// Element <b>SellAmt</b> (Sell Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount SellAmt;
        
        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string UnitCcy;
        
        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string QtdCcy;
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public decimal XchgRate;
        
        /// <summary>
        /// Element <b>QtnDt</b> (Quotation Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public System.DateTime QtnDt;
        
        /// <summary>
        /// Element <b>QtnDtSpecified</b> (Quotation Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtnDtSpecified;
        
        /// <summary>
        /// Element <b>QtgInstn</b> (Quoting Institution) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification2Choice QtgInstn;
    }
    
    /// <summary>
    /// Class <b>ProfitAndLoss1Choice</b> (Profit And Loss 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class ProfitAndLoss1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute("Loss", typeof(ActiveCurrencyAnd13DecimalAmount), Order=0)]
        [XmlElementAttribute("Prft", typeof(ActiveCurrencyAnd13DecimalAmount), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ActiveCurrencyAnd13DecimalAmount Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>Loss - Loss</b>.
        /// </summary>
        Loss,
        
        /// <summary>
        /// <b>Prft - Profit</b>.
        /// </summary>
        Prft,
    }
    
    /// <summary>
    /// Class <b>TaxableIncomePerShareCalculated1</b> (Taxable Income Per Share Calculated 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class TaxableIncomePerShareCalculated1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TaxableIncomePerShareCalculated1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxableIncomePerShareCalculated1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TaxableIncomePerShareCalculated1Code</b> (Taxable Income Per Share Calculated 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum TaxableIncomePerShareCalculated1Code
    {
        
        /// <summary>
        /// <b>TSIY - Fund Calculates</b>.
        /// </summary>
        TSIY,
        
        /// <summary>
        /// <b>TSIN - Fund Does Not Calculate</b>.
        /// </summary>
        TSIN,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>UnitPrice4</b> (Unit Price 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class UnitPrice4
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type TypeOfPrice8Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TypeOfPrice8Code Tp;
        
        /// <summary>
        /// Element <b>Val</b> (Value) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceValue1 Val;
    }
    
    /// <summary>
    /// Enumeration <b>TypeOfPrice8Code</b> (Type Of Price 8Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum TypeOfPrice8Code
    {
        
        /// <summary>
        /// <b>ACTU - Actual</b>.
        /// </summary>
        ACTU,
    }
    
    /// <summary>
    /// Class <b>PriceValue1</b> (Price Value 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class PriceValue1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>AmountPrice1Choice</b> (Amount Price 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class AmountPrice1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// UnitPric (Unit Price) of type UnitPrice4 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("UnitPric", typeof(UnitPrice4), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PriceType1</b> (Price Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class PriceType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TypeOfPrice7Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TypeOfPrice7Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TypeOfPrice7Code</b> (Type Of Price 7Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum TypeOfPrice7Code
    {
        
        /// <summary>
        /// <b>BIDE - Bid</b>.
        /// </summary>
        BIDE,
        
        /// <summary>
        /// <b>OFFR - Offer / Proposed Rate</b>.
        /// </summary>
        OFFR,
        
        /// <summary>
        /// <b>NAVL - Net Asset Value</b>.
        /// </summary>
        NAVL,
        
        /// <summary>
        /// <b>CREA - Creation</b>.
        /// </summary>
        CREA,
        
        /// <summary>
        /// <b>CANC - Request To Cancel</b>.
        /// </summary>
        CANC,
        
        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,
        
        /// <summary>
        /// <b>SWNG - Swing</b>.
        /// </summary>
        SWNG,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>MIDD - Mid</b>.
        /// </summary>
        MIDD,
        
        /// <summary>
        /// <b>RINV - Reinvestment</b>.
        /// </summary>
        RINV,
        
        /// <summary>
        /// <b>SWIC - Switch</b>.
        /// </summary>
        SWIC,
        
        /// <summary>
        /// <b>DDVR - Daily Dividend Rate</b>.
        /// </summary>
        DDVR,
        
        /// <summary>
        /// <b>ACTU - Actual</b>.
        /// </summary>
        ACTU,
    }
    
    /// <summary>
    /// Class <b>UnitPrice5</b> (Unit Price 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class UnitPrice5
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type PriceType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PriceType1 Tp;
        
        /// <summary>
        /// Element <b>Val</b> (Value) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceValue1 Val;
        
        /// <summary>
        /// Element <b>PricMtd</b> (Price Method) of type PriceMethod1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PriceMethod1Code PricMtd;
        
        /// <summary>
        /// Element <b>PricMtdSpecified</b> (Price Method Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricMtdSpecified;
        
        /// <summary>
        /// Element <b>NbOfDaysAcrd</b> (Number Of Days Accrued) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public decimal NbOfDaysAcrd;
        
        /// <summary>
        /// Element <b>NbOfDaysAcrdSpecified</b> (Number Of Days Accrued Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NbOfDaysAcrdSpecified;
        
        /// <summary>
        /// Element <b>TaxblIncmPerShr</b> (Taxable Income Per Share) of type AmountPrice1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public AmountPrice1Choice TaxblIncmPerShr;
        
        /// <summary>
        /// Element <b>TaxblIncmPerShrClctd</b> (Taxable Income Per Share Calculated) of type TaxableIncomePerShareCalculated1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public TaxableIncomePerShareCalculated1 TaxblIncmPerShrClctd;
    }
    
    /// <summary>
    /// Enumeration <b>PriceMethod1Code</b> (Price Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum PriceMethod1Code
    {
        
        /// <summary>
        /// <b>FORW - Forward Price</b>.
        /// </summary>
        FORW,
        
        /// <summary>
        /// <b>HIST - Historical Price</b>.
        /// </summary>
        HIST,
    }
    
    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Class <b>IdentificationType1</b> (Identification Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class IdentificationType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type PersonIdentificationType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PersonIdentificationType1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>PersonIdentificationType1Code</b> (Person Identification Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum PersonIdentificationType1Code
    {
        
        /// <summary>
        /// <b>PASS - Passport</b>.
        /// </summary>
        PASS,
        
        /// <summary>
        /// <b>CPFA - CPFAccount Number</b>.
        /// </summary>
        CPFA,
        
        /// <summary>
        /// <b>SRSA - Retirement Scheme</b>.
        /// </summary>
        SRSA,
        
        /// <summary>
        /// <b>NRIN - National Registration Identification Number</b>.
        /// </summary>
        NRIN,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>DRLC - Drivers License Number</b>.
        /// </summary>
        DRLC,
        
        /// <summary>
        /// <b>SOCS - Social Security Number</b>.
        /// </summary>
        SOCS,
        
        /// <summary>
        /// <b>AREG - Alien Registration Number</b>.
        /// </summary>
        AREG,
        
        /// <summary>
        /// <b>IDCD - Identity Card Number</b>.
        /// </summary>
        IDCD,
        
        /// <summary>
        /// <b>EMID - Employer Identification Number</b>.
        /// </summary>
        EMID,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification8</b> (Generic Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class GenericIdentification8
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type IdentificationType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public IdentificationType1 IdTp;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>CountryAndResidentialStatusType1</b> (Country And Residential Status Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class CountryAndResidentialStatusType1
    {
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ctry;
        
        /// <summary>
        /// Element <b>ResdtlSts</b> (Residential Status) of type ResidentialStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ResidentialStatus1Code ResdtlSts;
    }
    
    /// <summary>
    /// Enumeration <b>ResidentialStatus1Code</b> (Residential Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum ResidentialStatus1Code
    {
        
        /// <summary>
        /// <b>RESI - Resident</b>.
        /// </summary>
        RESI,
        
        /// <summary>
        /// <b>PRES - Permanent Resident</b>.
        /// </summary>
        PRES,
        
        /// <summary>
        /// <b>NRES - Non Resident</b>.
        /// </summary>
        NRES,
    }
    
    /// <summary>
    /// Class <b>IndividualPerson2</b> (Individual Person 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class IndividualPerson2
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime BirthDt;
        
        /// <summary>
        /// Element <b>BirthDtSpecified</b> (Birth Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDtSpecified;
        
        /// <summary>
        /// Element <b>CtryAndResdtlSts</b> (Country And Residential Status) of type CountryAndResidentialStatusType1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CountryAndResidentialStatusType1 CtryAndResdtlSts;
        
        /// <summary>
        /// Element <b>OthrId</b> (Other Identification) of type array of GenericIdentification8.
        /// </summary>
        [XmlElementAttribute("OthrId", Order=3)]
        public GenericIdentification8[] OthrId;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount13</b> (Investment Account 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>FundOrderType1</b> (Fund Order Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class FundOrderType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type FundOrderType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FundOrderType2Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>FundOrderType2Code</b> (Fund Order Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum FundOrderType2Code
    {
        
        /// <summary>
        /// <b>BEDB - Bed And Breakfast</b>.
        /// </summary>
        BEDB,
        
        /// <summary>
        /// <b>INVP - Investment Plan</b>.
        /// </summary>
        INVP,
        
        /// <summary>
        /// <b>PREA - Pre Advice</b>.
        /// </summary>
        PREA,
        
        /// <summary>
        /// <b>STAF - Staff Order</b>.
        /// </summary>
        STAF,
        
        /// <summary>
        /// <b>RGSV - Regular Savings Plan</b>.
        /// </summary>
        RGSV,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>RedemptionExecution3</b> (Redemption Execution 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class RedemptionExecution3
    {
        
        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string OrdrRef;
        
        /// <summary>
        /// Element <b>DealRef</b> (Deal Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string DealRef;
        
        /// <summary>
        /// Element <b>OrdrTp</b> (Order Type) of type array of FundOrderType1.
        /// </summary>
        [XmlElementAttribute("OrdrTp", Order=2)]
        public FundOrderType1[] OrdrTp;
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount13.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentAccount13 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>BnfcryDtls</b> (Beneficiary Details) of type IndividualPerson2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public IndividualPerson2 BnfcryDtls;
        
        /// <summary>
        /// Element <b>UnitsNb</b> (Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstrumentQuantity1 UnitsNb;
        
        /// <summary>
        /// Element <b>Rndg</b> (Rounding) of type RoundingDirection2Code.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public RoundingDirection2Code Rndg;
        
        /// <summary>
        /// Element <b>RndgSpecified</b> (Rounding Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RndgSpecified;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public ActiveCurrencyAndAmount NetAmt;
        
        /// <summary>
        /// Element <b>HldgsRedRate</b> (Holdings Redemption Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public decimal HldgsRedRate;
        
        /// <summary>
        /// Element <b>HldgsRedRateSpecified</b> (Holdings Redemption Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HldgsRedRateSpecified;
        
        /// <summary>
        /// Element <b>GrssAmt</b> (Gross Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public ActiveCurrencyAndAmount GrssAmt;
        
        /// <summary>
        /// Element <b>TradDtTm</b> (Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public DateAndDateTimeChoice TradDtTm;
        
        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type UnitPrice5.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public UnitPrice5 PricDtls;
        
        /// <summary>
        /// Element <b>PrtlyExctdInd</b> (Partially Executed Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public bool PrtlyExctdInd;
        
        /// <summary>
        /// Element <b>CumDvddInd</b> (Cum Dividend Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public bool CumDvddInd;
        
        /// <summary>
        /// Element <b>IntrmPrftAmt</b> (Interim Profit Amount) of type ProfitAndLoss1Choice.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public ProfitAndLoss1Choice IntrmPrftAmt;
        
        /// <summary>
        /// Element <b>FXDtls</b> (ForeignExchange Details) of type array of ForeignExchangeTerms4.
        /// </summary>
        [XmlElementAttribute("FXDtls", Order=15)]
        public ForeignExchangeTerms4[] FXDtls;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>Grp1Or2Units</b> (Group 1Or 2Units) of type UKTaxGroupUnitCode.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public UKTaxGroupUnitCode Grp1Or2Units;
        
        /// <summary>
        /// Element <b>Grp1Or2UnitsSpecified</b> (Group 1Or 2Units Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Grp1Or2UnitsSpecified;
        
        /// <summary>
        /// Element <b>ChrgGnlDtls</b> (Charge General Details) of type TotalCharges2.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public TotalCharges2 ChrgGnlDtls;
        
        /// <summary>
        /// Element <b>ComssnGnlDtls</b> (Commission General Details) of type TotalCommissions2.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public TotalCommissions2 ComssnGnlDtls;
        
        /// <summary>
        /// Element <b>TaxGnlDtls</b> (Tax General Details) of type TotalTaxes2.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public TotalTaxes2 TaxGnlDtls;
        
        /// <summary>
        /// Element <b>SttlmAndCtdyDtls</b> (Settlement And Custody Details) of type FundSettlementParameters3.
        /// </summary>
        [XmlElementAttribute(Order=21)]
        public FundSettlementParameters3 SttlmAndCtdyDtls;
        
        /// <summary>
        /// Element <b>PhysDlvryInd</b> (Physical Delivery Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=22)]
        public bool PhysDlvryInd;
        
        /// <summary>
        /// Element <b>PhysDlvryDtls</b> (Physical Delivery Details) of type DeliveryParameters3.
        /// </summary>
        [XmlElementAttribute(Order=23)]
        public DeliveryParameters3 PhysDlvryDtls;
        
        /// <summary>
        /// Element <b>CshSttlmDtls</b> (Cash Settlement Details) of type PaymentTransaction18.
        /// </summary>
        [XmlElementAttribute(Order=24)]
        public PaymentTransaction18 CshSttlmDtls;
    }
    
    /// <summary>
    /// Enumeration <b>RoundingDirection2Code</b> (Rounding Direction 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum RoundingDirection2Code
    {
        
        /// <summary>
        /// <b>RDUP - Round Up</b>.
        /// </summary>
        RDUP,
        
        /// <summary>
        /// <b>RDWN - Round Down</b>.
        /// </summary>
        RDWN,
    }
    
    /// <summary>
    /// Enumeration <b>IncomePreference1Code</b> (Income Preference 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Enumeration <b>UKTaxGroupUnitCode</b> (UK Tax Group Unit Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
    /// Class <b>CancellationRight1</b> (Cancellation Right 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class CancellationRight1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type CancellationRight2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationRight2Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CancellationRight2Code</b> (Cancellation Right 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public enum CancellationRight2Code
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
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>RedemptionBulkExecution2</b> (Redemption Bulk Execution 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
    public class RedemptionBulkExecution2
    {
        
        /// <summary>
        /// Element <b>PlcOfTrad</b> (Place Of Trade) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PlcOfTrad;
        
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
        /// Element <b>CxlRght</b> (Cancellation Right) of type CancellationRight1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CancellationRight1 CxlRght;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument6.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public FinancialInstrument6 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>IndvExctnDtls</b> (Individual Execution Details) of type array of RedemptionExecution3.
        /// </summary>
        [XmlElementAttribute("IndvExctnDtls", Order=4)]
        public RedemptionExecution3[] IndvExctnDtls;
        
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
        /// Element <b>BlkCshSttlmDtls</b> (Bulk Cash Settlement Details) of type PaymentTransaction18.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PaymentTransaction18 BlkCshSttlmDtls;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.003.001.02")]
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
}
