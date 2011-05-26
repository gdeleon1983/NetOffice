//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface FileDialog SupportByLibrary PowerPoint, 9
	///</summary>
	[SupportByLibrary("PowerPoint", 9)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FileDialog : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FileDialog()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
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
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.FileDialogExtensionList Extensions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Extensions", paramsArray);
				NetOffice.PowerPointApi.FileDialogExtensionList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.FileDialogExtensionList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public string DefaultDirectoryRegKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultDirectoryRegKey", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultDirectoryRegKey", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public string DialogTitle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DialogTitle", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DialogTitle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public string ActionButtonName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActionButtonName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActionButtonName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.OfficeApi.Enums.MsoTriState IsMultiSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsMultiSelect", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsMultiSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.OfficeApi.Enums.MsoTriState IsPrintEnabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsPrintEnabled", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsPrintEnabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.OfficeApi.Enums.MsoTriState IsReadOnlyEnabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsReadOnlyEnabled", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsReadOnlyEnabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.OfficeApi.Enums.MsoTriState DirectoriesOnly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DirectoriesOnly", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DirectoriesOnly", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Enums.PpFileDialogView InitialView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InitialView", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpFileDialogView)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InitialView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public string OnAction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnAction", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnAction", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.FileDialogFileList Files
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Files", paramsArray);
				NetOffice.PowerPointApi.FileDialogFileList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.FileDialogFileList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.OfficeApi.Enums.MsoTriState UseODMADlgs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UseODMADlgs", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UseODMADlgs", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="pUnk">object pUnk</param>
		[SupportByLibrary("PowerPoint", 9)]
		public void Launch(object pUnk)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pUnk);
			Invoker.Method(this, "Launch", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}