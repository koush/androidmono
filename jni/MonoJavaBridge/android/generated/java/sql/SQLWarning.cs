namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLWarning : java.sql.SQLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLWarning()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getNextWarning19219;
		public virtual global::java.sql.SQLWarning getNextWarning() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLWarning._getNextWarning19219)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._getNextWarning19219)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _setNextWarning19220;
		public virtual void setNextWarning(java.sql.SQLWarning arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLWarning._setNextWarning19220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._setNextWarning19220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19221;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19222;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19223;
		public SQLWarning(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19224;
		public SQLWarning()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19224);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19225;
		public SQLWarning(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19226;
		public SQLWarning(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19227;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning19228;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.Throwable arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning19228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLWarning.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLWarning"));
			global::java.sql.SQLWarning._getNextWarning19219 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "getNextWarning", "()Ljava/sql/SQLWarning;");
			global::java.sql.SQLWarning._setNextWarning19220 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "setNextWarning", "(Ljava/sql/SQLWarning;)V");
			global::java.sql.SQLWarning._SQLWarning19221 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::java.sql.SQLWarning._SQLWarning19222 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.SQLWarning._SQLWarning19223 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.sql.SQLWarning._SQLWarning19224 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "()V");
			global::java.sql.SQLWarning._SQLWarning19225 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.sql.SQLWarning._SQLWarning19226 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.sql.SQLWarning._SQLWarning19227 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.sql.SQLWarning._SQLWarning19228 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V");
		}
	}
}
