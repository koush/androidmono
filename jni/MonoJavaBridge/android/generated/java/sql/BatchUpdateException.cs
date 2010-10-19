namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BatchUpdateException : java.sql.SQLException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BatchUpdateException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getUpdateCounts18363;
		public virtual int[] getUpdateCounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.BatchUpdateException._getUpdateCounts18363)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._getUpdateCounts18363)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18364;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int arg2, int[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18365;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18366;
		public BatchUpdateException(java.lang.String arg0, int[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18367;
		public BatchUpdateException(int[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18368;
		public BatchUpdateException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18368);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18369;
		public BatchUpdateException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18370;
		public BatchUpdateException(int[] arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18371;
		public BatchUpdateException(java.lang.String arg0, int[] arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18372;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int[] arg2, java.lang.Throwable arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BatchUpdateException18373;
		public BatchUpdateException(java.lang.String arg0, java.lang.String arg1, int arg2, int[] arg3, java.lang.Throwable arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.BatchUpdateException.staticClass, global::java.sql.BatchUpdateException._BatchUpdateException18373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.BatchUpdateException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/BatchUpdateException"));
			global::java.sql.BatchUpdateException._getUpdateCounts18363 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "getUpdateCounts", "()[I");
			global::java.sql.BatchUpdateException._BatchUpdateException18364 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I[I)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18365 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[I)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18366 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;[I)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18367 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "([I)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18368 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "()V");
			global::java.sql.BatchUpdateException._BatchUpdateException18369 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18370 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "([ILjava/lang/Throwable;)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18371 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;[ILjava/lang/Throwable;)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18372 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;[ILjava/lang/Throwable;)V");
			global::java.sql.BatchUpdateException._BatchUpdateException18373 = @__env.GetMethodIDNoThrow(global::java.sql.BatchUpdateException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I[ILjava/lang/Throwable;)V");
		}
	}
}
