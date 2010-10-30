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
		internal static global::MonoJavaBridge.MethodId _getNextWarning25033;
		public virtual global::java.sql.SQLWarning getNextWarning()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._getNextWarning25033.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._getNextWarning25033 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "getNextWarning", "()Ljava/sql/SQLWarning;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._getNextWarning25033) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _setNextWarning25034;
		public virtual void setNextWarning(java.sql.SQLWarning arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._setNextWarning25034.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._setNextWarning25034 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "setNextWarning", "(Ljava/sql/SQLWarning;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._setNextWarning25034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25035;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25035.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25035 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25036;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25036.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25036 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25037;
		public SQLWarning(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25037.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25037 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25038;
		public SQLWarning() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25038.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25038 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25038);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25039;
		public SQLWarning(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25039.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25039 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25040;
		public SQLWarning(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25040.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25040 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25041;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25041.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25041 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning25042;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.Throwable arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLWarning._SQLWarning25042.native == global::System.IntPtr.Zero)
				global::java.sql.SQLWarning._SQLWarning25042 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning25042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
