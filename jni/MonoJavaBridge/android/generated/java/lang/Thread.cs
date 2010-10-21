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
			internal static global::MonoJavaBridge.MethodId _values20693;
			public static global::java.lang.Thread.State[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._values20693)) as java.lang.Thread.State[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf20694;
			public static global::java.lang.Thread.State valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._valueOf20694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Thread.State;
			}
			internal static global::MonoJavaBridge.FieldId _NEW20695;
			public static global::java.lang.Thread.State NEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _NEW20695)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNABLE20696;
			public static global::java.lang.Thread.State RUNNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _RUNNABLE20696)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCKED20697;
			public static global::java.lang.Thread.State BLOCKED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _BLOCKED20697)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WAITING20698;
			public static global::java.lang.Thread.State WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _WAITING20698)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIMED_WAITING20699;
			public static global::java.lang.Thread.State TIMED_WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TIMED_WAITING20699)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TERMINATED20700;
			public static global::java.lang.Thread.State TERMINATED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TERMINATED20700)) as java.lang.Thread.State;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$State"));
				global::java.lang.Thread.State._values20693 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;");
				global::java.lang.Thread.State._valueOf20694 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._NEW20695 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "NEW", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._RUNNABLE20696 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "RUNNABLE", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._BLOCKED20697 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "BLOCKED", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._WAITING20698 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TIMED_WAITING20699 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TIMED_WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TERMINATED20700 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TERMINATED", "Ljava/lang/Thread$State;");
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
			internal static global::MonoJavaBridge.MethodId _uncaughtException20701;
			 void java.lang.Thread.UncaughtExceptionHandler.uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.UncaughtExceptionHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$UncaughtExceptionHandler"));
				global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20701 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _run20702;
		public virtual void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._run20702);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._run20702);
		}
		internal static global::MonoJavaBridge.MethodId _toString20703;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._toString20703)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._toString20703)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isInterrupted20704;
		public virtual bool isInterrupted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isInterrupted20704);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isInterrupted20704);
		}
		internal static global::MonoJavaBridge.MethodId _currentThread20705;
		public static global::java.lang.Thread currentThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._currentThread20705)) as java.lang.Thread;
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
		internal static global::MonoJavaBridge.MethodId _getName20706;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getName20706)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getName20706)) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup20707;
		public virtual global::java.lang.ThreadGroup getThreadGroup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getThreadGroup20707)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getThreadGroup20707)) as java.lang.ThreadGroup;
		}
		public new global::java.lang.StackTraceElement[] StackTrace
		{
			get
			{
				return getStackTrace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStackTrace20708;
		public virtual global::java.lang.StackTraceElement[] getStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getStackTrace20708)) as java.lang.StackTraceElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getStackTrace20708)) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _dumpStack20709;
		public static void dumpStack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._dumpStack20709);
		}
		internal static global::MonoJavaBridge.MethodId _setPriority20710;
		public virtual void setPriority(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setPriority20710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setPriority20710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon20711;
		public virtual void setDaemon(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setDaemon20711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setDaemon20711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start20712;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._start20712);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._start20712);
		}
		internal static global::MonoJavaBridge.MethodId _yield20713;
		public static void yield() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._yield20713);
		}
		internal static global::MonoJavaBridge.MethodId _sleep20714;
		public static void sleep(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep20714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sleep20715;
		public static void sleep(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep20715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stop20716;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._stop20716);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop20716);
		}
		internal static global::MonoJavaBridge.MethodId _stop20717;
		public virtual void stop(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._stop20717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop20717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _interrupt20718;
		public virtual void interrupt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._interrupt20718);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._interrupt20718);
		}
		internal static global::MonoJavaBridge.MethodId _interrupted20719;
		public static bool interrupted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._interrupted20719);
		}
		internal static global::MonoJavaBridge.MethodId _destroy20720;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._destroy20720);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._destroy20720);
		}
		internal static global::MonoJavaBridge.MethodId _isAlive20721;
		public virtual bool isAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isAlive20721);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isAlive20721);
		}
		internal static global::MonoJavaBridge.MethodId _suspend20722;
		public virtual void suspend() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._suspend20722);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._suspend20722);
		}
		internal static global::MonoJavaBridge.MethodId _resume20723;
		public virtual void resume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._resume20723);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._resume20723);
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
		internal static global::MonoJavaBridge.MethodId _getPriority20724;
		public virtual int getPriority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Thread._getPriority20724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getPriority20724);
		}
		internal static global::MonoJavaBridge.MethodId _setName20725;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setName20725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setName20725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeCount20726;
		public static int activeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._activeCount20726);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20727;
		public static int enumerate(java.lang.Thread[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._enumerate20727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countStackFrames20728;
		public virtual int countStackFrames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Thread._countStackFrames20728);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._countStackFrames20728);
		}
		internal static global::MonoJavaBridge.MethodId _join20729;
		public virtual void join() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join20729);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20729);
		}
		internal static global::MonoJavaBridge.MethodId _join20730;
		public virtual void join(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join20730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join20731;
		public virtual void join(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join20731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon20732;
		public virtual bool isDaemon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isDaemon20732);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isDaemon20732);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20733;
		public virtual void checkAccess() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._checkAccess20733);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._checkAccess20733);
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
		internal static global::MonoJavaBridge.MethodId _getContextClassLoader20734;
		public virtual global::java.lang.ClassLoader getContextClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getContextClassLoader20734)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getContextClassLoader20734)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _setContextClassLoader20735;
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setContextClassLoader20735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setContextClassLoader20735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _holdsLock20736;
		public static bool holdsLock(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._holdsLock20736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Map AllStackTraces
		{
			get
			{
				return getAllStackTraces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllStackTraces20737;
		public static global::java.util.Map getAllStackTraces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getAllStackTraces20737)) as java.util.Map;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId20738;
		public virtual long getId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Thread._getId20738);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getId20738);
		}
		internal static global::MonoJavaBridge.MethodId _getState20739;
		public virtual global::java.lang.Thread.State getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getState20739)) as java.lang.Thread.State;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getState20739)) as java.lang.Thread.State;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUncaughtExceptionHandler20740;
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._setDefaultUncaughtExceptionHandler20740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultUncaughtExceptionHandler20741;
		public static global::java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getDefaultUncaughtExceptionHandler20741)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getUncaughtExceptionHandler20742;
		public virtual global::java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getUncaughtExceptionHandler20742)) as java.lang.Thread.UncaughtExceptionHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getUncaughtExceptionHandler20742)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setUncaughtExceptionHandler20743;
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setUncaughtExceptionHandler20743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setUncaughtExceptionHandler20743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Thread20744;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20745;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20746;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20747;
		public Thread(java.lang.Runnable arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20748;
		public Thread(java.lang.Runnable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20749;
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20750;
		public Thread(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20751;
		public Thread()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20751);
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
			global::java.lang.Thread._run20702 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "run", "()V");
			global::java.lang.Thread._toString20703 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Thread._isInterrupted20704 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isInterrupted", "()Z");
			global::java.lang.Thread._currentThread20705 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;");
			global::java.lang.Thread._getName20706 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Thread._getThreadGroup20707 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.Thread._getStackTrace20708 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Thread._dumpStack20709 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "dumpStack", "()V");
			global::java.lang.Thread._setPriority20710 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setPriority", "(I)V");
			global::java.lang.Thread._setDaemon20711 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDaemon", "(Z)V");
			global::java.lang.Thread._start20712 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "start", "()V");
			global::java.lang.Thread._yield20713 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "yield", "()V");
			global::java.lang.Thread._sleep20714 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(J)V");
			global::java.lang.Thread._sleep20715 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(JI)V");
			global::java.lang.Thread._stop20716 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "()V");
			global::java.lang.Thread._stop20717 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V");
			global::java.lang.Thread._interrupt20718 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupt", "()V");
			global::java.lang.Thread._interrupted20719 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupted", "()Z");
			global::java.lang.Thread._destroy20720 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "destroy", "()V");
			global::java.lang.Thread._isAlive20721 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isAlive", "()Z");
			global::java.lang.Thread._suspend20722 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "suspend", "()V");
			global::java.lang.Thread._resume20723 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "resume", "()V");
			global::java.lang.Thread._getPriority20724 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getPriority", "()I");
			global::java.lang.Thread._setName20725 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V");
			global::java.lang.Thread._activeCount20726 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "activeCount", "()I");
			global::java.lang.Thread._enumerate20727 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.Thread._countStackFrames20728 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "countStackFrames", "()I");
			global::java.lang.Thread._join20729 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "()V");
			global::java.lang.Thread._join20730 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(JI)V");
			global::java.lang.Thread._join20731 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(J)V");
			global::java.lang.Thread._isDaemon20732 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isDaemon", "()Z");
			global::java.lang.Thread._checkAccess20733 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "checkAccess", "()V");
			global::java.lang.Thread._getContextClassLoader20734 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Thread._setContextClassLoader20735 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.Thread._holdsLock20736 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z");
			global::java.lang.Thread._getAllStackTraces20737 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;");
			global::java.lang.Thread._getId20738 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getId", "()J");
			global::java.lang.Thread._getState20739 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;");
			global::java.lang.Thread._setDefaultUncaughtExceptionHandler20740 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._getDefaultUncaughtExceptionHandler20741 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._getUncaughtExceptionHandler20742 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._setUncaughtExceptionHandler20743 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._Thread20744 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread20745 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
			global::java.lang.Thread._Thread20746 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20747 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20748 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread20749 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20750 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20751 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "()V");
		}
	}
}
