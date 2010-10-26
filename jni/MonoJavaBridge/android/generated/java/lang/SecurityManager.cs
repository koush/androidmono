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
		internal static global::MonoJavaBridge.MethodId _checkPackageAccess20463;
		public virtual void checkPackageAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPackageAccess20463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPackageAccess20463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMemberAccess20464;
		public virtual void checkMemberAccess(java.lang.Class arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMemberAccess20464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMemberAccess20464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission20465;
		public virtual void checkPermission(java.security.Permission arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPermission20465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPermission20465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission20466;
		public virtual void checkPermission(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPermission20466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPermission20466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCreateClassLoader20467;
		public virtual void checkCreateClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkCreateClassLoader20467);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkCreateClassLoader20467);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertiesAccess20468;
		public virtual void checkPropertiesAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPropertiesAccess20468);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPropertiesAccess20468);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertyAccess20469;
		public virtual void checkPropertyAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPropertyAccess20469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPropertyAccess20469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup20470;
		public virtual global::java.lang.ThreadGroup getThreadGroup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getThreadGroup20470)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getThreadGroup20470)) as java.lang.ThreadGroup;
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20471;
		public virtual void checkAccess(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccess20471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccess20471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20472;
		public virtual void checkAccess(java.lang.ThreadGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccess20472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccess20472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExit20473;
		public virtual void checkExit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkExit20473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkExit20473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLink20474;
		public virtual void checkLink(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkLink20474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkLink20474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20475;
		public virtual void checkRead(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead20475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead20475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20476;
		public virtual void checkRead(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead20476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead20476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20477;
		public virtual void checkRead(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead20477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead20477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite20478;
		public virtual void checkWrite(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkWrite20478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkWrite20478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite20479;
		public virtual void checkWrite(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkWrite20479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkWrite20479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkDelete20480;
		public virtual void checkDelete(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkDelete20480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkDelete20480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExec20481;
		public virtual void checkExec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkExec20481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkExec20481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect20482;
		public virtual void checkConnect(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkConnect20482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkConnect20482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect20483;
		public virtual void checkConnect(java.lang.String arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkConnect20483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkConnect20483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _checkSetFactory20484;
		public virtual void checkSetFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSetFactory20484);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSetFactory20484);
		}
		internal static global::MonoJavaBridge.MethodId _checkSecurityAccess20485;
		public virtual void checkSecurityAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSecurityAccess20485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSecurityAccess20485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool InCheck
		{
			get
			{
				return getInCheck();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInCheck20486;
		public virtual bool getInCheck() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._getInCheck20486);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getInCheck20486);
		}
		protected new global::java.lang.Class[] ClassContext
		{
			get
			{
				return getClassContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassContext20487;
		protected virtual global::java.lang.Class[] getClassContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getClassContext20487)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getClassContext20487)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _currentClassLoader20488;
		protected virtual global::java.lang.ClassLoader currentClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._currentClassLoader20488)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._currentClassLoader20488)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _currentLoadedClass20489;
		protected virtual global::java.lang.Class currentLoadedClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._currentLoadedClass20489)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._currentLoadedClass20489)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _classDepth20490;
		protected virtual int classDepth(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SecurityManager._classDepth20490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._classDepth20490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _classLoaderDepth20491;
		protected virtual int classLoaderDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SecurityManager._classLoaderDepth20491);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._classLoaderDepth20491);
		}
		internal static global::MonoJavaBridge.MethodId _inClass20492;
		protected virtual bool inClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._inClass20492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._inClass20492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inClassLoader20493;
		protected virtual bool inClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._inClassLoader20493);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._inClassLoader20493);
		}
		public new global::java.lang.Object SecurityContext
		{
			get
			{
				return getSecurityContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSecurityContext20494;
		public virtual global::java.lang.Object getSecurityContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getSecurityContext20494)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getSecurityContext20494)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkListen20495;
		public virtual void checkListen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkListen20495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkListen20495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccept20496;
		public virtual void checkAccept(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccept20496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccept20496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast20497;
		public virtual void checkMulticast(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMulticast20497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMulticast20497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast20498;
		public virtual void checkMulticast(java.net.InetAddress arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMulticast20498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMulticast20498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkTopLevelWindow20499;
		public virtual bool checkTopLevelWindow(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._checkTopLevelWindow20499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkTopLevelWindow20499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkPrintJobAccess20500;
		public virtual void checkPrintJobAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPrintJobAccess20500);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPrintJobAccess20500);
		}
		internal static global::MonoJavaBridge.MethodId _checkSystemClipboardAccess20501;
		public virtual void checkSystemClipboardAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSystemClipboardAccess20501);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSystemClipboardAccess20501);
		}
		internal static global::MonoJavaBridge.MethodId _checkAwtEventQueueAccess20502;
		public virtual void checkAwtEventQueueAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAwtEventQueueAccess20502);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAwtEventQueueAccess20502);
		}
		internal static global::MonoJavaBridge.MethodId _checkPackageDefinition20503;
		public virtual void checkPackageDefinition(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPackageDefinition20503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPackageDefinition20503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SecurityManager20504;
		public SecurityManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._SecurityManager20504);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SecurityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SecurityManager"));
			global::java.lang.SecurityManager._checkPackageAccess20463 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPackageAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkMemberAccess20464 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMemberAccess", "(Ljava/lang/Class;I)V");
			global::java.lang.SecurityManager._checkPermission20465 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;Ljava/lang/Object;)V");
			global::java.lang.SecurityManager._checkPermission20466 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			global::java.lang.SecurityManager._checkCreateClassLoader20467 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkCreateClassLoader", "()V");
			global::java.lang.SecurityManager._checkPropertiesAccess20468 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPropertiesAccess", "()V");
			global::java.lang.SecurityManager._checkPropertyAccess20469 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPropertyAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._getThreadGroup20470 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.SecurityManager._checkAccess20471 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/Thread;)V");
			global::java.lang.SecurityManager._checkAccess20472 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/ThreadGroup;)V");
			global::java.lang.SecurityManager._checkExit20473 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkExit", "(I)V");
			global::java.lang.SecurityManager._checkLink20474 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkLink", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkRead20475 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/io/FileDescriptor;)V");
			global::java.lang.SecurityManager._checkRead20476 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.lang.SecurityManager._checkRead20477 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkWrite20478 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/io/FileDescriptor;)V");
			global::java.lang.SecurityManager._checkWrite20479 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkDelete20480 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkDelete", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkExec20481 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkExec", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkConnect20482 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;I)V");
			global::java.lang.SecurityManager._checkConnect20483 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V");
			global::java.lang.SecurityManager._checkSetFactory20484 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSetFactory", "()V");
			global::java.lang.SecurityManager._checkSecurityAccess20485 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSecurityAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._getInCheck20486 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getInCheck", "()Z");
			global::java.lang.SecurityManager._getClassContext20487 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getClassContext", "()[Ljava/lang/Class;");
			global::java.lang.SecurityManager._currentClassLoader20488 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "currentClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.SecurityManager._currentLoadedClass20489 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "currentLoadedClass", "()Ljava/lang/Class;");
			global::java.lang.SecurityManager._classDepth20490 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "classDepth", "(Ljava/lang/String;)I");
			global::java.lang.SecurityManager._classLoaderDepth20491 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "classLoaderDepth", "()I");
			global::java.lang.SecurityManager._inClass20492 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "inClass", "(Ljava/lang/String;)Z");
			global::java.lang.SecurityManager._inClassLoader20493 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "inClassLoader", "()Z");
			global::java.lang.SecurityManager._getSecurityContext20494 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getSecurityContext", "()Ljava/lang/Object;");
			global::java.lang.SecurityManager._checkListen20495 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkListen", "(I)V");
			global::java.lang.SecurityManager._checkAccept20496 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccept", "(Ljava/lang/String;I)V");
			global::java.lang.SecurityManager._checkMulticast20497 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;)V");
			global::java.lang.SecurityManager._checkMulticast20498 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;B)V");
			global::java.lang.SecurityManager._checkTopLevelWindow20499 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkTopLevelWindow", "(Ljava/lang/Object;)Z");
			global::java.lang.SecurityManager._checkPrintJobAccess20500 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPrintJobAccess", "()V");
			global::java.lang.SecurityManager._checkSystemClipboardAccess20501 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSystemClipboardAccess", "()V");
			global::java.lang.SecurityManager._checkAwtEventQueueAccess20502 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAwtEventQueueAccess", "()V");
			global::java.lang.SecurityManager._checkPackageDefinition20503 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPackageDefinition", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._SecurityManager20504 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "<init>", "()V");
		}
	}
}
