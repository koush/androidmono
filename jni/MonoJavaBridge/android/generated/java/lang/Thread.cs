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
			internal static global::net.sf.jni4net.jni.MethodId _values12237;
			public static global::java.lang.Thread.State[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._values12237));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf12238;
			public static global::java.lang.Thread.State valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.State.staticClass, global::java.lang.Thread.State._valueOf12238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _NEW12239;
			public static global::java.lang.Thread.State NEW
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RUNNABLE12240;
			public static global::java.lang.Thread.State RUNNABLE
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _BLOCKED12241;
			public static global::java.lang.Thread.State BLOCKED
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _WAITING12242;
			public static global::java.lang.Thread.State WAITING
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TIMED_WAITING12243;
			public static global::java.lang.Thread.State TIMED_WAITING
			{
				get
				{
					return default(global::java.lang.Thread.State);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TERMINATED12244;
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
				global::java.lang.Thread.State._values12237 = @__env.GetStaticMethodID(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;");
				global::java.lang.Thread.State._valueOf12238 = @__env.GetStaticMethodID(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;");
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
			internal static global::net.sf.jni4net.jni.MethodId _uncaughtException12245;
			 void java.lang.Thread.UncaughtExceptionHandler.uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::java.lang.Thread.__UncaughtExceptionHandler._uncaughtException12245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.__UncaughtExceptionHandler.staticClass, global::java.lang.Thread.__UncaughtExceptionHandler._uncaughtException12245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.lang.Thread.__UncaughtExceptionHandler.staticClass = @__class;
				global::java.lang.Thread.__UncaughtExceptionHandler._uncaughtException12245 = @__env.GetMethodID(global::java.lang.Thread.__UncaughtExceptionHandler.staticClass, "java.lang.Thread.UncaughtExceptionHandler.uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _run12246;
		public virtual void run() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._run12246);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._run12246);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12247;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._toString12247));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._toString12247));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInterrupted12248;
		public virtual bool isInterrupted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Thread._isInterrupted12248);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isInterrupted12248);
		}
		internal static global::net.sf.jni4net.jni.MethodId _currentThread12249;
		public static global::java.lang.Thread currentThread() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, global::java.lang.Thread._currentThread12249));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName12250;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getName12250));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getName12250));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadGroup12251;
		public virtual global::java.lang.ThreadGroup getThreadGroup() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getThreadGroup12251));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getThreadGroup12251));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStackTrace12252;
		public virtual global::java.lang.StackTraceElement[] getStackTrace() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getStackTrace12252));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getStackTrace12252));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpStack12253;
		public static void dumpStack() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._dumpStack12253);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPriority12254;
		public virtual void setPriority(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setPriority12254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setPriority12254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDaemon12255;
		public virtual void setDaemon(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setDaemon12255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setDaemon12255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _start12256;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._start12256);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._start12256);
		}
		internal static global::net.sf.jni4net.jni.MethodId _yield12257;
		public static void yield() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._yield12257);
		}
		internal static global::net.sf.jni4net.jni.MethodId _sleep12258;
		public static void sleep(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep12258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sleep12259;
		public static void sleep(long arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._sleep12259, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop12260;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._stop12260);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop12260);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop12261;
		public virtual void stop(java.lang.Throwable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._stop12261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._stop12261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _interrupt12262;
		public virtual void interrupt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._interrupt12262);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._interrupt12262);
		}
		internal static global::net.sf.jni4net.jni.MethodId _interrupted12263;
		public static bool interrupted() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._interrupted12263);
		}
		internal static global::net.sf.jni4net.jni.MethodId _destroy12264;
		public virtual void destroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._destroy12264);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._destroy12264);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAlive12265;
		public virtual bool isAlive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Thread._isAlive12265);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isAlive12265);
		}
		internal static global::net.sf.jni4net.jni.MethodId _suspend12266;
		public virtual void suspend() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._suspend12266);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._suspend12266);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resume12267;
		public virtual void resume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._resume12267);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._resume12267);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPriority12268;
		public virtual int getPriority() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Thread._getPriority12268);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getPriority12268);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setName12269;
		public virtual void setName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setName12269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setName12269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _activeCount12270;
		public static int activeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._activeCount12270);
		}
		internal static global::net.sf.jni4net.jni.MethodId _enumerate12271;
		public static int enumerate(java.lang.Thread[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, global::java.lang.Thread._enumerate12271, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _countStackFrames12272;
		public virtual int countStackFrames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.lang.Thread._countStackFrames12272);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._countStackFrames12272);
		}
		internal static global::net.sf.jni4net.jni.MethodId _join12273;
		public virtual void join() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._join12273);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join12273);
		}
		internal static global::net.sf.jni4net.jni.MethodId _join12274;
		public virtual void join(long arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._join12274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join12274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _join12275;
		public virtual void join(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._join12275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._join12275, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDaemon12276;
		public virtual bool isDaemon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.lang.Thread._isDaemon12276);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._isDaemon12276);
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkAccess12277;
		public virtual void checkAccess() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._checkAccess12277);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._checkAccess12277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContextClassLoader12278;
		public virtual global::java.lang.ClassLoader getContextClassLoader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getContextClassLoader12278));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getContextClassLoader12278));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContextClassLoader12279;
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setContextClassLoader12279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setContextClassLoader12279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _holdsLock12280;
		public static bool holdsLock(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, global::java.lang.Thread._holdsLock12280, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllStackTraces12281;
		public static global::java.util.Map getAllStackTraces() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, global::java.lang.Thread._getAllStackTraces12281));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getId12282;
		public virtual long getId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.lang.Thread._getId12282);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getId12282);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getState12283;
		public virtual global::java.lang.Thread.State getState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getState12283));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getState12283));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultUncaughtExceptionHandler12284;
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, global::java.lang.Thread._setDefaultUncaughtExceptionHandler12284, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultUncaughtExceptionHandler12285;
		public static global::java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, global::java.lang.Thread._getDefaultUncaughtExceptionHandler12285));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUncaughtExceptionHandler12286;
		public virtual global::java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.Thread._getUncaughtExceptionHandler12286));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._getUncaughtExceptionHandler12286));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUncaughtExceptionHandler12287;
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.lang.Thread._setUncaughtExceptionHandler12287, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.lang.Thread.staticClass, global::java.lang.Thread._setUncaughtExceptionHandler12287, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12288;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12288, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12289;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12289, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12290;
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12290, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12291;
		public Thread(java.lang.Runnable arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12291, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12292;
		public Thread(java.lang.Runnable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12292, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12293;
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12293, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12294;
		public Thread(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12294, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Thread12295;
		public Thread()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.lang.Thread.staticClass, global::java.lang.Thread._Thread12295, this);
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
			global::java.lang.Thread._run12246 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "run", "()V");
			global::java.lang.Thread._toString12247 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Thread._isInterrupted12248 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isInterrupted", "()Z");
			global::java.lang.Thread._currentThread12249 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;");
			global::java.lang.Thread._getName12250 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Thread._getThreadGroup12251 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;");
			global::java.lang.Thread._getStackTrace12252 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Thread._dumpStack12253 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "dumpStack", "()V");
			global::java.lang.Thread._setPriority12254 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setPriority", "(I)V");
			global::java.lang.Thread._setDaemon12255 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setDaemon", "(Z)V");
			global::java.lang.Thread._start12256 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "start", "()V");
			global::java.lang.Thread._yield12257 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "yield", "()V");
			global::java.lang.Thread._sleep12258 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "sleep", "(J)V");
			global::java.lang.Thread._sleep12259 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "sleep", "(JI)V");
			global::java.lang.Thread._stop12260 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "stop", "()V");
			global::java.lang.Thread._stop12261 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V");
			global::java.lang.Thread._interrupt12262 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "interrupt", "()V");
			global::java.lang.Thread._interrupted12263 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "interrupted", "()Z");
			global::java.lang.Thread._destroy12264 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "destroy", "()V");
			global::java.lang.Thread._isAlive12265 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isAlive", "()Z");
			global::java.lang.Thread._suspend12266 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "suspend", "()V");
			global::java.lang.Thread._resume12267 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "resume", "()V");
			global::java.lang.Thread._getPriority12268 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getPriority", "()I");
			global::java.lang.Thread._setName12269 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V");
			global::java.lang.Thread._activeCount12270 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "activeCount", "()I");
			global::java.lang.Thread._enumerate12271 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I");
			global::java.lang.Thread._countStackFrames12272 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "countStackFrames", "()I");
			global::java.lang.Thread._join12273 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "()V");
			global::java.lang.Thread._join12274 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "(JI)V");
			global::java.lang.Thread._join12275 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "(J)V");
			global::java.lang.Thread._isDaemon12276 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isDaemon", "()Z");
			global::java.lang.Thread._checkAccess12277 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "checkAccess", "()V");
			global::java.lang.Thread._getContextClassLoader12278 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Thread._setContextClassLoader12279 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::java.lang.Thread._holdsLock12280 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z");
			global::java.lang.Thread._getAllStackTraces12281 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;");
			global::java.lang.Thread._getId12282 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getId", "()J");
			global::java.lang.Thread._getState12283 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;");
			global::java.lang.Thread._setDefaultUncaughtExceptionHandler12284 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._getDefaultUncaughtExceptionHandler12285 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._getUncaughtExceptionHandler12286 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
			global::java.lang.Thread._setUncaughtExceptionHandler12287 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V");
			global::java.lang.Thread._Thread12288 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread12289 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V");
			global::java.lang.Thread._Thread12290 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread12291 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread12292 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V");
			global::java.lang.Thread._Thread12293 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V");
			global::java.lang.Thread._Thread12294 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Thread._Thread12295 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "()V");
		}
	}
}
