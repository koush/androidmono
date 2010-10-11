namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureOverlayView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureOverlayView()
		{
			InitJNI();
		}
		protected GestureOverlayView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGestureListener_))]
		public interface OnGestureListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGestureListener))]
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
			internal static global::MonoJavaBridge.MethodId _onGestureStarted2973;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureStarted2973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureStarted2973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGesture2974;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGesture2974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGesture2974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGestureEnded2975;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureEnded2975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureEnded2975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGestureCancelled2976;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureCancelled2976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureCancelled2976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGestureListener"));
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureStarted2973 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureStarted", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGesture2974 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGesture", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureEnded2975 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureEnded", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureCancelled2976 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureCancelled", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGesturePerformedListener_))]
		public interface OnGesturePerformedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGesturePerformedListener))]
		public sealed partial class OnGesturePerformedListener_ : java.lang.Object, OnGesturePerformedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGesturePerformedListener_()
			{
				InitJNI();
			}
			internal OnGesturePerformedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGesturePerformed2977;
			 void android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._onGesturePerformed2977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._onGesturePerformed2977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturePerformedListener"));
				global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._onGesturePerformed2977 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass, "onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGesturingListener_))]
		public interface OnGesturingListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGesturingStarted(android.gesture.GestureOverlayView arg0);
			void onGesturingEnded(android.gesture.GestureOverlayView arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGesturingListener))]
		public sealed partial class OnGesturingListener_ : java.lang.Object, OnGesturingListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGesturingListener_()
			{
				InitJNI();
			}
			internal OnGesturingListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGesturingStarted2978;
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted(android.gesture.GestureOverlayView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingStarted2978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingStarted2978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onGesturingEnded2979;
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded(android.gesture.GestureOverlayView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingEnded2979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingEnded2979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturingListener"));
				global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingStarted2978 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingStarted", "(Landroid/gesture/GestureOverlayView;)V");
				global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingEnded2979 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingEnded", "(Landroid/gesture/GestureOverlayView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear2980;
		public virtual void clear(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._clear2980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._clear2980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw2981;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._draw2981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._draw2981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow2982;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._onDetachedFromWindow2982);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._onDetachedFromWindow2982);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent2983;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._dispatchTouchEvent2983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._dispatchTouchEvent2983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation2984;
		public virtual void setOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setOrientation2984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setOrientation2984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOrientation2985;
		public virtual int getOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getOrientation2985);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getOrientation2985);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentStroke2986;
		public virtual global::java.util.ArrayList getCurrentStroke() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getCurrentStroke2986)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getCurrentStroke2986)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _setGestureColor2987;
		public virtual void setGestureColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureColor2987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureColor2987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUncertainGestureColor2988;
		public virtual void setUncertainGestureColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setUncertainGestureColor2988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setUncertainGestureColor2988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUncertainGestureColor2989;
		public virtual int getUncertainGestureColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getUncertainGestureColor2989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getUncertainGestureColor2989);
		}
		internal static global::MonoJavaBridge.MethodId _getGestureColor2990;
		public virtual int getGestureColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureColor2990);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureColor2990);
		}
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeWidth2991;
		public virtual float getGestureStrokeWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeWidth2991);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeWidth2991);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeWidth2992;
		public virtual void setGestureStrokeWidth(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeWidth2992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeWidth2992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeType2993;
		public virtual int getGestureStrokeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeType2993);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeType2993);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeType2994;
		public virtual void setGestureStrokeType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeType2994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeType2994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeLengthThreshold2995;
		public virtual float getGestureStrokeLengthThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2995);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2995);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeLengthThreshold2996;
		public virtual void setGestureStrokeLengthThreshold(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeSquarenessTreshold2997;
		public virtual float getGestureStrokeSquarenessTreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2997);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2997);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeSquarenessTreshold2998;
		public virtual void setGestureStrokeSquarenessTreshold(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeAngleThreshold2999;
		public virtual float getGestureStrokeAngleThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2999);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2999);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeAngleThreshold3000;
		public virtual void setGestureStrokeAngleThreshold(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold3000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold3000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEventsInterceptionEnabled3001;
		public virtual bool isEventsInterceptionEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled3001);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled3001);
		}
		internal static global::MonoJavaBridge.MethodId _setEventsInterceptionEnabled3002;
		public virtual void setEventsInterceptionEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled3002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled3002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFadeEnabled3003;
		public virtual bool isFadeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isFadeEnabled3003);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isFadeEnabled3003);
		}
		internal static global::MonoJavaBridge.MethodId _setFadeEnabled3004;
		public virtual void setFadeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setFadeEnabled3004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setFadeEnabled3004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGesture3005;
		public virtual global::android.gesture.Gesture getGesture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGesture3005)) as android.gesture.Gesture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesture3005)) as android.gesture.Gesture;
		}
		internal static global::MonoJavaBridge.MethodId _setGesture3006;
		public virtual void setGesture(android.gesture.Gesture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGesture3006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGesture3006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGesturePath3007;
		public virtual global::android.graphics.Path getGesturePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGesturePath3007)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesturePath3007)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _getGesturePath3008;
		public virtual global::android.graphics.Path getGesturePath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGesturePath3008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesturePath3008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _isGestureVisible3009;
		public virtual bool isGestureVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isGestureVisible3009);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isGestureVisible3009);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureVisible3010;
		public virtual void setGestureVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureVisible3010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureVisible3010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFadeOffset3011;
		public virtual long getFadeOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getFadeOffset3011);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getFadeOffset3011);
		}
		internal static global::MonoJavaBridge.MethodId _setFadeOffset3012;
		public virtual void setFadeOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setFadeOffset3012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setFadeOffset3012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnGestureListener3013;
		public virtual void addOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._addOnGestureListener3013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGestureListener3013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGestureListener3014;
		public virtual void removeOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeOnGestureListener3014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGestureListener3014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGestureListeners3015;
		public virtual void removeAllOnGestureListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeAllOnGestureListeners3015);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGestureListeners3015);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGesturePerformedListener3016;
		public virtual void addOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._addOnGesturePerformedListener3016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGesturePerformedListener3016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGesturePerformedListener3017;
		public virtual void removeOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener3017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener3017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGesturePerformedListeners3018;
		public virtual void removeAllOnGesturePerformedListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners3018);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners3018);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGesturingListener3019;
		public virtual void addOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._addOnGesturingListener3019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGesturingListener3019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGesturingListener3020;
		public virtual void removeOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeOnGesturingListener3020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGesturingListener3020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGesturingListeners3021;
		public virtual void removeAllOnGesturingListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners3021);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners3021);
		}
		internal static global::MonoJavaBridge.MethodId _isGesturing3022;
		public virtual bool isGesturing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isGesturing3022);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isGesturing3022);
		}
		internal static global::MonoJavaBridge.MethodId _cancelClearAnimation3023;
		public virtual void cancelClearAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._cancelClearAnimation3023);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._cancelClearAnimation3023);
		}
		internal static global::MonoJavaBridge.MethodId _cancelGesture3024;
		public virtual void cancelGesture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._cancelGesture3024);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._cancelGesture3024);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView3025;
		public GestureOverlayView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView3025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView3026;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView3026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView3027;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView3027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int GESTURE_STROKE_TYPE_SINGLE
		{
			get
			{
				return 0;
			}
		}
		public static int GESTURE_STROKE_TYPE_MULTIPLE
		{
			get
			{
				return 1;
			}
		}
		public static int ORIENTATION_HORIZONTAL
		{
			get
			{
				return 0;
			}
		}
		public static int ORIENTATION_VERTICAL
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureOverlayView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView"));
			global::android.gesture.GestureOverlayView._clear2980 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "clear", "(Z)V");
			global::android.gesture.GestureOverlayView._draw2981 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.gesture.GestureOverlayView._onDetachedFromWindow2982 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "onDetachedFromWindow", "()V");
			global::android.gesture.GestureOverlayView._dispatchTouchEvent2983 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.gesture.GestureOverlayView._setOrientation2984 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setOrientation", "(I)V");
			global::android.gesture.GestureOverlayView._getOrientation2985 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getOrientation", "()I");
			global::android.gesture.GestureOverlayView._getCurrentStroke2986 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getCurrentStroke", "()Ljava/util/ArrayList;");
			global::android.gesture.GestureOverlayView._setGestureColor2987 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureColor", "(I)V");
			global::android.gesture.GestureOverlayView._setUncertainGestureColor2988 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setUncertainGestureColor", "(I)V");
			global::android.gesture.GestureOverlayView._getUncertainGestureColor2989 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getUncertainGestureColor", "()I");
			global::android.gesture.GestureOverlayView._getGestureColor2990 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureColor", "()I");
			global::android.gesture.GestureOverlayView._getGestureStrokeWidth2991 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeWidth", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeWidth2992 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeWidth", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeType2993 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeType", "()I");
			global::android.gesture.GestureOverlayView._setGestureStrokeType2994 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeType", "(I)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2995 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeLengthThreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2996 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeLengthThreshold", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2997 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeSquarenessTreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2998 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeSquarenessTreshold", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2999 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeAngleThreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold3000 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeAngleThreshold", "(F)V");
			global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled3001 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isEventsInterceptionEnabled", "()Z");
			global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled3002 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setEventsInterceptionEnabled", "(Z)V");
			global::android.gesture.GestureOverlayView._isFadeEnabled3003 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isFadeEnabled", "()Z");
			global::android.gesture.GestureOverlayView._setFadeEnabled3004 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setFadeEnabled", "(Z)V");
			global::android.gesture.GestureOverlayView._getGesture3005 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGesture", "()Landroid/gesture/Gesture;");
			global::android.gesture.GestureOverlayView._setGesture3006 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGesture", "(Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureOverlayView._getGesturePath3007 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "()Landroid/graphics/Path;");
			global::android.gesture.GestureOverlayView._getGesturePath3008 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;");
			global::android.gesture.GestureOverlayView._isGestureVisible3009 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isGestureVisible", "()Z");
			global::android.gesture.GestureOverlayView._setGestureVisible3010 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureVisible", "(Z)V");
			global::android.gesture.GestureOverlayView._getFadeOffset3011 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getFadeOffset", "()J");
			global::android.gesture.GestureOverlayView._setFadeOffset3012 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setFadeOffset", "(J)V");
			global::android.gesture.GestureOverlayView._addOnGestureListener3013 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGestureListener3014 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGestureListeners3015 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGestureListeners", "()V");
			global::android.gesture.GestureOverlayView._addOnGesturePerformedListener3016 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener3017 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners3018 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturePerformedListeners", "()V");
			global::android.gesture.GestureOverlayView._addOnGesturingListener3019 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGesturingListener3020 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners3021 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturingListeners", "()V");
			global::android.gesture.GestureOverlayView._isGesturing3022 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isGesturing", "()Z");
			global::android.gesture.GestureOverlayView._cancelClearAnimation3023 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "cancelClearAnimation", "()V");
			global::android.gesture.GestureOverlayView._cancelGesture3024 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "cancelGesture", "()V");
			global::android.gesture.GestureOverlayView._GestureOverlayView3025 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.gesture.GestureOverlayView._GestureOverlayView3026 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.gesture.GestureOverlayView._GestureOverlayView3027 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
