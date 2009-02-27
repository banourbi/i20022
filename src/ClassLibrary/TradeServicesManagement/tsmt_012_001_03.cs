
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



namespace i20022.tsmt01200103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.012.001.03 name BaselineReSubmissionV03 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>BaselnReSubmissn</b> (Baseline Re Submission) of type BaselineReSubmissionV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public BaselineReSubmissionV03 BaselnReSubmissn;
    }
    
    /// <summary>
    /// Class <b>BaselineReSubmissionV03</b> (Baseline Re Submission V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class BaselineReSubmissionV03
    {
        
        /// <summary>
        /// Element <b>SubmissnId</b> (Submission Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 SubmissnId;
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SimpleIdentificationInformation TxId;
        
        /// <summary>
        /// Element <b>SubmitrTxRef</b> (Submitter Transaction Reference) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public SimpleIdentificationInformation SubmitrTxRef;
        
        /// <summary>
        /// Element <b>Baseln</b> (Baseline) of type Baseline3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Baseline3 Baseln;
        
        /// <summary>
        /// Element <b>BuyrCtctPrsn</b> (Buyer Contact Person) of type array of ContactIdentification1.
        /// </summary>
        [XmlElementAttribute("BuyrCtctPrsn", Order=4)]
        public ContactIdentification1[] BuyrCtctPrsn;
        
        /// <summary>
        /// Element <b>SellrCtctPrsn</b> (Seller Contact Person) of type array of ContactIdentification1.
        /// </summary>
        [XmlElementAttribute("SellrCtctPrsn", Order=5)]
        public ContactIdentification1[] SellrCtctPrsn;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of ContactIdentification1.
        /// </summary>
        [XmlElementAttribute("BuyrBkCtctPrsn", typeof(ContactIdentification1), Order=6)]
        [XmlElementAttribute("SellrBkCtctPrsn", typeof(ContactIdentification1), Order=6)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public ContactIdentification1[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=7)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>OthrBkCtctPrsn</b> (Other Bank Contact Person) of type array of ContactIdentification3.
        /// </summary>
        [XmlElementAttribute("OthrBkCtctPrsn", Order=8)]
        public ContactIdentification3[] OthrBkCtctPrsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>ContactIdentification3</b> (Contact Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class ContactIdentification3
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>NmPrfx</b> (Name Prefix) of type NamePrefix1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public NamePrefix1Code NmPrfx;
        
        /// <summary>
        /// Element <b>NmPrfxSpecified</b> (Name Prefix Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NmPrfxSpecified;
        
        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string GvnNm;
        
        /// <summary>
        /// Element <b>Role</b> (Role) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string Role;
        
        /// <summary>
        /// Element <b>PhneNb</b> (Phone Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string PhneNb;
        
        /// <summary>
        /// Element <b>FaxNb</b> (Fax Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string FaxNb;
        
        /// <summary>
        /// Element <b>EmailAdr</b> (Email Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string EmailAdr;
    }
    
    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>ContactIdentification1</b> (Contact Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>RequiredSubmission5</b> (Required Submission 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class RequiredSubmission5
    {
        
        /// <summary>
        /// Element <b>Submitr</b> (Submitter) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("Submitr", Order=0)]
        public BICIdentification1[] Submitr;
        
        /// <summary>
        /// Element <b>CertTp</b> (Certificate Type) of type TradeCertificateType2Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TradeCertificateType2Code CertTp;
    }
    
    /// <summary>
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Enumeration <b>TradeCertificateType2Code</b> (Trade Certificate Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum TradeCertificateType2Code
    {
        
        /// <summary>
        /// <b>BENE - Unemployment Disability Benefit</b>.
        /// </summary>
        BENE,
        
        /// <summary>
        /// <b>SHIP - Shipping Charge</b>.
        /// </summary>
        SHIP,
        
        /// <summary>
        /// <b>UND1 - Undefined 1</b>.
        /// </summary>
        UND1,
        
        /// <summary>
        /// <b>UND2 - Undefined 2</b>.
        /// </summary>
        UND2,
    }
    
    /// <summary>
    /// Class <b>RequiredSubmission4</b> (Required Submission 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class RequiredSubmission4
    {
        
        /// <summary>
        /// Element <b>Submitr</b> (Submitter) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("Submitr", Order=0)]
        public BICIdentification1[] Submitr;
        
        /// <summary>
        /// Element <b>CertTp</b> (Certificate Type) of type TradeCertificateType1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TradeCertificateType1Code CertTp;
        
        /// <summary>
        /// Element <b>MtchIssr</b> (Match Issuer) of type PartyIdentification27.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification27 MtchIssr;
        
        /// <summary>
        /// Element <b>MtchIsseDt</b> (Match Issue Date) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool MtchIsseDt;
        
        /// <summary>
        /// Element <b>MtchInspctnDt</b> (Match Inspection Date) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool MtchInspctnDt;
        
        /// <summary>
        /// Element <b>AuthrsdInspctrInd</b> (Authorised Inspector Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public bool AuthrsdInspctrInd;
        
        /// <summary>
        /// Element <b>MtchConsgn</b> (Match Consignee) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public bool MtchConsgn;
        
        /// <summary>
        /// Element <b>MtchManfctr</b> (Match Manufacturer) of type PartyIdentification27.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentification27 MtchManfctr;
        
        /// <summary>
        /// Element <b>LineItmId</b> (Line Item Identification) of type array of string.
        /// </summary>
        [XmlElementAttribute("LineItmId", Order=8)]
        public string[] LineItmId;
    }
    
    /// <summary>
    /// Enumeration <b>TradeCertificateType1Code</b> (Trade Certificate Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum TradeCertificateType1Code
    {
        
        /// <summary>
        /// <b>ANLY - Analysis</b>.
        /// </summary>
        ANLY,
        
        /// <summary>
        /// <b>QUAL - Quality</b>.
        /// </summary>
        QUAL,
        
        /// <summary>
        /// <b>QUAN - Quantity</b>.
        /// </summary>
        QUAN,
        
        /// <summary>
        /// <b>WEIG - Weight</b>.
        /// </summary>
        WEIG,
        
        /// <summary>
        /// <b>ORIG - Origin</b>.
        /// </summary>
        ORIG,
        
        /// <summary>
        /// <b>HEAL - Health</b>.
        /// </summary>
        HEAL,
        
        /// <summary>
        /// <b>PHYT - Phytosanitary</b>.
        /// </summary>
        PHYT,
    }
    
    /// <summary>
    /// Class <b>PartyIdentification27</b> (Party Identification 27).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class PartyIdentification27
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
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Ctry;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>RequiredSubmission3</b> (Required Submission 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class RequiredSubmission3
    {
        
        /// <summary>
        /// Element <b>Submitr</b> (Submitter) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("Submitr", Order=0)]
        public BICIdentification1[] Submitr;
        
        /// <summary>
        /// Element <b>MtchIssr</b> (Match Issuer) of type PartyIdentification27.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification27 MtchIssr;
        
        /// <summary>
        /// Element <b>MtchIsseDt</b> (Match Issue Date) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool MtchIsseDt;
        
        /// <summary>
        /// Element <b>MtchTrnsprt</b> (Match Transport) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool MtchTrnsprt;
        
        /// <summary>
        /// Element <b>MtchAmt</b> (Match Amount) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool MtchAmt;
        
        /// <summary>
        /// Element <b>ClausesReqrd</b> (Clauses Required) of type array of InsuranceClauses1Code.
        /// </summary>
        [XmlElementAttribute("ClausesReqrd", Order=5)]
        public InsuranceClauses1Code[] ClausesReqrd;
        
        /// <summary>
        /// Element <b>MtchAssrdPty</b> (Match Assured Party) of type AssuredType1Code.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public AssuredType1Code MtchAssrdPty;
        
        /// <summary>
        /// Element <b>MtchAssrdPtySpecified</b> (Match Assured Party Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MtchAssrdPtySpecified;
    }
    
    /// <summary>
    /// Enumeration <b>InsuranceClauses1Code</b> (Insurance Clauses 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum InsuranceClauses1Code
    {
        
        /// <summary>
        /// <b>ICCA - Institute Cargo Clause A</b>.
        /// </summary>
        ICCA,
        
        /// <summary>
        /// <b>ICCB - Institute Cargo Clause B</b>.
        /// </summary>
        ICCB,
        
        /// <summary>
        /// <b>ICCC - Institute Cargo Clause C</b>.
        /// </summary>
        ICCC,
        
        /// <summary>
        /// <b>ICAI - Institute Cargo Clause Air</b>.
        /// </summary>
        ICAI,
        
        /// <summary>
        /// <b>IWCC - Institute War Clause Cargo</b>.
        /// </summary>
        IWCC,
        
        /// <summary>
        /// <b>ISCC - Institute Strikes Clause Cargo</b>.
        /// </summary>
        ISCC,
        
        /// <summary>
        /// <b>IREC - Institute Replacement Clause</b>.
        /// </summary>
        IREC,
        
        /// <summary>
        /// <b>ICLC - Institute Classification Clause</b>.
        /// </summary>
        ICLC,
        
        /// <summary>
        /// <b>ISMC - ISMCode Endorsement</b>.
        /// </summary>
        ISMC,
        
        /// <summary>
        /// <b>CMCC - Computer Millenium Clause Cargo</b>.
        /// </summary>
        CMCC,
        
        /// <summary>
        /// <b>IRCE - Institute Radioactive Contamination Exclusion Clause</b>.
        /// </summary>
        IRCE,
    }
    
    /// <summary>
    /// Enumeration <b>AssuredType1Code</b> (Assured Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum AssuredType1Code
    {
        
        /// <summary>
        /// <b>BUYE - Buyer</b>.
        /// </summary>
        BUYE,
        
        /// <summary>
        /// <b>SELL - Seller</b>.
        /// </summary>
        SELL,
        
        /// <summary>
        /// <b>BUBA - Buyer Bank</b>.
        /// </summary>
        BUBA,
        
        /// <summary>
        /// <b>SEBA - Seller Bank</b>.
        /// </summary>
        SEBA,
    }
    
    /// <summary>
    /// Class <b>PaymentPeriod2</b> (Payment Period 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class PaymentPeriod2
    {
        
        /// <summary>
        /// Element <b>Cd</b> (Code) of type PaymentTime2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PaymentTime2Code Cd;
        
        /// <summary>
        /// Element <b>NbOfDays</b> (Number Of Days) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal NbOfDays;
        
        /// <summary>
        /// Element <b>NbOfDaysSpecified</b> (Number Of Days Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NbOfDaysSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentTime2Code</b> (Payment Time 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum PaymentTime2Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>EMTD - End Of Month Of Delivery</b>.
        /// </summary>
        EMTD,
        
        /// <summary>
        /// <b>EPRD - End Of Period After Delivery</b>.
        /// </summary>
        EPRD,
        
        /// <summary>
        /// <b>PRMD - End Of Period After End Of Delivery Month</b>.
        /// </summary>
        PRMD,
        
        /// <summary>
        /// <b>IREC - Institute Replacement Clause</b>.
        /// </summary>
        IREC,
        
        /// <summary>
        /// <b>PRMR - End Of Period After End Of Receipt Month</b>.
        /// </summary>
        PRMR,
        
        /// <summary>
        /// <b>EPRR - End Of Period After Receipt</b>.
        /// </summary>
        EPRR,
        
        /// <summary>
        /// <b>EMTR - End Of Month Of Receipt</b>.
        /// </summary>
        EMTR,
        
        /// <summary>
        /// <b>EPAM - End Of Period After Match</b>.
        /// </summary>
        EPAM,
    }
    
    /// <summary>
    /// Class <b>PaymentTerms2</b> (Payment Terms 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class PaymentTerms2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrPmtTerms (Other Payment Terms) of type string 
        /// PmtCd (Payment Code) of type PaymentPeriod2 
        /// </summary>
        [XmlElementAttribute("OthrPmtTerms", typeof(string), Order=0)]
        [XmlElementAttribute("PmtCd", typeof(PaymentPeriod2), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// Pctg (Percentage) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=1)]
        [XmlElementAttribute("Pctg", typeof(decimal), Order=1)]
        public object Item1;
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>PaymentObligation1</b> (Payment Obligation 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class PaymentObligation1
    {
        
        /// <summary>
        /// Element <b>OblgrBk</b> (Obligor Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public BICIdentification1 OblgrBk;
        
        /// <summary>
        /// Element <b>RcptBk</b> (Recipient Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BICIdentification1 RcptBk;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// Pctg (Percentage) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=2)]
        [XmlElementAttribute("Pctg", typeof(decimal), Order=2)]
        public object Item;
        
        /// <summary>
        /// Element <b>ChrgsAmt</b> (Charges Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CurrencyAndAmount ChrgsAmt;
        
        /// <summary>
        /// Element <b>ChrgsPctg</b> (Charges Percentage) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public decimal ChrgsPctg;
        
        /// <summary>
        /// Element <b>ChrgsPctgSpecified</b> (Charges Percentage Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgsPctgSpecified;
        
        /// <summary>
        /// Element <b>XpryDt</b> (Expiry Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime XpryDt;
        
        /// <summary>
        /// Element <b>AplblLaw</b> (Applicable Law) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string AplblLaw;
        
        /// <summary>
        /// Element <b>PmtTerms</b> (Payment Terms) of type array of PaymentTerms2.
        /// </summary>
        [XmlElementAttribute("PmtTerms", Order=7)]
        public PaymentTerms2[] PmtTerms;
        
        /// <summary>
        /// Element <b>SttlmTerms</b> (Settlement Terms) of type SettlementTerms2.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public SettlementTerms2 SttlmTerms;
    }
    
    /// <summary>
    /// Class <b>SettlementTerms2</b> (Settlement Terms 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class SettlementTerms2
    {
        
        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type FinancialInstitutionIdentification4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancialInstitutionIdentification4Choice CdtrAgt;
        
        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccount7 CdtrAcct;
    }
    
    /// <summary>
    /// Class <b>FinancialInstitutionIdentification4Choice</b> (Financial Institution Identification 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class FinancialInstitutionIdentification4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BIC (BIC) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress6 
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress6), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress6</b> (Name And Address 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class NameAndAddress6
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress2 Adr;
    }
    
    /// <summary>
    /// Class <b>PostalAddress2</b> (Postal Address 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class PostalAddress2
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
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>PaymentPeriod1</b> (Payment Period 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class PaymentPeriod1
    {
        
        /// <summary>
        /// Element <b>Cd</b> (Code) of type PaymentTime1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PaymentTime1Code Cd;
        
        /// <summary>
        /// Element <b>NbOfDays</b> (Number Of Days) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal NbOfDays;
        
        /// <summary>
        /// Element <b>NbOfDaysSpecified</b> (Number Of Days Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NbOfDaysSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentTime1Code</b> (Payment Time 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum PaymentTime1Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>EMTD - End Of Month Of Delivery</b>.
        /// </summary>
        EMTD,
        
        /// <summary>
        /// <b>EPRD - End Of Period After Delivery</b>.
        /// </summary>
        EPRD,
        
        /// <summary>
        /// <b>PRMD - End Of Period After End Of Delivery Month</b>.
        /// </summary>
        PRMD,
        
        /// <summary>
        /// <b>IREC - Institute Replacement Clause</b>.
        /// </summary>
        IREC,
        
        /// <summary>
        /// <b>PRMR - End Of Period After End Of Receipt Month</b>.
        /// </summary>
        PRMR,
        
        /// <summary>
        /// <b>EPRR - End Of Period After Receipt</b>.
        /// </summary>
        EPRR,
        
        /// <summary>
        /// <b>EMTR - End Of Month Of Receipt</b>.
        /// </summary>
        EMTR,
    }
    
    /// <summary>
    /// Class <b>PaymentTerms1</b> (Payment Terms 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class PaymentTerms1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrPmtTerms (Other Payment Terms) of type string 
        /// PmtCd (Payment Code) of type PaymentPeriod1 
        /// </summary>
        [XmlElementAttribute("OthrPmtTerms", typeof(string), Order=0)]
        [XmlElementAttribute("PmtCd", typeof(PaymentPeriod1), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// Pctg (Percentage) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=1)]
        [XmlElementAttribute("Pctg", typeof(decimal), Order=1)]
        public object Item1;
    }
    
    /// <summary>
    /// Class <b>UserDefinedInformation1</b> (User Defined Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class UserDefinedInformation1
    {
        
        /// <summary>
        /// Element <b>Labl</b> (Label) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Labl;
        
        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Inf;
    }
    
    /// <summary>
    /// Class <b>Tax13</b> (Tax 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class Tax13
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrTaxTp (Other Tax Type) of type string 
        /// Tp (Type) of type TaxType9Code 
        /// </summary>
        [XmlElementAttribute("OthrTaxTp", typeof(string), Order=0)]
        [XmlElementAttribute("Tp", typeof(TaxType9Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=1)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=1)]
        public object Item1;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType9Code</b> (Tax Type 9Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum TaxType9Code
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
        /// <b>STAM - Stamp Duty</b>.
        /// </summary>
        STAM,
        
        /// <summary>
        /// <b>COAX - Consumption Tax</b>.
        /// </summary>
        COAX,
        
        /// <summary>
        /// <b>VATA - Value Added Tax</b>.
        /// </summary>
        VATA,
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
    }
    
    /// <summary>
    /// Class <b>ChargesDetails1</b> (Charges Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class ChargesDetails1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrChrgsTp (Other Charges Type) of type string 
        /// Tp (Type) of type ChargeType8Code 
        /// </summary>
        [XmlElementAttribute("OthrChrgsTp", typeof(string), Order=0)]
        [XmlElementAttribute("Tp", typeof(ChargeType8Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=1)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=1)]
        public object Item1;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType8Code</b> (Charge Type 8Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum ChargeType8Code
    {
        
        /// <summary>
        /// <b>SIGN - Signature Service</b>.
        /// </summary>
        SIGN,
        
        /// <summary>
        /// <b>STDE - Storage At Destination</b>.
        /// </summary>
        STDE,
        
        /// <summary>
        /// <b>STOR - Storage At Origin</b>.
        /// </summary>
        STOR,
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>PICK - Pick Up</b>.
        /// </summary>
        PICK,
        
        /// <summary>
        /// <b>DNGR - Dangerous Goods Fee</b>.
        /// </summary>
        DNGR,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>INSU - Insurance Premium</b>.
        /// </summary>
        INSU,
        
        /// <summary>
        /// <b>COLF - Collect Freight</b>.
        /// </summary>
        COLF,
        
        /// <summary>
        /// <b>CHOR - Clearance And Handling At Origin</b>.
        /// </summary>
        CHOR,
        
        /// <summary>
        /// <b>CHDE - Clearance And Handling At Destination</b>.
        /// </summary>
        CHDE,
        
        /// <summary>
        /// <b>AIRF - Air Way Bill Fee</b>.
        /// </summary>
        AIRF,
        
        /// <summary>
        /// <b>TRPT - Transport Charges</b>.
        /// </summary>
        TRPT,
    }
    
    /// <summary>
    /// Class <b>Charge12</b> (Charge 12).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class Charge12
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type FreightCharges1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FreightCharges1Code Tp;
        
        /// <summary>
        /// Element <b>Chrgs</b> (Charges) of type array of ChargesDetails1.
        /// </summary>
        [XmlElementAttribute("Chrgs", Order=1)]
        public ChargesDetails1[] Chrgs;
    }
    
    /// <summary>
    /// Enumeration <b>FreightCharges1Code</b> (Freight Charges 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum FreightCharges1Code
    {
        
        /// <summary>
        /// <b>CLCT - Collect</b>.
        /// </summary>
        CLCT,
        
        /// <summary>
        /// <b>PRPD - Prepaid</b>.
        /// </summary>
        PRPD,
    }
    
    /// <summary>
    /// Class <b>Adjustment3</b> (Adjustment 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class Adjustment3
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OthrAdjstmntTp (Other Adjustment Type) of type string 
        /// Tp (Type) of type AdjustmentType2Code 
        /// </summary>
        [XmlElementAttribute("OthrAdjstmntTp", typeof(string), Order=0)]
        [XmlElementAttribute("Tp", typeof(AdjustmentType2Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=1)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=1)]
        public object Item1;
        
        /// <summary>
        /// Element <b>Drctn</b> (Direction) of type AdjustmentDirection1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AdjustmentDirection1Code Drctn;
    }
    
    /// <summary>
    /// Enumeration <b>AdjustmentType2Code</b> (Adjustment Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum AdjustmentType2Code
    {
        
        /// <summary>
        /// <b>REBA - Rebate</b>.
        /// </summary>
        REBA,
        
        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
        
        /// <summary>
        /// <b>CREN - Credit Note</b>.
        /// </summary>
        CREN,
        
        /// <summary>
        /// <b>SURC - Surcharge</b>.
        /// </summary>
        SURC,
    }
    
    /// <summary>
    /// Enumeration <b>AdjustmentDirection1Code</b> (Adjustment Direction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>Incoterms1</b> (Incoterms 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class Incoterms1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type Incoterms1Code 
        /// Othr (Other) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(Incoterms1Code), Order=0)]
        [XmlElementAttribute("Othr", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Lctn</b> (Location) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Lctn;
    }
    
    /// <summary>
    /// Enumeration <b>Incoterms1Code</b> (Incoterms 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum Incoterms1Code
    {
        
        /// <summary>
        /// <b>EXW - Ex Works</b>.
        /// </summary>
        EXW,
        
        /// <summary>
        /// <b>FCA - Free Carrier</b>.
        /// </summary>
        FCA,
        
        /// <summary>
        /// <b>FAS - Free Alongside Ship</b>.
        /// </summary>
        FAS,
        
        /// <summary>
        /// <b>FOB - Free On Board</b>.
        /// </summary>
        FOB,
        
        /// <summary>
        /// <b>CFR - Cost And Freight</b>.
        /// </summary>
        CFR,
        
        /// <summary>
        /// <b>CIF - Cost Insurance And Freight</b>.
        /// </summary>
        CIF,
        
        /// <summary>
        /// <b>CPT - Carriage Paid</b>.
        /// </summary>
        CPT,
        
        /// <summary>
        /// <b>CIP - Carriage And Insurance Paid</b>.
        /// </summary>
        CIP,
        
        /// <summary>
        /// <b>DAF - Delivered At Frontier</b>.
        /// </summary>
        DAF,
        
        /// <summary>
        /// <b>DES - Delivered Ex Ship</b>.
        /// </summary>
        DES,
        
        /// <summary>
        /// <b>DEQ - Delivered Ex Quay</b>.
        /// </summary>
        DEQ,
        
        /// <summary>
        /// <b>DDU - Delivered Duty Unpaid</b>.
        /// </summary>
        DDU,
        
        /// <summary>
        /// <b>DDP - Delivered Duty Paid</b>.
        /// </summary>
        DDP,
    }
    
    /// <summary>
    /// Class <b>MultimodalTransport3</b> (Multimodal Transport 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class MultimodalTransport3
    {
        
        /// <summary>
        /// Element <b>TakngInChrg</b> (Taking In Charge) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TakngInChrg;
        
        /// <summary>
        /// Element <b>PlcOfFnlDstn</b> (Place Of Final Destination) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PlcOfFnlDstn;
    }
    
    /// <summary>
    /// Class <b>TransportByRail3</b> (Transport By Rail 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class TransportByRail3
    {
        
        /// <summary>
        /// Element <b>PlcOfRct</b> (Place Of Receipt) of type array of string.
        /// </summary>
        [XmlElementAttribute("PlcOfRct", Order=0)]
        public string[] PlcOfRct;
        
        /// <summary>
        /// Element <b>PlcOfDlvry</b> (Place Of Delivery) of type array of string.
        /// </summary>
        [XmlElementAttribute("PlcOfDlvry", Order=1)]
        public string[] PlcOfDlvry;
        
        /// <summary>
        /// Element <b>RailCrrierNm</b> (Rail Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string RailCrrierNm;
    }
    
    /// <summary>
    /// Class <b>TransportByRoad3</b> (Transport By Road 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class TransportByRoad3
    {
        
        /// <summary>
        /// Element <b>PlcOfRct</b> (Place Of Receipt) of type array of string.
        /// </summary>
        [XmlElementAttribute("PlcOfRct", Order=0)]
        public string[] PlcOfRct;
        
        /// <summary>
        /// Element <b>PlcOfDlvry</b> (Place Of Delivery) of type array of string.
        /// </summary>
        [XmlElementAttribute("PlcOfDlvry", Order=1)]
        public string[] PlcOfDlvry;
        
        /// <summary>
        /// Element <b>RoadCrrierNm</b> (Road Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string RoadCrrierNm;
    }
    
    /// <summary>
    /// Class <b>TransportBySea3</b> (Transport By Sea 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class TransportBySea3
    {
        
        /// <summary>
        /// Element <b>PortOfLoadng</b> (Port Of Loading) of type array of string.
        /// </summary>
        [XmlElementAttribute("PortOfLoadng", Order=0)]
        public string[] PortOfLoadng;
        
        /// <summary>
        /// Element <b>PortOfDschrge</b> (Port Of Discharge) of type array of string.
        /// </summary>
        [XmlElementAttribute("PortOfDschrge", Order=1)]
        public string[] PortOfDschrge;
        
        /// <summary>
        /// Element <b>SeaCrrierNm</b> (Sea Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string SeaCrrierNm;
    }
    
    /// <summary>
    /// Class <b>AirportDescription1</b> (Airport Description 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class AirportDescription1
    {
        
        /// <summary>
        /// Element <b>Twn</b> (Town) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Twn;
        
        /// <summary>
        /// Element <b>AirprtNm</b> (Airport Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AirprtNm;
    }
    
    /// <summary>
    /// Class <b>AirportName1Choice</b> (Airport Name 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class AirportName1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AirprtCd (Airport Code) of type string 
        /// OthrAirprtDesc (Other Airport Description) of type AirportDescription1 
        /// </summary>
        [XmlElementAttribute("AirprtCd", typeof(string), Order=0)]
        [XmlElementAttribute("OthrAirprtDesc", typeof(AirportDescription1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>TransportByAir3</b> (Transport By Air 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class TransportByAir3
    {
        
        /// <summary>
        /// Element <b>DprtureAirprt</b> (Departure Airport) of type array of AirportName1Choice.
        /// </summary>
        [XmlElementAttribute("DprtureAirprt", Order=0)]
        public AirportName1Choice[] DprtureAirprt;
        
        /// <summary>
        /// Element <b>DstnAirprt</b> (Destination Airport) of type array of AirportName1Choice.
        /// </summary>
        [XmlElementAttribute("DstnAirprt", Order=1)]
        public AirportName1Choice[] DstnAirprt;
        
        /// <summary>
        /// Element <b>AirCrrierNm</b> (Air Carrier Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AirCrrierNm;
    }
    
    /// <summary>
    /// Class <b>SingleTransport4</b> (Single Transport 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class SingleTransport4
    {
        
        /// <summary>
        /// Element <b>TrnsprtByAir</b> (Transport By Air) of type array of TransportByAir3.
        /// </summary>
        [XmlElementAttribute("TrnsprtByAir", Order=0)]
        public TransportByAir3[] TrnsprtByAir;
        
        /// <summary>
        /// Element <b>TrnsprtBySea</b> (Transport By Sea) of type array of TransportBySea3.
        /// </summary>
        [XmlElementAttribute("TrnsprtBySea", Order=1)]
        public TransportBySea3[] TrnsprtBySea;
        
        /// <summary>
        /// Element <b>TrnsprtByRoad</b> (Transport By Road) of type array of TransportByRoad3.
        /// </summary>
        [XmlElementAttribute("TrnsprtByRoad", Order=2)]
        public TransportByRoad3[] TrnsprtByRoad;
        
        /// <summary>
        /// Element <b>TrnsprtByRail</b> (Transport By Rail) of type array of TransportByRail3.
        /// </summary>
        [XmlElementAttribute("TrnsprtByRail", Order=3)]
        public TransportByRail3[] TrnsprtByRail;
    }
    
    /// <summary>
    /// Class <b>TransportMeans1</b> (Transport Means 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class TransportMeans1
    {
        
        /// <summary>
        /// Element <b>IndvTrnsprt</b> (Individual Transport) of type SingleTransport4.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SingleTransport4 IndvTrnsprt;
        
        /// <summary>
        /// Element <b>MltmdlTrnsprt</b> (Multimodal Transport) of type MultimodalTransport3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public MultimodalTransport3 MltmdlTrnsprt;
    }
    
    /// <summary>
    /// Class <b>ShipmentDateRange2</b> (Shipment Date Range 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class ShipmentDateRange2
    {
        
        /// <summary>
        /// Element <b>SubQtyVal</b> (Sub Quantity Value) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal SubQtyVal;
        
        /// <summary>
        /// Element <b>EarlstShipmntDt</b> (Earliest Shipment Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime EarlstShipmntDt;
        
        /// <summary>
        /// Element <b>EarlstShipmntDtSpecified</b> (Earliest Shipment Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EarlstShipmntDtSpecified;
        
        /// <summary>
        /// Element <b>LatstShipmntDt</b> (Latest Shipment Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime LatstShipmntDt;
        
        /// <summary>
        /// Element <b>LatstShipmntDtSpecified</b> (Latest Shipment Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatstShipmntDtSpecified;
    }
    
    /// <summary>
    /// Class <b>ShipmentSchedule1Choice</b> (Shipment Schedule 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class ShipmentSchedule1Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// ShipmntDtRg (Shipment Date Range) of type ShipmentDateRange1 
        /// ShipmntSubSchdl (Shipment Sub Schedule) of type ShipmentDateRange2 
        /// </summary>
        [XmlElementAttribute("ShipmntDtRg", typeof(ShipmentDateRange1), Order=0)]
        [XmlElementAttribute("ShipmntSubSchdl", typeof(ShipmentDateRange2), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>ShipmentDateRange1</b> (Shipment Date Range 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class ShipmentDateRange1
    {
        
        /// <summary>
        /// Element <b>EarlstShipmntDt</b> (Earliest Shipment Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime EarlstShipmntDt;
        
        /// <summary>
        /// Element <b>EarlstShipmntDtSpecified</b> (Earliest Shipment Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EarlstShipmntDtSpecified;
        
        /// <summary>
        /// Element <b>LatstShipmntDt</b> (Latest Shipment Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime LatstShipmntDt;
        
        /// <summary>
        /// Element <b>LatstShipmntDtSpecified</b> (Latest Shipment Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatstShipmntDtSpecified;
    }
    
    /// <summary>
    /// Class <b>ProductCategory1</b> (Product Category 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>ProductCharacteristics1</b> (Product Characteristics 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>UnitPrice9</b> (Unit Price 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class UnitPrice9
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
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CurrencyAndAmount Amt;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>PercentageTolerance1</b> (Percentage Tolerance 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>LineItemDetails7</b> (Line Item Details 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class LineItemDetails7
    {
        
        /// <summary>
        /// Element <b>LineItmId</b> (Line Item Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string LineItmId;
        
        /// <summary>
        /// Element <b>Qty</b> (Quantity) of type Quantity4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Quantity4 Qty;
        
        /// <summary>
        /// Element <b>QtyTlrnce</b> (Quantity Tolerance) of type PercentageTolerance1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PercentageTolerance1 QtyTlrnce;
        
        /// <summary>
        /// Element <b>UnitPric</b> (Unit Price) of type UnitPrice9.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public UnitPrice9 UnitPric;
        
        /// <summary>
        /// Element <b>PricTlrnce</b> (Price Tolerance) of type PercentageTolerance1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PercentageTolerance1 PricTlrnce;
        
        /// <summary>
        /// Element <b>PdctNm</b> (Product Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string PdctNm;
        
        /// <summary>
        /// Element <b>PdctIdr</b> (Product Identifier) of type array of ProductIdentifier2Choice.
        /// </summary>
        [XmlElementAttribute("PdctIdr", Order=6)]
        public ProductIdentifier2Choice[] PdctIdr;
        
        /// <summary>
        /// Element <b>PdctChrtcs</b> (Product Characteristics) of type array of ProductCharacteristics1Choice.
        /// </summary>
        [XmlElementAttribute("PdctChrtcs", Order=7)]
        public ProductCharacteristics1Choice[] PdctChrtcs;
        
        /// <summary>
        /// Element <b>PdctCtgy</b> (Product Category) of type array of ProductCategory1Choice.
        /// </summary>
        [XmlElementAttribute("PdctCtgy", Order=8)]
        public ProductCategory1Choice[] PdctCtgy;
        
        /// <summary>
        /// Element <b>PdctOrgn</b> (Product Origin) of type array of string.
        /// </summary>
        [XmlElementAttribute("PdctOrgn", Order=9)]
        public string[] PdctOrgn;
        
        /// <summary>
        /// Element <b>ShipmntSchdl</b> (Shipment Schedule) of type ShipmentSchedule1Choice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public ShipmentSchedule1Choice ShipmntSchdl;
        
        /// <summary>
        /// Element <b>RtgSummry</b> (Routing Summary) of type TransportMeans1.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public TransportMeans1 RtgSummry;
        
        /// <summary>
        /// Element <b>Incotrms</b> (Incoterms) of type array of Incoterms1.
        /// </summary>
        [XmlElementAttribute("Incotrms", Order=12)]
        public Incoterms1[] Incotrms;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type array of Adjustment3.
        /// </summary>
        [XmlElementAttribute("Adjstmnt", Order=13)]
        public Adjustment3[] Adjstmnt;
        
        /// <summary>
        /// Element <b>FrghtChrgs</b> (Freight Charges) of type Charge12.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public Charge12 FrghtChrgs;
        
        /// <summary>
        /// Element <b>Tax</b> (Tax) of type array of Tax13.
        /// </summary>
        [XmlElementAttribute("Tax", Order=15)]
        public Tax13[] Tax;
        
        /// <summary>
        /// Element <b>TtlAmt</b> (Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public CurrencyAndAmount TtlAmt;
    }
    
    /// <summary>
    /// Class <b>LineItem7</b> (Line Item 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class LineItem7
    {
        
        /// <summary>
        /// Element <b>GoodsDesc</b> (Goods Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string GoodsDesc;
        
        /// <summary>
        /// Element <b>PrtlShipmnt</b> (Partial Shipment) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool PrtlShipmnt;
        
        /// <summary>
        /// Element <b>TrnsShipmnt</b> (Trans Shipment) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool TrnsShipmnt;
        
        /// <summary>
        /// Element <b>TrnsShipmntSpecified</b> (Trans Shipment Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TrnsShipmntSpecified;
        
        /// <summary>
        /// Element <b>ShipmntDtRg</b> (Shipment Date Range) of type ShipmentDateRange1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ShipmentDateRange1 ShipmntDtRg;
        
        /// <summary>
        /// Element <b>LineItmDtls</b> (Line Item Details) of type array of LineItemDetails7.
        /// </summary>
        [XmlElementAttribute("LineItmDtls", Order=4)]
        public LineItemDetails7[] LineItmDtls;
        
        /// <summary>
        /// Element <b>LineItmsTtlAmt</b> (Line Items Total Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CurrencyAndAmount LineItmsTtlAmt;
        
        /// <summary>
        /// Element <b>RtgSummry</b> (Routing Summary) of type TransportMeans1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public TransportMeans1 RtgSummry;
        
        /// <summary>
        /// Element <b>Incotrms</b> (Incoterms) of type array of Incoterms1.
        /// </summary>
        [XmlElementAttribute("Incotrms", Order=7)]
        public Incoterms1[] Incotrms;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type array of Adjustment3.
        /// </summary>
        [XmlElementAttribute("Adjstmnt", Order=8)]
        public Adjustment3[] Adjstmnt;
        
        /// <summary>
        /// Element <b>FrghtChrgs</b> (Freight Charges) of type Charge12.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public Charge12 FrghtChrgs;
        
        /// <summary>
        /// Element <b>Tax</b> (Tax) of type array of Tax13.
        /// </summary>
        [XmlElementAttribute("Tax", Order=10)]
        public Tax13[] Tax;
        
        /// <summary>
        /// Element <b>TtlNetAmt</b> (Total Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public CurrencyAndAmount TtlNetAmt;
        
        /// <summary>
        /// Element <b>BuyrDfndInf</b> (Buyer Defined Information) of type array of UserDefinedInformation1.
        /// </summary>
        [XmlElementAttribute("BuyrDfndInf", Order=12)]
        public UserDefinedInformation1[] BuyrDfndInf;
        
        /// <summary>
        /// Element <b>SellrDfndInf</b> (Seller Defined Information) of type array of UserDefinedInformation1.
        /// </summary>
        [XmlElementAttribute("SellrDfndInf", Order=13)]
        public UserDefinedInformation1[] SellrDfndInf;
    }
    
    /// <summary>
    /// Class <b>PostalAddress5</b> (Postal Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
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
    /// Class <b>DocumentIdentification7</b> (Document Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class DocumentIdentification7
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>DtOfIsse</b> (Date Of Issue) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime DtOfIsse;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification1</b> (Document Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class DocumentIdentification1
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
        /// Element <b>Submitr</b> (Submitter) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public BICIdentification1 Submitr;
    }
    
    /// <summary>
    /// Class <b>Baseline3</b> (Baseline 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class Baseline3
    {
        
        /// <summary>
        /// Element <b>SubmitrBaselnId</b> (Submitter Baseline Identification) of type DocumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification1 SubmitrBaselnId;
        
        /// <summary>
        /// Element <b>SvcCd</b> (Service Code) of type TradeFinanceService2Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TradeFinanceService2Code SvcCd;
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DocumentIdentification7 PurchsOrdrRef;
        
        /// <summary>
        /// Element <b>Buyr</b> (Buyer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification26 Buyr;
        
        /// <summary>
        /// Element <b>Sellr</b> (Seller) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification26 Sellr;
        
        /// <summary>
        /// Element <b>BuyrBk</b> (Buyer Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public BICIdentification1 BuyrBk;
        
        /// <summary>
        /// Element <b>SellrBk</b> (Seller Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public BICIdentification1 SellrBk;
        
        /// <summary>
        /// Element <b>BuyrSdSubmitgBk</b> (Buyer Side Submitting Bank) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("BuyrSdSubmitgBk", Order=7)]
        public BICIdentification1[] BuyrSdSubmitgBk;
        
        /// <summary>
        /// Element <b>SellrSdSubmitgBk</b> (Seller Side Submitting Bank) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("SellrSdSubmitgBk", Order=8)]
        public BICIdentification1[] SellrSdSubmitgBk;
        
        /// <summary>
        /// Element <b>BllTo</b> (Bill To) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PartyIdentification26 BllTo;
        
        /// <summary>
        /// Element <b>ShipTo</b> (Ship To) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public PartyIdentification26 ShipTo;
        
        /// <summary>
        /// Element <b>Consgn</b> (Consignee) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public PartyIdentification26 Consgn;
        
        /// <summary>
        /// Element <b>Goods</b> (Goods) of type LineItem7.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public LineItem7 Goods;
        
        /// <summary>
        /// Element <b>PmtTerms</b> (Payment Terms) of type array of PaymentTerms1.
        /// </summary>
        [XmlElementAttribute("PmtTerms", Order=13)]
        public PaymentTerms1[] PmtTerms;
        
        /// <summary>
        /// Element <b>SttlmTerms</b> (Settlement Terms) of type SettlementTerms2.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public SettlementTerms2 SttlmTerms;
        
        /// <summary>
        /// Element <b>PmtOblgtn</b> (Payment Obligation) of type array of PaymentObligation1.
        /// </summary>
        [XmlElementAttribute("PmtOblgtn", Order=15)]
        public PaymentObligation1[] PmtOblgtn;
        
        /// <summary>
        /// Element <b>LatstMtchDt</b> (Latest Match Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=16)]
        public System.DateTime LatstMtchDt;
        
        /// <summary>
        /// Element <b>LatstMtchDtSpecified</b> (Latest Match Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatstMtchDtSpecified;
        
        /// <summary>
        /// Element <b>ComrclDataSetReqrd</b> (Commercial Data Set Required) of type array of BICIdentification1.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order=17)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Submitr", IsNullable=false)]
        public BICIdentification1[] ComrclDataSetReqrd;
        
        /// <summary>
        /// Element <b>TrnsprtDataSetReqrd</b> (Transport Data Set Required) of type array of BICIdentification1.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order=18)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Submitr", IsNullable=false)]
        public BICIdentification1[] TrnsprtDataSetReqrd;
        
        /// <summary>
        /// Element <b>InsrncDataSetReqrd</b> (Insurance Data Set Required) of type RequiredSubmission3.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public RequiredSubmission3 InsrncDataSetReqrd;
        
        /// <summary>
        /// Element <b>CertDataSetReqrd</b> (Certificate Data Set Required) of type array of RequiredSubmission4.
        /// </summary>
        [XmlElementAttribute("CertDataSetReqrd", Order=20)]
        public RequiredSubmission4[] CertDataSetReqrd;
        
        /// <summary>
        /// Element <b>OthrCertDataSetReqrd</b> (Other Certificate Data Set Required) of type array of RequiredSubmission5.
        /// </summary>
        [XmlElementAttribute("OthrCertDataSetReqrd", Order=21)]
        public RequiredSubmission5[] OthrCertDataSetReqrd;
        
        /// <summary>
        /// Element <b>InttToPayXpctd</b> (Intent To Pay Expected) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=22)]
        public bool InttToPayXpctd;
    }
    
    /// <summary>
    /// Enumeration <b>TradeFinanceService2Code</b> (Trade Finance Service 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public enum TradeFinanceService2Code
    {
        
        /// <summary>
        /// <b>LEV1 - Level 1 Services</b>.
        /// </summary>
        LEV1,
        
        /// <summary>
        /// <b>LEV2 - Level 2 Services</b>.
        /// </summary>
        LEV2,
        
        /// <summary>
        /// <b>LEV3 - Level 3 Services</b>.
        /// </summary>
        LEV3,
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <summary>
        /// <b>BuyrBkCtctPrsn - Buyer Bank Contact Person</b>.
        /// </summary>
        BuyrBkCtctPrsn,
        
        /// <summary>
        /// <b>SellrBkCtctPrsn - Seller Bank Contact Person</b>.
        /// </summary>
        SellrBkCtctPrsn,
    }
}
