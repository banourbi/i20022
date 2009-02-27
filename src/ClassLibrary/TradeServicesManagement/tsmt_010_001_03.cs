
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



namespace i20022.tsmt01000103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.010.001.03 name BaselineMatchReportV03 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>BaselnMtchRpt</b> (Baseline Match Report) of type BaselineMatchReportV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public BaselineMatchReportV03 BaselnMtchRpt;
    }
    
    /// <summary>
    /// Class <b>BaselineMatchReportV03</b> (Baseline Match Report V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class BaselineMatchReportV03
    {
        
        /// <summary>
        /// Element <b>RptId</b> (Report Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 RptId;
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SimpleIdentificationInformation TxId;
        
        /// <summary>
        /// Element <b>EstblishdBaselnId</b> (Established Baseline Identification) of type DocumentIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DocumentIdentification3 EstblishdBaselnId;
        
        /// <summary>
        /// Element <b>TxSts</b> (Transaction Status) of type TransactionStatus4.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public TransactionStatus4 TxSts;
        
        /// <summary>
        /// Element <b>UsrTxRef</b> (User Transaction Reference) of type array of DocumentIdentification5.
        /// </summary>
        [XmlElementAttribute("UsrTxRef", Order=4)]
        public DocumentIdentification5[] UsrTxRef;
        
        /// <summary>
        /// Element <b>Buyr</b> (Buyer) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification26 Buyr;
        
        /// <summary>
        /// Element <b>Sellr</b> (Seller) of type PartyIdentification26.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification26 Sellr;
        
        /// <summary>
        /// Element <b>BuyrBk</b> (Buyer Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public BICIdentification1 BuyrBk;
        
        /// <summary>
        /// Element <b>SellrBk</b> (Seller Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BICIdentification1 SellrBk;
        
        /// <summary>
        /// Element <b>BaselnEstblishmtTrils</b> (Baseline Establishment Trials) of type Limit1.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public Limit1 BaselnEstblishmtTrils;
        
        /// <summary>
        /// Element <b>CmpardDocRef</b> (Compared Document Reference) of type array of DocumentIdentification4.
        /// </summary>
        [XmlElementAttribute("CmpardDocRef", Order=10)]
        public DocumentIdentification4[] CmpardDocRef;
        
        /// <summary>
        /// Element <b>Rpt</b> (Report) of type MisMatchReport3.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public MisMatchReport3 Rpt;
        
        /// <summary>
        /// Element <b>ReqForActn</b> (Request For Action) of type PendingActivity2.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public PendingActivity2 ReqForActn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
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
    /// Class <b>PendingActivity2</b> (Pending Activity 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class PendingActivity2
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type Action2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Action2Code Tp;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Enumeration <b>Action2Code</b> (Action 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public enum Action2Code
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
        
        /// <summary>
        /// <b>ARRO - Accept Or Reject Baseline And Role</b>.
        /// </summary>
        ARRO,
        
        /// <summary>
        /// <b>CINR - Check Invoice Reference</b>.
        /// </summary>
        CINR,
    }
    
    /// <summary>
    /// Class <b>ElementIdentification1</b> (Element Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class ElementIdentification1
    {
        
        /// <summary>
        /// Element <b>DocIndx</b> (Document Index) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string DocIndx;
        
        /// <summary>
        /// Element <b>ElmtPth</b> (Element Path) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string ElmtPth;
        
        /// <summary>
        /// Element <b>ElmtNm</b> (Element Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ElmtNm;
        
        /// <summary>
        /// Element <b>ElmtVal</b> (Element Value) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string ElmtVal;
    }
    
    /// <summary>
    /// Class <b>ValidationResult5</b> (Validation Result 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class ValidationResult5
    {
        
        /// <summary>
        /// Element <b>SeqNb</b> (Sequence Number) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal SeqNb;
        
        /// <summary>
        /// Element <b>RuleId</b> (Rule Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string RuleId;
        
        /// <summary>
        /// Element <b>RuleDesc</b> (Rule Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string RuleDesc;
        
        /// <summary>
        /// Element <b>MisMtchdElmt</b> (Mis Matched Element) of type array of ElementIdentification1.
        /// </summary>
        [XmlElementAttribute("MisMtchdElmt", Order=3)]
        public ElementIdentification1[] MisMtchdElmt;
    }
    
    /// <summary>
    /// Class <b>MisMatchReport3</b> (Mis Match Report 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class MisMatchReport3
    {
        
        /// <summary>
        /// Element <b>NbOfMisMtchs</b> (Number Of Mis Matches) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal NbOfMisMtchs;
        
        /// <summary>
        /// Element <b>MisMtchInf</b> (Mis Match Information) of type array of ValidationResult5.
        /// </summary>
        [XmlElementAttribute("MisMtchInf", Order=1)]
        public ValidationResult5[] MisMtchInf;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification4</b> (Document Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class DocumentIdentification4
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
        
        /// <summary>
        /// Element <b>DocIndx</b> (Document Index) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DocIndx;
    }
    
    /// <summary>
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>Limit1</b> (Limit 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class Limit1
    {
        
        /// <summary>
        /// Element <b>Cur</b> (Current) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Cur;
        
        /// <summary>
        /// Element <b>Lmt</b> (Limit) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Lmt;
    }
    
    /// <summary>
    /// Class <b>PostalAddress5</b> (Postal Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
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
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
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
    /// Class <b>PartyIdentification26</b> (Party Identification 26).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
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
    /// Class <b>DocumentIdentification5</b> (Document Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class DocumentIdentification5
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdIssr</b> (Identification Issuer) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BICIdentification1 IdIssr;
    }
    
    /// <summary>
    /// Class <b>TransactionStatus4</b> (Transaction Status 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
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
    /// Class <b>DocumentIdentification3</b> (Document Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class DocumentIdentification3
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
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.010.001.03")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
}
