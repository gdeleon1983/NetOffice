﻿//Generated by LateBindingApi.CodeGenerator
using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using LateBindingApi.Core;

namespace MSComctlLibApi.Utils
{
	#pragma warning disable
    /// <summary>
    /// necessary factory info, used from LateBindingApi.Core.Factory while Initialize()
    /// </summary>
    public class ProjectInfo : IFactoryInfo
    {
        #region Field

        private string   _namespace     = "NetOffice.MSComctlLibApi";
        private Guid     _componentGuid = new Guid("831FDD16-0C5C-11D2-A9FC-0000F8754DA1");
        private Assembly _assembly;

        #endregion

        #region Construction

        public ProjectInfo()
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        #endregion

        #region IFactoryInfo Members

        public string Namespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        #endregion
    }
    #pragma warning restore
}
