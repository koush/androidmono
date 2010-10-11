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
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed8728;
			 bool android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed8728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed8728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap8729;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap8729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap8729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent8730;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent8730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent8730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnDoubleTapListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnDoubleTapListener"));
				global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed8728 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap8729 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent8730 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
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
			internal static global::MonoJavaBridge.MethodId _onLongPress8731;
			 void android.view.GestureDetector.OnGestureListener.onLongPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onLongPress8731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onLongPress8731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp8732;
			 bool android.view.GestureDetector.OnGestureListener.onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp8732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp8732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll8733;
			 bool android.view.GestureDetector.OnGestureListener.onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onScroll8733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onScroll8733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling8734;
			 bool android.view.GestureDetector.OnGestureListener.onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onFling8734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onFling8734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress8735;
			 void android.view.GestureDetector.OnGestureListener.onShowPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onShowPress8735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onShowPress8735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown8736;
			 bool android.view.GestureDetector.OnGestureListener.onDown(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onDown8736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onDown8736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnGestureListener"));
				global::android.view.GestureDetector.OnGestureListener_._onLongPress8731 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp8732 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnGestureListener_._onScroll8733 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onFling8734 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onShowPress8735 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onDown8736 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
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
			internal static global::MonoJavaBridge.MethodId _onLongPress8737;
			public virtual void onLongPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress8737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress8737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed8738;
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed8738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed8738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap8739;
			public virtual bool onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap8739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap8739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent8740;
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent8740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent8740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp8741;
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp8741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp8741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll8742;
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll8742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll8742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling8743;
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onFling8743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onFling8743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress8744;
			public virtual void onShowPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress8744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress8744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown8745;
			public virtual bool onDown(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDown8745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDown8745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnGestureListener8746;
			public SimpleOnGestureListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener8746);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$SimpleOnGestureListener"));
				global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress8737 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed8738 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap8739 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent8740 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp8741 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onScroll8742 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onFling8743 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress8744 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDown8745 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener8746 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent8747;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._onTouchEvent8747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._onTouchEvent8747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDoubleTapListener8748;
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setOnDoubleTapListener8748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setOnDoubleTapListener8748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsLongpressEnabled8749;
		public virtual void setIsLongpressEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setIsLongpressEnabled8749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setIsLongpressEnabled8749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongpressEnabled8750;
		public virtual bool isLongpressEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._isLongpressEnabled8750);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._isLongpressEnabled8750);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector8751;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector8752;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector8753;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector8754;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector8755;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.GestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector"));
			global::android.view.GestureDetector._onTouchEvent8747 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.GestureDetector._setOnDoubleTapListener8748 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");
			global::android.view.GestureDetector._setIsLongpressEnabled8749 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V");
			global::android.view.GestureDetector._isLongpressEnabled8750 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z");
			global::android.view.GestureDetector._GestureDetector8751 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector8752 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector8753 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector8754 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector8755 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;Z)V");
		}
	}
}
