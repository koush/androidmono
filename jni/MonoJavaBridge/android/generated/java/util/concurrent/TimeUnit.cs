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
		internal static global::MonoJavaBridge.MethodId _values27500;
		public static global::java.util.concurrent.TimeUnit[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.concurrent.TimeUnit>(@__env.CallStaticObjectMethod(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._values27500)) as java.util.concurrent.TimeUnit[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf27501;
		public static global::java.util.concurrent.TimeUnit valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._valueOf27501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.TimeUnit;
		}
		internal static global::MonoJavaBridge.MethodId _sleep27502;
		public virtual void sleep(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._sleep27502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._sleep27502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toNanos27503;
		public virtual long toNanos(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toNanos27503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toNanos27503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convert27504;
		public virtual long convert(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._convert27504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._convert27504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toMicros27505;
		public virtual long toMicros(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toMicros27505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMicros27505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toMillis27506;
		public virtual long toMillis(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toMillis27506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMillis27506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toSeconds27507;
		public virtual long toSeconds(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toSeconds27507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toSeconds27507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toMinutes27508;
		public virtual long toMinutes(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toMinutes27508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMinutes27508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHours27509;
		public virtual long toHours(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toHours27509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toHours27509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDays27510;
		public virtual long toDays(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._toDays27510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toDays27510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _timedWait27511;
		public virtual void timedWait(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._timedWait27511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._timedWait27511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _timedJoin27512;
		public virtual void timedJoin(java.lang.Thread arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit._timedJoin27512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._timedJoin27512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.FieldId _NANOSECONDS27513;
		public static global::java.util.concurrent.TimeUnit NANOSECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _NANOSECONDS27513)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MICROSECONDS27514;
		public static global::java.util.concurrent.TimeUnit MICROSECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _MICROSECONDS27514)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MILLISECONDS27515;
		public static global::java.util.concurrent.TimeUnit MILLISECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _MILLISECONDS27515)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SECONDS27516;
		public static global::java.util.concurrent.TimeUnit SECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _SECONDS27516)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MINUTES27517;
		public static global::java.util.concurrent.TimeUnit MINUTES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _MINUTES27517)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOURS27518;
		public static global::java.util.concurrent.TimeUnit HOURS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _HOURS27518)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DAYS27519;
		public static global::java.util.concurrent.TimeUnit DAYS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _DAYS27519)) as java.util.concurrent.TimeUnit;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.TimeUnit.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/TimeUnit"));
			global::java.util.concurrent.TimeUnit._values27500 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "values", "()[Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._valueOf27501 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._sleep27502 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "sleep", "(J)V");
			global::java.util.concurrent.TimeUnit._toNanos27503 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toNanos", "(J)J");
			global::java.util.concurrent.TimeUnit._convert27504 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "convert", "(JLjava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.TimeUnit._toMicros27505 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toMicros", "(J)J");
			global::java.util.concurrent.TimeUnit._toMillis27506 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toMillis", "(J)J");
			global::java.util.concurrent.TimeUnit._toSeconds27507 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toSeconds", "(J)J");
			global::java.util.concurrent.TimeUnit._toMinutes27508 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toMinutes", "(J)J");
			global::java.util.concurrent.TimeUnit._toHours27509 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toHours", "(J)J");
			global::java.util.concurrent.TimeUnit._toDays27510 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "toDays", "(J)J");
			global::java.util.concurrent.TimeUnit._timedWait27511 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "timedWait", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.TimeUnit._timedJoin27512 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "timedJoin", "(Ljava/lang/Thread;J)V");
			global::java.util.concurrent.TimeUnit._NANOSECONDS27513 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "NANOSECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._MICROSECONDS27514 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "MICROSECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._MILLISECONDS27515 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "MILLISECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._SECONDS27516 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "SECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._MINUTES27517 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "MINUTES", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._HOURS27518 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "HOURS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._DAYS27519 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "DAYS", "Ljava/util/concurrent/TimeUnit;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.TimeUnit))]
	internal sealed partial class TimeUnit_ : java.util.concurrent.TimeUnit
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
