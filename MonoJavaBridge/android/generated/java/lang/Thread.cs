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
			internal static global::MonoJavaBridge.MethodId _values20812;
			public static global::java.lang.Thread.State[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._values20812)) as java.lang.Thread.State[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf20813;
			public static global::java.lang.Thread.State valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.CallStaticObjectMethod(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._valueOf20813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Thread.State;
			}
			internal static global::MonoJavaBridge.FieldId _NEW20814;
			public static global::java.lang.Thread.State NEW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _NEW20814)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNABLE20815;
			public static global::java.lang.Thread.State RUNNABLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _RUNNABLE20815)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCKED20816;
			public static global::java.lang.Thread.State BLOCKED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _BLOCKED20816)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WAITING20817;
			public static global::java.lang.Thread.State WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _WAITING20817)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIMED_WAITING20818;
			public static global::java.lang.Thread.State TIMED_WAITING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TIMED_WAITING20818)) as java.lang.Thread.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TERMINATED20819;
			public static global::java.lang.Thread.State TERMINATED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(@__env.GetStaticObjectField(global::java.lang.Thread.State.staticClass, _TERMINATED20819)) as java.lang.Thread.State;
				}
			}
			static State()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$State"));
				global::java.lang.Thread.State._values20812 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;");
				global::java.lang.Thread.State._valueOf20813 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._NEW20814 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "NEW", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._RUNNABLE20815 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "RUNNABLE", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._BLOCKED20816 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "BLOCKED", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._WAITING20817 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TIMED_WAITING20818 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TIMED_WAITING", "Ljava/lang/Thread$State;");
				global::java.lang.Thread.State._TERMINATED20819 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Thread.State.staticClass, "TERMINATED", "Ljava/lang/Thread$State;");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _uncaughtException20820;
			void java.lang.Thread.UncaughtExceptionHandler.uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static UncaughtExceptionHandler_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Thread.UncaughtExceptionHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Thread$UncaughtExceptionHandler"));
				global::java.lang.Thread.UncaughtExceptionHandler_._uncaughtException20820 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.UncaughtExceptionHandler_.staticClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _run20821;
		public virtual void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._run20821);
		}
		internal static global::MonoJavaBridge.MethodId _toString20822;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._toString20822)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isInterrupted20823;
		public virtual bool isInterrupted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isInterrupted20823);
		}
		internal static global::MonoJavaBridge.MethodId _currentThread20824;
		public static global::java.lang.Thread currentThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._currentThread20824)) as java.lang.Thread;
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
		internal static global::MonoJavaBridge.MethodId _getName20825;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getName20825)) as java.lang.String;
		}
		public new global::java.lang.ThreadGroup ThreadGroup
		{
			get
			{
				return getThreadGroup();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGroup20826;
		public virtual global::java.lang.ThreadGroup getThreadGroup()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getThreadGroup20826)) as java.lang.ThreadGroup;
		}
		public new global::java.lang.StackTraceElement[] StackTrace
		{
			get
			{
				return getStackTrace();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStackTrace20827;
		public virtual global::java.lang.StackTraceElement[] getStackTrace()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getStackTrace20827)) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _dumpStack20828;
		public static void dumpStack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._dumpStack20828);
		}
		internal static global::MonoJavaBridge.MethodId _setPriority20829;
		public virtual void setPriority(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setPriority20829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Daemon
		{
			set
			{
				setDaemon(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDaemon20830;
		public virtual void setDaemon(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setDaemon20830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _start20831;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._start20831);
		}
		internal static global::MonoJavaBridge.MethodId _yield20832;
		public static void yield()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._yield20832);
		}
		internal static global::MonoJavaBridge.MethodId _sleep20833;
		public static void sleep(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep20833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sleep20834;
		public static void sleep(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep20834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stop20835;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop20835);
		}
		internal static global::MonoJavaBridge.MethodId _stop20836;
		public virtual void stop(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop20836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _interrupt20837;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._interrupt20837);
		}
		internal static global::MonoJavaBridge.MethodId _interrupted20838;
		public static bool interrupted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._interrupted20838);
		}
		internal static global::MonoJavaBridge.MethodId _destroy20839;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._destroy20839);
		}
		internal static global::MonoJavaBridge.MethodId _isAlive20840;
		public virtual bool isAlive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isAlive20840);
		}
		internal static global::MonoJavaBridge.MethodId _suspend20841;
		public virtual void suspend()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._suspend20841);
		}
		internal static global::MonoJavaBridge.MethodId _resume20842;
		public virtual void resume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._resume20842);
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
		internal static global::MonoJavaBridge.MethodId _getPriority20843;
		public virtual int getPriority()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getPriority20843);
		}
		internal static global::MonoJavaBridge.MethodId _setName20844;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setName20844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _activeCount20845;
		public static int activeCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._activeCount20845);
		}
		internal static global::MonoJavaBridge.MethodId _enumerate20846;
		public static int enumerate(java.lang.Thread[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._enumerate20846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countStackFrames20847;
		public virtual int countStackFrames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._countStackFrames20847);
		}
		internal static global::MonoJavaBridge.MethodId _join20848;
		public virtual void join()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20848);
		}
		internal static global::MonoJavaBridge.MethodId _join20849;
		public virtual void join(long arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _join20850;
		public virtual void join(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join20850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDaemon20851;
		public virtual bool isDaemon()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isDaemon20851);
		}
		internal static global::MonoJavaBridge.MethodId _checkAccess20852;
		public virtual void checkAccess()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._checkAccess20852);
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
		internal static global::MonoJavaBridge.MethodId _getContextClassLoader20853;
		public virtual global::java.lang.ClassLoader getContextClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getContextClassLoader20853)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _setContextClassLoader20854;
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setContextClassLoader20854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _holdsLock20855;
		public static bool holdsLock(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._holdsLock20855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Map AllStackTraces
		{
			get
			{
				return getAllStackTraces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllStackTraces20856;
		public static global::java.util.Map getAllStackTraces()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getAllStackTraces20856)) as java.util.Map;
		}
		public new long Id
		{
			get
			{
				return getId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getId20857;
		public virtual long getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getId20857);
		}
		internal static global::MonoJavaBridge.MethodId _getState20858;
		public virtual global::java.lang.Thread.State getState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Thread.State>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getState20858)) as java.lang.Thread.State;
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUncaughtExceptionHandler20859;
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._setDefaultUncaughtExceptionHandler20859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDefaultUncaughtExceptionHandler20860;
		public static global::java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(@__env.CallStaticObjectMethod(java.lang.Thread.staticClass, global::java.lang.Thread._getDefaultUncaughtExceptionHandler20860)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getUncaughtExceptionHandler20861;
		public virtual global::java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Thread.UncaughtExceptionHandler>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getUncaughtExceptionHandler20861)) as java.lang.Thread.UncaughtExceptionHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setUncaughtExceptionHandler20862;
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setUncaughtExceptionHandler20862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Thread20863;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20864;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20865;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20866;
		public Thread(java.lang.Runnable arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20867;
		public Thread(java.lang.Runnable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20868;
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20869;
		public Thread(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Thread20870;
		public Thread() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread20870);
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
			global::java.lang.Thread._run20821 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "run", "()V");
			global::java.lang.Thread._toString20822 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Thread._isInterrupted20823 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isInterrupted", "()Z");
			global::java.lang.Thread._currentThread20824 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;");
			global::java.lang.Thread._getName20825 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Thread._getThreadGroup20826 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.Thread._getStackTrace20827 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Thread._dumpStack20828 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "dumpStack", "()V");
			global::java.lang.Thread._setPriority20829 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setPriority", "(I)V");
			global::java.lang.Thread._setDaemon20830 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDaemon", "(Z)V");
			global::java.lang.Thread._start20831 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "start", "()V");
			global::java.lang.Thread._yield20832 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "yield", "()V");
			global::java.lang.Thread._sleep20833 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(J)V");
			global::java.lang.Thread._sleep20834 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "sleep", "(JI)V");
			global::java.lang.Thread._stop20835 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "()V");
			global::java.lang.Thread._stop20836 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V");
			global::java.lang.Thread._interrupt20837 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupt", "()V");
			global::java.lang.Thread._interrupted20838 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "interrupted", "()Z");
			global::java.lang.Thread._destroy20839 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "destroy", "()V");
			global::java.lang.Thread._isAlive20840 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isAlive", "()Z");
			global::java.lang.Thread._suspend20841 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "suspend", "()V");
			global::java.lang.Thread._resume20842 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "resume", "()V");
			global::java.lang.Thread._getPriority20843 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getPriority", "()I");
			global::java.lang.Thread._setName20844 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V");
			global::java.lang.Thread._activeCount20845 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "activeCount", "()I");
			global::java.lang.Thread._enumerate20846 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.Thread._countStackFrames20847 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "countStackFrames", "()I");
			global::java.lang.Thread._join20848 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "()V");
			global::java.lang.Thread._join20849 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(JI)V");
			global::java.lang.Thread._join20850 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "join", "(J)V");
			global::java.lang.Thread._isDaemon20851 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "isDaemon", "()Z");
			global::java.lang.Thread._checkAccess20852 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "checkAccess", "()V");
			global::java.lang.Thread._getContextClassLoader20853 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Thread._setContextClassLoader20854 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.Thread._holdsLock20855 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z");
			global::java.lang.Thread._getAllStackTraces20856 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;");
			global::java.lang.Thread._getId20857 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getId", "()J");
			global::java.lang.Thread._getState20858 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;");
			global::java.lang.Thread._setDefaultUncaughtExceptionHandler20859 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._getDefaultUncaughtExceptionHandler20860 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._getUncaughtExceptionHandler20861 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._setUncaughtExceptionHandler20862 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._Thread20863 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread20864 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
			global::java.lang.Thread._Thread20865 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20866 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20867 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread20868 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20869 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Thread._Thread20870 = @__env.GetMethodIDNoThrow(global::java.lang.Thread.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
