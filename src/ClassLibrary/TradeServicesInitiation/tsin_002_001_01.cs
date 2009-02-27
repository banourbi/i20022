
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



namespace i20022.tsin00200101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsin.002.001.01 name InvoiceFinancingRequestStatusV01 from Trade Services Initiation business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>InvcFincgReqSts</b> (Invoice Financing Request Status) of type InvoiceFinancingRequestStatusV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvoiceFinancingRequestStatusV01 InvcFincgReqSts;
    }
    
    /// <summary>
    /// Class <b>InvoiceFinancingRequestStatusV01</b> (Invoice Financing Request Status V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class InvoiceFinancingRequestStatusV01
    {
        
        /// <summary>
        /// Element <b>StsId</b> (Status Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 StsId;
        
        /// <summary>
        /// Element <b>OrgnlReqInfAndSts</b> (Original Request Information And Status) of type OriginalRequestInformation1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public OriginalRequestInformation1 OrgnlReqInfAndSts;
        
        /// <summary>
        /// Element <b>FincgInfAndSts</b> (Financing Information And Status) of type FinancingInformationAndStatus1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancingInformationAndStatus1 FincgInfAndSts;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>InstalmentFinancingInformation1</b> (Instalment Financing Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class InstalmentFinancingInformation1
    {
        
        /// <summary>
        /// Element <b>InstlmtSeqId</b> (Instalment Sequence Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string InstlmtSeqId;
        
        /// <summary>
        /// Element <b>InstlmtTtlAmt</b> (Instalment Total Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount InstlmtTtlAmt;
        
        /// <summary>
        /// Element <b>InstlmtFincgRslt</b> (Instalment Financing Result) of type FinancingResult1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancingResult1 InstlmtFincgRslt;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>FinancingResult1</b> (Financing Result 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class FinancingResult1
    {
        
        /// <summary>
        /// Element <b>FincgReqSts</b> (Financing Request Status) of type RequestStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RequestStatus1Code FincgReqSts;
        
        /// <summary>
        /// Element <b>StsRsn</b> (Status Reason) of type StatusReason4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public StatusReason4Choice StsRsn;
        
        /// <summary>
        /// Element <b>AddtlStsRsnInf</b> (Additional Status Reason Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("AddtlStsRsnInf", Order=2)]
        public string[] AddtlStsRsnInf;
        
        /// <summary>
        /// Element <b>FincdAmt</b> (Financed Amount) of type FinancingRateOrAmountChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public FinancingRateOrAmountChoice FincdAmt;
    }
    
    /// <summary>
    /// Enumeration <b>RequestStatus1Code</b> (Request Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public enum RequestStatus1Code
    {
        
        /// <summary>
        /// <b>FNCD - Financed</b>.
        /// </summary>
        FNCD,
        
        /// <summary>
        /// <b>PDNG - Pending</b>.
        /// </summary>
        PDNG,
        
        /// <summary>
        /// <b>NTFD - Not Financed</b>.
        /// </summary>
        NTFD,
    }
    
    /// <summary>
    /// Class <b>StatusReason4Choice</b> (Status Reason 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class StatusReason4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type FinancingStatusReason1Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(FinancingStatusReason1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>FinancingStatusReason1Code</b> (Financing Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public enum FinancingStatusReason1Code
    {
        
        /// <summary>
        /// <b>CA01 - Cancellation Request Out Of Time</b>.
        /// </summary>
        CA01,
        
        /// <summary>
        /// <b>CA02 - No Matching Financing Request</b>.
        /// </summary>
        CA02,
        
        /// <summary>
        /// <b>AC01 - Incorrect Account Number</b>.
        /// </summary>
        AC01,
        
        /// <summary>
        /// <b>AC04 - Closed Account Number</b>.
        /// </summary>
        AC04,
        
        /// <summary>
        /// <b>AC06 - Blocked Account</b>.
        /// </summary>
        AC06,
        
        /// <summary>
        /// <b>BE08 - Unrecognised Financing Requestor</b>.
        /// </summary>
        BE08,
        
        /// <summary>
        /// <b>BE09 - Unrecognised Intermediary Agent</b>.
        /// </summary>
        BE09,
        
        /// <summary>
        /// <b>BE10 - Unexpected Intermediary Agent</b>.
        /// </summary>
        BE10,
        
        /// <summary>
        /// <b>BE11 - Unrecognised Party</b>.
        /// </summary>
        BE11,
        
        /// <summary>
        /// <b>DT02 - Invalid Payment Due Date</b>.
        /// </summary>
        DT02,
        
        /// <summary>
        /// <b>ID01 - Duplicated Request Message</b>.
        /// </summary>
        ID01,
        
        /// <summary>
        /// <b>ID02 - Wrong Identification</b>.
        /// </summary>
        ID02,
        
        /// <summary>
        /// <b>ID03 - Invalid Document Number</b>.
        /// </summary>
        ID03,
        
        /// <summary>
        /// <b>MI01 - Missing Mandatory Information</b>.
        /// </summary>
        MI01,
        
        /// <summary>
        /// <b>NA01 - Narrative</b>.
        /// </summary>
        NA01,
        
        /// <summary>
        /// <b>CA03 - Financing Process Already Initiated</b>.
        /// </summary>
        CA03,
    }
    
    /// <summary>
    /// Class <b>FinancingRateOrAmountChoice</b> (Financing Rate Or Amount Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>DateAndPlaceOfBirth</b> (Date And Place Of Birth).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>PersonIdentification3</b> (Person Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01", IncludeInSchema=false)]
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
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>OrganisationIdentification2</b> (Organisation Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>Party2Choice</b> (Party 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>PartyIdentification8</b> (Party Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>OriginalInvoiceInformation1</b> (Original Invoice Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class OriginalInvoiceInformation1
    {
        
        /// <summary>
        /// Element <b>DocNb</b> (Document Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string DocNb;
        
        /// <summary>
        /// Element <b>TtlInvcAmt</b> (Total Invoice Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount TtlInvcAmt;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime IsseDt;
        
        /// <summary>
        /// Element <b>PmtDueDt</b> (Payment Due Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime PmtDueDt;
    }
    
    /// <summary>
    /// Class <b>InvoiceFinancingDetails1</b> (Invoice Financing Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class InvoiceFinancingDetails1
    {
        
        /// <summary>
        /// Element <b>OrgnlInvcInf</b> (Original Invoice Information) of type OriginalInvoiceInformation1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public OriginalInvoiceInformation1 OrgnlInvcInf;
        
        /// <summary>
        /// Element <b>Spplr</b> (Supplier) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification8 Spplr;
        
        /// <summary>
        /// Element <b>InvcFincgRslt</b> (Invoice Financing Result) of type FinancingResult1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancingResult1 InvcFincgRslt;
        
        /// <summary>
        /// Element <b>InstlmtFincgInf</b> (Instalment Financing Information) of type array of InstalmentFinancingInformation1.
        /// </summary>
        [XmlElementAttribute("InstlmtFincgInf", Order=3)]
        public InstalmentFinancingInformation1[] InstlmtFincgInf;
    }
    
    /// <summary>
    /// Class <b>FinancingDateDetails1</b> (Financing Date Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class FinancingDateDetails1
    {
        
        /// <summary>
        /// Element <b>BookDt</b> (Book Date) of type array of System.DateTime.
        /// </summary>
        [XmlElementAttribute("BookDt", DataType="date", Order=0)]
        public System.DateTime[] BookDt;
        
        /// <summary>
        /// Element <b>CdtDt</b> (Credit Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime CdtDt;
        
        /// <summary>
        /// Element <b>DbtDt</b> (Debit Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime DbtDt;
        
        /// <summary>
        /// Element <b>DbtDtSpecified</b> (Debit Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DbtDtSpecified;
    }
    
    /// <summary>
    /// Class <b>FinancingAllowedSummary1</b> (Financing Allowed Summary 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class FinancingAllowedSummary1
    {
        
        /// <summary>
        /// Element <b>FincdItmNb</b> (Financed Item Number) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal FincdItmNb;
        
        /// <summary>
        /// Element <b>TtlAccptdItmsAmt</b> (Total Accepted Items Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount TtlAccptdItmsAmt;
        
        /// <summary>
        /// Element <b>ApldPctg</b> (Applied Percentage) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal ApldPctg;
        
        /// <summary>
        /// Element <b>ApldPctgSpecified</b> (Applied Percentage Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApldPctgSpecified;
        
        /// <summary>
        /// Element <b>TtlFincdAmt</b> (Total Financed Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount TtlFincdAmt;
        
        /// <summary>
        /// Element <b>FincgDtDtls</b> (Financing Date Details) of type FinancingDateDetails1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancingDateDetails1 FincgDtDtls;
        
        /// <summary>
        /// Element <b>CdtAcct</b> (Credit Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CashAccount7 CdtAcct;
        
        /// <summary>
        /// Element <b>FincgAcct</b> (Financing Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CashAccount7 FincgAcct;
    }
    
    /// <summary>
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    /// Class <b>FinancingInformationAndStatus1</b> (Financing Information And Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class FinancingInformationAndStatus1
    {
        
        /// <summary>
        /// Element <b>FincgAllwdSummry</b> (Financing Allowed Summary) of type FinancingAllowedSummary1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancingAllowedSummary1 FincgAllwdSummry;
        
        /// <summary>
        /// Element <b>InvcFincgDtls</b> (Invoice Financing Details) of type array of InvoiceFinancingDetails1.
        /// </summary>
        [XmlElementAttribute("InvcFincgDtls", Order=1)]
        public InvoiceFinancingDetails1[] InvcFincgDtls;
    }
    
    /// <summary>
    /// Class <b>CancellationStatusInformation1</b> (Cancellation Status Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class CancellationStatusInformation1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type CancellationStatus4Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationStatus4Code Sts;
        
        /// <summary>
        /// Element <b>StsRsn</b> (Status Reason) of type StatusReason4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public StatusReason4Choice StsRsn;
        
        /// <summary>
        /// Element <b>AddtlStsRsnInf</b> (Additional Status Reason Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("AddtlStsRsnInf", Order=2)]
        public string[] AddtlStsRsnInf;
    }
    
    /// <summary>
    /// Enumeration <b>CancellationStatus4Code</b> (Cancellation Status 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public enum CancellationStatus4Code
    {
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>REJT - Rejected</b>.
        /// </summary>
        REJT,
    }
    
    /// <summary>
    /// Class <b>ValidationStatusInformation1</b> (Validation Status Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class ValidationStatusInformation1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type TechnicalValidationStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TechnicalValidationStatus1Code Sts;
        
        /// <summary>
        /// Element <b>StsRsn</b> (Status Reason) of type StatusReason4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public StatusReason4Choice StsRsn;
        
        /// <summary>
        /// Element <b>AddtlStsRsnInf</b> (Additional Status Reason Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("AddtlStsRsnInf", Order=2)]
        public string[] AddtlStsRsnInf;
    }
    
    /// <summary>
    /// Enumeration <b>TechnicalValidationStatus1Code</b> (Technical Validation Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public enum TechnicalValidationStatus1Code
    {
        
        /// <summary>
        /// <b>RCCF - Reception Confirmation</b>.
        /// </summary>
        RCCF,
        
        /// <summary>
        /// <b>RCER - Reception Error</b>.
        /// </summary>
        RCER,
    }
    
    /// <summary>
    /// Class <b>ClearingSystemMemberIdentification2Choice</b> (Clearing System Member Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
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
    
    /// <summary>
    /// Class <b>OriginalRequestInformation1</b> (Original Request Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsin.002.001.01")]
    public class OriginalRequestInformation1
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
        
        /// <summary>
        /// Element <b>FincgRqstr</b> (Financing Requestor) of type PartyIdentificationAndAccount6.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentificationAndAccount6 FincgRqstr;
        
        /// <summary>
        /// Element <b>IntrmyAgt</b> (Intermediary Agent) of type FinancialInstitutionIdentification6.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public FinancialInstitutionIdentification6 IntrmyAgt;
        
        /// <summary>
        /// Element <b>FrstAgt</b> (First Agent) of type FinancialInstitutionIdentification6.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancialInstitutionIdentification6 FrstAgt;
        
        /// <summary>
        /// Element <b>VldtnStsInf</b> (Validation Status Information) of type ValidationStatusInformation1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public ValidationStatusInformation1 VldtnStsInf;
        
        /// <summary>
        /// Element <b>CxlStsInf</b> (Cancellation Status Information) of type CancellationStatusInformation1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CancellationStatusInformation1 CxlStsInf;
    }
}
