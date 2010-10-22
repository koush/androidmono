namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Handler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Handler()
		{
			InitJNI();
		}
		protected Handler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.Handler.Callback_))]
		public interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			bool handleMessage(android.os.Message arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.Handler.Callback))]
		public sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Callback_()
			{
				InitJNI();
			}
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _handleMessage9811;
			 bool android.os.Handler.Callback.handleMessage(android.os.Message arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler.Callback_._handleMessage9811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.Callback_.staticClass, global::android.os.Handler.Callback_._handleMessage9811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Handler.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler$Callback"));
				global::android.os.Handler.Callback_._handleMessage9811 = @__env.GetMethodIDNoThrow(global::android.os.Handler.Callback_.staticClass, "handleMessage", "(Landroid/os/Message;)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString9812;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._toString9812)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._toString9812)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump9813;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._dump9813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._dump9813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage9814;
		public virtual void handleMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._handleMessage9814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._handleMessage9814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchMessage9815;
		public virtual void dispatchMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._dispatchMessage9815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._dispatchMessage9815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9816;
		public virtual global::android.os.Message obtainMessage(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage9816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage9816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9817;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage9817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage9817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9818;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage9818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage9818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9819;
		public virtual global::android.os.Message obtainMessage(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage9819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage9819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage9820;
		public virtual global::android.os.Message obtainMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage9820)) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Message>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage9820)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _post9821;
		public virtual bool post(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._post9821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._post9821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postAtTime9822;
		public virtual bool postAtTime(java.lang.Runnable arg0, java.lang.Object arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postAtTime9822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime9822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _postAtTime9823;
		public virtual bool postAtTime(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postAtTime9823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime9823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postDelayed9824;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postDelayed9824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postDelayed9824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postAtFrontOfQueue9825;
		public virtual bool postAtFrontOfQueue(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postAtFrontOfQueue9825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postAtFrontOfQueue9825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks9826;
		public virtual void removeCallbacks(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeCallbacks9826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks9826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks9827;
		public virtual void removeCallbacks(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeCallbacks9827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks9827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessage9828;
		public virtual bool sendMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessage9828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessage9828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessage9829;
		public virtual bool sendEmptyMessage(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendEmptyMessage9829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessage9829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessageDelayed9830;
		public virtual bool sendEmptyMessageDelayed(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendEmptyMessageDelayed9830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageDelayed9830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessageAtTime9831;
		public virtual bool sendEmptyMessageAtTime(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendEmptyMessageAtTime9831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageAtTime9831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageDelayed9832;
		public virtual bool sendMessageDelayed(android.os.Message arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessageDelayed9832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageDelayed9832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageAtTime9833;
		public virtual bool sendMessageAtTime(android.os.Message arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessageAtTime9833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtTime9833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageAtFrontOfQueue9834;
		public virtual bool sendMessageAtFrontOfQueue(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessageAtFrontOfQueue9834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtFrontOfQueue9834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMessages9835;
		public virtual void removeMessages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeMessages9835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages9835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMessages9836;
		public virtual void removeMessages(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeMessages9836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages9836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacksAndMessages9837;
		public virtual void removeCallbacksAndMessages(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeCallbacksAndMessages9837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacksAndMessages9837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasMessages9838;
		public virtual bool hasMessages(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._hasMessages9838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages9838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasMessages9839;
		public virtual bool hasMessages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._hasMessages9839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages9839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Looper Looper
		{
			get
			{
				return getLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLooper9840;
		public virtual global::android.os.Looper getLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._getLooper9840)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._getLooper9840)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _Handler9841;
		public Handler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9841);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler9842;
		public Handler(android.os.Handler.Callback arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler9843;
		public Handler(android.os.Looper arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler9844;
		public Handler(android.os.Looper arg0, android.os.Handler.Callback arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler9844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Handler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler"));
			global::android.os.Handler._toString9812 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Handler._dump9813 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.os.Handler._handleMessage9814 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.os.Handler._dispatchMessage9815 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "dispatchMessage", "(Landroid/os/Message;)V");
			global::android.os.Handler._obtainMessage9816 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage9817 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(III)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage9818 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage9819 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(I)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage9820 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "()Landroid/os/Message;");
			global::android.os.Handler._post9821 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "post", "(Ljava/lang/Runnable;)Z");
			global::android.os.Handler._postAtTime9822 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z");
			global::android.os.Handler._postAtTime9823 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;J)Z");
			global::android.os.Handler._postDelayed9824 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			global::android.os.Handler._postAtFrontOfQueue9825 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z");
			global::android.os.Handler._removeCallbacks9826 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)V");
			global::android.os.Handler._removeCallbacks9827 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V");
			global::android.os.Handler._sendMessage9828 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessage", "(Landroid/os/Message;)Z");
			global::android.os.Handler._sendEmptyMessage9829 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendEmptyMessage", "(I)Z");
			global::android.os.Handler._sendEmptyMessageDelayed9830 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendEmptyMessageDelayed", "(IJ)Z");
			global::android.os.Handler._sendEmptyMessageAtTime9831 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendEmptyMessageAtTime", "(IJ)Z");
			global::android.os.Handler._sendMessageDelayed9832 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessageDelayed", "(Landroid/os/Message;J)Z");
			global::android.os.Handler._sendMessageAtTime9833 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessageAtTime", "(Landroid/os/Message;J)Z");
			global::android.os.Handler._sendMessageAtFrontOfQueue9834 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z");
			global::android.os.Handler._removeMessages9835 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeMessages", "(I)V");
			global::android.os.Handler._removeMessages9836 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeMessages", "(ILjava/lang/Object;)V");
			global::android.os.Handler._removeCallbacksAndMessages9837 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V");
			global::android.os.Handler._hasMessages9838 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "hasMessages", "(ILjava/lang/Object;)Z");
			global::android.os.Handler._hasMessages9839 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "hasMessages", "(I)Z");
			global::android.os.Handler._getLooper9840 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "getLooper", "()Landroid/os/Looper;");
			global::android.os.Handler._Handler9841 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "()V");
			global::android.os.Handler._Handler9842 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Handler$Callback;)V");
			global::android.os.Handler._Handler9843 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;)V");
			global::android.os.Handler._Handler9844 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V");
		}
	}
}
