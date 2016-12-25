﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService")]
public interface IService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTableData", ReplyAction="http://tempuri.org/IService/GetTableDataResponse")]
    string[] GetTableData(string tableName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTableData", ReplyAction="http://tempuri.org/IService/GetTableDataResponse")]
    System.Threading.Tasks.Task<string[]> GetTableDataAsync(string tableName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTables", ReplyAction="http://tempuri.org/IService/GetTablesResponse")]
    string[] GetTables();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTables", ReplyAction="http://tempuri.org/IService/GetTablesResponse")]
    System.Threading.Tasks.Task<string[]> GetTablesAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{
    
    public ServiceClient()
    {
    }
    
    public ServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string[] GetTableData(string tableName)
    {
        return base.Channel.GetTableData(tableName);
    }
    
    public System.Threading.Tasks.Task<string[]> GetTableDataAsync(string tableName)
    {
        return base.Channel.GetTableDataAsync(tableName);
    }
    
    public string[] GetTables()
    {
        return base.Channel.GetTables();
    }
    
    public System.Threading.Tasks.Task<string[]> GetTablesAsync()
    {
        return base.Channel.GetTablesAsync();
    }
}
