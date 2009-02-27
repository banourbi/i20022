
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



namespace i20022.tsin00100101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsin.001.001.01 name InvoiceFinancingRequestV01 from Trade Services Initiation business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>InvcFincgReq</b> (Invoice Financing Request) of type InvoiceFinancingRequestV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvoiceFinancingRequestV01 InvcFincgReq;
    }
    
    /// <summary>
    /// Class <b>InvoiceFinancingRequestV01</b> (Invoice Financing Request V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class InvoiceFinancingRequestV01
    {
        
        /// <summary>
        /// Element <b>ReqGrpInf</b> (Request Group Information) of type RequestGroupInformation1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RequestGroupInformation1 ReqGrpInf;
        
        /// <summary>
        /// Element <b>InvcReqInf</b> (Invoice Request Information) of type array of InvoiceRequestInformation1.
        /// </summary>
        [XmlElementAttribute("InvcReqInf", Order=1)]
        public InvoiceRequestInformation1[] InvcReqInf;
    }
    
    /// <summary>
    /// Class <b>RequestGroupInformation1</b> (Request Group Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class RequestGroupInformation1
    {
        
        /// <summary>
        /// Element <b>GrpId</b> (Group Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string GrpId;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime CreDtTm;
        
        /// <summary>
        /// Element <b>Authstn</b> (Authorisation) of type array of string.
        /// </summary>
        [XmlElementAttribute("Authstn", Order=2)]
        public string[] Authstn;
        
        /// <summary>
        /// Element <b>NbOfInvcReqs</b> (Number Of Invoice Requests) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string NbOfInvcReqs;
        
        /// <summary>
        /// Element <b>TtlBlkInvcAmt</b> (Total Bulk Invoice Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ActiveCurrencyAndAmount TtlBlkInvcAmt;
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string Ccy;
        
        /// <summary>
        /// Element <b>FincgAgrmt</b> (Financing Agreement) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string FincgAgrmt;
        
        /// <summary>
        /// Element <b>FincgRqstr</b> (Financing Requestor) of type PartyIdentificationAndAccount6.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentificationAndAccount6 FincgRqstr;
        
        /// <summary>
        /// Element <b>IntrmyAgt</b> (Intermediary Agent) of type FinancialInstitutionIdentification6.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public FinancialInstitutionIdentification6 IntrmyAgt;
        
        /// <summary>
        /// Element <b>FrstAgt</b> (First Agent) of type FinancialInstitutionIdentification6.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public FinancialInstitutionIdentification6 FrstAgt;
        
        /// <summary>
        /// Element <b>AgrmtClauses</b> (Agreement Clauses) of type array of AgreementClauses1.
        /// </summary>
        [XmlElementAttribute("AgrmtClauses", Order=10)]
        public AgreementClauses1[] AgrmtClauses;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type array of AdditionalInformation1.
        /// </summary>
        [XmlElementAttribute("AddtlInf", Order=11)]
        public AdditionalInformation1[] AddtlInf;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    /// Class <b>ReferredDocumentType1</b> (Referred Document Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class ReferredDocumentType1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type DocumentType2Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(DocumentType2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
    }
    
    /// <summary>
    /// Enumeration <b>DocumentType2Code</b> (Document Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public enum DocumentType2Code
    {
        
        /// <summary>
        /// <b>MSIN - Metered Service Invoice</b>.
        /// </summary>
        MSIN,
        
        /// <summary>
        /// <b>CNFA - Credit Note Related To Financial Adjustment</b>.
        /// </summary>
        CNFA,
        
        /// <summary>
        /// <b>DNFA - Debit Note Related To Financial Adjustment</b>.
        /// </summary>
        DNFA,
        
        /// <summary>
        /// <b>CINV - Commercial Invoice</b>.
        /// </summary>
        CINV,
        
        /// <summary>
        /// <b>CREN - Credit Note</b>.
        /// </summary>
        CREN,
        
        /// <summary>
        /// <b>DEBN - Debit Note</b>.
        /// </summary>
        DEBN,
        
        /// <summary>
        /// <b>HIRI - Hire Invoice</b>.
        /// </summary>
        HIRI,
        
        /// <summary>
        /// <b>SBIN - Self Billed Invoice</b>.
        /// </summary>
        SBIN,
        
        /// <summary>
        /// <b>CMCN - Commercial Contract</b>.
        /// </summary>
        CMCN,
        
        /// <summary>
        /// <b>SOAC - Statement Of Account</b>.
        /// </summary>
        SOAC,
        
        /// <summary>
        /// <b>DISP - Dispatch Advice</b>.
        /// </summary>
        DISP,
    }
    
    /// <summary>
    /// Class <b>ReferredDocumentInformation2</b> (Referred Document Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class ReferredDocumentInformation2
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ReferredDocumentType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ReferredDocumentType1 Tp;
        
        /// <summary>
        /// Element <b>DocNb</b> (Document Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string DocNb;
        
        /// <summary>
        /// Element <b>RltdDt</b> (Related Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime RltdDt;
        
        /// <summary>
        /// Element <b>RltdDtSpecified</b> (Related Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RltdDtSpecified;
        
        /// <summary>
        /// Element <b>DocAmt</b> (Document Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount DocAmt;
    }
    
    /// <summary>
    /// Class <b>PaymentInformation15</b> (Payment Information 15).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class PaymentInformation15
    {
        
        /// <summary>
        /// Element <b>PmtMtd</b> (Payment Method) of type PaymentMethod4Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PaymentMethod4Code PmtMtd;
        
        /// <summary>
        /// Element <b>PmtAcct</b> (Payment Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccount7 PmtAcct;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentMethod4Code</b> (Payment Method 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public enum PaymentMethod4Code
    {
        
        /// <summary>
        /// <b>CHK - Cheque</b>.
        /// </summary>
        CHK,
        
        /// <summary>
        /// <b>TRF - Credit Transfer</b>.
        /// </summary>
        TRF,
        
        /// <summary>
        /// <b>DD - Direct Debit</b>.
        /// </summary>
        DD,
        
        /// <summary>
        /// <b>TRA - Transfer Advice</b>.
        /// </summary>
        TRA,
    }
    
    /// <summary>
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    /// Class <b>AccountIdentification3Choice</b> (Account Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class SimpleIdentificationInformation2
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01", IncludeInSchema=false)]
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
    /// Class <b>CashAccountType2</b> (Cash Account Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    /// Class <b>PartyIdentificationAndContactInformation1</b> (Party Identification And Contact Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class PartyIdentificationAndContactInformation1
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification8 PtyId;
        
        /// <summary>
        /// Element <b>CtctInf</b> (Contact Information) of type ContactIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ContactIdentification1 CtctInf;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification8</b> (Party Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class PartyIdentification8
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 PstlAdr;
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type Party2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Party2Choice Id;
        
        /// <summary>
        /// Element <b>CtryOfRes</b> (Country Of Residence) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string CtryOfRes;
    }
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    /// Class <b>Party2Choice</b> (Party 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class Party2Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// OrgId (Organisation Identification) of type OrganisationIdentification2 
        /// PrvtId (Private Identification) of type PersonIdentification3 
        /// </summary>
        [XmlElementAttribute("OrgId", typeof(OrganisationIdentification2), Order=0)]
        [XmlElementAttribute("PrvtId", typeof(PersonIdentification3), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>OrganisationIdentification2</b> (Organisation Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class OrganisationIdentification2
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
        
        /// <summary>
        /// Element <b>IBEI</b> (IBEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IBEI;
        
        /// <summary>
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string BEI;
        
        /// <summary>
        /// Element <b>EANGLN</b> (EANGLN) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string EANGLN;
        
        /// <summary>
        /// Element <b>USCHU</b> (CHIPSUniversalIdentification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string USCHU;
        
        /// <summary>
        /// Element <b>DUNS</b> (DUNS) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string DUNS;
        
        /// <summary>
        /// Element <b>BkPtyId</b> (Bank Party Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string BkPtyId;
        
        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string TaxIdNb;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public GenericIdentification3 PrtryId;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class GenericIdentification3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>PersonIdentification3</b> (Person Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class PersonIdentification3
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AlnRegnNb (Alien Registration Number) of type string 
        /// CstmrNb (Customer Number) of type string 
        /// DrvrsLicNb (Drivers License Number) of type string 
        /// DtAndPlcOfBirth (Date And Place Of Birth) of type DateAndPlaceOfBirth 
        /// IdntyCardNb (Identity Card Number) of type string 
        /// MplyrIdNb (Employer Identification Number) of type string 
        /// OthrId (Other Identification) of type GenericIdentification4 
        /// PsptNb (Passport Number) of type string 
        /// SclSctyNb (Social Security Number) of type string 
        /// TaxIdNb (Tax Identification Number) of type string 
        /// </summary>
        [XmlElementAttribute("AlnRegnNb", typeof(string), Order=0)]
        [XmlElementAttribute("CstmrNb", typeof(string), Order=0)]
        [XmlElementAttribute("DrvrsLicNb", typeof(string), Order=0)]
        [XmlElementAttribute("DtAndPlcOfBirth", typeof(DateAndPlaceOfBirth), Order=0)]
        [XmlElementAttribute("IdntyCardNb", typeof(string), Order=0)]
        [XmlElementAttribute("MplyrIdNb", typeof(string), Order=0)]
        [XmlElementAttribute("OthrId", typeof(GenericIdentification4), Order=0)]
        [XmlElementAttribute("PsptNb", typeof(string), Order=0)]
        [XmlElementAttribute("SclSctyNb", typeof(string), Order=0)]
        [XmlElementAttribute("TaxIdNb", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>DateAndPlaceOfBirth</b> (Date And Place Of Birth).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class DateAndPlaceOfBirth
    {
        
        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime BirthDt;
        
        /// <summary>
        /// Element <b>PrvcOfBirth</b> (Province Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PrvcOfBirth;
        
        /// <summary>
        /// Element <b>CityOfBirth</b> (City Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CityOfBirth;
        
        /// <summary>
        /// Element <b>CtryOfBirth</b> (Country Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string CtryOfBirth;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>AlnRegnNb - Alien Registration Number</b>.
        /// </summary>
        AlnRegnNb,
        
        /// <summary>
        /// <b>CstmrNb - Customer Number</b>.
        /// </summary>
        CstmrNb,
        
        /// <summary>
        /// <b>DrvrsLicNb - Drivers License Number</b>.
        /// </summary>
        DrvrsLicNb,
        
        /// <summary>
        /// <b>DtAndPlcOfBirth - Date And Place Of Birth</b>.
        /// </summary>
        DtAndPlcOfBirth,
        
        /// <summary>
        /// <b>IdntyCardNb - Identity Card Number</b>.
        /// </summary>
        IdntyCardNb,
        
        /// <summary>
        /// <b>MplyrIdNb - Employer Identification Number</b>.
        /// </summary>
        MplyrIdNb,
        
        /// <summary>
        /// <b>OthrId - Other Identification</b>.
        /// </summary>
        OthrId,
        
        /// <summary>
        /// <b>PsptNb - Passport Number</b>.
        /// </summary>
        PsptNb,
        
        /// <summary>
        /// <b>SclSctyNb - Social Security Number</b>.
        /// </summary>
        SclSctyNb,
        
        /// <summary>
        /// <b>TaxIdNb - Tax Identification Number</b>.
        /// </summary>
        TaxIdNb,
    }
    
    /// <summary>
    /// Class <b>ContactIdentification1</b> (Contact Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class ContactIdentification1
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>NmPrfx</b> (Name Prefix) of type NamePrefix1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public NamePrefix1Code NmPrfx;
        
        /// <summary>
        /// Element <b>NmPrfxSpecified</b> (Name Prefix Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NmPrfxSpecified;
        
        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string GvnNm;
        
        /// <summary>
        /// Element <b>Role</b> (Role) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Role;
        
        /// <summary>
        /// Element <b>PhneNb</b> (Phone Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string PhneNb;
        
        /// <summary>
        /// Element <b>FaxNb</b> (Fax Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string FaxNb;
        
        /// <summary>
        /// Element <b>EmailAdr</b> (Email Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string EmailAdr;
    }
    
    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public enum NamePrefix1Code
    {
        
        /// <summary>
        /// <b>DOCT - Doctor</b>.
        /// </summary>
        DOCT,
        
        /// <summary>
        /// <b>MIST - Mister</b>.
        /// </summary>
        MIST,
        
        /// <summary>
        /// <b>MISS - Miss</b>.
        /// </summary>
        MISS,
        
        /// <summary>
        /// <b>MADM - Madam</b>.
        /// </summary>
        MADM,
    }
    
    /// <summary>
    /// Class <b>PartyAndAccountIdentificationAndContactInformation1</b> (Party And Account Identification And Contact Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class PartyAndAccountIdentificationAndContactInformation1
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification8 PtyId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccount7 AcctId;
        
        /// <summary>
        /// Element <b>CtctInf</b> (Contact Information) of type ContactIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ContactIdentification1 CtctInf;
    }
    
    /// <summary>
    /// Class <b>FinancingRateOrAmountChoice</b> (Financing Rate Or Amount Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class FinancingRateOrAmountChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAndAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>Instalment1</b> (Instalment 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class Instalment1
    {
        
        /// <summary>
        /// Element <b>SeqId</b> (Sequence Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string SeqId;
        
        /// <summary>
        /// Element <b>PmtDueDt</b> (Payment Due Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime PmtDueDt;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Class <b>Adjustment5</b> (Adjustment 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class Adjustment5
    {
        
        /// <summary>
        /// Element <b>Drctn</b> (Direction) of type AdjustmentDirection1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AdjustmentDirection1Code Drctn;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Enumeration <b>AdjustmentDirection1Code</b> (Adjustment Direction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
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
    /// Class <b>InvoiceTotals1</b> (Invoice Totals 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class InvoiceTotals1
    {
        
        /// <summary>
        /// Element <b>TtlTaxblAmt</b> (Total Taxable Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount TtlTaxblAmt;
        
        /// <summary>
        /// Element <b>TtlTaxAmt</b> (Total Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount TtlTaxAmt;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type Adjustment5.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Adjustment5 Adjstmnt;
        
        /// <summary>
        /// Element <b>TtlInvcAmt</b> (Total Invoice Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount TtlInvcAmt;
        
        /// <summary>
        /// Element <b>PmtDueDt</b> (Payment Due Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime PmtDueDt;
    }
    
    /// <summary>
    /// Class <b>DocumentGeneralInformation1</b> (Document General Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class DocumentGeneralInformation1
    {
        
        /// <summary>
        /// Element <b>DocTp</b> (Document Type) of type DocumentType4Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentType4Code DocTp;
        
        /// <summary>
        /// Element <b>DocNb</b> (Document Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string DocNb;
        
        /// <summary>
        /// Element <b>SndrRcvrSeqId</b> (Sender Receiver Sequence Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string SndrRcvrSeqId;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime IsseDt;
        
        /// <summary>
        /// Element <b>URL</b> (URL) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string URL;
    }
    
    /// <summary>
    /// Enumeration <b>DocumentType4Code</b> (Document Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public enum DocumentType4Code
    {
        
        /// <summary>
        /// <b>CINV - Commercial Invoice</b>.
        /// </summary>
        CINV,
    }
    
    /// <summary>
    /// Class <b>InvoiceRequestInformation1</b> (Invoice Request Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class InvoiceRequestInformation1
    {
        
        /// <summary>
        /// Element <b>InvcGnlInf</b> (Invoice General Information) of type DocumentGeneralInformation1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentGeneralInformation1 InvcGnlInf;
        
        /// <summary>
        /// Element <b>InvcTtlsInf</b> (Invoice Totals Information) of type InvoiceTotals1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public InvoiceTotals1 InvcTtlsInf;
        
        /// <summary>
        /// Element <b>CdtDbtNoteAmt</b> (Credit Debit Note Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAndAmount CdtDbtNoteAmt;
        
        /// <summary>
        /// Element <b>InstlmtInf</b> (Instalment Information) of type array of Instalment1.
        /// </summary>
        [XmlElementAttribute("InstlmtInf", Order=3)]
        public Instalment1[] InstlmtInf;
        
        /// <summary>
        /// Element <b>ReqdAmt</b> (Requested Amount) of type FinancingRateOrAmountChoice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancingRateOrAmountChoice ReqdAmt;
        
        /// <summary>
        /// Element <b>Spplr</b> (Supplier) of type PartyAndAccountIdentificationAndContactInformation1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyAndAccountIdentificationAndContactInformation1 Spplr;
        
        /// <summary>
        /// Element <b>Buyr</b> (Buyer) of type PartyIdentificationAndContactInformation1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentificationAndContactInformation1 Buyr;
        
        /// <summary>
        /// Element <b>InvcPmtInf</b> (Invoice Payment Information) of type PaymentInformation15.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PaymentInformation15 InvcPmtInf;
        
        /// <summary>
        /// Element <b>RfrdDoc</b> (Referred Document) of type array of ReferredDocumentInformation2.
        /// </summary>
        [XmlElementAttribute("RfrdDoc", Order=8)]
        public ReferredDocumentInformation2[] RfrdDoc;
    }
    
    /// <summary>
    /// Class <b>InformationType1Choice</b> (Information Type 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class InformationType1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type InformationType1Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(InformationType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>InformationType1Code</b> (Information Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public enum InformationType1Code
    {
        
        /// <summary>
        /// <b>INST - Processing Instructions</b>.
        /// </summary>
        INST,
        
        /// <summary>
        /// <b>RELY - Relay Instructions</b>.
        /// </summary>
        RELY,
    }
    
    /// <summary>
    /// Class <b>AdditionalInformation1</b> (Additional Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class AdditionalInformation1
    {
        
        /// <summary>
        /// Element <b>InfTp</b> (Information Type) of type InformationType1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InformationType1Choice InfTp;
        
        /// <summary>
        /// Element <b>InfVal</b> (Information Value) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string InfVal;
    }
    
    /// <summary>
    /// Class <b>AgreementClauses1</b> (Agreement Clauses 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class AgreementClauses1
    {
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Desc;
        
        /// <summary>
        /// Element <b>DocURL</b> (Document URL) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string DocURL;
    }
    
    /// <summary>
    /// Class <b>ClearingSystemMemberIdentification2Choice</b> (Clearing System Member Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class ClearingSystemMemberIdentification2Choice
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
        [XmlElementAttribute("GRHEBIC", typeof(string), Order=0)]
        [XmlElementAttribute("HKNCC", typeof(string), Order=0)]
        [XmlElementAttribute("IENSC", typeof(string), Order=0)]
        [XmlElementAttribute("INIFSC", typeof(string), Order=0)]
        [XmlElementAttribute("ITNCC", typeof(string), Order=0)]
        [XmlElementAttribute("NZNCC", typeof(string), Order=0)]
        [XmlElementAttribute("OthrClrCdId", typeof(string), Order=0)]
        [XmlElementAttribute("PLKNR", typeof(string), Order=0)]
        [XmlElementAttribute("PTNCC", typeof(string), Order=0)]
        [XmlElementAttribute("RUCB", typeof(string), Order=0)]
        [XmlElementAttribute("USCH", typeof(string), Order=0)]
        [XmlElementAttribute("USCHU", typeof(string), Order=0)]
        [XmlElementAttribute("USFW", typeof(string), Order=0)]
        [XmlElementAttribute("ZANCC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
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
        /// <b>GRHEBIC - ?undefined?</b>.
        /// </summary>
        GRHEBIC,
        
        /// <summary>
        /// <b>HKNCC - Hong Kong Bank Identifier</b>.
        /// </summary>
        HKNCC,
        
        /// <summary>
        /// <b>IENSC - Irish NSC Identifier</b>.
        /// </summary>
        IENSC,
        
        /// <summary>
        /// <b>INIFSC - ?undefined?</b>.
        /// </summary>
        INIFSC,
        
        /// <summary>
        /// <b>ITNCC - Italian Domestic Identifier</b>.
        /// </summary>
        ITNCC,
        
        /// <summary>
        /// <b>NZNCC - New Zealand NCC Identifier</b>.
        /// </summary>
        NZNCC,
        
        /// <summary>
        /// <b>OthrClrCdId - Other Clearing Code Identification</b>.
        /// </summary>
        OthrClrCdId,
        
        /// <summary>
        /// <b>PLKNR - ?undefined?</b>.
        /// </summary>
        PLKNR,
        
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
    /// Class <b>FinancialInstitutionIdentification6</b> (Financial Institution Identification 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class FinancialInstitutionIdentification6
    {
        
        /// <summary>
        /// Element <b>ClrSysMmbId</b> (Clearing System Member Identification) of type ClearingSystemMemberIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ClearingSystemMemberIdentification2Choice ClrSysMmbId;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public GenericIdentification4 PrtryId;
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification25</b> (Party Identification 25).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class PartyIdentification25
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
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string BEI;
    }
    
    /// <summary>
    /// Class <b>PartyIdentificationAndAccount6</b> (Party Identification And Account 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.001.001.01")]
    public class PartyIdentificationAndAccount6
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification25.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification25 PtyId;
        
        /// <summary>
        /// Element <b>CdtAcct</b> (Credit Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccount7 CdtAcct;
        
        /// <summary>
        /// Element <b>FincgAcct</b> (Financing Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CashAccount7 FincgAcct;
    }
}
