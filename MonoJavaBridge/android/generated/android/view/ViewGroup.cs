namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.ViewGroup_))]
	public abstract partial class ViewGroup : android.view.View, ViewParent, ViewManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewGroup(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class LayoutParams : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", ref global::android.view.ViewGroup.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewGroup.LayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.view.ViewGroup.LayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewGroup.LayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.view.ViewGroup.LayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewGroup.LayoutParams._m3.native == global::System.IntPtr.Zero)
					global::android.view.ViewGroup.LayoutParams._m3 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.FieldId _width5731;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width5731);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height5732;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height5732);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _layoutAnimationParameters5733;
			public global::android.view.animation.LayoutAnimationController.AnimationParameters layoutAnimationParameters
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _layoutAnimationParameters5733)) as android.view.animation.LayoutAnimationController.AnimationParameters;
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$LayoutParams"));
				global::android.view.ViewGroup.LayoutParams._width5731 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "width", "I");
				global::android.view.ViewGroup.LayoutParams._height5732 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "height", "I");
				global::android.view.ViewGroup.LayoutParams._layoutAnimationParameters5733 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.LayoutParams.staticClass, "layoutAnimationParameters", "Landroid/view/animation/LayoutAnimationController$AnimationParameters;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MarginLayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MarginLayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V", ref global::android.view.ViewGroup.MarginLayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewGroup.MarginLayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.view.ViewGroup.MarginLayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public MarginLayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewGroup.MarginLayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.view.ViewGroup.MarginLayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewGroup.MarginLayoutParams._m3.native == global::System.IntPtr.Zero)
					global::android.view.ViewGroup.MarginLayoutParams._m3 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewGroup.MarginLayoutParams._m4.native == global::System.IntPtr.Zero)
					global::android.view.ViewGroup.MarginLayoutParams._m4 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _leftMargin5734;
			public int leftMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _leftMargin5734);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _topMargin5735;
			public int topMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _topMargin5735);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _rightMargin5736;
			public int rightMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _rightMargin5736);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottomMargin5737;
			public int bottomMargin
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _bottomMargin5737);
				}
				set
				{
				}
			}
			static MarginLayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.MarginLayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$MarginLayoutParams"));
				global::android.view.ViewGroup.MarginLayoutParams._leftMargin5734 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "leftMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._topMargin5735 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "topMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._rightMargin5736 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "rightMargin", "I");
				global::android.view.ViewGroup.MarginLayoutParams._bottomMargin5737 = @__env.GetFieldIDNoThrow(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "bottomMargin", "I");
			}
			internal static void InitJNI()
			{
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
			internal OnHierarchyChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded(android.view.View arg0, android.view.View arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.view.ViewGroup.OnHierarchyChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved(android.view.View arg0, android.view.View arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.view.ViewGroup.OnHierarchyChangeListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnHierarchyChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewGroup.OnHierarchyChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup$OnHierarchyChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual void debug(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "debug", "(I)V", ref global::android.view.ViewGroup._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool addStatesFromChildren()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z", ref global::android.view.ViewGroup._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool hasFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "hasFocus", "()Z", ref global::android.view.ViewGroup._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.ViewGroup._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.ViewGroup._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.ViewGroup._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.view.ViewGroup._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.ViewGroup._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void addView(android.view.View arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V", ref global::android.view.ViewGroup._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void addView(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V", ref global::android.view.ViewGroup._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.ViewGroup._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.ViewGroup._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void removeView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void clearFocus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "clearFocus", "()V", ref global::android.view.ViewGroup._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override bool hasFocusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z", ref global::android.view.ViewGroup._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::android.view.View findFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;", ref global::android.view.ViewGroup._m16) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected override bool fitSystemWindows(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z", ref global::android.view.ViewGroup._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected override void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V", ref global::android.view.ViewGroup._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::android.view.View focusSearch(android.view.View arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;", ref global::android.view.ViewGroup._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z", ref global::android.view.ViewGroup._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override void addFocusables(java.util.ArrayList arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V", ref global::android.view.ViewGroup._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V", ref global::android.view.ViewGroup._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override void addTouchables(java.util.ArrayList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V", ref global::android.view.ViewGroup._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z", ref global::android.view.ViewGroup._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z", ref global::android.view.ViewGroup._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.ViewGroup._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override void dispatchWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V", ref global::android.view.ViewGroup._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		protected override void dispatchVisibilityChanged(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V", ref global::android.view.ViewGroup._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override void dispatchDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchDisplayHint", "(I)V", ref global::android.view.ViewGroup._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override void dispatchWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V", ref global::android.view.ViewGroup._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override void dispatchConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.view.ViewGroup._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.view.ViewGroup._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.view.ViewGroup._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.view.ViewGroup._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		protected abstract void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4);
		private static global::MonoJavaBridge.MethodId _m36;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V", ref global::android.view.ViewGroup._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		protected override int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.view.ViewGroup._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V", ref global::android.view.ViewGroup._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void dispatchSetSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V", ref global::android.view.ViewGroup._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		protected override void onAnimationStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V", ref global::android.view.ViewGroup._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		protected override void onAnimationEnd()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V", ref global::android.view.ViewGroup._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual int getDescendantFocusability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I", ref global::android.view.ViewGroup._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void setDescendantFocusability(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V", ref global::android.view.ViewGroup._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.view.ViewGroup._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void focusableViewAvailable(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual bool showContextMenuForChild(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z", ref global::android.view.ViewGroup._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", ref global::android.view.ViewGroup._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual void clearChildFocus(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual global::android.view.View getFocusedChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;", ref global::android.view.ViewGroup._m49) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual void recomputeViewAttributes(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void bringChildToFront(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual void requestDisallowInterceptTouchEvent(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V", ref global::android.view.ViewGroup._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.ViewGroup._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", ref global::android.view.ViewGroup._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V", ref global::android.view.ViewGroup._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V", ref global::android.view.ViewGroup._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V", ref global::android.view.ViewGroup._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		protected virtual int getChildDrawingOrder(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I", ref global::android.view.ViewGroup._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", ref global::android.view.ViewGroup._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void setClipChildren(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V", ref global::android.view.ViewGroup._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void setClipToPadding(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V", ref global::android.view.ViewGroup._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		protected virtual void setStaticTransformationsEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V", ref global::android.view.ViewGroup._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z", ref global::android.view.ViewGroup._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.view.ViewGroup._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", ref global::android.view.ViewGroup._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z", ref global::android.view.ViewGroup._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z", ref global::android.view.ViewGroup._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		protected virtual void cleanupLayoutState(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V", ref global::android.view.ViewGroup._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual void removeViewInLayout(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual void removeViewsInLayout(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V", ref global::android.view.ViewGroup._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual void removeViewAt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V", ref global::android.view.ViewGroup._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual void removeViews(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeViews", "(II)V", ref global::android.view.ViewGroup._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual void removeAllViews()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeAllViews", "()V", ref global::android.view.ViewGroup._m74);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual void removeAllViewsInLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V", ref global::android.view.ViewGroup._m75);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V", ref global::android.view.ViewGroup._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.ViewGroup._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		protected virtual void detachViewFromParent(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		protected virtual void detachViewFromParent(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V", ref global::android.view.ViewGroup._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		protected virtual void detachViewsFromParent(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V", ref global::android.view.ViewGroup._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		protected virtual void detachAllViewsFromParent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V", ref global::android.view.ViewGroup._m81);
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V", ref global::android.view.ViewGroup._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ViewParent>(this, global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;", ref global::android.view.ViewGroup._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.ViewParent;
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V", ref global::android.view.ViewGroup._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V", ref global::android.view.ViewGroup._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z", ref global::android.view.ViewGroup._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		protected virtual bool canAnimate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "canAnimate", "()Z", ref global::android.view.ViewGroup._m87);
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public virtual void startLayoutAnimation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V", ref global::android.view.ViewGroup._m88);
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public virtual void scheduleLayoutAnimation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V", ref global::android.view.ViewGroup._m89);
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V", ref global::android.view.ViewGroup._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public virtual global::android.view.animation.LayoutAnimationController getLayoutAnimation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;", ref global::android.view.ViewGroup._m91) as android.view.animation.LayoutAnimationController;
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public virtual bool isAnimationCacheEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z", ref global::android.view.ViewGroup._m92);
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public virtual void setAnimationCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V", ref global::android.view.ViewGroup._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public virtual bool isAlwaysDrawnWithCacheEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z", ref global::android.view.ViewGroup._m94);
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V", ref global::android.view.ViewGroup._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		protected virtual bool isChildrenDrawnWithCacheEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z", ref global::android.view.ViewGroup._m96);
		}
		private static global::MonoJavaBridge.MethodId _m97;
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V", ref global::android.view.ViewGroup._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		protected virtual bool isChildrenDrawingOrderEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z", ref global::android.view.ViewGroup._m98);
		}
		private static global::MonoJavaBridge.MethodId _m99;
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V", ref global::android.view.ViewGroup._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public virtual int getPersistentDrawingCache()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I", ref global::android.view.ViewGroup._m100);
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public virtual void setPersistentDrawingCache(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V", ref global::android.view.ViewGroup._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m102;
		protected virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.view.ViewGroup._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.view.ViewGroup._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m104;
		protected virtual global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.view.ViewGroup._m104) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public virtual int indexOfChild(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I", ref global::android.view.ViewGroup._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public virtual int getChildCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewGroup.staticClass, "getChildCount", "()I", ref global::android.view.ViewGroup._m106);
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public virtual global::android.view.View getChildAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;", ref global::android.view.ViewGroup._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m108;
		protected virtual void measureChildren(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V", ref global::android.view.ViewGroup._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V", ref global::android.view.ViewGroup._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V", ref global::android.view.ViewGroup._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewGroup._m111.native == global::System.IntPtr.Zero)
				global::android.view.ViewGroup._m111 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I");
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public virtual void clearDisappearingChildren()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V", ref global::android.view.ViewGroup._m112);
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z", ref global::android.view.ViewGroup._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public virtual void requestTransparentRegion(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public virtual global::android.view.animation.Animation.AnimationListener getLayoutAnimationListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.animation.Animation.AnimationListener>(this, global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;", ref global::android.view.ViewGroup._m115) as android.view.animation.Animation.AnimationListener;
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public virtual void setAddStatesFromChildren(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V", ref global::android.view.ViewGroup._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		public virtual void childDrawableStateChanged(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V", ref global::android.view.ViewGroup._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", ref global::android.view.ViewGroup._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewGroup._m119.native == global::System.IntPtr.Zero)
				global::android.view.ViewGroup._m119 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m120;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewGroup._m120.native == global::System.IntPtr.Zero)
				global::android.view.ViewGroup._m120 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m121;
		public ViewGroup(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewGroup._m121.native == global::System.IntPtr.Zero)
				global::android.view.ViewGroup._m121 = @__env.GetMethodIDNoThrow(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static ViewGroup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewGroup.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewGroup))]
	internal sealed partial class ViewGroup_ : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ViewGroup_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewGroup_.staticClass, "onLayout", "(ZIIII)V", ref global::android.view.ViewGroup_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		static ViewGroup_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewGroup_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewGroup"));
		}
		internal static void InitJNI()
		{
		}
	}
}
