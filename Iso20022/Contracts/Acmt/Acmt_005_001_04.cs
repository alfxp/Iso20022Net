﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Iso20022.Contracts.AcmtM005V00104 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04", IsNullable=false)]
    public partial class Document {
        
        private RequestForAccountManagementStatusReportV04 reqForAcctMgmtStsRptField;
        
        /// <remarks/>
        public RequestForAccountManagementStatusReportV04 ReqForAcctMgmtStsRpt {
            get {
                return this.reqForAcctMgmtStsRptField;
            }
            set {
                this.reqForAcctMgmtStsRptField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class RequestForAccountManagementStatusReportV04 {
        
        private MessageIdentification1 msgIdField;
        
        private AccountManagementMessageReference3 reqDtlsField;
        
        /// <remarks/>
        public MessageIdentification1 MsgId {
            get {
                return this.msgIdField;
            }
            set {
                this.msgIdField = value;
            }
        }
        
        /// <remarks/>
        public AccountManagementMessageReference3 ReqDtls {
            get {
                return this.reqDtlsField;
            }
            set {
                this.reqDtlsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class MessageIdentification1 {
        
        private string idField;
        
        private System.DateTime creDtTmField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreDtTm {
            get {
                return this.creDtTmField;
            }
            set {
                this.creDtTmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class PartyIdentification70Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification1))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class NameAndAddress5 {
        
        private string nmField;
        
        private PostalAddress1 adrField;
        
        /// <remarks/>
        public string Nm {
            get {
                return this.nmField;
            }
            set {
                this.nmField = value;
            }
        }
        
        /// <remarks/>
        public PostalAddress1 Adr {
            get {
                return this.adrField;
            }
            set {
                this.adrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class PostalAddress1 {
        
        private AddressType2Code adrTpField;
        
        private bool adrTpFieldSpecified;
        
        private string[] adrLineField;
        
        private string strtNmField;
        
        private string bldgNbField;
        
        private string pstCdField;
        
        private string twnNmField;
        
        private string ctrySubDvsnField;
        
        private string ctryField;
        
        /// <remarks/>
        public AddressType2Code AdrTp {
            get {
                return this.adrTpField;
            }
            set {
                this.adrTpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified {
            get {
                return this.adrTpFieldSpecified;
            }
            set {
                this.adrTpFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public string[] AdrLine {
            get {
                return this.adrLineField;
            }
            set {
                this.adrLineField = value;
            }
        }
        
        /// <remarks/>
        public string StrtNm {
            get {
                return this.strtNmField;
            }
            set {
                this.strtNmField = value;
            }
        }
        
        /// <remarks/>
        public string BldgNb {
            get {
                return this.bldgNbField;
            }
            set {
                this.bldgNbField = value;
            }
        }
        
        /// <remarks/>
        public string PstCd {
            get {
                return this.pstCdField;
            }
            set {
                this.pstCdField = value;
            }
        }
        
        /// <remarks/>
        public string TwnNm {
            get {
                return this.twnNmField;
            }
            set {
                this.twnNmField = value;
            }
        }
        
        /// <remarks/>
        public string CtrySubDvsn {
            get {
                return this.ctrySubDvsnField;
            }
            set {
                this.ctrySubDvsnField = value;
            }
        }
        
        /// <remarks/>
        public string Ctry {
            get {
                return this.ctryField;
            }
            set {
                this.ctryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public enum AddressType2Code {
        
        /// <remarks/>
        ADDR,
        
        /// <remarks/>
        PBOX,
        
        /// <remarks/>
        HOME,
        
        /// <remarks/>
        BIZZ,
        
        /// <remarks/>
        MLTO,
        
        /// <remarks/>
        DLVY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class GenericIdentification1 {
        
        private string idField;
        
        private string schmeNmField;
        
        private string issrField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string SchmeNm {
            get {
                return this.schmeNmField;
            }
            set {
                this.schmeNmField = value;
            }
        }
        
        /// <remarks/>
        public string Issr {
            get {
                return this.issrField;
            }
            set {
                this.issrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class PartyIdentification95 {
        
        private PartyIdentification70Choice idField;
        
        private string lglNttyIdrField;
        
        /// <remarks/>
        public PartyIdentification70Choice Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string LglNttyIdr {
            get {
                return this.lglNttyIdrField;
            }
            set {
                this.lglNttyIdrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class IndividualPerson30 {
        
        private string gvnNmField;
        
        private string mddlNmField;
        
        private string nmField;
        
        private GenderCode gndrField;
        
        private bool gndrFieldSpecified;
        
        private System.DateTime birthDtField;
        
        private bool birthDtFieldSpecified;
        
        /// <remarks/>
        public string GvnNm {
            get {
                return this.gvnNmField;
            }
            set {
                this.gvnNmField = value;
            }
        }
        
        /// <remarks/>
        public string MddlNm {
            get {
                return this.mddlNmField;
            }
            set {
                this.mddlNmField = value;
            }
        }
        
        /// <remarks/>
        public string Nm {
            get {
                return this.nmField;
            }
            set {
                this.nmField = value;
            }
        }
        
        /// <remarks/>
        public GenderCode Gndr {
            get {
                return this.gndrField;
            }
            set {
                this.gndrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GndrSpecified {
            get {
                return this.gndrFieldSpecified;
            }
            set {
                this.gndrFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime BirthDt {
            get {
                return this.birthDtField;
            }
            set {
                this.birthDtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDtSpecified {
            get {
                return this.birthDtFieldSpecified;
            }
            set {
                this.birthDtFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public enum GenderCode {
        
        /// <remarks/>
        MALE,
        
        /// <remarks/>
        FEMA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class GenericIdentification47 {
        
        private string idField;
        
        private string issrField;
        
        private string schmeNmField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Issr {
            get {
                return this.issrField;
            }
            set {
                this.issrField = value;
            }
        }
        
        /// <remarks/>
        public string SchmeNm {
            get {
                return this.schmeNmField;
            }
            set {
                this.schmeNmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class OtherIdentification3Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(PartyIdentificationType7Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification47))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public enum PartyIdentificationType7Code {
        
        /// <remarks/>
        ATIN,
        
        /// <remarks/>
        IDCD,
        
        /// <remarks/>
        NRIN,
        
        /// <remarks/>
        OTHR,
        
        /// <remarks/>
        PASS,
        
        /// <remarks/>
        POCD,
        
        /// <remarks/>
        SOCS,
        
        /// <remarks/>
        SRSA,
        
        /// <remarks/>
        GUNL,
        
        /// <remarks/>
        GTIN,
        
        /// <remarks/>
        ITIN,
        
        /// <remarks/>
        CPFA,
        
        /// <remarks/>
        AREG,
        
        /// <remarks/>
        DRLC,
        
        /// <remarks/>
        EMID,
        
        /// <remarks/>
        NINV,
        
        /// <remarks/>
        INCL,
        
        /// <remarks/>
        GIIN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class GenericIdentification81 {
        
        private string idField;
        
        private OtherIdentification3Choice idTpField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public OtherIdentification3Choice IdTp {
            get {
                return this.idTpField;
            }
            set {
                this.idTpField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class IndividualPersonIdentification2Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdNb", typeof(GenericIdentification81))]
        [System.Xml.Serialization.XmlElementAttribute("PrsnNm", typeof(IndividualPerson30))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class OwnerIdentification2Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndvOwnrId", typeof(IndividualPersonIdentification2Choice))]
        [System.Xml.Serialization.XmlElementAttribute("OrgOwnrId", typeof(PartyIdentification95))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class InvestmentAccount53 {
        
        private string acctIdField;
        
        private string acctNmField;
        
        private string acctDsgntField;
        
        private OwnerIdentification2Choice ownrIdField;
        
        private PartyIdentification70Choice acctSvcrField;
        
        /// <remarks/>
        public string AcctId {
            get {
                return this.acctIdField;
            }
            set {
                this.acctIdField = value;
            }
        }
        
        /// <remarks/>
        public string AcctNm {
            get {
                return this.acctNmField;
            }
            set {
                this.acctNmField = value;
            }
        }
        
        /// <remarks/>
        public string AcctDsgnt {
            get {
                return this.acctDsgntField;
            }
            set {
                this.acctDsgntField = value;
            }
        }
        
        /// <remarks/>
        public OwnerIdentification2Choice OwnrId {
            get {
                return this.ownrIdField;
            }
            set {
                this.ownrIdField = value;
            }
        }
        
        /// <remarks/>
        public PartyIdentification70Choice AcctSvcr {
            get {
                return this.acctSvcrField;
            }
            set {
                this.acctSvcrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class PartyIdentification90Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification1))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class AdditionalReference6 {
        
        private string refField;
        
        private PartyIdentification90Choice refIssrField;
        
        private string msgNmField;
        
        /// <remarks/>
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
        
        /// <remarks/>
        public PartyIdentification90Choice RefIssr {
            get {
                return this.refIssrField;
            }
            set {
                this.refIssrField = value;
            }
        }
        
        /// <remarks/>
        public string MsgNm {
            get {
                return this.msgNmField;
            }
            set {
                this.msgNmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class LinkedMessage3Choice {
        
        private AdditionalReference6 itemField;
        
        private ItemChoiceType itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OthrRef", typeof(AdditionalReference6))]
        [System.Xml.Serialization.XmlElementAttribute("PrvsRef", typeof(AdditionalReference6))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public AdditionalReference6 Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        OthrRef,
        
        /// <remarks/>
        PrvsRef,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public partial class AccountManagementMessageReference3 {
        
        private LinkedMessage3Choice lkdRefField;
        
        private AccountManagementType1Code stsReqTpField;
        
        private string acctApplIdField;
        
        private string exstgAcctIdField;
        
        private InvestmentAccount53 invstmtAcctField;
        
        /// <remarks/>
        public LinkedMessage3Choice LkdRef {
            get {
                return this.lkdRefField;
            }
            set {
                this.lkdRefField = value;
            }
        }
        
        /// <remarks/>
        public AccountManagementType1Code StsReqTp {
            get {
                return this.stsReqTpField;
            }
            set {
                this.stsReqTpField = value;
            }
        }
        
        /// <remarks/>
        public string AcctApplId {
            get {
                return this.acctApplIdField;
            }
            set {
                this.acctApplIdField = value;
            }
        }
        
        /// <remarks/>
        public string ExstgAcctId {
            get {
                return this.exstgAcctIdField;
            }
            set {
                this.exstgAcctIdField = value;
            }
        }
        
        /// <remarks/>
        public InvestmentAccount53 InvstmtAcct {
            get {
                return this.invstmtAcctField;
            }
            set {
                this.invstmtAcctField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.04")]
    public enum AccountManagementType1Code {
        
        /// <remarks/>
        ACCO,
        
        /// <remarks/>
        ACCM,
    }
}
