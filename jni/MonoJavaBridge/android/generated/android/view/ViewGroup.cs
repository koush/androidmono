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
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes9484;
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams._setBaseAttributes9484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._setBaseAttributes9484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams9485;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams9485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams9486;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams9486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams9487;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams9487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.FieldId _width9488;
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
			internal static global::MonoJavaBridge.FieldId _height9489;
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
			internal static global::MonoJavaBridge.FieldId _layoutAnimationParameters9490;
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
				global::android.view.ViewGroup.LayoutParams._setBaseAttributes9484 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams9485 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams9486 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams9487 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
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
			internal static global::MonoJavaBridge.MethodId _setMargins9491;
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams._setMargins9491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._setMargins9491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams9492;
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams9493;
			public MarginLayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams9494;
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams9495;
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _leftMargin9496;
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
			internal static global::MonoJavaBridge.FieldId _topMargin9497;
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
			internal static global::MonoJavaBridge.FieldId _rightMargin9498;
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
			internal static global::MonoJavaBridge.FieldId _bottomMargin9499;
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
				global::android.view.ViewGroup.MarginLayoutParams._setMargins9491 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9492 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9493 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9494 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9495 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
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
			internal static global::MonoJavaBridge.MethodId _onChildViewAdded9500;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded9500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded9500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onChildViewRemoved9501;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved9501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved9501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$OnHierarchyChangeListener"));
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded9500 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved9501 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _debug9502;
		protected virtual void debug(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._debug9502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._debug9502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addStatesFromChildren9503;
		public virtual bool addStatesFromChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addStatesFromChildren9503);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addStatesFromChildren9503);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus9504;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocus9504);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocus9504);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent9505;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEvent9505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEvent9505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent9506;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTouchEvent9506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTouchEvent9506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent9507;
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTrackballEvent9507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTrackballEvent9507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent9508;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent9508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent9508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView9509;
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView9509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView9510;
		public virtual void addView(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView9510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addView9511;
		public virtual void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView9511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView9512;
		public virtual void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView9512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView9513;
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView9513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout9514;
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._updateViewLayout9514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._updateViewLayout9514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView9515;
		public virtual void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeView9515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeView9515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus9516;
		public override void clearFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearFocus9516);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearFocus9516);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable9517;
		public override bool hasFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocusable9517);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocusable9517);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus9518;
		public override global::android.view.View findFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._findFocus9518)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._findFocus9518)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows9519;
		protected override bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._fitSystemWindows9519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._fitSystemWindows9519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed9520;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetPressed9520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetPressed9520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch9521;
		public virtual global::android.view.View focusSearch(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._focusSearch9521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusSearch9521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove9522;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchUnhandledMove9522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchUnhandledMove9522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables9523;
		public override void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables9523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables9523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables9524;
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables9524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables9524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables9525;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addTouchables9525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addTouchables9525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus9526;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestFocus9526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestFocus9526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme9527;
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEventPreIme9527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEventPreIme9527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent9528;
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyShortcutEvent9528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyShortcutEvent9528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged9529;
		public override void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowFocusChanged9529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowFocusChanged9529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged9530;
		protected override void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchVisibilityChanged9530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchVisibilityChanged9530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint9531;
		public override void dispatchDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDisplayHint9531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDisplayHint9531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged9532;
		public override void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowVisibilityChanged9532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowVisibilityChanged9532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged9533;
		public override void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchConfigurationChanged9533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchConfigurationChanged9533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw9534;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDraw9534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDraw9534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState9535;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSaveInstanceState9535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSaveInstanceState9535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState9536;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchRestoreInstanceState9536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchRestoreInstanceState9536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout9537;
		protected abstract new void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged9538;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._drawableStateChanged9538);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawableStateChanged9538);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState9539;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._onCreateDrawableState9539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onCreateDrawableState9539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setPadding9540;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPadding9540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPadding9540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected9541;
		public virtual new void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetSelected9541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetSelected9541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart9542;
		protected override void onAnimationStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationStart9542);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationStart9542);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd9543;
		protected override void onAnimationEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationEnd9543);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationEnd9543);
		}
		internal static global::MonoJavaBridge.MethodId _getDescendantFocusability9544;
		public virtual int getDescendantFocusability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getDescendantFocusability9544);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getDescendantFocusability9544);
		}
		internal static global::MonoJavaBridge.MethodId _setDescendantFocusability9545;
		public virtual void setDescendantFocusability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setDescendantFocusability9545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setDescendantFocusability9545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus9546;
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildFocus9546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildFocus9546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _focusableViewAvailable9547;
		public virtual void focusableViewAvailable(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._focusableViewAvailable9547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusableViewAvailable9547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild9548;
		public virtual bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._showContextMenuForChild9548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._showContextMenuForChild9548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen9549;
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildRectangleOnScreen9549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildRectangleOnScreen9549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearChildFocus9550;
		public virtual void clearChildFocus(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearChildFocus9550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearChildFocus9550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedChild9551;
		public virtual global::android.view.View getFocusedChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getFocusedChild9551)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getFocusedChild9551)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _recomputeViewAttributes9552;
		public virtual void recomputeViewAttributes(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._recomputeViewAttributes9552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._recomputeViewAttributes9552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringChildToFront9553;
		public virtual void bringChildToFront(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._bringChildToFront9553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._bringChildToFront9553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestDisallowInterceptTouchEvent9554;
		public virtual void requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent9554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent9554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent9555;
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onInterceptTouchEvent9555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onInterceptTouchEvent9555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants9556;
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onRequestFocusInDescendants9556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onRequestFocusInDescendants9556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchFreezeSelfOnly9557;
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchFreezeSelfOnly9557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchFreezeSelfOnly9557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchThawSelfOnly9558;
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchThawSelfOnly9558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchThawSelfOnly9558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingCacheEnabled9559;
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled9559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled9559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder9560;
		protected virtual int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildDrawingOrder9560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildDrawingOrder9560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild9561;
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._drawChild9561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawChild9561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClipChildren9562;
		public virtual void setClipChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipChildren9562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipChildren9562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClipToPadding9563;
		public virtual void setClipToPadding(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipToPadding9563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipToPadding9563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStaticTransformationsEnabled9564;
		protected virtual void setStaticTransformationsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setStaticTransformationsEnabled9564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setStaticTransformationsEnabled9564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildStaticTransformation9565;
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildStaticTransformation9565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildStaticTransformation9565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams9566;
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._checkLayoutParams9566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._checkLayoutParams9566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener9567;
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setOnHierarchyChangeListener9567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setOnHierarchyChangeListener9567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout9568;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout9568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout9568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout9569;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout9569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout9569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cleanupLayoutState9570;
		protected virtual void cleanupLayoutState(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._cleanupLayoutState9570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._cleanupLayoutState9570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _attachLayoutAnimationParameters9571;
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachLayoutAnimationParameters9571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachLayoutAnimationParameters9571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout9572;
		public virtual void removeViewInLayout(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewInLayout9572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewInLayout9572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout9573;
		public virtual void removeViewsInLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewsInLayout9573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewsInLayout9573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt9574;
		public virtual void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewAt9574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewAt9574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews9575;
		public virtual void removeViews(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViews9575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViews9575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews9576;
		public virtual void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViews9576);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViews9576);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViewsInLayout9577;
		public virtual void removeAllViewsInLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViewsInLayout9577);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViewsInLayout9577);
		}
		internal static global::MonoJavaBridge.MethodId _removeDetachedView9578;
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeDetachedView9578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeDetachedView9578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attachViewToParent9579;
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachViewToParent9579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachViewToParent9579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent9580;
		protected virtual void detachViewFromParent(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent9580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent9580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent9581;
		protected virtual void detachViewFromParent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent9581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent9581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewsFromParent9582;
		protected virtual void detachViewsFromParent(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewsFromParent9582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewsFromParent9582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detachAllViewsFromParent9583;
		protected virtual void detachAllViewsFromParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachAllViewsFromParent9583);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachAllViewsFromParent9583);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChild9584;
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChild9584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChild9584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChildInParent9585;
		public virtual global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChildInParent9585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChildInParent9585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _offsetDescendantRectToMyCoords9586;
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetDescendantRectToMyCoords9586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetDescendantRectToMyCoords9586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetRectIntoDescendantCoords9587;
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetRectIntoDescendantCoords9587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetRectIntoDescendantCoords9587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildVisibleRect9588;
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildVisibleRect9588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildVisibleRect9588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate9589;
		protected virtual bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._canAnimate9589);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._canAnimate9589);
		}
		internal static global::MonoJavaBridge.MethodId _startLayoutAnimation9590;
		public virtual void startLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._startLayoutAnimation9590);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._startLayoutAnimation9590);
		}
		internal static global::MonoJavaBridge.MethodId _scheduleLayoutAnimation9591;
		public virtual void scheduleLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._scheduleLayoutAnimation9591);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._scheduleLayoutAnimation9591);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimation9592;
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimation9592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimation9592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimation9593;
		public virtual global::android.view.animation.LayoutAnimationController getLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimation9593)) as android.view.animation.LayoutAnimationController;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimation9593)) as android.view.animation.LayoutAnimationController;
		}
		internal static global::MonoJavaBridge.MethodId _isAnimationCacheEnabled9594;
		public virtual bool isAnimationCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAnimationCacheEnabled9594);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAnimationCacheEnabled9594);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationCacheEnabled9595;
		public virtual void setAnimationCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAnimationCacheEnabled9595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAnimationCacheEnabled9595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAlwaysDrawnWithCacheEnabled9596;
		public virtual bool isAlwaysDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled9596);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled9596);
		}
		internal static global::MonoJavaBridge.MethodId _setAlwaysDrawnWithCacheEnabled9597;
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled9597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled9597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawnWithCacheEnabled9598;
		protected virtual bool isChildrenDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled9598);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled9598);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawnWithCacheEnabled9599;
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled9599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled9599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawingOrderEnabled9600;
		protected virtual bool isChildrenDrawingOrderEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled9600);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled9600);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingOrderEnabled9601;
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled9601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled9601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistentDrawingCache9602;
		public virtual int getPersistentDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getPersistentDrawingCache9602);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getPersistentDrawingCache9602);
		}
		internal static global::MonoJavaBridge.MethodId _setPersistentDrawingCache9603;
		public virtual void setPersistentDrawingCache(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPersistentDrawingCache9603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPersistentDrawingCache9603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams9604;
		protected virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams9604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams9604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams9605;
		public virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams9605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams9605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams9606;
		protected virtual global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateDefaultLayoutParams9606)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateDefaultLayoutParams9606)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _indexOfChild9607;
		public virtual int indexOfChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._indexOfChild9607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._indexOfChild9607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildCount9608;
		public virtual int getChildCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildCount9608);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildCount9608);
		}
		internal static global::MonoJavaBridge.MethodId _getChildAt9609;
		public virtual global::android.view.View getChildAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getChildAt9609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildAt9609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _measureChildren9610;
		protected virtual void measureChildren(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildren9610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildren9610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild9611;
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChild9611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChild9611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins9612;
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildWithMargins9612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildWithMargins9612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getChildMeasureSpec9613;
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildMeasureSpec9613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearDisappearingChildren9614;
		public virtual void clearDisappearingChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearDisappearingChildren9614);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearDisappearingChildren9614);
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion9615;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._gatherTransparentRegion9615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._gatherTransparentRegion9615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestTransparentRegion9616;
		public virtual void requestTransparentRegion(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestTransparentRegion9616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestTransparentRegion9616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimationListener9617;
		public virtual global::android.view.animation.Animation.AnimationListener getLayoutAnimationListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimationListener9617)) as android.view.animation.Animation.AnimationListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimationListener9617)) as android.view.animation.Animation.AnimationListener;
		}
		internal static global::MonoJavaBridge.MethodId _setAddStatesFromChildren9618;
		public virtual void setAddStatesFromChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAddStatesFromChildren9618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAddStatesFromChildren9618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged9619;
		public virtual void childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._childDrawableStateChanged9619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._childDrawableStateChanged9619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimationListener9620;
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimationListener9620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimationListener9620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup9621;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup9621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup9622;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup9622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup9623;
		public ViewGroup(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup9623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.ViewGroup._debug9502 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "debug", "(I)V");
			global::android.view.ViewGroup._addStatesFromChildren9503 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z");
			global::android.view.ViewGroup._hasFocus9504 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocus", "()Z");
			global::android.view.ViewGroup._dispatchKeyEvent9505 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchTouchEvent9506 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchTrackballEvent9507 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent9508 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.ViewGroup._addView9509 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._addView9510 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._addView9511 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._addView9512 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._addView9513 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._updateViewLayout9514 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._removeView9515 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._clearFocus9516 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearFocus", "()V");
			global::android.view.ViewGroup._hasFocusable9517 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z");
			global::android.view.ViewGroup._findFocus9518 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.ViewGroup._fitSystemWindows9519 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchSetPressed9520 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.ViewGroup._focusSearch9521 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.ViewGroup._dispatchUnhandledMove9522 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.ViewGroup._addFocusables9523 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.ViewGroup._addFocusables9524 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.ViewGroup._addTouchables9525 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.ViewGroup._requestFocus9526 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchKeyEventPreIme9527 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchKeyShortcutEvent9528 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchWindowFocusChanged9529 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.ViewGroup._dispatchVisibilityChanged9530 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._dispatchDisplayHint9531 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.ViewGroup._dispatchWindowVisibilityChanged9532 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.ViewGroup._dispatchConfigurationChanged9533 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.ViewGroup._dispatchDraw9534 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewGroup._dispatchSaveInstanceState9535 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchRestoreInstanceState9536 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._onLayout9537 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.ViewGroup._drawableStateChanged9538 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V");
			global::android.view.ViewGroup._onCreateDrawableState9539 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.ViewGroup._setPadding9540 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V");
			global::android.view.ViewGroup._dispatchSetSelected9541 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.ViewGroup._onAnimationStart9542 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V");
			global::android.view.ViewGroup._onAnimationEnd9543 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V");
			global::android.view.ViewGroup._getDescendantFocusability9544 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I");
			global::android.view.ViewGroup._setDescendantFocusability9545 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V");
			global::android.view.ViewGroup._requestChildFocus9546 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.ViewGroup._focusableViewAvailable9547 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._showContextMenuForChild9548 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.ViewGroup._requestChildRectangleOnScreen9549 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.ViewGroup._clearChildFocus9550 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getFocusedChild9551 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;");
			global::android.view.ViewGroup._recomputeViewAttributes9552 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._bringChildToFront9553 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._requestDisallowInterceptTouchEvent9554 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.ViewGroup._onInterceptTouchEvent9555 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._onRequestFocusInDescendants9556 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchFreezeSelfOnly9557 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchThawSelfOnly9558 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._setChildrenDrawingCacheEnabled9559 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildDrawingOrder9560 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.view.ViewGroup._drawChild9561 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.view.ViewGroup._setClipChildren9562 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V");
			global::android.view.ViewGroup._setClipToPadding9563 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V");
			global::android.view.ViewGroup._setStaticTransformationsEnabled9564 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildStaticTransformation9565 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.view.ViewGroup._checkLayoutParams9566 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._setOnHierarchyChangeListener9567 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.view.ViewGroup._addViewInLayout9568 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._addViewInLayout9569 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z");
			global::android.view.ViewGroup._cleanupLayoutState9570 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._attachLayoutAnimationParameters9571 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.view.ViewGroup._removeViewInLayout9572 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._removeViewsInLayout9573 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V");
			global::android.view.ViewGroup._removeViewAt9574 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V");
			global::android.view.ViewGroup._removeViews9575 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViews", "(II)V");
			global::android.view.ViewGroup._removeAllViews9576 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViews", "()V");
			global::android.view.ViewGroup._removeAllViewsInLayout9577 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V");
			global::android.view.ViewGroup._removeDetachedView9578 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V");
			global::android.view.ViewGroup._attachViewToParent9579 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._detachViewFromParent9580 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._detachViewFromParent9581 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V");
			global::android.view.ViewGroup._detachViewsFromParent9582 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V");
			global::android.view.ViewGroup._detachAllViewsFromParent9583 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V");
			global::android.view.ViewGroup._invalidateChild9584 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._invalidateChildInParent9585 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.ViewGroup._offsetDescendantRectToMyCoords9586 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._offsetRectIntoDescendantCoords9587 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._getChildVisibleRect9588 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.ViewGroup._canAnimate9589 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "canAnimate", "()Z");
			global::android.view.ViewGroup._startLayoutAnimation9590 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V");
			global::android.view.ViewGroup._scheduleLayoutAnimation9591 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V");
			global::android.view.ViewGroup._setLayoutAnimation9592 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V");
			global::android.view.ViewGroup._getLayoutAnimation9593 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;");
			global::android.view.ViewGroup._isAnimationCacheEnabled9594 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAnimationCacheEnabled9595 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled9596 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled9597 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled9598 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled9599 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawingOrderEnabled9600 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawingOrderEnabled9601 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V");
			global::android.view.ViewGroup._getPersistentDrawingCache9602 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I");
			global::android.view.ViewGroup._setPersistentDrawingCache9603 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V");
			global::android.view.ViewGroup._generateLayoutParams9604 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateLayoutParams9605 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateDefaultLayoutParams9606 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._indexOfChild9607 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I");
			global::android.view.ViewGroup._getChildCount9608 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildCount", "()I");
			global::android.view.ViewGroup._getChildAt9609 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;");
			global::android.view.ViewGroup._measureChildren9610 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V");
			global::android.view.ViewGroup._measureChild9611 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._measureChildWithMargins9612 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.view.ViewGroup._getChildMeasureSpec9613 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I");
			global::android.view.ViewGroup._clearDisappearingChildren9614 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V");
			global::android.view.ViewGroup._gatherTransparentRegion9615 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.ViewGroup._requestTransparentRegion9616 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getLayoutAnimationListener9617 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;");
			global::android.view.ViewGroup._setAddStatesFromChildren9618 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V");
			global::android.view.ViewGroup._childDrawableStateChanged9619 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._setLayoutAnimationListener9620 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.ViewGroup._ViewGroup9621 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewGroup._ViewGroup9622 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.ViewGroup._ViewGroup9623 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _onLayout9624;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup_._onLayout9624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup_.staticClass, global::android.view.ViewGroup_._onLayout9624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewGroup_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup"));
			global::android.view.ViewGroup_._onLayout9624 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup_.staticClass, "onLayout", "(ZIIII)V");
		}
	}
}
