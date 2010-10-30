namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Handler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Handler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.Handler.Callback_))]
		public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			bool handleMessage(android.os.Message arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.Handler.Callback))]
		internal sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _handleMessage9853;
			bool android.os.Handler.Callback.handleMessage(android.os.Message arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.Callback_.staticClass, "handleMessage", "(Landroid/os/Message;)Z", ref global::android.os.Handler.Callback_._handleMessage9853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Handler.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler$Callback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool CallbackDelegate(android.os.Message arg0);

		internal partial class CallbackDelegateWrapper : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _CallbackDelegateWrapper9854;
			public CallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Handler.CallbackDelegateWrapper._CallbackDelegateWrapper9854.native == global::System.IntPtr.Zero)
					global::android.os.Handler.CallbackDelegateWrapper._CallbackDelegateWrapper9854 = @__env.GetMethodIDNoThrow(global::android.os.Handler.CallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.CallbackDelegateWrapper.staticClass, global::android.os.Handler.CallbackDelegateWrapper._CallbackDelegateWrapper9854);
				Init(@__env, handle);
			}
			static CallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Handler.CallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler_CallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class CallbackDelegateWrapper
		{
			private CallbackDelegate myDelegate;
			public bool handleMessage(android.os.Message arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator CallbackDelegateWrapper(CallbackDelegate d)
			{
				global::android.os.Handler.CallbackDelegateWrapper ret = new global::android.os.Handler.CallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString9855;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Handler.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.Handler._toString9855) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump9856;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.os.Handler._dump9856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage9857;
		public virtual void handleMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.os.Handler._handleMessage9857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchMessage9858;
		public virtual void dispatchMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "dispatchMessage", "(Landroid/os/Message;)V", ref global::android.os.Handler._dispatchMessage9858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9859;
		public virtual global::android.os.Message obtainMessage(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;", ref global::android.os.Handler._obtainMessage9859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9860;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(III)Landroid/os/Message;", ref global::android.os.Handler._obtainMessage9860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9861;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2, java.lang.Object arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;", ref global::android.os.Handler._obtainMessage9861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9862;
		public virtual global::android.os.Message obtainMessage(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(I)Landroid/os/Message;", ref global::android.os.Handler._obtainMessage9862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9863;
		public virtual global::android.os.Message obtainMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "()Landroid/os/Message;", ref global::android.os.Handler._obtainMessage9863) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _post9864;
		public virtual bool post(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "post", "(Ljava/lang/Runnable;)Z", ref global::android.os.Handler._post9864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool post(global::java.lang.RunnableDelegate arg0)
		{
			return post((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _postAtTime9865;
		public virtual bool postAtTime(java.lang.Runnable arg0, java.lang.Object arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z", ref global::android.os.Handler._postAtTime9865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public bool postAtTime(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1, long arg2)
		{
			return postAtTime((global::java.lang.RunnableDelegateWrapper)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _postAtTime9866;
		public virtual bool postAtTime(java.lang.Runnable arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;J)Z", ref global::android.os.Handler._postAtTime9866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool postAtTime(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			return postAtTime((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _postDelayed9867;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z", ref global::android.os.Handler._postDelayed9867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool postDelayed(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			return postDelayed((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _postAtFrontOfQueue9868;
		public virtual bool postAtFrontOfQueue(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z", ref global::android.os.Handler._postAtFrontOfQueue9868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool postAtFrontOfQueue(global::java.lang.RunnableDelegate arg0)
		{
			return postAtFrontOfQueue((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks9869;
		public virtual void removeCallbacks(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)V", ref global::android.os.Handler._removeCallbacks9869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeCallbacks(global::java.lang.RunnableDelegate arg0)
		{
			removeCallbacks((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks9870;
		public virtual void removeCallbacks(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", ref global::android.os.Handler._removeCallbacks9870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void removeCallbacks(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			removeCallbacks((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _sendMessage9871;
		public virtual bool sendMessage(android.os.Message arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessage", "(Landroid/os/Message;)Z", ref global::android.os.Handler._sendMessage9871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessage9872;
		public virtual bool sendEmptyMessage(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendEmptyMessage", "(I)Z", ref global::android.os.Handler._sendEmptyMessage9872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessageDelayed9873;
		public virtual bool sendEmptyMessageDelayed(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendEmptyMessageDelayed", "(IJ)Z", ref global::android.os.Handler._sendEmptyMessageDelayed9873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessageAtTime9874;
		public virtual bool sendEmptyMessageAtTime(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendEmptyMessageAtTime", "(IJ)Z", ref global::android.os.Handler._sendEmptyMessageAtTime9874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageDelayed9875;
		public virtual bool sendMessageDelayed(android.os.Message arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessageDelayed", "(Landroid/os/Message;J)Z", ref global::android.os.Handler._sendMessageDelayed9875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageAtTime9876;
		public virtual bool sendMessageAtTime(android.os.Message arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessageAtTime", "(Landroid/os/Message;J)Z", ref global::android.os.Handler._sendMessageAtTime9876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageAtFrontOfQueue9877;
		public virtual bool sendMessageAtFrontOfQueue(android.os.Message arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z", ref global::android.os.Handler._sendMessageAtFrontOfQueue9877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMessages9878;
		public virtual void removeMessages(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeMessages", "(I)V", ref global::android.os.Handler._removeMessages9878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMessages9879;
		public virtual void removeMessages(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeMessages", "(ILjava/lang/Object;)V", ref global::android.os.Handler._removeMessages9879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacksAndMessages9880;
		public virtual void removeCallbacksAndMessages(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V", ref global::android.os.Handler._removeCallbacksAndMessages9880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasMessages9881;
		public virtual bool hasMessages(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "hasMessages", "(ILjava/lang/Object;)Z", ref global::android.os.Handler._hasMessages9881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasMessages9882;
		public virtual bool hasMessages(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "hasMessages", "(I)Z", ref global::android.os.Handler._hasMessages9882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Looper Looper
		{
			get
			{
				return getLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLooper9883;
		public virtual global::android.os.Looper getLooper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Handler.staticClass, "getLooper", "()Landroid/os/Looper;", ref global::android.os.Handler._getLooper9883) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _Handler9884;
		public Handler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._Handler9884.native == global::System.IntPtr.Zero)
				global::android.os.Handler._Handler9884 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9884);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler9885;
		public Handler(android.os.Handler.Callback arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._Handler9885.native == global::System.IntPtr.Zero)
				global::android.os.Handler._Handler9885 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Handler$Callback;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler9886;
		public Handler(android.os.Looper arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._Handler9886.native == global::System.IntPtr.Zero)
				global::android.os.Handler._Handler9886 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler9887;
		public Handler(android.os.Looper arg0, android.os.Handler.Callback arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._Handler9887.native == global::System.IntPtr.Zero)
				global::android.os.Handler._Handler9887 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Handler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Handler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
