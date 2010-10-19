namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScaleGestureDetector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScaleGestureDetector()
		{
			InitJNI();
		}
		protected ScaleGestureDetector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ScaleGestureDetector.OnScaleGestureListener_))]
		public interface OnScaleGestureListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onScale(android.view.ScaleGestureDetector arg0);
			bool onScaleBegin(android.view.ScaleGestureDetector arg0);
			void onScaleEnd(android.view.ScaleGestureDetector arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ScaleGestureDetector.OnScaleGestureListener))]
		public sealed partial class OnScaleGestureListener_ : java.lang.Object, OnScaleGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnScaleGestureListener_()
			{
				InitJNI();
			}
			internal OnScaleGestureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScale9526;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale9526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale9526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin9527;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin9527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin9527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd9528;
			 void android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd9528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd9528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$OnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale9526 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin9527 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd9528 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SimpleOnScaleGestureListener : java.lang.Object, OnScaleGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SimpleOnScaleGestureListener()
			{
				InitJNI();
			}
			protected SimpleOnScaleGestureListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScale9529;
			public virtual bool onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale9529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale9529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin9530;
			public virtual bool onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin9530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin9530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd9531;
			public virtual void onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd9531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd9531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnScaleGestureListener9532;
			public SimpleOnScaleGestureListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener9532);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$SimpleOnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale9529 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin9530 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd9531 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener9532 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "<init>", "()V");
			}
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime9533;
		public virtual long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getEventTime9533);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getEventTime9533);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent9534;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._onTouchEvent9534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._onTouchEvent9534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInProgress9535;
		public virtual bool isInProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._isInProgress9535);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._isInProgress9535);
		}
		public new float FocusX
		{
			get
			{
				return getFocusX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFocusX9536;
		public virtual float getFocusX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getFocusX9536);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusX9536);
		}
		public new float FocusY
		{
			get
			{
				return getFocusY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFocusY9537;
		public virtual float getFocusY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getFocusY9537);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusY9537);
		}
		public new float CurrentSpan
		{
			get
			{
				return getCurrentSpan();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentSpan9538;
		public virtual float getCurrentSpan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getCurrentSpan9538);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getCurrentSpan9538);
		}
		public new float PreviousSpan
		{
			get
			{
				return getPreviousSpan();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSpan9539;
		public virtual float getPreviousSpan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getPreviousSpan9539);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getPreviousSpan9539);
		}
		public new float ScaleFactor
		{
			get
			{
				return getScaleFactor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaleFactor9540;
		public virtual float getScaleFactor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getScaleFactor9540);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getScaleFactor9540);
		}
		public new long TimeDelta
		{
			get
			{
				return getTimeDelta();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDelta9541;
		public virtual long getTimeDelta() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getTimeDelta9541);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getTimeDelta9541);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleGestureDetector9542;
		public ScaleGestureDetector(android.content.Context arg0, android.view.ScaleGestureDetector.OnScaleGestureListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._ScaleGestureDetector9542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ScaleGestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector"));
			global::android.view.ScaleGestureDetector._getEventTime9533 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getEventTime", "()J");
			global::android.view.ScaleGestureDetector._onTouchEvent9534 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ScaleGestureDetector._isInProgress9535 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "isInProgress", "()Z");
			global::android.view.ScaleGestureDetector._getFocusX9536 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusX", "()F");
			global::android.view.ScaleGestureDetector._getFocusY9537 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusY", "()F");
			global::android.view.ScaleGestureDetector._getCurrentSpan9538 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getCurrentSpan", "()F");
			global::android.view.ScaleGestureDetector._getPreviousSpan9539 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getPreviousSpan", "()F");
			global::android.view.ScaleGestureDetector._getScaleFactor9540 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getScaleFactor", "()F");
			global::android.view.ScaleGestureDetector._getTimeDelta9541 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getTimeDelta", "()J");
			global::android.view.ScaleGestureDetector._ScaleGestureDetector9542 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListener;)V");
		}
	}
}
