
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



namespace i20022.tsmt00200103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.002.001.03 name ActivityReportV03 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>ActvtyRpt</b> (Activity Report) of type ActivityReportV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActivityReportV03 ActvtyRpt;
    }
    
    /// <summary>
    /// Class <b>ActivityReportV03</b> (Activity Report V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
    public class ActivityReportV03
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
        /// Element <b>Rpt</b> (Report) of type array of ActivityReportItems2.
        /// </summary>
        [XmlElementAttribute("Rpt", Order=2)]
        public ActivityReportItems2[] Rpt;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
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
    /// Class <b>Activity1</b> (Activity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
    public class Activity1
    {
        
        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MsgNm;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Class <b>ActivityDetails1</b> (Activity Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
    public class ActivityDetails1
    {
        
        /// <summary>
        /// Element <b>DtTm</b> (Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public System.DateTime DtTm;
        
        /// <summary>
        /// Element <b>Actvty</b> (Activity) of type Activity1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Activity1 Actvty;
        
        /// <summary>
        /// Element <b>Initr</b> (Initiator) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public BICIdentification1 Initr;
    }
    
    /// <summary>
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
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
    /// Class <b>ActivityReportItems2</b> (Activity Report Items 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.03")]
    public class ActivityReportItems2
    {
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TxId;
        
        /// <summary>
        /// Element <b>UsrTxRef</b> (User Transaction Reference) of type array of DocumentIdentification5.
        /// </summary>
        [XmlElementAttribute("UsrTxRef", Order=1)]
        public DocumentIdentification5[] UsrTxRef;
        
        /// <summary>
        /// Element <b>RptdNtty</b> (Reported Entity) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public BICIdentification1 RptdNtty;
        
        /// <summary>
        /// Element <b>RptdItm</b> (Reported Item) of type array of ActivityDetails1.
        /// </summary>
        [XmlElementAttribute("RptdItm", Order=3)]
        public ActivityDetails1[] RptdItm;
        
        /// <summary>
        /// Element <b>PdgReqForActn</b> (Pending Request For Action) of type array of PendingActivity2.
        /// </summary>
        [XmlElementAttribute("PdgReqForActn", Order=4)]
        public PendingActivity2[] PdgReqForActn;
    }
}
