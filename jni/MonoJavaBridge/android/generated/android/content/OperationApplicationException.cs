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
		public new int NumSuccessfulYieldPoints
		{
			get
			{
				return getNumSuccessfulYieldPoints();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumSuccessfulYieldPoints3483;
		public virtual int getNumSuccessfulYieldPoints()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints3483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints3483);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException3484;
		public OperationApplicationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException3484);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException3485;
		public OperationApplicationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException3485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException3486;
		public OperationApplicationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException3486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException3487;
		public OperationApplicationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException3487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException3488;
		public OperationApplicationException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException3488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationApplicationException3489;
		public OperationApplicationException(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.OperationApplicationException.staticClass, global::android.content.OperationApplicationException._OperationApplicationException3489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.OperationApplicationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/OperationApplicationException"));
			global::android.content.OperationApplicationException._getNumSuccessfulYieldPoints3483 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "getNumSuccessfulYieldPoints", "()I");
			global::android.content.OperationApplicationException._OperationApplicationException3484 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "()V");
			global::android.content.OperationApplicationException._OperationApplicationException3485 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.OperationApplicationException._OperationApplicationException3486 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.content.OperationApplicationException._OperationApplicationException3487 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::android.content.OperationApplicationException._OperationApplicationException3488 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(I)V");
			global::android.content.OperationApplicationException._OperationApplicationException3489 = @__env.GetMethodIDNoThrow(global::android.content.OperationApplicationException.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
