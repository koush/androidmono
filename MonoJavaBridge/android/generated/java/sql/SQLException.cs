namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLException : java.lang.Exception, java.lang.Iterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator24970;
		public virtual global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.sql.SQLException.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.sql.SQLException._iterator24970) as java.util.Iterator;
		}
		public new global::java.lang.String SQLState
		{
			get
			{
				return getSQLState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSQLState24971;
		public virtual global::java.lang.String getSQLState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.SQLException.staticClass, "getSQLState", "()Ljava/lang/String;", ref global::java.sql.SQLException._getSQLState24971) as java.lang.String;
		}
		public new int ErrorCode
		{
			get
			{
				return getErrorCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getErrorCode24972;
		public virtual int getErrorCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.SQLException.staticClass, "getErrorCode", "()I", ref global::java.sql.SQLException._getErrorCode24972);
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
		internal static global::MonoJavaBridge.MethodId _getNextException24973;
		public virtual global::java.sql.SQLException getNextException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLException.staticClass, "getNextException", "()Ljava/sql/SQLException;", ref global::java.sql.SQLException._getNextException24973) as java.sql.SQLException;
		}
		internal static global::MonoJavaBridge.MethodId _setNextException24974;
		public virtual void setNextException(java.sql.SQLException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLException.staticClass, "setNextException", "(Ljava/sql/SQLException;)V", ref global::java.sql.SQLException._setNextException24974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24975;
		public SQLException(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24975.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24975 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24976;
		public SQLException(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24976.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24976 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24977;
		public SQLException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24977.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24977 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24978;
		public SQLException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24978.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24978 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24978);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24979;
		public SQLException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24979.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24979 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24980;
		public SQLException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24980.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24980 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24981;
		public SQLException(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24981.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24981 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException24982;
		public SQLException(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.Throwable arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._SQLException24982.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._SQLException24982 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._SQLException24982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SQLException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
