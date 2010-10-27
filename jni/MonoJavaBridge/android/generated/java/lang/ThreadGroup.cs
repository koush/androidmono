namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadGroup : java.lang.Object, java.lang.Thread.UncaughtExceptionHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ThreadGroup()
		{
			InitJNI();
		}
		protected ThreadGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _uncaughtException20874;
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._uncaughtException20874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._uncaughtException20874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toString20875;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._toString20875)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._toString20875)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20876;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._getName20876)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getName20876)) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent20877;
		public virtual global::java.lang.ThreadGroup getParent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup._getParent20877)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getParent20877)) as java.lang.ThreadGroup;
		}
		public new bool Daemon
		{
			set
			{
				setDaemon(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon20878;
		public virtual void setDaemon(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._setDaemon20878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setDaemon20878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop20879;
		public virtual void stop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._stop20879);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._stop20879);
		}
		internal static global::MonoJavaBridge.MethodId _interrupt20880;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._interrupt20880);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._interrupt20880);
		}
		internal static global::MonoJavaBridge.MethodId _destroy20881;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._destroy20881);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._destroy20881);
		}
		internal static global::MonoJavaBridge.MethodId _suspend20882;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._suspend20882);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._suspend20882);
		}
		internal static global::MonoJavaBridge.MethodId _resume20883;
		public virtual void resume()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._resume20883);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._resume20883);
		}
		internal static global::MonoJavaBridge.MethodId _activeCount20884;
		public virtual int activeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._activeCount20884);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeCount20884);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20885;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20886;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20887;
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20888;
		public virtual int enumerate(java.lang.Thread[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._enumerate20888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._enumerate20888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon20889;
		public virtual bool isDaemon()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._isDaemon20889);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDaemon20889);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20890;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._checkAccess20890);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._checkAccess20890);
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
		internal static global::MonoJavaBridge.MethodId _getMaxPriority20891;
		public virtual int getMaxPriority()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._getMaxPriority20891);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._getMaxPriority20891);
		}
		internal static global::MonoJavaBridge.MethodId _isDestroyed20892;
		public virtual bool isDestroyed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._isDestroyed20892);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._isDestroyed20892);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxPriority20893;
		public virtual void setMaxPriority(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._setMaxPriority20893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._setMaxPriority20893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parentOf20894;
		public virtual bool parentOf(java.lang.ThreadGroup arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._parentOf20894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._parentOf20894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeGroupCount20895;
		public virtual int activeGroupCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.ThreadGroup._activeGroupCount20895);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._activeGroupCount20895);
		}
		internal static global::MonoJavaBridge.MethodId _list20896;
		public virtual void list()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup._list20896);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._list20896);
		}
		internal static global::MonoJavaBridge.MethodId _allowThreadSuspension20897;
		public virtual bool allowThreadSuspension(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup._allowThreadSuspension20897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._allowThreadSuspension20897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup20898;
		public ThreadGroup(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup20898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ThreadGroup20899;
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._ThreadGroup20899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadGroup"));
			global::java.lang.ThreadGroup._uncaughtException20874 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			global::java.lang.ThreadGroup._toString20875 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getName20876 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.ThreadGroup._getParent20877 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;");
			global::java.lang.ThreadGroup._setDaemon20878 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V");
			global::java.lang.ThreadGroup._stop20879 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "stop", "()V");
			global::java.lang.ThreadGroup._interrupt20880 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "interrupt", "()V");
			global::java.lang.ThreadGroup._destroy20881 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "destroy", "()V");
			global::java.lang.ThreadGroup._suspend20882 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "suspend", "()V");
			global::java.lang.ThreadGroup._resume20883 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "resume", "()V");
			global::java.lang.ThreadGroup._activeCount20884 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeCount", "()I");
			global::java.lang.ThreadGroup._enumerate20885 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I");
			global::java.lang.ThreadGroup._enumerate20886 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I");
			global::java.lang.ThreadGroup._enumerate20887 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I");
			global::java.lang.ThreadGroup._enumerate20888 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.ThreadGroup._isDaemon20889 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z");
			global::java.lang.ThreadGroup._checkAccess20890 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V");
			global::java.lang.ThreadGroup._getMaxPriority20891 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I");
			global::java.lang.ThreadGroup._isDestroyed20892 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z");
			global::java.lang.ThreadGroup._setMaxPriority20893 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V");
			global::java.lang.ThreadGroup._parentOf20894 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z");
			global::java.lang.ThreadGroup._activeGroupCount20895 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I");
			global::java.lang.ThreadGroup._list20896 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "list", "()V");
			global::java.lang.ThreadGroup._allowThreadSuspension20897 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z");
			global::java.lang.ThreadGroup._ThreadGroup20898 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.ThreadGroup._ThreadGroup20899 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
		}
	}
}
