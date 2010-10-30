namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CyclicBarrier : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CyclicBarrier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset27221;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "reset", "()V", ref global::java.util.concurrent.CyclicBarrier._reset27221);
		}
		internal static global::MonoJavaBridge.MethodId _await27222;
		public virtual int await()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "await", "()I", ref global::java.util.concurrent.CyclicBarrier._await27222);
		}
		internal static global::MonoJavaBridge.MethodId _await27223;
		public virtual int await(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)I", ref global::java.util.concurrent.CyclicBarrier._await27223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Parties
		{
			get
			{
				return getParties();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParties27224;
		public virtual int getParties()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "getParties", "()I", ref global::java.util.concurrent.CyclicBarrier._getParties27224);
		}
		internal static global::MonoJavaBridge.MethodId _isBroken27225;
		public virtual bool isBroken()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "isBroken", "()Z", ref global::java.util.concurrent.CyclicBarrier._isBroken27225);
		}
		public new int NumberWaiting
		{
			get
			{
				return getNumberWaiting();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberWaiting27226;
		public virtual int getNumberWaiting()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.CyclicBarrier.staticClass, "getNumberWaiting", "()I", ref global::java.util.concurrent.CyclicBarrier._getNumberWaiting27226);
		}
		internal static global::MonoJavaBridge.MethodId _CyclicBarrier27227;
		public CyclicBarrier(int arg0, java.lang.Runnable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CyclicBarrier._CyclicBarrier27227.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CyclicBarrier._CyclicBarrier27227 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(ILjava/lang/Runnable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._CyclicBarrier27227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CyclicBarrier27228;
		public CyclicBarrier(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CyclicBarrier._CyclicBarrier27228.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CyclicBarrier._CyclicBarrier27228 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._CyclicBarrier27228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CyclicBarrier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CyclicBarrier.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CyclicBarrier"));
		}
		internal static void InitJNI()
		{
		}
	}
}
