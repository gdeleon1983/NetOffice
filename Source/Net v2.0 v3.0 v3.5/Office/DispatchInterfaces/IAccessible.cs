//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface IAccessible SupportByLibrary Office, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IAccessible : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IAccessible);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAccessible(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAccessible(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAccessible(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAccessible()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject accParent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accParent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 accChildCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accChildCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject get_accChild(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accChild", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accName(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void set_accName(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accName", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accValue(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void set_accValue(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accValue", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accDescription(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object get_accRole(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
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

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accRole
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object get_accState(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
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

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accHelp(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accHelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="pszHelpFile">string pszHelpFile</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 get_accHelpTopic(string pszHelpFile, object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile, varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="pszHelpFile">string pszHelpFile</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 get_accHelpTopic(string pszHelpFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accKeyboardShortcut(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accKeyboardShortcut
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accFocus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accFocus", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accSelection", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string get_accDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public string accDefaultAction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accSelect(Int32 flagsSelect, object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect, varChild);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accSelect(Int32 flagsSelect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="pxLeft">Int32 pxLeft</param>
		/// <param name="pyTop">Int32 pyTop</param>
		/// <param name="pcxWidth">Int32 pcxWidth</param>
		/// <param name="pcyHeight">Int32 pcyHeight</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accLocation(Int32 pxLeft, Int32 pyTop, Int32 pcxWidth, Int32 pcyHeight, object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight, varChild);
			Invoker.Method(this, "accLocation", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="pxLeft">Int32 pxLeft</param>
		/// <param name="pyTop">Int32 pyTop</param>
		/// <param name="pcxWidth">Int32 pcxWidth</param>
		/// <param name="pcyHeight">Int32 pcyHeight</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accLocation(Int32 pxLeft, Int32 pyTop, Int32 pcxWidth, Int32 pcyHeight)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight);
			Invoker.Method(this, "accLocation", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		/// <param name="varStart">optional object varStart</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accNavigate(Int32 navDir, object varStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir, varStart);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accNavigate(Int32 navDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="xLeft">Int32 xLeft</param>
		/// <param name="yTop">Int32 yTop</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public object accHitTest(Int32 xLeft, Int32 yTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xLeft, yTop);
			object returnItem = Invoker.MethodReturn(this, "accHitTest", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accDoDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void accDoDefaultAction()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}