namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.TimeUnit_))]
	public abstract partial class TimeUnit : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeUnit()
		{
			InitJNI();
		}
		protected TimeUnit(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values15728;
		public static global::java.util.concurrent.TimeUnit[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.concurrent.TimeUnit>(@__env.CallStaticObjectMethod(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._values15728)) as java.util.concurrent.TimeUnit[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15729;
		public static global::java.util.concurrent.TimeUnit valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._valueOf15729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.TimeUnit;
		}
		internal static global::MonoJavaBridge.MethodId _sleep15730;
		public virtual void sleep(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._sleep15730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._sleep15730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toNanos15731;
		public virtual long toNanos(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toNanos15731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toNanos15731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convert15732;
		public virtual long convert(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._convert15732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._convert15732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toMicros15733;
		public virtual long toMicros(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toMicros15733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMicros15733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toMillis15734;
		public virtual long toMillis(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toMillis15734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMillis15734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toSeconds15735;
		public virtual long toSeconds(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toSeconds15735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toSeconds15735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toMinutes15736;
		public virtual long toMinutes(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toMinutes15736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMinutes15736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHours15737;
		public virtual long toHours(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toHours15737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toHours15737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDays15738;
		public virtual long toDays(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toDays15738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toDays15738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timedWait15739;
		public virtual void timedWait(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._timedWait15739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._timedWait15739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _timedJoin15740;
		public virtual void timedJoin(java.lang.Thread arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._timedJoin15740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._timedJoin15740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.FieldId _NANOSECONDS15741;
		public static global::java.util.concurrent.TimeUnit NANOSECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MICROSECONDS15742;
		public static global::java.util.concurrent.TimeUnit MICROSECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MILLISECONDS15743;
		public static global::java.util.concurrent.TimeUnit MILLISECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SECONDS15744;
		public static global::java.util.concurrent.TimeUnit SECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MINUTES15745;
		public static global::java.util.concurrent.TimeUnit MINUTES
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOURS15746;
		public static global::java.util.concurrent.TimeUnit HOURS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DAYS15747;
		public static global::java.util.concurrent.TimeUnit DAYS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.TimeUnit.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/TimeUnit"));
			global::java.util.concurrent.TimeUnit._values15728 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "values", "()[Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._valueOf15729 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._sleep15730 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "sleep", "(J)V");
			global::java.util.concurrent.TimeUnit._toNanos15731 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toNanos", "(J)J");
			global::java.util.concurrent.TimeUnit._convert15732 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "convert", "(JLjava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.TimeUnit._toMicros15733 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toMicros", "(J)J");
			global::java.util.concurrent.TimeUnit._toMillis15734 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toMillis", "(J)J");
			global::java.util.concurrent.TimeUnit._toSeconds15735 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toSeconds", "(J)J");
			global::java.util.concurrent.TimeUnit._toMinutes15736 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toMinutes", "(J)J");
			global::java.util.concurrent.TimeUnit._toHours15737 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toHours", "(J)J");
			global::java.util.concurrent.TimeUnit._toDays15738 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toDays", "(J)J");
			global::java.util.concurrent.TimeUnit._timedWait15739 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "timedWait", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.TimeUnit._timedJoin15740 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "timedJoin", "(Ljava/lang/Thread;J)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.TimeUnit))]
	public sealed partial class TimeUnit_ : java.util.concurrent.TimeUnit
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeUnit_()
		{
			InitJNI();
		}
		internal TimeUnit_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.TimeUnit_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/TimeUnit"));
		}
	}
}
