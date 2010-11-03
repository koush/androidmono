namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecurityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecurityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void checkPackageAccess(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPackageAccess", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void checkMemberAccess(java.lang.Class arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkMemberAccess", "(Ljava/lang/Class;I)V", ref global::java.lang.SecurityManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void checkPermission(java.security.Permission arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;Ljava/lang/Object;)V", ref global::java.lang.SecurityManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void checkPermission(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPermission", "(Ljava/security/Permission;)V", ref global::java.lang.SecurityManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void checkCreateClassLoader()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkCreateClassLoader", "()V", ref global::java.lang.SecurityManager._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void checkPropertiesAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPropertiesAccess", "()V", ref global::java.lang.SecurityManager._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void checkPropertyAccess(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPropertyAccess", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.ThreadGroup getThreadGroup()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.SecurityManager.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;", ref global::java.lang.SecurityManager._m7) as java.lang.ThreadGroup;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void checkAccess(java.lang.Thread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/Thread;)V", ref global::java.lang.SecurityManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void checkAccess(java.lang.ThreadGroup arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAccess", "(Ljava/lang/ThreadGroup;)V", ref global::java.lang.SecurityManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void checkExit(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkExit", "(I)V", ref global::java.lang.SecurityManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void checkLink(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkLink", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void checkRead(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/io/FileDescriptor;)V", ref global::java.lang.SecurityManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void checkRead(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::java.lang.SecurityManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void checkRead(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkRead", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void checkWrite(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/io/FileDescriptor;)V", ref global::java.lang.SecurityManager._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void checkWrite(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkWrite", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void checkDelete(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkDelete", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void checkExec(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkExec", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void checkConnect(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;I)V", ref global::java.lang.SecurityManager._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void checkConnect(java.lang.String arg0, int arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkConnect", "(Ljava/lang/String;ILjava/lang/Object;)V", ref global::java.lang.SecurityManager._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void checkSetFactory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkSetFactory", "()V", ref global::java.lang.SecurityManager._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void checkSecurityAccess(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkSecurityAccess", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool InCheck
		{
			get
			{
				return getInCheck();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool getInCheck()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "getInCheck", "()Z", ref global::java.lang.SecurityManager._m23);
		}
		protected new global::java.lang.Class[] ClassContext
		{
			get
			{
				return getClassContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		protected virtual global::java.lang.Class[] getClassContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.SecurityManager.staticClass, "getClassContext", "()[Ljava/lang/Class;", ref global::java.lang.SecurityManager._m24) as java.lang.Class[];
		}
		private static global::MonoJavaBridge.MethodId _m25;
		protected virtual global::java.lang.ClassLoader currentClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.SecurityManager.staticClass, "currentClassLoader", "()Ljava/lang/ClassLoader;", ref global::java.lang.SecurityManager._m25) as java.lang.ClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual global::java.lang.Class currentLoadedClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.SecurityManager.staticClass, "currentLoadedClass", "()Ljava/lang/Class;", ref global::java.lang.SecurityManager._m26) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected virtual int classDepth(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.SecurityManager.staticClass, "classDepth", "(Ljava/lang/String;)I", ref global::java.lang.SecurityManager._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		protected virtual int classLoaderDepth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.SecurityManager.staticClass, "classLoaderDepth", "()I", ref global::java.lang.SecurityManager._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected virtual bool inClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "inClass", "(Ljava/lang/String;)Z", ref global::java.lang.SecurityManager._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		protected virtual bool inClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "inClassLoader", "()Z", ref global::java.lang.SecurityManager._m30);
		}
		public new global::java.lang.Object SecurityContext
		{
			get
			{
				return getSecurityContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.lang.Object getSecurityContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.SecurityManager.staticClass, "getSecurityContext", "()Ljava/lang/Object;", ref global::java.lang.SecurityManager._m31) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void checkListen(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkListen", "(I)V", ref global::java.lang.SecurityManager._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void checkAccept(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAccept", "(Ljava/lang/String;I)V", ref global::java.lang.SecurityManager._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void checkMulticast(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;)V", ref global::java.lang.SecurityManager._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void checkMulticast(java.net.InetAddress arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkMulticast", "(Ljava/net/InetAddress;B)V", ref global::java.lang.SecurityManager._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual bool checkTopLevelWindow(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SecurityManager.staticClass, "checkTopLevelWindow", "(Ljava/lang/Object;)Z", ref global::java.lang.SecurityManager._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void checkPrintJobAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPrintJobAccess", "()V", ref global::java.lang.SecurityManager._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void checkSystemClipboardAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkSystemClipboardAccess", "()V", ref global::java.lang.SecurityManager._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void checkAwtEventQueueAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkAwtEventQueueAccess", "()V", ref global::java.lang.SecurityManager._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void checkPackageDefinition(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.SecurityManager.staticClass, "checkPackageDefinition", "(Ljava/lang/String;)V", ref global::java.lang.SecurityManager._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public SecurityManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.SecurityManager._m41.native == global::System.IntPtr.Zero)
				global::java.lang.SecurityManager._m41 = @__env.GetMethodIDNoThrow(global::java.lang.SecurityManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.SecurityManager.staticClass, global::java.lang.SecurityManager._m41);
			Init(@__env, handle);
		}
		static SecurityManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SecurityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SecurityManager"));
		}
	}
}
