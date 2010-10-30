namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MessageQueue : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MessageQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.MessageQueue.IdleHandler_))]
		public partial interface IdleHandler  : global::MonoJavaBridge.IJavaObject 
		{
			bool queueIdle();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.MessageQueue.IdleHandler))]
		internal sealed partial class IdleHandler_ : java.lang.Object, IdleHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal IdleHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.os.MessageQueue.IdleHandler.queueIdle()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.MessageQueue.IdleHandler_.staticClass, "queueIdle", "()Z", ref global::android.os.MessageQueue.IdleHandler_._m0);
			}
			static IdleHandler_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.MessageQueue.IdleHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue$IdleHandler"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool IdleHandlerDelegate();

		internal partial class IdleHandlerDelegateWrapper : java.lang.Object, IdleHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected IdleHandlerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public IdleHandlerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.MessageQueue.IdleHandlerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.os.MessageQueue.IdleHandlerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.IdleHandlerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.MessageQueue.IdleHandlerDelegateWrapper.staticClass, global::android.os.MessageQueue.IdleHandlerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static IdleHandlerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.MessageQueue.IdleHandlerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue_IdleHandlerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class IdleHandlerDelegateWrapper
		{
			private IdleHandlerDelegate myDelegate;
			public bool queueIdle()
			{
				return myDelegate();
			}
			public static implicit operator IdleHandlerDelegateWrapper(IdleHandlerDelegate d)
			{
				global::android.os.MessageQueue.IdleHandlerDelegateWrapper ret = new global::android.os.MessageQueue.IdleHandlerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void addIdleHandler(android.os.MessageQueue.IdleHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MessageQueue.staticClass, "addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", ref global::android.os.MessageQueue._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addIdleHandler(global::android.os.MessageQueue.IdleHandlerDelegate arg0)
		{
			addIdleHandler((global::android.os.MessageQueue.IdleHandlerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void removeIdleHandler(android.os.MessageQueue.IdleHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MessageQueue.staticClass, "removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", ref global::android.os.MessageQueue._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeIdleHandler(global::android.os.MessageQueue.IdleHandlerDelegate arg0)
		{
			removeIdleHandler((global::android.os.MessageQueue.IdleHandlerDelegateWrapper)arg0);
		}
		static MessageQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.MessageQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue"));
		}
		internal static void InitJNI()
		{
		}
	}
}
