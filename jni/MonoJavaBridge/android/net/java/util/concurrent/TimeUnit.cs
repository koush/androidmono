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
		internal static global::net.sf.jni4net.jni.MethodId _valueOf13033; 
		public static java.util.concurrent.TimeUnit valueOf(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.concurrent.TimeUnit>(@__env, @__env.CallStaticObjectMethodPtr(java.util.concurrent.TimeUnit.staticClass, _valueOf13033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values13034; 
		public static java.util.concurrent.TimeUnit[] values() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.concurrent.TimeUnit.staticClass, _values13034)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sleep13035; 
		public virtual void sleep(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				@__env.CallVoidMethod(this, _sleep13035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.concurrent.TimeUnit.staticClass, _sleep13035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toNanos13036; 
		public virtual long toNanos(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toNanos13036, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toNanos13036, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convert13037; 
		public virtual long convert(long arg0, java.util.concurrent.TimeUnit arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _convert13037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _convert13037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMicros13038; 
		public virtual long toMicros(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toMicros13038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toMicros13038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMillis13039; 
		public virtual long toMillis(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toMillis13039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toMillis13039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toSeconds13040; 
		public virtual long toSeconds(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toSeconds13040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toSeconds13040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMinutes13041; 
		public virtual long toMinutes(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toMinutes13041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toMinutes13041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toHours13042; 
		public virtual long toHours(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toHours13042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toHours13042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toDays13043; 
		public virtual long toDays(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				return @__env.CallLongMethod(this, _toDays13043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.concurrent.TimeUnit.staticClass, _toDays13043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timedWait13044; 
		public virtual void timedWait(java.lang.Object arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				@__env.CallVoidMethod(this, _timedWait13044, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.concurrent.TimeUnit.staticClass, _timedWait13044, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timedJoin13045; 
		public virtual void timedJoin(java.lang.Thread arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.concurrent.TimeUnit)) 
				@__env.CallVoidMethod(this, _timedJoin13045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.concurrent.TimeUnit.staticClass, _timedJoin13045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _NANOSECONDS13046; 
		public static java.util.concurrent.TimeUnit NANOSECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MICROSECONDS13047; 
		public static java.util.concurrent.TimeUnit MICROSECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MILLISECONDS13048; 
		public static java.util.concurrent.TimeUnit MILLISECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SECONDS13049; 
		public static java.util.concurrent.TimeUnit SECONDS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MINUTES13050; 
		public static java.util.concurrent.TimeUnit MINUTES
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _HOURS13051; 
		public static java.util.concurrent.TimeUnit HOURS
		{ 
			get 
			{ 
				return default(java.util.concurrent.TimeUnit); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DAYS13052; 
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
			global::java.util.concurrent.TimeUnit._valueOf13033 = @__env.GetStaticMethodID(global::java.util.concurrent.TimeUnit.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;"); 
			global::java.util.concurrent.TimeUnit._values13034 = @__env.GetStaticMethodID(global::java.util.concurrent.TimeUnit.staticClass, "values", "()[Ljava/util/concurrent/TimeUnit;"); 
			global::java.util.concurrent.TimeUnit._sleep13035 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "sleep", "(J)V"); 
			global::java.util.concurrent.TimeUnit._toNanos13036 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toNanos", "(J)J"); 
			global::java.util.concurrent.TimeUnit._convert13037 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "convert", "(JLjava/util/concurrent/TimeUnit;)J"); 
			global::java.util.concurrent.TimeUnit._toMicros13038 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMicros", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toMillis13039 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMillis", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toSeconds13040 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toSeconds", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toMinutes13041 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMinutes", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toHours13042 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toHours", "(J)J"); 
			global::java.util.concurrent.TimeUnit._toDays13043 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toDays", "(J)J"); 
			global::java.util.concurrent.TimeUnit._timedWait13044 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "timedWait", "(Ljava/lang/Object;J)V"); 
			global::java.util.concurrent.TimeUnit._timedJoin13045 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "timedJoin", "(Ljava/lang/Thread;J)V"); 
		} 
	} 
} 
