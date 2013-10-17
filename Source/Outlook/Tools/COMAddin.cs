using System;
using NetRunTimeSystem = System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Tools;
using NetOffice.OfficeApi.Tools;
using Office = NetOffice.OfficeApi;
using Outlook = NetOffice.OutlookApi;

namespace NetOffice.OutlookApi.Tools
{
    /// <summary>
    /// The class provides a lot of essential functionality for an MS-Outlook COMAddin
    /// </summary>
	[ComVisible(true)]
    public abstract class COMAddin : IDTExtensibility2, Office.IRibbonExtensibility, Office.ICustomTaskPaneConsumer
    {
        #region Fields

        /// <summary>
        /// MS-Outlook Registry Path 
        /// </summary>
        private static readonly string _addinOfficeRegistryKey  = "Software\\Microsoft\\Office\\Outlook\\AddIns\\";

        #endregion
        
        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public COMAddin()
        {
            Factory = RaiseCreateFactory();
            if (null == Factory)
                Factory = Core.Default;
            TaskPanes = new CustomTaskPaneCollection();
			TaskPaneInstances = new List<ITaskPane>();
            Type = this.GetType();
            Tweaks.EnableTweaks(Factory, Type, "Outlook");
        }

        #endregion

        #region Properties

        /// <summary>
        /// The used factory core
        /// </summary>
        public Core Factory { get; private set; }

        /// <summary>
        /// Type Information of the instance
        /// </summary>
        protected Type Type { get; set; }

        /// <summary>
        /// Host Application Instance
        /// </summary>
        protected Outlook.Application Application { get; private set; }
        
        /// <summary>
        /// Collection with all created custom Task Panes
        /// </summary>
        protected CustomTaskPaneCollection TaskPanes { get; private set; }

        /// <summary>
        /// TaskPaneFactory from CTPFactoryAvailable
        /// </summary>
        protected Office.ICTPFactory TaskPaneFactory { get; set; }

		/// <summary>
        /// ITaskPane Instances
        /// </summary>
		protected List<ITaskPane> TaskPaneInstances { get; set; }

		/// <summary>
        /// Cached Error Method Delegate
        /// </summary>
		private MethodInfo ErrorMethod { get; set; }

		/// <summary>
        /// Cached Register Error Method Delegate
        /// </summary>
		private static MethodInfo RegisterErrorMethod { get; set; }

        #endregion

        #region IDTExtensibility2 Events 

        /// <summary>
        /// The OnStartupComplete event occurs when the host application completes its startup routines, in the case where the COM add-in loads at startup. 
        /// If the add-in is not loaded when the application loads, the OnStartupComplete event does not occur — 
        /// even when the user loads the add-in in the COM Add-ins dialog box. When this event does occur, it occurs after the OnConnection event.
        /// You can use the OnStartupComplete  event procedure to run code that interacts with the application and that should not be run until the application has finished loading. 
        /// For example, if you want to display a form that gives users a choice of documents to create when they start the application, 
        /// you can put that code in the OnStartupComplete event procedure.
        /// </summary>
        public event OnStartupCompleteEventHandler OnStartupComplete;

        /// <summary>
        /// The Shutdown event occurs when the COM add-in is unloaded. 
        /// You can use the OnDisconnection event procedure to run code that restores any changes made to the application by the add-in and to perform general clean-up operations.
        /// An add-in can be unloaded in one of the following ways:
        /// - The user clears the check box next to the add-in in the COM Add-ins dialog box.
        /// - The host application closes. If the add-in is loaded when the application closes, it is unloaded. 
        ///   If the add-in's load behavior is set to Startup, it is reloaded when the application starts again.
        /// - The Connect property of the corresponding COMAddIn object is set to False.
        /// </summary>
        public event OnDisconnectionEventHandler OnDisconnection;

