
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



namespace i20022.setr01700102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id setr.017.001.02 name OrderCancellationStatusReportV02 from Securities Trade business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>setr01700102</b> (setr 01700102) of type setr01700102.
        /// </summary>
        [XmlElementAttribute("setr.017.001.02", Order=0)]
        public setr01700102 setr01700102;
    }
    
    /// <summary>
    /// Class <b>setr01700102</b> (setr 01700102).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="setr.017.001.02", Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
    public class setr01700102
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute("OthrRef", typeof(AdditionalReference3), Order=0)]
        [XmlElementAttribute("RltdRef", typeof(AdditionalReference3), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public AdditionalReference3[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>CxlStsRpt</b> (Cancellation Status Report) of type OrderStatusAndReason4.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public OrderStatusAndReason4 CxlStsRpt;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
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
    /// Class <b>RejectedStatusReason4</b> (Rejected Status Reason 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
    public class RejectedStatusReason4
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type RejectedStatusReason4Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RejectedStatusReason4Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>RejectedStatusReason4Code</b> (Rejected Status Reason 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
    public enum RejectedStatusReason4Code
    {
        
        /// <summary>
        /// <b>CUTO - Cut Off Time</b>.
        /// </summary>
        CUTO,
        
        /// <summary>
        /// <b>NALC - Not Allowed To Cancel</b>.
        /// </summary>
        NALC,
        
        /// <summary>
        /// <b>NSLA - Not Compliant With SLA</b>.
        /// </summary>
        NSLA,
        
        /// <summary>
        /// <b>LEGL - Legal Decision</b>.
        /// </summary>
        LEGL,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>RejectedStatus4</b> (Rejected Status 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
    public class RejectedStatus4
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type RejectedStatusReason4 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(RejectedStatusReason4), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
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
    /// Class <b>OrderStatusAndReason4</b> (Order Status And Reason 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
    public class OrderStatusAndReason4
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Rjctd (Rejected) of type RejectedStatus4 
        /// Sts (Status) of type OrderStatus3Code 
        /// </summary>
        [XmlElementAttribute("Rjctd", typeof(RejectedStatus4), Order=0)]
        [XmlElementAttribute("Sts", typeof(OrderStatus3Code), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice StsInitr;
    }
    
    /// <summary>
    /// Enumeration <b>OrderStatus3Code</b> (Order Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02")]
    public enum OrderStatus3Code
    {
        
        /// <summary>
        /// <b>STNP - Sent To Next Party</b>.
        /// </summary>
        STNP,
        
        /// <summary>
        /// <b>CANP - Pending</b>.
        /// </summary>
        CANP,
        
        /// <summary>
        /// <b>CAND - Complete</b>.
        /// </summary>
        CAND,
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:setr.017.001.02", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <summary>
        /// <b>OthrRef - Other Reference</b>.
        /// </summary>
        OthrRef,
        
        /// <summary>
        /// <b>RltdRef - Related Reference</b>.
        /// </summary>
        RltdRef,
    }
}
