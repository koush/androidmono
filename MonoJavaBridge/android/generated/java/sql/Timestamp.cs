namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Timestamp : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Timestamp(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Timestamp.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.sql.Timestamp._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool equals(java.sql.Timestamp arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Timestamp.staticClass, "equals", "(Ljava/sql/Timestamp;)Z", ref global::java.sql.Timestamp._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Timestamp.staticClass, "toString", "()Ljava/lang/String;", ref global::java.sql.Timestamp._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int compareTo(java.sql.Timestamp arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Timestamp.staticClass, "compareTo", "(Ljava/sql/Timestamp;)I", ref global::java.sql.Timestamp._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int compareTo(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Timestamp.staticClass, "compareTo", "(Ljava/util/Date;)I", ref global::java.sql.Timestamp._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.sql.Timestamp valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Timestamp._m5.native == global::System.IntPtr.Zero)
				global::java.sql.Timestamp._m5 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Timestamp.staticClass, global::java.sql.Timestamp._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool after(java.sql.Timestamp arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Timestamp.staticClass, "after", "(Ljava/sql/Timestamp;)Z", ref global::java.sql.Timestamp._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool before(java.sql.Timestamp arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Timestamp.staticClass, "before", "(Ljava/sql/Timestamp;)Z", ref global::java.sql.Timestamp._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Timestamp.staticClass, "setTime", "(J)V", ref global::java.sql.Timestamp._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Time
		{
			get
			{
				return getTime();
			}
			set
			{
				setTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override long getTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Timestamp.staticClass, "getTime", "()J", ref global::java.sql.Timestamp._m9);
		}
		public new int Nanos
		{
			get
			{
				return getNanos();
			}
			set
			{
				setNanos(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getNanos()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Timestamp.staticClass, "getNanos", "()I", ref global::java.sql.Timestamp._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setNanos(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Timestamp.staticClass, "setNanos", "(I)V", ref global::java.sql.Timestamp._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Timestamp(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Timestamp._m12.native == global::System.IntPtr.Zero)
				global::java.sql.Timestamp._m12 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Timestamp.staticClass, global::java.sql.Timestamp._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public Timestamp(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.Timestamp._m13.native == global::System.IntPtr.Zero)
				global::java.sql.Timestamp._m13 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "<init>", "(IIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Timestamp.staticClass, global::java.sql.Timestamp._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		static Timestamp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Timestamp.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Timestamp"));
		}
		internal static void InitJNI()
		{
		}
	}
}
