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
			internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged10205;
			 void android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged10205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged10205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalFocusChangeListener"));
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged10205 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
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
			internal static global::MonoJavaBridge.MethodId _onGlobalLayout10206;
			 void android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout10206);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout10206);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalLayoutListener"));
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout10206 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, "onGlobalLayout", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onPreDraw10207;
			 bool android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw10207);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw10207);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnPreDrawListener"));
				global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw10207 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, "onPreDraw", "()Z");
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
			internal static global::MonoJavaBridge.MethodId _onScrollChanged10208;
			 void android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged10208);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged10208);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnScrollChangedListener"));
				global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged10208 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, "onScrollChanged", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onTouchModeChanged10209;
			 void android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged10209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged10209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnTouchModeChangeListener"));
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged10209 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, "onTouchModeChanged", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _isAlive10210;
		public bool isAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver._isAlive10210);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._isAlive10210);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalFocusChangeListener10211;
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener10211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener10211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGlobalFocusChangeListener10212;
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener10212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener10212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalLayoutListener10213;
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener10213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener10213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeGlobalOnLayoutListener10214;
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener10214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener10214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnPreDrawListener10215;
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnPreDrawListener10215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnPreDrawListener10215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnPreDrawListener10216;
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnPreDrawListener10216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnPreDrawListener10216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnScrollChangedListener10217;
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnScrollChangedListener10217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnScrollChangedListener10217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnScrollChangedListener10218;
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnScrollChangedListener10218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnScrollChangedListener10218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnTouchModeChangeListener10219;
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener10219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener10219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnTouchModeChangeListener10220;
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener10220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener10220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnGlobalLayout10221;
		public void dispatchOnGlobalLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout10221);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout10221);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnPreDraw10222;
		public bool dispatchOnPreDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver._dispatchOnPreDraw10222);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnPreDraw10222);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewTreeObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver"));
			global::android.view.ViewTreeObserver._isAlive10210 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z");
			global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener10211 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener10212 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._addOnGlobalLayoutListener10213 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener10214 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._addOnPreDrawListener10215 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._removeOnPreDrawListener10216 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._addOnScrollChangedListener10217 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._removeOnScrollChangedListener10218 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._addOnTouchModeChangeListener10219 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener10220 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._dispatchOnGlobalLayout10221 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V");
			global::android.view.ViewTreeObserver._dispatchOnPreDraw10222 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z");
		}
	}
}
