namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RelativeLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RelativeLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.lang.String debug(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.widget.RelativeLayout.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void addRule(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(I)V", ref global::android.widget.RelativeLayout.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void addRule(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(II)V", ref global::android.widget.RelativeLayout.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new int[] Rules
			{
				get
				{
					return getRules();
				}
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual int[] getRules()
			{
				return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, "getRules", "()[I", ref global::android.widget.RelativeLayout.LayoutParams._m3) as int[];
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RelativeLayout.LayoutParams._m4.native == global::System.IntPtr.Zero)
					global::android.widget.RelativeLayout.LayoutParams._m4 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RelativeLayout.LayoutParams._m5.native == global::System.IntPtr.Zero)
					global::android.widget.RelativeLayout.LayoutParams._m5 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RelativeLayout.LayoutParams._m6.native == global::System.IntPtr.Zero)
					global::android.widget.RelativeLayout.LayoutParams._m6 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.RelativeLayout.LayoutParams._m7.native == global::System.IntPtr.Zero)
					global::android.widget.RelativeLayout.LayoutParams._m7 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _alignWithParent6084;
			public bool alignWithParent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _alignWithParent6084);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RelativeLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RelativeLayout$LayoutParams"));
				global::android.widget.RelativeLayout.LayoutParams._alignWithParent6084 = @__env.GetFieldIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "alignWithParent", "Z");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RelativeLayout.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.widget.RelativeLayout._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Gravity
		{
			set
			{
				setGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.staticClass, "setGravity", "(I)V", ref global::android.widget.RelativeLayout._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.RelativeLayout._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.RelativeLayout.staticClass, "getBaseline", "()I", ref global::android.widget.RelativeLayout._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.staticClass, "requestLayout", "()V", ref global::android.widget.RelativeLayout._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.staticClass, "onMeasure", "(II)V", ref global::android.widget.RelativeLayout._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.RelativeLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.RelativeLayout._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.widget.RelativeLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;", ref global::android.widget.RelativeLayout._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.RelativeLayout.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.RelativeLayout._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.RelativeLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.RelativeLayout._m9) as android.view.ViewGroup.LayoutParams;
		}
		public new int HorizontalGravity
		{
			set
			{
				setHorizontalGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setHorizontalGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.staticClass, "setHorizontalGravity", "(I)V", ref global::android.widget.RelativeLayout._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalGravity
		{
			set
			{
				setVerticalGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setVerticalGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.staticClass, "setVerticalGravity", "(I)V", ref global::android.widget.RelativeLayout._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IgnoreGravity
		{
			set
			{
				setIgnoreGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setIgnoreGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.RelativeLayout.staticClass, "setIgnoreGravity", "(I)V", ref global::android.widget.RelativeLayout._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public RelativeLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RelativeLayout._m13.native == global::System.IntPtr.Zero)
				global::android.widget.RelativeLayout._m13 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RelativeLayout._m14.native == global::System.IntPtr.Zero)
				global::android.widget.RelativeLayout._m14 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.RelativeLayout._m15.native == global::System.IntPtr.Zero)
				global::android.widget.RelativeLayout._m15 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int TRUE
		{
			get
			{
				return -1;
			}
		}
		public static int LEFT_OF
		{
			get
			{
				return 0;
			}
		}
		public static int RIGHT_OF
		{
			get
			{
				return 1;
			}
		}
		public static int ABOVE
		{
			get
			{
				return 2;
			}
		}
		public static int BELOW
		{
			get
			{
				return 3;
			}
		}
		public static int ALIGN_BASELINE
		{
			get
			{
				return 4;
			}
		}
		public static int ALIGN_LEFT
		{
			get
			{
				return 5;
			}
		}
		public static int ALIGN_TOP
		{
			get
			{
				return 6;
			}
		}
		public static int ALIGN_RIGHT
		{
			get
			{
				return 7;
			}
		}
		public static int ALIGN_BOTTOM
		{
			get
			{
				return 8;
			}
		}
		public static int ALIGN_PARENT_LEFT
		{
			get
			{
				return 9;
			}
		}
		public static int ALIGN_PARENT_TOP
		{
			get
			{
				return 10;
			}
		}
		public static int ALIGN_PARENT_RIGHT
		{
			get
			{
				return 11;
			}
		}
		public static int ALIGN_PARENT_BOTTOM
		{
			get
			{
				return 12;
			}
		}
		public static int CENTER_IN_PARENT
		{
			get
			{
				return 13;
			}
		}
		public static int CENTER_HORIZONTAL
		{
			get
			{
				return 14;
			}
		}
		public static int CENTER_VERTICAL
		{
			get
			{
				return 15;
			}
		}
		static RelativeLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RelativeLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RelativeLayout"));
		}
		internal static void InitJNI()
		{
		}
	}
}
