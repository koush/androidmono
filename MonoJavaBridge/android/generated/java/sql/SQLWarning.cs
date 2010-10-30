namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLWarning : java.sql.SQLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLWarning(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.sql.SQLWarning NextWarning
		{
			get
			{
				return getNextWarning();
			}
			set
			{
				setNextWarning(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.sql.SQLWarning getNextWarning()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLWarning.staticClass, "getNextWarning", "()Ljava/sql/SQLWarning;", ref global::java.sql.SQLWarning._m0) as java.sql.SQLWarning;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setNextWarning(java.sql.SQLWarning arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLWarning.staticClass, "setNextWarning", "(Ljava/sql/SQLWarning;)V", ref global::java.sql.SQLWarning._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m2.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m2 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m3.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m3 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public SQLWarning(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m4.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m4 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SQLWarning() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m5.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m5 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SQLWarning(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m6.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m6 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SQLWarning(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m7.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m7 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m8.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m8 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.Throwable arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._m9.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._m9 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SQLWarning()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLWarning.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLWarning"));
		}
		internal static void InitJNI()
		{
		}
	}
}
