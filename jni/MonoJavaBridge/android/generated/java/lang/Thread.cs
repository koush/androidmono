namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Thread : java.lang.Object, Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Thread()
		{
			InitJNI();
		}
		protected Thread(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class State : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static State()
			{
				InitJNI();
			}
			internal State(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values15174;
			public static global::java.lang.Thread.State[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._values15174)) as java.lang.Thread.State[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf15175;
			public static global::java.lang.Thread.State valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._valueOf15175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Thread.State;
			}
			internal static global::MonoJavaBridge.FieldId _NEW15176;
			public static global::java.lang.Thread.State NEW
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNABLE15177;
			public static global::java.lang.Thread.State RUNNABLE
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCKED15178;
			public static global::java.lang.Thread.State BLOCKED
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _WAITING15179;
			public static global::java.lang.Thread.State WAITING
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIMED_WAITING15180;
			public static global::java.lang.Thread.State TIMED_WAITING
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TERMINATED15181;
			public static global::java.lang.Thread.State TERMINATED
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$State"));
				global::java.lang.Thread.State._values15174 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;");
				global::java.lang.Thread.State._valueOf15175 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Thread.UncaughtExceptionHandler_))]
		public interface UncaughtExceptionHandler  : global::MonoJavaBridge.IJavaObject 
		{
			void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Thread.UncaughtExceptionHandler))]
		public sealed partial class UncaughtExceptionHandler_ : java.lang.Object, UncaughtExceptionHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static UncaughtExceptionHandler_()
			{
				InitJNI();
			}
			internal UncaughtExceptionHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _uncaughtException15182;
			 void java.lang.Thread.UncaughtExceptionHandler.uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException15182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException15182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.UncaughtExceptionHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$UncaughtExceptionHandler"));
				global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException15182 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _run15183;
		public virtual void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._run15183);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._run15183);
		}
		internal static global::MonoJavaBridge.MethodId _toString15184;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._toString15184)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._toString15184)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isInterrupted15185;
		public virtual bool isInterrupted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isInterrupted15185);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isInterrupted15185);
		}
		internal static global::MonoJavaBridge.MethodId _currentThread15186;
		public static global::java.lang.Thread currentThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._currentThread15186)) as java.lang.Thread;
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
		internal static global::MonoJavaBridge.MethodId _getName15187;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getName15187)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getName15187)) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup15188;
		public virtual global::java.lang.ThreadGroup getThreadGroup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getThreadGroup15188)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getThreadGroup15188)) as java.lang.ThreadGroup;
		}
		public new global::java.lang.StackTraceElement[] StackTrace
		{
			get
			{
				return getStackTrace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStackTrace15189;
		public virtual global::java.lang.StackTraceElement[] getStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getStackTrace15189)) as java.lang.StackTraceElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getStackTrace15189)) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _dumpStack15190;
		public static void dumpStack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._dumpStack15190);
		}
		internal static global::MonoJavaBridge.MethodId _setPriority15191;
		public virtual void setPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setPriority15191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setPriority15191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon15192;
		public virtual void setDaemon(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setDaemon15192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setDaemon15192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start15193;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._start15193);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._start15193);
		}
		internal static global::MonoJavaBridge.MethodId _yield15194;
		public static void yield() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._yield15194);
		}
		internal static global::MonoJavaBridge.MethodId _sleep15195;
		public static void sleep(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep15195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sleep15196;
		public static void sleep(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep15196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stop15197;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._stop15197);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop15197);
		}
		internal static global::MonoJavaBridge.MethodId _stop15198;
		public virtual void stop(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._stop15198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop15198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _interrupt15199;
		public virtual void interrupt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._interrupt15199);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._interrupt15199);
		}
		internal static global::MonoJavaBridge.MethodId _interrupted15200;
		public static bool interrupted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._interrupted15200);
		}
		internal static global::MonoJavaBridge.MethodId _destroy15201;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._destroy15201);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._destroy15201);
		}
		internal static global::MonoJavaBridge.MethodId _isAlive15202;
		public virtual bool isAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isAlive15202);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isAlive15202);
		}
		internal static global::MonoJavaBridge.MethodId _suspend15203;
		public virtual void suspend() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._suspend15203);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._suspend15203);
		}
		internal static global::MonoJavaBridge.MethodId _resume15204;
		public virtual void resume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._resume15204);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._resume15204);
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
		internal static global::MonoJavaBridge.MethodId _getPriority15205;
		public virtual int getPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Thread._getPriority15205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getPriority15205);
		}
		internal static global::MonoJavaBridge.MethodId _setName15206;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setName15206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setName15206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeCount15207;
		public static int activeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._activeCount15207);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate15208;
		public static int enumerate(java.lang.Thread[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._enumerate15208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countStackFrames15209;
		public virtual int countStackFrames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Thread._countStackFrames15209);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._countStackFrames15209);
		}
		internal static global::MonoJavaBridge.MethodId _join15210;
		public virtual void join() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join15210);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join15210);
		}
		internal static global::MonoJavaBridge.MethodId _join15211;
		public virtual void join(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join15211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join15211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join15212;
		public virtual void join(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join15212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join15212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon15213;
		public virtual bool isDaemon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isDaemon15213);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isDaemon15213);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess15214;
		public virtual void checkAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._checkAccess15214);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._checkAccess15214);
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
		internal static global::MonoJavaBridge.MethodId _getContextClassLoader15215;
		public virtual global::java.lang.ClassLoader getContextClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getContextClassLoader15215)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getContextClassLoader15215)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _setContextClassLoader15216;
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setContextClassLoader15216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setContextClassLoader15216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _holdsLock15217;
		public static bool holdsLock(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._holdsLock15217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Map AllStackTraces
		{
			get
			{
				return getAllStackTraces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllStackTraces15218;
		public static global::java.util.Map getAllStackTraces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getAllStackTraces15218)) as java.util.Map;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId15219;
		public virtual long getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Thread._getId15219);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getId15219);
		}
		internal static global::MonoJavaBridge.MethodId _getState15220;
		public virtual global::java.lang.Thread.State getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getState15220)) as java.lang.Thread.State;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getState15220)) as java.lang.Thread.State;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUncaughtExceptionHandler15221;
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._setDefaultUncaughtExceptionHandler15221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultUncaughtExceptionHandler15222;
		public static global::java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getDefaultUncaughtExceptionHandler15222)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getUncaughtExceptionHandler15223;
		public virtual global::java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getUncaughtExceptionHandler15223)) as java.lang.Thread.UncaughtExceptionHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getUncaughtExceptionHandler15223)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setUncaughtExceptionHandler15224;
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setUncaughtExceptionHandler15224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setUncaughtExceptionHandler15224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Thread15225;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread15226;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread15227;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread15228;
		public Thread(java.lang.Runnable arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread15229;
		public Thread(java.lang.Runnable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread15230;
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread15231;
		public Thread(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread15232;
		public Thread()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread15232);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Thread.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread"));
			global::java.lang.Thread._run15183 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "run", "()V");
			global::java.lang.Thread._toString15184 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Thread._isInterrupted15185 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isInterrupted", "()Z");
			global::java.lang.Thread._currentThread15186 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;");
			global::java.lang.Thread._getName15187 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Thread._getThreadGroup15188 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.Thread._getStackTrace15189 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Thread._dumpStack15190 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "dumpStack", "()V");
			global::java.lang.Thread._setPriority15191 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setPriority", "(I)V");
			global::java.lang.Thread._setDaemon15192 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDaemon", "(Z)V");
			global::java.lang.Thread._start15193 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "start", "()V");
			global::java.lang.Thread._yield15194 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "yield", "()V");
			global::java.lang.Thread._sleep15195 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(J)V");
			global::java.lang.Thread._sleep15196 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(JI)V");
			global::java.lang.Thread._stop15197 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "()V");
			global::java.lang.Thread._stop15198 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V");
			global::java.lang.Thread._interrupt15199 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupt", "()V");
			global::java.lang.Thread._interrupted15200 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupted", "()Z");
			global::java.lang.Thread._destroy15201 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "destroy", "()V");
			global::java.lang.Thread._isAlive15202 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isAlive", "()Z");
			global::java.lang.Thread._suspend15203 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "suspend", "()V");
			global::java.lang.Thread._resume15204 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "resume", "()V");
			global::java.lang.Thread._getPriority15205 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getPriority", "()I");
			global::java.lang.Thread._setName15206 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V");
			global::java.lang.Thread._activeCount15207 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "activeCount", "()I");
			global::java.lang.Thread._enumerate15208 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.Thread._countStackFrames15209 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "countStackFrames", "()I");
			global::java.lang.Thread._join15210 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "()V");
			global::java.lang.Thread._join15211 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(JI)V");
			global::java.lang.Thread._join15212 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(J)V");
			global::java.lang.Thread._isDaemon15213 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isDaemon", "()Z");
			global::java.lang.Thread._checkAccess15214 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "checkAccess", "()V");
			global::java.lang.Thread._getContextClassLoader15215 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Thread._setContextClassLoader15216 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.Thread._holdsLock15217 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z");
			global::java.lang.Thread._getAllStackTraces15218 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;");
			global::java.lang.Thread._getId15219 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getId", "()J");
			global::java.lang.Thread._getState15220 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;");
			global::java.lang.Thread._setDefaultUncaughtExceptionHandler15221 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._getDefaultUncaughtExceptionHandler15222 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._getUncaughtExceptionHandler15223 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._setUncaughtExceptionHandler15224 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._Thread15225 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread15226 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
			global::java.lang.Thread._Thread15227 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread15228 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread15229 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread15230 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread15231 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Thread._Thread15232 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "()V");
		}
	}
}
