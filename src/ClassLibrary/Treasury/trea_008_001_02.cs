
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



namespace i20022.trea00800102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id trea.008.001.02 name StatusNotificationV02 from Treasury business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.008.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.008.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>trea00800102</b> (trea 00800102) of type trea00800102.
        /// </summary>
        [XmlElementAttribute("trea.008.001.02", Order=0)]
        public trea00800102 trea00800102;
    }
    
    /// <summary>
    /// Class <b>trea00800102</b> (trea 00800102).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="trea.008.001.02", Namespace="urn:iso:std:iso:20022:tech:xsd:trea.008.001.02")]
    public class trea00800102
    {
        
        /// <summary>
        /// Element <b>TradData</b> (Trade Data) of type TradeData1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TradeData1 TradData;
    }
    
    /// <summary>
    /// Class <b>TradeData1</b> (Trade Data 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.008.001.02")]
    public class TradeData1
    {
        
        /// <summary>
        /// Element <b>NtfctnId</b> (Notification Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string NtfctnId;
        
        /// <summary>
        /// Element <b>MtchgSysUnqRef</b> (Matching System Unique Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string MtchgSysUnqRef;
        
        /// <summary>
        /// Element <b>StsOrgtr</b> (Status Originator) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StsOrgtr;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CurSts (Current Status) of type TradeStatus1Code 
        /// XtndedCurSts (Extended Current Status) of type string 
        /// </summary>
        [XmlElementAttribute("CurSts", typeof(TradeStatus1Code), Order=3)]
        [XmlElementAttribute("XtndedCurSts", typeof(string), Order=3)]
        public object Item;
        
        /// <summary>
        /// Element <b>CurStsSubTp</b> (Current Status Sub Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string CurStsSubTp;
        
        /// <summary>
        /// Element <b>CurStsTm</b> (Current Status Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public System.DateTime CurStsTm;
        
        /// <summary>
        /// Element <b>CurStsTmSpecified</b> (Current Status Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurStsTmSpecified;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// PrvsSts (Previous Status) of type TradeStatus1Code 
        /// XtndedPrvsSts (Extended Previous Status) of type string 
        /// </summary>
        [XmlElementAttribute("PrvsSts", typeof(TradeStatus1Code), Order=6)]
        [XmlElementAttribute("XtndedPrvsSts", typeof(string), Order=6)]
        public object Item1;
        
        /// <summary>
        /// Element <b>PrvsStsSubTp</b> (Previous Status Sub Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string PrvsStsSubTp;
        
        /// <summary>
        /// Element <b>PrvsStsTm</b> (Previous Status Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public System.DateTime PrvsStsTm;
        
        /// <summary>
        /// Element <b>PrvsStsTmSpecified</b> (Previous Status Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrvsStsTmSpecified;
        
        /// <summary>
        /// Element <b>PdctTp</b> (Product Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string PdctTp;
    }
    
    /// <summary>
    /// Enumeration <b>TradeStatus1Code</b> (Trade Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:trea.008.001.02")]
    public enum TradeStatus1Code
    {
        
        /// <summary>
        /// <b>INVA - Invalid</b>.
        /// </summary>
        INVA,
        
        /// <summary>
        /// <b>VALI - Entitled</b>.
        /// </summary>
        VALI,
        
        /// <summary>
        /// <b>REGC - Regulatory Checked</b>.
        /// </summary>
        REGC,
        
        /// <summary>
        /// <b>UMTC - Unmatched</b>.
        /// </summary>
        UMTC,
        
        /// <summary>
        /// <b>VMTC - Matched Valued</b>.
        /// </summary>
        VMTC,
        
        /// <summary>
        /// <b>RSCD - Rescinded</b>.
        /// </summary>
        RSCD,
        
        /// <summary>
        /// <b>STLD - Settled</b>.
        /// </summary>
        STLD,
        
        /// <summary>
        /// <b>PSTL - Partially Settled</b>.
        /// </summary>
        PSTL,
        
        /// <summary>
        /// <b>REGS - Regulatory Suspended / Regulation S Exchange</b>.
        /// </summary>
        REGS,
        
        /// <summary>
        /// <b>FMTC - Matched</b>.
        /// </summary>
        FMTC,
        
        /// <summary>
        /// <b>SRJC - Settlement Rejected</b>.
        /// </summary>
        SRJC,
        
        /// <summary>
        /// <b>RJCT - Payment Rejected</b>.
        /// </summary>
        RJCT,
        
        /// <summary>
        /// <b>OPMA - Option Mature</b>.
        /// </summary>
        OPMA,
    }
}
