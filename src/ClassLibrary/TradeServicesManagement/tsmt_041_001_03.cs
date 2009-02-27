
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



namespace i20022.tsmt04100103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.041.001.03 name TransactionReportV03 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>TxRpt</b> (Transaction Report) of type TransactionReportV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TransactionReportV03 TxRpt;
    }
    
    /// <summary>
    /// Class <b>TransactionReportV03</b> (Transaction Report V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
    public class TransactionReportV03
    {
        
        /// <summary>
        /// Element <b>RptId</b> (Report Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 RptId;
        
        /// <summary>
        /// Element <b>RltdMsgRef</b> (Related Message Reference) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public MessageIdentification1 RltdMsgRef;
        
        /// <summary>
        /// Element <b>RptdItms</b> (Reported Items) of type array of TransactionReportItems3.
        /// </summary>
        [XmlElementAttribute("RptdItms", Order=2)]
        public TransactionReportItems3[] RptdItms;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    /// Class <b>PostalAddress5</b> (Postal Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification5</b> (Document Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
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
    /// Class <b>TransactionReportItems3</b> (Transaction Report Items 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.041.001.03")]
    public class TransactionReportItems3
    {
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TxId;
        
        /// <summary>
        /// Element <b>EstblishdBaselnId</b> (Established Baseline Identification) of type DocumentIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentIdentification3 EstblishdBaselnId;
        
        /// <summary>
        /// Element <b>TxSts</b> (Transaction Status) of type TransactionStatus4.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TransactionStatus4 TxSts;
        
        /// <summary>
        /// Element <b>UsrTxRef</b> (User Transaction Reference) of type array of DocumentIdentification5.
        /// </summary>
        [XmlElementAttribute("UsrTxRef", Order=3)]
        public DocumentIdentification5[] UsrTxRef;
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DocumentIdentification7 PurchsOrdrRef;
        
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
        /// Element <b>BuyrBkCtry</b> (Buyer Bank Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string BuyrBkCtry;
        
        /// <summary>
        /// Element <b>SellrBk</b> (Seller Bank) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public BICIdentification1 SellrBk;
        
        /// <summary>
        /// Element <b>SellrBkCtry</b> (Seller Bank Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string SellrBkCtry;
        
        /// <summary>
        /// Element <b>OblgrBk</b> (Obligor Bank) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("OblgrBk", Order=11)]
        public BICIdentification1[] OblgrBk;
        
        /// <summary>
        /// Element <b>SubmitgBk</b> (Submitting Bank) of type array of BICIdentification1.
        /// </summary>
        [XmlElementAttribute("SubmitgBk", Order=12)]
        public BICIdentification1[] SubmitgBk;
        
        /// <summary>
        /// Element <b>OutsdngAmt</b> (Outstanding Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public CurrencyAndAmount OutsdngAmt;
        
        /// <summary>
        /// Element <b>TtlNetAmt</b> (Total Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public CurrencyAndAmount TtlNetAmt;
        
        /// <summary>
        /// Element <b>PdgReqForActn</b> (Pending Request For Action) of type array of PendingActivity2.
        /// </summary>
        [XmlElementAttribute("PdgReqForActn", Order=15)]
        public PendingActivity2[] PdgReqForActn;
    }
}
