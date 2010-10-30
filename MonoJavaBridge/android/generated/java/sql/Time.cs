namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Time : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Time(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Time.staticClass, "toString", "()Ljava/lang/String;", ref global::java.sql.Time._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.sql.Time valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Time._m1.native == global::System.IntPtr.Zero)
				global::java.sql.Time._m1 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Time.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Time;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Time.staticClass, global::java.sql.Time._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Time.staticClass, "setTime", "(J)V", ref global::java.sql.Time._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
			set
			{
				setYear(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getYear()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Time.staticClass, "getYear", "()I", ref global::java.sql.Time._m3);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
			set
			{
				setMonth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Time.staticClass, "getMonth", "()I", ref global::java.sql.Time._m4);
		}
		public new int Date
		{
			get
			{
				return getDate();
			}
			set
			{
				setDate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Time.staticClass, "getDate", "()I", ref global::java.sql.Time._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setDate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Time.staticClass, "setDate", "(I)V", ref global::java.sql.Time._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setMonth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Time.staticClass, "setMonth", "(I)V", ref global::java.sql.Time._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setYear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Time.staticClass, "setYear", "(I)V", ref global::java.sql.Time._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getDay()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Time.staticClass, "getDay", "()I", ref global::java.sql.Time._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Time(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Time._m10.native == global::System.IntPtr.Zero)
				global::java.sql.Time._m10 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Time.staticClass, global::java.sql.Time._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Time(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Time._m11.native == global::System.IntPtr.Zero)
				global::java.sql.Time._m11 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Time.staticClass, global::java.sql.Time._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Time()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Time.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Time"));
		}
		internal static void InitJNI()
		{
		}
	}
}
