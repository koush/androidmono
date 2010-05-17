namespace java.lang 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Thread : java.lang.Object, Runnable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Thread() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.lang.Thread), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.lang.Thread.State), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf10684; 
			public static java.lang.Thread.State valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.State.staticClass, _valueOf10684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values10685; 
			public static java.lang.Thread.State[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.State.staticClass, _values10685)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NEW10686; 
			public static java.lang.Thread.State NEW
			{ 
				get 
				{ 
					return default(java.lang.Thread.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RUNNABLE10687; 
			public static java.lang.Thread.State RUNNABLE
			{ 
				get 
				{ 
					return default(java.lang.Thread.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BLOCKED10688; 
			public static java.lang.Thread.State BLOCKED
			{ 
				get 
				{ 
					return default(java.lang.Thread.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _WAITING10689; 
			public static java.lang.Thread.State WAITING
			{ 
				get 
				{ 
					return default(java.lang.Thread.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TIMED_WAITING10690; 
			public static java.lang.Thread.State TIMED_WAITING
			{ 
				get 
				{ 
					return default(java.lang.Thread.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TERMINATED10691; 
			public static java.lang.Thread.State TERMINATED
			{ 
				get 
				{ 
					return default(java.lang.Thread.State); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::java.lang.Thread.State.staticClass = @__class; 
				global::java.lang.Thread.State._valueOf10684 = @__env.GetStaticMethodID(global::java.lang.Thread.State.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Thread$State;"); 
				global::java.lang.Thread.State._values10685 = @__env.GetStaticMethodID(global::java.lang.Thread.State.staticClass, "values", "()[Ljava/lang/Thread/State;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface UncaughtExceptionHandler 
		{ 
			void uncaughtException(java.lang.Thread arg0, java.lang.Throwable arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _run10692; 
		public virtual void run() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _run10692); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _run10692); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInterrupted10693; 
		public virtual bool isInterrupted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return @__env.CallBooleanMethod(this, _isInterrupted10693); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Thread.staticClass, _isInterrupted10693); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _currentThread10694; 
		public static java.lang.Thread currentThread() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, _currentThread10694)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10695; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10695)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Thread.staticClass, _toString10695)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName10696; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName10696)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Thread.staticClass, _getName10696)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadGroup10697; 
		public virtual java.lang.ThreadGroup getThreadGroup() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallObjectMethodPtr(this, _getThreadGroup10697)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ThreadGroup>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Thread.staticClass, _getThreadGroup10697)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStackTrace10698; 
		public virtual java.lang.StackTraceElement[] getStackTrace() 
		{ 
			if (GetType() == typeof(java.lang.Thread)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getStackTrace10698)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Thread.staticClass, _getStackTrace10698)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpStack10699; 
		public static void dumpStack() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, _dumpStack10699); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPriority10700; 
		public virtual void setPriority(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _setPriority10700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _setPriority10700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDaemon10701; 
		public virtual void setDaemon(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _setDaemon10701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _setDaemon10701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start10702; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _start10702); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _start10702); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _yield10703; 
		public static void yield() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, _yield10703); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sleep10704; 
		public static void sleep(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, _sleep10704, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sleep10705; 
		public static void sleep(long arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, _sleep10705, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop10706; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _stop10706); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _stop10706); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop10707; 
		public virtual void stop(java.lang.Throwable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _stop10707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _stop10707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _interrupt10708; 
		public virtual void interrupt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _interrupt10708); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _interrupt10708); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _interrupted10709; 
		public static bool interrupted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, _interrupted10709); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroy10710; 
		public virtual void destroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _destroy10710); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _destroy10710); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAlive10711; 
		public virtual bool isAlive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return @__env.CallBooleanMethod(this, _isAlive10711); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Thread.staticClass, _isAlive10711); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _suspend10712; 
		public virtual void suspend() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _suspend10712); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _suspend10712); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resume10713; 
		public virtual void resume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _resume10713); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _resume10713); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPriority10714; 
		public virtual int getPriority() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return @__env.CallIntMethod(this, _getPriority10714); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Thread.staticClass, _getPriority10714); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setName10715; 
		public virtual void setName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _setName10715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _setName10715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _activeCount10716; 
		public static int activeCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, _activeCount10716); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enumerate10717; 
		public static int enumerate(java.lang.Thread[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(java.lang.Thread.staticClass, _enumerate10717, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countStackFrames10718; 
		public virtual int countStackFrames() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return @__env.CallIntMethod(this, _countStackFrames10718); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Thread.staticClass, _countStackFrames10718); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _join10719; 
		public virtual void join() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _join10719); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _join10719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _join10720; 
		public virtual void join(long arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _join10720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _join10720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _join10721; 
		public virtual void join(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _join10721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _join10721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDaemon10722; 
		public virtual bool isDaemon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return @__env.CallBooleanMethod(this, _isDaemon10722); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Thread.staticClass, _isDaemon10722); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkAccess10723; 
		public virtual void checkAccess() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _checkAccess10723); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _checkAccess10723); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContextClassLoader10724; 
		public virtual java.lang.ClassLoader getContextClassLoader() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallObjectMethodPtr(this, _getContextClassLoader10724)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.ClassLoader>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Thread.staticClass, _getContextClassLoader10724)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContextClassLoader10725; 
		public virtual void setContextClassLoader(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _setContextClassLoader10725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _setContextClassLoader10725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _holdsLock10726; 
		public static bool holdsLock(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(java.lang.Thread.staticClass, _holdsLock10726, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllStackTraces10727; 
		public static java.util.Map getAllStackTraces() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, _getAllStackTraces10727)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId10728; 
		public virtual long getId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return @__env.CallLongMethod(this, _getId10728); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.lang.Thread.staticClass, _getId10728); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState10729; 
		public virtual java.lang.Thread.State getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallObjectMethodPtr(this, _getState10729)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread.State>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Thread.staticClass, _getState10729)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultUncaughtExceptionHandler10730; 
		public static void setDefaultUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.lang.Thread.staticClass, _setDefaultUncaughtExceptionHandler10730, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultUncaughtExceptionHandler10731; 
		public static java.lang.Thread.UncaughtExceptionHandler getDefaultUncaughtExceptionHandler() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Thread.staticClass, _getDefaultUncaughtExceptionHandler10731)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUncaughtExceptionHandler10732; 
		public virtual java.lang.Thread.UncaughtExceptionHandler getUncaughtExceptionHandler() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallObjectMethodPtr(this, _getUncaughtExceptionHandler10732)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Thread.UncaughtExceptionHandler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Thread.staticClass, _getUncaughtExceptionHandler10732)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUncaughtExceptionHandler10733; 
		public virtual void setUncaughtExceptionHandler(java.lang.Thread.UncaughtExceptionHandler arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Thread)) 
				@__env.CallVoidMethod(this, _setUncaughtExceptionHandler10733, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.lang.Thread.staticClass, _setUncaughtExceptionHandler10733, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10734; 
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10734, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10735; 
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2, long arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10735, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10736; 
		public Thread(java.lang.ThreadGroup arg0, java.lang.Runnable arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10736, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10737; 
		public Thread(java.lang.Runnable arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10737, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10738; 
		public Thread(java.lang.Runnable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10738, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10739; 
		public Thread(java.lang.ThreadGroup arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10739, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10740; 
		public Thread(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10740, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Thread10741; 
		public Thread()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Thread.staticClass, _Thread10741, this); 
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
			global::java.lang.Thread._run10692 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "run", "()V"); 
			global::java.lang.Thread._isInterrupted10693 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isInterrupted", "()Z"); 
			global::java.lang.Thread._currentThread10694 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "currentThread", "()Ljava/lang/Thread;"); 
			global::java.lang.Thread._toString10695 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.lang.Thread._getName10696 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.lang.Thread._getThreadGroup10697 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getThreadGroup", "()Ljava/lang/ThreadGroup;"); 
			global::java.lang.Thread._getStackTrace10698 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;"); 
			global::java.lang.Thread._dumpStack10699 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "dumpStack", "()V"); 
			global::java.lang.Thread._setPriority10700 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setPriority", "(I)V"); 
			global::java.lang.Thread._setDaemon10701 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setDaemon", "(Z)V"); 
			global::java.lang.Thread._start10702 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "start", "()V"); 
			global::java.lang.Thread._yield10703 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "yield", "()V"); 
			global::java.lang.Thread._sleep10704 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "sleep", "(J)V"); 
			global::java.lang.Thread._sleep10705 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "sleep", "(JI)V"); 
			global::java.lang.Thread._stop10706 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "stop", "()V"); 
			global::java.lang.Thread._stop10707 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "stop", "(Ljava/lang/Throwable;)V"); 
			global::java.lang.Thread._interrupt10708 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "interrupt", "()V"); 
			global::java.lang.Thread._interrupted10709 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "interrupted", "()Z"); 
			global::java.lang.Thread._destroy10710 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "destroy", "()V"); 
			global::java.lang.Thread._isAlive10711 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isAlive", "()Z"); 
			global::java.lang.Thread._suspend10712 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "suspend", "()V"); 
			global::java.lang.Thread._resume10713 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "resume", "()V"); 
			global::java.lang.Thread._getPriority10714 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getPriority", "()I"); 
			global::java.lang.Thread._setName10715 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setName", "(Ljava/lang/String;)V"); 
			global::java.lang.Thread._activeCount10716 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "activeCount", "()I"); 
			global::java.lang.Thread._enumerate10717 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "enumerate", "([Ljava/lang/Thread;)I"); 
			global::java.lang.Thread._countStackFrames10718 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "countStackFrames", "()I"); 
			global::java.lang.Thread._join10719 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "()V"); 
			global::java.lang.Thread._join10720 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "(JI)V"); 
			global::java.lang.Thread._join10721 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "join", "(J)V"); 
			global::java.lang.Thread._isDaemon10722 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "isDaemon", "()Z"); 
			global::java.lang.Thread._checkAccess10723 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "checkAccess", "()V"); 
			global::java.lang.Thread._getContextClassLoader10724 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getContextClassLoader", "()Ljava/lang/ClassLoader;"); 
			global::java.lang.Thread._setContextClassLoader10725 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setContextClassLoader", "(Ljava/lang/ClassLoader;)V"); 
			global::java.lang.Thread._holdsLock10726 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "holdsLock", "(Ljava/lang/Object;)Z"); 
			global::java.lang.Thread._getAllStackTraces10727 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "getAllStackTraces", "()Ljava/util/Map;"); 
			global::java.lang.Thread._getId10728 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getId", "()J"); 
			global::java.lang.Thread._getState10729 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getState", "()Ljava/lang/Thread$State;"); 
			global::java.lang.Thread._setDefaultUncaughtExceptionHandler10730 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "setDefaultUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V"); 
			global::java.lang.Thread._getDefaultUncaughtExceptionHandler10731 = @__env.GetStaticMethodID(global::java.lang.Thread.staticClass, "getDefaultUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;"); 
			global::java.lang.Thread._getUncaughtExceptionHandler10732 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;"); 
			global::java.lang.Thread._setUncaughtExceptionHandler10733 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "setUncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)V"); 
			global::java.lang.Thread._Thread10734 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;)V"); 
			global::java.lang.Thread._Thread10735 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;J)V"); 
			global::java.lang.Thread._Thread10736 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/Runnable;Ljava/lang/String;)V"); 
			global::java.lang.Thread._Thread10737 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/String;)V"); 
			global::java.lang.Thread._Thread10738 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/Runnable;)V"); 
			global::java.lang.Thread._Thread10739 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/ThreadGroup;Ljava/lang/String;)V"); 
			global::java.lang.Thread._Thread10740 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::java.lang.Thread._Thread10741 = @__env.GetMethodID(global::java.lang.Thread.staticClass, "<init>", "()V"); 
		} 
	} 
} 
