namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadGroup : java.lang.Object, java.lang.Thread.UncaughtExceptionHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThreadGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _uncaughtException20875;
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._uncaughtException20875.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._uncaughtException20875 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._uncaughtException20875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString20876;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._toString20876.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._toString20876 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._toString20876) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20877;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._getName20877.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._getName20877 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getName20877) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent20878;
		public virtual global::java.lang.ThreadGroup getParent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._getParent20878.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._getParent20878 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getParent20878) as java.lang.ThreadGroup;
		}
		public new bool Daemon
		{
			set
			{
				setDaemon(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon20879;
		public virtual void setDaemon(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._setDaemon20879.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._setDaemon20879 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setDaemon20879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop20880;
		public virtual void stop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._stop20880.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._stop20880 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "stop", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._stop20880);
		}
		internal static global::MonoJavaBridge.MethodId _interrupt20881;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._interrupt20881.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._interrupt20881 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "interrupt", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._interrupt20881);
		}
		internal static global::MonoJavaBridge.MethodId _destroy20882;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._destroy20882.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._destroy20882 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "destroy", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._destroy20882);
		}
		internal static global::MonoJavaBridge.MethodId _suspend20883;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._suspend20883.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._suspend20883 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "suspend", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._suspend20883);
		}
		internal static global::MonoJavaBridge.MethodId _resume20884;
		public virtual void resume()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._resume20884.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._resume20884 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "resume", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._resume20884);
		}
		internal static global::MonoJavaBridge.MethodId _activeCount20885;
		public virtual int activeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._activeCount20885.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._activeCount20885 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeCount20885);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20886;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._enumerate20886.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._enumerate20886 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20887;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._enumerate20887.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._enumerate20887 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20888;
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._enumerate20888.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._enumerate20888 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20889;
		public virtual int enumerate(java.lang.Thread[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._enumerate20889.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._enumerate20889 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon20890;
		public virtual bool isDaemon()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._isDaemon20890.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._isDaemon20890 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDaemon20890);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20891;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._checkAccess20891.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._checkAccess20891 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._checkAccess20891);
		}
		public new int MaxPriority
		{
			get
			{
				return getMaxPriority();
			}
			set
			{
				setMaxPriority(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxPriority20892;
		public virtual int getMaxPriority()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._getMaxPriority20892.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._getMaxPriority20892 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getMaxPriority20892);
		}
		internal static global::MonoJavaBridge.MethodId _isDestroyed20893;
		public virtual bool isDestroyed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._isDestroyed20893.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._isDestroyed20893 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDestroyed20893);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxPriority20894;
		public virtual void setMaxPriority(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._setMaxPriority20894.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._setMaxPriority20894 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setMaxPriority20894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parentOf20895;
		public virtual bool parentOf(java.lang.ThreadGroup arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._parentOf20895.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._parentOf20895 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._parentOf20895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeGroupCount20896;
		public virtual int activeGroupCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._activeGroupCount20896.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._activeGroupCount20896 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeGroupCount20896);
		}
		internal static global::MonoJavaBridge.MethodId _list20897;
		public virtual void list()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._list20897.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._list20897 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "list", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._list20897);
		}
		internal static global::MonoJavaBridge.MethodId _allowThreadSuspension20898;
		public virtual bool allowThreadSuspension(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._allowThreadSuspension20898.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._allowThreadSuspension20898 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._allowThreadSuspension20898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup20899;
		public ThreadGroup(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._ThreadGroup20899.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._ThreadGroup20899 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup20899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup20900;
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._ThreadGroup20900.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._ThreadGroup20900 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup20900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ThreadGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadGroup"));
		}
		internal static void InitJNI()
		{
		}
	}
}
