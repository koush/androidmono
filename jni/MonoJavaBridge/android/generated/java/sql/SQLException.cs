namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLException : java.lang.Exception, java.lang.Iterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLException()
		{
			InitJNI();
		}
		protected SQLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _iterator19156;
		public virtual global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLException._iterator19156)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLException.staticClass, global::java.sql.SQLException._iterator19156)) as java.util.Iterator;
		}
		public new global::java.lang.String SQLState
		{
			get
			{
				return getSQLState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSQLState19157;
		public virtual global::java.lang.String getSQLState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLException._getSQLState19157)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLException.staticClass, global::java.sql.SQLException._getSQLState19157)) as java.lang.String;
		}
		public new int ErrorCode
		{
			get
			{
				return getErrorCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getErrorCode19158;
		public virtual int getErrorCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.SQLException._getErrorCode19158);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.SQLException.staticClass, global::java.sql.SQLException._getErrorCode19158);
		}
		public new global::java.sql.SQLException NextException
		{
			get
			{
				return getNextException();
			}
			set
			{
				setNextException(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextException19159;
		public virtual global::java.sql.SQLException getNextException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.SQLException._getNextException19159)) as java.sql.SQLException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.SQLException.staticClass, global::java.sql.SQLException._getNextException19159)) as java.sql.SQLException;
		}
		internal static global::MonoJavaBridge.MethodId _setNextException19160;
		public virtual void setNextException(java.sql.SQLException arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.SQLException._setNextException19160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.SQLException.staticClass, global::java.sql.SQLException._setNextException19160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19161;
		public SQLException(java.lang.String arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19162;
		public SQLException(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19163;
		public SQLException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19164;
		public SQLException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19164);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19165;
		public SQLException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19166;
		public SQLException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19167;
		public SQLException(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException19168;
		public SQLException(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.Throwable arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException19168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLException"));
			global::java.sql.SQLException._iterator19156 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.sql.SQLException._getSQLState19157 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "getSQLState", "()Ljava/lang/String;");
			global::java.sql.SQLException._getErrorCode19158 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "getErrorCode", "()I");
			global::java.sql.SQLException._getNextException19159 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "getNextException", "()Ljava/sql/SQLException;");
			global::java.sql.SQLException._setNextException19160 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "setNextException", "(Ljava/sql/SQLException;)V");
			global::java.sql.SQLException._SQLException19161 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::java.sql.SQLException._SQLException19162 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.SQLException._SQLException19163 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.sql.SQLException._SQLException19164 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "()V");
			global::java.sql.SQLException._SQLException19165 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.sql.SQLException._SQLException19166 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.sql.SQLException._SQLException19167 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.sql.SQLException._SQLException19168 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V");
		}
	}
}
