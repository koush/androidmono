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
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes10030;
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams._setBaseAttributes10030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._setBaseAttributes10030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams10031;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams10031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams10032;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams10032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams10033;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams10033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.FieldId _width10034;
			public int width
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height10035;
			public int height
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _layoutAnimationParameters10036;
			public global::android.view.animation.LayoutAnimationController.AnimationParameters layoutAnimationParameters
			{
				get
				{
					return default(global::android.view.animation.LayoutAnimationController.AnimationParameters);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$LayoutParams"));
				global::android.view.ViewGroup.LayoutParams._setBaseAttributes10030 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams10031 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams10032 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams10033 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
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
			internal static global::MonoJavaBridge.MethodId _setMargins10037;
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams._setMargins10037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._setMargins10037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams10038;
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams10039;
			public MarginLayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams10040;
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams10041;
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _leftMargin10042;
			public int leftMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _topMargin10043;
			public int topMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rightMargin10044;
			public int rightMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottomMargin10045;
			public int bottomMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.MarginLayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$MarginLayoutParams"));
				global::android.view.ViewGroup.MarginLayoutParams._setMargins10037 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10038 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10039 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10040 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams10041 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewGroup.OnHierarchyChangeListener_))]
		public interface OnHierarchyChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onChildViewAdded(android.view.View arg0, android.view.View arg1);
			void onChildViewRemoved(android.view.View arg0, android.view.View arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewGroup.OnHierarchyChangeListener))]
		public sealed partial class OnHierarchyChangeListener_ : java.lang.Object, OnHierarchyChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnHierarchyChangeListener_()
			{
				InitJNI();
			}
			internal OnHierarchyChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onChildViewAdded10046;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded10046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded10046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onChildViewRemoved10047;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved10047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved10047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$OnHierarchyChangeListener"));
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded10046 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved10047 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _debug10048;
		protected virtual void debug(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._debug10048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._debug10048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addStatesFromChildren10049;
		public virtual bool addStatesFromChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addStatesFromChildren10049);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addStatesFromChildren10049);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus10050;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocus10050);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocus10050);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent10051;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEvent10051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEvent10051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent10052;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTouchEvent10052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTouchEvent10052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent10053;
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTrackballEvent10053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTrackballEvent10053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent10054;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent10054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent10054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView10055;
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView10055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView10055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView10056;
		public virtual void addView(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView10056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView10056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addView10057;
		public virtual void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView10057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView10057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView10058;
		public virtual void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView10058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView10058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView10059;
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView10059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView10059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout10060;
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._updateViewLayout10060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._updateViewLayout10060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView10061;
		public virtual void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeView10061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeView10061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus10062;
		public override void clearFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearFocus10062);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearFocus10062);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable10063;
		public override bool hasFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocusable10063);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocusable10063);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus10064;
		public override global::android.view.View findFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._findFocus10064)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._findFocus10064)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows10065;
		protected override bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._fitSystemWindows10065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._fitSystemWindows10065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed10066;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetPressed10066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetPressed10066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch10067;
		public virtual global::android.view.View focusSearch(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._focusSearch10067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusSearch10067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove10068;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchUnhandledMove10068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchUnhandledMove10068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables10069;
		public override void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables10069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables10069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables10070;
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables10070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables10070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables10071;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addTouchables10071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addTouchables10071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus10072;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestFocus10072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestFocus10072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme10073;
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEventPreIme10073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEventPreIme10073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent10074;
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyShortcutEvent10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyShortcutEvent10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged10075;
		public override void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowFocusChanged10075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowFocusChanged10075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged10076;
		protected override void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchVisibilityChanged10076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchVisibilityChanged10076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint10077;
		public override void dispatchDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDisplayHint10077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDisplayHint10077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged10078;
		public override void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowVisibilityChanged10078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowVisibilityChanged10078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged10079;
		public override void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchConfigurationChanged10079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchConfigurationChanged10079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw10080;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDraw10080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDraw10080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState10081;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSaveInstanceState10081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSaveInstanceState10081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState10082;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchRestoreInstanceState10082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchRestoreInstanceState10082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout10083;
		protected abstract void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged10084;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._drawableStateChanged10084);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawableStateChanged10084);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState10085;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._onCreateDrawableState10085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onCreateDrawableState10085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setPadding10086;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPadding10086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPadding10086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected10087;
		public virtual void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetSelected10087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetSelected10087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart10088;
		protected override void onAnimationStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationStart10088);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationStart10088);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd10089;
		protected override void onAnimationEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationEnd10089);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationEnd10089);
		}
		internal static global::MonoJavaBridge.MethodId _getDescendantFocusability10090;
		public virtual int getDescendantFocusability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getDescendantFocusability10090);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getDescendantFocusability10090);
		}
		internal static global::MonoJavaBridge.MethodId _setDescendantFocusability10091;
		public virtual void setDescendantFocusability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setDescendantFocusability10091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setDescendantFocusability10091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus10092;
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildFocus10092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildFocus10092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _focusableViewAvailable10093;
		public virtual void focusableViewAvailable(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._focusableViewAvailable10093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusableViewAvailable10093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild10094;
		public virtual bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._showContextMenuForChild10094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._showContextMenuForChild10094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen10095;
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildRectangleOnScreen10095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildRectangleOnScreen10095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearChildFocus10096;
		public virtual void clearChildFocus(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearChildFocus10096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearChildFocus10096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedChild10097;
		public virtual global::android.view.View getFocusedChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getFocusedChild10097)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getFocusedChild10097)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _recomputeViewAttributes10098;
		public virtual void recomputeViewAttributes(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._recomputeViewAttributes10098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._recomputeViewAttributes10098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringChildToFront10099;
		public virtual void bringChildToFront(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._bringChildToFront10099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._bringChildToFront10099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestDisallowInterceptTouchEvent10100;
		public virtual void requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent10100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent10100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent10101;
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onInterceptTouchEvent10101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onInterceptTouchEvent10101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants10102;
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onRequestFocusInDescendants10102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onRequestFocusInDescendants10102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchFreezeSelfOnly10103;
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchFreezeSelfOnly10103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchFreezeSelfOnly10103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchThawSelfOnly10104;
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchThawSelfOnly10104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchThawSelfOnly10104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingCacheEnabled10105;
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled10105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled10105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder10106;
		protected virtual int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildDrawingOrder10106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildDrawingOrder10106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild10107;
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._drawChild10107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawChild10107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClipChildren10108;
		public virtual void setClipChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipChildren10108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipChildren10108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClipToPadding10109;
		public virtual void setClipToPadding(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipToPadding10109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipToPadding10109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStaticTransformationsEnabled10110;
		protected virtual void setStaticTransformationsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setStaticTransformationsEnabled10110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setStaticTransformationsEnabled10110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildStaticTransformation10111;
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildStaticTransformation10111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildStaticTransformation10111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams10112;
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._checkLayoutParams10112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._checkLayoutParams10112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener10113;
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setOnHierarchyChangeListener10113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setOnHierarchyChangeListener10113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout10114;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout10114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout10114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout10115;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout10115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout10115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cleanupLayoutState10116;
		protected virtual void cleanupLayoutState(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._cleanupLayoutState10116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._cleanupLayoutState10116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _attachLayoutAnimationParameters10117;
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachLayoutAnimationParameters10117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachLayoutAnimationParameters10117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout10118;
		public virtual void removeViewInLayout(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewInLayout10118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewInLayout10118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout10119;
		public virtual void removeViewsInLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewsInLayout10119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewsInLayout10119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt10120;
		public virtual void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewAt10120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewAt10120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews10121;
		public virtual void removeViews(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViews10121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViews10121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews10122;
		public virtual void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViews10122);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViews10122);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViewsInLayout10123;
		public virtual void removeAllViewsInLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViewsInLayout10123);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViewsInLayout10123);
		}
		internal static global::MonoJavaBridge.MethodId _removeDetachedView10124;
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeDetachedView10124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeDetachedView10124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attachViewToParent10125;
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachViewToParent10125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachViewToParent10125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent10126;
		protected virtual void detachViewFromParent(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent10126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent10126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent10127;
		protected virtual void detachViewFromParent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent10127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent10127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewsFromParent10128;
		protected virtual void detachViewsFromParent(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewsFromParent10128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewsFromParent10128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detachAllViewsFromParent10129;
		protected virtual void detachAllViewsFromParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachAllViewsFromParent10129);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachAllViewsFromParent10129);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChild10130;
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChild10130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChild10130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChildInParent10131;
		public virtual global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChildInParent10131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChildInParent10131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _offsetDescendantRectToMyCoords10132;
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetDescendantRectToMyCoords10132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetDescendantRectToMyCoords10132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetRectIntoDescendantCoords10133;
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetRectIntoDescendantCoords10133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetRectIntoDescendantCoords10133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildVisibleRect10134;
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildVisibleRect10134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildVisibleRect10134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate10135;
		protected virtual bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._canAnimate10135);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._canAnimate10135);
		}
		internal static global::MonoJavaBridge.MethodId _startLayoutAnimation10136;
		public virtual void startLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._startLayoutAnimation10136);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._startLayoutAnimation10136);
		}
		internal static global::MonoJavaBridge.MethodId _scheduleLayoutAnimation10137;
		public virtual void scheduleLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._scheduleLayoutAnimation10137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._scheduleLayoutAnimation10137);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimation10138;
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimation10138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimation10138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimation10139;
		public virtual global::android.view.animation.LayoutAnimationController getLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimation10139)) as android.view.animation.LayoutAnimationController;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimation10139)) as android.view.animation.LayoutAnimationController;
		}
		internal static global::MonoJavaBridge.MethodId _isAnimationCacheEnabled10140;
		public virtual bool isAnimationCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAnimationCacheEnabled10140);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAnimationCacheEnabled10140);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationCacheEnabled10141;
		public virtual void setAnimationCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAnimationCacheEnabled10141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAnimationCacheEnabled10141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAlwaysDrawnWithCacheEnabled10142;
		public virtual bool isAlwaysDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled10142);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled10142);
		}
		internal static global::MonoJavaBridge.MethodId _setAlwaysDrawnWithCacheEnabled10143;
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled10143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled10143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawnWithCacheEnabled10144;
		protected virtual bool isChildrenDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled10144);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled10144);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawnWithCacheEnabled10145;
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled10145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled10145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawingOrderEnabled10146;
		protected virtual bool isChildrenDrawingOrderEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled10146);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled10146);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingOrderEnabled10147;
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled10147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled10147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistentDrawingCache10148;
		public virtual int getPersistentDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getPersistentDrawingCache10148);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getPersistentDrawingCache10148);
		}
		internal static global::MonoJavaBridge.MethodId _setPersistentDrawingCache10149;
		public virtual void setPersistentDrawingCache(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPersistentDrawingCache10149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPersistentDrawingCache10149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams10150;
		protected virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams10150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams10150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams10151;
		public virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams10151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams10151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams10152;
		protected virtual global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateDefaultLayoutParams10152)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateDefaultLayoutParams10152)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _indexOfChild10153;
		public virtual int indexOfChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._indexOfChild10153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._indexOfChild10153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildCount10154;
		public virtual int getChildCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildCount10154);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildCount10154);
		}
		internal static global::MonoJavaBridge.MethodId _getChildAt10155;
		public virtual global::android.view.View getChildAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getChildAt10155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildAt10155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _measureChildren10156;
		protected virtual void measureChildren(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildren10156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildren10156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild10157;
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChild10157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChild10157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins10158;
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildWithMargins10158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildWithMargins10158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getChildMeasureSpec10159;
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildMeasureSpec10159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearDisappearingChildren10160;
		public virtual void clearDisappearingChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearDisappearingChildren10160);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearDisappearingChildren10160);
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion10161;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._gatherTransparentRegion10161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._gatherTransparentRegion10161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestTransparentRegion10162;
		public virtual void requestTransparentRegion(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestTransparentRegion10162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestTransparentRegion10162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimationListener10163;
		public virtual global::android.view.animation.Animation.AnimationListener getLayoutAnimationListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimationListener10163)) as android.view.animation.Animation.AnimationListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimationListener10163)) as android.view.animation.Animation.AnimationListener;
		}
		internal static global::MonoJavaBridge.MethodId _setAddStatesFromChildren10164;
		public virtual void setAddStatesFromChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAddStatesFromChildren10164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAddStatesFromChildren10164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged10165;
		public virtual void childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._childDrawableStateChanged10165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._childDrawableStateChanged10165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimationListener10166;
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimationListener10166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimationListener10166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup10167;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup10167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup10168;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup10168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup10169;
		public ViewGroup(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup10169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.ViewGroup._debug10048 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "debug", "(I)V");
			global::android.view.ViewGroup._addStatesFromChildren10049 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z");
			global::android.view.ViewGroup._hasFocus10050 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocus", "()Z");
			global::android.view.ViewGroup._dispatchKeyEvent10051 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchTouchEvent10052 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchTrackballEvent10053 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent10054 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.ViewGroup._addView10055 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._addView10056 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._addView10057 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._addView10058 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._addView10059 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._updateViewLayout10060 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._removeView10061 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._clearFocus10062 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearFocus", "()V");
			global::android.view.ViewGroup._hasFocusable10063 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z");
			global::android.view.ViewGroup._findFocus10064 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.ViewGroup._fitSystemWindows10065 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchSetPressed10066 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.ViewGroup._focusSearch10067 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.ViewGroup._dispatchUnhandledMove10068 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.ViewGroup._addFocusables10069 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.ViewGroup._addFocusables10070 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.ViewGroup._addTouchables10071 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.ViewGroup._requestFocus10072 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchKeyEventPreIme10073 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchKeyShortcutEvent10074 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchWindowFocusChanged10075 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.ViewGroup._dispatchVisibilityChanged10076 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._dispatchDisplayHint10077 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.ViewGroup._dispatchWindowVisibilityChanged10078 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.ViewGroup._dispatchConfigurationChanged10079 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.ViewGroup._dispatchDraw10080 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewGroup._dispatchSaveInstanceState10081 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchRestoreInstanceState10082 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._onLayout10083 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.ViewGroup._drawableStateChanged10084 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V");
			global::android.view.ViewGroup._onCreateDrawableState10085 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.ViewGroup._setPadding10086 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V");
			global::android.view.ViewGroup._dispatchSetSelected10087 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.ViewGroup._onAnimationStart10088 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V");
			global::android.view.ViewGroup._onAnimationEnd10089 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V");
			global::android.view.ViewGroup._getDescendantFocusability10090 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I");
			global::android.view.ViewGroup._setDescendantFocusability10091 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V");
			global::android.view.ViewGroup._requestChildFocus10092 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.ViewGroup._focusableViewAvailable10093 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._showContextMenuForChild10094 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.ViewGroup._requestChildRectangleOnScreen10095 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.ViewGroup._clearChildFocus10096 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getFocusedChild10097 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;");
			global::android.view.ViewGroup._recomputeViewAttributes10098 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._bringChildToFront10099 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._requestDisallowInterceptTouchEvent10100 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.ViewGroup._onInterceptTouchEvent10101 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._onRequestFocusInDescendants10102 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchFreezeSelfOnly10103 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchThawSelfOnly10104 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._setChildrenDrawingCacheEnabled10105 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildDrawingOrder10106 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.view.ViewGroup._drawChild10107 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.view.ViewGroup._setClipChildren10108 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V");
			global::android.view.ViewGroup._setClipToPadding10109 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V");
			global::android.view.ViewGroup._setStaticTransformationsEnabled10110 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildStaticTransformation10111 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.view.ViewGroup._checkLayoutParams10112 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._setOnHierarchyChangeListener10113 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.view.ViewGroup._addViewInLayout10114 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._addViewInLayout10115 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z");
			global::android.view.ViewGroup._cleanupLayoutState10116 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._attachLayoutAnimationParameters10117 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.view.ViewGroup._removeViewInLayout10118 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._removeViewsInLayout10119 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V");
			global::android.view.ViewGroup._removeViewAt10120 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V");
			global::android.view.ViewGroup._removeViews10121 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViews", "(II)V");
			global::android.view.ViewGroup._removeAllViews10122 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViews", "()V");
			global::android.view.ViewGroup._removeAllViewsInLayout10123 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V");
			global::android.view.ViewGroup._removeDetachedView10124 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V");
			global::android.view.ViewGroup._attachViewToParent10125 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._detachViewFromParent10126 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._detachViewFromParent10127 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V");
			global::android.view.ViewGroup._detachViewsFromParent10128 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V");
			global::android.view.ViewGroup._detachAllViewsFromParent10129 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V");
			global::android.view.ViewGroup._invalidateChild10130 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._invalidateChildInParent10131 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.ViewGroup._offsetDescendantRectToMyCoords10132 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._offsetRectIntoDescendantCoords10133 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._getChildVisibleRect10134 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.ViewGroup._canAnimate10135 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "canAnimate", "()Z");
			global::android.view.ViewGroup._startLayoutAnimation10136 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V");
			global::android.view.ViewGroup._scheduleLayoutAnimation10137 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V");
			global::android.view.ViewGroup._setLayoutAnimation10138 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V");
			global::android.view.ViewGroup._getLayoutAnimation10139 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;");
			global::android.view.ViewGroup._isAnimationCacheEnabled10140 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAnimationCacheEnabled10141 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled10142 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled10143 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled10144 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled10145 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawingOrderEnabled10146 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawingOrderEnabled10147 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V");
			global::android.view.ViewGroup._getPersistentDrawingCache10148 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I");
			global::android.view.ViewGroup._setPersistentDrawingCache10149 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V");
			global::android.view.ViewGroup._generateLayoutParams10150 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateLayoutParams10151 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateDefaultLayoutParams10152 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._indexOfChild10153 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I");
			global::android.view.ViewGroup._getChildCount10154 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildCount", "()I");
			global::android.view.ViewGroup._getChildAt10155 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;");
			global::android.view.ViewGroup._measureChildren10156 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V");
			global::android.view.ViewGroup._measureChild10157 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._measureChildWithMargins10158 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.view.ViewGroup._getChildMeasureSpec10159 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I");
			global::android.view.ViewGroup._clearDisappearingChildren10160 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V");
			global::android.view.ViewGroup._gatherTransparentRegion10161 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.ViewGroup._requestTransparentRegion10162 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getLayoutAnimationListener10163 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;");
			global::android.view.ViewGroup._setAddStatesFromChildren10164 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V");
			global::android.view.ViewGroup._childDrawableStateChanged10165 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._setLayoutAnimationListener10166 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.ViewGroup._ViewGroup10167 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewGroup._ViewGroup10168 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.ViewGroup._ViewGroup10169 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewGroup))]
	public sealed partial class ViewGroup_ : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewGroup_()
		{
			InitJNI();
		}
		internal ViewGroup_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onLayout10170;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup_._onLayout10170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup_.staticClass, global::android.view.ViewGroup_._onLayout10170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewGroup_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup"));
			global::android.view.ViewGroup_._onLayout10170 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup_.staticClass, "onLayout", "(ZIIII)V");
		}
	}
}
