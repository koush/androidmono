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
			internal static global::MonoJavaBridge.MethodId _values20811;
			public static global::java.lang.Thread.State[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._values20811)) as java.lang.Thread.State[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf20812;
			public static global::java.lang.Thread.State valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._valueOf20812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Thread.State;
			}
			internal static global::MonoJavaBridge.FieldId _NEW20813;
			public static global::java.lang.Thread.State NEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _NEW20813)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNABLE20814;
			public static global::java.lang.Thread.State RUNNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _RUNNABLE20814)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCKED20815;
			public static global::java.lang.Thread.State BLOCKED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _BLOCKED20815)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WAITING20816;
			public static global::java.lang.Thread.State WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _WAITING20816)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIMED_WAITING20817;
			public static global::java.lang.Thread.State TIMED_WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TIMED_WAITING20817)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TERMINATED20818;
			public static global::java.lang.Thread.State TERMINATED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TERMINATED20818)) as java.lang.Thread.State;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$State"));
				global::java.lang.Thread.State._values20811 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;");
				global::java.lang.Thread.State._valueOf20812 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._NEW20813 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "NEW", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._RUNNABLE20814 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "RUNNABLE", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._BLOCKED20815 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "BLOCKED", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._WAITING20816 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TIMED_WAITING20817 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TIMED_WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TERMINATED20818 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TERMINATED", "Ljava/lang/Thread$State;");
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
			static UncaughtExceptionHandler_()
			{
				InitJNI();
			}
			internal UncaughtExceptionHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _uncaughtException20819;
			void java.lang.Thread.UncaughtExceptionHandler.uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.UncaughtExceptionHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$UncaughtExceptionHandler"));
				global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20819 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _run20820;
		public virtual void run()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._run20820);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._run20820);
		}
		internal static global::MonoJavaBridge.MethodId _toString20821;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._toString20821)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._toString20821)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isInterrupted20822;
		public virtual bool isInterrupted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isInterrupted20822);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isInterrupted20822);
		}
		internal static global::MonoJavaBridge.MethodId _currentThread20823;
		public static global::java.lang.Thread currentThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._currentThread20823)) as java.lang.Thread;
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
		internal static global::MonoJavaBridge.MethodId _getName20824;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getName20824)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getName20824)) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup20825;
		public virtual global::java.lang.ThreadGroup getThreadGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getThreadGroup20825)) as java.lang.ThreadGroup;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getThreadGroup20825)) as java.lang.ThreadGroup;
		}
		public new global::java.lang.StackTraceElement[] StackTrace
		{
			get
			{
				return getStackTrace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStackTrace20826;
		public virtual global::java.lang.StackTraceElement[] getStackTrace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getStackTrace20826)) as java.lang.StackTraceElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getStackTrace20826)) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _dumpStack20827;
		public static void dumpStack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._dumpStack20827);
		}
		internal static global::MonoJavaBridge.MethodId _setPriority20828;
		public virtual void setPriority(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setPriority20828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setPriority20828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Daemon
		{
			set
			{
				setDaemon(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon20829;
		public virtual void setDaemon(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setDaemon20829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setDaemon20829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start20830;
		public virtual void start()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._start20830);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._start20830);
		}
		internal static global::MonoJavaBridge.MethodId _yield20831;
		public static void yield()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._yield20831);
		}
		internal static global::MonoJavaBridge.MethodId _sleep20832;
		public static void sleep(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep20832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sleep20833;
		public static void sleep(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep20833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stop20834;
		public virtual void stop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._stop20834);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop20834);
		}
		internal static global::MonoJavaBridge.MethodId _stop20835;
		public virtual void stop(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._stop20835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop20835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _interrupt20836;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._interrupt20836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._interrupt20836);
		}
		internal static global::MonoJavaBridge.MethodId _interrupted20837;
		public static bool interrupted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._interrupted20837);
		}
		internal static global::MonoJavaBridge.MethodId _destroy20838;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._destroy20838);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._destroy20838);
		}
		internal static global::MonoJavaBridge.MethodId _isAlive20839;
		public virtual bool isAlive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isAlive20839);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isAlive20839);
		}
		internal static global::MonoJavaBridge.MethodId _suspend20840;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._suspend20840);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._suspend20840);
		}
		internal static global::MonoJavaBridge.MethodId _resume20841;
		public virtual void resume()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._resume20841);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._resume20841);
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
		internal static global::MonoJavaBridge.MethodId _getPriority20842;
		public virtual int getPriority()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Thread._getPriority20842);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getPriority20842);
		}
		internal static global::MonoJavaBridge.MethodId _setName20843;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setName20843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setName20843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeCount20844;
		public static int activeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._activeCount20844);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20845;
		public static int enumerate(java.lang.Thread[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._enumerate20845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countStackFrames20846;
		public virtual int countStackFrames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Thread._countStackFrames20846);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._countStackFrames20846);
		}
		internal static global::MonoJavaBridge.MethodId _join20847;
		public virtual void join()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join20847);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20847);
		}
		internal static global::MonoJavaBridge.MethodId _join20848;
		public virtual void join(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join20848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join20849;
		public virtual void join(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._join20849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon20850;
		public virtual bool isDaemon()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Thread._isDaemon20850);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._isDaemon20850);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20851;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._checkAccess20851);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._checkAccess20851);
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
		internal static global::MonoJavaBridge.MethodId _getContextClassLoader20852;
		public virtual global::java.lang.ClassLoader getContextClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getContextClassLoader20852)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getContextClassLoader20852)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _setContextClassLoader20853;
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setContextClassLoader20853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setContextClassLoader20853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _holdsLock20854;
		public static bool holdsLock(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._holdsLock20854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Map AllStackTraces
		{
			get
			{
				return getAllStackTraces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllStackTraces20855;
		public static global::java.util.Map getAllStackTraces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getAllStackTraces20855)) as java.util.Map;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId20856;
		public virtual long getId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Thread._getId20856);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getId20856);
		}
		internal static global::MonoJavaBridge.MethodId _getState20857;
		public virtual global::java.lang.Thread.State getState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getState20857)) as java.lang.Thread.State;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getState20857)) as java.lang.Thread.State;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUncaughtExceptionHandler20858;
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._setDefaultUncaughtExceptionHandler20858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultUncaughtExceptionHandler20859;
		public static global::java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getDefaultUncaughtExceptionHandler20859)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getUncaughtExceptionHandler20860;
		public virtual global::java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Thread._getUncaughtExceptionHandler20860)) as java.lang.Thread.UncaughtExceptionHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._getUncaughtExceptionHandler20860)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setUncaughtExceptionHandler20861;
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread._setUncaughtExceptionHandler20861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Thread.staticClass, global::java.lang.Thread._setUncaughtExceptionHandler20861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Thread20862;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20863;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20864;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20865;
		public Thread(java.lang.Runnable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20866;
		public Thread(java.lang.Runnable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20867;
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20868;
		public Thread(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20869;
		public Thread() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20869);
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
			global::java.lang.Thread._run20820 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "run", "()V");
			global::java.lang.Thread._toString20821 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Thread._isInterrupted20822 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isInterrupted", "()Z");
			global::java.lang.Thread._currentThread20823 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;");
			global::java.lang.Thread._getName20824 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Thread._getThreadGroup20825 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.Thread._getStackTrace20826 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Thread._dumpStack20827 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "dumpStack", "()V");
			global::java.lang.Thread._setPriority20828 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setPriority", "(I)V");
			global::java.lang.Thread._setDaemon20829 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDaemon", "(Z)V");
			global::java.lang.Thread._start20830 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "start", "()V");
			global::java.lang.Thread._yield20831 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "yield", "()V");
			global::java.lang.Thread._sleep20832 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(J)V");
			global::java.lang.Thread._sleep20833 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(JI)V");
			global::java.lang.Thread._stop20834 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "()V");
			global::java.lang.Thread._stop20835 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V");
			global::java.lang.Thread._interrupt20836 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupt", "()V");
			global::java.lang.Thread._interrupted20837 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupted", "()Z");
			global::java.lang.Thread._destroy20838 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "destroy", "()V");
			global::java.lang.Thread._isAlive20839 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isAlive", "()Z");
			global::java.lang.Thread._suspend20840 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "suspend", "()V");
			global::java.lang.Thread._resume20841 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "resume", "()V");
			global::java.lang.Thread._getPriority20842 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getPriority", "()I");
			global::java.lang.Thread._setName20843 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V");
			global::java.lang.Thread._activeCount20844 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "activeCount", "()I");
			global::java.lang.Thread._enumerate20845 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.Thread._countStackFrames20846 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "countStackFrames", "()I");
			global::java.lang.Thread._join20847 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "()V");
			global::java.lang.Thread._join20848 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(JI)V");
			global::java.lang.Thread._join20849 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(J)V");
			global::java.lang.Thread._isDaemon20850 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isDaemon", "()Z");
			global::java.lang.Thread._checkAccess20851 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "checkAccess", "()V");
			global::java.lang.Thread._getContextClassLoader20852 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Thread._setContextClassLoader20853 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.Thread._holdsLock20854 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z");
			global::java.lang.Thread._getAllStackTraces20855 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;");
			global::java.lang.Thread._getId20856 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getId", "()J");
			global::java.lang.Thread._getState20857 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;");
			global::java.lang.Thread._setDefaultUncaughtExceptionHandler20858 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._getDefaultUncaughtExceptionHandler20859 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._getUncaughtExceptionHandler20860 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._setUncaughtExceptionHandler20861 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._Thread20862 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread20863 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
			global::java.lang.Thread._Thread20864 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20865 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20866 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread20867 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20868 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20869 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "()V");
		}
	}
}
