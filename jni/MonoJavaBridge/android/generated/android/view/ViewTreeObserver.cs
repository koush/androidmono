namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ViewTreeObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewTreeObserver()
		{
			InitJNI();
		}
		internal ViewTreeObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_))]
		public interface OnGlobalFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener))]
		public sealed partial class OnGlobalFocusChangeListener_ : java.lang.Object, OnGlobalFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGlobalFocusChangeListener_()
			{
				InitJNI();
			}
			internal OnGlobalFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged9659;
			 void android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged9659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged9659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalFocusChangeListener"));
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged9659 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnGlobalLayoutListener_))]
		public interface OnGlobalLayoutListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGlobalLayout();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnGlobalLayoutListener))]
		public sealed partial class OnGlobalLayoutListener_ : java.lang.Object, OnGlobalLayoutListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGlobalLayoutListener_()
			{
				InitJNI();
			}
			internal OnGlobalLayoutListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGlobalLayout9660;
			 void android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout9660);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout9660);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalLayoutListener"));
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout9660 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, "onGlobalLayout", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnPreDrawListener_))]
		public interface OnPreDrawListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onPreDraw();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnPreDrawListener))]
		public sealed partial class OnPreDrawListener_ : java.lang.Object, OnPreDrawListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPreDrawListener_()
			{
				InitJNI();
			}
			internal OnPreDrawListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPreDraw9661;
			 bool android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw9661);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw9661);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnPreDrawListener"));
				global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw9661 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, "onPreDraw", "()Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnScrollChangedListener_))]
		public interface OnScrollChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScrollChanged();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnScrollChangedListener))]
		public sealed partial class OnScrollChangedListener_ : java.lang.Object, OnScrollChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnScrollChangedListener_()
			{
				InitJNI();
			}
			internal OnScrollChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScrollChanged9662;
			 void android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged9662);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged9662);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnScrollChangedListener"));
				global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged9662 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, "onScrollChanged", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnTouchModeChangeListener_))]
		public interface OnTouchModeChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTouchModeChanged(bool arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnTouchModeChangeListener))]
		public sealed partial class OnTouchModeChangeListener_ : java.lang.Object, OnTouchModeChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnTouchModeChangeListener_()
			{
				InitJNI();
			}
			internal OnTouchModeChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onTouchModeChanged9663;
			 void android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged9663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged9663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnTouchModeChangeListener"));
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged9663 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, "onTouchModeChanged", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _isAlive9664;
		public bool isAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver._isAlive9664);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._isAlive9664);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalFocusChangeListener9665;
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener9665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener9665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGlobalFocusChangeListener9666;
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener9666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener9666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalLayoutListener9667;
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener9667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener9667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGlobalOnLayoutListener9668;
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener9668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener9668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnPreDrawListener9669;
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnPreDrawListener9669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnPreDrawListener9669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnPreDrawListener9670;
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnPreDrawListener9670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnPreDrawListener9670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnScrollChangedListener9671;
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnScrollChangedListener9671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnScrollChangedListener9671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnScrollChangedListener9672;
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnScrollChangedListener9672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnScrollChangedListener9672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnTouchModeChangeListener9673;
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener9673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener9673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnTouchModeChangeListener9674;
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener9674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener9674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnGlobalLayout9675;
		public void dispatchOnGlobalLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout9675);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout9675);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnPreDraw9676;
		public bool dispatchOnPreDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver._dispatchOnPreDraw9676);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnPreDraw9676);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewTreeObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver"));
			global::android.view.ViewTreeObserver._isAlive9664 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z");
			global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener9665 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener9666 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._addOnGlobalLayoutListener9667 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener9668 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._addOnPreDrawListener9669 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._removeOnPreDrawListener9670 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._addOnScrollChangedListener9671 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._removeOnScrollChangedListener9672 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._addOnTouchModeChangeListener9673 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener9674 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._dispatchOnGlobalLayout9675 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V");
			global::android.view.ViewTreeObserver._dispatchOnPreDraw9676 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z");
		}
	}
}
