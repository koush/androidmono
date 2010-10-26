namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.ViewGroup_))]
	public abstract partial class ViewGroup : android.view.View, ViewParent, ViewManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewGroup()
		{
			InitJNI();
		}
		protected ViewGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class LayoutParams : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes15034;
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams._setBaseAttributes15034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._setBaseAttributes15034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams15035;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams15035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams15036;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams15036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams15037;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams15037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			public static int FILL_PARENT
			{
				get
				{
					return -1;
				}
			}
			public static int MATCH_PARENT
			{
				get
				{
					return -1;
				}
			}
			public static int WRAP_CONTENT
			{
				get
				{
					return -2;
				}
			}
			internal static global::MonoJavaBridge.FieldId _width15041;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width15041);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height15042;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height15042);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _layoutAnimationParameters15043;
			public global::android.view.animation.LayoutAnimationController.AnimationParameters layoutAnimationParameters
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _layoutAnimationParameters15043)) as android.view.animation.LayoutAnimationController.AnimationParameters;
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$LayoutParams"));
				global::android.view.ViewGroup.LayoutParams._setBaseAttributes15034 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams15035 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams15036 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams15037 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.view.ViewGroup.LayoutParams._width15041 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "width", "I");
				global::android.view.ViewGroup.LayoutParams._height15042 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "height", "I");
				global::android.view.ViewGroup.LayoutParams._layoutAnimationParameters15043 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "layoutAnimationParameters", "Landroid/view/animation/LayoutAnimationController$AnimationParameters;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MarginLayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MarginLayoutParams()
			{
				InitJNI();
			}
			protected MarginLayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setMargins15044;
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams._setMargins15044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._setMargins15044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams15045;
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams15046;
			public MarginLayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams15047;
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams15048;
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _leftMargin15049;
			public int leftMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _leftMargin15049);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _topMargin15050;
			public int topMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _topMargin15050);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rightMargin15051;
			public int rightMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rightMargin15051);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottomMargin15052;
			public int bottomMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _bottomMargin15052);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.MarginLayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$MarginLayoutParams"));
				global::android.view.ViewGroup.MarginLayoutParams._setMargins15044 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15045 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15046 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15047 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams15048 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.view.ViewGroup.MarginLayoutParams._leftMargin15049 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "leftMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._topMargin15050 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "topMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._rightMargin15051 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "rightMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._bottomMargin15052 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "bottomMargin", "I");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewGroup.OnHierarchyChangeListener_))]
		public partial interface OnHierarchyChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onChildViewAdded(android.view.View arg0, android.view.View arg1);
			void onChildViewRemoved(android.view.View arg0, android.view.View arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewGroup.OnHierarchyChangeListener))]
		internal sealed partial class OnHierarchyChangeListener_ : java.lang.Object, OnHierarchyChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnHierarchyChangeListener_()
			{
				InitJNI();
			}
			internal OnHierarchyChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onChildViewAdded15053;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded15053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded15053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onChildViewRemoved15054;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved15054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved15054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$OnHierarchyChangeListener"));
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded15053 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved15054 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _debug15055;
		protected virtual void debug(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._debug15055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._debug15055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addStatesFromChildren15056;
		public virtual bool addStatesFromChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addStatesFromChildren15056);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addStatesFromChildren15056);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus15057;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocus15057);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocus15057);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent15058;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEvent15058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEvent15058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent15059;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTouchEvent15059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTouchEvent15059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent15060;
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTrackballEvent15060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTrackballEvent15060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent15061;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent15061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent15061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView15062;
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView15062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView15062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView15063;
		public virtual void addView(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView15063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView15063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addView15064;
		public virtual void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView15064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView15064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView15065;
		public virtual void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView15065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView15065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView15066;
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView15066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView15066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout15067;
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._updateViewLayout15067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._updateViewLayout15067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView15068;
		public virtual void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeView15068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeView15068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus15069;
		public override void clearFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearFocus15069);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearFocus15069);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable15070;
		public override bool hasFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocusable15070);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocusable15070);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus15071;
		public override global::android.view.View findFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._findFocus15071)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._findFocus15071)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows15072;
		protected override bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._fitSystemWindows15072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._fitSystemWindows15072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed15073;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetPressed15073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetPressed15073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch15074;
		public virtual global::android.view.View focusSearch(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._focusSearch15074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusSearch15074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove15075;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchUnhandledMove15075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchUnhandledMove15075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables15076;
		public override void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables15076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables15076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables15077;
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables15077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables15077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables15078;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addTouchables15078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addTouchables15078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus15079;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestFocus15079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestFocus15079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme15080;
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEventPreIme15080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEventPreIme15080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent15081;
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyShortcutEvent15081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyShortcutEvent15081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged15082;
		public override void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowFocusChanged15082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowFocusChanged15082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged15083;
		protected override void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchVisibilityChanged15083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchVisibilityChanged15083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint15084;
		public override void dispatchDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDisplayHint15084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDisplayHint15084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged15085;
		public override void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowVisibilityChanged15085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowVisibilityChanged15085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged15086;
		public override void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchConfigurationChanged15086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchConfigurationChanged15086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw15087;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDraw15087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDraw15087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState15088;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSaveInstanceState15088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSaveInstanceState15088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState15089;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchRestoreInstanceState15089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchRestoreInstanceState15089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout15090;
		protected abstract void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged15091;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._drawableStateChanged15091);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawableStateChanged15091);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState15092;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._onCreateDrawableState15092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onCreateDrawableState15092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setPadding15093;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPadding15093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPadding15093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected15094;
		public virtual void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetSelected15094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetSelected15094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart15095;
		protected override void onAnimationStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationStart15095);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationStart15095);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd15096;
		protected override void onAnimationEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationEnd15096);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationEnd15096);
		}
		internal static global::MonoJavaBridge.MethodId _getDescendantFocusability15097;
		public virtual int getDescendantFocusability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getDescendantFocusability15097);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getDescendantFocusability15097);
		}
		internal static global::MonoJavaBridge.MethodId _setDescendantFocusability15098;
		public virtual void setDescendantFocusability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setDescendantFocusability15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setDescendantFocusability15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus15099;
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildFocus15099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildFocus15099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _focusableViewAvailable15100;
		public virtual void focusableViewAvailable(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._focusableViewAvailable15100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusableViewAvailable15100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild15101;
		public virtual bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._showContextMenuForChild15101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._showContextMenuForChild15101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen15102;
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildRectangleOnScreen15102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildRectangleOnScreen15102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearChildFocus15103;
		public virtual void clearChildFocus(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearChildFocus15103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearChildFocus15103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedChild15104;
		public virtual global::android.view.View getFocusedChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getFocusedChild15104)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getFocusedChild15104)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _recomputeViewAttributes15105;
		public virtual void recomputeViewAttributes(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._recomputeViewAttributes15105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._recomputeViewAttributes15105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringChildToFront15106;
		public virtual void bringChildToFront(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._bringChildToFront15106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._bringChildToFront15106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestDisallowInterceptTouchEvent15107;
		public virtual void requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent15107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent15107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent15108;
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onInterceptTouchEvent15108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onInterceptTouchEvent15108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants15109;
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onRequestFocusInDescendants15109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onRequestFocusInDescendants15109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchFreezeSelfOnly15110;
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchFreezeSelfOnly15110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchFreezeSelfOnly15110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchThawSelfOnly15111;
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchThawSelfOnly15111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchThawSelfOnly15111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingCacheEnabled15112;
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled15112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled15112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder15113;
		protected virtual int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildDrawingOrder15113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildDrawingOrder15113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild15114;
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._drawChild15114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawChild15114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClipChildren15115;
		public virtual void setClipChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipChildren15115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipChildren15115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClipToPadding15116;
		public virtual void setClipToPadding(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipToPadding15116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipToPadding15116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStaticTransformationsEnabled15117;
		protected virtual void setStaticTransformationsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setStaticTransformationsEnabled15117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setStaticTransformationsEnabled15117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildStaticTransformation15118;
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildStaticTransformation15118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildStaticTransformation15118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams15119;
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._checkLayoutParams15119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._checkLayoutParams15119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener15120;
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setOnHierarchyChangeListener15120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setOnHierarchyChangeListener15120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout15121;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout15121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout15121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout15122;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout15122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout15122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cleanupLayoutState15123;
		protected virtual void cleanupLayoutState(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._cleanupLayoutState15123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._cleanupLayoutState15123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _attachLayoutAnimationParameters15124;
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachLayoutAnimationParameters15124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachLayoutAnimationParameters15124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout15125;
		public virtual void removeViewInLayout(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewInLayout15125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewInLayout15125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout15126;
		public virtual void removeViewsInLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewsInLayout15126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewsInLayout15126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt15127;
		public virtual void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewAt15127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewAt15127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews15128;
		public virtual void removeViews(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViews15128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViews15128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews15129;
		public virtual void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViews15129);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViews15129);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViewsInLayout15130;
		public virtual void removeAllViewsInLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViewsInLayout15130);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViewsInLayout15130);
		}
		internal static global::MonoJavaBridge.MethodId _removeDetachedView15131;
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeDetachedView15131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeDetachedView15131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attachViewToParent15132;
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachViewToParent15132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachViewToParent15132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent15133;
		protected virtual void detachViewFromParent(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent15133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent15133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent15134;
		protected virtual void detachViewFromParent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent15134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent15134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewsFromParent15135;
		protected virtual void detachViewsFromParent(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewsFromParent15135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewsFromParent15135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detachAllViewsFromParent15136;
		protected virtual void detachAllViewsFromParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachAllViewsFromParent15136);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachAllViewsFromParent15136);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChild15137;
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChild15137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChild15137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChildInParent15138;
		public virtual global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChildInParent15138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChildInParent15138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _offsetDescendantRectToMyCoords15139;
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetDescendantRectToMyCoords15139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetDescendantRectToMyCoords15139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetRectIntoDescendantCoords15140;
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetRectIntoDescendantCoords15140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetRectIntoDescendantCoords15140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildVisibleRect15141;
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildVisibleRect15141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildVisibleRect15141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate15142;
		protected virtual bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._canAnimate15142);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._canAnimate15142);
		}
		internal static global::MonoJavaBridge.MethodId _startLayoutAnimation15143;
		public virtual void startLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._startLayoutAnimation15143);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._startLayoutAnimation15143);
		}
		internal static global::MonoJavaBridge.MethodId _scheduleLayoutAnimation15144;
		public virtual void scheduleLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._scheduleLayoutAnimation15144);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._scheduleLayoutAnimation15144);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimation15145;
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimation15145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimation15145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimation15146;
		public virtual global::android.view.animation.LayoutAnimationController getLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimation15146)) as android.view.animation.LayoutAnimationController;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimation15146)) as android.view.animation.LayoutAnimationController;
		}
		internal static global::MonoJavaBridge.MethodId _isAnimationCacheEnabled15147;
		public virtual bool isAnimationCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAnimationCacheEnabled15147);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAnimationCacheEnabled15147);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationCacheEnabled15148;
		public virtual void setAnimationCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAnimationCacheEnabled15148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAnimationCacheEnabled15148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAlwaysDrawnWithCacheEnabled15149;
		public virtual bool isAlwaysDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled15149);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled15149);
		}
		internal static global::MonoJavaBridge.MethodId _setAlwaysDrawnWithCacheEnabled15150;
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled15150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled15150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawnWithCacheEnabled15151;
		protected virtual bool isChildrenDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled15151);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled15151);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawnWithCacheEnabled15152;
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled15152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled15152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawingOrderEnabled15153;
		protected virtual bool isChildrenDrawingOrderEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled15153);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled15153);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingOrderEnabled15154;
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled15154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled15154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistentDrawingCache15155;
		public virtual int getPersistentDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getPersistentDrawingCache15155);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getPersistentDrawingCache15155);
		}
		internal static global::MonoJavaBridge.MethodId _setPersistentDrawingCache15156;
		public virtual void setPersistentDrawingCache(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPersistentDrawingCache15156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPersistentDrawingCache15156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams15157;
		protected virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams15157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams15157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams15158;
		public virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams15158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams15158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams15159;
		protected virtual global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateDefaultLayoutParams15159)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateDefaultLayoutParams15159)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _indexOfChild15160;
		public virtual int indexOfChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._indexOfChild15160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._indexOfChild15160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildCount15161;
		public virtual int getChildCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildCount15161);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildCount15161);
		}
		internal static global::MonoJavaBridge.MethodId _getChildAt15162;
		public virtual global::android.view.View getChildAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getChildAt15162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildAt15162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _measureChildren15163;
		protected virtual void measureChildren(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildren15163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildren15163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild15164;
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChild15164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChild15164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins15165;
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildWithMargins15165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildWithMargins15165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getChildMeasureSpec15166;
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildMeasureSpec15166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearDisappearingChildren15167;
		public virtual void clearDisappearingChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearDisappearingChildren15167);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearDisappearingChildren15167);
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion15168;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._gatherTransparentRegion15168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._gatherTransparentRegion15168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestTransparentRegion15169;
		public virtual void requestTransparentRegion(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestTransparentRegion15169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestTransparentRegion15169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimationListener15170;
		public virtual global::android.view.animation.Animation.AnimationListener getLayoutAnimationListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimationListener15170)) as android.view.animation.Animation.AnimationListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimationListener15170)) as android.view.animation.Animation.AnimationListener;
		}
		internal static global::MonoJavaBridge.MethodId _setAddStatesFromChildren15171;
		public virtual void setAddStatesFromChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAddStatesFromChildren15171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAddStatesFromChildren15171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged15172;
		public virtual void childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._childDrawableStateChanged15172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._childDrawableStateChanged15172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimationListener15173;
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimationListener15173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimationListener15173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup15174;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup15174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup15175;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup15175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup15176;
		public ViewGroup(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup15176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int FOCUS_BEFORE_DESCENDANTS
		{
			get
			{
				return 131072;
			}
		}
		public static int FOCUS_AFTER_DESCENDANTS
		{
			get
			{
				return 262144;
			}
		}
		public static int FOCUS_BLOCK_DESCENDANTS
		{
			get
			{
				return 393216;
			}
		}
		public static int PERSISTENT_NO_CACHE
		{
			get
			{
				return 0;
			}
		}
		public static int PERSISTENT_ANIMATION_CACHE
		{
			get
			{
				return 1;
			}
		}
		public static int PERSISTENT_SCROLLING_CACHE
		{
			get
			{
				return 2;
			}
		}
		public static int PERSISTENT_ALL_CACHES
		{
			get
			{
				return 3;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup"));
			global::android.view.ViewGroup._debug15055 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "debug", "(I)V");
			global::android.view.ViewGroup._addStatesFromChildren15056 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z");
			global::android.view.ViewGroup._hasFocus15057 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocus", "()Z");
			global::android.view.ViewGroup._dispatchKeyEvent15058 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchTouchEvent15059 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchTrackballEvent15060 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent15061 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.ViewGroup._addView15062 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._addView15063 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._addView15064 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._addView15065 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._addView15066 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._updateViewLayout15067 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._removeView15068 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._clearFocus15069 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearFocus", "()V");
			global::android.view.ViewGroup._hasFocusable15070 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z");
			global::android.view.ViewGroup._findFocus15071 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.ViewGroup._fitSystemWindows15072 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchSetPressed15073 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.ViewGroup._focusSearch15074 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.ViewGroup._dispatchUnhandledMove15075 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.ViewGroup._addFocusables15076 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.ViewGroup._addFocusables15077 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.ViewGroup._addTouchables15078 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.ViewGroup._requestFocus15079 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchKeyEventPreIme15080 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchKeyShortcutEvent15081 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchWindowFocusChanged15082 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.ViewGroup._dispatchVisibilityChanged15083 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._dispatchDisplayHint15084 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.ViewGroup._dispatchWindowVisibilityChanged15085 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.ViewGroup._dispatchConfigurationChanged15086 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.ViewGroup._dispatchDraw15087 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewGroup._dispatchSaveInstanceState15088 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchRestoreInstanceState15089 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._onLayout15090 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.ViewGroup._drawableStateChanged15091 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V");
			global::android.view.ViewGroup._onCreateDrawableState15092 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.ViewGroup._setPadding15093 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V");
			global::android.view.ViewGroup._dispatchSetSelected15094 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.ViewGroup._onAnimationStart15095 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V");
			global::android.view.ViewGroup._onAnimationEnd15096 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V");
			global::android.view.ViewGroup._getDescendantFocusability15097 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I");
			global::android.view.ViewGroup._setDescendantFocusability15098 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V");
			global::android.view.ViewGroup._requestChildFocus15099 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.ViewGroup._focusableViewAvailable15100 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._showContextMenuForChild15101 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.ViewGroup._requestChildRectangleOnScreen15102 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.ViewGroup._clearChildFocus15103 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getFocusedChild15104 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;");
			global::android.view.ViewGroup._recomputeViewAttributes15105 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._bringChildToFront15106 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._requestDisallowInterceptTouchEvent15107 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.ViewGroup._onInterceptTouchEvent15108 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._onRequestFocusInDescendants15109 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchFreezeSelfOnly15110 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchThawSelfOnly15111 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._setChildrenDrawingCacheEnabled15112 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildDrawingOrder15113 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.view.ViewGroup._drawChild15114 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.view.ViewGroup._setClipChildren15115 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V");
			global::android.view.ViewGroup._setClipToPadding15116 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V");
			global::android.view.ViewGroup._setStaticTransformationsEnabled15117 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildStaticTransformation15118 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.view.ViewGroup._checkLayoutParams15119 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._setOnHierarchyChangeListener15120 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.view.ViewGroup._addViewInLayout15121 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._addViewInLayout15122 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z");
			global::android.view.ViewGroup._cleanupLayoutState15123 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._attachLayoutAnimationParameters15124 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.view.ViewGroup._removeViewInLayout15125 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._removeViewsInLayout15126 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V");
			global::android.view.ViewGroup._removeViewAt15127 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V");
			global::android.view.ViewGroup._removeViews15128 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViews", "(II)V");
			global::android.view.ViewGroup._removeAllViews15129 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViews", "()V");
			global::android.view.ViewGroup._removeAllViewsInLayout15130 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V");
			global::android.view.ViewGroup._removeDetachedView15131 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V");
			global::android.view.ViewGroup._attachViewToParent15132 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._detachViewFromParent15133 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._detachViewFromParent15134 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V");
			global::android.view.ViewGroup._detachViewsFromParent15135 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V");
			global::android.view.ViewGroup._detachAllViewsFromParent15136 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V");
			global::android.view.ViewGroup._invalidateChild15137 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._invalidateChildInParent15138 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.ViewGroup._offsetDescendantRectToMyCoords15139 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._offsetRectIntoDescendantCoords15140 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._getChildVisibleRect15141 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.ViewGroup._canAnimate15142 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "canAnimate", "()Z");
			global::android.view.ViewGroup._startLayoutAnimation15143 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V");
			global::android.view.ViewGroup._scheduleLayoutAnimation15144 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V");
			global::android.view.ViewGroup._setLayoutAnimation15145 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V");
			global::android.view.ViewGroup._getLayoutAnimation15146 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;");
			global::android.view.ViewGroup._isAnimationCacheEnabled15147 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAnimationCacheEnabled15148 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled15149 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled15150 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled15151 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled15152 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawingOrderEnabled15153 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawingOrderEnabled15154 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V");
			global::android.view.ViewGroup._getPersistentDrawingCache15155 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I");
			global::android.view.ViewGroup._setPersistentDrawingCache15156 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V");
			global::android.view.ViewGroup._generateLayoutParams15157 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateLayoutParams15158 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateDefaultLayoutParams15159 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._indexOfChild15160 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I");
			global::android.view.ViewGroup._getChildCount15161 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildCount", "()I");
			global::android.view.ViewGroup._getChildAt15162 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;");
			global::android.view.ViewGroup._measureChildren15163 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V");
			global::android.view.ViewGroup._measureChild15164 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._measureChildWithMargins15165 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.view.ViewGroup._getChildMeasureSpec15166 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I");
			global::android.view.ViewGroup._clearDisappearingChildren15167 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V");
			global::android.view.ViewGroup._gatherTransparentRegion15168 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.ViewGroup._requestTransparentRegion15169 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getLayoutAnimationListener15170 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;");
			global::android.view.ViewGroup._setAddStatesFromChildren15171 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V");
			global::android.view.ViewGroup._childDrawableStateChanged15172 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._setLayoutAnimationListener15173 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.ViewGroup._ViewGroup15174 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewGroup._ViewGroup15175 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.ViewGroup._ViewGroup15176 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewGroup))]
	internal sealed partial class ViewGroup_ : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewGroup_()
		{
			InitJNI();
		}
		internal ViewGroup_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onLayout15184;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup_._onLayout15184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup_.staticClass, global::android.view.ViewGroup_._onLayout15184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewGroup_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup"));
			global::android.view.ViewGroup_._onLayout15184 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup_.staticClass, "onLayout", "(ZIIII)V");
		}
	}
}
