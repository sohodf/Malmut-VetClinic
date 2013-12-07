﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.239.
// 
#pragma warning disable 1591

namespace Vet_Clinic.SendSmsWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SendSmsWSSoap", Namespace="http://www.telemessersms.co.il/webservice/")]
    public partial class SendSmsWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback IsSmsAllowedInThisScheduleOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCellPhoneOperatorOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMessagesCreditOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMessagesDeliveryOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendSmsOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendSmsWithSumOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendSmsArrayOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SendSmsWS() {
            this.Url = global::Vet_Clinic.Properties.Settings.Default.Vet_Clinic_SendSmsWS_SendSmsWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event IsSmsAllowedInThisScheduleCompletedEventHandler IsSmsAllowedInThisScheduleCompleted;
        
        /// <remarks/>
        public event GetCellPhoneOperatorCompletedEventHandler GetCellPhoneOperatorCompleted;
        
        /// <remarks/>
        public event GetMessagesCreditCompletedEventHandler GetMessagesCreditCompleted;
        
        /// <remarks/>
        public event GetMessagesDeliveryCompletedEventHandler GetMessagesDeliveryCompleted;
        
        /// <remarks/>
        public event SendSmsCompletedEventHandler SendSmsCompleted;
        
        /// <remarks/>
        public event SendSmsWithSumCompletedEventHandler SendSmsWithSumCompleted;
        
        /// <remarks/>
        public event SendSmsArrayCompletedEventHandler SendSmsArrayCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.telemessersms.co.il/webservice/IsSmsAllowedInThisSchedule", RequestNamespace="http://www.telemessersms.co.il/webservice/", ResponseNamespace="http://www.telemessersms.co.il/webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Result IsSmsAllowedInThisSchedule(string UserName, string EncryptPassword, int DeliveryDelayInMinutes) {
            object[] results = this.Invoke("IsSmsAllowedInThisSchedule", new object[] {
                        UserName,
                        EncryptPassword,
                        DeliveryDelayInMinutes});
            return ((Result)(results[0]));
        }
        
        /// <remarks/>
        public void IsSmsAllowedInThisScheduleAsync(string UserName, string EncryptPassword, int DeliveryDelayInMinutes) {
            this.IsSmsAllowedInThisScheduleAsync(UserName, EncryptPassword, DeliveryDelayInMinutes, null);
        }
        
        /// <remarks/>
        public void IsSmsAllowedInThisScheduleAsync(string UserName, string EncryptPassword, int DeliveryDelayInMinutes, object userState) {
            if ((this.IsSmsAllowedInThisScheduleOperationCompleted == null)) {
                this.IsSmsAllowedInThisScheduleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsSmsAllowedInThisScheduleOperationCompleted);
            }
            this.InvokeAsync("IsSmsAllowedInThisSchedule", new object[] {
                        UserName,
                        EncryptPassword,
                        DeliveryDelayInMinutes}, this.IsSmsAllowedInThisScheduleOperationCompleted, userState);
        }
        
        private void OnIsSmsAllowedInThisScheduleOperationCompleted(object arg) {
            if ((this.IsSmsAllowedInThisScheduleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsSmsAllowedInThisScheduleCompleted(this, new IsSmsAllowedInThisScheduleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.telemessersms.co.il/webservice/GetCellPhoneOperator", RequestNamespace="http://www.telemessersms.co.il/webservice/", ResponseNamespace="http://www.telemessersms.co.il/webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetCellPhoneOperator(string UserName, string EncryptPassword, string CellPhone) {
            object[] results = this.Invoke("GetCellPhoneOperator", new object[] {
                        UserName,
                        EncryptPassword,
                        CellPhone});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetCellPhoneOperatorAsync(string UserName, string EncryptPassword, string CellPhone) {
            this.GetCellPhoneOperatorAsync(UserName, EncryptPassword, CellPhone, null);
        }
        
        /// <remarks/>
        public void GetCellPhoneOperatorAsync(string UserName, string EncryptPassword, string CellPhone, object userState) {
            if ((this.GetCellPhoneOperatorOperationCompleted == null)) {
                this.GetCellPhoneOperatorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCellPhoneOperatorOperationCompleted);
            }
            this.InvokeAsync("GetCellPhoneOperator", new object[] {
                        UserName,
                        EncryptPassword,
                        CellPhone}, this.GetCellPhoneOperatorOperationCompleted, userState);
        }
        
        private void OnGetCellPhoneOperatorOperationCompleted(object arg) {
            if ((this.GetCellPhoneOperatorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCellPhoneOperatorCompleted(this, new GetCellPhoneOperatorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.telemessersms.co.il/webservice/GetMessagesCredit", RequestNamespace="http://www.telemessersms.co.il/webservice/", ResponseNamespace="http://www.telemessersms.co.il/webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetMessagesCredit(string UserName, string EncryptPassword) {
            object[] results = this.Invoke("GetMessagesCredit", new object[] {
                        UserName,
                        EncryptPassword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetMessagesCreditAsync(string UserName, string EncryptPassword) {
            this.GetMessagesCreditAsync(UserName, EncryptPassword, null);
        }
        
        /// <remarks/>
        public void GetMessagesCreditAsync(string UserName, string EncryptPassword, object userState) {
            if ((this.GetMessagesCreditOperationCompleted == null)) {
                this.GetMessagesCreditOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMessagesCreditOperationCompleted);
            }
            this.InvokeAsync("GetMessagesCredit", new object[] {
                        UserName,
                        EncryptPassword}, this.GetMessagesCreditOperationCompleted, userState);
        }
        
        private void OnGetMessagesCreditOperationCompleted(object arg) {
            if ((this.GetMessagesCreditCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMessagesCreditCompleted(this, new GetMessagesCreditCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.telemessersms.co.il/webservice/GetMessagesDelivery", RequestNamespace="http://www.telemessersms.co.il/webservice/", ResponseNamespace="http://www.telemessersms.co.il/webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Result GetMessagesDelivery(string UserName, string EncryptPassword, string MessagesID) {
            object[] results = this.Invoke("GetMessagesDelivery", new object[] {
                        UserName,
                        EncryptPassword,
                        MessagesID});
            return ((Result)(results[0]));
        }
        
        /// <remarks/>
        public void GetMessagesDeliveryAsync(string UserName, string EncryptPassword, string MessagesID) {
            this.GetMessagesDeliveryAsync(UserName, EncryptPassword, MessagesID, null);
        }
        
        /// <remarks/>
        public void GetMessagesDeliveryAsync(string UserName, string EncryptPassword, string MessagesID, object userState) {
            if ((this.GetMessagesDeliveryOperationCompleted == null)) {
                this.GetMessagesDeliveryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMessagesDeliveryOperationCompleted);
            }
            this.InvokeAsync("GetMessagesDelivery", new object[] {
                        UserName,
                        EncryptPassword,
                        MessagesID}, this.GetMessagesDeliveryOperationCompleted, userState);
        }
        
        private void OnGetMessagesDeliveryOperationCompleted(object arg) {
            if ((this.GetMessagesDeliveryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMessagesDeliveryCompleted(this, new GetMessagesDeliveryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.telemessersms.co.il/webservice/SendSms", RequestNamespace="http://www.telemessersms.co.il/webservice/", ResponseNamespace="http://www.telemessersms.co.il/webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Result SendSms(string UserName, string EncryptPassword, string Subscribers, string Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes) {
            object[] results = this.Invoke("SendSms", new object[] {
                        UserName,
                        EncryptPassword,
                        Subscribers,
                        Message,
                        SenderName,
                        DeliveryDelayInMinutes,
                        ExpirationDelayInMinutes});
            return ((Result)(results[0]));
        }
        
        /// <remarks/>
        public void SendSmsAsync(string UserName, string EncryptPassword, string Subscribers, string Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes) {
            this.SendSmsAsync(UserName, EncryptPassword, Subscribers, Message, SenderName, DeliveryDelayInMinutes, ExpirationDelayInMinutes, null);
        }
        
        /// <remarks/>
        public void SendSmsAsync(string UserName, string EncryptPassword, string Subscribers, string Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes, object userState) {
            if ((this.SendSmsOperationCompleted == null)) {
                this.SendSmsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSmsOperationCompleted);
            }
            this.InvokeAsync("SendSms", new object[] {
                        UserName,
                        EncryptPassword,
                        Subscribers,
                        Message,
                        SenderName,
                        DeliveryDelayInMinutes,
                        ExpirationDelayInMinutes}, this.SendSmsOperationCompleted, userState);
        }
        
        private void OnSendSmsOperationCompleted(object arg) {
            if ((this.SendSmsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSmsCompleted(this, new SendSmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.telemessersms.co.il/webservice/SendSmsWithSum", RequestNamespace="http://www.telemessersms.co.il/webservice/", ResponseNamespace="http://www.telemessersms.co.il/webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ResultWithSum SendSmsWithSum(string UserName, string EncryptPassword, string Subscribers, string Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes) {
            object[] results = this.Invoke("SendSmsWithSum", new object[] {
                        UserName,
                        EncryptPassword,
                        Subscribers,
                        Message,
                        SenderName,
                        DeliveryDelayInMinutes,
                        ExpirationDelayInMinutes});
            return ((ResultWithSum)(results[0]));
        }
        
        /// <remarks/>
        public void SendSmsWithSumAsync(string UserName, string EncryptPassword, string Subscribers, string Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes) {
            this.SendSmsWithSumAsync(UserName, EncryptPassword, Subscribers, Message, SenderName, DeliveryDelayInMinutes, ExpirationDelayInMinutes, null);
        }
        
        /// <remarks/>
        public void SendSmsWithSumAsync(string UserName, string EncryptPassword, string Subscribers, string Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes, object userState) {
            if ((this.SendSmsWithSumOperationCompleted == null)) {
                this.SendSmsWithSumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSmsWithSumOperationCompleted);
            }
            this.InvokeAsync("SendSmsWithSum", new object[] {
                        UserName,
                        EncryptPassword,
                        Subscribers,
                        Message,
                        SenderName,
                        DeliveryDelayInMinutes,
                        ExpirationDelayInMinutes}, this.SendSmsWithSumOperationCompleted, userState);
        }
        
        private void OnSendSmsWithSumOperationCompleted(object arg) {
            if ((this.SendSmsWithSumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSmsWithSumCompleted(this, new SendSmsWithSumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.telemessersms.co.il/webservice/SendSmsArray", RequestNamespace="http://www.telemessersms.co.il/webservice/", ResponseNamespace="http://www.telemessersms.co.il/webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Result SendSmsArray(string UserName, string EncryptPassword, string Subscribers, string[] Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes) {
            object[] results = this.Invoke("SendSmsArray", new object[] {
                        UserName,
                        EncryptPassword,
                        Subscribers,
                        Message,
                        SenderName,
                        DeliveryDelayInMinutes,
                        ExpirationDelayInMinutes});
            return ((Result)(results[0]));
        }
        
        /// <remarks/>
        public void SendSmsArrayAsync(string UserName, string EncryptPassword, string Subscribers, string[] Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes) {
            this.SendSmsArrayAsync(UserName, EncryptPassword, Subscribers, Message, SenderName, DeliveryDelayInMinutes, ExpirationDelayInMinutes, null);
        }
        
        /// <remarks/>
        public void SendSmsArrayAsync(string UserName, string EncryptPassword, string Subscribers, string[] Message, string SenderName, int DeliveryDelayInMinutes, int ExpirationDelayInMinutes, object userState) {
            if ((this.SendSmsArrayOperationCompleted == null)) {
                this.SendSmsArrayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSmsArrayOperationCompleted);
            }
            this.InvokeAsync("SendSmsArray", new object[] {
                        UserName,
                        EncryptPassword,
                        Subscribers,
                        Message,
                        SenderName,
                        DeliveryDelayInMinutes,
                        ExpirationDelayInMinutes}, this.SendSmsArrayOperationCompleted, userState);
        }
        
        private void OnSendSmsArrayOperationCompleted(object arg) {
            if ((this.SendSmsArrayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSmsArrayCompleted(this, new SendSmsArrayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.telemessersms.co.il/webservice/")]
    public partial class Result {
        
        private string resultField;
        
        private Message[] messagesField;
        
        /// <remarks/>
        public string result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public Message[] Messages {
            get {
                return this.messagesField;
            }
            set {
                this.messagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.telemessersms.co.il/webservice/")]
    public partial class Message {
        
        private string idField;
        
        private string cliField;
        
        private string statusField;
        
        private string operatorField;
        
        /// <remarks/>
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Cli {
            get {
                return this.cliField;
            }
            set {
                this.cliField = value;
            }
        }
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string Operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.telemessersms.co.il/webservice/")]
    public partial class ResultWithSum {
        
        private string resultField;
        
        private int chargeMessagesField;
        
        private int countMessagesField;
        
        private Message[] messagesField;
        
        /// <remarks/>
        public string result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        public int ChargeMessages {
            get {
                return this.chargeMessagesField;
            }
            set {
                this.chargeMessagesField = value;
            }
        }
        
        /// <remarks/>
        public int CountMessages {
            get {
                return this.countMessagesField;
            }
            set {
                this.countMessagesField = value;
            }
        }
        
        /// <remarks/>
        public Message[] Messages {
            get {
                return this.messagesField;
            }
            set {
                this.messagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void IsSmsAllowedInThisScheduleCompletedEventHandler(object sender, IsSmsAllowedInThisScheduleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsSmsAllowedInThisScheduleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsSmsAllowedInThisScheduleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Result Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Result)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetCellPhoneOperatorCompletedEventHandler(object sender, GetCellPhoneOperatorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCellPhoneOperatorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCellPhoneOperatorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetMessagesCreditCompletedEventHandler(object sender, GetMessagesCreditCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMessagesCreditCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMessagesCreditCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetMessagesDeliveryCompletedEventHandler(object sender, GetMessagesDeliveryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMessagesDeliveryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMessagesDeliveryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Result Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Result)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SendSmsCompletedEventHandler(object sender, SendSmsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Result Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Result)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SendSmsWithSumCompletedEventHandler(object sender, SendSmsWithSumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSmsWithSumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSmsWithSumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResultWithSum Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResultWithSum)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SendSmsArrayCompletedEventHandler(object sender, SendSmsArrayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSmsArrayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSmsArrayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Result Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Result)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591