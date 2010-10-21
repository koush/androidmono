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
		internal static global::MonoJavaBridge.MethodId _checkPackageAccess20345;
		public virtual void checkPackageAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPackageAccess20345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPackageAccess20345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMemberAccess20346;
		public virtual void checkMemberAccess(java.lang.Class arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMemberAccess20346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMemberAccess20346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission20347;
		public virtual void checkPermission(java.security.Permission arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPermission20347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPermission20347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkPermission20348;
		public virtual void checkPermission(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPermission20348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPermission20348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkCreateClassLoader20349;
		public virtual void checkCreateClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkCreateClassLoader20349);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkCreateClassLoader20349);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertiesAccess20350;
		public virtual void checkPropertiesAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPropertiesAccess20350);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPropertiesAccess20350);
		}
		internal static global::MonoJavaBridge.MethodId _checkPropertyAccess20351;
		public virtual void checkPropertyAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPropertyAccess20351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPropertyAccess20351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup20352;
		public virtual global::java.lang.ThreadGroup getThreadGroup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getThreadGroup20352)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getThreadGroup20352)) as java.lang.ThreadGroup;
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20353;
		public virtual void checkAccess(java.lang.Thread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccess20353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccess20353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20354;
		public virtual void checkAccess(java.lang.ThreadGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccess20354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccess20354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExit20355;
		public virtual void checkExit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkExit20355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkExit20355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkLink20356;
		public virtual void checkLink(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkLink20356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkLink20356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20357;
		public virtual void checkRead(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead20357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead20357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20358;
		public virtual void checkRead(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead20358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead20358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkRead20359;
		public virtual void checkRead(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkRead20359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkRead20359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite20360;
		public virtual void checkWrite(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkWrite20360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkWrite20360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkWrite20361;
		public virtual void checkWrite(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkWrite20361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkWrite20361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkDelete20362;
		public virtual void checkDelete(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkDelete20362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkDelete20362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkExec20363;
		public virtual void checkExec(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkExec20363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkExec20363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect20364;
		public virtual void checkConnect(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkConnect20364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkConnect20364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkConnect20365;
		public virtual void checkConnect(java.lang.String arg0, int arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkConnect20365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkConnect20365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _checkSetFactory20366;
		public virtual void checkSetFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSetFactory20366);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSetFactory20366);
		}
		internal static global::MonoJavaBridge.MethodId _checkSecurityAccess20367;
		public virtual void checkSecurityAccess(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSecurityAccess20367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSecurityAccess20367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool InCheck
		{
			get
			{
				return getInCheck();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInCheck20368;
		public virtual bool getInCheck() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._getInCheck20368);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getInCheck20368);
		}
		protected new global::java.lang.Class[] ClassContext
		{
			get
			{
				return getClassContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassContext20369;
		protected virtual global::java.lang.Class[] getClassContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getClassContext20369)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getClassContext20369)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _currentClassLoader20370;
		protected virtual global::java.lang.ClassLoader currentClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._currentClassLoader20370)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._currentClassLoader20370)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _currentLoadedClass20371;
		protected virtual global::java.lang.Class currentLoadedClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._currentLoadedClass20371)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._currentLoadedClass20371)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _classDepth20372;
		protected virtual int classDepth(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SecurityManager._classDepth20372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._classDepth20372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _classLoaderDepth20373;
		protected virtual int classLoaderDepth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SecurityManager._classLoaderDepth20373);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._classLoaderDepth20373);
		}
		internal static global::MonoJavaBridge.MethodId _inClass20374;
		protected virtual bool inClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._inClass20374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._inClass20374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inClassLoader20375;
		protected virtual bool inClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._inClassLoader20375);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._inClassLoader20375);
		}
		public new global::java.lang.Object SecurityContext
		{
			get
			{
				return getSecurityContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSecurityContext20376;
		public virtual global::java.lang.Object getSecurityContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SecurityManager._getSecurityContext20376)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._getSecurityContext20376)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _checkListen20377;
		public virtual void checkListen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkListen20377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkListen20377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkAccept20378;
		public virtual void checkAccept(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAccept20378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAccept20378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast20379;
		public virtual void checkMulticast(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMulticast20379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMulticast20379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMulticast20380;
		public virtual void checkMulticast(java.net.InetAddress arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkMulticast20380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkMulticast20380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkTopLevelWindow20381;
		public virtual bool checkTopLevelWindow(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager._checkTopLevelWindow20381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkTopLevelWindow20381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkPrintJobAccess20382;
		public virtual void checkPrintJobAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPrintJobAccess20382);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPrintJobAccess20382);
		}
		internal static global::MonoJavaBridge.MethodId _checkSystemClipboardAccess20383;
		public virtual void checkSystemClipboardAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkSystemClipboardAccess20383);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkSystemClipboardAccess20383);
		}
		internal static global::MonoJavaBridge.MethodId _checkAwtEventQueueAccess20384;
		public virtual void checkAwtEventQueueAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkAwtEventQueueAccess20384);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkAwtEventQueueAccess20384);
		}
		internal static global::MonoJavaBridge.MethodId _checkPackageDefinition20385;
		public virtual void checkPackageDefinition(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.SecurityManager._checkPackageDefinition20385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._checkPackageDefinition20385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SecurityManager20386;
		public SecurityManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._SecurityManager20386);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SecurityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SecurityManager"));
			global::java.lang.SecurityManager._checkPackageAccess20345 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPackageAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkMemberAccess20346 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMemberAccess", "(Ljava/lang/Class;I)V");
			global::java.lang.SecurityManager._checkPermission20347 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;Ljava/lang/Object;)V");
			global::java.lang.SecurityManager._checkPermission20348 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;)V");
			global::java.lang.SecurityManager._checkCreateClassLoader20349 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkCreateClassLoader", "()V");
			global::java.lang.SecurityManager._checkPropertiesAccess20350 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPropertiesAccess", "()V");
			global::java.lang.SecurityManager._checkPropertyAccess20351 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPropertyAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._getThreadGroup20352 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.SecurityManager._checkAccess20353 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/Thread;)V");
			global::java.lang.SecurityManager._checkAccess20354 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/ThreadGroup;)V");
			global::java.lang.SecurityManager._checkExit20355 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkExit", "(I)V");
			global::java.lang.SecurityManager._checkLink20356 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkLink", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkRead20357 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/io/FileDescriptor;)V");
			global::java.lang.SecurityManager._checkRead20358 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.lang.SecurityManager._checkRead20359 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkWrite20360 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/io/FileDescriptor;)V");
			global::java.lang.SecurityManager._checkWrite20361 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkDelete20362 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkDelete", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkExec20363 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkExec", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._checkConnect20364 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;I)V");
			global::java.lang.SecurityManager._checkConnect20365 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V");
			global::java.lang.SecurityManager._checkSetFactory20366 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSetFactory", "()V");
			global::java.lang.SecurityManager._checkSecurityAccess20367 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSecurityAccess", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._getInCheck20368 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getInCheck", "()Z");
			global::java.lang.SecurityManager._getClassContext20369 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getClassContext", "()[Ljava/lang/Class;");
			global::java.lang.SecurityManager._currentClassLoader20370 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "currentClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.SecurityManager._currentLoadedClass20371 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "currentLoadedClass", "()Ljava/lang/Class;");
			global::java.lang.SecurityManager._classDepth20372 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "classDepth", "(Ljava/lang/String;)I");
			global::java.lang.SecurityManager._classLoaderDepth20373 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "classLoaderDepth", "()I");
			global::java.lang.SecurityManager._inClass20374 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "inClass", "(Ljava/lang/String;)Z");
			global::java.lang.SecurityManager._inClassLoader20375 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "inClassLoader", "()Z");
			global::java.lang.SecurityManager._getSecurityContext20376 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "getSecurityContext", "()Ljava/lang/Object;");
			global::java.lang.SecurityManager._checkListen20377 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkListen", "(I)V");
			global::java.lang.SecurityManager._checkAccept20378 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAccept", "(Ljava/lang/String;I)V");
			global::java.lang.SecurityManager._checkMulticast20379 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;)V");
			global::java.lang.SecurityManager._checkMulticast20380 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;B)V");
			global::java.lang.SecurityManager._checkTopLevelWindow20381 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkTopLevelWindow", "(Ljava/lang/Object;)Z");
			global::java.lang.SecurityManager._checkPrintJobAccess20382 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPrintJobAccess", "()V");
			global::java.lang.SecurityManager._checkSystemClipboardAccess20383 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkSystemClipboardAccess", "()V");
			global::java.lang.SecurityManager._checkAwtEventQueueAccess20384 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkAwtEventQueueAccess", "()V");
			global::java.lang.SecurityManager._checkPackageDefinition20385 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "checkPackageDefinition", "(Ljava/lang/String;)V");
			global::java.lang.SecurityManager._SecurityManager20386 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "<init>", "()V");
		}
	}
}
