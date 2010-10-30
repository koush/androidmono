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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.sql.SQLException.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.sql.SQLException._m0) as java.util.Iterator;
		}
		public new global::java.lang.String SQLState
		{
			get
			{
				return getSQLState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getSQLState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.SQLException.staticClass, "getSQLState", "()Ljava/lang/String;", ref global::java.sql.SQLException._m1) as java.lang.String;
		}
		public new int ErrorCode
		{
			get
			{
				return getErrorCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getErrorCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.SQLException.staticClass, "getErrorCode", "()I", ref global::java.sql.SQLException._m2);
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.sql.SQLException getNextException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.SQLException.staticClass, "getNextException", "()Ljava/sql/SQLException;", ref global::java.sql.SQLException._m3) as java.sql.SQLException;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setNextException(java.sql.SQLException arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.SQLException.staticClass, "setNextException", "(Ljava/sql/SQLException;)V", ref global::java.sql.SQLException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SQLException(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m5.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m5 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SQLException(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m6.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m6 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SQLException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m7.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m7 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public SQLException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m8.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m8 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m8);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public SQLException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m9.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m9 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public SQLException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m10.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m10 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public SQLException(java.lang.String arg0, java.lang.String arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m11.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m11 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SQLException(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.Throwable arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLException._m12.native == global::System.IntPtr.Zero)
				global::java.sql.SQLException._m12 = @__env.GetMethodIDNoThrow(global::java.sql.SQLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLException.staticClass, global::java.sql.SQLException._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
