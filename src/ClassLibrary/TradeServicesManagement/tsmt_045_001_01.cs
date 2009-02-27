
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



namespace i20022.tsmt04500101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.045.001.01 name ForwardIntentToPayNotificationV01 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>FwdInttToPayNtfctn</b> (Forward Intent To Pay Notification) of type ForwardIntentToPayNotificationV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ForwardIntentToPayNotificationV01 FwdInttToPayNtfctn;
    }
    
    /// <summary>
    /// Class <b>ForwardIntentToPayNotificationV01</b> (Forward Intent To Pay Notification V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class ForwardIntentToPayNotificationV01
    {
        
        /// <summary>
        /// Element <b>NtfctnId</b> (Notification Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 NtfctnId;
        
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
        /// Element <b>InttToPay</b> (Intent To Pay) of type IntentToPay1.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public IntentToPay1 InttToPay;
        
        /// <summary>
        /// Element <b>ReqForActn</b> (Request For Action) of type PendingActivity2.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public PendingActivity2 ReqForActn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>CashAccountType2</b> (Cash Account Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class SimpleIdentificationInformation2
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification3Choice</b> (Account Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01", IncludeInSchema=false)]
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
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>PostalAddress2</b> (Postal Address 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>NameAndAddress6</b> (Name And Address 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>FinancialInstitutionIdentification4Choice</b> (Financial Institution Identification 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>SettlementTerms2</b> (Settlement Terms 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>ReportLine2</b> (Report Line 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class ReportLine2
    {
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TxId;
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentIdentification7 PurchsOrdrRef;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type array of Adjustment4.
        /// </summary>
        [XmlElementAttribute("Adjstmnt", Order=2)]
        public Adjustment4[] Adjstmnt;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CurrencyAndAmount NetAmt;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification7</b> (Document Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>Adjustment4</b> (Adjustment 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class Adjustment4
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
        /// Element <b>Drctn</b> (Direction) of type AdjustmentDirection1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdjustmentDirection1Code Drctn;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Enumeration <b>AdjustmentType2Code</b> (Adjustment Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    /// Class <b>InvoiceIdentification1</b> (Invoice Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class InvoiceIdentification1
    {
        
        /// <summary>
        /// Element <b>InvcNb</b> (Invoice Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string InvcNb;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime IsseDt;
    }
    
    /// <summary>
    /// Class <b>ReportLine4</b> (Report Line 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class ReportLine4
    {
        
        /// <summary>
        /// Element <b>ComrclDocRef</b> (Commercial Document Reference) of type InvoiceIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvoiceIdentification1 ComrclDocRef;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type array of Adjustment4.
        /// </summary>
        [XmlElementAttribute("Adjstmnt", Order=1)]
        public Adjustment4[] Adjstmnt;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount NetAmt;
        
        /// <summary>
        /// Element <b>BrkdwnByPurchsOrdr</b> (Breakdown By Purchase Order) of type array of ReportLine2.
        /// </summary>
        [XmlElementAttribute("BrkdwnByPurchsOrdr", Order=3)]
        public ReportLine2[] BrkdwnByPurchsOrdr;
    }
    
    /// <summary>
    /// Class <b>ReportLine3</b> (Report Line 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class ReportLine3
    {
        
        /// <summary>
        /// Element <b>PurchsOrdrRef</b> (Purchase Order Reference) of type DocumentIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification7 PurchsOrdrRef;
        
        /// <summary>
        /// Element <b>Adjstmnt</b> (Adjustment) of type array of Adjustment4.
        /// </summary>
        [XmlElementAttribute("Adjstmnt", Order=1)]
        public Adjustment4[] Adjstmnt;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount NetAmt;
    }
    
    /// <summary>
    /// Class <b>IntentToPay1</b> (Intent To Pay 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class IntentToPay1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ByComrclInvc (By Commercial Invoice) of type ReportLine4 
        /// ByPurchsOrdr (By Purchase Order) of type ReportLine3 
        /// </summary>
        [XmlElementAttribute("ByComrclInvc", typeof(ReportLine4), Order=0)]
        [XmlElementAttribute("ByPurchsOrdr", typeof(ReportLine3), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>XpctdPmtDt</b> (Expected Payment Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime XpctdPmtDt;
        
        /// <summary>
        /// Element <b>SttlmTerms</b> (Settlement Terms) of type SettlementTerms2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public SettlementTerms2 SttlmTerms;
    }
    
    /// <summary>
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.045.001.01")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
}
