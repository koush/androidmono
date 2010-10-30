namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadGroup : java.lang.Object, java.lang.Thread.UncaughtExceptionHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThreadGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", ref global::java.lang.ThreadGroup._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.ThreadGroup.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.ThreadGroup._m1) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.ThreadGroup.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.ThreadGroup._m2) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup Parent
		{
			get
			{
				return getParent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.ThreadGroup getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.ThreadGroup.staticClass, "getParent", "()Ljava/lang/ThreadGroup;", ref global::java.lang.ThreadGroup._m3) as java.lang.ThreadGroup;
		}
		public new bool Daemon
		{
			set
			{
				setDaemon(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setDaemon(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "setDaemon", "(Z)V", ref global::java.lang.ThreadGroup._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "stop", "()V", ref global::java.lang.ThreadGroup._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "interrupt", "()V", ref global::java.lang.ThreadGroup._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "destroy", "()V", ref global::java.lang.ThreadGroup._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "suspend", "()V", ref global::java.lang.ThreadGroup._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void resume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "resume", "()V", ref global::java.lang.ThreadGroup._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int activeCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "activeCount", "()I", ref global::java.lang.ThreadGroup._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;)I", ref global::java.lang.ThreadGroup._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int enumerate(java.lang.ThreadGroup[] arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/ThreadGroup;Z)I", ref global::java.lang.ThreadGroup._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int enumerate(java.lang.Thread[] arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;Z)I", ref global::java.lang.ThreadGroup._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int enumerate(java.lang.Thread[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "enumerate", "([Ljava/lang/Thread;)I", ref global::java.lang.ThreadGroup._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isDaemon()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "isDaemon", "()Z", ref global::java.lang.ThreadGroup._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "checkAccess", "()V", ref global::java.lang.ThreadGroup._m16);
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
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getMaxPriority()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "getMaxPriority", "()I", ref global::java.lang.ThreadGroup._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool isDestroyed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "isDestroyed", "()Z", ref global::java.lang.ThreadGroup._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setMaxPriority(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "setMaxPriority", "(I)V", ref global::java.lang.ThreadGroup._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool parentOf(java.lang.ThreadGroup arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "parentOf", "(Ljava/lang/ThreadGroup;)Z", ref global::java.lang.ThreadGroup._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int activeGroupCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.ThreadGroup.staticClass, "activeGroupCount", "()I", ref global::java.lang.ThreadGroup._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void list()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.ThreadGroup.staticClass, "list", "()V", ref global::java.lang.ThreadGroup._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool allowThreadSuspension(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.ThreadGroup.staticClass, "allowThreadSuspension", "(Z)Z", ref global::java.lang.ThreadGroup._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public ThreadGroup(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._m24.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._m24 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public ThreadGroup(java.lang.ThreadGroup arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadGroup._m25.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadGroup._m25 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadGroup.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadGroup.staticClass, global::java.lang.ThreadGroup._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
