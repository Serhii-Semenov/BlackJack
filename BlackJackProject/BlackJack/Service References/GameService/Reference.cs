﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackJack.GameService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerList", Namespace="http://schemas.datacontract.org/2004/07/BlackJackWcfService.Model")]
    [System.SerializableAttribute()]
    public partial class PlayerList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<int, BlackJack.GameService.Player> PlayersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<int, BlackJack.GameService.Player> Players {
            get {
                return this.PlayersField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayersField, value) != true)) {
                    this.PlayersField = value;
                    this.RaisePropertyChanged("Players");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/BlackJackWcfService.Model")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NicknameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nickname {
            get {
                return this.NicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.NicknameField, value) != true)) {
                    this.NicknameField = value;
                    this.RaisePropertyChanged("Nickname");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GamePlayer", Namespace="http://schemas.datacontract.org/2004/07/BlackJackWcfService.Model")]
    [System.SerializableAttribute()]
    public partial class GamePlayer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SomeArtibute1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SomeAtribute2Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SomeArtibute1 {
            get {
                return this.SomeArtibute1Field;
            }
            set {
                if ((this.SomeArtibute1Field.Equals(value) != true)) {
                    this.SomeArtibute1Field = value;
                    this.RaisePropertyChanged("SomeArtibute1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SomeAtribute2 {
            get {
                return this.SomeAtribute2Field;
            }
            set {
                if ((this.SomeAtribute2Field.Equals(value) != true)) {
                    this.SomeAtribute2Field = value;
                    this.RaisePropertyChanged("SomeAtribute2");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GameService.IGameService", CallbackContract=typeof(BlackJack.GameService.IGameServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IGameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Login", ReplyAction="http://tempuri.org/IGameService/LoginResponse")]
        int Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Login", ReplyAction="http://tempuri.org/IGameService/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string login, string pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Registration", ReplyAction="http://tempuri.org/IGameService/RegistrationResponse")]
        int Registration(string login, string pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Registration", ReplyAction="http://tempuri.org/IGameService/RegistrationResponse")]
        System.Threading.Tasks.Task<int> RegistrationAsync(string login, string pasword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Logout", ReplyAction="http://tempuri.org/IGameService/LogoutResponse")]
        void Logout(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/Logout", ReplyAction="http://tempuri.org/IGameService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetPlayers", ReplyAction="http://tempuri.org/IGameService/GetPlayersResponse")]
        BlackJack.GameService.PlayerList GetPlayers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameService/GetPlayers", ReplyAction="http://tempuri.org/IGameService/GetPlayersResponse")]
        System.Threading.Tasks.Task<BlackJack.GameService.PlayerList> GetPlayersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameService/UpdatePlayerList")]
        void UpdatePlayerList(BlackJack.GameService.PlayerList players);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameService/BattleStarted")]
        void BattleStarted(BlackJack.GameService.GamePlayer[] players);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IGameService/PlayerMoved")]
        void PlayerMoved(BlackJack.GameService.GamePlayer player);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameServiceChannel : BlackJack.GameService.IGameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameServiceClient : System.ServiceModel.DuplexClientBase<BlackJack.GameService.IGameService>, BlackJack.GameService.IGameService {
        
        public GameServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Login(string login, string pasword) {
            return base.Channel.Login(login, pasword);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string login, string pasword) {
            return base.Channel.LoginAsync(login, pasword);
        }
        
        public int Registration(string login, string pasword) {
            return base.Channel.Registration(login, pasword);
        }
        
        public System.Threading.Tasks.Task<int> RegistrationAsync(string login, string pasword) {
            return base.Channel.RegistrationAsync(login, pasword);
        }
        
        public void Logout(int id) {
            base.Channel.Logout(id);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(int id) {
            return base.Channel.LogoutAsync(id);
        }
        
        public BlackJack.GameService.PlayerList GetPlayers() {
            return base.Channel.GetPlayers();
        }
        
        public System.Threading.Tasks.Task<BlackJack.GameService.PlayerList> GetPlayersAsync() {
            return base.Channel.GetPlayersAsync();
        }
    }
}