        /// <summary>
        /// The OnConnection event occurs when the COM add-in is loaded (connected). An add-in can be loaded in one of the following ways:
        /// The user starts the host application and the add-in's load behavior is specified to load when the application starts.
        /// The user loads the add-in in the COM Add-ins dialog box.
        /// The Connect property of the corresponding COMAddIn object is set to True.
        /// For more information about the COMAddIn object, search the Microsoft® Office Visual Basic Reference Help index for "COMAddIn object."
        /// </summary>
        public event OnConnectionEventHandler OnConnection;

        /// <summary>
        /// The OnAddInsUpdate event occurs when the set of loaded COM add-ins changes. 
        /// When an add-in is loaded or unloaded, the OnAddInsUpdate event occurs in any other loaded add-ins. 
        /// For example, if add-ins A and B both are loaded currently, and then add-in C is loaded, 
        /// the OnAddInsUpdate event occurs in add-ins A and B. If C is unloaded, the OnAddInsUpdate event occurs again in add-ins A and B. 
        /// </summary>
        public event OnAddInsUpdateEventHandler OnAddInsUpdate;

        /// <summary>
        /// The OnBeginShutdown event occurs when the host application begins its shutdown routines, 
        /// in the case where the application closes while the COM add-in is still loaded. 
        /// If the add-in is not loaded when the application closes, 
        /// the OnBeginShutdown event does not occur. When this event does occur, it occurs before the OnDisconnection event.
        /// You can use the OnBeginShutdown event procedure to run code when the user closes the application. For example, you can run code that saves form data to a file.
        /// </summary>
        public event OnBeginShutdownEventHandler OnBeginShutdown;

        private void RaiseOnStartupComplete(ref Array custom)
        {
            try
            {
                if (null != OnStartupComplete)
                    OnStartupComplete(ref custom);
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.OnStartupComplete, exception);
            }
        }

