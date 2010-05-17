namespace java.util.concurrent 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class TimeUnit : java.lang.Enum
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TimeUnit() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.concurrent.TimeUnit), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected TimeUnit(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf12087; 
		public static java.util.concurrent.TimeUnit valueOf(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.concurrent.TimeUnit>(@__env, @__env.CallStaticObjectMethodPtr(java.util.concurrent.TimeUnit.staticClass, _valueOf12087, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values12088; 
		public static java.util.concurrent.TimeUnit[] values() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.concurrent.TimeUnit.staticClass, _values12088)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sleep12089; 
		public virtual void sleep(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				@__env.CallVoidMethod(this, _sleep12089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.concurrent.TimeUnit.staticClass, _sleep12089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toNanos12090; 
		public virtual long toNanos(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toNanos12090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toNanos12090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convert12091; 
		public virtual long convert(long arg0, java.util.concurrent.TimeUnit arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _convert12091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _convert12091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMicros12092; 
		public virtual long toMicros(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toMicros12092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toMicros12092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMillis12093; 
		public virtual long toMillis(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toMillis12093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toMillis12093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toSeconds12094; 
		public virtual long toSeconds(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toSeconds12094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toSeconds12094, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMinutes12095; 
		public virtual long toMinutes(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toMinutes12095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toMinutes12095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toHours12096; 
		public virtual long toHours(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toHours12096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toHours12096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toDays12097; 
		public virtual long toDays(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toDays12097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toDays12097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timedWait12098; 
		public virtual void timedWait(java.lang.Object arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				@__env.CallVoidMethod(this, _timedWait12098, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.concurrent.TimeUnit.staticClass, _timedWait12098, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timedJoin12099; 
		public virtual void timedJoin(java.lang.Thread arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				@__env.CallVoidMethod(this, _timedJoin12099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.concurrent.TimeUnit.staticClass, _timedJoin12099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _NANOSECONDS12100; 
		public static java.util.concurrent.TimeUnit NANOSECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MICROSECONDS12101; 
		public static java.util.concurrent.TimeUnit MICROSECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MILLISECONDS12102; 
		public static java.util.concurrent.TimeUnit MILLISECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SECONDS12103; 
		public static java.util.concurrent.TimeUnit SECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MINUTES12104; 
		public static java.util.concurrent.TimeUnit MINUTES
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _HOURS12105; 
		public static java.util.concurrent.TimeUnit HOURS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DAYS12106; 
		public static java.util.concurrent.TimeUnit DAYS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.concurrent.TimeUnit.staticClass = @__class; 
			global::java.util.concurrent.TimeUnit._valueOf12087 = @__env.GetStaticMethodID(global::java.util.concurrent.TimeUnit.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;"); 
			global::java.util.concurrent.TimeUnit._values12088 = @__env.GetStaticMethodID(global::java.util.concurrent.TimeUnit.staticClass, "values", "()[Ljava/util/concurrent/TimeUnit;"); 
			global::java.util.concurrent.TimeUnit._sleep12089 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "sleep", "(J)V"); 
			global::java.util.concurrent.TimeUnit._toNanos12090 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toNanos", "(J)J"); 
			global::java.util.concurrent.TimeUnit._convert12091 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "convert", "(JLjava/util/concurrent/TimeUnit;)J"); 
			global::java.util.concurrent.TimeUnit._toMicros12092 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMicros", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toMillis12093 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMillis", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toSeconds12094 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toSeconds", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toMinutes12095 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMinutes", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toHours12096 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toHours", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toDays12097 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toDays", "(J)J"); 
			global::java.util.concurrent.TimeUnit._timedWait12098 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "timedWait", "(Ljava/lang/Object;J)V"); 
			global::java.util.concurrent.TimeUnit._timedJoin12099 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "timedJoin", "(Ljava/lang/Thread;J)V"); 
		} 
	} 
} 
