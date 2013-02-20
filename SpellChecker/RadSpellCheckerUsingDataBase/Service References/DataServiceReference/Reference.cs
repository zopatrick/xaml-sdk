﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace RadSpellCheckerUsingDataBase.DataServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Word", Namespace="http://schemas.datacontract.org/2004/07/RadSpellCheckerUsingDataBase.Web")]
    public partial class Word : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string stringField;
        
        private int idField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string @string {
            get {
                return this.stringField;
            }
            set {
                if ((object.ReferenceEquals(this.stringField, value) != true)) {
                    this.stringField = value;
                    this.RaisePropertyChanged("string");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="DataServiceReference.DataService")]
    public interface DataService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:DataService/GetAllWords", ReplyAction="urn:DataService/GetAllWordsResponse")]
        System.IAsyncResult BeginGetAllWords(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word> EndGetAllWords(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:DataService/UpdateWords", ReplyAction="urn:DataService/UpdateWordsResponse")]
        System.IAsyncResult BeginUpdateWords(System.Collections.ObjectModel.ObservableCollection<string> words, System.AsyncCallback callback, object asyncState);
        
        void EndUpdateWords(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataServiceChannel : RadSpellCheckerUsingDataBase.DataServiceReference.DataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllWordsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllWordsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<RadSpellCheckerUsingDataBase.DataServiceReference.DataService>, RadSpellCheckerUsingDataBase.DataServiceReference.DataService {
        
        private BeginOperationDelegate onBeginGetAllWordsDelegate;
        
        private EndOperationDelegate onEndGetAllWordsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllWordsCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateWordsDelegate;
        
        private EndOperationDelegate onEndUpdateWordsDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateWordsCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetAllWordsCompletedEventArgs> GetAllWordsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UpdateWordsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RadSpellCheckerUsingDataBase.DataServiceReference.DataService.BeginGetAllWords(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllWords(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word> RadSpellCheckerUsingDataBase.DataServiceReference.DataService.EndGetAllWords(System.IAsyncResult result) {
            return base.Channel.EndGetAllWords(result);
        }
        
        private System.IAsyncResult OnBeginGetAllWords(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((RadSpellCheckerUsingDataBase.DataServiceReference.DataService)(this)).BeginGetAllWords(callback, asyncState);
        }
        
        private object[] OnEndGetAllWords(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word> retVal = ((RadSpellCheckerUsingDataBase.DataServiceReference.DataService)(this)).EndGetAllWords(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllWordsCompleted(object state) {
            if ((this.GetAllWordsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllWordsCompleted(this, new GetAllWordsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllWordsAsync() {
            this.GetAllWordsAsync(null);
        }
        
        public void GetAllWordsAsync(object userState) {
            if ((this.onBeginGetAllWordsDelegate == null)) {
                this.onBeginGetAllWordsDelegate = new BeginOperationDelegate(this.OnBeginGetAllWords);
            }
            if ((this.onEndGetAllWordsDelegate == null)) {
                this.onEndGetAllWordsDelegate = new EndOperationDelegate(this.OnEndGetAllWords);
            }
            if ((this.onGetAllWordsCompletedDelegate == null)) {
                this.onGetAllWordsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllWordsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllWordsDelegate, null, this.onEndGetAllWordsDelegate, this.onGetAllWordsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RadSpellCheckerUsingDataBase.DataServiceReference.DataService.BeginUpdateWords(System.Collections.ObjectModel.ObservableCollection<string> words, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateWords(words, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void RadSpellCheckerUsingDataBase.DataServiceReference.DataService.EndUpdateWords(System.IAsyncResult result) {
            base.Channel.EndUpdateWords(result);
        }
        
        private System.IAsyncResult OnBeginUpdateWords(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Collections.ObjectModel.ObservableCollection<string> words = ((System.Collections.ObjectModel.ObservableCollection<string>)(inValues[0]));
            return ((RadSpellCheckerUsingDataBase.DataServiceReference.DataService)(this)).BeginUpdateWords(words, callback, asyncState);
        }
        
        private object[] OnEndUpdateWords(System.IAsyncResult result) {
            ((RadSpellCheckerUsingDataBase.DataServiceReference.DataService)(this)).EndUpdateWords(result);
            return null;
        }
        
        private void OnUpdateWordsCompleted(object state) {
            if ((this.UpdateWordsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateWordsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateWordsAsync(System.Collections.ObjectModel.ObservableCollection<string> words) {
            this.UpdateWordsAsync(words, null);
        }
        
        public void UpdateWordsAsync(System.Collections.ObjectModel.ObservableCollection<string> words, object userState) {
            if ((this.onBeginUpdateWordsDelegate == null)) {
                this.onBeginUpdateWordsDelegate = new BeginOperationDelegate(this.OnBeginUpdateWords);
            }
            if ((this.onEndUpdateWordsDelegate == null)) {
                this.onEndUpdateWordsDelegate = new EndOperationDelegate(this.OnEndUpdateWords);
            }
            if ((this.onUpdateWordsCompletedDelegate == null)) {
                this.onUpdateWordsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateWordsCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateWordsDelegate, new object[] {
                        words}, this.onEndUpdateWordsDelegate, this.onUpdateWordsCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override RadSpellCheckerUsingDataBase.DataServiceReference.DataService CreateChannel() {
            return new DataServiceClientChannel(this);
        }
        
        private class DataServiceClientChannel : ChannelBase<RadSpellCheckerUsingDataBase.DataServiceReference.DataService>, RadSpellCheckerUsingDataBase.DataServiceReference.DataService {
            
            public DataServiceClientChannel(System.ServiceModel.ClientBase<RadSpellCheckerUsingDataBase.DataServiceReference.DataService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetAllWords(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAllWords", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word> EndGetAllWords(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word> _result = ((System.Collections.ObjectModel.ObservableCollection<RadSpellCheckerUsingDataBase.DataServiceReference.Word>)(base.EndInvoke("GetAllWords", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginUpdateWords(System.Collections.ObjectModel.ObservableCollection<string> words, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = words;
                System.IAsyncResult _result = base.BeginInvoke("UpdateWords", _args, callback, asyncState);
                return _result;
            }
            
            public void EndUpdateWords(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("UpdateWords", _args, result);
            }
        }
    }
}
