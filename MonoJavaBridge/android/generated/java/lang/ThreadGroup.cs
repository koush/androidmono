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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", ref global::java.lang.ThreadGroup._uncaughtException20875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString20876;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.ThreadGroup._toString20876) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.ThreadGroup._getName20877) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;", ref global::java.lang.ThreadGroup._getParent20878) as java.lang.ThreadGroup;
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V", ref global::java.lang.ThreadGroup._setDaemon20879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop20880;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "stop", "()V", ref global::java.lang.ThreadGroup._stop20880);
		}
		internal static global::MonoJavaBridge.MethodId _interrupt20881;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "interrupt", "()V", ref global::java.lang.ThreadGroup._interrupt20881);
		}
		internal static global::MonoJavaBridge.MethodId _destroy20882;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "destroy", "()V", ref global::java.lang.ThreadGroup._destroy20882);
		}
		internal static global::MonoJavaBridge.MethodId _suspend20883;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "suspend", "()V", ref global::java.lang.ThreadGroup._suspend20883);
		}
		internal static global::MonoJavaBridge.MethodId _resume20884;
		public virtual void resume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "resume", "()V", ref global::java.lang.ThreadGroup._resume20884);
		}
		internal static global::MonoJavaBridge.MethodId _activeCount20885;
		public virtual int activeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "activeCount", "()I", ref global::java.lang.ThreadGroup._activeCount20885);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20886;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I", ref global::java.lang.ThreadGroup._enumerate20886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20887;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I", ref global::java.lang.ThreadGroup._enumerate20887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20888;
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I", ref global::java.lang.ThreadGroup._enumerate20888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20889;
		public virtual int enumerate(java.lang.Thread[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I", ref global::java.lang.ThreadGroup._enumerate20889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon20890;
		public virtual bool isDaemon()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z", ref global::java.lang.ThreadGroup._isDaemon20890);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20891;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V", ref global::java.lang.ThreadGroup._checkAccess20891);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I", ref global::java.lang.ThreadGroup._getMaxPriority20892);
		}
		internal static global::MonoJavaBridge.MethodId _isDestroyed20893;
		public virtual bool isDestroyed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z", ref global::java.lang.ThreadGroup._isDestroyed20893);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxPriority20894;
		public virtual void setMaxPriority(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V", ref global::java.lang.ThreadGroup._setMaxPriority20894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parentOf20895;
		public virtual bool parentOf(java.lang.ThreadGroup arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z", ref global::java.lang.ThreadGroup._parentOf20895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeGroupCount20896;
		public virtual int activeGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I", ref global::java.lang.ThreadGroup._activeGroupCount20896);
		}
		internal static global::MonoJavaBridge.MethodId _list20897;
		public virtual void list()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "list", "()V", ref global::java.lang.ThreadGroup._list20897);
		}
		internal static global::MonoJavaBridge.MethodId _allowThreadSuspension20898;
		public virtual bool allowThreadSuspension(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z", ref global::java.lang.ThreadGroup._allowThreadSuspension20898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
