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
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes14960;
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams._setBaseAttributes14960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._setBaseAttributes14960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams14961;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams14961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams14962;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams14962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams14963;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams14963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.FieldId _width14967;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width14967);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height14968;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height14968);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _layoutAnimationParameters14969;
			public global::android.view.animation.LayoutAnimationController.AnimationParameters layoutAnimationParameters
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _layoutAnimationParameters14969)) as android.view.animation.LayoutAnimationController.AnimationParameters;
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$LayoutParams"));
				global::android.view.ViewGroup.LayoutParams._setBaseAttributes14960 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams14961 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams14962 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams14963 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.view.ViewGroup.LayoutParams._width14967 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "width", "I");
				global::android.view.ViewGroup.LayoutParams._height14968 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "height", "I");
				global::android.view.ViewGroup.LayoutParams._layoutAnimationParameters14969 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "layoutAnimationParameters", "Landroid/view/animation/LayoutAnimationController$AnimationParameters;");
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
			internal static global::MonoJavaBridge.MethodId _setMargins14970;
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams._setMargins14970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._setMargins14970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams14971;
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams14972;
			public MarginLayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams14973;
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _MarginLayoutParams14974;
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _leftMargin14975;
			public int leftMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _leftMargin14975);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _topMargin14976;
			public int topMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _topMargin14976);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rightMargin14977;
			public int rightMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rightMargin14977);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottomMargin14978;
			public int bottomMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _bottomMargin14978);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.MarginLayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$MarginLayoutParams"));
				global::android.view.ViewGroup.MarginLayoutParams._setMargins14970 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14971 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14972 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14973 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams14974 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.view.ViewGroup.MarginLayoutParams._leftMargin14975 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "leftMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._topMargin14976 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "topMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._rightMargin14977 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "rightMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._bottomMargin14978 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "bottomMargin", "I");
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
			internal static global::MonoJavaBridge.MethodId _onChildViewAdded14979;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded14979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded14979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onChildViewRemoved14980;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved14980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved14980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$OnHierarchyChangeListener"));
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewAdded14979 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
				global::android.view.ViewGroup.OnHierarchyChangeListener_._onChildViewRemoved14980 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _debug14981;
		protected virtual void debug(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._debug14981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._debug14981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addStatesFromChildren14982;
		public virtual bool addStatesFromChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addStatesFromChildren14982);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addStatesFromChildren14982);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus14983;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocus14983);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocus14983);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent14984;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEvent14984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEvent14984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent14985;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTouchEvent14985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTouchEvent14985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent14986;
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchTrackballEvent14986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTrackballEvent14986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent14987;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent14987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent14987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView14988;
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView14988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView14988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView14989;
		public virtual void addView(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView14989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView14989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addView14990;
		public virtual void addView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView14990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView14990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView14991;
		public virtual void addView(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView14991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView14991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView14992;
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addView14992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView14992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout14993;
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._updateViewLayout14993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._updateViewLayout14993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView14994;
		public virtual void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeView14994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeView14994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFocus14995;
		public override void clearFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearFocus14995);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearFocus14995);
		}
		internal static global::MonoJavaBridge.MethodId _hasFocusable14996;
		public override bool hasFocusable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._hasFocusable14996);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocusable14996);
		}
		internal static global::MonoJavaBridge.MethodId _findFocus14997;
		public override global::android.view.View findFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._findFocus14997)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._findFocus14997)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _fitSystemWindows14998;
		protected override bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._fitSystemWindows14998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._fitSystemWindows14998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetPressed14999;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetPressed14999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetPressed14999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _focusSearch15000;
		public virtual global::android.view.View focusSearch(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._focusSearch15000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusSearch15000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove15001;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchUnhandledMove15001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchUnhandledMove15001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables15002;
		public override void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables15002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables15002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFocusables15003;
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addFocusables15003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables15003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addTouchables15004;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._addTouchables15004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addTouchables15004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus15005;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestFocus15005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestFocus15005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEventPreIme15006;
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyEventPreIme15006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEventPreIme15006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyShortcutEvent15007;
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchKeyShortcutEvent15007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyShortcutEvent15007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowFocusChanged15008;
		public override void dispatchWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowFocusChanged15008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowFocusChanged15008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchVisibilityChanged15009;
		protected override void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchVisibilityChanged15009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchVisibilityChanged15009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDisplayHint15010;
		public override void dispatchDisplayHint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDisplayHint15010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDisplayHint15010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchWindowVisibilityChanged15011;
		public override void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchWindowVisibilityChanged15011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowVisibilityChanged15011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchConfigurationChanged15012;
		public override void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchConfigurationChanged15012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchConfigurationChanged15012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchDraw15013;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchDraw15013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDraw15013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSaveInstanceState15014;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSaveInstanceState15014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSaveInstanceState15014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchRestoreInstanceState15015;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchRestoreInstanceState15015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchRestoreInstanceState15015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout15016;
		protected abstract void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged15017;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._drawableStateChanged15017);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawableStateChanged15017);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState15018;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._onCreateDrawableState15018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onCreateDrawableState15018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setPadding15019;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPadding15019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPadding15019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchSetSelected15020;
		public virtual void dispatchSetSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchSetSelected15020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetSelected15020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationStart15021;
		protected override void onAnimationStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationStart15021);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationStart15021);
		}
		internal static global::MonoJavaBridge.MethodId _onAnimationEnd15022;
		protected override void onAnimationEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._onAnimationEnd15022);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationEnd15022);
		}
		internal static global::MonoJavaBridge.MethodId _getDescendantFocusability15023;
		public virtual int getDescendantFocusability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getDescendantFocusability15023);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getDescendantFocusability15023);
		}
		internal static global::MonoJavaBridge.MethodId _setDescendantFocusability15024;
		public virtual void setDescendantFocusability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setDescendantFocusability15024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setDescendantFocusability15024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildFocus15025;
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildFocus15025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildFocus15025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _focusableViewAvailable15026;
		public virtual void focusableViewAvailable(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._focusableViewAvailable15026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusableViewAvailable15026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _showContextMenuForChild15027;
		public virtual bool showContextMenuForChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._showContextMenuForChild15027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._showContextMenuForChild15027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen15028;
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._requestChildRectangleOnScreen15028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildRectangleOnScreen15028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearChildFocus15029;
		public virtual void clearChildFocus(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearChildFocus15029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearChildFocus15029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFocusedChild15030;
		public virtual global::android.view.View getFocusedChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getFocusedChild15030)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getFocusedChild15030)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _recomputeViewAttributes15031;
		public virtual void recomputeViewAttributes(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._recomputeViewAttributes15031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._recomputeViewAttributes15031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bringChildToFront15032;
		public virtual void bringChildToFront(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._bringChildToFront15032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._bringChildToFront15032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestDisallowInterceptTouchEvent15033;
		public virtual void requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent15033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent15033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onInterceptTouchEvent15034;
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onInterceptTouchEvent15034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onInterceptTouchEvent15034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocusInDescendants15035;
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._onRequestFocusInDescendants15035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onRequestFocusInDescendants15035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchFreezeSelfOnly15036;
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchFreezeSelfOnly15036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchFreezeSelfOnly15036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchThawSelfOnly15037;
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._dispatchThawSelfOnly15037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchThawSelfOnly15037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingCacheEnabled15038;
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled15038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled15038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildDrawingOrder15039;
		protected virtual int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildDrawingOrder15039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildDrawingOrder15039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild15040;
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._drawChild15040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawChild15040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClipChildren15041;
		public virtual void setClipChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipChildren15041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipChildren15041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setClipToPadding15042;
		public virtual void setClipToPadding(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setClipToPadding15042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipToPadding15042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStaticTransformationsEnabled15043;
		protected virtual void setStaticTransformationsEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setStaticTransformationsEnabled15043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setStaticTransformationsEnabled15043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildStaticTransformation15044;
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildStaticTransformation15044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildStaticTransformation15044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams15045;
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._checkLayoutParams15045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._checkLayoutParams15045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener15046;
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setOnHierarchyChangeListener15046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setOnHierarchyChangeListener15046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout15047;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout15047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout15047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addViewInLayout15048;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._addViewInLayout15048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout15048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _cleanupLayoutState15049;
		protected virtual void cleanupLayoutState(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._cleanupLayoutState15049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._cleanupLayoutState15049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _attachLayoutAnimationParameters15050;
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachLayoutAnimationParameters15050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachLayoutAnimationParameters15050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout15051;
		public virtual void removeViewInLayout(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewInLayout15051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewInLayout15051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout15052;
		public virtual void removeViewsInLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewsInLayout15052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewsInLayout15052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt15053;
		public virtual void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViewAt15053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewAt15053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews15054;
		public virtual void removeViews(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeViews15054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViews15054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews15055;
		public virtual void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViews15055);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViews15055);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViewsInLayout15056;
		public virtual void removeAllViewsInLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeAllViewsInLayout15056);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViewsInLayout15056);
		}
		internal static global::MonoJavaBridge.MethodId _removeDetachedView15057;
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._removeDetachedView15057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeDetachedView15057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attachViewToParent15058;
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._attachViewToParent15058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachViewToParent15058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent15059;
		protected virtual void detachViewFromParent(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent15059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent15059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewFromParent15060;
		protected virtual void detachViewFromParent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewFromParent15060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent15060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _detachViewsFromParent15061;
		protected virtual void detachViewsFromParent(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachViewsFromParent15061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewsFromParent15061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _detachAllViewsFromParent15062;
		protected virtual void detachAllViewsFromParent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._detachAllViewsFromParent15062);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachAllViewsFromParent15062);
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChild15063;
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChild15063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChild15063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateChildInParent15064;
		public virtual global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._invalidateChildInParent15064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.ViewParent>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChildInParent15064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.ViewParent;
		}
		internal static global::MonoJavaBridge.MethodId _offsetDescendantRectToMyCoords15065;
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetDescendantRectToMyCoords15065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetDescendantRectToMyCoords15065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offsetRectIntoDescendantCoords15066;
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._offsetRectIntoDescendantCoords15066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetRectIntoDescendantCoords15066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildVisibleRect15067;
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._getChildVisibleRect15067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildVisibleRect15067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canAnimate15068;
		protected virtual bool canAnimate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._canAnimate15068);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._canAnimate15068);
		}
		internal static global::MonoJavaBridge.MethodId _startLayoutAnimation15069;
		public virtual void startLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._startLayoutAnimation15069);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._startLayoutAnimation15069);
		}
		internal static global::MonoJavaBridge.MethodId _scheduleLayoutAnimation15070;
		public virtual void scheduleLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._scheduleLayoutAnimation15070);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._scheduleLayoutAnimation15070);
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimation15071;
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimation15071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimation15071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimation15072;
		public virtual global::android.view.animation.LayoutAnimationController getLayoutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimation15072)) as android.view.animation.LayoutAnimationController;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimation15072)) as android.view.animation.LayoutAnimationController;
		}
		internal static global::MonoJavaBridge.MethodId _isAnimationCacheEnabled15073;
		public virtual bool isAnimationCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAnimationCacheEnabled15073);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAnimationCacheEnabled15073);
		}
		internal static global::MonoJavaBridge.MethodId _setAnimationCacheEnabled15074;
		public virtual void setAnimationCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAnimationCacheEnabled15074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAnimationCacheEnabled15074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAlwaysDrawnWithCacheEnabled15075;
		public virtual bool isAlwaysDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled15075);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled15075);
		}
		internal static global::MonoJavaBridge.MethodId _setAlwaysDrawnWithCacheEnabled15076;
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled15076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled15076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawnWithCacheEnabled15077;
		protected virtual bool isChildrenDrawnWithCacheEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled15077);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled15077);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawnWithCacheEnabled15078;
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled15078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled15078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isChildrenDrawingOrderEnabled15079;
		protected virtual bool isChildrenDrawingOrderEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled15079);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled15079);
		}
		internal static global::MonoJavaBridge.MethodId _setChildrenDrawingOrderEnabled15080;
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled15080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled15080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPersistentDrawingCache15081;
		public virtual int getPersistentDrawingCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getPersistentDrawingCache15081);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getPersistentDrawingCache15081);
		}
		internal static global::MonoJavaBridge.MethodId _setPersistentDrawingCache15082;
		public virtual void setPersistentDrawingCache(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setPersistentDrawingCache15082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPersistentDrawingCache15082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams15083;
		protected virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams15083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams15083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams15084;
		public virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateLayoutParams15084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams15084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams15085;
		protected virtual global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._generateDefaultLayoutParams15085)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateDefaultLayoutParams15085)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _indexOfChild15086;
		public virtual int indexOfChild(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._indexOfChild15086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._indexOfChild15086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChildCount15087;
		public virtual int getChildCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewGroup._getChildCount15087);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildCount15087);
		}
		internal static global::MonoJavaBridge.MethodId _getChildAt15088;
		public virtual global::android.view.View getChildAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getChildAt15088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildAt15088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _measureChildren15089;
		protected virtual void measureChildren(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildren15089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildren15089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _measureChild15090;
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChild15090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChild15090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _measureChildWithMargins15091;
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._measureChildWithMargins15091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildWithMargins15091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _getChildMeasureSpec15092;
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildMeasureSpec15092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearDisappearingChildren15093;
		public virtual void clearDisappearingChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._clearDisappearingChildren15093);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearDisappearingChildren15093);
		}
		internal static global::MonoJavaBridge.MethodId _gatherTransparentRegion15094;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewGroup._gatherTransparentRegion15094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._gatherTransparentRegion15094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestTransparentRegion15095;
		public virtual void requestTransparentRegion(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._requestTransparentRegion15095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestTransparentRegion15095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutAnimationListener15096;
		public virtual global::android.view.animation.Animation.AnimationListener getLayoutAnimationListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewGroup._getLayoutAnimationListener15096)) as android.view.animation.Animation.AnimationListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Animation.AnimationListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimationListener15096)) as android.view.animation.Animation.AnimationListener;
		}
		internal static global::MonoJavaBridge.MethodId _setAddStatesFromChildren15097;
		public virtual void setAddStatesFromChildren(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setAddStatesFromChildren15097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAddStatesFromChildren15097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childDrawableStateChanged15098;
		public virtual void childDrawableStateChanged(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._childDrawableStateChanged15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._childDrawableStateChanged15098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutAnimationListener15099;
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup._setLayoutAnimationListener15099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimationListener15099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup15100;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup15100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup15101;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup15101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewGroup15102;
		public ViewGroup(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup15102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.ViewGroup._debug14981 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "debug", "(I)V");
			global::android.view.ViewGroup._addStatesFromChildren14982 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z");
			global::android.view.ViewGroup._hasFocus14983 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocus", "()Z");
			global::android.view.ViewGroup._dispatchKeyEvent14984 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchTouchEvent14985 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchTrackballEvent14986 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent14987 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.ViewGroup._addView14988 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._addView14989 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._addView14990 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._addView14991 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._addView14992 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._updateViewLayout14993 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._removeView14994 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._clearFocus14995 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearFocus", "()V");
			global::android.view.ViewGroup._hasFocusable14996 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z");
			global::android.view.ViewGroup._findFocus14997 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.ViewGroup._fitSystemWindows14998 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchSetPressed14999 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.ViewGroup._focusSearch15000 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.ViewGroup._dispatchUnhandledMove15001 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.ViewGroup._addFocusables15002 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.ViewGroup._addFocusables15003 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.ViewGroup._addTouchables15004 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.ViewGroup._requestFocus15005 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchKeyEventPreIme15006 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchKeyShortcutEvent15007 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchWindowFocusChanged15008 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.ViewGroup._dispatchVisibilityChanged15009 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._dispatchDisplayHint15010 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.ViewGroup._dispatchWindowVisibilityChanged15011 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.ViewGroup._dispatchConfigurationChanged15012 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.ViewGroup._dispatchDraw15013 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewGroup._dispatchSaveInstanceState15014 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchRestoreInstanceState15015 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._onLayout15016 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.ViewGroup._drawableStateChanged15017 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V");
			global::android.view.ViewGroup._onCreateDrawableState15018 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.ViewGroup._setPadding15019 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V");
			global::android.view.ViewGroup._dispatchSetSelected15020 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.ViewGroup._onAnimationStart15021 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V");
			global::android.view.ViewGroup._onAnimationEnd15022 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V");
			global::android.view.ViewGroup._getDescendantFocusability15023 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I");
			global::android.view.ViewGroup._setDescendantFocusability15024 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V");
			global::android.view.ViewGroup._requestChildFocus15025 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.ViewGroup._focusableViewAvailable15026 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._showContextMenuForChild15027 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.ViewGroup._requestChildRectangleOnScreen15028 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.ViewGroup._clearChildFocus15029 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getFocusedChild15030 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;");
			global::android.view.ViewGroup._recomputeViewAttributes15031 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._bringChildToFront15032 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._requestDisallowInterceptTouchEvent15033 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.ViewGroup._onInterceptTouchEvent15034 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._onRequestFocusInDescendants15035 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchFreezeSelfOnly15036 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchThawSelfOnly15037 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._setChildrenDrawingCacheEnabled15038 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildDrawingOrder15039 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.view.ViewGroup._drawChild15040 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.view.ViewGroup._setClipChildren15041 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V");
			global::android.view.ViewGroup._setClipToPadding15042 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V");
			global::android.view.ViewGroup._setStaticTransformationsEnabled15043 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildStaticTransformation15044 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.view.ViewGroup._checkLayoutParams15045 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._setOnHierarchyChangeListener15046 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.view.ViewGroup._addViewInLayout15047 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._addViewInLayout15048 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z");
			global::android.view.ViewGroup._cleanupLayoutState15049 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._attachLayoutAnimationParameters15050 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.view.ViewGroup._removeViewInLayout15051 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._removeViewsInLayout15052 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V");
			global::android.view.ViewGroup._removeViewAt15053 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V");
			global::android.view.ViewGroup._removeViews15054 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeViews", "(II)V");
			global::android.view.ViewGroup._removeAllViews15055 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViews", "()V");
			global::android.view.ViewGroup._removeAllViewsInLayout15056 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V");
			global::android.view.ViewGroup._removeDetachedView15057 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V");
			global::android.view.ViewGroup._attachViewToParent15058 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._detachViewFromParent15059 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._detachViewFromParent15060 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V");
			global::android.view.ViewGroup._detachViewsFromParent15061 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V");
			global::android.view.ViewGroup._detachAllViewsFromParent15062 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V");
			global::android.view.ViewGroup._invalidateChild15063 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._invalidateChildInParent15064 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.ViewGroup._offsetDescendantRectToMyCoords15065 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._offsetRectIntoDescendantCoords15066 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._getChildVisibleRect15067 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.ViewGroup._canAnimate15068 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "canAnimate", "()Z");
			global::android.view.ViewGroup._startLayoutAnimation15069 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V");
			global::android.view.ViewGroup._scheduleLayoutAnimation15070 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V");
			global::android.view.ViewGroup._setLayoutAnimation15071 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V");
			global::android.view.ViewGroup._getLayoutAnimation15072 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;");
			global::android.view.ViewGroup._isAnimationCacheEnabled15073 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAnimationCacheEnabled15074 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled15075 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled15076 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled15077 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled15078 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawingOrderEnabled15079 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawingOrderEnabled15080 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V");
			global::android.view.ViewGroup._getPersistentDrawingCache15081 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I");
			global::android.view.ViewGroup._setPersistentDrawingCache15082 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V");
			global::android.view.ViewGroup._generateLayoutParams15083 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateLayoutParams15084 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateDefaultLayoutParams15085 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._indexOfChild15086 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I");
			global::android.view.ViewGroup._getChildCount15087 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildCount", "()I");
			global::android.view.ViewGroup._getChildAt15088 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;");
			global::android.view.ViewGroup._measureChildren15089 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V");
			global::android.view.ViewGroup._measureChild15090 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._measureChildWithMargins15091 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.view.ViewGroup._getChildMeasureSpec15092 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I");
			global::android.view.ViewGroup._clearDisappearingChildren15093 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V");
			global::android.view.ViewGroup._gatherTransparentRegion15094 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.ViewGroup._requestTransparentRegion15095 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getLayoutAnimationListener15096 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;");
			global::android.view.ViewGroup._setAddStatesFromChildren15097 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V");
			global::android.view.ViewGroup._childDrawableStateChanged15098 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._setLayoutAnimationListener15099 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.ViewGroup._ViewGroup15100 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewGroup._ViewGroup15101 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.ViewGroup._ViewGroup15102 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _onLayout15110;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewGroup_._onLayout15110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewGroup_.staticClass, global::android.view.ViewGroup_._onLayout15110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewGroup_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup"));
			global::android.view.ViewGroup_._onLayout15110 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup_.staticClass, "onLayout", "(ZIIII)V");
		}
	}
}
