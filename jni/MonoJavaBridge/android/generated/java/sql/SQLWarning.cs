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
		internal static global::MonoJavaBridge.MethodId _getNextWarning24914;
		public virtual global::java.sql.SQLWarning getNextWarning() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLWarning._getNextWarning24914)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._getNextWarning24914)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _setNextWarning24915;
		public virtual void setNextWarning(java.sql.SQLWarning arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLWarning._setNextWarning24915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._setNextWarning24915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24916;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24917;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24918;
		public SQLWarning(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24919;
		public SQLWarning()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24919);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24920;
		public SQLWarning(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24921;
		public SQLWarning(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24922;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLWarning24923;
		public SQLWarning(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.Throwable arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLWarning.staticClass, global::java.sql.SQLWarning._SQLWarning24923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLWarning.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLWarning"));
			global::java.sql.SQLWarning._getNextWarning24914 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "getNextWarning", "()Ljava/sql/SQLWarning;");
			global::java.sql.SQLWarning._setNextWarning24915 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "setNextWarning", "(Ljava/sql/SQLWarning;)V");
			global::java.sql.SQLWarning._SQLWarning24916 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::java.sql.SQLWarning._SQLWarning24917 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.SQLWarning._SQLWarning24918 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.sql.SQLWarning._SQLWarning24919 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "()V");
			global::java.sql.SQLWarning._SQLWarning24920 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.sql.SQLWarning._SQLWarning24921 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.sql.SQLWarning._SQLWarning24922 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.sql.SQLWarning._SQLWarning24923 = @__env.GetMethodIDNoThrow(global::java.sql.SQLWarning.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V");
		}
	}
}
