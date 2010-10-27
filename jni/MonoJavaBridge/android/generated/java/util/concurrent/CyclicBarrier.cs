namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CyclicBarrier : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CyclicBarrier()
		{
			InitJNI();
		}
		protected CyclicBarrier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset27220;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._reset27220);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._reset27220);
		}
		internal static global::MonoJavaBridge.MethodId _await27221;
		public virtual int await()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._await27221);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._await27221);
		}
		internal static global::MonoJavaBridge.MethodId _await27222;
		public virtual int await(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._await27222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._await27222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Parties
		{
			get
			{
				return getParties();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParties27223;
		public virtual int getParties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._getParties27223);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._getParties27223);
		}
		internal static global::MonoJavaBridge.MethodId _isBroken27224;
		public virtual bool isBroken()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._isBroken27224);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._isBroken27224);
		}
		public new int NumberWaiting
		{
			get
			{
				return getNumberWaiting();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberWaiting27225;
		public virtual int getNumberWaiting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._getNumberWaiting27225);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._getNumberWaiting27225);
		}
		internal static global::MonoJavaBridge.MethodId _CyclicBarrier27226;
		public CyclicBarrier(int arg0, java.lang.Runnable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._CyclicBarrier27226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CyclicBarrier27227;
		public CyclicBarrier(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._CyclicBarrier27227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CyclicBarrier.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CyclicBarrier"));
			global::java.util.concurrent.CyclicBarrier._reset27220 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "reset", "()V");
			global::java.util.concurrent.CyclicBarrier._await27221 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "await", "()I");
			global::java.util.concurrent.CyclicBarrier._await27222 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)I");
			global::java.util.concurrent.CyclicBarrier._getParties27223 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "getParties", "()I");
			global::java.util.concurrent.CyclicBarrier._isBroken27224 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "isBroken", "()Z");
			global::java.util.concurrent.CyclicBarrier._getNumberWaiting27225 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "getNumberWaiting", "()I");
			global::java.util.concurrent.CyclicBarrier._CyclicBarrier27226 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(ILjava/lang/Runnable;)V");
			global::java.util.concurrent.CyclicBarrier._CyclicBarrier27227 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(I)V");
		}
	}
}
