namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Exchanger : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Exchanger()
		{
			InitJNI();
		}
		protected Exchanger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _exchange27254;
		public virtual global::java.lang.Object exchange(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Exchanger._exchange27254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Exchanger.staticClass, global::java.util.concurrent.Exchanger._exchange27254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _exchange27255;
		public virtual global::java.lang.Object exchange(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Exchanger._exchange27255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Exchanger.staticClass, global::java.util.concurrent.Exchanger._exchange27255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _Exchanger27256;
		public Exchanger() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.Exchanger.staticClass, global::java.util.concurrent.Exchanger._Exchanger27256);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Exchanger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Exchanger"));
			global::java.util.concurrent.Exchanger._exchange27254 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Exchanger.staticClass, "exchange", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.Exchanger._exchange27255 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Exchanger.staticClass, "exchange", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.Exchanger._Exchanger27256 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Exchanger.staticClass, "<init>", "()V");
		}
	}
}
