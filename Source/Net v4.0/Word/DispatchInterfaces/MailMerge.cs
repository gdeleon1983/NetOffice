//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface MailMerge SupportByLibrary Word, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class MailMerge : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMerge(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMerge(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMerge(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMerge()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdMailMergeMainDocType MainDocumentType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MainDocumentType", paramsArray);
				return (NetOffice.WordApi.Enums.WdMailMergeMainDocType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MainDocumentType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdMailMergeState State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (NetOffice.WordApi.Enums.WdMailMergeState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdMailMergeDestination Destination
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Destination", paramsArray);
				return (NetOffice.WordApi.Enums.WdMailMergeDestination)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Destination", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.MailMergeDataSource DataSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSource", paramsArray);
				NetOffice.WordApi.MailMergeDataSource newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.MailMergeDataSource;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.MailMergeFields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.WordApi.MailMergeFields newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.MailMergeFields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 ViewMailMergeFieldCodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewMailMergeFieldCodes", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ViewMailMergeFieldCodes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool SuppressBlankLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SuppressBlankLines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SuppressBlankLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MailAsAttachment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailAsAttachment", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailAsAttachment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public string MailAddressFieldName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailAddressFieldName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailAddressFieldName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public string MailSubject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailSubject", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailSubject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool HighlightMergeFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HighlightMergeFields", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HighlightMergeFields", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Enums.WdMailMergeMailFormat MailFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailFormat", paramsArray);
				return (NetOffice.WordApi.Enums.WdMailMergeMailFormat)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public string ShowSendToCustom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSendToCustom", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSendToCustom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Int32 WizardState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WizardState", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WizardState", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="HeaderRecord">optional object HeaderRecord</param>
		/// <param name="MSQuery">optional object MSQuery</param>
		/// <param name="SQLStatement">optional object SQLStatement</param>
		/// <param name="SQLStatement1">optional object SQLStatement1</param>
		/// <param name="Connection">optional object Connection</param>
		/// <param name="LinkToSource">optional object LinkToSource</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void CreateDataSource(object name=null, object passwordDocument=null, object writePasswordDocument=null, object headerRecord=null, object mSQuery=null, object sQLStatement=null, object sQLStatement1=null, object connection=null, object linkToSource=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, passwordDocument, writePasswordDocument, headerRecord, mSQuery, sQLStatement, sQLStatement1, connection, linkToSource);
			Invoker.Method(this, "CreateDataSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void CreateDataSource()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CreateDataSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="HeaderRecord">optional object HeaderRecord</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void CreateHeaderSource(string name, object passwordDocument=null, object writePasswordDocument=null, object headerRecord=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, passwordDocument, writePasswordDocument, headerRecord);
			Invoker.Method(this, "CreateHeaderSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void CreateHeaderSource(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "CreateHeaderSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="ConfirmConversions">optional object ConfirmConversions</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="LinkToSource">optional object LinkToSource</param>
		/// <param name="AddToRecentFiles">optional object AddToRecentFiles</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="PasswordTemplate">optional object PasswordTemplate</param>
		/// <param name="Revert">optional object Revert</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="WritePasswordTemplate">optional object WritePasswordTemplate</param>
		/// <param name="Connection">optional object Connection</param>
		/// <param name="SQLStatement">optional object SQLStatement</param>
		/// <param name="SQLStatement1">optional object SQLStatement1</param>
		[SupportByLibrary("Word", 9)]
		public void OpenDataSource(string name, object format=null, object confirmConversions=null, object readOnly=null, object linkToSource=null, object addToRecentFiles=null, object passwordDocument=null, object passwordTemplate=null, object revert=null, object writePasswordDocument=null, object writePasswordTemplate=null, object connection=null, object sQLStatement=null, object sQLStatement1=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, format, confirmConversions, readOnly, linkToSource, addToRecentFiles, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate, connection, sQLStatement, sQLStatement1);
			Invoker.Method(this, "OpenDataSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="ConfirmConversions">optional object ConfirmConversions</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="LinkToSource">optional object LinkToSource</param>
		/// <param name="AddToRecentFiles">optional object AddToRecentFiles</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="PasswordTemplate">optional object PasswordTemplate</param>
		/// <param name="Revert">optional object Revert</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="WritePasswordTemplate">optional object WritePasswordTemplate</param>
		/// <param name="Connection">optional object Connection</param>
		/// <param name="SQLStatement">optional object SQLStatement</param>
		/// <param name="SQLStatement1">optional object SQLStatement1</param>
		/// <param name="OpenExclusive">optional object OpenExclusive</param>
		/// <param name="SubType">optional object SubType</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void OpenDataSource(string name, object format=null, object confirmConversions=null, object readOnly=null, object linkToSource=null, object addToRecentFiles=null, object passwordDocument=null, object passwordTemplate=null, object revert=null, object writePasswordDocument=null, object writePasswordTemplate=null, object connection=null, object sQLStatement=null, object sQLStatement1=null, object openExclusive=null, object subType=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, format, confirmConversions, readOnly, linkToSource, addToRecentFiles, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate, connection, sQLStatement, sQLStatement1, openExclusive, subType);
			Invoker.Method(this, "OpenDataSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void OpenDataSource(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "OpenDataSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="ConfirmConversions">optional object ConfirmConversions</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="AddToRecentFiles">optional object AddToRecentFiles</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="PasswordTemplate">optional object PasswordTemplate</param>
		/// <param name="Revert">optional object Revert</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="WritePasswordTemplate">optional object WritePasswordTemplate</param>
		[SupportByLibrary("Word", 9)]
		public void OpenHeaderSource(string name, object format=null, object confirmConversions=null, object readOnly=null, object addToRecentFiles=null, object passwordDocument=null, object passwordTemplate=null, object revert=null, object writePasswordDocument=null, object writePasswordTemplate=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, format, confirmConversions, readOnly, addToRecentFiles, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate);
			Invoker.Method(this, "OpenHeaderSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="ConfirmConversions">optional object ConfirmConversions</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="AddToRecentFiles">optional object AddToRecentFiles</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="PasswordTemplate">optional object PasswordTemplate</param>
		/// <param name="Revert">optional object Revert</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="WritePasswordTemplate">optional object WritePasswordTemplate</param>
		/// <param name="OpenExclusive">optional object OpenExclusive</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void OpenHeaderSource(string name, object format=null, object confirmConversions=null, object readOnly=null, object addToRecentFiles=null, object passwordDocument=null, object passwordTemplate=null, object revert=null, object writePasswordDocument=null, object writePasswordTemplate=null, object openExclusive=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, format, confirmConversions, readOnly, addToRecentFiles, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate, openExclusive);
			Invoker.Method(this, "OpenHeaderSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void OpenHeaderSource(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "OpenHeaderSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Pause">optional object Pause</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Execute(object pause=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pause);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Execute()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Check()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Check", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void EditDataSource()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "EditDataSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void EditHeaderSource()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "EditHeaderSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void EditMainDocument()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "EditMainDocument", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">string Type</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void UseAddressBook(string type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			Invoker.Method(this, "UseAddressBook", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="ConfirmConversions">optional object ConfirmConversions</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="LinkToSource">optional object LinkToSource</param>
		/// <param name="AddToRecentFiles">optional object AddToRecentFiles</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="PasswordTemplate">optional object PasswordTemplate</param>
		/// <param name="Revert">optional object Revert</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="WritePasswordTemplate">optional object WritePasswordTemplate</param>
		/// <param name="Connection">optional object Connection</param>
		/// <param name="SQLStatement">optional object SQLStatement</param>
		/// <param name="SQLStatement1">optional object SQLStatement1</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void OpenDataSource2000(string name, object format=null, object confirmConversions=null, object readOnly=null, object linkToSource=null, object addToRecentFiles=null, object passwordDocument=null, object passwordTemplate=null, object revert=null, object writePasswordDocument=null, object writePasswordTemplate=null, object connection=null, object sQLStatement=null, object sQLStatement1=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, format, confirmConversions, readOnly, linkToSource, addToRecentFiles, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate, connection, sQLStatement, sQLStatement1);
			Invoker.Method(this, "OpenDataSource2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void OpenDataSource2000(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "OpenDataSource2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Format">optional object Format</param>
		/// <param name="ConfirmConversions">optional object ConfirmConversions</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="AddToRecentFiles">optional object AddToRecentFiles</param>
		/// <param name="PasswordDocument">optional object PasswordDocument</param>
		/// <param name="PasswordTemplate">optional object PasswordTemplate</param>
		/// <param name="Revert">optional object Revert</param>
		/// <param name="WritePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="WritePasswordTemplate">optional object WritePasswordTemplate</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void OpenHeaderSource2000(string name, object format=null, object confirmConversions=null, object readOnly=null, object addToRecentFiles=null, object passwordDocument=null, object passwordTemplate=null, object revert=null, object writePasswordDocument=null, object writePasswordTemplate=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, format, confirmConversions, readOnly, addToRecentFiles, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate);
			Invoker.Method(this, "OpenHeaderSource2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void OpenHeaderSource2000(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "OpenHeaderSource2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="InitialState">object InitialState</param>
		/// <param name="ShowDocumentStep">optional object ShowDocumentStep</param>
		/// <param name="ShowTemplateStep">optional object ShowTemplateStep</param>
		/// <param name="ShowDataStep">optional object ShowDataStep</param>
		/// <param name="ShowWriteStep">optional object ShowWriteStep</param>
		/// <param name="ShowPreviewStep">optional object ShowPreviewStep</param>
		/// <param name="ShowMergeStep">optional object ShowMergeStep</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void ShowWizard(object initialState, object showDocumentStep=null, object showTemplateStep=null, object showDataStep=null, object showWriteStep=null, object showPreviewStep=null, object showMergeStep=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(initialState, showDocumentStep, showTemplateStep, showDataStep, showWriteStep, showPreviewStep, showMergeStep);
			Invoker.Method(this, "ShowWizard", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="InitialState">object InitialState</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void ShowWizard(object initialState)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(initialState);
			Invoker.Method(this, "ShowWizard", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}