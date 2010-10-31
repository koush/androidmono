namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Thread : java.lang.Object, Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Thread(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class State : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal State(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.Thread.State[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.lang.Thread.State._m0.native == global::System.IntPtr.Zero)
					global::java.lang.Thread.State._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._m0)) as java.lang.Thread.State[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.lang.Thread.State valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.lang.Thread.State._m1.native == global::System.IntPtr.Zero)
					global::java.lang.Thread.State._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Thread.State;
			}
			internal static global::MonoJavaBridge.FieldId _NEW6399;
			public static global::java.lang.Thread.State NEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _NEW6399)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNABLE6400;
			public static global::java.lang.Thread.State RUNNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _RUNNABLE6400)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCKED6401;
			public static global::java.lang.Thread.State BLOCKED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _BLOCKED6401)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WAITING6402;
			public static global::java.lang.Thread.State WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _WAITING6402)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIMED_WAITING6403;
			public static global::java.lang.Thread.State TIMED_WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TIMED_WAITING6403)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TERMINATED6404;
			public static global::java.lang.Thread.State TERMINATED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TERMINATED6404)) as java.lang.Thread.State;
				}
			}
			static State()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$State"));
				global::java.lang.Thread.State._NEW6399 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "NEW", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._RUNNABLE6400 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "RUNNABLE", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._BLOCKED6401 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "BLOCKED", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._WAITING6402 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TIMED_WAITING6403 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TIMED_WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TERMINATED6404 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TERMINATED", "Ljava/lang/Thread$State;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Thread.UncaughtExceptionHandler_))]
		public partial interface UncaughtExceptionHandler  : global::MonoJavaBridge.IJavaObject 
		{
			void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Thread.UncaughtExceptionHandler))]
		internal sealed partial class UncaughtExceptionHandler_ : java.lang.Object, UncaughtExceptionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal UncaughtExceptionHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void java.lang.Thread.UncaughtExceptionHandler.uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", ref global::java.lang.Thread.UncaughtExceptionHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static UncaughtExceptionHandler_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.UncaughtExceptionHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$UncaughtExceptionHandler"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "run", "()V", ref global::java.lang.Thread._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Thread._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isInterrupted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Thread.staticClass, "isInterrupted", "()Z", ref global::java.lang.Thread._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.Thread currentThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m3.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m3)) as java.lang.Thread;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
			set
			{
				setName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.Thread._m4) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.ThreadGroup getThreadGroup()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;", ref global::java.lang.Thread._m5) as java.lang.ThreadGroup;
		}
		public new global::java.lang.StackTraceElement[] StackTrace
		{
			get
			{
				return getStackTrace();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.StackTraceElement[] getStackTrace()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.StackTraceElement>(this, global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;", ref global::java.lang.Thread._m6) as java.lang.StackTraceElement[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void dumpStack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m7.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "dumpStack", "()V");
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setPriority(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "setPriority", "(I)V", ref global::java.lang.Thread._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Daemon
		{
			set
			{
				setDaemon(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDaemon(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "setDaemon", "(Z)V", ref global::java.lang.Thread._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "start", "()V", ref global::java.lang.Thread._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void yield()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "yield", "()V");
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void sleep(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(J)V");
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void sleep(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m13.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(JI)V");
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "stop", "()V", ref global::java.lang.Thread._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void stop(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V", ref global::java.lang.Thread._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "interrupt", "()V", ref global::java.lang.Thread._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static bool interrupted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m17.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupted", "()Z");
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "destroy", "()V", ref global::java.lang.Thread._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isAlive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Thread.staticClass, "isAlive", "()Z", ref global::java.lang.Thread._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "suspend", "()V", ref global::java.lang.Thread._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void resume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "resume", "()V", ref global::java.lang.Thread._m21);
		}
		public new int Priority
		{
			get
			{
				return getPriority();
			}
			set
			{
				setPriority(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getPriority()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Thread.staticClass, "getPriority", "()I", ref global::java.lang.Thread._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V", ref global::java.lang.Thread._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int activeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m24.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m24 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "activeCount", "()I");
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static int enumerate(java.lang.Thread[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m25.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m25 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int countStackFrames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Thread.staticClass, "countStackFrames", "()I", ref global::java.lang.Thread._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void join()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "join", "()V", ref global::java.lang.Thread._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void join(long arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "join", "(JI)V", ref global::java.lang.Thread._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void join(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "join", "(J)V", ref global::java.lang.Thread._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool isDaemon()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Thread.staticClass, "isDaemon", "()Z", ref global::java.lang.Thread._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "checkAccess", "()V", ref global::java.lang.Thread._m31);
		}
		public new global::java.lang.ClassLoader ContextClassLoader
		{
			get
			{
				return getContextClassLoader();
			}
			set
			{
				setContextClassLoader(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.lang.ClassLoader getContextClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;", ref global::java.lang.Thread._m32) as java.lang.ClassLoader;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V", ref global::java.lang.Thread._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static bool holdsLock(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m34.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m34 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Map AllStackTraces
		{
			get
			{
				return getAllStackTraces();
			}
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static global::java.util.Map getAllStackTraces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m35.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m35 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m35)) as java.util.Map;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual long getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Thread.staticClass, "getId", "()J", ref global::java.lang.Thread._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::java.lang.Thread.State getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Thread.State>(this, global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;", ref global::java.lang.Thread._m37) as java.lang.Thread.State;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m38.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m38 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.Thread.UncaughtExceptionHandler DefaultUncaughtExceptionHandler
		{
			get
			{
				return getDefaultUncaughtExceptionHandler();
			}
			set
			{
				setDefaultUncaughtExceptionHandler(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static global::java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m39.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m39 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._m39)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Thread.UncaughtExceptionHandler>(this, global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;", ref global::java.lang.Thread._m40) as java.lang.Thread.UncaughtExceptionHandler;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V", ref global::java.lang.Thread._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m42.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m42 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m43.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m43 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m44.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m44 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public Thread(java.lang.Runnable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m45.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m45 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public Thread(java.lang.Runnable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m46.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m46 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m47.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m47 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public Thread(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m48.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m48 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public Thread() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Thread._m49.native == global::System.IntPtr.Zero)
				global::java.lang.Thread._m49 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._m49);
			Init(@__env, handle);
		}
		public static int MIN_PRIORITY
		{
			get
			{
				return 1;
			}
		}
		public static int NORM_PRIORITY
		{
			get
			{
				return 5;
			}
		}
		public static int MAX_PRIORITY
		{
			get
			{
				return 10;
			}
		}
		static Thread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Thread.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread"));
		}
	}
}
