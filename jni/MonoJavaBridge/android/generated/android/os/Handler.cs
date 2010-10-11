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
			internal static global::MonoJavaBridge.MethodId _handleMessage6420;
			 bool android.os.Handler.Callback.handleMessage(android.os.Message arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler.Callback_._handleMessage6420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.Callback_.staticClass, global::android.os.Handler.Callback_._handleMessage6420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Handler.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler$Callback"));
				global::android.os.Handler.Callback_._handleMessage6420 = @__env.GetMethodIDNoThrow(global::android.os.Handler.Callback_.staticClass, "handleMessage", "(Landroid/os/Message;)Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString6421;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._toString6421)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._toString6421)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump6422;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._dump6422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._dump6422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage6423;
		public virtual void handleMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._handleMessage6423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._handleMessage6423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchMessage6424;
		public virtual void dispatchMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._dispatchMessage6424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._dispatchMessage6424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage6425;
		public virtual global::android.os.Message obtainMessage(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage6425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage6426;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage6426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage6427;
		public virtual global::android.os.Message obtainMessage(int arg0, int arg1, int arg2, java.lang.Object arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage6427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage6428;
		public virtual global::android.os.Message obtainMessage(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage6428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _obtainMessage6429;
		public virtual global::android.os.Message obtainMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._obtainMessage6429)) as android.os.Message;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._obtainMessage6429)) as android.os.Message;
		}
		internal static global::MonoJavaBridge.MethodId _post6430;
		public virtual bool post(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._post6430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._post6430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postAtTime6431;
		public virtual bool postAtTime(java.lang.Runnable arg0, java.lang.Object arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postAtTime6431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime6431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _postAtTime6432;
		public virtual bool postAtTime(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postAtTime6432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postAtTime6432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postDelayed6433;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postDelayed6433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postDelayed6433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _postAtFrontOfQueue6434;
		public virtual bool postAtFrontOfQueue(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._postAtFrontOfQueue6434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._postAtFrontOfQueue6434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks6435;
		public virtual void removeCallbacks(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeCallbacks6435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks6435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacks6436;
		public virtual void removeCallbacks(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeCallbacks6436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacks6436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessage6437;
		public virtual bool sendMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessage6437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessage6437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessage6438;
		public virtual bool sendEmptyMessage(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendEmptyMessage6438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessage6438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessageDelayed6439;
		public virtual bool sendEmptyMessageDelayed(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendEmptyMessageDelayed6439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageDelayed6439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendEmptyMessageAtTime6440;
		public virtual bool sendEmptyMessageAtTime(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendEmptyMessageAtTime6440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendEmptyMessageAtTime6440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageDelayed6441;
		public virtual bool sendMessageDelayed(android.os.Message arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessageDelayed6441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageDelayed6441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageAtTime6442;
		public virtual bool sendMessageAtTime(android.os.Message arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessageAtTime6442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtTime6442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendMessageAtFrontOfQueue6443;
		public virtual bool sendMessageAtFrontOfQueue(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._sendMessageAtFrontOfQueue6443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._sendMessageAtFrontOfQueue6443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMessages6444;
		public virtual void removeMessages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeMessages6444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages6444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMessages6445;
		public virtual void removeMessages(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeMessages6445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeMessages6445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeCallbacksAndMessages6446;
		public virtual void removeCallbacksAndMessages(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Handler._removeCallbacksAndMessages6446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._removeCallbacksAndMessages6446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasMessages6447;
		public virtual bool hasMessages(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._hasMessages6447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages6447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasMessages6448;
		public virtual bool hasMessages(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Handler._hasMessages6448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._hasMessages6448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLooper6449;
		public virtual global::android.os.Looper getLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Handler._getLooper6449)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Handler.staticClass, global::android.os.Handler._getLooper6449)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _Handler6450;
		public Handler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6450);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler6451;
		public Handler(android.os.Handler.Callback arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler6452;
		public Handler(android.os.Looper arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Handler6453;
		public Handler(android.os.Looper arg0, android.os.Handler.Callback arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Handler.staticClass, global::android.os.Handler._Handler6453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Handler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Handler"));
			global::android.os.Handler._toString6421 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Handler._dump6422 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.os.Handler._handleMessage6423 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.os.Handler._dispatchMessage6424 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "dispatchMessage", "(Landroid/os/Message;)V");
			global::android.os.Handler._obtainMessage6425 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(ILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6426 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(III)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6427 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(IIILjava/lang/Object;)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6428 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "(I)Landroid/os/Message;");
			global::android.os.Handler._obtainMessage6429 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "obtainMessage", "()Landroid/os/Message;");
			global::android.os.Handler._post6430 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "post", "(Ljava/lang/Runnable;)Z");
			global::android.os.Handler._postAtTime6431 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;Ljava/lang/Object;J)Z");
			global::android.os.Handler._postAtTime6432 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postAtTime", "(Ljava/lang/Runnable;J)Z");
			global::android.os.Handler._postDelayed6433 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z");
			global::android.os.Handler._postAtFrontOfQueue6434 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "postAtFrontOfQueue", "(Ljava/lang/Runnable;)Z");
			global::android.os.Handler._removeCallbacks6435 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)V");
			global::android.os.Handler._removeCallbacks6436 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;Ljava/lang/Object;)V");
			global::android.os.Handler._sendMessage6437 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessage", "(Landroid/os/Message;)Z");
			global::android.os.Handler._sendEmptyMessage6438 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendEmptyMessage", "(I)Z");
			global::android.os.Handler._sendEmptyMessageDelayed6439 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendEmptyMessageDelayed", "(IJ)Z");
			global::android.os.Handler._sendEmptyMessageAtTime6440 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendEmptyMessageAtTime", "(IJ)Z");
			global::android.os.Handler._sendMessageDelayed6441 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessageDelayed", "(Landroid/os/Message;J)Z");
			global::android.os.Handler._sendMessageAtTime6442 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessageAtTime", "(Landroid/os/Message;J)Z");
			global::android.os.Handler._sendMessageAtFrontOfQueue6443 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "sendMessageAtFrontOfQueue", "(Landroid/os/Message;)Z");
			global::android.os.Handler._removeMessages6444 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeMessages", "(I)V");
			global::android.os.Handler._removeMessages6445 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeMessages", "(ILjava/lang/Object;)V");
			global::android.os.Handler._removeCallbacksAndMessages6446 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "removeCallbacksAndMessages", "(Ljava/lang/Object;)V");
			global::android.os.Handler._hasMessages6447 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "hasMessages", "(ILjava/lang/Object;)Z");
			global::android.os.Handler._hasMessages6448 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "hasMessages", "(I)Z");
			global::android.os.Handler._getLooper6449 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "getLooper", "()Landroid/os/Looper;");
			global::android.os.Handler._Handler6450 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "()V");
			global::android.os.Handler._Handler6451 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Handler$Callback;)V");
			global::android.os.Handler._Handler6452 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;)V");
			global::android.os.Handler._Handler6453 = @__env.GetMethodIDNoThrow(global::android.os.Handler.staticClass, "<init>", "(Landroid/os/Looper;Landroid/os/Handler$Callback;)V");
		}
	}
}