        private void RaiseOnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            try
            {
                if (null != OnDisconnection)
                    OnDisconnection(RemoveMode, ref custom);
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.OnDisconnection, exception);
            }
        }

        private void RaiseOnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            try
            {
                if (null != OnConnection)
                    OnConnection(Application, ConnectMode, AddInInst, ref custom);
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.OnConnection, exception);
            }
        }

        private void RaiseOnAddInsUpdate(ref Array custom)
        {
            try
            {
                if (null != OnAddInsUpdate)
                    OnAddInsUpdate(ref custom);
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.OnAddInsUpdate, exception);
            }
        }

        private void RaiseOnBeginShutdown(ref Array custom)
        {
            try
            {
                if (null != OnBeginShutdown)
                    OnBeginShutdown(ref custom);
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.OnBeginShutdown, exception);
            }
        }

        #endregion

        #region IDTExtensibility2 Members

        void IDTExtensibility2.OnStartupComplete(ref Array custom)
        {
            RaiseOnStartupComplete(ref custom);
        }

        void IDTExtensibility2.OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
			this.Application = new Outlook.Application(null, Application);
			RaiseOnConnection(Application, ConnectMode, AddInInst, ref custom);
        }

        void IDTExtensibility2.OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            RaiseOnDisconnection(RemoveMode, ref custom);

			foreach(ITaskPane item in TaskPaneInstances)
			{
				try
				{
					item.OnDisconnection();
				}
				catch(NetRunTimeSystem.Exception exception)
				{
						NetOffice.DebugConsole.Default.WriteException(exception);
				}			
			}

			foreach (var item in TaskPanes)
            {
				try
				{
					if(null != item.Pane && !item.Pane.IsDisposed)
	                    item.Pane.Dispose();
				}
				catch(NetRunTimeSystem.Exception exception)
				{
					NetOffice.DebugConsole.Default.WriteException(exception);
				}		
			 }
             
			 try
			 { 
				if (null != TaskPaneFactory && false == TaskPaneFactory.IsDisposed)
					TaskPaneFactory.Dispose();
			 }
			 catch(NetRunTimeSystem.Exception exception)
			 {
				 NetOffice.DebugConsole.Default.WriteException(exception);
			 }	
                
             try
			 { 
				 if (!Application.IsDisposed)
                    Application.Dispose();
			 }
			 catch(NetRunTimeSystem.Exception exception)
			 {
				 NetOffice.DebugConsole.Default.WriteException(exception);
			 }	
        }

        void IDTExtensibility2.OnAddInsUpdate(ref Array custom)
        {
            RaiseOnAddInsUpdate(ref custom);
        }

        void IDTExtensibility2.OnBeginShutdown(ref Array custom)
        {
            RaiseOnBeginShutdown(ref custom);
        }

        #endregion

        #region IRibbonExtensibility Members

        /// <summary>
        /// IRibbonExtensibility implementation
        /// </summary>
        /// <param name="RibbonID">target ribbon id, only used from Outlook and ignored in this standard impklementation. overwrite this method if you need a custom behavior</param>
        /// <returns>XML content oder string.Empty</returns>
        public virtual string GetCustomUI(string RibbonID)
        {
            try
            {
                CustomUIAttribute ribbon = AttributeHelper.GetRibbonAttribute(Type);
                if (null != ribbon)
                    return ReadRessourceFile(ribbon.Value);
                else
                    return string.Empty;
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.GetCustomUI, exception);
				return string.Empty;
            } 
        }

        #endregion

        #region ICustomTaskPaneConsumer Member

        /// <summary>
        /// ICustomTaskPaneConsumer implementation
        /// </summary>
        /// <param name="CTPFactoryInst">factory proxy from host application</param>
        public virtual void CTPFactoryAvailable(object CTPFactoryInst)
        {
            try
            {
                if (null != CTPFactoryInst)
                {
                    TaskPaneFactory = new NetOffice.OfficeApi.ICTPFactory(null, CTPFactoryInst);
                    foreach (TaskPaneInfo item in TaskPanes)
                    {
                        string title = item.Title;
                        Office._CustomTaskPane taskPane = TaskPaneFactory.CreateCTP(item.Type.FullName, title);                        
                        item.Pane = taskPane;
                        item.IsLoaded = true;

                        ITaskPane pane = taskPane.ContentControl as ITaskPane;
                        if (null != pane)
						{
							TaskPaneInstances.Add(pane);
							object[] argumentArray = new object[0];

							if(item.Arguments != null)
								argumentArray = item.Arguments;

							pane.OnConnection(Application, taskPane, argumentArray);
						}

                        foreach (KeyValuePair<string, object> property in item.ChangedProperties)
                            if (property.Key != "Title")
                                taskPane.GetType().InvokeMember(property.Key, BindingFlags.SetProperty, null, taskPane, new object[] { property.Value });
                    }
                }
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.CTPFactoryAvailable, exception);
            } 
        }

        #endregion

        #region Virtual Methods

        /// <summary>
        /// Create the used factory. The method was called as first in the base ctor
        /// </summary>
        /// <returns>new Settings instance</returns>
        protected virtual Core CreateFactory()
        {
            return new Core();
        }

        /// <summary>
        /// Create the necessary factory and was called in the first line in base ctor
        /// </summary>
        /// <returns></returns>
        private Core RaiseCreateFactory()
        {
            try
            {
                return CreateFactory();
            }
            catch (NetRunTimeSystem.Exception exception)
            {
                NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.CreateFactory, exception);
                return null;
            }
        }

        #endregion

        #region ErrorHandler 
        
        /// <summary>
        /// Checks for a static method, signed with the ErrorHandlerAttribute and call them if its available
        /// </summary>
        /// <param name="type">type information for the class wtih static method </param>
       /// <param name="methodKind">origin method where the error comes from</param>
        /// <param name="exception">occured exception</param>
        private static void RaiseStaticErrorHandlerMethod(Type type, RegisterErrorMethodKind methodKind, NetRunTimeSystem.Exception exception)
        {
			MethodInfo errorMethod = AttributeHelper.GetRegisterErrorMethod(type);
            if (null != errorMethod)
                errorMethod.Invoke(null, new object[] { methodKind, exception });
        }

        /// <summary>
        /// Custom error handler
        /// </summary>
        /// <param name="methodKind">origin method where the error comes from</param>
        /// <param name="exception">occured exception</param>
        protected virtual void OnError(ErrorMethodKind methodKind, NetRunTimeSystem.Exception exception)
        {

        }
        
        #endregion

        #region COM Register Functions

        /// <summary>
        /// Called from regasm while register 
        /// </summary>
        /// <param name="type">Type information for the class</param>
        [ComRegisterFunctionAttribute, Browsable(false), EditorBrowsable( EditorBrowsableState.Never)]
        public static void RegisterFunction(Type type)
        {
            try                
            {
                MethodInfo registerMethod = null;
                RegisterFunctionAttribute registerAttribute = null;
                bool registerMethodPresent = AttributeHelper.GetRegisterAttribute(type, ref registerMethod, ref registerAttribute);
                if (registerMethodPresent)
                {
                    CallDerivedRegisterMethod(type, registerMethod, registerAttribute);
                    if (registerAttribute.Value == RegisterMode.Replace)
                        return;
                }

                GuidAttribute guid = AttributeHelper.GetGuidAttribute(type);
                ProgIdAttribute progId = AttributeHelper.GetProgIDAttribute(type);
                RegistryLocationAttribute location = AttributeHelper.GetRegistryLocationAttribute(type);
				COMAddinAttribute addin = AttributeHelper.GetCOMAddinAttribute(type);

                Assembly thisAssembly = Assembly.GetAssembly(type);
                RegistryKey key = Registry.ClassesRoot.CreateSubKey("CLSID\\{" + type.GUID.ToString().ToUpper() + "}\\InprocServer32\\" + GetAssemblyVersionString(type.Assembly));
                key.SetValue("CodeBase", thisAssembly.CodeBase);
                key.Close();
                
                // add bypass key
                // http://support.microsoft.com/kb/948461
                key = Registry.ClassesRoot.CreateSubKey("Interface\\{000C0601-0000-0000-C000-000000000046}");
                string defaultValue = key.GetValue("") as string;
                if (null == defaultValue)
                    key.SetValue("", "Office .NET Framework Lockback Bypass Key");
                key.Close();

                // register addin in Word
                Registry.CurrentUser.CreateSubKey(_addinOfficeRegistryKey +  progId.Value);
                RegistryKey regKeyWord = null;
                
                if(location.Value == RegistrySaveLocation.LocalMachine)
                    regKeyWord = Registry.LocalMachine.OpenSubKey(_addinOfficeRegistryKey + progId.Value, true);
                else
                    regKeyWord = Registry.CurrentUser.OpenSubKey(_addinOfficeRegistryKey + progId.Value, true);

                regKeyWord.SetValue("LoadBehavior", addin.LoadBehavior);
                regKeyWord.SetValue("FriendlyName", addin.Name);
                regKeyWord.SetValue("Description", addin.Description);
                if(-1 != addin.CommandLineSafe)
                    regKeyWord.SetValue("CommandLineSafe", addin.CommandLineSafe);

                regKeyWord.Close();

                 if( (registerMethodPresent) && (registerAttribute.Value == RegisterMode.CallBeforeAndAfter || registerAttribute.Value == RegisterMode.CallAfter))
                        registerMethod.Invoke(null, new object[] { type, RegisterCall.CallAfter });
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                RaiseStaticErrorHandlerMethod(type, RegisterErrorMethodKind.Register, exception);
            }
        }

        /// <summary>
        /// Called from regasm while ungregister
        /// </summary>
        /// <param name="type">Type information for the class</param>
        [ComUnregisterFunctionAttribute, Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public static void UnregisterFunction(Type type)
        {
            try
            {
                MethodInfo registerMethod = null;
                UnRegisterFunctionAttribute registerAttribute = null;
                bool registerMethodPresent = AttributeHelper.GetUnRegisterAttribute(type, ref registerMethod, ref registerAttribute);
                if (registerMethodPresent)
                {
                    CallDerivedUnRegisterMethod(type, registerMethod, registerAttribute);
                    if (registerAttribute.Value == RegisterMode.Replace)
                        return;
                }

                ProgIdAttribute progId = AttributeHelper.GetProgIDAttribute(type);
                RegistryLocationAttribute location = AttributeHelper.GetRegistryLocationAttribute(type);

                // unregister addin
                Registry.ClassesRoot.DeleteSubKey(@"CLSID\{" + type.GUID.ToString().ToUpper() + @"}\Programmable", false);
               
                // unregister addin in office 
                if (location.Value == RegistrySaveLocation.LocalMachine)
                    Registry.LocalMachine.DeleteSubKey(_addinOfficeRegistryKey + progId.Value, false);
                else
                    Registry.CurrentUser.DeleteSubKey(_addinOfficeRegistryKey + progId.Value, false);

                if ((registerMethodPresent) && (registerAttribute.Value == RegisterMode.CallBeforeAndAfter || registerAttribute.Value == RegisterMode.CallAfter))
                    registerMethod.Invoke(null, new object[] { type, RegisterCall.CallAfter });
            }
            catch (NetRunTimeSystem.Exception exception)
            {
				NetOffice.DebugConsole.Default.WriteException(exception);
                RaiseStaticErrorHandlerMethod(type, RegisterErrorMethodKind.UnRegister, exception);
            }
        }

        /// <summary>
        /// Derived Register Call Helper
        /// </summary>
        /// <param name="type">type for derived class</param>
        /// <param name="registerMethod">the method to call</param>
        /// <param name="registerAttribute">arguments</param>
        private static void CallDerivedRegisterMethod(Type type, MethodInfo registerMethod, RegisterFunctionAttribute registerAttribute)
        {
            if (registerAttribute.Value == RegisterMode.Replace)
                registerMethod.Invoke(null, new object[] { type, RegisterCall.Replace });
            else if (registerAttribute.Value == RegisterMode.CallBeforeAndAfter || registerAttribute.Value == RegisterMode.CallBefore)
                registerMethod.Invoke(null, new object[] { type, RegisterCall.CallBefore });
        }

        /// <summary>
        /// Derived Unregister Call Helper
        /// </summary>
        /// <param name="type">type for derived class</param>
        /// <param name="registerMethod">the method to call</param>
        /// <param name="registerAttribute">arguments</param>
        private static void CallDerivedUnRegisterMethod(Type type, MethodInfo registerMethod, UnRegisterFunctionAttribute registerAttribute)
        {
            if (registerAttribute.Value == RegisterMode.Replace)
                registerMethod.Invoke(null, new object[] { type, RegisterCall.Replace });
            else if (registerAttribute.Value == RegisterMode.CallBeforeAndAfter || registerAttribute.Value == RegisterMode.CallBefore)
                registerMethod.Invoke(null, new object[] { type, RegisterCall.CallBefore });
        }


        #endregion

        #region Private Helper Methods

		/// <summary>
        /// Returns the Addin Version String
        /// </summary>
        /// <param name="assembly">Addin Assembly</param>
        /// <returns>Version String</returns>
		private static string GetAssemblyVersionString(Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyVersionAttribute), false);
            if (attributes.Length > 0)
            {
                AssemblyVersionAttribute titleAttribute = (AssemblyVersionAttribute)attributes[0];
                if (titleAttribute.Version != "")
                    return titleAttribute.Version;
            }
            return "1.0.0.0";
        }

        /// <summary>
        /// reads text file from ressource
        /// </summary>
        /// <param name="fileName">ressourceLocation</param>
        /// <returns>text content</returns>
        private string ReadRessourceFile(string fileName)
        {
            Assembly assembly = Type.Assembly;
            NetRunTimeSystem.IO.Stream ressourceStream = assembly.GetManifestResourceStream(fileName);
            if (ressourceStream == null)
                throw (new NetRunTimeSystem.IO.IOException("Error accessing resource Stream."));

            NetRunTimeSystem.IO.StreamReader textStreamReader = new NetRunTimeSystem.IO.StreamReader(ressourceStream);
            if (textStreamReader == null)
                throw (new NetRunTimeSystem.IO.IOException("Error accessing resource File."));

            string text = textStreamReader.ReadToEnd();
            ressourceStream.Close();
            textStreamReader.Close();
            return text;
        }

        #endregion
    }
}