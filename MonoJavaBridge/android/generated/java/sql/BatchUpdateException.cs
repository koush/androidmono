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
		internal static global::MonoJavaBridge.MethodId _getUpdateCounts24091;
		public virtual int[] getUpdateCounts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::java.sql.BatchUpdateException.staticClass, "getUpdateCounts", "()[I", ref global::java.sql.BatchUpdateException._getUpdateCounts24091) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24092;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int arg2, int[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24092.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24092 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24093;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24093.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24093 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24094;
		public BatchUpdateException(java.lang.String arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24094.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24094 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24095;
		public BatchUpdateException(int[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24095.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24095 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "([I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24096;
		public BatchUpdateException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24096.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24096 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24096);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24097;
		public BatchUpdateException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24097.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24097 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24098;
		public BatchUpdateException(int[] arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24098.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24098 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "([ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24099;
		public BatchUpdateException(java.lang.String arg0, int[] arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24099.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24099 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;[ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24100;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int[] arg2, java.lang.Throwable arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24100.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24100 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException24101;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int arg2, int[] arg3, java.lang.Throwable arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.BatchUpdateException._BatchUpdateException24101.native == global::System.IntPtr.Zero)
				global::java.sql.BatchUpdateException._BatchUpdateException24101 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I[ILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException24101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static BatchUpdateException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.BatchUpdateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/BatchUpdateException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
