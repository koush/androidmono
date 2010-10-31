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
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.os.Handler.Callback.handleMessage(android.os.Message arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.Callback_.staticClass, "handleMessage", "(Landroid/os/Message;)Z", ref global::android.os.Handler.Callback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Handler.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler$Callback"));
			}
		}

		public delegate bool CallbackDelegate(android.os.Message arg0);

		internal partial class CallbackDelegateWrapper : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public CallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Handler.CallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.os.Handler.CallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.os.Handler.CallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.CallbackDelegateWrapper.staticClass, global::android.os.Handler.CallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static CallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Handler.CallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler_CallbackDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Handler.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.Handler._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.os.Handler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void handleMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.os.Handler._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void dispatchMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "dispatchMessage", "(Landroid/os/Message;)V", ref global::android.os.Handler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.os.Message obtainMessage(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;", ref global::android.os.Handler._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(III)Landroid/os/Message;", ref global::android.os.Handler._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2, java.lang.Object arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;", ref global::android.os.Handler._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.os.Message obtainMessage(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "(I)Landroid/os/Message;", ref global::android.os.Handler._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.os.Message obtainMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Message>(this, global::android.os.Handler.staticClass, "obtainMessage", "()Landroid/os/Message;", ref global::android.os.Handler._m8) as android.os.Message;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool post(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "post", "(Ljava/lang/Runnable;)Z", ref global::android.os.Handler._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool post(global::java.lang.RunnableDelegate arg0)
		{
			return post((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool postAtTime(java.lang.Runnable arg0, java.lang.Object arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z", ref global::android.os.Handler._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public bool postAtTime(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1, long arg2)
		{
			return postAtTime((global::java.lang.RunnableDelegateWrapper)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool postAtTime(java.lang.Runnable arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;J)Z", ref global::android.os.Handler._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool postAtTime(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			return postAtTime((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z", ref global::android.os.Handler._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool postDelayed(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			return postDelayed((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool postAtFrontOfQueue(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z", ref global::android.os.Handler._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool postAtFrontOfQueue(global::java.lang.RunnableDelegate arg0)
		{
			return postAtFrontOfQueue((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void removeCallbacks(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)V", ref global::android.os.Handler._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeCallbacks(global::java.lang.RunnableDelegate arg0)
		{
			removeCallbacks((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void removeCallbacks(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V", ref global::android.os.Handler._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void removeCallbacks(global::java.lang.RunnableDelegate arg0, java.lang.Object arg1)
		{
			removeCallbacks((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool sendMessage(android.os.Message arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessage", "(Landroid/os/Message;)Z", ref global::android.os.Handler._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool sendEmptyMessage(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendEmptyMessage", "(I)Z", ref global::android.os.Handler._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool sendEmptyMessageDelayed(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendEmptyMessageDelayed", "(IJ)Z", ref global::android.os.Handler._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool sendEmptyMessageAtTime(int arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendEmptyMessageAtTime", "(IJ)Z", ref global::android.os.Handler._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool sendMessageDelayed(android.os.Message arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessageDelayed", "(Landroid/os/Message;J)Z", ref global::android.os.Handler._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool sendMessageAtTime(android.os.Message arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessageAtTime", "(Landroid/os/Message;J)Z", ref global::android.os.Handler._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool sendMessageAtFrontOfQueue(android.os.Message arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z", ref global::android.os.Handler._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void removeMessages(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeMessages", "(I)V", ref global::android.os.Handler._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void removeMessages(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeMessages", "(ILjava/lang/Object;)V", ref global::android.os.Handler._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void removeCallbacksAndMessages(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Handler.staticClass, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V", ref global::android.os.Handler._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool hasMessages(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "hasMessages", "(ILjava/lang/Object;)Z", ref global::android.os.Handler._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool hasMessages(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Handler.staticClass, "hasMessages", "(I)Z", ref global::android.os.Handler._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Looper Looper
		{
			get
			{
				return getLooper();
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::android.os.Looper getLooper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Handler.staticClass, "getLooper", "()Landroid/os/Looper;", ref global::android.os.Handler._m28) as android.os.Looper;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public Handler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._m29.native == global::System.IntPtr.Zero)
				global::android.os.Handler._m29 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._m29);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public Handler(android.os.Handler.Callback arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._m30.native == global::System.IntPtr.Zero)
				global::android.os.Handler._m30 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Handler$Callback;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public Handler(android.os.Looper arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._m31.native == global::System.IntPtr.Zero)
				global::android.os.Handler._m31 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public Handler(android.os.Looper arg0, android.os.Handler.Callback arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Handler._m32.native == global::System.IntPtr.Zero)
				global::android.os.Handler._m32 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Handler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Handler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler"));
		}
	}
}
