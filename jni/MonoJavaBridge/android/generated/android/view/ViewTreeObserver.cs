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
			internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged15145;
			 void android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged15145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged15145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalFocusChangeListener"));
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged15145 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
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
			internal static global::MonoJavaBridge.MethodId _onGlobalLayout15146;
			 void android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout15146);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout15146);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalLayoutListener"));
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout15146 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, "onGlobalLayout", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onPreDraw15147;
			 bool android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw15147);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw15147);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnPreDrawListener"));
				global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw15147 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, "onPreDraw", "()Z");
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
			internal static global::MonoJavaBridge.MethodId _onScrollChanged15148;
			 void android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged15148);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged15148);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnScrollChangedListener"));
				global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged15148 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, "onScrollChanged", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onTouchModeChanged15149;
			 void android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged15149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged15149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnTouchModeChangeListener"));
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged15149 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, "onTouchModeChanged", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _isAlive15150;
		public bool isAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver._isAlive15150);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._isAlive15150);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalFocusChangeListener15151;
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener15151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener15151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGlobalFocusChangeListener15152;
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener15152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener15152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalLayoutListener15153;
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener15153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener15153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGlobalOnLayoutListener15154;
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener15154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener15154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnPreDrawListener15155;
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnPreDrawListener15155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnPreDrawListener15155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnPreDrawListener15156;
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnPreDrawListener15156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnPreDrawListener15156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnScrollChangedListener15157;
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnScrollChangedListener15157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnScrollChangedListener15157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnScrollChangedListener15158;
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnScrollChangedListener15158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnScrollChangedListener15158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnTouchModeChangeListener15159;
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener15159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener15159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnTouchModeChangeListener15160;
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener15160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener15160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnGlobalLayout15161;
		public void dispatchOnGlobalLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout15161);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout15161);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnPreDraw15162;
		public bool dispatchOnPreDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver._dispatchOnPreDraw15162);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnPreDraw15162);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewTreeObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver"));
			global::android.view.ViewTreeObserver._isAlive15150 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z");
			global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener15151 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener15152 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._addOnGlobalLayoutListener15153 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener15154 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._addOnPreDrawListener15155 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._removeOnPreDrawListener15156 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._addOnScrollChangedListener15157 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._removeOnScrollChangedListener15158 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._addOnTouchModeChangeListener15159 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener15160 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._dispatchOnGlobalLayout15161 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V");
			global::android.view.ViewTreeObserver._dispatchOnPreDraw15162 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z");
		}
	}
}
