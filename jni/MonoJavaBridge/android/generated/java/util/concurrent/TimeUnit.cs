namespace java.util.concurrent
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class TimeUnit : java.lang.Enum
	{
		internal new static global::java.lang.Class staticClass;
		static TimeUnit()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.concurrent.TimeUnit), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected TimeUnit(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _values13864;
		public static global::java.util.concurrent.TimeUnit[] values() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._values13864));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf13865;
		public static global::java.util.concurrent.TimeUnit valueOf(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.concurrent.TimeUnit>(@__env, @__env.CallStaticObjectMethodPtr(java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._valueOf13865, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sleep13866;
		public virtual void sleep(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.concurrent.TimeUnit._sleep13866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._sleep13866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toNanos13867;
		public virtual long toNanos(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._toNanos13867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toNanos13867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _convert13868;
		public virtual long convert(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._convert13868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._convert13868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toMicros13869;
		public virtual long toMicros(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._toMicros13869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMicros13869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toMillis13870;
		public virtual long toMillis(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._toMillis13870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMillis13870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toSeconds13871;
		public virtual long toSeconds(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._toSeconds13871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toSeconds13871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toMinutes13872;
		public virtual long toMinutes(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._toMinutes13872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toMinutes13872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toHours13873;
		public virtual long toHours(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._toHours13873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toHours13873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toDays13874;
		public virtual long toDays(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.concurrent.TimeUnit._toDays13874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._toDays13874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _timedWait13875;
		public virtual void timedWait(java.lang.Object arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.concurrent.TimeUnit._timedWait13875, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._timedWait13875, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _timedJoin13876;
		public virtual void timedJoin(java.lang.Thread arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.concurrent.TimeUnit._timedJoin13876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.concurrent.TimeUnit.staticClass, global::java.util.concurrent.TimeUnit._timedJoin13876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.FieldId _NANOSECONDS13877;
		public static global::java.util.concurrent.TimeUnit NANOSECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _MICROSECONDS13878;
		public static global::java.util.concurrent.TimeUnit MICROSECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _MILLISECONDS13879;
		public static global::java.util.concurrent.TimeUnit MILLISECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _SECONDS13880;
		public static global::java.util.concurrent.TimeUnit SECONDS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _MINUTES13881;
		public static global::java.util.concurrent.TimeUnit MINUTES
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _HOURS13882;
		public static global::java.util.concurrent.TimeUnit HOURS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _DAYS13883;
		public static global::java.util.concurrent.TimeUnit DAYS
		{
			get
			{
				return default(global::java.util.concurrent.TimeUnit);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.concurrent.TimeUnit.staticClass = @__class;
			global::java.util.concurrent.TimeUnit._values13864 = @__env.GetStaticMethodID(global::java.util.concurrent.TimeUnit.staticClass, "values", "()[Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._valueOf13865 = @__env.GetStaticMethodID(global::java.util.concurrent.TimeUnit.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/concurrent/TimeUnit;");
			global::java.util.concurrent.TimeUnit._sleep13866 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "sleep", "(J)V");
			global::java.util.concurrent.TimeUnit._toNanos13867 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toNanos", "(J)J");
			global::java.util.concurrent.TimeUnit._convert13868 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "convert", "(JLjava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.TimeUnit._toMicros13869 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMicros", "(J)J");
			global::java.util.concurrent.TimeUnit._toMillis13870 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMillis", "(J)J");
			global::java.util.concurrent.TimeUnit._toSeconds13871 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toSeconds", "(J)J");
			global::java.util.concurrent.TimeUnit._toMinutes13872 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toMinutes", "(J)J");
			global::java.util.concurrent.TimeUnit._toHours13873 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toHours", "(J)J");
			global::java.util.concurrent.TimeUnit._toDays13874 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "toDays", "(J)J");
			global::java.util.concurrent.TimeUnit._timedWait13875 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "timedWait", "(Ljava/lang/Object;J)V");
			global::java.util.concurrent.TimeUnit._timedJoin13876 = @__env.GetMethodID(global::java.util.concurrent.TimeUnit.staticClass, "timedJoin", "(Ljava/lang/Thread;J)V");
		}
	}
}
