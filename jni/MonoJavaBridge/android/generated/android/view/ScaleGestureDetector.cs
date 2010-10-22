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
		public partial interface OnScaleGestureListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onScale14397;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale14397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale14397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin14398;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin14398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin14398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd14399;
			 void android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd14399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd14399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$OnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale14397 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin14398 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd14399 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
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
			internal static global::MonoJavaBridge.MethodId _onScale14400;
			public virtual bool onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale14400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale14400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin14401;
			public virtual bool onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin14401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin14401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd14402;
			public virtual void onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd14402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd14402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnScaleGestureListener14403;
			public SimpleOnScaleGestureListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener14403);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$SimpleOnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale14400 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin14401 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd14402 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener14403 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "<init>", "()V");
			}
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime14404;
		public virtual long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getEventTime14404);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getEventTime14404);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent14405;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._onTouchEvent14405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._onTouchEvent14405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInProgress14406;
		public virtual bool isInProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._isInProgress14406);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._isInProgress14406);
		}
		public new float FocusX
		{
			get
			{
				return getFocusX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFocusX14407;
		public virtual float getFocusX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getFocusX14407);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusX14407);
		}
		public new float FocusY
		{
			get
			{
				return getFocusY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFocusY14408;
		public virtual float getFocusY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getFocusY14408);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusY14408);
		}
		public new float CurrentSpan
		{
			get
			{
				return getCurrentSpan();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentSpan14409;
		public virtual float getCurrentSpan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getCurrentSpan14409);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getCurrentSpan14409);
		}
		public new float PreviousSpan
		{
			get
			{
				return getPreviousSpan();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSpan14410;
		public virtual float getPreviousSpan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getPreviousSpan14410);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getPreviousSpan14410);
		}
		public new float ScaleFactor
		{
			get
			{
				return getScaleFactor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaleFactor14411;
		public virtual float getScaleFactor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getScaleFactor14411);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getScaleFactor14411);
		}
		public new long TimeDelta
		{
			get
			{
				return getTimeDelta();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDelta14412;
		public virtual long getTimeDelta() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getTimeDelta14412);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getTimeDelta14412);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleGestureDetector14413;
		public ScaleGestureDetector(android.content.Context arg0, android.view.ScaleGestureDetector.OnScaleGestureListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._ScaleGestureDetector14413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ScaleGestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector"));
			global::android.view.ScaleGestureDetector._getEventTime14404 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getEventTime", "()J");
			global::android.view.ScaleGestureDetector._onTouchEvent14405 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ScaleGestureDetector._isInProgress14406 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "isInProgress", "()Z");
			global::android.view.ScaleGestureDetector._getFocusX14407 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusX", "()F");
			global::android.view.ScaleGestureDetector._getFocusY14408 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusY", "()F");
			global::android.view.ScaleGestureDetector._getCurrentSpan14409 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getCurrentSpan", "()F");
			global::android.view.ScaleGestureDetector._getPreviousSpan14410 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getPreviousSpan", "()F");
			global::android.view.ScaleGestureDetector._getScaleFactor14411 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getScaleFactor", "()F");
			global::android.view.ScaleGestureDetector._getTimeDelta14412 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getTimeDelta", "()J");
			global::android.view.ScaleGestureDetector._ScaleGestureDetector14413 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListener;)V");
		}
	}
}
