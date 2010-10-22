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
		public partial interface OnDoubleTapListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed13962;
			 bool android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed13962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed13962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap13963;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap13963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap13963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent13964;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent13964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent13964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnDoubleTapListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnDoubleTapListener"));
				global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed13962 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap13963 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent13964 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.GestureDetector.OnGestureListener_))]
		public partial interface OnGestureListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onLongPress13965;
			 void android.view.GestureDetector.OnGestureListener.onLongPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onLongPress13965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onLongPress13965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp13966;
			 bool android.view.GestureDetector.OnGestureListener.onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp13966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp13966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll13967;
			 bool android.view.GestureDetector.OnGestureListener.onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onScroll13967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onScroll13967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling13968;
			 bool android.view.GestureDetector.OnGestureListener.onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onFling13968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onFling13968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress13969;
			 void android.view.GestureDetector.OnGestureListener.onShowPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onShowPress13969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onShowPress13969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown13970;
			 bool android.view.GestureDetector.OnGestureListener.onDown(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onDown13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onDown13970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnGestureListener"));
				global::android.view.GestureDetector.OnGestureListener_._onLongPress13965 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp13966 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnGestureListener_._onScroll13967 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onFling13968 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onShowPress13969 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onDown13970 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
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
			internal static global::MonoJavaBridge.MethodId _onLongPress13971;
			public virtual void onLongPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress13971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress13971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed13972;
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed13972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed13972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap13973;
			public virtual bool onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap13973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap13973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent13974;
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent13974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent13974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp13975;
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp13975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp13975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll13976;
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll13976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll13976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling13977;
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onFling13977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onFling13977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress13978;
			public virtual void onShowPress(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress13978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress13978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown13979;
			public virtual bool onDown(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDown13979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDown13979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnGestureListener13980;
			public SimpleOnGestureListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener13980);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$SimpleOnGestureListener"));
				global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress13971 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed13972 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap13973 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent13974 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp13975 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onScroll13976 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onFling13977 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress13978 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDown13979 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener13980 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent13981;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._onTouchEvent13981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._onTouchEvent13981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDoubleTapListener13982;
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setOnDoubleTapListener13982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setOnDoubleTapListener13982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsLongpressEnabled13983;
		public virtual void setIsLongpressEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setIsLongpressEnabled13983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setIsLongpressEnabled13983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongpressEnabled13984;
		public virtual bool isLongpressEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._isLongpressEnabled13984);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._isLongpressEnabled13984);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector13985;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector13985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector13986;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector13986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector13987;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector13987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector13988;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector13988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector13989;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector13989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.GestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector"));
			global::android.view.GestureDetector._onTouchEvent13981 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.GestureDetector._setOnDoubleTapListener13982 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");
			global::android.view.GestureDetector._setIsLongpressEnabled13983 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V");
			global::android.view.GestureDetector._isLongpressEnabled13984 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z");
			global::android.view.GestureDetector._GestureDetector13985 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector13986 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector13987 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector13988 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector13989 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;Z)V");
		}
	}
}
