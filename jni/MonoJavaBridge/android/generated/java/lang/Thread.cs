namespace java.lang
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Thread : java.lang.Object, Runnable
	{
		internal static global::java.lang.Class staticClass;
		static Thread()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.Thread), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.lang.Thread(@__env);
			}
		}
		protected Thread(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class State : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static State()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.Thread.State), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::java.lang.Thread.State(@__env);
				}
			}
			internal State(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values11508;
			public static global::java.lang.Thread.State[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._values11508));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf11509;
			public static global::java.lang.Thread.State valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._valueOf11509, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _NEW11510;
			public static global::java.lang.Thread.State NEW
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RUNNABLE11511;
			public static global::java.lang.Thread.State RUNNABLE
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _BLOCKED11512;
			public static global::java.lang.Thread.State BLOCKED
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _WAITING11513;
			public static global::java.lang.Thread.State WAITING
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TIMED_WAITING11514;
			public static global::java.lang.Thread.State TIMED_WAITING
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TERMINATED11515;
			public static global::java.lang.Thread.State TERMINATED
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.lang.Thread.State.staticClass = @__class;
				global::java.lang.Thread.State._values11508 = @__env.GetStaticMethodID(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;");
				global::java.lang.Thread.State._valueOf11509 = @__env.GetStaticMethodID(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface UncaughtExceptionHandler 
		{
			void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1);
		}

		public partial class UncaughtExceptionHandler_
		{
			public static global::java.lang.Class _class
			{
				get { return __UncaughtExceptionHandler.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __UncaughtExceptionHandler : java.lang.Object, UncaughtExceptionHandler
		{
			internal static global::java.lang.Class staticClass;
			static __UncaughtExceptionHandler()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.lang.Thread.__UncaughtExceptionHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::java.lang.Thread.__UncaughtExceptionHandler(@__env);
				}
			}
			internal __UncaughtExceptionHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _uncaughtException11516;
			 void java.lang.Thread.UncaughtExceptionHandler.uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::java.lang.Thread.__UncaughtExceptionHandler._uncaughtException11516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.__UncaughtExceptionHandler.staticClass, global::java.lang.Thread.__UncaughtExceptionHandler._uncaughtException11516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.lang.Thread.__UncaughtExceptionHandler.staticClass = @__class;
				global::java.lang.Thread.__UncaughtExceptionHandler._uncaughtException11516 = @__env.GetMethodID(global::java.lang.Thread.__UncaughtExceptionHandler.staticClass, "java.lang.Thread.UncaughtExceptionHandler.uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _run11517;
		public virtual void run() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._run11517);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._run11517);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString11518;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._toString11518));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._toString11518));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInterrupted11519;
		public virtual bool isInterrupted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Thread._isInterrupted11519);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isInterrupted11519);
		}
		internal static global::net.sf.jni4net.jni.MethodId _currentThread11520;
		public static global::java.lang.Thread currentThread() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, global::java.lang.Thread._currentThread11520));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName11521;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getName11521));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getName11521));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadGroup11522;
		public virtual global::java.lang.ThreadGroup getThreadGroup() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getThreadGroup11522));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getThreadGroup11522));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStackTrace11523;
		public virtual global::java.lang.StackTraceElement[] getStackTrace() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getStackTrace11523));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getStackTrace11523));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpStack11524;
		public static void dumpStack() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._dumpStack11524);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPriority11525;
		public virtual void setPriority(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setPriority11525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setPriority11525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDaemon11526;
		public virtual void setDaemon(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setDaemon11526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setDaemon11526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _start11527;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._start11527);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._start11527);
		}
		internal static global::net.sf.jni4net.jni.MethodId _yield11528;
		public static void yield() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._yield11528);
		}
		internal static global::net.sf.jni4net.jni.MethodId _sleep11529;
		public static void sleep(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep11529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sleep11530;
		public static void sleep(long arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep11530, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop11531;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._stop11531);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop11531);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop11532;
		public virtual void stop(java.lang.Throwable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._stop11532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop11532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _interrupt11533;
		public virtual void interrupt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._interrupt11533);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._interrupt11533);
		}
		internal static global::net.sf.jni4net.jni.MethodId _interrupted11534;
		public static bool interrupted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._interrupted11534);
		}
		internal static global::net.sf.jni4net.jni.MethodId _destroy11535;
		public virtual void destroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._destroy11535);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._destroy11535);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAlive11536;
		public virtual bool isAlive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Thread._isAlive11536);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isAlive11536);
		}
		internal static global::net.sf.jni4net.jni.MethodId _suspend11537;
		public virtual void suspend() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._suspend11537);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._suspend11537);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resume11538;
		public virtual void resume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._resume11538);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._resume11538);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPriority11539;
		public virtual int getPriority() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Thread._getPriority11539);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getPriority11539);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setName11540;
		public virtual void setName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setName11540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setName11540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _activeCount11541;
		public static int activeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._activeCount11541);
		}
		internal static global::net.sf.jni4net.jni.MethodId _enumerate11542;
		public static int enumerate(java.lang.Thread[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._enumerate11542, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countStackFrames11543;
		public virtual int countStackFrames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Thread._countStackFrames11543);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._countStackFrames11543);
		}
		internal static global::net.sf.jni4net.jni.MethodId _join11544;
		public virtual void join() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._join11544);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join11544);
		}
		internal static global::net.sf.jni4net.jni.MethodId _join11545;
		public virtual void join(long arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._join11545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join11545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _join11546;
		public virtual void join(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._join11546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join11546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDaemon11547;
		public virtual bool isDaemon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Thread._isDaemon11547);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isDaemon11547);
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkAccess11548;
		public virtual void checkAccess() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._checkAccess11548);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._checkAccess11548);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContextClassLoader11549;
		public virtual global::java.lang.ClassLoader getContextClassLoader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getContextClassLoader11549));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getContextClassLoader11549));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContextClassLoader11550;
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setContextClassLoader11550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setContextClassLoader11550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _holdsLock11551;
		public static bool holdsLock(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._holdsLock11551, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllStackTraces11552;
		public static global::java.util.Map getAllStackTraces() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, global::java.lang.Thread._getAllStackTraces11552));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getId11553;
		public virtual long getId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.lang.Thread._getId11553);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getId11553);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getState11554;
		public virtual global::java.lang.Thread.State getState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getState11554));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getState11554));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultUncaughtExceptionHandler11555;
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._setDefaultUncaughtExceptionHandler11555, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultUncaughtExceptionHandler11556;
		public static global::java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, global::java.lang.Thread._getDefaultUncaughtExceptionHandler11556));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUncaughtExceptionHandler11557;
		public virtual global::java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getUncaughtExceptionHandler11557));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getUncaughtExceptionHandler11557));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUncaughtExceptionHandler11558;
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setUncaughtExceptionHandler11558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setUncaughtExceptionHandler11558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11559;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11559, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11560;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11560, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11561;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11561, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11562;
		public Thread(java.lang.Runnable arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11562, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11563;
		public Thread(java.lang.Runnable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11563, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11564;
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11564, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11565;
		public Thread(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11565, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread11566;
		public Thread()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread11566, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.lang.Thread.staticClass = @__class;
			global::java.lang.Thread._run11517 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "run", "()V");
			global::java.lang.Thread._toString11518 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Thread._isInterrupted11519 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isInterrupted", "()Z");
			global::java.lang.Thread._currentThread11520 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;");
			global::java.lang.Thread._getName11521 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Thread._getThreadGroup11522 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.Thread._getStackTrace11523 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Thread._dumpStack11524 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "dumpStack", "()V");
			global::java.lang.Thread._setPriority11525 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setPriority", "(I)V");
			global::java.lang.Thread._setDaemon11526 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setDaemon", "(Z)V");
			global::java.lang.Thread._start11527 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "start", "()V");
			global::java.lang.Thread._yield11528 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "yield", "()V");
			global::java.lang.Thread._sleep11529 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "sleep", "(J)V");
			global::java.lang.Thread._sleep11530 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "sleep", "(JI)V");
			global::java.lang.Thread._stop11531 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "stop", "()V");
			global::java.lang.Thread._stop11532 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V");
			global::java.lang.Thread._interrupt11533 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "interrupt", "()V");
			global::java.lang.Thread._interrupted11534 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "interrupted", "()Z");
			global::java.lang.Thread._destroy11535 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "destroy", "()V");
			global::java.lang.Thread._isAlive11536 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isAlive", "()Z");
			global::java.lang.Thread._suspend11537 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "suspend", "()V");
			global::java.lang.Thread._resume11538 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "resume", "()V");
			global::java.lang.Thread._getPriority11539 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getPriority", "()I");
			global::java.lang.Thread._setName11540 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V");
			global::java.lang.Thread._activeCount11541 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "activeCount", "()I");
			global::java.lang.Thread._enumerate11542 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.Thread._countStackFrames11543 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "countStackFrames", "()I");
			global::java.lang.Thread._join11544 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "()V");
			global::java.lang.Thread._join11545 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "(JI)V");
			global::java.lang.Thread._join11546 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "(J)V");
			global::java.lang.Thread._isDaemon11547 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isDaemon", "()Z");
			global::java.lang.Thread._checkAccess11548 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "checkAccess", "()V");
			global::java.lang.Thread._getContextClassLoader11549 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Thread._setContextClassLoader11550 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.Thread._holdsLock11551 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z");
			global::java.lang.Thread._getAllStackTraces11552 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;");
			global::java.lang.Thread._getId11553 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getId", "()J");
			global::java.lang.Thread._getState11554 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;");
			global::java.lang.Thread._setDefaultUncaughtExceptionHandler11555 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._getDefaultUncaughtExceptionHandler11556 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._getUncaughtExceptionHandler11557 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._setUncaughtExceptionHandler11558 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._Thread11559 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread11560 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
			global::java.lang.Thread._Thread11561 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread11562 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread11563 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread11564 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread11565 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Thread._Thread11566 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "()V");
		}
	}
}
