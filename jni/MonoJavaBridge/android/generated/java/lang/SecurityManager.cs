namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecurityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecurityManager()
		{
			InitJNI();
		}
		protected SecurityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkPackageAccess14831;
		public virtual void checkPackageAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPackageAccess14831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPackageAccess14831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMemberAccess14832;
		public virtual void checkMemberAccess(java.lang.Class arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMemberAccess14832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMemberAccess14832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission14833;
		public virtual void checkPermission(java.security.Permission arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPermission14833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPermission14833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission14834;
		public virtual void checkPermission(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPermission14834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPermission14834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCreateClassLoader14835;
		public virtual void checkCreateClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkCreateClassLoader14835);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkCreateClassLoader14835);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertiesAccess14836;
		public virtual void checkPropertiesAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPropertiesAccess14836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPropertiesAccess14836);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertyAccess14837;
		public virtual void checkPropertyAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPropertyAccess14837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPropertyAccess14837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup14838;
		public virtual global::java.lang.ThreadGroup getThreadGroup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getThreadGroup14838)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getThreadGroup14838)) as java.lang.ThreadGroup;
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess14839;
		public virtual void checkAccess(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccess14839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccess14839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess14840;
		public virtual void checkAccess(java.lang.ThreadGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccess14840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccess14840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExit14841;
		public virtual void checkExit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkExit14841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkExit14841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLink14842;
		public virtual void checkLink(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkLink14842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkLink14842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead14843;
		public virtual void checkRead(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead14843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead14843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead14844;
		public virtual void checkRead(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead14844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead14844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead14845;
		public virtual void checkRead(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead14845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead14845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite14846;
		public virtual void checkWrite(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkWrite14846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkWrite14846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite14847;
		public virtual void checkWrite(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkWrite14847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkWrite14847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkDelete14848;
		public virtual void checkDelete(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkDelete14848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkDelete14848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExec14849;
		public virtual void checkExec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkExec14849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkExec14849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect14850;
		public virtual void checkConnect(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkConnect14850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkConnect14850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect14851;
		public virtual void checkConnect(java.lang.String arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkConnect14851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkConnect14851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _checkSetFactory14852;
		public virtual void checkSetFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSetFactory14852);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSetFactory14852);
		}
		internal static global::MonoJavaBridge.MethodId _checkSecurityAccess14853;
		public virtual void checkSecurityAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSecurityAccess14853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSecurityAccess14853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool InCheck
		{
			get
			{
				return getInCheck();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInCheck14854;
		public virtual bool getInCheck() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._getInCheck14854);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getInCheck14854);
		}
		protected new global::java.lang.Class[] ClassContext
		{
			get
			{
				return getClassContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassContext14855;
		protected virtual global::java.lang.Class[] getClassContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getClassContext14855)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getClassContext14855)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _currentClassLoader14856;
		protected virtual global::java.lang.ClassLoader currentClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._currentClassLoader14856)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._currentClassLoader14856)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _currentLoadedClass14857;
		protected virtual global::java.lang.Class currentLoadedClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._currentLoadedClass14857)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._currentLoadedClass14857)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _classDepth14858;
		protected virtual int classDepth(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SecurityManager._classDepth14858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._classDepth14858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _classLoaderDepth14859;
		protected virtual int classLoaderDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SecurityManager._classLoaderDepth14859);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._classLoaderDepth14859);
		}
		internal static global::MonoJavaBridge.MethodId _inClass14860;
		protected virtual bool inClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._inClass14860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._inClass14860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inClassLoader14861;
		protected virtual bool inClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._inClassLoader14861);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._inClassLoader14861);
		}
		public new global::java.lang.Object SecurityContext
		{
			get
			{
				return getSecurityContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSecurityContext14862;
		public virtual global::java.lang.Object getSecurityContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getSecurityContext14862)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getSecurityContext14862)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkListen14863;
		public virtual void checkListen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkListen14863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkListen14863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccept14864;
		public virtual void checkAccept(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccept14864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccept14864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast14865;
		public virtual void checkMulticast(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMulticast14865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMulticast14865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast14866;
		public virtual void checkMulticast(java.net.InetAddress arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMulticast14866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMulticast14866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkTopLevelWindow14867;
		public virtual bool checkTopLevelWindow(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._checkTopLevelWindow14867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkTopLevelWindow14867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkPrintJobAccess14868;
		public virtual void checkPrintJobAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPrintJobAccess14868);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPrintJobAccess14868);
		}
		internal static global::MonoJavaBridge.MethodId _checkSystemClipboardAccess14869;
		public virtual void checkSystemClipboardAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSystemClipboardAccess14869);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSystemClipboardAccess14869);
		}
		internal static global::MonoJavaBridge.MethodId _checkAwtEventQueueAccess14870;
		public virtual void checkAwtEventQueueAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAwtEventQueueAccess14870);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAwtEventQueueAccess14870);
		}
		internal static global::MonoJavaBridge.MethodId _checkPackageDefinition14871;
		public virtual void checkPackageDefinition(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPackageDefinition14871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPackageDefinition14871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SecurityManager14872;
		public SecurityManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._SecurityManager14872);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SecurityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SecurityManager"));
			global::java.lang.SecurityManager._checkPackageAccess14831 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPackageAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkMemberAccess14832 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMemberAccess", "(Ljava/lang/Class;I)V");
			global::java.lang.SecurityManager._checkPermission14833 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;Ljava/lang/Object;)V");
			global::java.lang.SecurityManager._checkPermission14834 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			global::java.lang.SecurityManager._checkCreateClassLoader14835 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkCreateClassLoader", "()V");
			global::java.lang.SecurityManager._checkPropertiesAccess14836 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPropertiesAccess", "()V");
			global::java.lang.SecurityManager._checkPropertyAccess14837 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPropertyAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._getThreadGroup14838 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.SecurityManager._checkAccess14839 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/Thread;)V");
			global::java.lang.SecurityManager._checkAccess14840 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/ThreadGroup;)V");
			global::java.lang.SecurityManager._checkExit14841 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkExit", "(I)V");
			global::java.lang.SecurityManager._checkLink14842 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkLink", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkRead14843 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/io/FileDescriptor;)V");
			global::java.lang.SecurityManager._checkRead14844 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.lang.SecurityManager._checkRead14845 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkWrite14846 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/io/FileDescriptor;)V");
			global::java.lang.SecurityManager._checkWrite14847 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkDelete14848 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkDelete", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkExec14849 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkExec", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkConnect14850 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;I)V");
			global::java.lang.SecurityManager._checkConnect14851 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V");
			global::java.lang.SecurityManager._checkSetFactory14852 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSetFactory", "()V");
			global::java.lang.SecurityManager._checkSecurityAccess14853 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSecurityAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._getInCheck14854 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getInCheck", "()Z");
			global::java.lang.SecurityManager._getClassContext14855 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getClassContext", "()[Ljava/lang/Class;");
			global::java.lang.SecurityManager._currentClassLoader14856 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "currentClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.SecurityManager._currentLoadedClass14857 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "currentLoadedClass", "()Ljava/lang/Class;");
			global::java.lang.SecurityManager._classDepth14858 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "classDepth", "(Ljava/lang/String;)I");
			global::java.lang.SecurityManager._classLoaderDepth14859 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "classLoaderDepth", "()I");
			global::java.lang.SecurityManager._inClass14860 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "inClass", "(Ljava/lang/String;)Z");
			global::java.lang.SecurityManager._inClassLoader14861 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "inClassLoader", "()Z");
			global::java.lang.SecurityManager._getSecurityContext14862 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getSecurityContext", "()Ljava/lang/Object;");
			global::java.lang.SecurityManager._checkListen14863 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkListen", "(I)V");
			global::java.lang.SecurityManager._checkAccept14864 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccept", "(Ljava/lang/String;I)V");
			global::java.lang.SecurityManager._checkMulticast14865 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;)V");
			global::java.lang.SecurityManager._checkMulticast14866 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;B)V");
			global::java.lang.SecurityManager._checkTopLevelWindow14867 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkTopLevelWindow", "(Ljava/lang/Object;)Z");
			global::java.lang.SecurityManager._checkPrintJobAccess14868 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPrintJobAccess", "()V");
			global::java.lang.SecurityManager._checkSystemClipboardAccess14869 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSystemClipboardAccess", "()V");
			global::java.lang.SecurityManager._checkAwtEventQueueAccess14870 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAwtEventQueueAccess", "()V");
			global::java.lang.SecurityManager._checkPackageDefinition14871 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPackageDefinition", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._SecurityManager14872 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "<init>", "()V");
		}
	}
}
