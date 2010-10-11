namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OperationApplicationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OperationApplicationException()
		{
			InitJNI();
		}
		protected OperationApplicationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getNumSuccessfulYieldPoints1730;
		public virtual int getNumSuccessfulYieldPoints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints1730);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints1730);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException1731;
		public OperationApplicationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1731);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException1732;
		public OperationApplicationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException1733;
		public OperationApplicationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException1734;
		public OperationApplicationException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException1735;
		public OperationApplicationException(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException1736;
		public OperationApplicationException(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException1736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.OperationApplicationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/OperationApplicationException"));
			global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints1730 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "getNumSuccessfulYieldPoints", "()I");
			global::android.content.OperationApplicationException._OperationApplicationException1731 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "()V");
			global::android.content.OperationApplicationException._OperationApplicationException1732 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.OperationApplicationException._OperationApplicationException1733 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.content.OperationApplicationException._OperationApplicationException1734 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::android.content.OperationApplicationException._OperationApplicationException1735 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(I)V");
			global::android.content.OperationApplicationException._OperationApplicationException1736 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
