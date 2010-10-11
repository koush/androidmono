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
			internal static global::MonoJavaBridge.MethodId _onScale8980;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale8980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale8980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin8981;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin8981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin8981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd8982;
			 void android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd8982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd8982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$OnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale8980 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin8981 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd8982 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
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
			internal static global::MonoJavaBridge.MethodId _onScale8983;
			public virtual bool onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale8983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale8983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin8984;
			public virtual bool onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin8984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin8984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd8985;
			public virtual void onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd8985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd8985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnScaleGestureListener8986;
			public SimpleOnScaleGestureListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener8986);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$SimpleOnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale8983 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin8984 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd8985 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener8986 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime8987;
		public virtual long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getEventTime8987);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getEventTime8987);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent8988;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._onTouchEvent8988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._onTouchEvent8988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInProgress8989;
		public virtual bool isInProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._isInProgress8989);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._isInProgress8989);
		}
		internal static global::MonoJavaBridge.MethodId _getFocusX8990;
		public virtual float getFocusX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getFocusX8990);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusX8990);
		}
		internal static global::MonoJavaBridge.MethodId _getFocusY8991;
		public virtual float getFocusY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getFocusY8991);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusY8991);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentSpan8992;
		public virtual float getCurrentSpan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getCurrentSpan8992);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getCurrentSpan8992);
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSpan8993;
		public virtual float getPreviousSpan() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getPreviousSpan8993);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getPreviousSpan8993);
		}
		internal static global::MonoJavaBridge.MethodId _getScaleFactor8994;
		public virtual float getScaleFactor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getScaleFactor8994);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getScaleFactor8994);
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDelta8995;
		public virtual long getTimeDelta() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector._getTimeDelta8995);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getTimeDelta8995);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleGestureDetector8996;
		public ScaleGestureDetector(android.content.Context arg0, android.view.ScaleGestureDetector.OnScaleGestureListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._ScaleGestureDetector8996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ScaleGestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector"));
			global::android.view.ScaleGestureDetector._getEventTime8987 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getEventTime", "()J");
			global::android.view.ScaleGestureDetector._onTouchEvent8988 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ScaleGestureDetector._isInProgress8989 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "isInProgress", "()Z");
			global::android.view.ScaleGestureDetector._getFocusX8990 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusX", "()F");
			global::android.view.ScaleGestureDetector._getFocusY8991 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusY", "()F");
			global::android.view.ScaleGestureDetector._getCurrentSpan8992 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getCurrentSpan", "()F");
			global::android.view.ScaleGestureDetector._getPreviousSpan8993 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getPreviousSpan", "()F");
			global::android.view.ScaleGestureDetector._getScaleFactor8994 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getScaleFactor", "()F");
			global::android.view.ScaleGestureDetector._getTimeDelta8995 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getTimeDelta", "()J");
			global::android.view.ScaleGestureDetector._ScaleGestureDetector8996 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListener;)V");
		}
	}
}
