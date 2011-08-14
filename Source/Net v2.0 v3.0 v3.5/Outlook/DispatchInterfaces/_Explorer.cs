//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _Explorer SupportByLibrary Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Explorer : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_Explorer);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Explorer(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Explorer(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Explorer(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Explorer()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
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
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBars CommandBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandBars", paramsArray);
				NetOffice.OfficeApi.CommandBars newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.MAPIFolder CurrentFolder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentFolder", paramsArray);
				NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.MAPIFolder;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CurrentFolder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public object CurrentView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentView", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CurrentView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Panes Panes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Panes", paramsArray);
				NetOffice.OutlookApi.Panes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Panes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Selection Selection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Selection", paramsArray);
				NetOffice.OutlookApi.Selection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Selection;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlWindowState WindowState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WindowState", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlWindowState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WindowState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject Views
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Views", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public COMObject HTMLDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLDocument", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi._NavigationPane NavigationPane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NavigationPane", paramsArray);
				NetOffice.OutlookApi._NavigationPane newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NavigationPane;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi._AccountSelector AccountSelector
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AccountSelector", paramsArray);
				NetOffice.OutlookApi._AccountSelector newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._AccountSelector;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi._AttachmentSelection AttachmentSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AttachmentSelection", paramsArray);
				NetOffice.OutlookApi._AttachmentSelection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._AttachmentSelection;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Display()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Activate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Activate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Pane">NetOffice.OutlookApi.Enums.OlPane Pane</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public bool IsPaneVisible(NetOffice.OutlookApi.Enums.OlPane pane)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pane);
			object returnItem = Invoker.MethodReturn(this, "IsPaneVisible", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Pane">NetOffice.OutlookApi.Enums.OlPane Pane</param>
		/// <param name="Visible">bool Visible</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void ShowPane(NetOffice.OutlookApi.Enums.OlPane pane, bool visible)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pane, visible);
			Invoker.Method(this, "ShowPane", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 11, 12, 14
		/// </summary>
		/// <param name="Folder">NetOffice.OutlookApi.MAPIFolder Folder</param>
		[SupportByLibrary("Outlook", 11,12,14)]
		public void SelectFolder(NetOffice.OutlookApi.MAPIFolder folder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folder);
			Invoker.Method(this, "SelectFolder", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 11, 12, 14
		/// </summary>
		/// <param name="Folder">NetOffice.OutlookApi.MAPIFolder Folder</param>
		[SupportByLibrary("Outlook", 11,12,14)]
		public void DeselectFolder(NetOffice.OutlookApi.MAPIFolder folder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folder);
			Invoker.Method(this, "DeselectFolder", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 11, 12, 14
		/// </summary>
		/// <param name="Folder">NetOffice.OutlookApi.MAPIFolder Folder</param>
		[SupportByLibrary("Outlook", 11,12,14)]
		public bool IsFolderSelected(NetOffice.OutlookApi.MAPIFolder folder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folder);
			object returnItem = Invoker.MethodReturn(this, "IsFolderSelected", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public void ClearSearch()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearSearch", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Query">string Query</param>
		/// <param name="SearchScope">NetOffice.OutlookApi.Enums.OlSearchScope SearchScope</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void Search(string query, NetOffice.OutlookApi.Enums.OlSearchScope searchScope)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query, searchScope);
			Invoker.Method(this, "Search", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("Outlook", 14)]
		public bool IsItemSelectableInView(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.MethodReturn(this, "IsItemSelectableInView", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("Outlook", 14)]
		public void AddToSelection(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			Invoker.Method(this, "AddToSelection", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("Outlook", 14)]
		public void RemoveFromSelection(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			Invoker.Method(this, "RemoveFromSelection", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public void SelectAllItems()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SelectAllItems", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public void ClearSelection()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearSelection", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}