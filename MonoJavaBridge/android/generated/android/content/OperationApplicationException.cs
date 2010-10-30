namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OperationApplicationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OperationApplicationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int NumSuccessfulYieldPoints
		{
			get
			{
				return getNumSuccessfulYieldPoints();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getNumSuccessfulYieldPoints()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.OperationApplicationException.staticClass, "getNumSuccessfulYieldPoints", "()I", ref global::android.content.OperationApplicationException._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public OperationApplicationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.OperationApplicationException._m1.native == global::System.IntPtr.Zero)
				global::android.content.OperationApplicationException._m1 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._m1);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public OperationApplicationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.OperationApplicationException._m2.native == global::System.IntPtr.Zero)
				global::android.content.OperationApplicationException._m2 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public OperationApplicationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.OperationApplicationException._m3.native == global::System.IntPtr.Zero)
				global::android.content.OperationApplicationException._m3 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public OperationApplicationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.OperationApplicationException._m4.native == global::System.IntPtr.Zero)
				global::android.content.OperationApplicationException._m4 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public OperationApplicationException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.OperationApplicationException._m5.native == global::System.IntPtr.Zero)
				global::android.content.OperationApplicationException._m5 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public OperationApplicationException(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.OperationApplicationException._m6.native == global::System.IntPtr.Zero)
				global::android.content.OperationApplicationException._m6 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static OperationApplicationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.OperationApplicationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/OperationApplicationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
