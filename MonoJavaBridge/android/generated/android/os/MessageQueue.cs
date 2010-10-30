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
			internal static global::MonoJavaBridge.MethodId _queueIdle9962;
			bool android.os.MessageQueue.IdleHandler.queueIdle()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.MessageQueue.IdleHandler_._queueIdle9962);
			}
			static IdleHandler_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.MessageQueue.IdleHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue$IdleHandler"));
				global::android.os.MessageQueue.IdleHandler_._queueIdle9962 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.IdleHandler_.staticClass, "queueIdle", "()Z");
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
			internal static global::MonoJavaBridge.MethodId _IdleHandlerDelegateWrapper9963;
			public IdleHandlerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.MessageQueue.IdleHandlerDelegateWrapper.staticClass, global::android.os.MessageQueue.IdleHandlerDelegateWrapper._IdleHandlerDelegateWrapper9963);
				Init(@__env, handle);
			}
			static IdleHandlerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.MessageQueue.IdleHandlerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue_IdleHandlerDelegateWrapper"));
				global::android.os.MessageQueue.IdleHandlerDelegateWrapper._IdleHandlerDelegateWrapper9963 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.IdleHandlerDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _addIdleHandler9964;
		public virtual void addIdleHandler(android.os.MessageQueue.IdleHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MessageQueue.staticClass, global::android.os.MessageQueue._addIdleHandler9964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addIdleHandler(global::android.os.MessageQueue.IdleHandlerDelegate arg0)
		{
			addIdleHandler((global::android.os.MessageQueue.IdleHandlerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeIdleHandler9965;
		public virtual void removeIdleHandler(android.os.MessageQueue.IdleHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.MessageQueue.staticClass, global::android.os.MessageQueue._removeIdleHandler9965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeIdleHandler(global::android.os.MessageQueue.IdleHandlerDelegate arg0)
		{
			removeIdleHandler((global::android.os.MessageQueue.IdleHandlerDelegateWrapper)arg0);
		}
		static MessageQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.MessageQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/MessageQueue"));
			global::android.os.MessageQueue._addIdleHandler9964 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.staticClass, "addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V");
			global::android.os.MessageQueue._removeIdleHandler9965 = @__env.GetMethodIDNoThrow(global::android.os.MessageQueue.staticClass, "removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
