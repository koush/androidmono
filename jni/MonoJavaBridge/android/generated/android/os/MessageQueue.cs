namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MessageQueue : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageQueue()
		{
			InitJNI();
		}
		protected MessageQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.MessageQueue.IdleHandler_))]
		public interface IdleHandler  : global::MonoJavaBridge.IJavaObject 
		{
			bool queueIdle();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.MessageQueue.IdleHandler))]
		public sealed partial class IdleHandler_ : java.lang.Object, IdleHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static IdleHandler_()
			{
				InitJNI();
			}
			internal IdleHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _queueIdle9917;
			 bool android.os.MessageQueue.IdleHandler.queueIdle() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.MessageQueue.IdleHandler_._queueIdle9917);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.MessageQueue.IdleHandler_.staticClass, global::android.os.MessageQueue.IdleHandler_._queueIdle9917);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.MessageQueue.IdleHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue$IdleHandler"));
				global::android.os.MessageQueue.IdleHandler_._queueIdle9917 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.IdleHandler_.staticClass, "queueIdle", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _addIdleHandler9918;
		public virtual void addIdleHandler(android.os.MessageQueue.IdleHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MessageQueue._addIdleHandler9918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MessageQueue.staticClass, global::android.os.MessageQueue._addIdleHandler9918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeIdleHandler9919;
		public virtual void removeIdleHandler(android.os.MessageQueue.IdleHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.MessageQueue._removeIdleHandler9919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.MessageQueue.staticClass, global::android.os.MessageQueue._removeIdleHandler9919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.MessageQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue"));
			global::android.os.MessageQueue._addIdleHandler9918 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.staticClass, "addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V");
			global::android.os.MessageQueue._removeIdleHandler9919 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.staticClass, "removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V");
		}
	}
}
