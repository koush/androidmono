namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.TimeUnit_))]
	public abstract partial class TimeUnit : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimeUnit(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.util.concurrent.TimeUnit[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.TimeUnit._m0.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.TimeUnit._m0 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "values", "()[Ljava/util/concurrent/TimeUnit;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.concurrent.TimeUnit>(@__env.CallStaticObjectMethod(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._m0)) as java.util.concurrent.TimeUnit[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.concurrent.TimeUnit valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.TimeUnit._m1.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.TimeUnit._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.TimeUnit;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void sleep(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "sleep", "(J)V", ref global::java.util.concurrent.TimeUnit._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual long toNanos(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "toNanos", "(J)J", ref global::java.util.concurrent.TimeUnit._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long convert(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "convert", "(JLjava/util/concurrent/TimeUnit;)J", ref global::java.util.concurrent.TimeUnit._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual long toMicros(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "toMicros", "(J)J", ref global::java.util.concurrent.TimeUnit._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long toMillis(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "toMillis", "(J)J", ref global::java.util.concurrent.TimeUnit._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual long toSeconds(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "toSeconds", "(J)J", ref global::java.util.concurrent.TimeUnit._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long toMinutes(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "toMinutes", "(J)J", ref global::java.util.concurrent.TimeUnit._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual long toHours(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "toHours", "(J)J", ref global::java.util.concurrent.TimeUnit._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long toDays(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "toDays", "(J)J", ref global::java.util.concurrent.TimeUnit._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void timedWait(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "timedWait", "(Ljava/lang/Object;J)V", ref global::java.util.concurrent.TimeUnit._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void timedJoin(java.lang.Thread arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.TimeUnit.staticClass, "timedJoin", "(Ljava/lang/Thread;J)V", ref global::java.util.concurrent.TimeUnit._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.FieldId _NANOSECONDS6698;
		public static global::java.util.concurrent.TimeUnit NANOSECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _NANOSECONDS6698)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MICROSECONDS6699;
		public static global::java.util.concurrent.TimeUnit MICROSECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _MICROSECONDS6699)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MILLISECONDS6700;
		public static global::java.util.concurrent.TimeUnit MILLISECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _MILLISECONDS6700)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SECONDS6701;
		public static global::java.util.concurrent.TimeUnit SECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _SECONDS6701)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MINUTES6702;
		public static global::java.util.concurrent.TimeUnit MINUTES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _MINUTES6702)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOURS6703;
		public static global::java.util.concurrent.TimeUnit HOURS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _HOURS6703)) as java.util.concurrent.TimeUnit;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DAYS6704;
		public static global::java.util.concurrent.TimeUnit DAYS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.concurrent.TimeUnit.staticClass, _DAYS6704)) as java.util.concurrent.TimeUnit;
			}
		}
		static TimeUnit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.TimeUnit.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/TimeUnit"));
			global::java.util.concurrent.TimeUnit._NANOSECONDS6698 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "NANOSECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._MICROSECONDS6699 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "MICROSECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._MILLISECONDS6700 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "MILLISECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._SECONDS6701 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "SECONDS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._MINUTES6702 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "MINUTES", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._HOURS6703 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "HOURS", "Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._DAYS6704 = @__env.GetStaticFieldIDNoThrow(global::java.util.concurrent.TimeUnit.staticClass, "DAYS", "Ljava/util/concurrent/TimeUnit;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.TimeUnit))]
	internal sealed partial class TimeUnit_ : java.util.concurrent.TimeUnit
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TimeUnit_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static TimeUnit_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.TimeUnit_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/TimeUnit"));
		}
	}
}
