namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Date : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Date(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Date.staticClass, "toString", "()Ljava/lang/String;", ref global::java.sql.Date._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.sql.Date valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Date._m1.native == global::System.IntPtr.Zero)
				global::java.sql.Date._m1 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Date.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Date;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Date.staticClass, global::java.sql.Date._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		public new long Time
		{
			set
			{
				setTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setTime", "(J)V", ref global::java.sql.Date._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Hours
		{
			get
			{
				return getHours();
			}
			set
			{
				setHours(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getHours()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Date.staticClass, "getHours", "()I", ref global::java.sql.Date._m3);
		}
		public new int Minutes
		{
			get
			{
				return getMinutes();
			}
			set
			{
				setMinutes(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getMinutes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Date.staticClass, "getMinutes", "()I", ref global::java.sql.Date._m4);
		}
		public new int Seconds
		{
			get
			{
				return getSeconds();
			}
			set
			{
				setSeconds(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getSeconds()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Date.staticClass, "getSeconds", "()I", ref global::java.sql.Date._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setHours(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setHours", "(I)V", ref global::java.sql.Date._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setMinutes(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setMinutes", "(I)V", ref global::java.sql.Date._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setSeconds(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Date.staticClass, "setSeconds", "(I)V", ref global::java.sql.Date._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Date(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Date._m9.native == global::System.IntPtr.Zero)
				global::java.sql.Date._m9 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Date(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Date._m10.native == global::System.IntPtr.Zero)
				global::java.sql.Date._m10 = @__env.GetMethodIDNoThrow(global::java.sql.Date.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Date.staticClass, global::java.sql.Date._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Date()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Date.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Date"));
		}
	}
}
