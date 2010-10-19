namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureDetector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureDetector()
		{
			InitJNI();
		}
		protected GestureDetector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.GestureDetector.OnDoubleTapListener_))]
		public interface OnDoubleTapListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onSingleTapConfirmed(android.view.MotionEvent arg0);
			bool onDoubleTap(android.view.MotionEvent arg0);
			bool onDoubleTapEvent(android.view.MotionEvent arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.GestureDetector.OnDoubleTapListener))]
		public sealed partial class OnDoubleTapListener_ : java.lang.Object, OnDoubleTapListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnDoubleTapListener_()
			{
				InitJNI();
			}
			internal OnDoubleTapListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed9274;
			 bool android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed9274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed9274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap9275;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap9275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap9275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent9276;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent9276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent9276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnDoubleTapListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnDoubleTapListener"));
				global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed9274 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap9275 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent9276 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.GestureDetector.OnGestureListener_))]
		public interface OnGestureListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onLongPress(android.view.MotionEvent arg0);
			bool onSingleTapUp(android.view.MotionEvent arg0);
			bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3);
			bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3);
			void onShowPress(android.view.MotionEvent arg0);
			bool onDown(android.view.MotionEvent arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.GestureDetector.OnGestureListener))]
		public sealed partial class OnGestureListener_ : java.lang.Object, OnGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGestureListener_()
			{
				InitJNI();
			}
			internal OnGestureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLongPress9277;
			 void android.view.GestureDetector.OnGestureListener.onLongPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onLongPress9277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onLongPress9277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp9278;
			 bool android.view.GestureDetector.OnGestureListener.onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp9278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp9278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll9279;
			 bool android.view.GestureDetector.OnGestureListener.onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onScroll9279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onScroll9279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling9280;
			 bool android.view.GestureDetector.OnGestureListener.onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onFling9280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onFling9280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress9281;
			 void android.view.GestureDetector.OnGestureListener.onShowPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onShowPress9281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onShowPress9281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown9282;
			 bool android.view.GestureDetector.OnGestureListener.onDown(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onDown9282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onDown9282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnGestureListener"));
				global::android.view.GestureDetector.OnGestureListener_._onLongPress9277 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp9278 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnGestureListener_._onScroll9279 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onFling9280 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onShowPress9281 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onDown9282 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SimpleOnGestureListener : java.lang.Object, OnGestureListener, OnDoubleTapListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SimpleOnGestureListener()
			{
				InitJNI();
			}
			protected SimpleOnGestureListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLongPress9283;
			public virtual void onLongPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress9283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress9283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed9284;
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed9284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed9284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap9285;
			public virtual bool onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap9285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap9285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent9286;
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent9286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent9286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp9287;
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp9287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp9287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll9288;
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll9288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll9288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling9289;
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onFling9289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onFling9289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress9290;
			public virtual void onShowPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress9290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress9290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown9291;
			public virtual bool onDown(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDown9291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDown9291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnGestureListener9292;
			public SimpleOnGestureListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener9292);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$SimpleOnGestureListener"));
				global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress9283 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed9284 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap9285 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent9286 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp9287 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onScroll9288 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onFling9289 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress9290 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDown9291 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener9292 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent9293;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._onTouchEvent9293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._onTouchEvent9293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDoubleTapListener9294;
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setOnDoubleTapListener9294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setOnDoubleTapListener9294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsLongpressEnabled9295;
		public virtual void setIsLongpressEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setIsLongpressEnabled9295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setIsLongpressEnabled9295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongpressEnabled9296;
		public virtual bool isLongpressEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._isLongpressEnabled9296);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._isLongpressEnabled9296);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector9297;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector9297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector9298;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector9298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector9299;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector9299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector9300;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector9300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector9301;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector9301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.GestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector"));
			global::android.view.GestureDetector._onTouchEvent9293 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.GestureDetector._setOnDoubleTapListener9294 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");
			global::android.view.GestureDetector._setIsLongpressEnabled9295 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V");
			global::android.view.GestureDetector._isLongpressEnabled9296 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z");
			global::android.view.GestureDetector._GestureDetector9297 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector9298 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector9299 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector9300 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector9301 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;Z)V");
		}
	}
}
