namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BatchUpdateException : java.sql.SQLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BatchUpdateException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int[] UpdateCounts
		{
			get
			{
				return getUpdateCounts();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int[] getUpdateCounts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::java.sql.BatchUpdateException.staticClass, "getUpdateCounts", "()[I", ref global::java.sql.BatchUpdateException._m0) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int arg2, int[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m1.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m1 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m2.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m2 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public BatchUpdateException(java.lang.String arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m3.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m3 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public BatchUpdateException(int[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m4.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m4 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "([I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public BatchUpdateException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m5.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m5 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public BatchUpdateException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m6.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m6 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public BatchUpdateException(int[] arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m7.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m7 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "([ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public BatchUpdateException(java.lang.String arg0, int[] arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m8.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m8 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;[ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int[] arg2, java.lang.Throwable arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m9.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m9 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int arg2, int[] arg3, java.lang.Throwable arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._m10.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._m10 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I[ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static BatchUpdateException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.BatchUpdateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/BatchUpdateException"));
		}
	}
}
