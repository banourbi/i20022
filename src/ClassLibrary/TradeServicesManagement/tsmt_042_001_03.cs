
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



namespace i20022.tsmt04200103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.042.001.03 name TransactionReportRequestV03 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>TxRptReq</b> (Transaction Report Request) of type TransactionReportRequestV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TransactionReportRequestV03 TxRptReq;
    }
    
    /// <summary>
    /// Class <b>TransactionReportRequestV03</b> (Transaction Report Request V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public class TransactionReportRequestV03
    {
        
        /// <summary>
        /// Element <b>ReqId</b> (Request Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 ReqId;
        
        /// <summary>
        /// Element <b>RptSpcfctn</b> (Report Specification) of type ReportSpecification4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ReportSpecification4 RptSpcfctn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
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
    /// Class <b>PendingActivity1</b> (Pending Activity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public class PendingActivity1
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type Action1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Action1Code Tp;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Enumeration <b>Action1Code</b> (Action 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public enum Action1Code
    {
        
        /// <summary>
        /// <b>SBTW - Submit Twin</b>.
        /// </summary>
        SBTW,
        
        /// <summary>
        /// <b>RSTW - Re Submit Twin</b>.
        /// </summary>
        RSTW,
        
        /// <summary>
        /// <b>RSBS - Re Submit Baseline</b>.
        /// </summary>
        RSBS,
        
        /// <summary>
        /// <b>ARDM - Accept Or Reject Data Set Mis Matches</b>.
        /// </summary>
        ARDM,
        
        /// <summary>
        /// <b>ARCS - Accept Or Reject Change Of Status</b>.
        /// </summary>
        ARCS,
        
        /// <summary>
        /// <b>ARES - Accept Or Reject Extension Of Status</b>.
        /// </summary>
        ARES,
        
        /// <summary>
        /// <b>WAIT - Wait For Baseline Established</b>.
        /// </summary>
        WAIT,
        
        /// <summary>
        /// <b>UPDT - Update And Resend</b>.
        /// </summary>
        UPDT,
        
        /// <summary>
        /// <b>SBDS - Submit Data Set</b>.
        /// </summary>
        SBDS,
        
        /// <summary>
        /// <b>ARBA - Accept Or Reject Baseline Amendment</b>.
        /// </summary>
        ARBA,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
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
    /// Class <b>PartyIdentification28</b> (Party Identification 28).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public class PartyIdentification28
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
    }
    
    /// <summary>
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>TransactionStatus4</b> (Transaction Status 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public class TransactionStatus4
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type BaselineStatus3Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public BaselineStatus3Code Sts;
    }
    
    /// <summary>
    /// Enumeration <b>BaselineStatus3Code</b> (Baseline Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public enum BaselineStatus3Code
    {
        
        /// <summary>
        /// <b>PROP - Proposed</b>.
        /// </summary>
        PROP,
        
        /// <summary>
        /// <b>CLSD - Closed</b>.
        /// </summary>
        CLSD,
        
        /// <summary>
        /// <b>PMTC - Partially Matched</b>.
        /// </summary>
        PMTC,
        
        /// <summary>
        /// <b>ESTD - Established</b>.
        /// </summary>
        ESTD,
        
        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
        
        /// <summary>
        /// <b>AMRQ - Amendment Requested</b>.
        /// </summary>
        AMRQ,
        
        /// <summary>
        /// <b>RARQ - Re Activate Requested</b>.
        /// </summary>
        RARQ,
        
        /// <summary>
        /// <b>CLRQ - Close Requested</b>.
        /// </summary>
        CLRQ,
        
        /// <summary>
        /// <b>SCRQ - Complete Requested</b>.
        /// </summary>
        SCRQ,
        
        /// <summary>
        /// <b>SERQ - Status Extension Requested</b>.
        /// </summary>
        SERQ,
        
        /// <summary>
        /// <b>DARQ - Data Set Acceptance Requested</b>.
        /// </summary>
        DARQ,
    }
    
    /// <summary>
    /// Class <b>ReportSpecification4</b> (Report Specification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.042.001.03")]
    public class ReportSpecification4
    {
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type array of string.
        /// </summary>
        [XmlElementAttribute("TxId", Order=0)]
        public string[] TxId;
        
        /// <summary>
        /// Element <b>TxSts</b> (Transaction Status) of type array of TransactionStatus4.
        /// </summary>
        [XmlElementAttribute("TxSts", Order=1)]
        public TransactionStatus4[] TxSts;
        
        /// <summary>
        /// Element <b>SubmitrTxRef</b> (Submitter Transaction Reference) of type array of string.
        /// </summary>
        [XmlElementAttribute("SubmitrTxRef", Order=2)]
        public string[] SubmitrTxRef;
        
        /// <summary>
        /// Element <b>NttiesToBeRptd</b> (Entities To Be Reported) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("NttiesToBeRptd", Order=3)]
        public BICIdentification1[] NttiesToBeRptd;
        
        /// <summary>
        /// Element <b>Crspdt</b> (Correspondent) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("Crspdt", Order=4)]
        public BICIdentification1[] Crspdt;
        
        /// <summary>
        /// Element <b>SubmitgBk</b> (Submitting Bank) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("SubmitgBk", Order=5)]
        public BICIdentification1[] SubmitgBk;
        
        /// <summary>
        /// Element <b>OblgrBk</b> (Obligor Bank) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("OblgrBk", Order=6)]
        public BICIdentification1[] OblgrBk;
        
        /// <summary>
        /// Element <b>Buyr</b> (Buyer) of type array of PartyIdentification28.
        /// </summary>
        [XmlElementAttribute("Buyr", Order=7)]
        public PartyIdentification28[] Buyr;
        
        /// <summary>
        /// Element <b>Sellr</b> (Seller) of type array of PartyIdentification28.
        /// </summary>
        [XmlElementAttribute("Sellr", Order=8)]
        public PartyIdentification28[] Sellr;
        
        /// <summary>
        /// Element <b>BuyrCtry</b> (Buyer Country) of type array of string.
        /// </summary>
        [XmlElementAttribute("BuyrCtry", Order=9)]
        public string[] BuyrCtry;
        
        /// <summary>
        /// Element <b>SellrCtry</b> (Seller Country) of type array of string.
        /// </summary>
        [XmlElementAttribute("SellrCtry", Order=10)]
        public string[] SellrCtry;
        
        /// <summary>
        /// Element <b>CrspdtCtry</b> (Correspondent Country) of type array of string.
        /// </summary>
        [XmlElementAttribute("CrspdtCtry", Order=11)]
        public string[] CrspdtCtry;
        
        /// <summary>
        /// Element <b>PdgReqForActn</b> (Pending Request For Action) of type array of PendingActivity1.
        /// </summary>
        [XmlElementAttribute("PdgReqForActn", Order=12)]
        public PendingActivity1[] PdgReqForActn;
    }
}
