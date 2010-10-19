namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileHandler : java.util.logging.StreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileHandler()
		{
			InitJNI();
		}
		protected FileHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close21965;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.FileHandler._close21965);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._close21965);
		}
		internal static global::MonoJavaBridge.MethodId _publish21966;
		public override void publish(java.util.logging.LogRecord arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.FileHandler._publish21966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._publish21966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler21967;
		public FileHandler(java.lang.String arg0, int arg1, int arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler21967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler21968;
		public FileHandler(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler21968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler21969;
		public FileHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler21969);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler21970;
		public FileHandler(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler21970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileHandler21971;
		public FileHandler(java.lang.String arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.FileHandler.staticClass, global::java.util.logging.FileHandler._FileHandler21971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.FileHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/FileHandler"));
			global::java.util.logging.FileHandler._close21965 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "close", "()V");
			global::java.util.logging.FileHandler._publish21966 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.FileHandler._FileHandler21967 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;IIZ)V");
			global::java.util.logging.FileHandler._FileHandler21968 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.logging.FileHandler._FileHandler21969 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "()V");
			global::java.util.logging.FileHandler._FileHandler21970 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::java.util.logging.FileHandler._FileHandler21971 = @__env.GetMethodIDNoThrow(global::java.util.logging.FileHandler.staticClass, "<init>", "(Ljava/lang/String;II)V");
		}
	}
}
