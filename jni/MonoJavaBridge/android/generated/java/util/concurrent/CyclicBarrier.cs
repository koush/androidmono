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
		internal static global::MonoJavaBridge.MethodId _reset21272;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._reset21272);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._reset21272);
		}
		internal static global::MonoJavaBridge.MethodId _await21273;
		public virtual int await() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._await21273);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._await21273);
		}
		internal static global::MonoJavaBridge.MethodId _await21274;
		public virtual int await(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._await21274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._await21274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Parties
		{
			get
			{
				return getParties();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParties21275;
		public virtual int getParties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._getParties21275);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._getParties21275);
		}
		internal static global::MonoJavaBridge.MethodId _isBroken21276;
		public virtual bool isBroken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._isBroken21276);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._isBroken21276);
		}
		public new int NumberWaiting
		{
			get
			{
				return getNumberWaiting();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberWaiting21277;
		public virtual int getNumberWaiting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier._getNumberWaiting21277);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._getNumberWaiting21277);
		}
		internal static global::MonoJavaBridge.MethodId _CyclicBarrier21278;
		public CyclicBarrier(int arg0, java.lang.Runnable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._CyclicBarrier21278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CyclicBarrier21279;
		public CyclicBarrier(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CyclicBarrier.staticClass, global::java.util.concurrent.CyclicBarrier._CyclicBarrier21279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CyclicBarrier.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CyclicBarrier"));
			global::java.util.concurrent.CyclicBarrier._reset21272 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "reset", "()V");
			global::java.util.concurrent.CyclicBarrier._await21273 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "await", "()I");
			global::java.util.concurrent.CyclicBarrier._await21274 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)I");
			global::java.util.concurrent.CyclicBarrier._getParties21275 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "getParties", "()I");
			global::java.util.concurrent.CyclicBarrier._isBroken21276 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "isBroken", "()Z");
			global::java.util.concurrent.CyclicBarrier._getNumberWaiting21277 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "getNumberWaiting", "()I");
			global::java.util.concurrent.CyclicBarrier._CyclicBarrier21278 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(ILjava/lang/Runnable;)V");
			global::java.util.concurrent.CyclicBarrier._CyclicBarrier21279 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CyclicBarrier.staticClass, "<init>", "(I)V");
		}
	}
}
